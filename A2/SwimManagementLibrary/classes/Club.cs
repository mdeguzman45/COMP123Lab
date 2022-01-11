using SwimManagementLibrary.structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.classes
{
    public class Club
    {
        public Address ClubAddress { get; set; }
        public uint ClubNumber { get; set; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }
        private List<Registrant> Swimmers { get; }

        public Club()
        {
            ClubNumber = RegistrationNumberGenerator.GetNext();
            Swimmers = new List<Registrant>();
        }

        public Club(string name, Address anAddress, ulong phoneNumber)
        {
            Name = name;
            ClubAddress = anAddress;
            PhoneNumber = phoneNumber;
            Swimmers = new List<Registrant>();
        }

        internal Club(uint regNumber, string name, Address anAddress, ulong phoneNumber)
        {
            Name = name;
            ClubAddress = anAddress;
            PhoneNumber = phoneNumber;
            ClubNumber = regNumber;
            Swimmers = new List<Registrant>();
        }

        public void AddSwimmer(Registrant aSwimmer)
        {
            Swimmers.Add(aSwimmer);
        }

        public override string ToString()
        {
            string record = $"Name: {Name}\n" +
                $"Address: {ClubAddress}\n" +
                $"Phone: {PhoneNumber}\n" +
                $"Reg number: {ClubNumber}\n" +
                $"Swimmers: ";
            foreach (Registrant swimmer in Swimmers)
                record += $"\n\t{swimmer.Name}";
            return record;
        }
    }
}
