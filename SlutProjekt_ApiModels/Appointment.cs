﻿using System.ComponentModel.DataAnnotations;

namespace SlutProjekt_ApiModels
{
    public class Appointment
    {
        [Key]
        public int AppointId { get; set; }
        [Required]
        public DateTime StartingTime { get; set; }

        public int AppointmentDurationMinutes { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        // RELATIONS
   
        public Company Company { get; set; }

        public Customer Customer { get; set; }
    }
}
