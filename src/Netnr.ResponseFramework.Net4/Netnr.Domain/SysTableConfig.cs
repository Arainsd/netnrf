namespace Netnr.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("SysTableConfig")]
    public partial class SysTableConfig
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(200)]
        public string TableName { get; set; }

        [StringLength(200)]
        public string ColField { get; set; }

        [StringLength(200)]
        public string DvTitle { get; set; }

        [StringLength(200)]
        public string ColTitle { get; set; }

        public int? ColWidth { get; set; }

        public int? ColAlign { get; set; }

        public int? ColHide { get; set; }

        public int? ColOrder { get; set; }

        public int? ColFrozen { get; set; }

        [StringLength(200)]
        public string ColFormat { get; set; }

        public int? ColSort { get; set; }

        public int? ColExport { get; set; }

        public int? ColQuery { get; set; }

        public string FormUrl { get; set; }

        [StringLength(200)]
        public string FormType { get; set; }

        public int? FormArea { get; set; }

        public int? FormSpan { get; set; }

        public int? FormHide { get; set; }

        public int? FormOrder { get; set; }

        public int? FormRequired { get; set; }

        [StringLength(200)]
        public string FormPlaceholder { get; set; }

        public string FormValue { get; set; }

        public string FormText { get; set; }
    }
}
