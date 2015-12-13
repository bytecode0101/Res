using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reservations
{
    public abstract class Client
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public Guid Id { get; set; }

        public string Password { get; set; }

        public DateTime DateBirth { get; set; }

        public string Tel { get; set; }

        public List<Guid> Reservations { get; set; }

        public enum Gender { }

        public string Email { get; set; }


        public void Authenticate()
        {

        }

        public void MakeReservation()
        {
          
        }

        public void CancelReservation()
        {
            
        }

        public void ViewCalendar()
        {
            
        }

        public void SubscribeToWaitingList()
        {
            
        }
    }
}