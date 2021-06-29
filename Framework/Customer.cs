using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Framework
{
    public class Customer
    {
        [DisplayName("S.No")]
        [Required]
        public int id
        {
            get;
            set;
        }


        [DisplayName("Customer Name")]
        [Required]
        public string name
        {
            get;
            set;
        }

        [DisplayName("Contact No")]
        [Required]
        public string phoneno
        {
            get;
            set;
        }

        [DisplayName("Id Proof")]
        [Required]
        public string Idproof
        {
            get;
            set;
        }

        [DisplayName("Address")]
        [Required]
        public string Address
        {
            get;
            set;
        }

    }
}