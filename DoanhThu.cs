namespace QuanCafe2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThu")]
    public partial class DoanhThu
    {
        public int Id { get; set; }

        public int? SanPhamId { get; set; }

        public int TongSoLuong { get; set; }

        public decimal TongTienSP { get; set; }

        public DateTime ThoiDiem { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
