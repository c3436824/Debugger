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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBugID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewArchivedBugs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeveloper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackPro
            // 
            this.btnBackPro.Location = new System.Drawing.Point(12, 463);
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
            this.dataGridViewDeveloper.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDeveloper.Name = "dataGridViewDeveloper";
            this.dataGridViewDeveloper.Size = new System.Drawing.Size(1025, 227);
            this.dataGridViewDeveloper.TabIndex = 1;
            this.dataGridViewDeveloper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lsBug
            // 
            this.lsBug.FormattingEnabled = true;
            this.lsBug.Location = new System.Drawing.Point(12, 245);
            this.lsBug.Name = "lsBug";
            this.lsBug.Size = new System.Drawing.Size(274, 212);
            this.lsBug.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(385, 291);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(385, 317);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(155, 20);
            this.txtDate.TabIndex = 5;
            // 
            // txtComent
            // 
            this.txtComent.Location = new System.Drawing.Point(385, 343);
            this.txtComent.Name = "txtComent";
            this.txtComent.Size = new System.Drawing.Size(155, 20);
            this.txtComent.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(573, 288);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFixAndArchive
            // 
            this.btnFixAndArchive.Location = new System.Drawing.Point(573, 346);
            this.btnFixAndArchive.Name = "btnFixAndArchive";
            this.btnFixAndArchive.Size = new System.Drawing.Size(102, 23);
            this.btnFixAndArchive.TabIndex = 8;
            this.btnFixAndArchive.Text = "Fix and Archive";
            this.btnFixAndArchive.UseVisualStyleBackColor = true;
            this.btnFixAndArchive.Click += new System.EventHandler(this.btnFixAndArchive_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(573, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtBugID
            // 
            this.txtBugID.Location = new System.Drawing.Point(385, 265);
            this.txtBugID.Name = "txtBugID";
            this.txtBugID.Size = new System.Drawing.Size(85, 20);
            this.txtBugID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bug ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(314, 320);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 13;
            this.Date.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Coment";
            // 
            // btnViewArchivedBugs
            // 
            this.btnViewArchivedBugs.Location = new System.Drawing.Point(916, 464);
            this.btnViewArchivedBugs.Name = "btnViewArchivedBugs";
            this.btnViewArchivedBugs.Size = new System.Drawing.Size(117, 23);
            this.btnViewArchivedBugs.TabIndex = 15;
            this.btnViewArchivedBugs.Text = "View  Archived Bugs";
            this.btnViewArchivedBugs.UseVisualStyleBackColor = true;
            this.btnViewArchivedBugs.Click += new System.EventHandler(this.btnViewArchivedBugs_Click);
            // 
            // Developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 499);
            this.Controls.Add(this.btnViewArchivedBugs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBugID);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBugID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewArchivedBugs;
    }
}