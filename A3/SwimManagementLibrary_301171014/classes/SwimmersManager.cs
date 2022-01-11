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
    public class SwimmersManager : ISwimmersRepository
    {
        public IClubsRepository ClubsManager { get; set; }
        public List<Swimmer> Swimmers { get; } = new List<Swimmer>();

        public SwimmersManager(IClubsRepository manager)
        {
            ClubsManager = manager;
        }

        public void AddSwimmer(Swimmer aSwimmer)
        {
            // only add the swimmer if it does not exist yet
            if (GetSwimmer(aSwimmer.Id) == null)
            {
                Swimmers.Add(aSwimmer);
                if (aSwimmer.Club != null)
                {
                    ClubsManager.AddClub(aSwimmer.Club);
                }
            }
        }

        private string formatRecord(Registrant aSwimmer, string delimiter)
        {
            string result = $"{aSwimmer.Id}{delimiter}" +
                    $"{aSwimmer.Name}{delimiter}" +
                    $"{aSwimmer.DateOfBirth}{delimiter}" +
                    $"{aSwimmer.Address.Street}{delimiter}" +
                    $"{aSwimmer.Address.City}{delimiter}" +
                    $"{aSwimmer.Address.Province}{delimiter}" +
                    $"{aSwimmer.Address.PostalCode}{delimiter}" +
                    $"{aSwimmer.PhoneNumber}{delimiter}";
            if (aSwimmer.Club != null)
            {
                result += $"{aSwimmer.Club.ClubNumber}";
            }

            return result;
        }

        public Swimmer GetSwimmer(uint regNumber)
        {
            foreach (Swimmer aSwimmer in Swimmers)
            {
                if (aSwimmer.Id == regNumber)
                    return aSwimmer;
            }
            return null;
        }

        public void LoadSwimmers(string fileName, string delimiter)
        {
            string swimmerRecord;
            StreamReader reader = default;
            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        swimmerRecord = reader.ReadLine();
                        try
                        {
                            Swimmers.Add(processSwimmerRecord(swimmerRecord, delimiter));
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

        private Swimmer processSwimmerRecord(string aRecord, string delimiter)
        {
            string[] swimmerInfo = aRecord.Split(delimiter[0]);
            if (swimmerInfo.Length < 9)
            {
                throw new Exception($"Invalid swimmer record. Not enough fields\n\t{aRecord}");
            }

            string street = swimmerInfo[3];
            string city = swimmerInfo[4];
            string prov = swimmerInfo[5];
            string postCode = swimmerInfo[6];
            Address address = new Address(street, city, prov, postCode);

            uint id = default;
            string name;
            DateTime dob = default;
            ulong phone = default;
            uint clubRegNum;

            try
            {
                id = UInt32.Parse(swimmerInfo[0]);
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    throw new Exception($"Invalid swimmer record. Invalid registration number\n\t{aRecord}");
                }
            }

            name = swimmerInfo[1];
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception($"Invalid swimmer record. Invalid swimmer name\n\t{aRecord}");
            }

            try
            {
                dob = DateTime.Parse(swimmerInfo[2]);
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is ArgumentNullException)
                {
                    throw new Exception($"Invalid swimmer record. Birth date is invalid\n\t{aRecord}");
                }
            }

            try
            {
                phone = UInt64.Parse(swimmerInfo[7]);
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException)
                {
                    throw new Exception($"Invalid swimmer record. Phone number wrong format\n\t{aRecord}");
                }
            }

            if (GetSwimmer(id) != null)
            {
                throw new Exception($"Invalid swimmer record. Swimmer with the registration number already exists\n\t{aRecord}");
            }

            Club theClub = default;
            if (string.IsNullOrEmpty(swimmerInfo[8]))
            {
                theClub = null;
            }
            else
            {
                try
                {
                    clubRegNum = UInt32.Parse(swimmerInfo[8]);
                    theClub = ClubsManager.GetClub(clubRegNum);

                    if (theClub == null)
                    {
                        throw new Exception($"Invalid swimmer record. Club affiliation exists but not valid\n\t{aRecord}");
                    }     
                }
                catch (Exception ex)
                {
                    if (ex is FormatException || ex is OverflowException)
                    {
                        throw new Exception($"Invalid swimmer record. Club affiliation exists but not valid\n\t{aRecord}");
                    }
                }
            }

            Swimmer newSwimmer = new Swimmer(id, name, dob, address, phone)
            {
                Club = theClub
            };

            return newSwimmer;
        }

        public void SaveSwimmers(string fileName, string delimiter)
        {
            TextWriter writer = default;
            try
            {
                using (writer = new StreamWriter(fileName))
                {
                    foreach (Swimmer aSwimmer in Swimmers)
                    {
                        writer.WriteLine(formatRecord(aSwimmer, delimiter));
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
