using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Restaurant
    {
        [DisplayName("S.No")]
        [Required]
        public int ID { get; set; }

        [DisplayName("Restaurant Name")]
        [Required]
        public string name
        {
            get;
            set;
        }

        [DisplayName("Address")]
        [Required]
        public string address
        {
            get;
            set;
        }

        [DisplayName("Tables")]
        public List<Table> tables
        {
            get;
            set;
        }
    }
}
