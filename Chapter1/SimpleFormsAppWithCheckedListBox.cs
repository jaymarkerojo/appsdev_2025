namespace SimpleFormsAppWithCheckedListBox
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (var item in clbMovies.CheckedItems)
            {
                if (!sMovies.Items.Contains(item))
                {
                    sMovies.Items.Add(item);
                }
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (sMovies.SelectedItem != null)
            {
                sMovies.Items.Remove(sMovies.SelectedItem);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            sMovies.Items.Clear();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

