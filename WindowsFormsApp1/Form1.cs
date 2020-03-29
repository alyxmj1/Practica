using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //кнопка войти
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=НАСТЯ-ПК\SQLEXPRESS;Initial Catalog=Fabrika;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Пользователи where Логин = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Пожалуйста, убедитесь в корректности вводимых данных и попробуйте снова.");

            }
        }
    }
    }
