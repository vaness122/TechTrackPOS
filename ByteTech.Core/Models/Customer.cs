using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByteTech.Core.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(50)]
        public string? TIN { get; set; }

        [StringLength(100)]
        public string? BusinessStyle { get; set; }

        public string? Address { get; set; }

 
        public PriceLevels PriceLevel { get; set; }

        
        public byte[]? Picture { get; set; }

        public string? PictureFileName { get; set; }
        public string? PictureFileType { get; set; }

        public string? Remarks { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CreditLimit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }

       
        [NotMapped]
        public decimal AvailableCredit => CreditLimit - Balance;

        public bool IsInactive { get; set; }

        public int ServerId { get; set; }
    }

    public enum PriceLevels
    {
        Regular,
        Wholesale,
        VIP
    }
}