using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public interface IBookingService
    {
        void GetReservations();

        void GetReservation(int id);

        void UpdateReservation(int id);

        void AddReservation(Reservation booking);

        void DeleteReservation(int id);

    }
}
