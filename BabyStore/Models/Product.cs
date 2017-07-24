using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public partial class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "The Product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s]*$", ErrorMessage = "Please enter a product name made up letters and numbers only")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The product description cannot be blank")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Please enter a product description between 10 and 200 characters in length")]
        [RegularExpression(@"^[,;a-zA-Z0-9'-'\s]*$", ErrorMessage = "Please enter a product description made up of letters and numbers only")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "The price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage = "Please enter a price between {1} and {2}")]
        [DataType(DataType.Currency)]                                   //Usado somente para formatação. A validação é feita por regularExpression
        [DisplayFormat(DataFormatString = "{0:c}")]
        //[RegularExpression(@"^\d+(?:\,\d{1,2})?$", ErrorMessage = "The price must be a number up to two decimal places")]
        [RegularExpression(@"^\d*(\.|,|(\.\d{1,2})|(,\d{1,2}))?$", ErrorMessage = "The price must be a number up to two decimal places")]
        public decimal Price { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}