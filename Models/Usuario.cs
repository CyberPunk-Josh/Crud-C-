using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is requierd")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone numer is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Cellphone is required")]
        public string Cellphone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}
