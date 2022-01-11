using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using SwimManagementLibrary.enums;

namespace SwimManagementLibrary.classes
{
    public class Event
    {
        //fields
        //private RegistrantsSwims swimmingEvents;
        private readonly Dictionary<Registrant, Swim> SwimmersSwim = new Dictionary<Registrant, Swim>();
        //properties
        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Registrant> Swimmers { get; } = new List<Registrant>();

        //constructor
        public Event()
        {
            //swimmingEvents = new RegistrantsSwims();
        }
        public Event(EventDistance distance, Stroke stroke)
        {
            //swimmingEvents = new RegistrantsSwims();
            Distance = distance;
            Stroke = stroke;
        }

        //methods
        public override string ToString()
        {
            string s = $"{Distance} {Stroke}\n\tSwimmers:";
            if (Swimmers.Count > 0)
            {
                foreach (Registrant r in Swimmers)
                {
                    s = s + "\n\t" + r.Name + "\n\t\t" + SwimmersSwim[r];

                }
            }
            else
                s = s + '\n';
            return s;


        }
        public void AddSwimmer(Registrant aSwimmer)
        {
            if (Swimmers.Contains(aSwimmer))
            {
                //swimmingEvents.swim = null;
                //swimmingEvents.AddOrUpdate(aSwimmer, swimmingEvents.swim);
                AddOrUpdate(aSwimmer, null);
                throw new Exception($"Swimmer {aSwimmer.Name}, {aSwimmer.Id} is already entered");
            }
            else
            {
                Swimmers.Add(aSwimmer);
                AddOrUpdate(aSwimmer, swim);
            }
        }
        public void EnterSwimmersTime(Registrant aSwimmer, string time)
        {
            Swim Swimmer = GetSwimmwersSwim(aSwimmer);
            Swimmer.Time = DateTime.ParseExact(time, "mm:ss.ff", null);
            AddOrUpdate(aSwimmer, Swimmer);
        }
        public void Seed(byte maxLanes)
        {
            ushort heat = 1;
            byte lane = 1;
            foreach (Registrant swimmer in Swimmers)
            {
                Swim s = new Swim(heat, lane++);
                AddOrUpdate(swimmer, s);
                if (lane > maxLanes)
                {
                    lane = 1;
                    heat++;
                }


            }
        }

        //nested class
        //class RegistrantsSwims
        //{
        //fields
        // public  List<Registrant> swimmers = new List<Registrant>();
        //public  List<Swim> swims = new List<Swim>();

        //properties
        public Swim swim { get; set; } = new Swim();

        //methods
        public void AddOrUpdate(Registrant swimmer, Swim swim)
        {
            if (Contains(swimmer) == false || swim == null)
            {
                SwimmersSwim.Add(swimmer, swim);
            }
            else
            {
                //swims[swimmers.FindIndex(ind => ind.Equals(swimmer))] = swim;
                SwimmersSwim[swimmer] = swim;
            }
        }
        public bool Contains(Registrant swimmer)
        {
            foreach (Registrant person in Swimmers)
            {
                if (person.Id == swimmer.Id)
                {
                    return true;
                }
            }
            return false;
        }
        public Swim GetSwimmwersSwim(Registrant swimmer)
        {
            Swim temp;

            if (Contains(swimmer))
            {
                temp = SwimmersSwim[swimmer];
            }
            else
            {
                throw new Exception("Swimmer has not entered event");
            }
            return temp;
        }
        //}
    }
}
