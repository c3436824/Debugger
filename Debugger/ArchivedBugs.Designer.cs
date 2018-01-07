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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbBlackBoxTester = new System.Windows.Forms.ListBox();
            this.lbWhiteBoxTester = new System.Windows.Forms.ListBox();
            this.lbDeveloper = new System.Windows.Forms.ListBox();
            this.txtBugID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.webSourceCode = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnNotFixed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivedBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArchivedBugs
            // 
            this.dgvArchivedBugs.Location = new System.Drawing.Point(12, 12);
            this.dgvArchivedBugs.Name = "dgvArchivedBugs";
            this.dgvArchivedBugs.Size = new System.Drawing.Size(1537, 284);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(357, 638);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
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
            this.lbWhiteBoxTester.Location = new System.Drawing.Point(261, 320);
            this.lbWhiteBoxTester.Name = "lbWhiteBoxTester";
            this.lbWhiteBoxTester.Size = new System.Drawing.Size(243, 251);
            this.lbWhiteBoxTester.TabIndex = 5;
            // 
            // lbDeveloper
            // 
            this.lbDeveloper.FormattingEnabled = true;
            this.lbDeveloper.Location = new System.Drawing.Point(510, 320);
            this.lbDeveloper.Name = "lbDeveloper";
            this.lbDeveloper.Size = new System.Drawing.Size(243, 251);
            this.lbDeveloper.TabIndex = 6;
            // 
            // txtBugID
            // 
            this.txtBugID.Location = new System.Drawing.Point(414, 583);
            this.txtBugID.Name = "txtBugID";
            this.txtBugID.Size = new System.Drawing.Size(63, 20);
            this.txtBugID.TabIndex = 7;
            this.txtBugID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBugID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bug ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Black Box Tester Report:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "White Box Tester Report:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Developer Report:";
            // 
            // webSourceCode
            // 
            this.webSourceCode.Location = new System.Drawing.Point(759, 321);
            this.webSourceCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSourceCode.Name = "webSourceCode";
            this.webSourceCode.Size = new System.Drawing.Size(790, 369);
            this.webSourceCode.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(756, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Source Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "To delete or report as not fixed please enter Bug ID:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(357, 609);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(120, 23);
            this.btnDisplay.TabIndex = 15;
            this.btnDisplay.Text = "Display Bug";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnNotFixed
            // 
            this.btnNotFixed.Location = new System.Drawing.Point(357, 667);
            this.btnNotFixed.Name = "btnNotFixed";
            this.btnNotFixed.Size = new System.Drawing.Size(120, 23);
            this.btnNotFixed.TabIndex = 16;
            this.btnNotFixed.Text = "Bug Not Fixed";
            this.btnNotFixed.UseVisualStyleBackColor = true;
            this.btnNotFixed.Click += new System.EventHandler(this.btnNotFixed_Click);
            // 
            // ArchivedBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 727);
            this.Controls.Add(this.btnNotFixed);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.webSourceCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBugID);
            this.Controls.Add(this.lbDeveloper);
            this.Controls.Add(this.lbWhiteBoxTester);
            this.Controls.Add(this.lbBlackBoxTester);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbBlackBoxTester;
        private System.Windows.Forms.ListBox lbWhiteBoxTester;
        private System.Windows.Forms.ListBox lbDeveloper;
        private System.Windows.Forms.TextBox txtBugID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webSourceCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnNotFixed;
    }
}