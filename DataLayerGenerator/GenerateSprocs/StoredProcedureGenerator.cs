using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;
using Microsoft.SqlServer.Management.Smo;

namespace DataLayerGenerator.GenerateSprocs
{
    public static class StoredProcedureGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        public static void GenerateProcedures()
        {
            var server = new Server(@"VIRTUALHOST\SQLEXPRESS");
            server.ConnectionContext.LoginSecure = true;
            server.ConnectionContext.Connect();

            const string dbName = "proTrace_Jupiter_blank";
            var db = server.Databases[dbName];

            const string prefix = "";

            const string schema = "Cip";
            

            var sprocNames = new List<string>();
            foreach (StoredProcedure sp in db.StoredProcedures)
            {
                if (sp.Schema == schema)
                {
                    sprocNames.Add(sp.Name);
                }
            }

            var tables = new List<Table>();
            foreach (Table table in db.Tables)
            {
                if (table.Schema != schema) continue;
                if (table.Name.StartsWith("sys") || table.Name.StartsWith("tblMimicDataLogged_")
                                                 || table.Name.StartsWith("tblMimicSnapshotdata_") || table.Name.StartsWith("tblMimicSnapshots_") || table.Schema != schema)
                {
                    continue;
                }
                tables.Add(table);
            }

            foreach (var table in tables)
            {
                

                var indexDataType = DataType.BigInt;
                foreach (Column column in table.Columns)
                {
                    if (column.InPrimaryKey)
                    {
                        indexDataType = column.DataType;
                    }
                }

                var checkList = sprocNames.Where(x => x.StartsWith(prefix + table.Name));
                if (checkList.Any())
                {
                    continue;
                }

                try
                {
                    CreateGetSproc(table, db, prefix, indexDataType, schema);
                    CreateMergeSproc(table, db, prefix, schema);
                    CreateMergeBatchSproc(table, db, prefix, schema);
                    CreateDeleteSproc(table, db, prefix, indexDataType, schema);
                    CreateDeleteBatchSproc(table, db, prefix, schema);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void CreateGetSproc(Table table, Database db, string prefix, DataType indexType, string schema = "dbo")
        {
            var sproc = new StringBuilder();
            sproc.Append("SELECT [" + table.Columns[0].Name + "]\n");
            for (var i = 1; i < table.Columns.Count; i++)
            {
                sproc.Append("\t,[" + table.Columns[i].Name + "]\n");
            }

            var pk = "";
            foreach (Column column in table.Columns)
            {
                if (!column.InPrimaryKey) continue;
                if (string.IsNullOrEmpty(pk))
                    pk = column.Name;
            }


            sproc.Append("FROM " + schema + "." + table.Name + " \n");
            sproc.Append("WHERE (@id is NULL OR (Id = @id))\n");

            var sp = new StoredProcedure(db, prefix + table.Name + "Get")
            {
                TextMode = false, AnsiNullsStatus = false, QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@id", indexType) {DefaultValue = "NULL"};
            sp.Schema = schema;
            sp.Parameters.Add(param);
            sp.TextBody = sproc.ToString();
            sp.Create();
        }
        
        private static void CreateMergeSproc(Table table, Database db, string prefix, string schema = "dbo")
        {
            var tableType = table.Name.Clean();
            var types = new List<UserDefinedTableType>();
            foreach (UserDefinedTableType item in db.UserDefinedTableTypes)
            {
                types.Add(item);
            }

            var type = types.First(x => x.Name == tableType && x.Schema == schema);

            var columnsList = new List<string>();
            var pk = "";
            foreach (Column column in table.Columns)
            {
                if (!column.InPrimaryKey)
                {
                    columnsList.Add(column.Name);
                }
                else
                {
                    if(string.IsNullOrEmpty(pk))
                        pk = column.Name;
                }
            }

            var sproc = MergeBody(table, schema, tableType, type, pk, columnsList);

            var sp = new StoredProcedure(db, prefix + table.Name + "Merge")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };

            foreach (Column column in table.Columns)
            {
                var p = new StoredProcedureParameter(sp, "@" + column.Name, column.DataType);
                sp.Parameters.Add(p);
            }

            sp.Schema = schema;
            sp.TextBody = sproc.ToString();
            try
            {
                sp.Create();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private static void CreateMergeBatchSproc(Table table, Database db, string prefix, string schema = "dbo")
        {
            var tableType = table.Name.Clean();

            var types = new List<UserDefinedTableType>();
            foreach (UserDefinedTableType item in db.UserDefinedTableTypes)
            {
                types.Add(item);
            }

            var type = types.First(x => x.Name == tableType && x.Schema == schema);
            
            var columnsList = new List<string>();
            var pk = "";
            foreach (Column column in table.Columns)
            {
                if (!column.InPrimaryKey)
                {
                    columnsList.Add(column.Name);
                }
                else
                {
                    if (string.IsNullOrEmpty(pk))
                        pk = column.Name;
                }
            }

            var sproc = MergeBatchBody(table, schema, pk, columnsList, type);

            var sp = new StoredProcedure(db, prefix + table.Name + "MergeBatch")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@list", new DataType(type))
            {
                IsReadOnly = true
            };
            sp.Parameters.Add(param);
            sp.Schema = schema;
            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static void CreateDeleteSproc(Table table, Database db, string prefix, DataType indexType, string schema = "dbo")
        {
            var pk = "";
            foreach (Column column in table.Columns)
            {
                if (!column.InPrimaryKey) continue;
                if (!string.IsNullOrEmpty(pk)) continue;
                pk = column.Name;
                break;

            }
            var sproc = new StringBuilder("DELETE FROM " + schema + ".[" + table.Name + "]\n");
            sproc.Append("WHERE [" + pk + "] = @id");

            var sp = new StoredProcedure(db, prefix + table.Name + "Delete")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };

            var p = new StoredProcedureParameter(sp, "@id", indexType);
            sp.Parameters.Add(p);
            sp.Schema = schema;
            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static void CreateDeleteBatchSproc(Table table, Database db, string prefix, string schema = "dbo")
        {
            var tableType = table.Name.Clean();

            var pk = "";
            foreach (Column column in table.Columns)
            {
                if (!column.InPrimaryKey) continue;
                if (!string.IsNullOrEmpty(pk)) continue;
                pk = column.Name;
                break;

            }

            var types = new List<UserDefinedTableType>();
            foreach (UserDefinedTableType item in db.UserDefinedTableTypes)
            {
                types.Add(item);
            }

            var type = types.First(x => x.Name == tableType && x.Schema == schema);

            var sproc = new StringBuilder("DELETE FROM " + schema + ".[" + table.Name + "]\n");
            sproc.Append("WHERE [" + pk + "] IN (SELECT [" + pk + "] FROM @list)");

            var sp = new StoredProcedure(db, prefix + table.Name + "DeleteBatch")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@list", new DataType(type))
            {
                IsReadOnly = true
            };
            sp.Parameters.Add(param);
            sp.Schema = schema;
            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static StringBuilder MergeBody(NamedSmoObject table, string schema, string tableType, TableViewTableTypeBase type,
            string pk, IReadOnlyList<string> columnsList)
        {
            var sproc = new StringBuilder("DECLARE @list " + schema + "." + tableType + "; \n");
            sproc.Append("INSERT INTO @list ([" + type.Columns[0].Name + "] \n");
            for (var i = 1; i < type.Columns.Count; i++)
            {
                sproc.Append("\t\t\t,[" + type.Columns[i].Name + "]");
                sproc.Append(i < type.Columns.Count - 1 ? " \n" : ") \n");
            }

            sproc.Append("\t\tVALUES(@" + type.Columns[0].Name + " \n");
            for (var i = 1; i < type.Columns.Count; i++)
            {
                sproc.Append("\t\t\t,@" + type.Columns[i].Name + "");
                sproc.Append(i < type.Columns.Count - 1 ? " \n" : "); \n");
            }

            sproc.Append("\n\n");

            sproc.Append(MergeBatchBody(table, schema, pk, columnsList, type));

            return sproc;
        }

        private static StringBuilder MergeBatchBody(NamedSmoObject table, string schema, string pk, IReadOnlyList<string> columnsList,
            TableViewTableTypeBase type)
        {
            var sproc = new StringBuilder("MERGE " + schema + ".[" + table.Name + "] AS target \n");
            sproc.Append("USING @list as source \n");
            sproc.Append("ON target.[" + pk + "] = source.[" + pk + "] \n");
            sproc.Append("\t WHEN MATCHED THEN \n");
            sproc.Append("\t\t UPDATE SET \n");
            sproc.Append("\t\t\t[" + columnsList[0] + "] = source.[" + type.Columns[0].Name + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "] = source.[" + columnsList[i] + "] \n");
            }

            sproc.Append("\t WHEN NOT MATCHED THEN \n");
            sproc.Append("\t\tINSERT([" + columnsList[0] + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : ") \n");
            }

            sproc.Append("\t\tVALUES(source.[" + columnsList[0] + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,source.[" + columnsList[i] + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : "); \n");
            }

            return sproc;
        }
    }
}
