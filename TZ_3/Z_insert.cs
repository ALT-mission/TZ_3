using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TZ_3
{
    public partial class Z_insert : Form
    {
        public Z_insert()
        {
            InitializeComponent();
          
        }
        public int w_shop;
        private void ID_w_shop()
        {
            SqlConnection myConnection = new SqlConnection(G_forms.connection);
            string query_W = "SELECT ID_w_shop  FROM W_shop where Name_w_shop like '%'+@FindOBJ+'%'";
            myConnection.Open();

            SqlCommand command_w = new SqlCommand(query_W, myConnection);

            SqlParameter obj = new SqlParameter("@FindOBJ", comboBox1.Text);

            command_w.Parameters.Add(obj);

            SqlDataReader reader = command_w.ExecuteReader();
            
            while (reader.Read())
            {
                w_shop=(int)reader[0];
            }
            reader.Close();


            myConnection.Open();
            
        }
        private void b_insert_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(G_forms.connection);
            string query_Add = "INSERT INTO `Zakaz` (`W_shop_P`, `Data_start`, `Data_end`, `Statys`) VALUES ( ?, ?, ?, ?)";

            ID_w_shop();

            using (SqlCommand command = new SqlCommand(query_Add, myConnection))
            {
                command.Parameters.Add("Param1", SqlDbType.Int).Value = w_shop;
                command.Parameters.Add("Param2", SqlDbType.Date).Value = dateTimePicker1.Text;
                command.Parameters.Add("Param3", SqlDbType.Date).Value = dateTimePicker2.Text;
                command.Parameters.Add("Param4", SqlDbType.Char).Value = comboBox2.Text;
                
                command.ExecuteNonQuery();

            }
            myConnection.Close();



           
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Z_insert_Load(object sender, EventArgs e)
        {
            string query = "SELECT Name_w_shop  FROM W_shop";
            SqlConnection myConnection = new SqlConnection(G_forms.connection);


            myConnection.Open();

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();

        }
    }
}
