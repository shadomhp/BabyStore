﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabyStore.ViewModels
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "The product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage ="Please enter a product name made up of letters and numbers only")]
        public string Name { get; set; }
        [Required(ErrorMessage ="The product description cannot be blank")]
        [StringLength(200, MinimumLength = 10, ErrorMessage ="Please enter a product description between 10 and 200 characters in length")]
        [RegularExpression(@"^[,;a-zA-Z0-9'-'\s]*$", ErrorMessage ="Please enter a product description made up of letters and numbers only")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage ="The Price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage ="Please enter a price between {1} and {2}")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:c}")]
        [RegularExpression("[0-9]+(\\,[0-9][0-9]?)?", ErrorMessage ="The price must be a number up to two decimal places")]
        public decimal Price { get; set; }

        [Display(Name ="Category")]
        public int CategoryID { get; set; }
        public SelectList CategoryList { get; set; }
        public List<SelectList> ImageLists { get; set; }
        public string[] ProductImages { get; set; }

    }
}