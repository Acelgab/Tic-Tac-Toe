namespace Assignment01_MARGALLO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong","Hmm",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope", "Haha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong", "Aww", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please try again", "err", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am Acel Gabrielle P. Margallo", "Hola! Bonjour!,Konnichiwa!", MessageBoxButtons.OK);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}