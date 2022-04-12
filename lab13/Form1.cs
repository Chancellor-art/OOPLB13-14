namespace lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        virtual protected void formRez()
        {
            string resultat;
            resultat = Priz.Text;

            if (NameFO.Text != "")
            {
                if (resultat != "") resultat += " ";
                resultat += NameFO.Text;
            }

            if (Fname.Text != "")
            {
                if (resultat != "") resultat += " ";
                resultat += Fname.Text;
            }

            Rez.Text = resultat;
        }

        private void Priz_TextChanged(object sender, EventArgs e)
        {
            formRez();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            formRez();
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
            formRez();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formRez();
        }
    }
}