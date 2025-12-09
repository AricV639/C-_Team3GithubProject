namespace Team3GithubProject
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
            this.btnFtoC = new System.Windows.Forms.Button();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AM4Chnge = new System.Windows.Forms.Label();
            this.btnAnjelica = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAric = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(248, 71);
            this.btnFtoC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(89, 54);
            this.btnFtoC.TabIndex = 0;
            this.btnFtoC.Text = "F to C ->";
            this.btnFtoC.UseVisualStyleBackColor = true;
            this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(248, 149);
            this.btnCtoF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(89, 54);
            this.btnCtoF.TabIndex = 1;
            this.btnCtoF.Text = "<- C to F";
            this.btnCtoF.UseVisualStyleBackColor = true;
            this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(248, 226);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 54);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFah
            // 
            this.txtFah.Location = new System.Drawing.Point(76, 167);
            this.txtFah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFah.Name = "txtFah";
            this.txtFah.Size = new System.Drawing.Size(76, 20);
            this.txtFah.TabIndex = 3;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(439, 167);
            this.txtCel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(76, 20);
            this.txtCel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Celsius";
            // 
            // AM4Chnge
            // 
            this.AM4Chnge.AutoSize = true;
            this.AM4Chnge.Location = new System.Drawing.Point(86, 294);
            this.AM4Chnge.Name = "AM4Chnge";
            this.AM4Chnge.Size = new System.Drawing.Size(88, 15);
            this.AM4Chnge.TabIndex = 7;
            this.AM4Chnge.Text = "Step 4 Change";
            this.AM4Chnge.Click += new System.EventHandler(this.AM4Chnge_Click);

            this.btnExit = new System.Windows.Forms.Button();

            // 
            // btnAnjelica
            // 
            this.btnAnjelica.Location = new System.Drawing.Point(0, 0);
            this.btnAnjelica.Name = "btnAnjelica";
            this.btnAnjelica.Size = new System.Drawing.Size(75, 23);
            this.btnAnjelica.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 96);
            this.listBox1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(514, 324);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAric
            // 
            this.btnAric.Location = new System.Drawing.Point(440, 39);
            this.btnAric.Name = "btnAric";
            this.btnAric.Size = new System.Drawing.Size(75, 51);
            this.btnAric.TabIndex = 9;
            this.btnAric.Text = "Aric V.";
            this.btnAric.UseVisualStyleBackColor = true;
            this.btnAric.Click += new System.EventHandler(this.btnAric_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(24, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 95);
            this.listBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnAric);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.AM4Chnge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtFah);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.btnFtoC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFtoC;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AM4Chnge;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAnjelica;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAric;
        private System.Windows.Forms.ListBox listBox2;
    }
}

