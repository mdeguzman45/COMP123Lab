
namespace SwimManagementApp
{
    partial class AddSwimmerForm
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
            this.txtSwimmersPhone = new System.Windows.Forms.TextBox();
            this.txtSwimmersZip = new System.Windows.Forms.TextBox();
            this.txtSwimmersProvince = new System.Windows.Forms.TextBox();
            this.txtSwimmersCity = new System.Windows.Forms.TextBox();
            this.lblSwimmerPhone = new System.Windows.Forms.Label();
            this.lblSwimmerZip = new System.Windows.Forms.Label();
            this.lblSwimmerProvince = new System.Windows.Forms.Label();
            this.lblSwimmerCity = new System.Windows.Forms.Label();
            this.lblSwimmerStreet = new System.Windows.Forms.Label();
            this.txtSwimmersStreet = new System.Windows.Forms.TextBox();
            this.lblSwimmerDob = new System.Windows.Forms.Label();
            this.dtSwmmerDob = new System.Windows.Forms.DateTimePicker();
            this.lblSwimmerName = new System.Windows.Forms.Label();
            this.txtSwimmerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(343, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 34);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(429, 404);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 36;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtSwimmersPhone
            // 
            this.txtSwimmersPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwimmersPhone.Location = new System.Drawing.Point(187, 348);
            this.txtSwimmersPhone.Name = "txtSwimmersPhone";
            this.txtSwimmersPhone.Size = new System.Drawing.Size(317, 28);
            this.txtSwimmersPhone.TabIndex = 35;
            // 
            // txtSwimmersZip
            // 
            this.txtSwimmersZip.AllowDrop = true;
            this.txtSwimmersZip.AutoCompleteCustomSource.AddRange(new string[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.txtSwimmersZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwimmersZip.Location = new System.Drawing.Point(187, 291);
            this.txtSwimmersZip.Name = "txtSwimmersZip";
            this.txtSwimmersZip.Size = new System.Drawing.Size(317, 28);
            this.txtSwimmersZip.TabIndex = 34;
            // 
            // txtSwimmersProvince
            // 
            this.txtSwimmersProvince.AutoCompleteCustomSource.AddRange(new string[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NS",
            "NT",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.txtSwimmersProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSwimmersProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtSwimmersProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwimmersProvince.Location = new System.Drawing.Point(187, 238);
            this.txtSwimmersProvince.MaxLength = 2;
            this.txtSwimmersProvince.Name = "txtSwimmersProvince";
            this.txtSwimmersProvince.Size = new System.Drawing.Size(317, 28);
            this.txtSwimmersProvince.TabIndex = 33;
            // 
            // txtSwimmersCity
            // 
            this.txtSwimmersCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwimmersCity.Location = new System.Drawing.Point(187, 182);
            this.txtSwimmersCity.Name = "txtSwimmersCity";
            this.txtSwimmersCity.Size = new System.Drawing.Size(317, 28);
            this.txtSwimmersCity.TabIndex = 32;
            // 
            // lblSwimmerPhone
            // 
            this.lblSwimmerPhone.AutoSize = true;
            this.lblSwimmerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerPhone.Location = new System.Drawing.Point(71, 352);
            this.lblSwimmerPhone.Name = "lblSwimmerPhone";
            this.lblSwimmerPhone.Size = new System.Drawing.Size(66, 24);
            this.lblSwimmerPhone.TabIndex = 31;
            this.lblSwimmerPhone.Text = "Phone";
            // 
            // lblSwimmerZip
            // 
            this.lblSwimmerZip.AutoSize = true;
            this.lblSwimmerZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerZip.Location = new System.Drawing.Point(97, 294);
            this.lblSwimmerZip.Name = "lblSwimmerZip";
            this.lblSwimmerZip.Size = new System.Drawing.Size(37, 24);
            this.lblSwimmerZip.TabIndex = 30;
            this.lblSwimmerZip.Text = "Zip";
            // 
            // lblSwimmerProvince
            // 
            this.lblSwimmerProvince.AutoSize = true;
            this.lblSwimmerProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerProvince.Location = new System.Drawing.Point(53, 242);
            this.lblSwimmerProvince.Name = "lblSwimmerProvince";
            this.lblSwimmerProvince.Size = new System.Drawing.Size(84, 24);
            this.lblSwimmerProvince.TabIndex = 29;
            this.lblSwimmerProvince.Text = "Province";
            // 
            // lblSwimmerCity
            // 
            this.lblSwimmerCity.AutoSize = true;
            this.lblSwimmerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerCity.Location = new System.Drawing.Point(97, 186);
            this.lblSwimmerCity.Name = "lblSwimmerCity";
            this.lblSwimmerCity.Size = new System.Drawing.Size(40, 24);
            this.lblSwimmerCity.TabIndex = 28;
            this.lblSwimmerCity.Text = "City";
            // 
            // lblSwimmerStreet
            // 
            this.lblSwimmerStreet.AutoSize = true;
            this.lblSwimmerStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerStreet.Location = new System.Drawing.Point(76, 138);
            this.lblSwimmerStreet.Name = "lblSwimmerStreet";
            this.lblSwimmerStreet.Size = new System.Drawing.Size(58, 24);
            this.lblSwimmerStreet.TabIndex = 27;
            this.lblSwimmerStreet.Text = "Street";
            // 
            // txtSwimmersStreet
            // 
            this.txtSwimmersStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwimmersStreet.Location = new System.Drawing.Point(187, 134);
            this.txtSwimmersStreet.Name = "txtSwimmersStreet";
            this.txtSwimmersStreet.Size = new System.Drawing.Size(317, 28);
            this.txtSwimmersStreet.TabIndex = 25;
            // 
            // lblSwimmerDob
            // 
            this.lblSwimmerDob.AutoSize = true;
            this.lblSwimmerDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerDob.Location = new System.Drawing.Point(24, 75);
            this.lblSwimmerDob.Name = "lblSwimmerDob";
            this.lblSwimmerDob.Size = new System.Drawing.Size(110, 24);
            this.lblSwimmerDob.TabIndex = 24;
            this.lblSwimmerDob.Text = "Date of Birth";
            // 
            // dtSwmmerDob
            // 
            this.dtSwmmerDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSwmmerDob.Location = new System.Drawing.Point(187, 75);
            this.dtSwmmerDob.Name = "dtSwmmerDob";
            this.dtSwmmerDob.Size = new System.Drawing.Size(317, 28);
            this.dtSwmmerDob.TabIndex = 23;
            // 
            // lblSwimmerName
            // 
            this.lblSwimmerName.AutoSize = true;
            this.lblSwimmerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerName.Location = new System.Drawing.Point(73, 32);
            this.lblSwimmerName.Name = "lblSwimmerName";
            this.lblSwimmerName.Size = new System.Drawing.Size(61, 24);
            this.lblSwimmerName.TabIndex = 22;
            this.lblSwimmerName.Text = "Name";
            // 
            // txtSwimmerName
            // 
            this.txtSwimmerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwimmerName.Location = new System.Drawing.Point(187, 32);
            this.txtSwimmerName.Name = "txtSwimmerName";
            this.txtSwimmerName.Size = new System.Drawing.Size(317, 28);
            this.txtSwimmerName.TabIndex = 21;
            // 
            // AddSwimmerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSwimmersPhone);
            this.Controls.Add(this.txtSwimmersZip);
            this.Controls.Add(this.txtSwimmersProvince);
            this.Controls.Add(this.txtSwimmersCity);
            this.Controls.Add(this.lblSwimmerPhone);
            this.Controls.Add(this.lblSwimmerZip);
            this.Controls.Add(this.lblSwimmerProvince);
            this.Controls.Add(this.lblSwimmerCity);
            this.Controls.Add(this.lblSwimmerStreet);
            this.Controls.Add(this.txtSwimmersStreet);
            this.Controls.Add(this.lblSwimmerDob);
            this.Controls.Add(this.dtSwmmerDob);
            this.Controls.Add(this.lblSwimmerName);
            this.Controls.Add(this.txtSwimmerName);
            this.Name = "AddSwimmerForm";
            this.Text = "Add Swimmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtSwimmersPhone;
        private System.Windows.Forms.TextBox txtSwimmersZip;
        private System.Windows.Forms.TextBox txtSwimmersProvince;
        private System.Windows.Forms.TextBox txtSwimmersCity;
        private System.Windows.Forms.Label lblSwimmerPhone;
        private System.Windows.Forms.Label lblSwimmerZip;
        private System.Windows.Forms.Label lblSwimmerProvince;
        private System.Windows.Forms.Label lblSwimmerCity;
        private System.Windows.Forms.Label lblSwimmerStreet;
        private System.Windows.Forms.TextBox txtSwimmersStreet;
        private System.Windows.Forms.Label lblSwimmerDob;
        private System.Windows.Forms.DateTimePicker dtSwmmerDob;
        private System.Windows.Forms.Label lblSwimmerName;
        private System.Windows.Forms.TextBox txtSwimmerName;
    }
}