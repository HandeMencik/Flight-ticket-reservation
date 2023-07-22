namespace Ders_10_Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + "  Tarih: " + dateTimePicker1.Text + "  Saat: " + maskedTextBox1.Text + "  Yolcu bilgileri: ~  Ad: " + textBox1.Text + "  T.C: " + maskedTextBox2.Text + "  Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydý Yapýldý");

        }

    }
}
    