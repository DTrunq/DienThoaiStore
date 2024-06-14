using System.ComponentModel.DataAnnotations;

namespace DienThoaiStore.Models
{
    public class Phone
    {
        [Key] 
        [Display(Name = "Mã máy")]
        public int Ma { get; set; }

        [Required(ErrorMessage = "Tên điện thoại là bắt buộc.")]

        [StringLength(100, ErrorMessage = "Tên điện thoại không được vượt quá 100 ký tự.")]
        [Display(Name = "Tên sản phẩm")]
        public string DienThoai { get; set; }

        [Display(Name = "Năm Sản Xuất")]
        public int NamSX { get; set; }


        [Required(ErrorMessage = "Màu là bắt buộc.")]
        [Display(Name = "Màu sắc")]
        [StringLength(50, ErrorMessage = "Màu không được vượt quá 50 ký tự.")]
        public string Mau { get; set; }

        [Required(ErrorMessage = "Hệ điều hành là bắt buộc.")]
        [Display(Name = "Hệ điều hành")]
        [StringLength(50, ErrorMessage = "Hệ điều hành không được vượt quá 50 ký tự.")]
        public string HeDieuHanh { get; set; }

   
        [Range(0, 1000000000, ErrorMessage = "Giá phải nằm trong khoảng từ 0 đến 1tỷ đồng.")]
        [Display(Name = "Giá")]
        [DisplayFormat(DataFormatString = "{0:#,##0₫}", ApplyFormatInEditMode = false)]
        public decimal Gia { get; set; }

        [Required(ErrorMessage = "Thông số kỹ thuật là bắt buộc.")]
        [Display(Name = "Thông sô kỹ thuật")]
        public string ThongsoKyThuat { get; set; }
    }
}
