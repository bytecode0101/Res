using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reservations
{
    public abstract class Item
    {
        private List<Guid> waitingList;

        public string Description { get; set; }

        public Guid Id { get; set; }

        private List<Guid> participants;

        public int NoOfPlaces { get; set; }

        public enum Location { }

        public DateTime DateAndTime { get; set; }

        public void View()
        {

        }

        public void CreateItem()
        {

        }

        public void DeleteItem()
        {

        }



    }
}