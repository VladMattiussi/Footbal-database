namespace CampionatoCalcio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbScelta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.tcResult = new System.Windows.Forms.TabControl();
            this.tpQuery = new System.Windows.Forms.TabPage();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.tpPersona = new System.Windows.Forms.TabPage();
            this.dgPersona = new System.Windows.Forms.DataGridView();
            this.tpGiocatore = new System.Windows.Forms.TabPage();
            this.dgGiocatore = new System.Windows.Forms.DataGridView();
            this.tpAllenatore = new System.Windows.Forms.TabPage();
            this.dgAllenatore = new System.Windows.Forms.DataGridView();
            this.tpArbitro = new System.Windows.Forms.TabPage();
            this.dgArbitro = new System.Windows.Forms.DataGridView();
            this.tpPresidente = new System.Windows.Forms.TabPage();
            this.dgPresidente = new System.Windows.Forms.DataGridView();
            this.tcResult.SuspendLayout();
            this.tpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.tpPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersona)).BeginInit();
            this.tpGiocatore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGiocatore)).BeginInit();
            this.tpAllenatore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllenatore)).BeginInit();
            this.tpArbitro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArbitro)).BeginInit();
            this.tpPresidente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresidente)).BeginInit();
            this.SuspendLayout();
            // 
            // cbScelta
            // 
            this.cbScelta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbScelta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScelta.FormattingEnabled = true;
            this.cbScelta.Items.AddRange(new object[] {
            "Classifica Squadre",
            "Classifica Marcatori",
            "Classifica Fallosi",
            "Classifica Coppe Squadre",
            "Classifica Stadi",
            "Campionato",
            "Classifica Giocatori più Giovani",
            "Classifica Giocatori più Esperti"});
            this.cbScelta.Location = new System.Drawing.Point(13, 56);
            this.cbScelta.Name = "cbScelta";
            this.cbScelta.Size = new System.Drawing.Size(657, 28);
            this.cbScelta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selezionare una query per la visualizzazione";
            // 
            // btnCerca
            // 
            this.btnCerca.BackColor = System.Drawing.Color.MintCream;
            this.btnCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerca.Location = new System.Drawing.Point(676, 54);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(113, 30);
            this.btnCerca.TabIndex = 3;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.MintCream;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(676, 13);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(113, 30);
            this.btnModifica.TabIndex = 4;
            this.btnModifica.Text = "ModificaDB";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // tcResult
            // 
            this.tcResult.Controls.Add(this.tpQuery);
            this.tcResult.Controls.Add(this.tpPersona);
            this.tcResult.Controls.Add(this.tpGiocatore);
            this.tcResult.Controls.Add(this.tpAllenatore);
            this.tcResult.Controls.Add(this.tpArbitro);
            this.tcResult.Controls.Add(this.tpPresidente);
            this.tcResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcResult.Location = new System.Drawing.Point(13, 94);
            this.tcResult.Name = "tcResult";
            this.tcResult.SelectedIndex = 0;
            this.tcResult.Size = new System.Drawing.Size(776, 354);
            this.tcResult.TabIndex = 5;
            // 
            // tpQuery
            // 
            this.tpQuery.Controls.Add(this.dgResult);
            this.tpQuery.Location = new System.Drawing.Point(4, 25);
            this.tpQuery.Name = "tpQuery";
            this.tpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery.Size = new System.Drawing.Size(768, 325);
            this.tpQuery.TabIndex = 5;
            this.tpQuery.Text = "Query";
            this.tpQuery.UseVisualStyleBackColor = true;
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToOrderColumns = true;
            this.dgResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.Location = new System.Drawing.Point(3, 3);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(762, 319);
            this.dgResult.TabIndex = 1;
            // 
            // tpPersona
            // 
            this.tpPersona.Controls.Add(this.dgPersona);
            this.tpPersona.Location = new System.Drawing.Point(4, 25);
            this.tpPersona.Name = "tpPersona";
            this.tpPersona.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersona.Size = new System.Drawing.Size(768, 325);
            this.tpPersona.TabIndex = 0;
            this.tpPersona.Text = "Persona";
            this.tpPersona.UseVisualStyleBackColor = true;
            // 
            // dgPersona
            // 
            this.dgPersona.AllowUserToOrderColumns = true;
            this.dgPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPersona.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPersona.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPersona.Location = new System.Drawing.Point(3, 3);
            this.dgPersona.Name = "dgPersona";
            this.dgPersona.Size = new System.Drawing.Size(762, 319);
            this.dgPersona.TabIndex = 2;
            // 
            // tpGiocatore
            // 
            this.tpGiocatore.Controls.Add(this.dgGiocatore);
            this.tpGiocatore.Location = new System.Drawing.Point(4, 25);
            this.tpGiocatore.Name = "tpGiocatore";
            this.tpGiocatore.Padding = new System.Windows.Forms.Padding(3);
            this.tpGiocatore.Size = new System.Drawing.Size(768, 325);
            this.tpGiocatore.TabIndex = 1;
            this.tpGiocatore.Text = "Giocatore";
            this.tpGiocatore.UseVisualStyleBackColor = true;
            // 
            // dgGiocatore
            // 
            this.dgGiocatore.AllowUserToOrderColumns = true;
            this.dgGiocatore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGiocatore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgGiocatore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgGiocatore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGiocatore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGiocatore.Location = new System.Drawing.Point(3, 3);
            this.dgGiocatore.Name = "dgGiocatore";
            this.dgGiocatore.Size = new System.Drawing.Size(762, 319);
            this.dgGiocatore.TabIndex = 3;
            // 
            // tpAllenatore
            // 
            this.tpAllenatore.Controls.Add(this.dgAllenatore);
            this.tpAllenatore.Location = new System.Drawing.Point(4, 25);
            this.tpAllenatore.Name = "tpAllenatore";
            this.tpAllenatore.Size = new System.Drawing.Size(768, 325);
            this.tpAllenatore.TabIndex = 2;
            this.tpAllenatore.Text = "Allenatore";
            this.tpAllenatore.UseVisualStyleBackColor = true;
            // 
            // dgAllenatore
            // 
            this.dgAllenatore.AllowUserToOrderColumns = true;
            this.dgAllenatore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAllenatore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAllenatore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAllenatore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllenatore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAllenatore.Location = new System.Drawing.Point(0, 0);
            this.dgAllenatore.Name = "dgAllenatore";
            this.dgAllenatore.Size = new System.Drawing.Size(768, 325);
            this.dgAllenatore.TabIndex = 3;
            // 
            // tpArbitro
            // 
            this.tpArbitro.Controls.Add(this.dgArbitro);
            this.tpArbitro.Location = new System.Drawing.Point(4, 25);
            this.tpArbitro.Name = "tpArbitro";
            this.tpArbitro.Size = new System.Drawing.Size(768, 325);
            this.tpArbitro.TabIndex = 3;
            this.tpArbitro.Text = "Arbitro";
            this.tpArbitro.UseVisualStyleBackColor = true;
            // 
            // dgArbitro
            // 
            this.dgArbitro.AllowUserToOrderColumns = true;
            this.dgArbitro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArbitro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgArbitro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgArbitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArbitro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArbitro.Location = new System.Drawing.Point(0, 0);
            this.dgArbitro.Name = "dgArbitro";
            this.dgArbitro.Size = new System.Drawing.Size(768, 325);
            this.dgArbitro.TabIndex = 3;
            // 
            // tpPresidente
            // 
            this.tpPresidente.Controls.Add(this.dgPresidente);
            this.tpPresidente.Location = new System.Drawing.Point(4, 25);
            this.tpPresidente.Name = "tpPresidente";
            this.tpPresidente.Size = new System.Drawing.Size(768, 325);
            this.tpPresidente.TabIndex = 4;
            this.tpPresidente.Text = "Presidente";
            this.tpPresidente.UseVisualStyleBackColor = true;
            // 
            // dgPresidente
            // 
            this.dgPresidente.AllowUserToOrderColumns = true;
            this.dgPresidente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPresidente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPresidente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPresidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPresidente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPresidente.Location = new System.Drawing.Point(0, 0);
            this.dgPresidente.Name = "dgPresidente";
            this.dgPresidente.Size = new System.Drawing.Size(768, 325);
            this.dgPresidente.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.tcResult);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbScelta);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampionatoCalcio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcResult.ResumeLayout(false);
            this.tpQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.tpPersona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersona)).EndInit();
            this.tpGiocatore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGiocatore)).EndInit();
            this.tpAllenatore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllenatore)).EndInit();
            this.tpArbitro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArbitro)).EndInit();
            this.tpPresidente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPresidente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbScelta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TabControl tcResult;
        private System.Windows.Forms.TabPage tpPersona;
        private System.Windows.Forms.TabPage tpGiocatore;
        private System.Windows.Forms.TabPage tpAllenatore;
        private System.Windows.Forms.TabPage tpArbitro;
        private System.Windows.Forms.TabPage tpPresidente;
        private System.Windows.Forms.TabPage tpQuery;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.DataGridView dgPersona;
        private System.Windows.Forms.DataGridView dgGiocatore;
        private System.Windows.Forms.DataGridView dgAllenatore;
        private System.Windows.Forms.DataGridView dgArbitro;
        private System.Windows.Forms.DataGridView dgPresidente;
    }
}

