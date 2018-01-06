namespace Debugger
{
    partial class BlackBoxTester
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
            this.btnBackBBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBugSym = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBugTrig = new System.Windows.Forms.TextBox();
            this.btnAddBug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackBBT
            // 
            this.btnBackBBT.Location = new System.Drawing.Point(19, 171);
            this.btnBackBBT.Name = "btnBackBBT";
            this.btnBackBBT.Size = new System.Drawing.Size(75, 23);
            this.btnBackBBT.TabIndex = 0;
            this.btnBackBBT.Text = "Back";
            this.btnBackBBT.UseVisualStyleBackColor = true;
            this.btnBackBBT.Click += new System.EventHandler(this.btnBackBBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Application Name:";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(162, 64);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(130, 20);
            this.txtAppName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // txtBugSym
            // 
            this.txtBugSym.Location = new System.Drawing.Point(162, 95);
            this.txtBugSym.Name = "txtBugSym";
            this.txtBugSym.Size = new System.Drawing.Size(130, 20);
            this.txtBugSym.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "* Bug Symptoms:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "* Bug Trigger:";
            // 
            // txtBugTrig
            // 
            this.txtBugTrig.Location = new System.Drawing.Point(162, 124);
            this.txtBugTrig.Name = "txtBugTrig";
            this.txtBugTrig.Size = new System.Drawing.Size(130, 20);
            this.txtBugTrig.TabIndex = 10;
            // 
            // btnAddBug
            // 
            this.btnAddBug.Location = new System.Drawing.Point(253, 171);
            this.btnAddBug.Name = "btnAddBug";
            this.btnAddBug.Size = new System.Drawing.Size(75, 23);
            this.btnAddBug.TabIndex = 11;
            this.btnAddBug.Text = "Add Bug";
            this.btnAddBug.UseVisualStyleBackColor = true;
            this.btnAddBug.Click += new System.EventHandler(this.btnAddBug_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "To report a bug please fill in the following fields: ";
            // 
            // BlackBoxTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 216);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddBug);
            this.Controls.Add(this.txtBugTrig);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBugSym);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackBBT);
            this.Name = "BlackBoxTester";
            this.Text = "Black Box Tester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BlackBoxTester_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackBBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBugSym;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBugTrig;
        private System.Windows.Forms.Button btnAddBug;
        private System.Windows.Forms.Label label3;
    }
}