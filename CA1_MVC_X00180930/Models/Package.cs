using System.ComponentModel.DataAnnotations;

namespace CA1_MVC_X00180930.Models
{
    public class Package
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string ClientName { get; set; } = "";
        [Required]
        public string ShippingAddress { get; set; } = "";
        [Required]
        public double Weight { get; set; }
        [Required]

        public double Length { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
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
