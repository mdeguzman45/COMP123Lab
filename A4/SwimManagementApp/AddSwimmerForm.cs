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
    public partial class AddSwimmerForm : Form
    {
        Swimmer swimmer;
        public AddSwimmerForm(Swimmer swimmer)
        {

            InitializeComponent();
            this.swimmer = swimmer;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //lblTest.Text = "ok";
            try
            {
                if (txtSwimmerName.Text != "")
                {
                    swimmer.Name = txtSwimmerName.Text;
                }
                else
                    throw new Exception("Missing Swimmer's Name");
                swimmer.DateOfBirth = Convert.ToDateTime(dtSwmmerDob.Value);
                swimmer.Address = new Address(txtSwimmersStreet.Text, txtSwimmersCity.Text, txtSwimmersProvince.Text, txtSwimmersZip.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                swimmer.PhoneNumber = Convert.ToUInt64(txtSwimmersPhone.Text);
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
