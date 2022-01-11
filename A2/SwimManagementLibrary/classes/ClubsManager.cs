using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary.structs;

namespace SwimManagementLibrary.classes
{
    public class ClubsManager
    {
        public List<Club> Clubs { get; }

        public ClubsManager()
        {
            Clubs = new List<Club>();
        }

        public void AddClub(Club aClub)
        {
            Clubs.Add(aClub);
        }

        private string formatRecord(Club aClub, string delimiter)
        {
            return $"{aClub.ClubNumber}{delimiter}" +
                $"{aClub.Name}{delimiter}" +
                $"{aClub.ClubAddress.Street}{delimiter}" +
                $"{aClub.ClubAddress.City}{delimiter}" +
                $"{aClub.ClubAddress.Province}{delimiter}" +
                $"{aClub.ClubAddress.PostalCode}{delimiter}" +
                $"{aClub.PhoneNumber}{delimiter}";
        }

        public Club GetClub(uint regNumber)
        {
            foreach (Club club in Clubs)
            {
                if (club.ClubNumber == regNumber)
                {
                    return club;
                }
            }
            return null;
        }

        public void LoadClubs(String fileName, string delimiter)
        {
            string clubRecord;
            try
            {
                using (StreamReader file = new StreamReader(fileName))
                {
                    while (!file.EndOfStream)
                    {
                        clubRecord = file.ReadLine();
                        Clubs.Add(processClubRecord(clubRecord, delimiter));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception($"File {fileName} not found");
            }
        }

        private Club processClubRecord(string aRecord, string delimiter)
        {
            string[] clubInfo = aRecord.Split(delimiter.ToCharArray());
            if (clubInfo.Length < 7)
                throw new Exception($"Invalid club record. Not enough fields\n\t{aRecord}");

            string street = clubInfo[2];
            string city = clubInfo[3];
            string prov = clubInfo[4];
            string postCode = clubInfo[5];
            Address address = new Address(street, city, prov, postCode);

            uint id;
            string name;
            ulong phone;
            try
            {
                id = UInt32.Parse(clubInfo[0]);
            }
            catch (FormatException)
            {
                throw new Exception($"Invalid club record. Club number is not valid\n\t{aRecord}");
            }

            name = clubInfo[1];
            if (name.Length == 0)
            {
                throw new Exception($"Invalid club record. Invalid club name\n\t{aRecord}");
            }

            try
            {
                phone = UInt64.Parse(clubInfo[6]);
            }
            catch (FormatException)
            {
                throw new Exception($"Invalid club record. Phone number wrong format\n\t{aRecord}");
            }

            if (GetClub(id) != null)
            {
                throw new Exception($"Invalid club record. Club with the registration already exists\n\t{aRecord}");
            }

            return new Club(id, name, address, phone);
        }

        public void SaveClubs(string fileName, string delimiter)
        {
            try
            {
                using (TextWriter file = new StreamWriter(fileName))
                {
                    foreach (Club club in Clubs)
                    {
                        file.WriteLine(formatRecord(club, delimiter));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception($"File {fileName} not found");
            }
        }

    }
}
