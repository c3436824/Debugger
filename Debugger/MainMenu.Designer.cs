namespace Debugger
{
    partial class Form1
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
            this.btnPro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBBT
            // 
            this.btnBBT.Location = new System.Drawing.Point(70, 30);
            this.btnBBT.Name = "btnBBT";
            this.btnBBT.Size = new System.Drawing.Size(139, 50);
            this.btnBBT.TabIndex = 0;
            this.btnBBT.Text = "Black Box Tester";
            this.btnBBT.UseVisualStyleBackColor = true;
            // 
            // btnWBT
            // 
            this.btnWBT.Location = new System.Drawing.Point(70, 95);
            this.btnWBT.Name = "btnWBT";
            this.btnWBT.Size = new System.Drawing.Size(139, 50);
            this.btnWBT.TabIndex = 1;
            this.btnWBT.Text = "White Box Tester";
            this.btnWBT.UseVisualStyleBackColor = true;
            // 
            // btnPro
            // 
            this.btnPro.Location = new System.Drawing.Point(70, 159);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(139, 50);
            this.btnPro.TabIndex = 2;
            this.btnPro.Text = "Programmer";
            this.btnPro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.btnWBT);
            this.Controls.Add(this.btnBBT);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBBT;
        private System.Windows.Forms.Button btnWBT;
        private System.Windows.Forms.Button btnPro;
    }
}

