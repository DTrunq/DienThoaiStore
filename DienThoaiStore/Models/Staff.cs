using System;
using System.ComponentModel.DataAnnotations;

namespace DienThoaiStore.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên nhân viên là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên nhân viên không được vượt quá 100 ký tự.")]
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ngày sinh là bắt buộc.")]
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Giới tính là bắt buộc.")]
        [StringLength(10, ErrorMessage = "Giới tính không được vượt quá 10 ký tự.")]
        [Display(Name = "Giới tính")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Quê quán là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Quê quán không được vượt quá 100 ký tự.")]
        [Display(Name = "Quê quán")]
        public string QueQuan { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
        [StringLength(15, ErrorMessage = "Số điện thoại không được vượt quá 15 ký tự.")]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}
