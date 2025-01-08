namespace QuanCafe2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BanSanPham")]
    public partial class BanSanPham
    {
        public int Id { get; set; }

        public int? BanId { get; set; }

        public int? SanPhamId { get; set; }

        public int SoLuong { get; set; }

        public decimal TongTien { get; set; }

        public int DaTinhTien { get; set; }

        public virtual Ban Ban { get; set; }

        public virtual Ban Ban1 { get; set; }

        public virtual SanPham SanPham { get; set; }

        public virtual SanPham SanPham1 { get; set; }
    }
}
