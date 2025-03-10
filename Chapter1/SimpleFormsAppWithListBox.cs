namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string language = textBoxLanguage.Text.Trim();
            if (!string.IsNullOrEmpty(language))
            {
                listBoxLanguages.Items.Add(language);
                textBoxLanguage.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a programming language.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxLanguages.SelectedItem != null)
            {
                listBoxLanguages.Items.Remove(listBoxLanguages.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a programming language to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxLanguages.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLanguage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
