using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimManagementLibrary.classes;
using SwimManagementLibrary.structs;
using SwimManagementLibrary.interfaces;

namespace SwimManagementApp
{
    public partial class SwimManagementApp : Form
    {
        // clubs manager and swimmers manager
        IClubsRepository clbMngr;
        ISwimmersRepository swmMngr;
        List<Club> clubs = new List<Club>();
        List<Registrant> swimmers = new List<Registrant>();

        public SwimManagementApp()
        {
            InitializeComponent();
            clbMngr = new ClubsManager();
            swmMngr = new SwimmersManager(clbMngr);
        }

        private void btnLoadClub_Click(object sender, EventArgs e)
        {
            if (clubFileLoc.Text == string.Empty)
            {
                showMessage("Club file location is blank", "Error");
                return;
            }

            try
            {
                clbMngr.LoadClubs(clubFileLoc.Text, ",");
            }
            catch (Exception ex)
            {
                showMessage(ex.Message, "Error");
                return;
            }

            for (int i = 0; i < clbMngr.Clubs.Count; i++)
            {
                Club aClub = clbMngr.Clubs[i];
                // only add if the club is not yet on the list
                if (!isClubOnList(aClub))
                {
                    clubs.Add(aClub);
                    lstClubs.Items.Add(aClub);
                }
            }

            clubFileLoc.Text = string.Empty;
        }

        private void btnSaveClub_Click(object sender, EventArgs e)
        {
            if (clubFileLoc.Text == string.Empty)
            {
                showMessage("Club file location is blank", "Error");
                return;
            }

            try
            {
                clbMngr.SaveClubs(clubFileLoc.Text, "|");
            }
            catch (Exception ex)
            {
                showMessage(ex.Message, "Error");
                return;
            }

            showMessage($"Clubs saved successful on {clubFileLoc.Text}", "Success");
            clubFileLoc.Text = string.Empty;
        }

        private void btnLoadSwimmers_Click(object sender, EventArgs e)
        {
            if (swimmerFileLoc.Text == string.Empty)
            {
                showMessage("Swimmers file location is blank", "Error");
                return;
            }

            try
            {
                swmMngr.LoadSwimmers(swimmerFileLoc.Text, ",");
            }
            catch (Exception ex)
            {
                showMessage(ex.Message, "Error");
                return;
            }

            for (int i = 0; i < swmMngr.Swimmers.Count; i++)
            {
                Registrant aSwimmer = swmMngr.Swimmers[i];
                // only add if the swimmer is not yet on the list
                if (!isSwimmerOnList(aSwimmer))
                {
                    swimmers.Add(aSwimmer);
                    lstSwimmers.Items.Add(aSwimmer);
                }
            }

            swimmerFileLoc.Text = string.Empty;
        }

        private void btnSaveSwimmers_Click(object sender, EventArgs e)
        {
            if (swimmerFileLoc.Text == string.Empty)
            {
                showMessage("Swimmers file location is blank", "Error");
                return;
            }

            try
            {
                swmMngr.SaveSwimmers(swimmerFileLoc.Text, "|");
            }
            catch (Exception ex)
            {
                showMessage(ex.Message, "Error");
                return;
            }

            showMessage($"Swimmers saved successful on {swimmerFileLoc.Text}", "Success");
            swimmerFileLoc.Text = string.Empty;
        }

        private Boolean isClubOnList(Club aClub)
        {
            bool isClubFound = false;
            foreach (Club club in clubs)
            {
                if (club.ClubNumber == aClub.ClubNumber||club.Name==aClub.Name)
                {
                    isClubFound = true;
                    break;
                }
            }

            return isClubFound;
        }

        private Boolean isSwimmerOnList(Registrant aSwimmer)
        {
            bool isSwimmerFound = false;
            foreach (Registrant swimmer in swimmers)
            {
                if (swimmer.Id == aSwimmer.Id)
                {
                    isSwimmerFound = true;
                    break;
                }
            }

            return isSwimmerFound;
        }

        private void showMessage(string alertMsg, string alertType)
        {
            MessageBoxIcon icon = alertType == "Error" ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            MessageBox.Show(alertMsg, alertType, MessageBoxButtons.OK, icon);
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            Club club = new Club();
            AddClubForm addSwimmerForm = new AddClubForm(club);
            DialogResult dialogResult = addSwimmerForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (!isClubOnList(club))
                {
                    clubs.Add(club);
                    lstClubs.Items.Add(club);
                    clbMngr.AddClub(club); // add on the club manager list as well
                    showMessage("Club Entered", "Success");
                }
                else
                {
                    showMessage("Club Already Exists", "Error");
                }
            }
        }

        private void btnAddSwimmer_Click(object sender, EventArgs e)
        {
            Swimmer swimmer = new Swimmer();
            AddSwimmerForm addSwimmerForm = new AddSwimmerForm(swimmer);
            DialogResult dialogResult = addSwimmerForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //swimmersManager.AddSwimmer(swimmer);
                if (!isSwimmerOnList(swimmer))
                {
                    swimmers.Add(swimmer);
                    lstSwimmers.Items.Add(swimmer);
                    swmMngr.AddSwimmer(swimmer); // add on the swimmer manager list as well
                    showMessage("Swimmer Entered", "Success");
                }
                else
                {
                    showMessage("Swimer Already Exists ", "Error");
                }
            }
        }

        private void btnAssignSwimmerToClub_Click(object sender, EventArgs e)
        {
            if (lstSwimmers.Items.Count == 0 || lstClubs.Items.Count == 0)
            {
                showMessage("Empty List, Enter Clubs or Swimmers", "Error");
                return;
            }
            if (!(lstSwimmers.SelectedItem is Swimmer swimmer))
            {
                showMessage("Select Both Club And Swimmer From The List", "Error");
                return;
            }
            if (!(lstClubs.SelectedItem is Club club))
            {
                showMessage("Select Both Club And Swimmer From The List", "Error");
                return;
            }

            Club temp = swimmer.Club;
            if (temp==null)
            {
                club.AddSwimmer(swimmer);
                lstClubs.SelectedItem = club.ToString();
                lstSwimmers.SelectedItem = swimmer.ToString();
                lblClub.Text = string.Empty;
                lblSwimmer.Text = string.Empty;
                showMessage("Swimmer Assigned", "Success");
            }
            else
            {
                showMessage("Swimmer Already assigned to a Club","Error");
            }
        }

        private void lstClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstClubs.SelectedItem is Club club))
                return;
            String s = $"Name: {club.Name}\nAddress: {club.ClubAddress.ToString()}\nPhone: {Convert.ToString(club.PhoneNumber)}" +
                $"\nReg Number: {club.ClubNumber}\nSwimmers: ";
            if (club.Swimmers.Count > 0)
            {
                foreach (Registrant r in club.Swimmers)
                    s += "\n\t" + r.Name;
            }
            Coach coach = club.Coach;
            s += "\nCoach:";
            if (coach == null)
            {
                s += "Not assigned";
            }
            else
            {
                s += coach.Name;
            }
            lblClub.Text = s;
        }

        private void lstSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstSwimmers.SelectedItem is Swimmer swimmer))
                return;
            string s = $"Name: {swimmer.Name}\nAddress: {swimmer.Address}\nPhone: {swimmer.PhoneNumber}\nDOB: {swimmer.DateOfBirth.ToString("yyyy-MM-dd hh:mm:ss tt")}" +
                    $"\nId: {swimmer.Id}\nClub: ";
            Club club = swimmer.Club;
            if (club == null)
            {
                s += "not assigned";
            }
            else
            {
                s+=club.Name;
            }
            lblSwimmer.Text = s;
        }
    }
}
