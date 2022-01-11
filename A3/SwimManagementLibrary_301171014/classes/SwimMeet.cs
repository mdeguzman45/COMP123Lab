using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary_301171014.enums;

namespace SwimManagementLibrary_301171014.classes
{
    public class SwimMeet
    {
        // represents the pool type
        public PoolType Course { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte NoOfLanes { get; set; }
        public List<Event> Events { get; } = new List<Event>();
        public string Name { get; set; }

        public SwimMeet() : this (String.Empty, default, default, PoolType.SCM, 8)
        {
        }

        public SwimMeet(string name, DateTime start, DateTime end, PoolType course, byte noOfLanes)
        {
            Name = name;
            StartDate = start;
            EndDate = end;
            Course = course;
            NoOfLanes = noOfLanes;
        }

        public override string ToString()
        {
            string meetInformation = $"Swim Meet Name: {Name}\nFrom-to: {StartDate} to {EndDate}\nPool Type: {Course}\nNo Lanes: {NoOfLanes}\nEvents:\n";

            foreach (Event anEvent in Events)
            {
                meetInformation += $"\t{anEvent}\n";
            }

            return meetInformation;
        }

        public void AddEvent(Event anEvent)
        {
            Events.Add(anEvent);
        }

        public void Seed()
        {
            foreach (Event anEvent in Events)
            {
                anEvent.Seed(NoOfLanes);
            }
        }
    }
}

