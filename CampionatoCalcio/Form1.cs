using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public CampionatoCalcioDataContext db = new CampionatoCalcioDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            DatabaseForm f2 = new DatabaseForm();
            f2.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cbScelta.SelectedItem = null;
            cbScelta.SelectedValue = 0;
            cbScelta.SelectedText = "Classifica Squadre";

            //carcicamento tabelle
            dgPersona.DataSource = from p in db.persona
                                   orderby p.nome, p.cognome descending
                                   select new { p.CF, Nome = p.nome, Cognome = p.cognome, DataDiNascita = p.dataNascita, Nazionalità = p.nazionalita };

            dgGiocatore.DataSource = from g in db.giocatore
                                     from p in db.persona
                                     where g.CF_GIO == p.CF
                                     orderby p.nome, p.cognome descending
                                     select new { p.CF, Nome = p.nome, Cognome = p.cognome, Nazionalità = p.nazionalita, DataDiNascita = p.dataNascita, Squadra = g.nomeSquadra };

            dgAllenatore.DataSource = from a in db.allenatore
                                      from p in db.persona
                                      from s in db.squadra
                                      where a.CF_ALL == p.CF && a.nomeSquadra == s.nomeSquadra
                                      orderby p.nome, p.cognome descending
                                      select new { p.CF, Nome = p.nome, Cognome = p.cognome, Nazionalità = p.nazionalita, DataDiNascita = p.dataNascita, Squadra = s.nomeSquadra };

            dgArbitro.DataSource = from a in db.arbitro
                                   from p in db.persona
                                   where a.CF_ARB == p.CF
                                   orderby p.nome, p.cognome descending
                                   select new { p.CF, Nome = p.nome, Cognome = p.cognome, Nazionalità = p.nazionalita, DataDiNascita = p.dataNascita };

            dgPresidente.DataSource = from pr in db.presidente
                                      from p in db.persona
                                      from s in db.squadra
                                      where pr.CF_PRE == p.CF && pr.CF_PRE == s.CF_PRE
                                      orderby p.nome, p.cognome descending
                                      select new { p.CF, Nome = p.nome, Cognome = p.cognome, Nazionalità = p.nazionalita, DataDiNascita = p.dataNascita, Squadra = s.nomeSquadra };
        }

        internal static void InserisciGiocatore(string cF, string nome, string cognome, DateTime nascita, string nazione, int numMaglia, string squadra, string ruolo, string ammonto, int dataInizio, int dataFine)
        {
            using (CampionatoCalcioDataContext db = new CampionatoCalcioDataContext())
            {
                persona P = new persona();
                giocatore G = new giocatore();
                contratto C = new contratto();
                P.CF = cF;
                P.nome = nome;
                P.cognome = cognome;
                P.nazionalita = nazione;
                P.dataNascita = nascita;
                P.GIOCATORE = "1";
                P.ALLENATORE = P.ARBITRO = P.PRESIDENTE = "";
                G.numMaglia = numMaglia;
                G.CF_GIO = cF;
                G.ruolo = ruolo;
                G.partiteGiocate = 0;
                G.capitano = null;
                G.goal = G.tiri = G.assist = G.ammonizioni = G.esplusioni = "";
                G.nomeSquadra = squadra;
                int lastContr =   (from c in db.contratto
                               orderby c.codContratto descending
                               select c.codContratto).ToList().First();
                
                C.codContratto = G.codContratto = lastContr + 1;
                C.ammonto = ammonto;
                C.dataInizio = dataInizio;
                C.dataScadenza = dataFine;

                db.persona.InsertOnSubmit(P);
                db.contratto.InsertOnSubmit(C);
                db.giocatore.InsertOnSubmit(G);
                db.SubmitChanges();
            };
        }

        internal static void InserisciAllenatore(string cF, string nome, string cognome, DateTime nascita, string nazione, string squadra, string ammonto, int dataInizio, int dataFine)
        {
            using (CampionatoCalcioDataContext db = new CampionatoCalcioDataContext())
            {
                persona P = new persona();
                allenatore A = new allenatore();
                contratto C = new contratto();
                A.CF_ALL = P.CF = cF;
                P.nome = nome;
                P.cognome = cognome;
                P.nazionalita = nazione;
                P.dataNascita = nascita;
                P.ALLENATORE = "1";
                P.GIOCATORE = P.ARBITRO = P.PRESIDENTE = "";
                A.nomeSquadra = squadra;
                int lastContr = (from c in db.contratto
                                 orderby c.codContratto descending
                                 select c.codContratto).ToList().First();

                C.codContratto = A.codContratto = lastContr + 1;
                C.ammonto = ammonto;
                C.dataInizio = dataInizio;
                C.dataScadenza = dataFine;

                db.persona.InsertOnSubmit(P);
                db.allenatore.InsertOnSubmit(A);
                db.contratto.InsertOnSubmit(C);
                db.SubmitChanges();
            };
        }

        internal static void InserisciPresidente(string cF, string nome, string cognome, DateTime nascita, string nazione, string squadra)
        {
            using (CampionatoCalcioDataContext db = new CampionatoCalcioDataContext())
            {
                persona P = new persona();
                presidente PR = new presidente();
                squadra S = new squadra();

                P.CF = cF;
                P.nome = nome;
                P.cognome = cognome;
                P.nazionalita = nazione;
                P.dataNascita = nascita;
                P.GIOCATORE = "";
                P.ALLENATORE = "";
                P.ARBITRO = "";
                P.PRESIDENTE = "1";
                PR.CF_PRE = S.CF_PRE = cF;

                db.persona.InsertOnSubmit(P);
                db.squadra.InsertOnSubmit(S);
                db.SubmitChanges();
            };
        }

        internal static void InserisciArbitro(string cF, string nome, string cognome, DateTime nascita, string nazione)
        {
            using (CampionatoCalcioDataContext db = new CampionatoCalcioDataContext())
            {
                persona P = new persona();
                arbitro A = new arbitro();

                A.CF_ARB = P.CF = cF;
                P.nome = nome;
                P.cognome = cognome;
                P.nazionalita = nazione;
                P.dataNascita = nascita;
                P.GIOCATORE = "";
                P.ALLENATORE = "";
                P.ARBITRO = "1";
                P.PRESIDENTE = "";

                db.persona.InsertOnSubmit(P);
                db.arbitro.InsertOnSubmit(A);
                db.SubmitChanges();
            };
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            IQueryable res = null;
            switch (cbScelta.SelectedIndex)
            {
                case 0:
                    res = ClassificaSquadre();
                    break;
                case 1:
                    res = Marcatori();
                    break;
                case 2:
                    res = Fallosi();
                    break;
                case 3:
                    res = CoppeSquadre();
                    break;
                case 4:
                    res = Stadi();
                    break;
                case 5:
                    res = Campionati();
                    break;
                case 6:
                    res = ClassificaGiovani();
                    break;
                case 7:
                    res = ClassificaEsperti();
                    break;
                default:
                    break;
            }

            dgResult.DataSource = res;
        }

        internal static void EliminaPresidente(string cognome, DateTime data)
        {
            using (CampionatoCalcioDataContext db = new CampionatoCalcioDataContext())
            {
                string CF = (from p in db.persona
                             from pr in db.presidente
                             where p.CF == pr.CF_PRE && p.cognome == cognome && p.dataNascita == data
                             select p.CF).ToList().First();

                persona P = db.persona.Single(c => c.cognome == cognome && c.dataNascita == data);
                presidente PR = db.presidente.Single(p => p.CF_PRE == CF);

                db.presidente.DeleteOnSubmit(PR);
                db.persona.DeleteOnSubmit(P);
                db.SubmitChanges();
            };
        }

        internal static void EliminaArbitro(string cognome, DateTime data)
        {
            using (CampionatoCalcioDataContext db = new CampionatoCalcioDataContext())
            {
                string CF = (from p in db.persona
                             from a in db.arbitro
                             where p.CF == a.CF_ARB && p.cognome == cognome && p.dataNascita == data
                             select p.CF).ToList().First();

                persona P = db.persona.Single(c => c.cognome == cognome && c.dataNascita == data);
             
                arbitro A = db.arbitro.Single(a => a.CF_ARB == CF);

                db.persona.DeleteOnSubmit(P);
                db.arbitro.DeleteOnSubmit(A);
                db.SubmitChanges();
            };
        }

        internal static void EliminaAllenatore(string cognome, DateTime data, int dataInizio, int dataFine)
        {
            using (CampionatoCalcioDataContext db = new CampionatoCalcioDataContext())
            {
                string CF = (from p in db.persona
                             from a in db.allenatore
                             where p.CF == a.CF_ALL && p.cognome == cognome && p.dataNascita == data
                             select p.CF).ToList().First();

                int delContr = (from c in db.contratto
                                from p in db.persona
                                 where c.dataInizio == dataInizio && c.dataScadenza == dataFine && p.CF == CF
                                 orderby c.codContratto descending
                                 select c.codContratto).ToList().First();

                persona P = db.persona.Single(c => c.cognome == cognome && c.dataNascita == data);
                contratto C = db.contratto.Single(c => c.codContratto == delContr);
                allenatore A = db.allenatore.Single(a => a.CF_ALL == CF);

                db.allenatore.DeleteOnSubmit(A);
                db.contratto.DeleteOnSubmit(C);
                db.persona.DeleteOnSubmit(P);
                db.SubmitChanges();
            };
        }

        internal static void EliminaGiocatore(string cognome, DateTime data, int dataInizio, int dataFine)
        {
            using (CampionatoCalcioDataContext db = new CampionatoCalcioDataContext())
            {
                string CF = (from p in db.persona
                             from g in db.giocatore
                             where p.CF == g.CF_GIO && p.cognome == cognome && p.dataNascita == data
                             select p.CF).ToList().First();

                int delContr = (from c in db.contratto
                                from p in db.persona
                                where c.dataInizio == dataInizio && c.dataScadenza == dataFine && p.CF == CF
                                orderby c.codContratto descending
                                select c.codContratto).ToList().First();

                persona P = db.persona.Single(c => c.cognome == cognome && c.dataNascita == data);
                contratto C = db.contratto.Single(c => c.codContratto == delContr);
                giocatore G = db.giocatore.Single(g => g.CF_GIO == CF);

                db.giocatore.DeleteOnSubmit(G);
                db.contratto.DeleteOnSubmit(C);
                db.persona.DeleteOnSubmit(P);
                db.SubmitChanges();
            };
        }

        private IQueryable ClassificaEsperti()
        {
            var q = from g in db.giocatore
                    from p in db.persona
                    where g.CF_GIO == p.CF
                    orderby p.dataNascita ascending
                    select new { p.CF, Nome = p.nome, Cognome = p.cognome, Nazionalità = p.nazionalita, DataDiNascita = p.dataNascita, Squadra = g.nomeSquadra };
            return q;
        }

        private IQueryable ClassificaGiovani()
        {
            var q = from g in db.giocatore
                     from p in db.persona
                     where g.CF_GIO == p.CF
                     orderby p.dataNascita descending
                     select new { p.CF, Nome = p.nome, Cognome = p.cognome, Nazionalità = p.nazionalita, DataDiNascita = p.dataNascita, Squadra = g.nomeSquadra };
            return q;
        }

        private IQueryable Campionati()
        {
            var q = from c in db.campionato
                    select new { c.stagione, c.nome, c.luogo };
            return q;
        }

        private IQueryable Stadi()
        {
            var q = (from s in db.stadio
                    from p in db.partita
                    from sq in db.squadra
                    where p.codStadio == s.codStadio && p.nomeSquadraCasa == sq.nomeSquadra
                    select new { NomeStadio = s.nomeStadio, Squadra = sq.nomeSquadra, Luogo = s.luogo, Capienza = s.capienza}).Distinct().OrderByDescending(s => s.Capienza);
            return q;
        }

        private IQueryable CoppeSquadre()
        {
            var q = from s in db.squadra
                    from v in db.vittoria
                    from c in db.coppa
                    where s.nomeSquadra == v.nomeSquadra && c.codCoppa == v.codCoppa
                    select new {Squadra = s.nomeSquadra, Scudetti = c.scudetti, ChampionsLeague = c.UCL, WorldCup = c.CWC, EuropaLeague = c.UEL };
            return q;
        }

        private IQueryable Fallosi()
        {
            var q = (from g in db.giocatore
                     from p in db.persona
                     where g.CF_GIO == p.CF && Convert.ToInt32(g.esplusioni) > 0 || Convert.ToInt32(g.ammonizioni) > 0 
                     orderby Convert.ToInt32(g.esplusioni), Convert.ToInt32(g.ammonizioni) descending
                     select new { Nome = p.nome, Cognome = p.cognome, Ammonizioni = g.ammonizioni, Espulsioni = g.esplusioni, Squadra = g.nomeSquadra }).Take(25);
            return q;
        }


        private IQueryable ClassificaSquadre()
        { 
            var q = from s in db.squadra
                    from pr in db.presidente
                    from p in db.persona
                    where pr.CF_PRE == s.CF_PRE && p.CF == pr.CF_PRE
                    select new { Squadra = s.nomeSquadra, Modulo = s.modulo, Stemma = s.stemma, Nazionale = s.NAZIONALE, Club = s.CLUB, Presidente = p.cognome + " " + p.nome };
            return q;
        }

        private IQueryable Marcatori()
        {
            var q = (from g in db.giocatore
                            from p in db.persona
                            where g.CF_GIO == p.CF 
                           orderby Convert.ToInt32(g.goal) descending
                           select new {Nome =p.nome, Cognome = p.cognome, Goal = g.goal, Assist = g.assist, Squadra = g.nomeSquadra }).Take(25);
            return q;
        }
    }
}
