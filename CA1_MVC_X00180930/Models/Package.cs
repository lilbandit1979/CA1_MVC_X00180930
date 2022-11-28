using System.ComponentModel.DataAnnotations;

namespace CA1_MVC_X00180930.Models
{
    public class Package
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; } = "";
        [Required]
        [StringLength (200,MinimumLength =6)]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; } = "";
        [Required]
        [Range(0.0, 100)]
        [Display(Name = "Weight: KG")]
        public double Weight { get; set; }
        [Required]
        [Range(0.0, 200)]
        [Display(Name = "Length: CM")]
        public double Length { get; set; }
        [Required]
        [Range(0.0, 200)]
        [Display(Name = "Width: CM")]
        public double Width { get; set; }
        [Required]
        [Range(0.0, 200)]
        [Display(Name = "Height: CM")]
        public double Height { get; set; }
        [Required]

        public ShippingCategory ShippingCategory
        {
            get
            {
                return ShippingCategory;
            }
            set
            {
                if(Density()<1)
                {
                    ShippingCategory = ShippingCategory.Low;
                }
                if(Density()<100)
                {
                    ShippingCategory = ShippingCategory.Medium;
                }
                if(Density()>=100)
                {
                    ShippingCategory = ShippingCategory.High;
                }
            }
        }


        public double Volume()
        {
            return Weight * Length*Height;
        }
        
        public double Density()
        {
            double answer = Weight / Volume();
            return answer;
        }


    }
}
