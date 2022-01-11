using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary.classes;

namespace SwimManagementLibrary.interfaces
{
    public interface IClubsRepository
    {
        List<Club> Clubs { get; }

        void AddClub(Club aClub);
        Club GetClub(uint regNumber);
        void LoadClubs(string fileName, string delimeter);
        void SaveClubs(string fileName, string delimeter);
    }
}
