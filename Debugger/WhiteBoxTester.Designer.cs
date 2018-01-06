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
            this.label6 = new System.Windows.Forms.Label();
            this.lbBlackBox = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBugIdWBT = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.addWBT = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodeAuthor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodeBlock = new System.Windows.Forms.TextBox();
            this.txtCodeSnipet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugsWBT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackWBT
            // 
            this.btnBackWBT.Location = new System.Drawing.Point(12, 711);
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
            this.dgvBugsWBT.Location = new System.Drawing.Point(10, 443);
            this.dgvBugsWBT.Name = "dgvBugsWBT";
            this.dgvBugsWBT.Size = new System.Drawing.Size(1245, 264);
            this.dgvBugsWBT.TabIndex = 1;
            this.dgvBugsWBT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugsWBT_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Souce File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Line Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Method:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(162, 104);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(159, 20);
            this.txtProjectName.TabIndex = 8;
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(162, 129);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(159, 20);
            this.txtSourceFile.TabIndex = 9;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(162, 156);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(159, 20);
            this.txtClassName.TabIndex = 10;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(502, 130);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(159, 20);
            this.txtMethod.TabIndex = 12;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(502, 74);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(159, 20);
            this.txtLineNumber.TabIndex = 11;
            this.txtLineNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLineNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bug ID:";
            // 
            // lbBlackBox
            // 
            this.lbBlackBox.FormattingEnabled = true;
            this.lbBlackBox.Location = new System.Drawing.Point(973, 71);
            this.lbBlackBox.Name = "lbBlackBox";
            this.lbBlackBox.Size = new System.Drawing.Size(266, 303);
            this.lbBlackBox.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(726, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBugIdWBT
            // 
            this.txtBugIdWBT.Location = new System.Drawing.Point(162, 78);
            this.txtBugIdWBT.Name = "txtBugIdWBT";
            this.txtBugIdWBT.Size = new System.Drawing.Size(159, 20);
            this.txtBugIdWBT.TabIndex = 26;
            this.txtBugIdWBT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBugIdWBT_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(726, 336);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // addWBT
            // 
            this.addWBT.Location = new System.Drawing.Point(726, 396);
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
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(411, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Please use the Bug ID to search, delete and edit bugs. ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(405, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Code Author:";
            // 
            // txtCodeAuthor
            // 
            this.txtCodeAuthor.Location = new System.Drawing.Point(502, 159);
            this.txtCodeAuthor.Name = "txtCodeAuthor";
            this.txtCodeAuthor.Size = new System.Drawing.Size(159, 20);
            this.txtCodeAuthor.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(417, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Code Block";
            // 
            // txtCodeBlock
            // 
            this.txtCodeBlock.Location = new System.Drawing.Point(502, 100);
            this.txtCodeBlock.Name = "txtCodeBlock";
            this.txtCodeBlock.Size = new System.Drawing.Size(159, 20);
            this.txtCodeBlock.TabIndex = 33;
            // 
            // txtCodeSnipet
            // 
            this.txtCodeSnipet.Location = new System.Drawing.Point(162, 198);
            this.txtCodeSnipet.Multiline = true;
            this.txtCodeSnipet.Name = "txtCodeSnipet";
            this.txtCodeSnipet.Size = new System.Drawing.Size(499, 238);
            this.txtCodeSnipet.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Enter Code Snippet: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(970, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Bug Report:";
            // 
            // WhiteBoxTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 746);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCodeSnipet);
            this.Controls.Add(this.txtCodeBlock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCodeAuthor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addWBT);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBugIdWBT);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbBlackBox);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbBlackBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBugIdWBT;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button addWBT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodeAuthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodeBlock;
        private System.Windows.Forms.TextBox txtCodeSnipet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
    }
}