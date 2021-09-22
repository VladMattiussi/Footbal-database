using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampionatoCalcio
{
    public partial class DatabaseForm : Form
    {
        string nome;
        string cognome;
        DateTime nascita;
        string squadra;
        string nazione;
        int numMaglia;
        string ruolo;
        string ammonto;
        int dataInizio;
        int dataFine;
        enum Persona { Giocatore = 0, Allenatore = 1, Arbitro = 2, Presidente = 3 };
        int p;

        public DatabaseForm()
        {
            InitializeComponent();
        }
        private void DatabaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void cbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPersona.SelectedIndex)
            {
                case 0: //giocatore
                    cbSquadra.Enabled = true;
                    cbRuolo.Enabled = true;
                    tbAmmonto.Enabled = true;
                    tbInizio.Enabled = true;
                    tbFine.Enabled = true;
                    nudMaglia.Enabled = true;
                    break;
                case 1: //allenatore
                    cbSquadra.Enabled = true;
                    cbRuolo.Enabled = false;
                    nudMaglia.Enabled = false;
                    tbAmmonto.Enabled = true;
                    tbInizio.Enabled = true;
                    tbFine.Enabled = true;
                    break;
                case 2: //arbitro
                    cbSquadra.Enabled = false;
                    cbRuolo.Enabled = false;
                    tbAmmonto.Enabled = false;
                    tbInizio.Enabled = false;
                    tbFine.Enabled = false;
                    nudMaglia.Enabled = false;
                    break;
                case 3: //presidente
                    cbSquadra.Enabled = true;
                    cbRuolo.Enabled = false;
                    tbAmmonto.Enabled = false;
                    tbInizio.Enabled = false;
                    tbFine.Enabled = false;
                    nudMaglia.Enabled = false;
                    break;
                default:
                    break;
            }
            p = cbPersona.SelectedIndex;
            btnAggiungi.Enabled = true;
            btnElimina.Enabled = true;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            //controlli
            string CF = Controllo();

            try
            {
                switch (p)
                {
                    case (int)Persona.Giocatore:
                        Form1.InserisciGiocatore(CF, nome, cognome, nascita, nazione, numMaglia, squadra, ruolo, ammonto, dataInizio, dataFine);
                        break;
                    case (int)Persona.Allenatore:
                        Form1.InserisciAllenatore(CF, nome, cognome, nascita, nazione, squadra, ammonto, dataInizio, dataFine);
                        break;
                    case (int)Persona.Arbitro:
                        Form1.InserisciArbitro(CF, nome, cognome, nascita, nazione);
                        break;
                    case (int)Persona.Presidente:
                        Form1.InserisciPresidente(CF, nome, cognome, nascita, squadra, nazione);
                        break;
                    default:
                        break;
                }
                MessageBox.Show("Persona eliminata", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Inserimento non riuscito!");
            }
        }

    private string Controllo()
        {
            try
            {
                CodiceFiscale cf = null;

                nome = tbNome.Text;
                cognome = tbCognome.Text;
                nascita = Convert.ToDateTime(data.Value.ToShortDateString());
                string genere = (rbMaschio.Checked == true ? "M" : "F");
                squadra = cbSquadra.SelectedItem.ToString();
                string comune = tbComune.Text;
                ruolo = cbRuolo.SelectedItem.ToString();
                nazione = tbNazione.Text;
                string provincia = cbProvincia.SelectedItem.ToString();
                numMaglia = (int)nudMaglia.Value;
                ammonto = tbAmmonto.Text;
                dataInizio = Convert.ToInt32(tbInizio.Text);
                dataFine = Convert.ToInt32(tbFine.Text);
                cf = new CodiceFiscale(cognome, nome, genere, nascita, comune, provincia, 0);
                return cf.Codice;
            }
            catch
            {
                MessageBox.Show("Inserire correttamente tutti i campi in modo appropriato", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCognome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbComune_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbInizio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbAmmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbAmmonto.Text.Contains("."))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar.ToString() != "." && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cbPersona_SelectedValueChanged(object sender, EventArgs e)
        {
            cbPersona_SelectedIndexChanged(sender, e);
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            //controlli
            string CF = Controllo();
            try
            {
                switch (p)
                {
                    case (int)Persona.Giocatore:
                        Form1.EliminaGiocatore(cognome, nascita, dataInizio, dataFine);
                        break;
                    case (int)Persona.Allenatore:
                        Form1.EliminaAllenatore(cognome, nascita, dataInizio, dataFine);
                        break;
                    case (int)Persona.Arbitro:
                        Form1.EliminaArbitro(cognome, nascita);
                        break;
                    case (int)Persona.Presidente:
                        Form1.EliminaPresidente(cognome, nascita);
                        break;
                    default:
                        break;
                }
                MessageBox.Show("Persona inserita", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Eliminazione non riuscita!");
            }
        }
    }
}
