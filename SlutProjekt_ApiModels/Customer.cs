﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt_ApiModels
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "This is not a valid email address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^+?[1-9][0-9]{7,14}$", ErrorMessage = "This is not a valid phone number")]
        public string Phone { get; set; }
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}

