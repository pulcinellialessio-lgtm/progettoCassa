using System.Windows.Forms;

namespace progettoCassa
{
    public partial class Form1 : Form
    {
        List<string> listaOggetti = new List<string>();
        double prezzoTotale = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Aggiorna()
        {
            listBoxRiepilogo.Items.Clear();

            foreach (string s in listaOggetti)
            {
                listBoxRiepilogo.Items.Add(s);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOggetto.Text) || string.IsNullOrWhiteSpace(textBoxPrezzo.Text) || string.IsNullOrWhiteSpace(textBoxQuantita.Text))
            {
                MessageBox.Show("Inserisci un nome e un prezzo validi.");
            }
            else
            {
                int quantita = Convert.ToInt32(textBoxQuantita.Text);
                double prezzo = Convert.ToDouble(textBoxPrezzo.Text);
                string nome = textBoxOggetto.Text;

                prezzo = prezzo * quantita;
                prezzoTotale = prezzoTotale + prezzo;
                                                                                           // sistemare problema con virgola e punto
                listaOggetti.Add("x" + quantita + " " + nome + " - " + prezzo + "€");

                textBoxQuantita.Clear();
                textBoxPrezzo.Clear();
                textBoxOggetto.Clear();

                labelImportoCassa.Text = prezzoTotale + "€";
                Aggiorna();
            }
        }

        private void buttonRimuovi_Click(object sender, EventArgs e)
        {
            int indice = listBoxRiepilogo.SelectedIndex;

            if (indice != -1)
            {
                listaOggetti.RemoveAt(indice);

                int quantita = Convert.ToInt32(textBoxQuantita.Text);
                double prezzo = Convert.ToDouble(textBoxPrezzo.Text);

                prezzo = prezzo * quantita;
                prezzoTotale = prezzoTotale - prezzo;

                labelImportoCassa.Text = prezzoTotale + "€";
            }
            else
            {
                MessageBox.Show("errore");
            }

            Aggiorna();
        }
    }
}
