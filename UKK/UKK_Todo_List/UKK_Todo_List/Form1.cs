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
    public partial class Form1: Form
    {
        Class1 class1 = new Class1();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGreen;
            panel2.BackColor = Color.LightSalmon;
            loadcard();
        }

        public void loadcard()
        {
            flowLayoutPanel1.Controls.Clear();
            string sql = "SELECT * FROM Tugas WHERE tanggal = '"+ monthCalendar1.SelectionStart.ToString("yyyy/MM/dd") + "' ORDER BY CASE prioritas WHEN 'Tinggi' THEN 1  WHEN 'Sedang' THEN 2  WHEN 'Rendah' THEN 3 END ASC";
           
            foreach(DataRow row in class1.getdata(sql).Rows)
            {
                Panel panel = new Panel()
                {
                    Size = new Size(500, 100),
                    AutoScroll = true,
                    BackColor = Color.LightSalmon,
                    
                };
                Label label = new Label()
                {
                    Text = "Nama Tugas: "+row["nama_tugas"].ToString(),
                    Size = new Size(400, 50),
                    FlatStyle = FlatStyle.Standard,
                    Location = new Point(3,10),
                    Font = new Font("Arial", 10)


                };
                Label label1 = new Label()
                {
                    Text = "Prioritas: " + row["prioritas"].ToString(),
                    Size = new Size(180, 30),
                    FlatStyle = FlatStyle.Standard,
                    Location = new Point(3, 30),
                    Font = new Font("Arial", 10),
                    
                };
                Button button = new Button()
                {
                    Text = "Delete",
                    Size = new Size(100, 30),
                    Location = new Point(380, 60),
                    FlatStyle = FlatStyle.Standard,
                    BackColor = Color.Red
                };
                button.Click += (sender, e) =>
                {
                    string sql1 = "DELETE FROM Tugas WHERE nama_tugas = '" + row["nama_tugas"].ToString() + "'";
                    class1.exc(sql1);
                    loadcard();
                };
                Button button1 = new Button
                {
                    Text = "Edit",
                    Size = new Size(100, 30),
                    Location = new Point(280, 60),
                    FlatStyle = FlatStyle.Standard,

                };

                button1.Click += (sender, e) =>
                {
                    Form2 form2 = new Form2();
                    form2.id = row["id"].ToString();
                    form2.textBox1.Text = row["nama_tugas"].ToString();
                    form2.comboBox1.Text = row["prioritas"].ToString();
                    form2.dateTimePicker1.Value = Convert.ToDateTime(row["tanggal"]);
                    form2.ShowDialog();
                };

                Button button2 = new Button()
                {
                    Text = "Selesai",
                    Size = new Size(100, 30),
                    Location = new Point(180, 60),
                    FlatStyle = FlatStyle.Standard,
                    BackColor = Color.Green
                };

                button2.Click += (sender, e) =>
                {
                    string sql1 = "UPDATE Tugas Set status = 'Selesai' WHERE nama_tugas = '"+ row["nama_tugas"] +"'";
                    class1.exc(sql1);
                    loadcard();
                };
            
                if (row["status"].ToString() == "Selesai")
                {
                    panel.BackColor = Color.LightGreen;
                }
                panel.Controls.Add(label1);
                panel.Controls.Add(button2);
                panel.Controls.Add(label);
                panel.Controls.Add(button1);
                panel.Controls.Add(button);
                flowLayoutPanel1.Controls.Add(panel);
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadcard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            loadcard();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
