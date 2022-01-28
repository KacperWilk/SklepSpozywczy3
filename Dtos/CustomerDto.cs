using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SklepSpozywczy3.Models;

namespace SklepSpozywczy3.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
//        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool NewsletterSubscribed { get; set; }

        [Required(ErrorMessage = "Please choose a Membership Type.")]

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}