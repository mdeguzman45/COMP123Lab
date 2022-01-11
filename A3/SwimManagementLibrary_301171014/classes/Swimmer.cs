using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary_301171014.structs;

namespace SwimManagementLibrary_301171014.classes
{
    public class Swimmer : Registrant
    {
        public override Club Club
        {
            get
            {
                return base.Club;
            }
            set
            {
                if (base.Club == null)
                {
                    base.Club = value;
                    if (value != null)
                    {
                        value.AddSwimmer(this);
                    }
                }
                else
                {
                    throw new Exception("Swimmer is registered with a different club");
                }
            }
        }

        public Swimmer() : base()
        {
        }

        public Swimmer(string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber):
            this(RegistrationNumberGenerator.GetNext(), name, dateOfBirth, anAddress, phoneNumber)
        {
        }

        internal Swimmer(uint regNumber, string name, DateTime dateOfBirth, Address anAddress, ulong phoneNumber):
            base(regNumber, name, dateOfBirth, anAddress, phoneNumber)
        {
        }
    }
}
