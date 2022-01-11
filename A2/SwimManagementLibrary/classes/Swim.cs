using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimManagementLibrary.classes
{
    public class Swim
    {
        public ushort Heat { get; set; }
        public byte Lane { get; set; }
        public DateTime Time { get; set; }

        public Swim()
        {
        }

        public Swim(ushort heat, byte lane)
        {
            Heat = heat;
            Lane = lane;
        }

        public override string ToString()
        {
            string swimInformation = $"Heat: {Heat}, Lane: {Lane}, Swim Time: ";
            swimInformation += (Time != null) ? $"{Time}" : "no time";
            
            return swimInformation;
        }
    }
}
