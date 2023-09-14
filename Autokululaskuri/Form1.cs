namespace Autokululaskuri
{
    public partial class KustannusForm : Form
    {
        public KustannusForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, muut,polttoaine, pesut, huollot, renkaat, kilometrit, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            nesteet = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(VakuutusTB.Text);
            muut = Convert.ToDouble(PesutTB.Text);
            polttoaine = Convert.ToDouble(PolttonesteTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            kustannukset = (laina + nesteet + vakuutus + muut + polttoaine + pesut + huollot + renkaat) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometria kohti ovat: " + kustannukset;
            VastausLB.Visible = true;
        }

    }

}