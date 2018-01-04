namespace Debugger
{
    partial class ArchivedBugs
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
            this.dgvArchivedBugs = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbBlackBoxTester = new System.Windows.Forms.ListBox();
            this.lbWhiteBoxTester = new System.Windows.Forms.ListBox();
            this.lbDeveloper = new System.Windows.Forms.ListBox();
            this.txtBugID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivedBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArchivedBugs
            // 
            this.dgvArchivedBugs.Location = new System.Drawing.Point(12, 12);
            this.dgvArchivedBugs.Name = "dgvArchivedBugs";
            this.dgvArchivedBugs.Size = new System.Drawing.Size(1347, 284);
            this.dgvArchivedBugs.TabIndex = 0;
            this.dgvArchivedBugs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchivedBugs_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(2, 692);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1182, 314);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Bug";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1182, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Bug";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbBlackBoxTester
            // 
            this.lbBlackBoxTester.FormattingEnabled = true;
            this.lbBlackBoxTester.Location = new System.Drawing.Point(12, 320);
            this.lbBlackBoxTester.Name = "lbBlackBoxTester";
            this.lbBlackBoxTester.Size = new System.Drawing.Size(243, 251);
            this.lbBlackBoxTester.TabIndex = 4;
            // 
            // lbWhiteBoxTester
            // 
            this.lbWhiteBoxTester.FormattingEnabled = true;
            this.lbWhiteBoxTester.Location = new System.Drawing.Point(346, 320);
            this.lbWhiteBoxTester.Name = "lbWhiteBoxTester";
            this.lbWhiteBoxTester.Size = new System.Drawing.Size(243, 251);
            this.lbWhiteBoxTester.TabIndex = 5;
            // 
            // lbDeveloper
            // 
            this.lbDeveloper.FormattingEnabled = true;
            this.lbDeveloper.Location = new System.Drawing.Point(704, 320);
            this.lbDeveloper.Name = "lbDeveloper";
            this.lbDeveloper.Size = new System.Drawing.Size(243, 251);
            this.lbDeveloper.TabIndex = 6;
            // 
            // txtBugID
            // 
            this.txtBugID.Location = new System.Drawing.Point(1092, 317);
            this.txtBugID.Name = "txtBugID";
            this.txtBugID.Size = new System.Drawing.Size(63, 20);
            this.txtBugID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1043, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bug ID:";
            // 
            // ArchivedBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBugID);
            this.Controls.Add(this.lbDeveloper);
            this.Controls.Add(this.lbWhiteBoxTester);
            this.Controls.Add(this.lbBlackBoxTester);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvArchivedBugs);
            this.Name = "ArchivedBugs";
            this.Text = "ArchivedBugs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArchivedBugs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivedBugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivedBugs;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbBlackBoxTester;
        private System.Windows.Forms.ListBox lbWhiteBoxTester;
        private System.Windows.Forms.ListBox lbDeveloper;
        private System.Windows.Forms.TextBox txtBugID;
        private System.Windows.Forms.Label label1;
    }
}