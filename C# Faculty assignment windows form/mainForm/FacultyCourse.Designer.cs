namespace mainForm
{
    partial class _frmFacultyCourse
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
            this._lbxFaculty = new System.Windows.Forms.ListBox();
            this._btnExit = new System.Windows.Forms.Button();
            this._grpboxFacuclty = new System.Windows.Forms.GroupBox();
            this._grpboxCourse = new System.Windows.Forms.GroupBox();
            this._lstboxCourseDetails = new System.Windows.Forms.ListBox();
            this._grpboxFacuclty.SuspendLayout();
            this._grpboxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lbxFaculty
            // 
            this._lbxFaculty.BackColor = System.Drawing.SystemColors.Info;
            this._lbxFaculty.FormattingEnabled = true;
            this._lbxFaculty.Location = new System.Drawing.Point(1, 19);
            this._lbxFaculty.Name = "_lbxFaculty";
            this._lbxFaculty.Size = new System.Drawing.Size(232, 303);
            this._lbxFaculty.TabIndex = 0;
            this._lbxFaculty.SelectedIndexChanged += new System.EventHandler(this._bxFaculty_SelectedIndex);
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(312, 399);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(142, 23);
            this._btnExit.TabIndex = 1;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this._btnClick_click);
            // 
            // _grpboxFacuclty
            // 
            this._grpboxFacuclty.Controls.Add(this._lbxFaculty);
            this._grpboxFacuclty.Location = new System.Drawing.Point(22, 25);
            this._grpboxFacuclty.Name = "_grpboxFacuclty";
            this._grpboxFacuclty.Size = new System.Drawing.Size(239, 343);
            this._grpboxFacuclty.TabIndex = 2;
            this._grpboxFacuclty.TabStop = false;
            this._grpboxFacuclty.Text = "Faculty";
            // 
            // _grpboxCourse
            // 
            this._grpboxCourse.Controls.Add(this._lstboxCourseDetails);
            this._grpboxCourse.Location = new System.Drawing.Point(539, 25);
            this._grpboxCourse.Name = "_grpboxCourse";
            this._grpboxCourse.Size = new System.Drawing.Size(239, 343);
            this._grpboxCourse.TabIndex = 3;
            this._grpboxCourse.TabStop = false;
            this._grpboxCourse.Text = "Course";
            // 
            // _lstboxCourseDetails
            // 
            this._lstboxCourseDetails.BackColor = System.Drawing.SystemColors.Info;
            this._lstboxCourseDetails.FormattingEnabled = true;
            this._lstboxCourseDetails.Location = new System.Drawing.Point(6, 19);
            this._lstboxCourseDetails.Name = "_lstboxCourseDetails";
            this._lstboxCourseDetails.Size = new System.Drawing.Size(227, 303);
            this._lstboxCourseDetails.TabIndex = 0;
            // 
            // _frmFacultyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._grpboxCourse);
            this.Controls.Add(this._grpboxFacuclty);
            this.Controls.Add(this._btnExit);
            this.Name = "_frmFacultyCourse";
            this.Text = "Faculty and Courses";
            this.Load += new System.EventHandler(this._frmFacultyAndCourse_Load);
            this._grpboxFacuclty.ResumeLayout(false);
            this._grpboxCourse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _lbxFaculty;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.GroupBox _grpboxFacuclty;
        private System.Windows.Forms.GroupBox _grpboxCourse;
        private System.Windows.Forms.ListBox _lstboxCourseDetails;
    }
}