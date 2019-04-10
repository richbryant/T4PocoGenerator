using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerGenerator.GenerateSprocs;
using DataLayerGenerator.GenerateTypes;

namespace DataLayerGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            StoredProcedureGenerator.GenerateProcedures();
        }
    }
}
