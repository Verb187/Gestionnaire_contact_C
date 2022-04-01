namespace B1_prog_6_TD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && textBoxTel.Text != "" && textBoxMail.Text != "")
            {
                Contact monContact = new Contact(textBoxNom.Text, textBoxPrenom.Text, textBoxTel.Text, textBoxMail.Text);
                listBoxContact.Items.Add(monContact);
            } else
            {
                MessageBox.Show("Veuillez saisir les champs avant d'ajouter.", "Gestionnaire de contact - Verb.");
            }

        }

        private void listBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex>-1)
            {
                textBoxNom.Text = ((Contact)listBoxContact.SelectedItem).GetNom();
                textBoxPrenom.Text = ((Contact)listBoxContact.SelectedItem).GetPrenom();
                textBoxTel.Text = ((Contact)listBoxContact.SelectedItem).GetTel();
                textBoxMail.Text = ((Contact)listBoxContact.SelectedItem).GetMail();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex > -1)
            {
                listBoxContact.Items.RemoveAt(listBoxContact.SelectedIndex);
                Contact monContact = new Contact(textBoxNom.Text, textBoxPrenom.Text, textBoxTel.Text, textBoxMail.Text);
                listBoxContact.Items.Add(monContact);
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une personne à modifier.", "Gestionnaire de contact - Verb.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxContact.SelectedIndex > -1)
            {
                listBoxContact.Items.RemoveAt(listBoxContact.SelectedIndex);
            } else
            {
                MessageBox.Show("Veuillez selectionner une personne à supprimer.", "Gestionnaire de contact - Verb.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                const string sPath = "info";

                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("C:/Users/3asba/Desktop/info/" + sPath + ".csv");
                foreach (var item in listBoxContact.Items)
                {
                SaveFile.WriteLine("Gestionnaire de contact");
                SaveFile.WriteLine(item);
                }

                SaveFile.Close();

        
        }
    }
}