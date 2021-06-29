using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Table
    {
        [DisplayName("S.No")]
        [Required]
        public int id
        {
            get;
            set;
        }

        public int numSeats
        {
            get;
            set;
        }
    }
}
