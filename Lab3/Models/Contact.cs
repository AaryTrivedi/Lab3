using System;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Contact
    {

        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a valid first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a valid last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }
        public string Organization { get; set; }
        public DateTime DateAdded { get; set; }

        [Range(1, 10, ErrorMessage = "Please select category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Slug => FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();


    }
}
