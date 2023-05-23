using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoExplore.Entity.Booking;

namespace GoExplore.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "É necessario primeiro Nome")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "É necessario Apelido")]
        [StringLength(50)]
        public string LastName { get; set; }


        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "É necessario Email")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[az0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email address")]
        public string? Email { get; set; }



        [Column(TypeName = "char(9)")]
        [Required(ErrorMessage = "É necessario Telemovel")]
        [Display(Name = "Phone number")]
        public Nullable<int> Phone { get; set; }


        [Range(0,120,ErrorMessage ="Idade é entre 0 e 120")]
        public int Age { get; set; }


        public string? Address { get; set; }= null;


        public string? City { get; set; } = null;

    
        public string? Zipcode { get; set; } = null;

       
        public string? Country { get; set; } = null;


        [Required(ErrorMessage = "É necessario Contribuinte")]
        [Column(TypeName = "char(9)")]
        public int  NumeroContribuinte { get; set; }


        public ICollection<Reservation> Reservations { get; set; }




    }
}
