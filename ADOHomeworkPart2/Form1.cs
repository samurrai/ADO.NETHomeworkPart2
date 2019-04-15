using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOHomeworkPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ADOHomeworkPart2\ADOHomeworkPart2\DB.mdf;Integrated Security=True";
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.ConnectionString = connectionString;
            stringBuilder.UserID = textBox1.Text;
            stringBuilder.Password = textBox2.Text;
            using (var connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                MessageBox.Show("Connected");
            }
        }
    }
}
