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
            var server = new Server("C877");
            server.ConnectionContext.LoginSecure = true;
            server.ConnectionContext.Connect();

            const string dbName = "proTrace_Jupiter_blank";
            var db = server.Databases[dbName];

            const string prefix = "x_";
            

            var sprocNames = new List<string>();
            foreach (StoredProcedure sp in db.StoredProcedures)
            {
                sprocNames.Add(sp.Name);
            }
            
            foreach (Table table in db.Tables)
            {
                if (table.Name.StartsWith("sys") || table.Name.StartsWith("tblMimicDataLogged_") 
                                                 || table.Name.StartsWith("tblMimicSnapshotdata_") || table.Name.StartsWith("tblMimicSnapshots_"))
                {
                    continue;
                }

                DataType indexDataType = DataType.BigInt;
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
                    CreateGetSproc(table, db, prefix, indexDataType);
                    CreateMergeSproc(table, db, prefix);
                    CreateMergeBatchSproc(table, db, prefix);
                    CreateDeleteSproc(table, db, prefix, indexDataType);
                    CreateDeleteBatchSproc(table, db, prefix);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void CreateGetSproc(Table table, Database db, string prefix, DataType indexType)
        {
            var sproc = new StringBuilder();
            sproc.Append("SELECT " + table.Columns[0].Name + "\n");
            for (var i = 1; i < table.Columns.Count; i++)
            {
                sproc.Append("\t," + table.Columns[i].Name + "\n");
            }

            sproc.Append("FROM " + table.Name + " \n");
            sproc.Append("WHERE (@id is NULL OR (fldIndex = @id))\n");

            var sp = new StoredProcedure(db, prefix + table.Name + "Get")
            {
                TextMode = false, AnsiNullsStatus = false, QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@id", indexType) {DefaultValue = "NULL"};
            sp.Parameters.Add(param);
            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        
        private static void CreateMergeSproc(Table table, Database db, string prefix)
        {
            var tableType = table.Name.Clean();
            var type = db.UserDefinedTableTypes[tableType];

            var columnsList = new List<string>();
            foreach (Column column in table.Columns)
            {
                if (!column.Identity)
                {
                    columnsList.Add(column.Name);
                }
            }

            var sproc = new StringBuilder("DECLARE @list " + tableType + "; \n");
            sproc.Append("INSERT INTO @list ([" + columnsList[0].Clean() + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i].Clean() + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : ") \n");
            }

            sproc.Append("\t\tVALUES(@" + columnsList[0].Clean() + " \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,@" + columnsList[i].Clean() + "");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : "); \n");
            }

            sproc.Append("\n\n");
            sproc.Append("MERGE " + table.Name + " AS target \n");
            sproc.Append("USING @list as source \n");
            sproc.Append("ON target.fldIndex = source.[Index] \n");
            sproc.Append("\t WHEN MATCHED THEN \n");
            sproc.Append("\t\t UPDATE SET \n");
            sproc.Append("\t\t\t[" + columnsList[0] + "] = source.[" + type.Columns[0].Name + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "] = source.[" + columnsList[i].Clean() + "] \n");
            }

            sproc.Append("\t WHEN NOT MATCHED THEN \n");
            sproc.Append("\t\tINSERT(" + columnsList[0] + " \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : ") \n");
            }

            sproc.Append("\t\tVALUES(source.[" + columnsList[0].Clean() + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,source.[" + columnsList[i].Clean() + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : "); \n");
            }

            var sp = new StoredProcedure(db, prefix + table.Name + "Merge")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };

            foreach (Column column in table.Columns)
            {
                var p = new StoredProcedureParameter(sp, "@" + column.Name.Clean(), column.DataType);
                sp.Parameters.Add(p);
            }

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

        private static void CreateMergeBatchSproc(Table table, Database db, string prefix)
        {
            var tableType = table.Name.Clean();
            var type = db.UserDefinedTableTypes[tableType];

            var columnsList = new List<string>();
            foreach (Column column in table.Columns)
            {
                if (!column.Identity)
                {
                    columnsList.Add(column.Name);
                }
            }

            var sproc = new StringBuilder("MERGE " + table.Name + " AS target \n");
            sproc.Append("USING @list as source \n");
            sproc.Append("ON target.fldIndex = source.[Index] \n");
            sproc.Append("\t WHEN MATCHED THEN \n");
            sproc.Append("\t\t UPDATE SET \n");
            sproc.Append("\t\t\t[" + columnsList[0] + "] = source.[" + type.Columns[0].Name + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "] = source.[" + columnsList[i].Clean() + "] \n");
            }

            sproc.Append("\t WHEN NOT MATCHED THEN \n");
            sproc.Append("\t\tINSERT(" + columnsList[0] + " \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : ") \n");
            }

            sproc.Append("\t\tVALUES(source.[" + columnsList[0].Clean() + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,source.[" + columnsList[i].Clean() + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : "); \n");
            }

            var sp = new StoredProcedure(db, prefix + table.Name + "MergeBatch")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@list", new DataType(db.UserDefinedTableTypes[tableType]))
            {
                IsReadOnly = true
            };
            sp.Parameters.Add(param);

            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static void CreateDeleteSproc(Table table, Database db, string prefix, DataType indexType)
        {
            var sproc = new StringBuilder("DELETE FROM " + table.Name + "\n");
            sproc.Append("WHERE fldIndex = @id");

            var sp = new StoredProcedure(db, prefix + table.Name + "Delete")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };

            var p = new StoredProcedureParameter(sp, "@id", indexType);
            sp.Parameters.Add(p);

            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static void CreateDeleteBatchSproc(Table table, Database db, string prefix)
        {
            var tableType = table.Name.Clean();
            
            var sproc = new StringBuilder("DELETE FROM " + table.Name + "\n");
            sproc.Append("WHERE fldIndex IN (SELECT [Index] FROM @list)");

            var sp = new StoredProcedure(db, prefix + table.Name + "DeleteBatch")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@list", new DataType(db.UserDefinedTableTypes[tableType]))
            {
                IsReadOnly = true
            };
            sp.Parameters.Add(param);

            sp.TextBody = sproc.ToString();
            sp.Create();
        }
    }
}
