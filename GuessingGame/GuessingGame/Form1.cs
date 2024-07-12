namespace GuessingGame
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form2 guessnext = new Form2();
            guessnext.Show();
            this.Hide();

        }
    }
}