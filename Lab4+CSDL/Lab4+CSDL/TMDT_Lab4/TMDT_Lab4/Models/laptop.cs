namespace TMDT_Lab4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class laptop
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string Product { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        public double Inches { get; set; }

        [StringLength(50)]
        public string ScreenResolution { get; set; }

        [StringLength(50)]
        public string Cpu { get; set; }

        [StringLength(50)]
        public string Gen { get; set; }

        public double Speed { get; set; }

        public int Ram { get; set; }

        [StringLength(50)]
        public string Memory { get; set; }

        [StringLength(50)]
        public string Gpu { get; set; }

        [StringLength(50)]
        public string OpSys { get; set; }

        public double Weight { get; set; }

        public double Price_euros { get; set; }
    }
}
