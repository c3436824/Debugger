namespace Debugger
{
    partial class Programmer
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
            this.SuspendLayout();
            // 
            // btnBackPro
            // 
            this.btnBackPro.Location = new System.Drawing.Point(13, 226);
            this.btnBackPro.Name = "btnBackPro";
            this.btnBackPro.Size = new System.Drawing.Size(75, 23);
            this.btnBackPro.TabIndex = 0;
            this.btnBackPro.Text = "Back";
            this.btnBackPro.UseVisualStyleBackColor = true;
            this.btnBackPro.Click += new System.EventHandler(this.btnBackPro_Click);
            // 
            // Programmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBackPro);
            this.Name = "Programmer";
            this.Text = "Programmer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Programmer_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackPro;
    }
}