using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Reservation : IBookingService
    {

        [DisplayName("Reservation Id")]
        [Required]
        public int Id
        {
            get;
            set;
        }

        public DateTime startDateTime
        {
            get;
            set;
        }

        public DateTime EndDateTime
        {
            get;
            set;
        }


        [Required]
        public Customer Customers
        {
            get;
            set;
        }

        [Required]
        public Table Tables
        {
            get;
            set;
        }

        public void AddReservation(Reservation booking)
        {
            throw new NotImplementedException();
        }

        public void DeleteReservation(int id)
        {
            throw new NotImplementedException();
        }

        public void GetReservation(int id)
        {
            throw new NotImplementedException();
        }

        public void GetReservations()
        {
            throw new NotImplementedException();
        }

        public void UpdateReservation(int id)
        {
            throw new NotImplementedException();
        }
    }
}
