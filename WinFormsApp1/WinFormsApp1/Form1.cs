namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            bool isNumeric = int.TryParse(textBox1.Text, out _);
            if (isNumeric)
            {
                MessageBox.Show("Ви ввели число: " + textBox1.Text);
            }
            /*else
            {
                MessageBox.Show("Ви ввели *НЕ*число:" + textBox1.Text);
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}