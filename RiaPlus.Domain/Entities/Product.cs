using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RiaPlus.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue=false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Введіть назву автомобіля")]
        public string Name { get; set; }


        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Введіть опис автомобіля")]
        public string Description { get; set; }

        [Required]
        [Range(0.001, 1000000.00, ErrorMessage = "Введіть коректну ціну")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Введіть категорію для автомобіля")]
        public string Category { get; set; }
    }
}
