namespace CSC240_08_03_ManyButtons_PMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UxRedButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void UxWhiteButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UxBlueButton_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Blue;
        }
    }
}
