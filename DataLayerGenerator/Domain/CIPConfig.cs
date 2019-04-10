using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPConfig 
    {
        public long Index { get; set; }
        public string ServiceAddress { get; set; }
        public int? MaxOPCErrors { get; set; }
        public int? InstructionPollInterval { get; set; }
        public int? RecipeMonitorInterval { get; set; }
        public int? MaxRecipeEvents { get; set; }
        public int? RefreshTimer { get; set; }
        public int? MaxInstructionAttempts { get; set; }
        public int? RetainLife { get; set; }
        public int? ServerPageRefresh { get; set; }
        public int? LoggingLevel { get; set; }
    }
}      
