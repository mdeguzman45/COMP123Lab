
namespace SwimManagementApp
{
    partial class SwimManagementApp
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
            this.btnSaveSwimmers = new System.Windows.Forms.Button();
            this.btnLoadSwimmers = new System.Windows.Forms.Button();
            this.swimmerFileLoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveClub = new System.Windows.Forms.Button();
            this.btnLoadClub = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clubFileLoc = new System.Windows.Forms.TextBox();
            this.lstSwimmers = new System.Windows.Forms.ListBox();
            this.lstClubs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddClub = new System.Windows.Forms.Button();
            this.btnAddSwimmer = new System.Windows.Forms.Button();
            this.btnAssignSwimmerToClub = new System.Windows.Forms.Button();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblSwimmer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveSwimmers
            // 
            this.btnSaveSwimmers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSwimmers.Location = new System.Drawing.Point(944, 430);
            this.btnSaveSwimmers.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSwimmers.Name = "btnSaveSwimmers";
            this.btnSaveSwimmers.Size = new System.Drawing.Size(173, 37);
            this.btnSaveSwimmers.TabIndex = 24;
            this.btnSaveSwimmers.Text = "Save Swimmers";
            this.btnSaveSwimmers.UseVisualStyleBackColor = true;
            this.btnSaveSwimmers.Click += new System.EventHandler(this.btnSaveSwimmers_Click);
            // 
            // btnLoadSwimmers
            // 
            this.btnLoadSwimmers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSwimmers.Location = new System.Drawing.Point(752, 430);
            this.btnLoadSwimmers.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadSwimmers.Name = "btnLoadSwimmers";
            this.btnLoadSwimmers.Size = new System.Drawing.Size(168, 37);
            this.btnLoadSwimmers.TabIndex = 23;
            this.btnLoadSwimmers.Text = "Load Swimmers";
            this.btnLoadSwimmers.UseVisualStyleBackColor = true;
            this.btnLoadSwimmers.Click += new System.EventHandler(this.btnLoadSwimmers_Click);
            // 
            // swimmerFileLoc
            // 
            this.swimmerFileLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerFileLoc.Location = new System.Drawing.Point(862, 397);
            this.swimmerFileLoc.Margin = new System.Windows.Forms.Padding(4);
            this.swimmerFileLoc.Name = "swimmerFileLoc";
            this.swimmerFileLoc.Size = new System.Drawing.Size(255, 28);
            this.swimmerFileLoc.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(622, 397);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Swimmers File Location:";
            // 
            // btnSaveClub
            // 
            this.btnSaveClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClub.Location = new System.Drawing.Point(361, 430);
            this.btnSaveClub.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveClub.Name = "btnSaveClub";
            this.btnSaveClub.Size = new System.Drawing.Size(144, 37);
            this.btnSaveClub.TabIndex = 20;
            this.btnSaveClub.Text = "Save Clubs";
            this.btnSaveClub.UseVisualStyleBackColor = true;
            this.btnSaveClub.Click += new System.EventHandler(this.btnSaveClub_Click);
            // 
            // btnLoadClub
            // 
            this.btnLoadClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadClub.Location = new System.Drawing.Point(213, 430);
            this.btnLoadClub.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadClub.Name = "btnLoadClub";
            this.btnLoadClub.Size = new System.Drawing.Size(140, 37);
            this.btnLoadClub.TabIndex = 19;
            this.btnLoadClub.Text = "Load Clubs";
            this.btnLoadClub.UseVisualStyleBackColor = true;
            this.btnLoadClub.Click += new System.EventHandler(this.btnLoadClub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 397);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Club File Location:";
            // 
            // clubFileLoc
            // 
            this.clubFileLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubFileLoc.Location = new System.Drawing.Point(245, 394);
            this.clubFileLoc.Margin = new System.Windows.Forms.Padding(4);
            this.clubFileLoc.Name = "clubFileLoc";
            this.clubFileLoc.Size = new System.Drawing.Size(260, 28);
            this.clubFileLoc.TabIndex = 17;
            // 
            // lstSwimmers
            // 
            this.lstSwimmers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSwimmers.FormattingEnabled = true;
            this.lstSwimmers.ItemHeight = 22;
            this.lstSwimmers.Location = new System.Drawing.Point(680, 95);
            this.lstSwimmers.Margin = new System.Windows.Forms.Padding(4);
            this.lstSwimmers.Name = "lstSwimmers";
            this.lstSwimmers.Size = new System.Drawing.Size(437, 224);
            this.lstSwimmers.TabIndex = 16;
            this.lstSwimmers.SelectedIndexChanged += new System.EventHandler(this.lstSwimmers_SelectedIndexChanged);
            // 
            // lstClubs
            // 
            this.lstClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClubs.FormattingEnabled = true;
            this.lstClubs.ItemHeight = 22;
            this.lstClubs.Location = new System.Drawing.Point(68, 95);
            this.lstClubs.Margin = new System.Windows.Forms.Padding(4);
            this.lstClubs.Name = "lstClubs";
            this.lstClubs.Size = new System.Drawing.Size(437, 224);
            this.lstClubs.TabIndex = 15;
            this.lstClubs.SelectedIndexChanged += new System.EventHandler(this.lstClubs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Swimmers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clubs";
            // 
            // btnAddClub
            // 
            this.btnAddClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClub.Location = new System.Drawing.Point(386, 326);
            this.btnAddClub.Name = "btnAddClub";
            this.btnAddClub.Size = new System.Drawing.Size(120, 43);
            this.btnAddClub.TabIndex = 26;
            this.btnAddClub.Text = "Add Club";
            this.btnAddClub.UseVisualStyleBackColor = true;
            this.btnAddClub.Click += new System.EventHandler(this.btnAddClub_Click);
            // 
            // btnAddSwimmer
            // 
            this.btnAddSwimmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSwimmer.Location = new System.Drawing.Point(978, 326);
            this.btnAddSwimmer.Name = "btnAddSwimmer";
            this.btnAddSwimmer.Size = new System.Drawing.Size(148, 47);
            this.btnAddSwimmer.TabIndex = 27;
            this.btnAddSwimmer.Text = "Add Swimmer";
            this.btnAddSwimmer.UseVisualStyleBackColor = true;
            this.btnAddSwimmer.Click += new System.EventHandler(this.btnAddSwimmer_Click);
            // 
            // btnAssignSwimmerToClub
            // 
            this.btnAssignSwimmerToClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignSwimmerToClub.Location = new System.Drawing.Point(801, 326);
            this.btnAssignSwimmerToClub.Name = "btnAssignSwimmerToClub";
            this.btnAssignSwimmerToClub.Size = new System.Drawing.Size(171, 47);
            this.btnAssignSwimmerToClub.TabIndex = 28;
            this.btnAssignSwimmerToClub.Text = "Assign Swimmer";
            this.btnAssignSwimmerToClub.UseVisualStyleBackColor = true;
            this.btnAssignSwimmerToClub.Click += new System.EventHandler(this.btnAssignSwimmerToClub_Click);
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(65, 507);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(0, 17);
            this.lblClub.TabIndex = 29;
            // 
            // lblSwimmer
            // 
            this.lblSwimmer.AutoSize = true;
            this.lblSwimmer.Location = new System.Drawing.Point(749, 507);
            this.lblSwimmer.Name = "lblSwimmer";
            this.lblSwimmer.Size = new System.Drawing.Size(0, 17);
            this.lblSwimmer.TabIndex = 30;
            // 
            // SwimManagementApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 729);
            this.Controls.Add(this.lblSwimmer);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.btnAssignSwimmerToClub);
            this.Controls.Add(this.btnAddSwimmer);
            this.Controls.Add(this.btnAddClub);
            this.Controls.Add(this.btnSaveSwimmers);
            this.Controls.Add(this.btnLoadSwimmers);
            this.Controls.Add(this.swimmerFileLoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveClub);
            this.Controls.Add(this.btnLoadClub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clubFileLoc);
            this.Controls.Add(this.lstSwimmers);
            this.Controls.Add(this.lstClubs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SwimManagementApp";
            this.Text = "Swim Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveSwimmers;
        private System.Windows.Forms.Button btnLoadSwimmers;
        private System.Windows.Forms.TextBox swimmerFileLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveClub;
        private System.Windows.Forms.Button btnLoadClub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clubFileLoc;
        private System.Windows.Forms.ListBox lstSwimmers;
        private System.Windows.Forms.ListBox lstClubs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.Button btnAddSwimmer;
        private System.Windows.Forms.Button btnAssignSwimmerToClub;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblSwimmer;
    }
}

