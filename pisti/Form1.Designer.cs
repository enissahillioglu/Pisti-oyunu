namespace pisti
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bilgiOrta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.oyuncuu2 = new System.Windows.Forms.ListBox();
            this.oyuncuu1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rakipOyuncu = new System.Windows.Forms.Timer(this.components);
            this.log = new System.Windows.Forms.ListBox();
            this.lbIsim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(232, 312);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(232, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(255, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bilgiOrta
            // 
            this.bilgiOrta.AutoSize = true;
            this.bilgiOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiOrta.Location = new System.Drawing.Point(502, 166);
            this.bilgiOrta.Name = "bilgiOrta";
            this.bilgiOrta.Size = new System.Drawing.Size(41, 13);
            this.bilgiOrta.TabIndex = 4;
            this.bilgiOrta.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "gönder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // oyuncuu2
            // 
            this.oyuncuu2.BackColor = System.Drawing.Color.Red;
            this.oyuncuu2.ForeColor = System.Drawing.SystemColors.Menu;
            this.oyuncuu2.FormattingEnabled = true;
            this.oyuncuu2.Location = new System.Drawing.Point(58, 12);
            this.oyuncuu2.Name = "oyuncuu2";
            this.oyuncuu2.Size = new System.Drawing.Size(78, 69);
            this.oyuncuu2.TabIndex = 6;
            // 
            // oyuncuu1
            // 
            this.oyuncuu1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.oyuncuu1.ForeColor = System.Drawing.SystemColors.Menu;
            this.oyuncuu1.FormattingEnabled = true;
            this.oyuncuu1.Location = new System.Drawing.Point(58, 284);
            this.oyuncuu1.Name = "oyuncuu1";
            this.oyuncuu1.Size = new System.Drawing.Size(78, 69);
            this.oyuncuu1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aldığım Kartlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Aldığı Kartlar";
            // 
            // rakipOyuncu
            // 
            this.rakipOyuncu.Interval = 1000;
            this.rakipOyuncu.Tick += new System.EventHandler(this.rakipOyuncu_Tick);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(40, 445);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(581, 69);
            this.log.TabIndex = 11;
            this.log.SelectedIndexChanged += new System.EventHandler(this.log_SelectedIndexChanged);
            // 
            // lbIsim
            // 
            this.lbIsim.AutoSize = true;
            this.lbIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbIsim.Location = new System.Drawing.Point(255, 284);
            this.lbIsim.Name = "lbIsim";
            this.lbIsim.Size = new System.Drawing.Size(70, 25);
            this.lbIsim.TabIndex = 12;
            this.lbIsim.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(255, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rakip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(502, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(662, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbIsim);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oyuncuu1);
            this.Controls.Add(this.oyuncuu2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bilgiOrta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label bilgiOrta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox oyuncuu2;
        private System.Windows.Forms.ListBox oyuncuu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer rakipOyuncu;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.Label lbIsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

