using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;

namespace CheeseMVC.ViewModels
{
    public class AddMenuViewModel
    {
        private Menu menu;
        private List<Cheese> cheeses;

        public AddMenuViewModel(Menu menu, List<Cheese> cheeses)
        {
            this.menu = menu;
            this.cheeses = cheeses;
        }

        [Required]
        [Display(Name = "Menu Name")]
        public string Name { get; set; }
    }
}
