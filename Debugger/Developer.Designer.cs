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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDisplayBugs = new System.Windows.Forms.Button();
            this.lsBug = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBugID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackPro
            // 
            this.btnBackPro.Location = new System.Drawing.Point(12, 535);
            this.btnBackPro.Name = "btnBackPro";
            this.btnBackPro.Size = new System.Drawing.Size(75, 23);
            this.btnBackPro.TabIndex = 0;
            this.btnBackPro.Text = "Back";
            this.btnBackPro.UseVisualStyleBackColor = true;
            this.btnBackPro.Click += new System.EventHandler(this.btnBackPro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 218);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnDisplayBugs
            // 
            this.btnDisplayBugs.Location = new System.Drawing.Point(933, 19);
            this.btnDisplayBugs.Name = "btnDisplayBugs";
            this.btnDisplayBugs.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayBugs.TabIndex = 2;
            this.btnDisplayBugs.Text = "Display Bugs ";
            this.btnDisplayBugs.UseVisualStyleBackColor = true;
            // 
            // lsBug
            // 
            this.lsBug.FormattingEnabled = true;
            this.lsBug.Location = new System.Drawing.Point(12, 245);
            this.lsBug.Name = "lsBug";
            this.lsBug.Size = new System.Drawing.Size(231, 277);
            this.lsBug.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 345);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(933, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Fix and Archive";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(933, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtBugID
            // 
            this.txtBugID.Location = new System.Drawing.Point(933, 138);
            this.txtBugID.Name = "txtBugID";
            this.txtBugID.Size = new System.Drawing.Size(75, 20);
            this.txtBugID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bug ID";
            // 
            // Developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBugID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lsBug);
            this.Controls.Add(this.btnDisplayBugs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackPro);
            this.Name = "Developer";
            this.Text = "Developer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Programmer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackPro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDisplayBugs;
        private System.Windows.Forms.ListBox lsBug;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBugID;
        private System.Windows.Forms.Label label1;
    }
}