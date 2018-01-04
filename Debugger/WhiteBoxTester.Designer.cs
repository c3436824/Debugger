namespace Debugger
{
    partial class WhiteBoxTester
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
            this.btnBackWBT = new System.Windows.Forms.Button();
            this.dgvBugsWBT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSymptoms = new System.Windows.Forms.ListBox();
            this.lbTrigger = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBugIdWBT = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.addWBT = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodeAuthor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugsWBT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackWBT
            // 
            this.btnBackWBT.Location = new System.Drawing.Point(12, 492);
            this.btnBackWBT.Name = "btnBackWBT";
            this.btnBackWBT.Size = new System.Drawing.Size(75, 23);
            this.btnBackWBT.TabIndex = 0;
            this.btnBackWBT.Text = "Back";
            this.btnBackWBT.UseVisualStyleBackColor = true;
            this.btnBackWBT.Click += new System.EventHandler(this.btnBackWBT_Click);
            // 
            // dgvBugsWBT
            // 
            this.dgvBugsWBT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugsWBT.Location = new System.Drawing.Point(12, 222);
            this.dgvBugsWBT.Name = "dgvBugsWBT";
            this.dgvBugsWBT.Size = new System.Drawing.Size(1058, 264);
            this.dgvBugsWBT.TabIndex = 1;
            this.dgvBugsWBT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugsWBT_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Souce File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Line Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Method:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(95, 72);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(159, 20);
            this.txtProjectName.TabIndex = 8;
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(95, 97);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(159, 20);
            this.txtSourceFile.TabIndex = 9;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(95, 124);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(159, 20);
            this.txtClassName.TabIndex = 10;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(361, 98);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(159, 20);
            this.txtMethod.TabIndex = 12;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(361, 72);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(159, 20);
            this.txtLineNumber.TabIndex = 11;
            this.txtLineNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLineNumber_KeyPress);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(878, 39);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(10, 13);
            this.lblAppName.TabIndex = 15;
            this.lblAppName.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bug ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(779, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Application Name:";
            // 
            // lbSymptoms
            // 
            this.lbSymptoms.FormattingEnabled = true;
            this.lbSymptoms.Location = new System.Drawing.Point(881, 68);
            this.lbSymptoms.Name = "lbSymptoms";
            this.lbSymptoms.Size = new System.Drawing.Size(165, 69);
            this.lbSymptoms.TabIndex = 20;
            // 
            // lbTrigger
            // 
            this.lbTrigger.FormattingEnabled = true;
            this.lbTrigger.Location = new System.Drawing.Point(878, 147);
            this.lbTrigger.Name = "lbTrigger";
            this.lbTrigger.Size = new System.Drawing.Size(168, 69);
            this.lbTrigger.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(795, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bug Symptoms:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(807, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Bug Trigger:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(566, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBugIdWBT
            // 
            this.txtBugIdWBT.Location = new System.Drawing.Point(95, 46);
            this.txtBugIdWBT.Name = "txtBugIdWBT";
            this.txtBugIdWBT.Size = new System.Drawing.Size(159, 20);
            this.txtBugIdWBT.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(566, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // addWBT
            // 
            this.addWBT.Location = new System.Drawing.Point(566, 129);
            this.addWBT.Name = "addWBT";
            this.addWBT.Size = new System.Drawing.Size(108, 23);
            this.addWBT.TabIndex = 28;
            this.addWBT.Text = "Edit";
            this.addWBT.UseVisualStyleBackColor = true;
            this.addWBT.Click += new System.EventHandler(this.addWBT_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(268, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Please use the Bug ID  to search, delete and edit bugs ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Code Author:";
            // 
            // txtCodeAuthor
            // 
            this.txtCodeAuthor.Location = new System.Drawing.Point(361, 128);
            this.txtCodeAuthor.Name = "txtCodeAuthor";
            this.txtCodeAuthor.Size = new System.Drawing.Size(159, 20);
            this.txtCodeAuthor.TabIndex = 31;
            // 
            // WhiteBoxTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 527);
            this.Controls.Add(this.txtCodeAuthor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addWBT);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBugIdWBT);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTrigger);
            this.Controls.Add(this.lbSymptoms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBugsWBT);
            this.Controls.Add(this.btnBackWBT);
            this.Name = "WhiteBoxTester";
            this.Text = "WhiteBoxTester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WhiteBoxTester_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugsWBT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackWBT;
        private System.Windows.Forms.DataGridView dgvBugsWBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbSymptoms;
        private System.Windows.Forms.ListBox lbTrigger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBugIdWBT;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button addWBT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodeAuthor;
    }
}