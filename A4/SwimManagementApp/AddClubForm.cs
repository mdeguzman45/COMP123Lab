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
    public partial class AddClubForm : Form
    {
        Club club;
        public AddClubForm(Club club)
        {
            InitializeComponent();
            this.club = club;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //lblTest.Text = "ok";
            try
            {
                if (txtClubsName.Text != "")
                {
                    club.Name = txtClubsName.Text;
                }
                else
                    throw new Exception("Club's Name");
                club.ClubAddress = new Address(txtClubsStreet.Text, txtClubsCity.Text, txtClubsProvince.Text, txtClubsZip.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                club.PhoneNumber = Convert.ToUInt64(txtClubsPhone.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Phone");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
