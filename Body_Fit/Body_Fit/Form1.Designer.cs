using System.Windows.Forms;

namespace Body_Fit
{
    partial class Body_Fit_Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Body_Fit_Program));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hd = new System.Windows.Forms.Label();
            this.textBox2HraneniaDen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4VisokaAktivnost = new System.Windows.Forms.RadioButton();
            this.radioButton3UmerenaAktivnost = new System.Windows.Forms.RadioButton();
            this.radioButton2LekaAktivnost = new System.Windows.Forms.RadioButton();
            this.radioButton1Zasednal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2Woman = new System.Windows.Forms.RadioButton();
            this.radioButton1Man = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textBox5Teglo = new System.Windows.Forms.TextBox();
            this.button4Close = new System.Windows.Forms.Button();
            this.button3Save = new System.Windows.Forms.Button();
            this.button2Clear = new System.Windows.Forms.Button();
            this.button1Calculate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4Hansh = new System.Windows.Forms.TextBox();
            this.textBox3Talia = new System.Windows.Forms.TextBox();
            this.textBox2Visochina = new System.Windows.Forms.TextBox();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hd);
            this.panel1.Controls.Add(this.textBox2HraneniaDen);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.textBox5Teglo);
            this.panel1.Controls.Add(this.button4Close);
            this.panel1.Controls.Add(this.button3Save);
            this.panel1.Controls.Add(this.button2Clear);
            this.panel1.Controls.Add(this.button1Calculate);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox4Hansh);
            this.panel1.Controls.Add(this.textBox3Talia);
            this.panel1.Controls.Add(this.textBox2Visochina);
            this.panel1.Controls.Add(this.textBox1Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 374);
            this.panel1.TabIndex = 0;
            // 
            // hd
            // 
            this.hd.AutoSize = true;
            this.hd.Location = new System.Drawing.Point(9, 299);
            this.hd.Name = "hd";
            this.hd.Size = new System.Drawing.Size(92, 13);
            this.hd.TabIndex = 34;
            this.hd.Text = "Хранения на ден";
            // 
            // textBox2HraneniaDen
            // 
            this.textBox2HraneniaDen.Location = new System.Drawing.Point(104, 296);
            this.textBox2HraneniaDen.Name = "textBox2HraneniaDen";
            this.textBox2HraneniaDen.Size = new System.Drawing.Size(37, 20);
            this.textBox2HraneniaDen.TabIndex = 32;
            this.textBox2HraneniaDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2HraneniaDen_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4VisokaAktivnost);
            this.groupBox2.Controls.Add(this.radioButton3UmerenaAktivnost);
            this.groupBox2.Controls.Add(this.radioButton2LekaAktivnost);
            this.groupBox2.Controls.Add(this.radioButton1Zasednal);
            this.groupBox2.Location = new System.Drawing.Point(184, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 109);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "активност";
            // 
            // radioButton4VisokaAktivnost
            // 
            this.radioButton4VisokaAktivnost.AutoSize = true;
            this.radioButton4VisokaAktivnost.Location = new System.Drawing.Point(8, 91);
            this.radioButton4VisokaAktivnost.Name = "radioButton4VisokaAktivnost";
            this.radioButton4VisokaAktivnost.Size = new System.Drawing.Size(280, 17);
            this.radioButton4VisokaAktivnost.TabIndex = 3;
            this.radioButton4VisokaAktivnost.Text = "висока активност (спортуване 6-7 пъти седмично)";
            this.radioButton4VisokaAktivnost.UseVisualStyleBackColor = true;
            // 
            // radioButton3UmerenaAktivnost
            // 
            this.radioButton3UmerenaAktivnost.AutoSize = true;
            this.radioButton3UmerenaAktivnost.Location = new System.Drawing.Point(8, 67);
            this.radioButton3UmerenaAktivnost.Name = "radioButton3UmerenaAktivnost";
            this.radioButton3UmerenaAktivnost.Size = new System.Drawing.Size(287, 17);
            this.radioButton3UmerenaAktivnost.TabIndex = 2;
            this.radioButton3UmerenaAktivnost.Text = "умерена активност (спортуване 3-5 пъти седмично)";
            this.radioButton3UmerenaAktivnost.UseVisualStyleBackColor = true;
            // 
            // radioButton2LekaAktivnost
            // 
            this.radioButton2LekaAktivnost.AutoSize = true;
            this.radioButton2LekaAktivnost.Checked = true;
            this.radioButton2LekaAktivnost.Location = new System.Drawing.Point(8, 43);
            this.radioButton2LekaAktivnost.Name = "radioButton2LekaAktivnost";
            this.radioButton2LekaAktivnost.Size = new System.Drawing.Size(268, 17);
            this.radioButton2LekaAktivnost.TabIndex = 1;
            this.radioButton2LekaAktivnost.TabStop = true;
            this.radioButton2LekaAktivnost.Text = "лека активност (спортуване 1-3 пъти седмично)";
            this.radioButton2LekaAktivnost.UseVisualStyleBackColor = true;
            // 
            // radioButton1Zasednal
            // 
            this.radioButton1Zasednal.AutoSize = true;
            this.radioButton1Zasednal.Location = new System.Drawing.Point(8, 19);
            this.radioButton1Zasednal.Name = "radioButton1Zasednal";
            this.radioButton1Zasednal.Size = new System.Drawing.Size(150, 17);
            this.radioButton1Zasednal.TabIndex = 0;
            this.radioButton1Zasednal.Text = "Заседнал начин на живо";
            this.radioButton1Zasednal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2Woman);
            this.groupBox1.Controls.Add(this.radioButton1Man);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 48);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "пол";
            // 
            // radioButton2Woman
            // 
            this.radioButton2Woman.AutoSize = true;
            this.radioButton2Woman.Location = new System.Drawing.Point(78, 17);
            this.radioButton2Woman.Name = "radioButton2Woman";
            this.radioButton2Woman.Size = new System.Drawing.Size(51, 17);
            this.radioButton2Woman.TabIndex = 1;
            this.radioButton2Woman.TabStop = true;
            this.radioButton2Woman.Text = "жена";
            this.radioButton2Woman.UseVisualStyleBackColor = true;
            // 
            // radioButton1Man
            // 
            this.radioButton1Man.AutoSize = true;
            this.radioButton1Man.Checked = true;
            this.radioButton1Man.Location = new System.Drawing.Point(6, 17);
            this.radioButton1Man.Name = "radioButton1Man";
            this.radioButton1Man.Size = new System.Drawing.Size(48, 17);
            this.radioButton1Man.TabIndex = 0;
            this.radioButton1Man.TabStop = true;
            this.radioButton1Man.Text = "мъж";
            this.radioButton1Man.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Тегло";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Талия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ханш";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Височина";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(8, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 24;
            this.name.Text = "Име";
            // 
            // textBox5Teglo
            // 
            this.textBox5Teglo.Location = new System.Drawing.Point(103, 266);
            this.textBox5Teglo.Name = "textBox5Teglo";
            this.textBox5Teglo.Size = new System.Drawing.Size(37, 20);
            this.textBox5Teglo.TabIndex = 23;
            this.textBox5Teglo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5Teglo_KeyPress);
            // 
            // button4Close
            // 
            this.button4Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4Close.Location = new System.Drawing.Point(366, 339);
            this.button4Close.Name = "button4Close";
            this.button4Close.Size = new System.Drawing.Size(75, 23);
            this.button4Close.TabIndex = 21;
            this.button4Close.Text = "Затвори";
            this.button4Close.UseVisualStyleBackColor = true;
            this.button4Close.Click += new System.EventHandler(this.button4Close_Click);
            // 
            // button3Save
            // 
            this.button3Save.Location = new System.Drawing.Point(266, 339);
            this.button3Save.Name = "button3Save";
            this.button3Save.Size = new System.Drawing.Size(75, 23);
            this.button3Save.TabIndex = 20;
            this.button3Save.Text = "Запази";
            this.button3Save.UseVisualStyleBackColor = true;
            this.button3Save.Click += new System.EventHandler(this.button3Save_Click);
            // 
            // button2Clear
            // 
            this.button2Clear.Location = new System.Drawing.Point(166, 339);
            this.button2Clear.Name = "button2Clear";
            this.button2Clear.Size = new System.Drawing.Size(75, 23);
            this.button2Clear.TabIndex = 19;
            this.button2Clear.Text = "Изчисти";
            this.button2Clear.UseVisualStyleBackColor = true;
            this.button2Clear.Click += new System.EventHandler(this.button2Clear_Click);
            // 
            // button1Calculate
            // 
            this.button1Calculate.Location = new System.Drawing.Point(66, 339);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(75, 23);
            this.button1Calculate.TabIndex = 18;
            this.button1Calculate.Text = "Изчисли";
            this.button1Calculate.UseVisualStyleBackColor = true;
            this.button1Calculate.Click += new System.EventHandler(this.button1Calculate_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(184, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(322, 140);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // textBox4Hansh
            // 
            this.textBox4Hansh.Location = new System.Drawing.Point(103, 206);
            this.textBox4Hansh.Name = "textBox4Hansh";
            this.textBox4Hansh.Size = new System.Drawing.Size(37, 20);
            this.textBox4Hansh.TabIndex = 15;
            this.textBox4Hansh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4Hansh_KeyPress);
            // 
            // textBox3Talia
            // 
            this.textBox3Talia.Location = new System.Drawing.Point(103, 236);
            this.textBox3Talia.Name = "textBox3Talia";
            this.textBox3Talia.Size = new System.Drawing.Size(37, 20);
            this.textBox3Talia.TabIndex = 14;
            this.textBox3Talia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3Talia_KeyPress);
            // 
            // textBox2Visochina
            // 
            this.textBox2Visochina.Location = new System.Drawing.Point(103, 176);
            this.textBox2Visochina.Name = "textBox2Visochina";
            this.textBox2Visochina.Size = new System.Drawing.Size(37, 20);
            this.textBox2Visochina.TabIndex = 13;
            this.textBox2Visochina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Visochina_KeyPress);
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(43, 12);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(174, 20);
            this.textBox1Name.TabIndex = 12;
            // 
            // Body_Fit_Program
            // 
            this.AcceptButton = this.button1Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button4Close;
            this.ClientSize = new System.Drawing.Size(523, 374);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Body_Fit_Program";
            this.Text = "Body_Fit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox5Teglo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2Woman;
        private System.Windows.Forms.RadioButton radioButton1Man;
        private System.Windows.Forms.Button button4Close;
        private System.Windows.Forms.Button button3Save;
        private System.Windows.Forms.Button button2Clear;
        private System.Windows.Forms.Button button1Calculate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4Hansh;
        private System.Windows.Forms.TextBox textBox3Talia;
        private System.Windows.Forms.TextBox textBox2Visochina;
        private System.Windows.Forms.TextBox textBox1Name;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton4VisokaAktivnost;
        private RadioButton radioButton3UmerenaAktivnost;
        private RadioButton radioButton2LekaAktivnost;
        private RadioButton radioButton1Zasednal;
        private PictureBox pictureBox1;
        private Label hd;
        private TextBox textBox2HraneniaDen;
    }
}

