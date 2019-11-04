namespace mainForm
{
    partial class addAssign
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
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOkay = new System.Windows.Forms.Button();
            this._listbox = new System.Windows.Forms.ListBox();
            this._btnAddCourse = new System.Windows.Forms.Button();
            this._checkListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(411, 380);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 4;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._onClickCancel);
            // 
            // _btnOkay
            // 
            this._btnOkay.Location = new System.Drawing.Point(288, 381);
            this._btnOkay.Name = "_btnOkay";
            this._btnOkay.Size = new System.Drawing.Size(75, 23);
            this._btnOkay.TabIndex = 3;
            this._btnOkay.Text = "Okay";
            this._btnOkay.UseVisualStyleBackColor = true;
            this._btnOkay.Click += new System.EventHandler(this._onClickOkay);
            // 
            // _listbox
            // 
            this._listbox.BackColor = System.Drawing.SystemColors.Info;
            this._listbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._listbox.FormattingEnabled = true;
            this._listbox.Location = new System.Drawing.Point(494, 47);
            this._listbox.Name = "_listbox";
            this._listbox.Size = new System.Drawing.Size(187, 264);
            this._listbox.TabIndex = 1;
            // 
            // _btnAddCourse
            // 
            this._btnAddCourse.Location = new System.Drawing.Point(350, 163);
            this._btnAddCourse.Name = "_btnAddCourse";
            this._btnAddCourse.Size = new System.Drawing.Size(96, 23);
            this._btnAddCourse.TabIndex = 2;
            this._btnAddCourse.Text = "Add Course";
            this._btnAddCourse.UseVisualStyleBackColor = true;
            this._btnAddCourse.Click += new System.EventHandler(this._onClickAddCourse);
            // 
            // _checkListBox
            // 
            this._checkListBox.BackColor = System.Drawing.SystemColors.Info;
            this._checkListBox.FormattingEnabled = true;
            this._checkListBox.Items.AddRange(new object[] {
            "------------List Of Course---------",
            "BSAF320------Project Management",
            "CECP101------PC Hardware",
            "CECP257------The physical Layer",
            "COMP120-----Programming1",
            "COMP228-----Introduction to java",
            "BSAF100------Introduction to business"});
            this._checkListBox.Location = new System.Drawing.Point(126, 47);
            this._checkListBox.Name = "_checkListBox";
            this._checkListBox.Size = new System.Drawing.Size(179, 264);
            this._checkListBox.TabIndex = 0;
            this._checkListBox.DoubleClick += new System.EventHandler(this._onClickAddCourse);
            // 
            // addAssign
            // 
            this.AcceptButton = this._btnAddCourse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 409);
            this.Controls.Add(this._checkListBox);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOkay);
            this.Controls.Add(this._listbox);
            this.Controls.Add(this._btnAddCourse);
            this.MaximumSize = new System.Drawing.Size(795, 448);
            this.Name = "addAssign";
            this.Text = "addAssign";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOkay;
        private System.Windows.Forms.ListBox _listbox;
        private System.Windows.Forms.Button _btnAddCourse;
        private System.Windows.Forms.ListBox _checkListBox;
    }
}