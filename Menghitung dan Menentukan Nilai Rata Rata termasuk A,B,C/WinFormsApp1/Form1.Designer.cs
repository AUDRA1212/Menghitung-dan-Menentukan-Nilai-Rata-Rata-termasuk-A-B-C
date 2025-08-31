namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpinput = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtpas = new TextBox();
            txtnama = new TextBox();
            txtpts = new TextBox();
            txtabsen = new TextBox();
            grpoutput = new GroupBox();
            label9 = new Label();
            txtnamahasil = new TextBox();
            label8 = new Label();
            txtabsenhasil = new TextBox();
            txtratarata = new TextBox();
            txtgrade = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnproses = new Button();
            btnclear = new Button();
            btnkeluar = new Button();
            label7 = new Label();
            grpinput.SuspendLayout();
            grpoutput.SuspendLayout();
            SuspendLayout();
            // 
            // grpinput
            // 
            grpinput.Controls.Add(label4);
            grpinput.Controls.Add(label2);
            grpinput.Controls.Add(label3);
            grpinput.Controls.Add(label1);
            grpinput.Controls.Add(txtpas);
            grpinput.Controls.Add(txtnama);
            grpinput.Controls.Add(txtpts);
            grpinput.Controls.Add(txtabsen);
            grpinput.Location = new Point(77, 148);
            grpinput.Name = "grpinput";
            grpinput.Size = new Size(332, 334);
            grpinput.TabIndex = 0;
            grpinput.TabStop = false;
            grpinput.Text = "Input";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 237);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Nilai PAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Absen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 184);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Nilai PTS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Nama";
            // 
            // txtpas
            // 
            txtpas.Location = new Point(15, 260);
            txtpas.Name = "txtpas";
            txtpas.Size = new Size(301, 27);
            txtpas.TabIndex = 4;
            // 
            // txtnama
            // 
            txtnama.Location = new Point(15, 65);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(301, 27);
            txtnama.TabIndex = 0;
            txtnama.TextChanged += textBox1_TextChanged;
            // 
            // txtpts
            // 
            txtpts.Location = new Point(15, 207);
            txtpts.Name = "txtpts";
            txtpts.Size = new Size(301, 27);
            txtpts.TabIndex = 3;
            txtpts.TextChanged += textBox3_TextChanged;
            // 
            // txtabsen
            // 
            txtabsen.Location = new Point(15, 118);
            txtabsen.Name = "txtabsen";
            txtabsen.Size = new Size(301, 27);
            txtabsen.TabIndex = 2;
            txtabsen.TextChanged += txtabsen_TextChanged;
            // 
            // grpoutput
            // 
            grpoutput.BackColor = Color.Transparent;
            grpoutput.Controls.Add(label9);
            grpoutput.Controls.Add(txtnamahasil);
            grpoutput.Controls.Add(label8);
            grpoutput.Controls.Add(txtabsenhasil);
            grpoutput.Controls.Add(txtratarata);
            grpoutput.Controls.Add(txtgrade);
            grpoutput.Controls.Add(label6);
            grpoutput.Controls.Add(label5);
            grpoutput.Location = new Point(652, 148);
            grpoutput.Name = "grpoutput";
            grpoutput.Size = new Size(286, 271);
            grpoutput.TabIndex = 1;
            grpoutput.TabStop = false;
            grpoutput.Text = "Hasil";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 22);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 7;
            label9.Text = "Nama";
            // 
            // txtnamahasil
            // 
            txtnamahasil.Location = new Point(17, 42);
            txtnamahasil.Name = "txtnamahasil";
            txtnamahasil.Size = new Size(249, 27);
            txtnamahasil.TabIndex = 6;
            txtnamahasil.TextChanged += txtnamahasil_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 72);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 5;
            label8.Text = "Absen";
            // 
            // txtabsenhasil
            // 
            txtabsenhasil.Location = new Point(17, 92);
            txtabsenhasil.Name = "txtabsenhasil";
            txtabsenhasil.Size = new Size(249, 27);
            txtabsenhasil.TabIndex = 4;
            txtabsenhasil.TextChanged += txtabsenhasil_TextChanged;
            // 
            // txtratarata
            // 
            txtratarata.Location = new Point(17, 154);
            txtratarata.Name = "txtratarata";
            txtratarata.Size = new Size(249, 27);
            txtratarata.TabIndex = 2;
            // 
            // txtgrade
            // 
            txtgrade.Location = new Point(17, 207);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new Size(249, 27);
            txtgrade.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 184);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 2;
            label6.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 131);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 2;
            label5.Text = "Rata Rata PTS dan PAS";
            // 
            // btnproses
            // 
            btnproses.Location = new Point(564, 486);
            btnproses.Name = "btnproses";
            btnproses.Size = new Size(94, 29);
            btnproses.TabIndex = 3;
            btnproses.Text = "Proses";
            btnproses.UseVisualStyleBackColor = true;
            btnproses.Click += btnproses_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(725, 486);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 4;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnkeluar
            // 
            btnkeluar.Location = new Point(883, 486);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(94, 29);
            btnkeluar.TabIndex = 5;
            btnkeluar.Text = "Keluar";
            btnkeluar.UseVisualStyleBackColor = true;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Window;
            label7.Enabled = false;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI Variable Text", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(77, 25);
            label7.Name = "label7";
            label7.Size = new Size(900, 67);
            label7.TabIndex = 2;
            label7.Text = "DATA NILAI SISWA/SISWI";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1107, 626);
            Controls.Add(btnkeluar);
            Controls.Add(btnclear);
            Controls.Add(btnproses);
            Controls.Add(label7);
            Controls.Add(grpoutput);
            Controls.Add(grpinput);
            Name = "Form1";
            Text = "Form1";
            grpinput.ResumeLayout(false);
            grpinput.PerformLayout();
            grpoutput.ResumeLayout(false);
            grpoutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpinput;
        private TextBox txtnama;
        private TextBox txtabsen;
        private GroupBox grpoutput;
        private TextBox txtpts;
        private TextBox txtpas;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtratarata;
        private TextBox txtgrade;
        private Label label6;
        private Label label5;
        private Button btnproses;
        private Button btnclear;
        private Button btnkeluar;
        private Label label7;
        private TextBox txtabsenhasil;
        private Label label9;
        private TextBox txtnamahasil;
        private Label label8;
    }
}
