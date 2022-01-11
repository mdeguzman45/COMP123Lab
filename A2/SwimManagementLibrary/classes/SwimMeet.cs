using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary.enums;

namespace SwimManagementLibrary.classes
{
    public class SwimMeet
    {
        // represents the pool type
        public PoolType Course { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte NoOfLanes { get; set; }
        public List<Event> Events { get; }
        public string Name { get; set; }

        public SwimMeet() : this("", DateTime.Now, DateTime.Now, PoolType.SCM, 8)
        {
        }

        // constructor initializer
        public SwimMeet(string name, DateTime start, DateTime end, PoolType course, byte noOfLanes)
        {
            Name = name;
            StartDate = start;
            EndDate = end;
            Course = course;
            NoOfLanes = noOfLanes;
            Events = new List<Event>();
        }

        public override string ToString()
        {
            string meetInformation = $"Name: {Name}, Start Date: {StartDate}, End Date: {EndDate}, Course: {Course}, Number of Lanes: {NoOfLanes}\n";

            foreach (Event anEvent in Events)
            {
                meetInformation += $"{anEvent}";
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
