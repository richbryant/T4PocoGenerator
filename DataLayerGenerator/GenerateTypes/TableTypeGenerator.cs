﻿using System.Configuration;
using Microsoft.SqlServer.Management.Smo;

namespace DataLayerGenerator.GenerateTypes
{
    public static class TableTypeGenerator
    {
        public static void GenerateTypes()
        {
            var server = new Server("virtualhost\\sqlexpress");
            server.ConnectionContext.LoginSecure = true;
            server.ConnectionContext.Connect();

            var dbName =   "proTrace_Jupiter_blank";
            var db = server.Databases[dbName];

            foreach (Table table in db.Tables)
            {
                
                if (table.Name.StartsWith("sys"))
                {
                    continue;
                }

                var fixedName = table.Name.Replace("tbl", "").Replace("CIP", "Cip").Replace("OPC", "Opc");
                UserDefinedTableType type;

                if (db.UserDefinedTableTypes.Contains(fixedName))
                {
                    type = db.UserDefinedTableTypes[fixedName];
                    continue;
                }

                type = new UserDefinedTableType(db, fixedName);
                foreach (Column column in table.Columns)
                {
                    var fixedColumnName = column.Name.Replace("fld", "").Replace("CIP", "Cip").Replace("OPC", "Opc");
                    var c = new Column(type, fixedColumnName)
                    {
                        DataType = column.DataType
                    };
                    type.Columns.Add(c);
                }
                type.Create();
            }
        }
    }
}