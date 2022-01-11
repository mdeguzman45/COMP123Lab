using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwimManagementLibrary_301171014.interfaces;
using SwimManagementLibrary_301171014.structs;

namespace SwimManagementLibrary_301171014.classes
{
    public class ClubsManager : IClubsRepository
    {
        public List<Club> Clubs { get; } = new List<Club>();

        public void AddClub(Club aClub)
        {
            // only add the club if it does not exist yet
            if (GetClub(aClub.ClubNumber) == null)
            {
                Clubs.Add(aClub);
            }
        }

        private string formatRecord(Club aClub, string delimiter)
        {
            return $"{aClub.ClubNumber}{delimiter}" +
                $"{aClub.Name}{delimiter}" +
                $"{aClub.ClubAddress.Street}{delimiter}" +
                $"{aClub.ClubAddress.City}{delimiter}" +
                $"{aClub.ClubAddress.Province}{delimiter}" +
                $"{aClub.ClubAddress.PostalCode}{delimiter}" +
                $"{aClub.PhoneNumber}";
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
            StreamReader reader = default;
            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        clubRecord = reader.ReadLine();
                        try
                        {
                            Clubs.Add(processClubRecord(clubRecord, delimiter));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new Exception($"File {fileName} not found.");
            }
            catch (DirectoryNotFoundException)
            {
                throw new Exception($"Directory not found {fileName}.");
            }
            catch (IOException)
            {
                throw new Exception($"Error reading from file {fileName}.");
            }
            catch (Exception)
            {
                throw new Exception($"Error accessing File {fileName}.");
            }

            if (reader != null)
            {
                reader.Close();
            }
        }

        private Club processClubRecord(string aRecord, string delimiter)
        {
            string[] clubInfo = aRecord.Split(delimiter[0]);
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
            TextWriter writer = default;
            try
            {
                using (writer = new StreamWriter(fileName))
                {
                    foreach (Club club in Clubs)
                    {
                        writer.WriteLine(formatRecord(club, delimiter));
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                throw new Exception($"Unauthorized access on {fileName}.");
            }
            catch (DirectoryNotFoundException)
            {
                throw new Exception($"Directory not found {fileName}.");
            }
            catch (IOException)
            {
                throw new Exception($"Error writing to file {fileName}.");
            }
            catch (Exception)
            {
                throw new Exception($"Error accessing File {fileName}.");
            }

            if (writer != null)
            {
                writer.Close();
            }
        }
    }
}
