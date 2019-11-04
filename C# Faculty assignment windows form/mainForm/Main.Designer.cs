namespace mainForm
{
    partial class _mainForm
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
            this._lstFaculty = new System.Windows.Forms.ListBox();
            this._lstAssignment = new System.Windows.Forms.ListBox();
            this._btnAddFaculty = new System.Windows.Forms.Button();
            this._btnAddAssignment = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lstFaculty
            // 
            this._lstFaculty.BackColor = System.Drawing.SystemColors.Info;
            this._lstFaculty.FormattingEnabled = true;
            this._lstFaculty.Location = new System.Drawing.Point(12, 13);
            this._lstFaculty.Name = "_lstFaculty";
            this._lstFaculty.Size = new System.Drawing.Size(186, 264);
            this._lstFaculty.TabIndex = 0;
            this._lstFaculty.SelectedIndexChanged += new System.EventHandler(this._lstFaculty_SelectedIndexChanged);
            this._lstFaculty.DoubleClick += new System.EventHandler(this._onClickAddAssignment);
            // 
            // _lstAssignment
            // 
            this._lstAssignment.BackColor = System.Drawing.SystemColors.Info;
            this._lstAssignment.FormattingEnabled = true;
            this._lstAssignment.Location = new System.Drawing.Point(517, 13);
            this._lstAssignment.Name = "_lstAssignment";
            this._lstAssignment.Size = new System.Drawing.Size(256, 264);
            this._lstAssignment.TabIndex = 1;
            // 
            // _btnAddFaculty
            // 
            this._btnAddFaculty.Location = new System.Drawing.Point(43, 283);
            this._btnAddFaculty.Name = "_btnAddFaculty";
            this._btnAddFaculty.Size = new System.Drawing.Size(104, 23);
            this._btnAddFaculty.TabIndex = 2;
            this._btnAddFaculty.Text = "Add Faculty";
            this._btnAddFaculty.UseVisualStyleBackColor = true;
            this._btnAddFaculty.Click += new System.EventHandler(this._onClickAddFaculty);
            // 
            // _btnAddAssignment
            // 
            this._btnAddAssignment.Location = new System.Drawing.Point(592, 283);
            this._btnAddAssignment.Name = "_btnAddAssignment";
            this._btnAddAssignment.Size = new System.Drawing.Size(97, 23);
            this._btnAddAssignment.TabIndex = 3;
            this._btnAddAssignment.Text = "Add Assignment";
            this._btnAddAssignment.UseVisualStyleBackColor = true;
            this._btnAddAssignment.Click += new System.EventHandler(this._onClickAddAssignment);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(315, 154);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 4;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check Course Assignment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._btnCourseAssignment_click);
            // 
            // _mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnAddAssignment);
            this.Controls.Add(this._btnAddFaculty);
            this.Controls.Add(this._lstAssignment);
            this.Controls.Add(this._lstFaculty);
            this.MinimumSize = new System.Drawing.Size(797, 426);
            this.Name = "_mainForm";
            this.Text = "Main Form";
            this.Activated += new System.EventHandler(this._onActivateForm);
            this.Load += new System.EventHandler(this._mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _lstFaculty;
        private System.Windows.Forms.ListBox _lstAssignment;
        private System.Windows.Forms.Button _btnAddFaculty;
        private System.Windows.Forms.Button _btnAddAssignment;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button button1;
    }
}

