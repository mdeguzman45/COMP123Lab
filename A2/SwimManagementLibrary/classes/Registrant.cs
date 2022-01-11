using SwimManagementLibrary.structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.classes
{
    public class Registrant
    {
        private Club club;

        public Club Club
        {
            get
            {
                return club;
            }
            set
            {
                if (club == null)
                {
                    club = value;
                }
                else
                {
                    throw new Exception("Swimmer is registered with a different club");
                }
            }
        }
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public uint Id { get; }
        public string Name { get; set; }
        public ulong PhoneNumber { get; set; }

        public Registrant()
        {
            Id = RegistrationNumberGenerator.GetNext();
        }

        // TODO: use constructor initializer
        public Registrant(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber)
        {
            Id = RegistrationNumberGenerator.GetNext();
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = anAddress;
            PhoneNumber = phoneNumber;
        }

        // TODO: use constructor initializer
        // used only internally within the library
        internal Registrant(uint regNumber, string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber)
        {
            Id = regNumber;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = anAddress;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            string registrantInformation = $"Name: {Name}\nAddress: {Address}\n";
            registrantInformation += (club != null) ? $"Club: {club.Name}" : "Not Assigned";

            return registrantInformation;
        }
    }
}
