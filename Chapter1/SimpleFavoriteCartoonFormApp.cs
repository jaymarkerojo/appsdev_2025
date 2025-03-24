namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cartoons = { "Alucard", "Gusion", "Cicilion", "Aamon", "Granger" };
            comboBox1.Items.AddRange(cartoons);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            switch (selectedCharacter)
            {
                case "Alucard":
                    pictureBox.Image = Image.FromFile(@"C:\Users\USER\Documents\images\Alucard.jpg");
                    break;
                case "Gusion":
                    pictureBox.Image = Image.FromFile(@"C:\Users\USER\Documents\images\Gusion.jpg");
                    break;
                case "Cicilion":
                    pictureBox.Image = Image.FromFile(@"C:\Users\USER\Documents\images\Cecilion.jpg");
                    break;
                case "Aamon":
                    pictureBox.Image = Image.FromFile(@"C:\Users\USER\Documents\images\Aamon.jpg");
                    break;
                case "Granger":
                    pictureBox.Image = Image.FromFile(@"C:\Users\USER\Documents\images\Granger.jpg");
                    break;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }
    }
}
