using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary_301171014.enums;

namespace SwimManagementLibrary_301171014.classes
{
    public class Event
    {
        private RegistrantsSwims swimmingEvents;

        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Registrant> Swimmers
        {
            get
            {
                return swimmingEvents.swimmers;
            }
        }

        public Event() : this(default, default)
        {
        }

        public Event(EventDistance distance, Stroke stroke)
        {
            Distance = distance;
            Stroke = stroke;
            swimmingEvents = new RegistrantsSwims()
            {
                swims = new List<Swim>(),
                swimmers = new List<Registrant>()
            };

        }

        public override string ToString()
        {
            string eventInformation;

            eventInformation = $"{Distance} {Stroke}\n\tSwimmers:\n";
            foreach (Registrant swimmer in Swimmers)
            {
                //try
                //{
                    Swim swimmerSwim = swimmingEvents.GetSwimmersSwim(swimmer);
                    if (swimmerSwim == null)
                    {
                        eventInformation += $"\t{swimmer.Name}\n\t\tNot seeded/no swim\n";
                    }
                    else
                    {
                        eventInformation += $"\t{swimmer.Name}\n\t\t{swimmerSwim}\n";
                    }
                //}
                //catch (Exception ex)
                //{
                //    throw new Exception(ex.Message);
                //    continue;
                //}
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
                //formattedTime = DateTime.ParseExact(time, "mm:ss.FF", System.Globalization.CultureInfo.InvariantCulture);
                formattedTime = DateTime.ParseExact(time, "HH:mm.FF", System.Globalization.CultureInfo.InvariantCulture);
                swimmersSwim.Time = formattedTime;
                swimmingEvents.AddOrUpdate(aSwimmer, swimmersSwim);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                throw new Exception(ex.Message);
            }

        }

        private class RegistrantsSwims
        {
            public List<Registrant> swimmers;
            public List<Swim> swims;

            public void AddOrUpdate(Registrant swimmer, Swim swim)
            {
                if (Contains(swimmer))
                {
                    // update swimmers swim
                    int swimIndex = getSwimIndex(swimmer);
                    swims[swimIndex] = swim;
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
                bool isSwimmerOnList = false;
                foreach (Registrant aSwimmer in swimmers)
                {
                    if (aSwimmer.Id == swimmer.Id)
                    {
                        isSwimmerOnList = true;
                        break;
                    }
                }

                return isSwimmerOnList;
            }

            public Swim GetSwimmersSwim(Registrant swimmer)
            {
                if (Contains(swimmer))
                {
                    int swimIndex = getSwimIndex(swimmer);
                    return swims[swimIndex];
                }
                else
                {
                    throw new Exception("Swimmer has not entered event");
                }
            }

            // helper function to get swim index of a swimmer
            private int getSwimIndex(Registrant swimmer)
            {
                int swimIndex = default;
                for (int x = 0; x < swimmers.Count; x++)
                {
                    Registrant aSwimmer = swimmers[x];
                    if (aSwimmer.Id == swimmer.Id)
                    {
                        swimIndex = x;
                        break;
                    }
                }

                return swimIndex;
            }
        }
    }
}
