using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SklepSpozywczy3.Models;

namespace SklepSpozywczy3.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                {
                    return "Edit Customer Data";
                }
                else
                {
                    return "Add Customer";
                }
            }
        }
    }
}