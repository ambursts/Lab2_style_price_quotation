using System.ComponentModel.DataAnnotations;
namespace Lab_2.Models
{
    public class PriceQuotationModel
    {

        /*struggled to clone so just copied code over from other lab and adjusted*/
        /*pulled code chunks for view from FutureValue lab provided*/


        [Required(ErrorMessage = "Please enter a sale price.")]
        [Range(0.01, double.MaxValue,
                   ErrorMessage = "Subtotal must be greater than 0.")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(0, 100,
            ErrorMessage = "Discount percent must be between 0 and 100.")]
        public decimal? DiscountPercent { get; set; }

        public decimal GetDiscountAmount()
        {
            if (Subtotal.HasValue && DiscountPercent.HasValue)
            {
                return Subtotal.Value * DiscountPercent.Value / 100;
            }
            return 0;
        }
        public decimal GetTotal()
        {
            if (Subtotal.HasValue)
            {
                return Subtotal.Value - GetDiscountAmount();
            }
            return 0;
        }




        }
}
