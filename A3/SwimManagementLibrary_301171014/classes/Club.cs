using SwimManagementLibrary_301171014.structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary_301171014.classes
{
    public class Club
    {
        private Coach coach;
        public Address ClubAddress { get; set; }
        public uint ClubNumber { get; set; }
        public Coach Coach 
        {
            get
            {
                return coach;
            }
            set
            {
                // handle reassigning of coach
                if (coach != null)
                {
                    if (coach.Club?.ClubNumber != value.Club?.ClubNumber)
                    {
                        coach.Club = null;
                    }
                }

                coach = value;
                value.Club = this;
            }
        }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        public List<Registrant> Swimmers { get; } = new List<Registrant>();

        public Club() :
            this(RegistrationNumberGenerator.GetNext(), string.Empty, new Address("", "", "", ""), 0)
        {

        }

        public Club(string name, Address anAddress, ulong phoneNumber) :
            this(RegistrationNumberGenerator.GetNext(), name, anAddress, phoneNumber)
        {
        }

        internal Club(uint regNumber, string name, Address anAddress, ulong phoneNumber)
        {
            Name = name;
            ClubAddress = anAddress;
            PhoneNumber = phoneNumber;
            ClubNumber = regNumber;
        }

        public void AddSwimmer(Registrant aSwimmer)
        {

            if (aSwimmer.Club != null)
            {
                if (aSwimmer.Club.ClubNumber != ClubNumber)
                {
                    // the swimmer is already a part of another club
                    throw new Exception($"Swimmer already assigned to {aSwimmer.Club.Name}");
                }
            }

            bool isSwimmerOnList = false;
            foreach (Registrant swimmer in Swimmers)
            {
                if (swimmer.Id == aSwimmer.Id)
                {
                    isSwimmerOnList = true;
                    break;
                }
            }

            if (!isSwimmerOnList)
            {
                Swimmers.Add(aSwimmer);
            }

            if (aSwimmer.Club == null)
            {
                aSwimmer.Club = this;
            }
        }

        public override string ToString()
        {
            string coachInformation = (coach != null) ? $"{coach.Name}" : "not assigned";
            string record = $"Name: {Name}\n" +
                $"Address: {ClubAddress}\n" +
                $"Phone: {PhoneNumber}\n" +
                $"Reg number: {ClubNumber}\n" +
                $"Swimmers:";
            foreach (Registrant swimmer in Swimmers)
            {
                record += $"\n  {swimmer.Name}";
            }

            record += $"\nCoach:{coachInformation}";

            return record;
        }
    }
}
