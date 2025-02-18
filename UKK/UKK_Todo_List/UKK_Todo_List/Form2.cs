using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKK_Todo_List
{
    public partial class Form2: Form
    {
        Class1 class1 = new Class1();
        public string id = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Silahkan Beri Nama Tugas Anda");
            }
            else
            {
                if(id == "")
                {
                    string sql = "INSERT INTO Tugas VALUES ('" + textBox1.Text + "','Belum Selesai' ,'" + comboBox1.Text + "' , '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "')";
                    class1.exc(sql);
                    MessageBox.Show("Tugas Berhasil Di Tambahkan");
                    textBox1.Clear();
                    comboBox1.Text = "";
                    Form1 form1 = new Form1();
                    form1.loadcard();

                }
                else
                {
                    string sql = "UPDATE Tugas SET nama_tugas = '" + textBox1.Text + "', status = 'Belum Selesai', prioritas = '" + comboBox1.Text + "', tanggal = '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' WHERE id = '"+ id +"'";
                    class1.exc(sql);
                    MessageBox.Show("Tugas Berhasil Di Ubah");
                    textBox1.Clear();
                    comboBox1.Text = "";
                    Form1 form1 = new Form1();
                    form1.loadcard();

                }

                

            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.Close();
           
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
