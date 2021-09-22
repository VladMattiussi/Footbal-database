namespace CampionatoCalcio
{
    partial class DatabaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPersona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMaschio = new System.Windows.Forms.RadioButton();
            this.rbFemmina = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSquadra = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAmmonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nudMaglia = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.cbRuolo = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.tbInizio = new System.Windows.Forms.TextBox();
            this.tbFine = new System.Windows.Forms.TextBox();
            this.tbComune = new System.Windows.Forms.TextBox();
            this.tbNazione = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaglia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aggiungi una persona:";
            // 
            // cbPersona
            // 
            this.cbPersona.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPersona.FormattingEnabled = true;
            this.cbPersona.Items.AddRange(new object[] {
            "GIOCATORE",
            "ALLENATORE",
            "ARBITRO",
            "PRESIDENTE"});
            this.cbPersona.Location = new System.Drawing.Point(185, 12);
            this.cbPersona.Name = "cbPersona";
            this.cbPersona.Size = new System.Drawing.Size(121, 28);
            this.cbPersona.TabIndex = 1;
            this.cbPersona.SelectedIndexChanged += new System.EventHandler(this.cbPersona_SelectedIndexChanged);
            this.cbPersona.SelectedValueChanged += new System.EventHandler(this.cbPersona_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cognome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data di nascita:";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(185, 53);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(121, 26);
            this.tbNome.TabIndex = 5;
            this.tbNome.Text = "Alessandro";
            this.tbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            this.tbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNome_KeyPress);
            // 
            // tbCognome
            // 
            this.tbCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCognome.Location = new System.Drawing.Point(185, 93);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(121, 26);
            this.tbCognome.TabIndex = 6;
            this.tbCognome.Text = "Del Piero";
            this.tbCognome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCognome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCognome_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genere:";
            // 
            // rbMaschio
            // 
            this.rbMaschio.AutoSize = true;
            this.rbMaschio.Checked = true;
            this.rbMaschio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaschio.Location = new System.Drawing.Point(474, 56);
            this.rbMaschio.Name = "rbMaschio";
            this.rbMaschio.Size = new System.Drawing.Size(86, 24);
            this.rbMaschio.TabIndex = 9;
            this.rbMaschio.TabStop = true;
            this.rbMaschio.Text = "Maschio";
            this.rbMaschio.UseVisualStyleBackColor = true;
            // 
            // rbFemmina
            // 
            this.rbFemmina.AutoSize = true;
            this.rbFemmina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemmina.Location = new System.Drawing.Point(585, 56);
            this.rbFemmina.Name = "rbFemmina";
            this.rbFemmina.Size = new System.Drawing.Size(93, 24);
            this.rbFemmina.TabIndex = 10;
            this.rbFemmina.Text = "Femmina";
            this.rbFemmina.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comune:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Provincia:";
            // 
            // cbProvincia
            // 
            this.cbProvincia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Items.AddRange(new object[] {
            "AG",
            "AL",
            "AN",
            "AR",
            "AP",
            "AT",
            "AV",
            "BA",
            "BT",
            "BL",
            "BN",
            "BG",
            "BI",
            "BO",
            "BZ",
            "BS",
            "BR",
            "CA",
            "CL",
            "CB",
            "CI",
            "CE",
            "CT",
            "CZ",
            "CH",
            "CO",
            "CS",
            "CR",
            "KR",
            "CN",
            "EN",
            "FM",
            "FE",
            "FI",
            "FG",
            "FC",
            "FR",
            "GE",
            "GO",
            "GR",
            "IM",
            "IS",
            "AQ",
            "SP",
            "LT",
            "LE",
            "LC",
            "LI",
            "LO",
            "LU",
            "MC",
            "MN",
            "MS",
            "MT",
            "VS",
            "ME",
            "MI",
            "MO",
            "MB",
            "NA",
            "NO",
            "NU",
            "OG",
            "OT",
            "OR",
            "PD",
            "PA",
            "PR",
            "PV",
            "PG",
            "PU",
            "PE",
            "PC",
            "PI",
            "PT",
            "PN",
            "PZ",
            "PO",
            "RG",
            "RA",
            "RC",
            "RE",
            "RI",
            "RN",
            "RM",
            "RO",
            "SA",
            "SS",
            "SV",
            "SI",
            "SR",
            "SO",
            "TA",
            "TE",
            "TR",
            "TO",
            "TP",
            "TN",
            "TV",
            "TS",
            "UD",
            "AO",
            "VA",
            "VE",
            "VB",
            "VC",
            "VR",
            "VV",
            "VI",
            "VT"});
            this.cbProvincia.Location = new System.Drawing.Point(474, 181);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(121, 28);
            this.cbProvincia.TabIndex = 14;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.BackColor = System.Drawing.Color.MintCream;
            this.btnAggiungi.Enabled = false;
            this.btnAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungi.Location = new System.Drawing.Point(351, 332);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(327, 43);
            this.btnAggiungi.TabIndex = 15;
            this.btnAggiungi.Text = "AGGIUNGI PERSONA";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Squadra di appartenenza:";
            // 
            // cbSquadra
            // 
            this.cbSquadra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSquadra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSquadra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSquadra.FormattingEnabled = true;
            this.cbSquadra.Items.AddRange(new object[] {
            "Atalanta",
            "Bologna",
            "Cagliari",
            "Chievo Verona",
            "Empoli",
            "Fiorentina",
            "Frosinone",
            "Genoa",
            "Inter",
            "Juventus",
            "Lazio",
            "Milan",
            "Napoli",
            "Parma",
            "Roma",
            "Sampdoria",
            "Sassuolo",
            "SPAL",
            "Torino",
            "Udinese"});
            this.cbSquadra.Location = new System.Drawing.Point(559, 13);
            this.cbSquadra.Name = "cbSquadra";
            this.cbSquadra.Size = new System.Drawing.Size(121, 28);
            this.cbSquadra.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Contratto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(347, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "da:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(521, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "fino a:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ammonto: [milioni]";
            // 
            // tbAmmonto
            // 
            this.tbAmmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmmonto.Location = new System.Drawing.Point(185, 289);
            this.tbAmmonto.MaxLength = 5;
            this.tbAmmonto.Name = "tbAmmonto";
            this.tbAmmonto.Size = new System.Drawing.Size(121, 26);
            this.tbAmmonto.TabIndex = 25;
            this.tbAmmonto.Text = "0.22";
            this.tbAmmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAmmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmmonto_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Numero di maglia:";
            // 
            // nudMaglia
            // 
            this.nudMaglia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaglia.Location = new System.Drawing.Point(186, 181);
            this.nudMaglia.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudMaglia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaglia.Name = "nudMaglia";
            this.nudMaglia.Size = new System.Drawing.Size(120, 26);
            this.nudMaglia.TabIndex = 27;
            this.nudMaglia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaglia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(347, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Ruolo:";
            // 
            // cbRuolo
            // 
            this.cbRuolo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbRuolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRuolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRuolo.FormattingEnabled = true;
            this.cbRuolo.Items.AddRange(new object[] {
            "ATT",
            "CEN",
            "DIF",
            "POR"});
            this.cbRuolo.Location = new System.Drawing.Point(474, 229);
            this.cbRuolo.Name = "cbRuolo";
            this.cbRuolo.Size = new System.Drawing.Size(121, 28);
            this.cbRuolo.TabIndex = 29;
            // 
            // data
            // 
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(185, 141);
            this.data.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.data.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(121, 26);
            this.data.TabIndex = 30;
            this.data.Value = new System.DateTime(1974, 11, 9, 0, 0, 0, 0);
            // 
            // tbInizio
            // 
            this.tbInizio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInizio.Location = new System.Drawing.Point(409, 289);
            this.tbInizio.MaxLength = 4;
            this.tbInizio.Name = "tbInizio";
            this.tbInizio.Size = new System.Drawing.Size(80, 26);
            this.tbInizio.TabIndex = 31;
            this.tbInizio.Text = "1993";
            this.tbInizio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInizio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInizio_KeyPress);
            // 
            // tbFine
            // 
            this.tbFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFine.Location = new System.Drawing.Point(598, 287);
            this.tbFine.MaxLength = 4;
            this.tbFine.Name = "tbFine";
            this.tbFine.Size = new System.Drawing.Size(80, 26);
            this.tbFine.TabIndex = 32;
            this.tbFine.Text = "2012";
            this.tbFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFine_KeyPress);
            // 
            // tbComune
            // 
            this.tbComune.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComune.Location = new System.Drawing.Point(474, 141);
            this.tbComune.Name = "tbComune";
            this.tbComune.Size = new System.Drawing.Size(121, 26);
            this.tbComune.TabIndex = 33;
            this.tbComune.Text = "Conegliano";
            this.tbComune.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbComune.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbComune_KeyPress);
            // 
            // tbNazione
            // 
            this.tbNazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNazione.Location = new System.Drawing.Point(474, 99);
            this.tbNazione.Name = "tbNazione";
            this.tbNazione.Size = new System.Drawing.Size(121, 26);
            this.tbNazione.TabIndex = 35;
            this.tbNazione.Text = "Italia";
            this.tbNazione.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(347, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Nazionalità:";
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.MintCream;
            this.btnElimina.Enabled = false;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnElimina.Location = new System.Drawing.Point(12, 332);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(294, 43);
            this.btnElimina.TabIndex = 36;
            this.btnElimina.Text = "ELIMINA PERSONA";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(696, 387);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.tbNazione);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbComune);
            this.Controls.Add(this.tbFine);
            this.Controls.Add(this.tbInizio);
            this.Controls.Add(this.data);
            this.Controls.Add(this.cbRuolo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nudMaglia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbAmmonto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSquadra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.cbProvincia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbFemmina);
            this.Controls.Add(this.rbMaschio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCognome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPersona);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatabaseForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaglia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMaschio;
        private System.Windows.Forms.RadioButton rbFemmina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSquadra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAmmonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudMaglia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbRuolo;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.TextBox tbInizio;
        private System.Windows.Forms.TextBox tbFine;
        private System.Windows.Forms.TextBox tbComune;
        private System.Windows.Forms.TextBox tbNazione;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnElimina;
    }
}