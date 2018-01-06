namespace Debugger
{
    partial class Developer
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
            this.btnBackPro = new System.Windows.Forms.Button();
            this.dataGridViewDeveloper = new System.Windows.Forms.DataGridView();
            this.lsBug = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtComent = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFixAndArchive = new System.Windows.Forms.Button();
            this.txtBugID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewArchivedBugs = new System.Windows.Forms.Button();
            this.webColourCode = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourceCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditSourceCode = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeveloper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackPro
            // 
            this.btnBackPro.Location = new System.Drawing.Point(7, 919);
            this.btnBackPro.Name = "btnBackPro";
            this.btnBackPro.Size = new System.Drawing.Size(75, 23);
            this.btnBackPro.TabIndex = 0;
            this.btnBackPro.Text = "Back";
            this.btnBackPro.UseVisualStyleBackColor = true;
            this.btnBackPro.Click += new System.EventHandler(this.btnBackPro_Click);
            // 
            // dataGridViewDeveloper
            // 
            this.dataGridViewDeveloper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeveloper.Location = new System.Drawing.Point(11, 260);
            this.dataGridViewDeveloper.Name = "dataGridViewDeveloper";
            this.dataGridViewDeveloper.Size = new System.Drawing.Size(1243, 235);
            this.dataGridViewDeveloper.TabIndex = 1;
            this.dataGridViewDeveloper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lsBug
            // 
            this.lsBug.FormattingEnabled = true;
            this.lsBug.Location = new System.Drawing.Point(15, 12);
            this.lsBug.Name = "lsBug";
            this.lsBug.Size = new System.Drawing.Size(274, 212);
            this.lsBug.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(393, 151);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(393, 177);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(155, 20);
            this.txtDate.TabIndex = 5;
            // 
            // txtComent
            // 
            this.txtComent.Location = new System.Drawing.Point(393, 203);
            this.txtComent.Name = "txtComent";
            this.txtComent.Size = new System.Drawing.Size(155, 20);
            this.txtComent.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(578, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFixAndArchive
            // 
            this.btnFixAndArchive.Location = new System.Drawing.Point(578, 207);
            this.btnFixAndArchive.Name = "btnFixAndArchive";
            this.btnFixAndArchive.Size = new System.Drawing.Size(102, 23);
            this.btnFixAndArchive.TabIndex = 8;
            this.btnFixAndArchive.Text = "Fix and Archive";
            this.btnFixAndArchive.UseVisualStyleBackColor = true;
            this.btnFixAndArchive.Click += new System.EventHandler(this.btnFixAndArchive_Click);
            // 
            // txtBugID
            // 
            this.txtBugID.Location = new System.Drawing.Point(393, 125);
            this.txtBugID.Name = "txtBugID";
            this.txtBugID.Size = new System.Drawing.Size(85, 20);
            this.txtBugID.TabIndex = 10;
            this.txtBugID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBugID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bug ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(334, 178);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(42, 17);
            this.Date.TabIndex = 13;
            this.Date.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Comment:";
            // 
            // btnViewArchivedBugs
            // 
            this.btnViewArchivedBugs.Location = new System.Drawing.Point(1095, 919);
            this.btnViewArchivedBugs.Name = "btnViewArchivedBugs";
            this.btnViewArchivedBugs.Size = new System.Drawing.Size(117, 23);
            this.btnViewArchivedBugs.TabIndex = 15;
            this.btnViewArchivedBugs.Text = "View  Archived Bugs";
            this.btnViewArchivedBugs.UseVisualStyleBackColor = true;
            this.btnViewArchivedBugs.Click += new System.EventHandler(this.btnViewArchivedBugs_Click);
            // 
            // webColourCode
            // 
            this.webColourCode.Location = new System.Drawing.Point(633, 547);
            this.webColourCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.webColourCode.Name = "webColourCode";
            this.webColourCode.Size = new System.Drawing.Size(621, 294);
            this.webColourCode.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Formatted Source Code:";
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Location = new System.Drawing.Point(7, 547);
            this.txtSourceCode.Multiline = true;
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.Size = new System.Drawing.Size(616, 294);
            this.txtSourceCode.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Edit Source Code:";
            // 
            // btnEditSourceCode
            // 
            this.btnEditSourceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSourceCode.Location = new System.Drawing.Point(469, 847);
            this.btnEditSourceCode.Name = "btnEditSourceCode";
            this.btnEditSourceCode.Size = new System.Drawing.Size(154, 26);
            this.btnEditSourceCode.TabIndex = 21;
            this.btnEditSourceCode.Text = "Format Edited Source Code ";
            this.btnEditSourceCode.UseVisualStyleBackColor = true;
            this.btnEditSourceCode.Click += new System.EventHandler(this.btnEditSourceCode_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(536, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Please select or search the Bug ID you have fixed and wish to archive.";
            // 
            // Developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 1000);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditSourceCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.webColourCode);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.btnViewArchivedBugs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBugID);
            this.Controls.Add(this.btnFixAndArchive);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtComent);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lsBug);
            this.Controls.Add(this.dataGridViewDeveloper);
            this.Controls.Add(this.btnBackPro);
            this.Name = "Developer";
            this.Text = "Developer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Programmer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeveloper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackPro;
        private System.Windows.Forms.DataGridView dataGridViewDeveloper;
        private System.Windows.Forms.ListBox lsBug;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtComent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFixAndArchive;
        private System.Windows.Forms.TextBox txtBugID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewArchivedBugs;
        private System.Windows.Forms.WebBrowser webColourCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSourceCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditSourceCode;
        private System.Windows.Forms.Label label6;
    }
}