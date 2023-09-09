namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "sus?";
            label4.Text = "Activate this card then someone is acting awfully sus.";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "Give me money";
            label4.Text = "Once played, the opposing enemy must give 20 dollars.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "Rick Roll";
            label4.Text = "Play this when they least except it.";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "Roll Safe";
            label4.Text = "Cannot be played. You can't lose if you don't play.";
        }
    }
}