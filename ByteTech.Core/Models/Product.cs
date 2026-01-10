using ByteTech.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required,StringLength(200)]
        public string Description { get; set; } = String.Empty;
        public bool Vatable { get; set; } = true;

        //define what discounts are allowed
        [Display(Name = "Senior Citizen")]
        public bool isSeniorCitizen { get; set; } = true;
        public bool BasicCommodity { get; set; }

        [Display(Name = "PWD")]
        public bool isPWD { get; set; } = true;

        public string SKU { get; set; }
        public string Barcode { get; set; }

       



        public Category Category { get; set; }
        public int Stock { get; set; }
        public int MinimumStockLevel { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public bool IsActive { get; set; } = true;
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime? DateModified { get; set; }


        // added properties 

        [Required, StringLength(150), Display(Name = "Created By")]
        public string CreatedBy { get; set; } = String.Empty;
        [StringLength(50),Display(Name = "Modified By")]
        public string? ModifiedBy { get; set; } = null;
        [Display(Name = "Inactive?")]
        public bool IsInactive { get; set; }

        public bool TrackInventory { get; set; }
        public Location? Location { get; set; }
        public Material? Material { get; set; }
        public int? MaterialId { get; set; }
        public byte[]? Picture { get; set; }
        [StringLength(50)]
        public string? PictureName { get; set; }
        [StringLength(50)]
        public string? PictureFileType { get; set; }
        [Required, StringLength(50)]
        public string LookupCode { get; set; } = String.Empty;
        public bool SoldByAmount { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; } = null;
        [Display(Name = "Last Sold")]
        public DateTime? LastSold { get; set; }

        [Display(Name ="Not Discountable")]
        public bool NotDiscountableAtPOS { get; set; }
        public bool ExcludeFromOrderSlip    { get; set; }
        public bool isDiscountable => NotDiscountableAtPOS == false;


        [Display(Name = "Exclusive of service charge")]
        public bool InclusiveOfServiceCharge { get; set; }
        public int ServerId { get; set; }

        [NotMapped]
        public string CategoryName => Category != null ? Category.Description : "";
        [NotMapped]
        public bool BindedInItemView { get; set; } = false;

        public SectionTypes Section { get; set; } = SectionTypes.Default;

        [Required,Range(1, int.MaxValue , ErrorMessage = "Please select a category"),Display(Name="Category")]
        public int CategoryId { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal WholeSalePrice { get; set; }
        public decimal PriceA {  get; set; }
        public decimal PriceB { get; set; }
        public decimal PriceC { get; set; }
        public decimal Cost { get; set; }













        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
