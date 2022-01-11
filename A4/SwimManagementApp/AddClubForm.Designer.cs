
namespace SwimManagementApp
{
    partial class AddClubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtClubsPhone = new System.Windows.Forms.TextBox();
            this.txtClubsZip = new System.Windows.Forms.TextBox();
            this.txtClubsProvince = new System.Windows.Forms.TextBox();
            this.txtClubsCity = new System.Windows.Forms.TextBox();
            this.lblClubsPhone = new System.Windows.Forms.Label();
            this.lblClubsZip = new System.Windows.Forms.Label();
            this.lblClubsProvince = new System.Windows.Forms.Label();
            this.lblClubsCity = new System.Windows.Forms.Label();
            this.lblClubsStreet = new System.Windows.Forms.Label();
            this.txtClubsStreet = new System.Windows.Forms.TextBox();
            this.lblClubsName = new System.Windows.Forms.Label();
            this.txtClubsName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(320, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 39);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(406, 399);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 39);
            this.btnOk.TabIndex = 52;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtClubsPhone
            // 
            this.txtClubsPhone.Location = new System.Drawing.Point(167, 358);
            this.txtClubsPhone.Name = "txtClubsPhone";
            this.txtClubsPhone.Size = new System.Drawing.Size(319, 22);
            this.txtClubsPhone.TabIndex = 51;
            // 
            // txtClubsZip
            // 
            this.txtClubsZip.Location = new System.Drawing.Point(167, 293);
            this.txtClubsZip.Name = "txtClubsZip";
            this.txtClubsZip.Size = new System.Drawing.Size(319, 22);
            this.txtClubsZip.TabIndex = 50;
            // 
            // txtClubsProvince
            // 
            this.txtClubsProvince.Location = new System.Drawing.Point(167, 230);
            this.txtClubsProvince.MaxLength = 2;
            this.txtClubsProvince.Name = "txtClubsProvince";
            this.txtClubsProvince.Size = new System.Drawing.Size(319, 22);
            this.txtClubsProvince.TabIndex = 49;
            // 
            // txtClubsCity
            // 
            this.txtClubsCity.Location = new System.Drawing.Point(167, 169);
            this.txtClubsCity.Name = "txtClubsCity";
            this.txtClubsCity.Size = new System.Drawing.Size(319, 22);
            this.txtClubsCity.TabIndex = 48;
            // 
            // lblClubsPhone
            // 
            this.lblClubsPhone.AutoSize = true;
            this.lblClubsPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubsPhone.Location = new System.Drawing.Point(72, 356);
            this.lblClubsPhone.Name = "lblClubsPhone";
            this.lblClubsPhone.Size = new System.Drawing.Size(66, 24);
            this.lblClubsPhone.TabIndex = 47;
            this.lblClubsPhone.Text = "Phone";
            // 
            // lblClubsZip
            // 
            this.lblClubsZip.AutoSize = true;
            this.lblClubsZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubsZip.Location = new System.Drawing.Point(98, 291);
            this.lblClubsZip.Name = "lblClubsZip";
            this.lblClubsZip.Size = new System.Drawing.Size(37, 24);
            this.lblClubsZip.TabIndex = 46;
            this.lblClubsZip.Text = "Zip";
            // 
            // lblClubsProvince
            // 
            this.lblClubsProvince.AutoSize = true;
            this.lblClubsProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubsProvince.Location = new System.Drawing.Point(54, 228);
            this.lblClubsProvince.Name = "lblClubsProvince";
            this.lblClubsProvince.Size = new System.Drawing.Size(84, 24);
            this.lblClubsProvince.TabIndex = 45;
            this.lblClubsProvince.Text = "Province";
            // 
            // lblClubsCity
            // 
            this.lblClubsCity.AutoSize = true;
            this.lblClubsCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubsCity.Location = new System.Drawing.Point(98, 167);
            this.lblClubsCity.Name = "lblClubsCity";
            this.lblClubsCity.Size = new System.Drawing.Size(40, 24);
            this.lblClubsCity.TabIndex = 44;
            this.lblClubsCity.Text = "City";
            // 
            // lblClubsStreet
            // 
            this.lblClubsStreet.AutoSize = true;
            this.lblClubsStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubsStreet.Location = new System.Drawing.Point(80, 106);
            this.lblClubsStreet.Name = "lblClubsStreet";
            this.lblClubsStreet.Size = new System.Drawing.Size(58, 24);
            this.lblClubsStreet.TabIndex = 43;
            this.lblClubsStreet.Text = "Street";
            // 
            // txtClubsStreet
            // 
            this.txtClubsStreet.Location = new System.Drawing.Point(167, 108);
            this.txtClubsStreet.Name = "txtClubsStreet";
            this.txtClubsStreet.Size = new System.Drawing.Size(319, 22);
            this.txtClubsStreet.TabIndex = 41;
            // 
            // lblClubsName
            // 
            this.lblClubsName.AutoSize = true;
            this.lblClubsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubsName.Location = new System.Drawing.Point(77, 39);
            this.lblClubsName.Name = "lblClubsName";
            this.lblClubsName.Size = new System.Drawing.Size(61, 24);
            this.lblClubsName.TabIndex = 40;
            this.lblClubsName.Text = "Name";
            // 
            // txtClubsName
            // 
            this.txtClubsName.Location = new System.Drawing.Point(167, 41);
            this.txtClubsName.Name = "txtClubsName";
            this.txtClubsName.Size = new System.Drawing.Size(319, 22);
            this.txtClubsName.TabIndex = 39;
            // 
            // AddClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtClubsPhone);
            this.Controls.Add(this.txtClubsZip);
            this.Controls.Add(this.txtClubsProvince);
            this.Controls.Add(this.txtClubsCity);
            this.Controls.Add(this.lblClubsPhone);
            this.Controls.Add(this.lblClubsZip);
            this.Controls.Add(this.lblClubsProvince);
            this.Controls.Add(this.lblClubsCity);
            this.Controls.Add(this.lblClubsStreet);
            this.Controls.Add(this.txtClubsStreet);
            this.Controls.Add(this.lblClubsName);
            this.Controls.Add(this.txtClubsName);
            this.Name = "AddClubForm";
            this.Text = "Add Club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtClubsPhone;
        private System.Windows.Forms.TextBox txtClubsZip;
        private System.Windows.Forms.TextBox txtClubsProvince;
        private System.Windows.Forms.TextBox txtClubsCity;
        private System.Windows.Forms.Label lblClubsPhone;
        private System.Windows.Forms.Label lblClubsZip;
        private System.Windows.Forms.Label lblClubsProvince;
        private System.Windows.Forms.Label lblClubsCity;
        private System.Windows.Forms.Label lblClubsStreet;
        private System.Windows.Forms.TextBox txtClubsStreet;
        private System.Windows.Forms.Label lblClubsName;
        private System.Windows.Forms.TextBox txtClubsName;
    }
}