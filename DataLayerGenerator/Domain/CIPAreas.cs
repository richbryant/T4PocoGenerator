using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPAreas.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPAreas 
    {
        public long Index { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int? State { get; set; }
        public long? CIPStatusTag { get; set; }
        public long? RecipeIDTag { get; set; }
        public long? RecipeInstructionIDTag { get; set; }
        public long? HandshakingTag { get; set; }
        public long? GlobalInstructionIDTag { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public long? Operator { get; set; }
        public string CIPStatusTagText { get; set; }
        public string RecipeIDTagText { get; set; }
        public string RecipeInstructionIDTagText { get; set; }
        public string HandshakingTagText { get; set; }
        public string InstructionTypeTagText { get; set; }
        public string GlobalInstructionIDTagText { get; set; }
        public string OperatorName { get; set; }
        public long? InstructionAttemptsTag { get; set; }
        public string InstructionAttemptsTagText { get; set; }
        public string PausedTagText { get; set; }
        public long? PausedTag { get; set; }
        public long? AbortTag { get; set; }
        public string AbortTagText { get; set; }
        public int OPCServerID { get; set; }
    }
}      
