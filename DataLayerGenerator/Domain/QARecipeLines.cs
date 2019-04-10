using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblQARecipeLines.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class QARecipeLines 
    {
        public long RecipeNo { get; set; }
        public int RevisionNo { get; set; }
        public int Area { get; set; }
        public int StationID { get; set; }
        public int Vessel { get; set; }
        public int LineNo { get; set; }
        public int? Instruction { get; set; }
        public int? Parameter { get; set; }
        public decimal? Target { get; set; }
        public decimal? PositiveTol { get; set; }
        public decimal? NegativeTol { get; set; }
        public int? Grouped { get; set; }
        public int? Scale { get; set; }
        public long? Image { get; set; }
        public int? SuperPrompt { get; set; }
        public int? RinseWater { get; set; }
        public int? RemoteScale { get; set; }
        public int? SubContainer { get; set; }
        public long? PreweighIndex { get; set; }
        public int? BagWeighIgnore { get; set; }
        public int? Substitution { get; set; }
        public int UOM { get; set; }
        public string StageData { get; set; }
    }
}      
