namespace U3_1_Practica_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal = double.Parse(textBox1.Text);
            if (cal < 3.0) MessageBox.Show(" REPROBADO "); else MessageBox.Show("APROBADO");
        }
    }
}
