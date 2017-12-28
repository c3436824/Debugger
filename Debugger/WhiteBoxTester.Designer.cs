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
            this.SuspendLayout();
            // 
            // btnBackWBT
            // 
            this.btnBackWBT.Location = new System.Drawing.Point(13, 226);
            this.btnBackWBT.Name = "btnBackWBT";
            this.btnBackWBT.Size = new System.Drawing.Size(75, 23);
            this.btnBackWBT.TabIndex = 0;
            this.btnBackWBT.Text = "Back";
            this.btnBackWBT.UseVisualStyleBackColor = true;
            this.btnBackWBT.Click += new System.EventHandler(this.btnBackWBT_Click);
            // 
            // WhiteBoxTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBackWBT);
            this.Name = "WhiteBoxTester";
            this.Text = "WhiteBoxTester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WhiteBoxTester_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackWBT;
    }
}