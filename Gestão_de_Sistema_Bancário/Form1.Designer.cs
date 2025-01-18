namespace Gestão_de_Sistema_Bancário
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_Poupanca = new System.Windows.Forms.RadioButton();
            this.rdb_Corrente = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxGestor = new System.Windows.Forms.ComboBox();
            this.txtNConta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNTelefone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(727, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 26);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdb_Masculino
            // 
            this.rdb_Masculino.AutoSize = true;
            this.rdb_Masculino.Location = new System.Drawing.Point(7, 29);
            this.rdb_Masculino.Name = "rdb_Masculino";
            this.rdb_Masculino.Size = new System.Drawing.Size(107, 24);
            this.rdb_Masculino.TabIndex = 3;
            this.rdb_Masculino.TabStop = true;
            this.rdb_Masculino.Text = "Masculino";
            this.rdb_Masculino.UseVisualStyleBackColor = true;
            this.rdb_Masculino.CheckedChanged += new System.EventHandler(this.rdb_Masculino_CheckedChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(16, 133);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(171, 26);
            this.txtSobrenome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sobrenome";
            // 
            // txtBI
            // 
            this.txtBI.Location = new System.Drawing.Point(19, 262);
            this.txtBI.Name = "txtBI";
            this.txtBI.Size = new System.Drawing.Size(168, 26);
            this.txtBI.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nº BI";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data de Nascimento";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Location = new System.Drawing.Point(22, 317);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(165, 28);
            this.cbxProvincia.TabIndex = 10;
            this.cbxProvincia.SelectedIndexChanged += new System.EventHandler(this.cbxProvincia_SelectedIndexChanged);
            this.cbxProvincia.DropDownClosed += new System.EventHandler(this.cbxProvincia_DropDownClosed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Provincia";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Municipio";
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(22, 387);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(165, 28);
            this.cbxMunicipio.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Feminino);
            this.groupBox1.Controls.Add(this.rdb_Masculino);
            this.groupBox1.Location = new System.Drawing.Point(203, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdb_Feminino
            // 
            this.rdb_Feminino.AutoSize = true;
            this.rdb_Feminino.Location = new System.Drawing.Point(7, 68);
            this.rdb_Feminino.Name = "rdb_Feminino";
            this.rdb_Feminino.Size = new System.Drawing.Size(106, 24);
            this.rdb_Feminino.TabIndex = 4;
            this.rdb_Feminino.TabStop = true;
            this.rdb_Feminino.Text = "Femenino";
            this.rdb_Feminino.UseVisualStyleBackColor = true;
            this.rdb_Feminino.CheckedChanged += new System.EventHandler(this.rdb_Feminino_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_Poupanca);
            this.groupBox2.Controls.Add(this.rdb_Corrente);
            this.groupBox2.Location = new System.Drawing.Point(19, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Conta";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdb_Poupanca
            // 
            this.rdb_Poupanca.AutoSize = true;
            this.rdb_Poupanca.Location = new System.Drawing.Point(7, 68);
            this.rdb_Poupanca.Name = "rdb_Poupanca";
            this.rdb_Poupanca.Size = new System.Drawing.Size(107, 24);
            this.rdb_Poupanca.TabIndex = 4;
            this.rdb_Poupanca.TabStop = true;
            this.rdb_Poupanca.Text = "Poupança";
            this.rdb_Poupanca.UseVisualStyleBackColor = true;
            this.rdb_Poupanca.CheckedChanged += new System.EventHandler(this.rdb_Poupanca_CheckedChanged);
            // 
            // rdb_Corrente
            // 
            this.rdb_Corrente.AutoSize = true;
            this.rdb_Corrente.Location = new System.Drawing.Point(7, 29);
            this.rdb_Corrente.Name = "rdb_Corrente";
            this.rdb_Corrente.Size = new System.Drawing.Size(97, 24);
            this.rdb_Corrente.TabIndex = 3;
            this.rdb_Corrente.TabStop = true;
            this.rdb_Corrente.Text = "Corrente";
            this.rdb_Corrente.UseVisualStyleBackColor = true;
            this.rdb_Corrente.CheckedChanged += new System.EventHandler(this.rdb_Corrente_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gestor";
            // 
            // cbxGestor
            // 
            this.cbxGestor.FormattingEnabled = true;
            this.cbxGestor.Location = new System.Drawing.Point(19, 309);
            this.cbxGestor.Name = "cbxGestor";
            this.cbxGestor.Size = new System.Drawing.Size(174, 28);
            this.cbxGestor.TabIndex = 16;
            // 
            // txtNConta
            // 
            this.txtNConta.Enabled = false;
            this.txtNConta.Location = new System.Drawing.Point(19, 72);
            this.txtNConta.Name = "txtNConta";
            this.txtNConta.Size = new System.Drawing.Size(174, 26);
            this.txtNConta.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nº  de Conta";
            // 
            // txtIban
            // 
            this.txtIban.Enabled = false;
            this.txtIban.Location = new System.Drawing.Point(72, 133);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(121, 26);
            this.txtIban.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "IBAN";
            // 
            // txtNTelefone
            // 
            this.txtNTelefone.Location = new System.Drawing.Point(22, 458);
            this.txtNTelefone.Name = "txtNTelefone";
            this.txtNTelefone.Size = new System.Drawing.Size(120, 26);
            this.txtNTelefone.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nº  de Telefone";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(19, 198);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(174, 26);
            this.txtSaldo.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Saldo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Data de Abertura";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(541, 225);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker2.TabIndex = 26;
            this.dateTimePicker2.EnabledChanged += new System.EventHandler(this.rdb_Poupanca_CheckedChanged);
            this.dateTimePicker2.VisibleChanged += new System.EventHandler(this.Form1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(19, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 26);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "AO06";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(17, 254);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(174, 26);
            this.dateTimePicker3.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSobrenome);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNome);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.txtBI);
            this.groupBox3.Controls.Add(this.txtNTelefone);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbxProvincia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbxMunicipio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(298, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 522);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS DO CLIENTE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNConta);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dateTimePicker3);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbxGestor);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtIban);
            this.groupBox4.Controls.Add(this.txtSaldo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(709, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 473);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DADOS DA CONTA";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DimGray;
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(-6, -5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 636);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DimGray;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(162, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "ODE";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(111, 533);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "ASTER";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DimGray;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 484);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "ANCO";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DimGray;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(119, 553);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 55);
            this.label16.TabIndex = 7;
            this.label16.Text = "C";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DimGray;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 450);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 55);
            this.label17.TabIndex = 5;
            this.label17.Text = "B";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DimGray;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(63, 498);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 55);
            this.label18.TabIndex = 6;
            this.label18.Text = "M";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(897, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 67);
            this.button4.TabIndex = 36;
            this.button4.Text = "CANCELAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1058, 627);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdb_Masculino;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProvincia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_Feminino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_Poupanca;
        private System.Windows.Forms.RadioButton rdb_Corrente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxGestor;
        private System.Windows.Forms.TextBox txtNConta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
    }
}

