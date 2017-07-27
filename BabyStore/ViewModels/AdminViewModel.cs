using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BabyStore.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set;}
        [Required(AllowEmptyStrings = false)]
        [Display(Name ="Role Nome")]
        public string Name { get; set; }
    }
}