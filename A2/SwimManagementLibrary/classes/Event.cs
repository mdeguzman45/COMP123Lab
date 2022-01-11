using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary.enums;

namespace SwimManagementLibrary.classes
{
    public class Event
    {
        private RegistrantsSwims swimmingEvents;

        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Registrant> Swimmers { 
            get
            {
                return swimmingEvents.Swimmers;
            }
        }

        public Event()
        {
            swimmingEvents = new RegistrantsSwims();
        }
        
        // TODO: use constructor initializer
        public Event(EventDistance distance, Stroke stroke)
        {
            Distance = distance;
            Stroke = stroke;
        }

        public override string ToString()
        {
            string eventInformation;
            string eventDistance = "";

            switch(Distance)
            {
                case EventDistance._50: eventDistance = "50M"; break;
                case EventDistance._100: eventDistance = "100M"; break;
                case EventDistance._200: eventDistance = "200M"; break;
                case EventDistance._400: eventDistance = "400M"; break;
                case EventDistance._800: eventDistance = "800M"; break;
                case EventDistance._1500: eventDistance = "1500M"; break;
            }

            eventInformation = $"Distance: {eventDistance}, Stroke: {Stroke}\nList of Swimmers:\n";
            foreach (Registrant swimmer in Swimmers)
            {
                try
                {
                    Swim swimmerSwim = swimmingEvents.GetSwimmersSwim(swimmer);
                    if (swimmerSwim == null)
                    {
                        eventInformation += $"Swimmer: {swimmer.Name}, Swim: Not seeded/no swim.\n";
                    }
                    else
                    {
                        eventInformation += $"Swimmer: {swimmer.Name}, Swim: {swimmerSwim}.\n";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            return eventInformation;
        }

        public void AddSwimmer(Registrant aSwimmer)
        {
            // check if swimmer is already on the event
            if (swimmingEvents.Contains(aSwimmer))
            {
                throw new Exception($"Swimmer {aSwimmer.Name}, {aSwimmer.Id} is already entered.");
            }
            else
            {
                // add to the Registrants swim
                swimmingEvents.AddOrUpdate(aSwimmer, null);
            }
        }

        public void EnterSwimmersTime(Registrant aSwimmer, string time)
        {
            Swim swimmersSwim = swimmingEvents.GetSwimmersSwim(aSwimmer);
            DateTime formattedTime = default;

            try
            {
                // update the swimmers time
                formattedTime = DateTime.Parse(time);
                swimmersSwim.Time = formattedTime;
                swimmingEvents.AddOrUpdate(aSwimmer, swimmersSwim);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Seed(byte maxLanes)
        {
            try
            {
                int maxNumberOfLanes = Convert.ToInt32(maxLanes);
                int heatCounter = 1;
                int laneCounter = 1;   
                foreach (Registrant aSwimmer in Swimmers)
                {
                    ushort swimmerHeat = Convert.ToUInt16(heatCounter);
                    byte swimmerLane = Convert.ToByte(laneCounter);

                    Swim swimmersSeed = new Swim(swimmerHeat, swimmerLane);
                    swimmingEvents.AddOrUpdate(aSwimmer, swimmersSeed);

                    if (laneCounter == maxNumberOfLanes)
                    {
                        heatCounter++;
                        laneCounter = 1;
                        continue;
                    }

                    laneCounter++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private class RegistrantsSwims
        {
            private List<Registrant> swimmers;
            public List<Registrant> Swimmers { get; }
            private List<Swim> swims;

            public RegistrantsSwims()
            {
                swimmers = new List<Registrant>();
                swims = new List<Swim>();
            }

            public void AddOrUpdate(Registrant swimmer, Swim swim)
            {
                if (Contains(swimmer))
                {
                    // update swimmers swim
                    int swimmerIndex = swimmers.FindIndex(aSwimmer => aSwimmer.Id == swimmer.Id);
                    swims[swimmerIndex] = swim;
                }
                else
                {
                    // add the swimmer
                    swimmers.Add(swimmer);

                    // add a blank swim on swims
                    swims.Add(swim);
                }
            }

            public bool Contains(Registrant swimmer)
            {
                // check if the swimmer is already in the list
                return swimmers.Any(aSwimmer => aSwimmer.Id == swimmer.Id);
            }

            public Swim GetSwimmersSwim(Registrant swimmer)
            {
                if (Contains(swimmer))
                {
                    int swimmerIndex = swimmers.FindIndex(aSwimmer => aSwimmer.Id == swimmer.Id);
                    return swims[swimmerIndex];
                }
                else
                {
                    throw new Exception("Swimmer has not entered event");
                }
            }
        }
    }
}
