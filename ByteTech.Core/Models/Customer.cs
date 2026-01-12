using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteTech.Core.Models
{
    public enum PriceLevels { Regular, Wholesale, VIP }

    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string? TIN { get; set; }

        [StringLength(50), Display(Name = "Business Style")]
        public string? BusinessStyle { get; set; }

        public string? Address { get; set; }

        [Display(Name = "Price Level")]
        public PriceLevels PriceLevel { get; set; } = PriceLevels.Regular;

        public byte[]? Picture { get; set; }
        public string? PictureFileName { get; set; } = string.Empty;
        public string? PictureFileType { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Remarks { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Credit Limit")]
        public decimal CreditLimit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

        [NotMapped]
        [Display(Name = "Available Credit")]
        public decimal AvailableCredit => CreditLimit - Balance;

        public bool IsInactive { get; set; }
        public int ServerId { get; set; }
    }
}