using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;

namespace DataLayerGenerator.GenerateSprocs
{
    public static class StoredProcedureGenerator
    {
        public static void GenerateProcedures()
        {
            var server = new Server("virtualhost\\sqlexpress");
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

                var checkList = sprocNames.Where(x => x.StartsWith(prefix + table.Name));
                if (checkList.Any())
                {
                    continue;
                }
                CreateGetSproc(table, db, prefix);
                CreateMergeSproc(table, db, prefix);
                CreateMergeBatchSproc(table, db, prefix);
                CreateDeleteSproc(table, db, prefix);
                CreateDeleteBatchSproc(table, db, prefix);
            }
        }

        private static void CreateGetSproc(Table table, Database db, string prefix)
        {
            var sproc = new StringBuilder();
            sproc.Append("SELECT " + table.Columns[0].Name + "\n");
            for (var i = 1; i < table.Columns.Count; i++)
            {
                sproc.Append("\t," + table.Columns[i].Name + "\n");
            }

            sproc.Append("FROM " + table.Name + " \n");
            sproc.Append("WHERE (@index is NULL OR (fldIndex = @index))\n");

            var sp = new StoredProcedure(db, prefix + table.Name + "Get")
            {
                TextMode = false, AnsiNullsStatus = false, QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@index", DataType.BigInt);
            sp.Parameters.Add(param);
            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static void CreateMergeSproc(Table table, Database db, string prefix)
        {
            var tableType = Tidy.Clean(table.Name);
            var type = db.UserDefinedTableTypes[tableType];

            var columnsList = new List<string>();
            foreach (Column column in table.Columns)
            {
                if (!column.Identity)
                {
                    columnsList.Add(column.Name);
                }
            }

            var sproc = new StringBuilder("DECLARE @table " + tableType + "; \n");
            sproc.Append("INSERT INTO @table ([" + Tidy.Clean(columnsList[0]) + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + Tidy.Clean(columnsList[i]) + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : ") \n");
            }

            sproc.Append("\t\tVALUES(@" + Tidy.Clean(columnsList[0] + " \n"));
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,@" + Tidy.Clean(columnsList[i]) + "");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : "); \n");
            }

            sproc.Append("\n\n");
            sproc.Append("MERGE " + table.Name + " AS target \n");
            sproc.Append("USING @table as source \n");
            sproc.Append("ON target.fldIndex = source.[Index] \n");
            sproc.Append("\t WHEN MATCHED THEN \n");
            sproc.Append("\t\t UPDATE SET \n");
            sproc.Append("\t\t\t[" + columnsList[0] + "] = source.[" + type.Columns[0].Name + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "] = source.[" + Tidy.Clean(columnsList[i]) + "] \n");
            }

            sproc.Append("\t WHEN NOT MATCHED THEN \n");
            sproc.Append("\t\tINSERT(" + columnsList[0] + " \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : ") \n");
            }

            sproc.Append("\t\tVALUES(source.[" + Tidy.Clean(columnsList[0] + "] \n"));
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,source.[" + Tidy.Clean(columnsList[i]) + "]");
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
                var p = new StoredProcedureParameter(sp, "@" + Tidy.Clean(column.Name), column.DataType);
                sp.Parameters.Add(p);
            }

            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static void CreateMergeBatchSproc(Table table, Database db, string prefix)
        {
            var tableType = Tidy.Clean(table.Name);
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
            sproc.Append("USING @table as source \n");
            sproc.Append("ON target.fldIndex = source.[Index] \n");
            sproc.Append("\t WHEN MATCHED THEN \n");
            sproc.Append("\t\t UPDATE SET \n");
            sproc.Append("\t\t\t[" + columnsList[0] + "] = source.[" + type.Columns[0].Name + "] \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "] = source.[" + Tidy.Clean(columnsList[i]) + "] \n");
            }

            sproc.Append("\t WHEN NOT MATCHED THEN \n");
            sproc.Append("\t\tINSERT(" + columnsList[0] + " \n");
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,[" + columnsList[i] + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : ") \n");
            }

            sproc.Append("\t\tVALUES(source.[" + Tidy.Clean(columnsList[0] + "] \n"));
            for (var i = 1; i < columnsList.Count; i++)
            {
                sproc.Append("\t\t\t,source.[" + Tidy.Clean(columnsList[i]) + "]");
                sproc.Append(i < columnsList.Count - 1 ? " \n" : "); \n");
            }

            var sp = new StoredProcedure(db, prefix + table.Name + "MergeBatch")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@table", new DataType(db.UserDefinedTableTypes[tableType]))
            {
                IsReadOnly = true
            };
            sp.Parameters.Add(param);

            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static void CreateDeleteSproc(Table table, Database db, string prefix)
        {
            var sproc = new StringBuilder("DELETE FROM " + table.Name + "\n");
            sproc.Append("WHERE fldIndex = @index");

            var sp = new StoredProcedure(db, prefix + table.Name + "Delete")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };

            var p = new StoredProcedureParameter(sp, "@index", DataType.BigInt);
            sp.Parameters.Add(p);

            sp.TextBody = sproc.ToString();
            sp.Create();
        }

        private static void CreateDeleteBatchSproc(Table table, Database db, string prefix)
        {
            var tableType = Tidy.Clean(table.Name);
            
            var sproc = new StringBuilder("DELETE FROM " + table.Name + "\n");
            sproc.Append("WHERE fldIndex IN (SELECT [Index] FROM @table)");

            var sp = new StoredProcedure(db, prefix + table.Name + "DeleteBatch")
            {
                TextMode = false,
                AnsiNullsStatus = false,
                QuotedIdentifierStatus = false
            };
            var param = new StoredProcedureParameter(sp, "@table", new DataType(db.UserDefinedTableTypes[tableType]))
            {
                IsReadOnly = true
            };
            sp.Parameters.Add(param);

            sp.TextBody = sproc.ToString();
            sp.Create();
        }
    }
}
