using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary_301171014.classes;

namespace SwimManagementLibrary_301171014.interfaces
{
    public interface ISwimmersRepository
    {
        IClubsRepository ClubsManager { get; set; }
        List<Swimmer> Swimmers { get; }

        void AddSwimmer(Swimmer aSwimmer);
        Swimmer GetSwimmer(uint regNumber);
        void LoadSwimmers(string fileName, string delimeter);
        void SaveSwimmers(string fileName, string delimeter);
    }
}
