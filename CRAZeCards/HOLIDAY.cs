namespace CRAZeCards
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOLIDAYS")]
    public partial class HOLIDAY
    {
        [Key]
        [StringLength(50)]
        public string Holiday_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Holiday_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Holiday_Month { get; set; }

        [Required]
        [StringLength(50)]
        public string Holiday_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Holiday_View { get; set; }
    }
}
