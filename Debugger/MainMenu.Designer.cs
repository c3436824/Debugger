﻿namespace Debugger
{
    partial class mainMenu
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
            this.btnBBT = new System.Windows.Forms.Button();
            this.btnWBT = new System.Windows.Forms.Button();
            this.btnDeveloper = new System.Windows.Forms.Button();
            this.btnArchivedBugs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBBT
            // 
            this.btnBBT.Location = new System.Drawing.Point(87, 116);
            this.btnBBT.Name = "btnBBT";
            this.btnBBT.Size = new System.Drawing.Size(139, 50);
            this.btnBBT.TabIndex = 0;
            this.btnBBT.Text = "Black Box Tester";
            this.btnBBT.UseVisualStyleBackColor = true;
            this.btnBBT.Click += new System.EventHandler(this.btnBBT_Click);
            // 
            // btnWBT
            // 
            this.btnWBT.Location = new System.Drawing.Point(87, 172);
            this.btnWBT.Name = "btnWBT";
            this.btnWBT.Size = new System.Drawing.Size(139, 50);
            this.btnWBT.TabIndex = 1;
            this.btnWBT.Text = "White Box Tester";
            this.btnWBT.UseVisualStyleBackColor = true;
            this.btnWBT.Click += new System.EventHandler(this.btnWBT_Click);
            // 
            // btnDeveloper
            // 
            this.btnDeveloper.Location = new System.Drawing.Point(87, 228);
            this.btnDeveloper.Name = "btnDeveloper";
            this.btnDeveloper.Size = new System.Drawing.Size(139, 50);
            this.btnDeveloper.TabIndex = 2;
            this.btnDeveloper.Text = "Developer";
            this.btnDeveloper.UseVisualStyleBackColor = true;
            this.btnDeveloper.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnArchivedBugs
            // 
            this.btnArchivedBugs.Location = new System.Drawing.Point(87, 284);
            this.btnArchivedBugs.Name = "btnArchivedBugs";
            this.btnArchivedBugs.Size = new System.Drawing.Size(139, 50);
            this.btnArchivedBugs.TabIndex = 3;
            this.btnArchivedBugs.Text = "Archived Bugs";
            this.btnArchivedBugs.UseVisualStyleBackColor = true;
            this.btnArchivedBugs.Click += new System.EventHandler(this.btnArchivedBugs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bug Tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please Select:";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArchivedBugs);
            this.Controls.Add(this.btnDeveloper);
            this.Controls.Add(this.btnWBT);
            this.Controls.Add(this.btnBBT);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBBT;
        private System.Windows.Forms.Button btnWBT;
        private System.Windows.Forms.Button btnDeveloper;
        private System.Windows.Forms.Button btnArchivedBugs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

