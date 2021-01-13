namespace LeTruongNam.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DS_DANHBA
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string TenNhom { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public virtual NHOM NHOM { get; set; }
    }
}
