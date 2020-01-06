using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace coin_application.Models
{
    public class Market
    {
        [Key]
        [Required(ErrorMessage = "Vui lòng nhập mã sàn.")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Mã sàn chỉ được phép trong khoảng từ 2 - 10 ký tự.")]
        [Display(Name = "Market Id")]
        public string MarketId  { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên sàn.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Tên sàn chỉ được phép trong khoảng từ 2 - 200 ký tự.")]
        [Display(Name = "Market Name")]
        public string MarketName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Mô tả chỉ được phép trong khoảng từ 2 - 200 ký tự.")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public MarketStatus Status { get; set; }

        public virtual ICollection<Coin>Coins { get; set; }


        public enum MarketStatus
        {
            Active = 1,
            Deactivate = 0,
            Deleted = -1
        }
    }
}