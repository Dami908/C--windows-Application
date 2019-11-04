namespace mainForm
{
    partial class addFaculty
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
            this._btnAddnew = new System.Windows.Forms.Button();
            this._txtPhn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtFacId = new System.Windows.Forms.TextBox();
            this._txtId = new System.Windows.Forms.Label();
            this._txtFacultyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtStreet = new System.Windows.Forms.Label();
            this._txtStreetbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtProvince = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnAddnew
            // 
            this._btnAddnew.Location = new System.Drawing.Point(236, 397);
            this._btnAddnew.Name = "_btnAddnew";
            this._btnAddnew.Size = new System.Drawing.Size(308, 23);
            this._btnAddnew.TabIndex = 12;
            this._btnAddnew.Text = "Add New Faculty";
            this._btnAddnew.UseVisualStyleBackColor = true;
            this._btnAddnew.Click += new System.EventHandler(this._onClickAddNewFaculty);
            // 
            // _txtPhn
            // 
            this._txtPhn.BackColor = System.Drawing.SystemColors.Info;
            this._txtPhn.Location = new System.Drawing.Point(272, 77);
            this._txtPhn.Name = "_txtPhn";
            this._txtPhn.Size = new System.Drawing.Size(185, 20);
            this._txtPhn.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // _txtFacId
            // 
            this._txtFacId.BackColor = System.Drawing.SystemColors.Info;
            this._txtFacId.Location = new System.Drawing.Point(272, 51);
            this._txtFacId.Name = "_txtFacId";
            this._txtFacId.Size = new System.Drawing.Size(185, 20);
            this._txtFacId.TabIndex = 7;
            // 
            // _txtId
            // 
            this._txtId.AutoSize = true;
            this._txtId.Location = new System.Drawing.Point(173, 54);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(55, 13);
            this._txtId.TabIndex = 1;
            this._txtId.Text = "Faculty ID";
            // 
            // _txtFacultyName
            // 
            this._txtFacultyName.BackColor = System.Drawing.SystemColors.Info;
            this._txtFacultyName.Location = new System.Drawing.Point(272, 24);
            this._txtFacultyName.Name = "_txtFacultyName";
            this._txtFacultyName.Size = new System.Drawing.Size(185, 20);
            this._txtFacultyName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Name";
            // 
            // _txtStreet
            // 
            this._txtStreet.AutoSize = true;
            this._txtStreet.Location = new System.Drawing.Point(173, 119);
            this._txtStreet.Name = "_txtStreet";
            this._txtStreet.Size = new System.Drawing.Size(35, 13);
            this._txtStreet.TabIndex = 3;
            this._txtStreet.Text = "Street";
            // 
            // _txtStreetbox
            // 
            this._txtStreetbox.BackColor = System.Drawing.SystemColors.Info;
            this._txtStreetbox.Location = new System.Drawing.Point(272, 112);
            this._txtStreetbox.Name = "_txtStreetbox";
            this._txtStreetbox.Size = new System.Drawing.Size(185, 20);
            this._txtStreetbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "City";
            // 
            // _txtCity
            // 
            this._txtCity.BackColor = System.Drawing.SystemColors.Info;
            this._txtCity.Location = new System.Drawing.Point(272, 150);
            this._txtCity.Name = "_txtCity";
            this._txtCity.Size = new System.Drawing.Size(185, 20);
            this._txtCity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Province";
            // 
            // _txtProvince
            // 
            this._txtProvince.BackColor = System.Drawing.SystemColors.Info;
            this._txtProvince.Location = new System.Drawing.Point(272, 185);
            this._txtProvince.Name = "_txtProvince";
            this._txtProvince.Size = new System.Drawing.Size(185, 20);
            this._txtProvince.TabIndex = 11;
            // 
            // addFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtProvince);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtStreetbox);
            this.Controls.Add(this._txtStreet);
            this.Controls.Add(this._btnAddnew);
            this.Controls.Add(this._txtPhn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtFacId);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._txtFacultyName);
            this.Controls.Add(this.label1);
            this.Name = "addFaculty";
            this.Text = "Add Faculty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAddnew;
        private System.Windows.Forms.TextBox _txtPhn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtFacId;
        private System.Windows.Forms.Label _txtId;
        private System.Windows.Forms.TextBox _txtFacultyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _txtStreet;
        private System.Windows.Forms.TextBox _txtStreetbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtProvince;
    }
}