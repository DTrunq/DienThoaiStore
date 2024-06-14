using System;
using System.ComponentModel.DataAnnotations;

namespace DienThoaiStore.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(100, ErrorMessage = "Tên không được vượt quá 100 ký tự")]
        [Display(Name = "Khách hàng")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sản phẩm không được để trống")]
        [StringLength(200, ErrorMessage = "Sản phẩm không được vượt quá 200 ký tự")]
        [Display(Name = "Sản phẩm")]
        public string SanPham { get; set; }

        [Required(ErrorMessage = "Ngày đặt hàng không được để trống")]
        [Display(Name = "Ngày đặt hàng")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(300, ErrorMessage = "Địa chỉ không được vượt quá 300 ký tự")]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [StringLength(50, ErrorMessage = "Trạng thái không được vượt quá 50 ký tự")]
        [Display(Name = "Trạng thái")]
        public string TrangThai { get; set; }
    }

}
