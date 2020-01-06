using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace coin_application.Models
{
    public class Coin
    {
        [Key]
        [Required(ErrorMessage = "Vui lòng nhập mã Coin.")]
        [Display(Name = "Coin Id")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Mã Coin chỉ được phép trong khoảng từ 2 - 10 ký tự.")]
        public string CoinId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên Coin.")]
        [Display(Name = "Coin Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tên Coin chỉ được phép trong khoảng từ 2 - 50 ký tự.")]
        public string CoinName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên Base Asset.")]
        [Display(Name = "Base Asset")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tên Base Asset chỉ được phép trong khoảng từ 2 - 50 ký tự.")]
        public string BaseAsset { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên Quote Asset.")]
        [Display(Name = "Quote Asset")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tên Quote Asset chỉ được phép trong khoảng từ 2 - 50 ký tự.")]
        public string QuoteAsset { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá.")]
        [Display(Name = "Last Price")]
        [Range(1000, maximum: Double.MaxValue, ErrorMessage = "Vui lòng nhập đúng giá trị.")]
        public double LastPrice { get; set; }
        public double Volume24h { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual Market Market  { get; set; }
        public string MarketId { get; set; }
        public CoinStatus Status { get; set; }

    public enum CoinStatus
    {
        Active = 1,
        Deactivate = 0,
        Deleted = -1
    }
    }
}