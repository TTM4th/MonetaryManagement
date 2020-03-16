namespace MonetaryManagementAccessor.Entity.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MoneyData
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public decimal? Price { get; set; }

        [StringLength(1)]
        public string Classification { get; set; }
    }
}
