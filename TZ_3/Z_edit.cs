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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TZ_3
{
    public partial class Z_edit : Form
    {
        private int w_shop;

        public Z_edit()
        {
            InitializeComponent();
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
        
        private void b_insert_Click(object sender, EventArgs e)
        {
            ID_w_shop();
            string queryED = " UPDATE `Zakaz` SET  `W_shop_P` = ?, `Data_start` = ?, `Data_end` = ?, `Statys` = ? WHERE(`Num_zakaz` = ?)";
            SqlConnection myConnection = new SqlConnection(G_forms.connection);

            myConnection.Open();

            using (SqlCommand command = new SqlCommand(queryED, myConnection))
            {
                command.Parameters.Add("Param1", SqlDbType.Int).Value = comboBox1.Text;
                command.Parameters.Add("Param2", SqlDbType.Date).Value = dateTimePicker1.Text;
                command.Parameters.Add("Param3", SqlDbType.Date).Value = dateTimePicker2.Text;
                command.Parameters.Add("Param4", SqlDbType.Char).Value = comboBox2.Text;
                command.Parameters.Add("Param5", SqlDbType.Int).Value = G_forms.Text1;
                command.ExecuteNonQuery();
            }

            myConnection.Close();



           
        }
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
                w_shop = (int)reader[0];
            }
            reader.Close();


            myConnection.Open();

        }

        private void Z_edit_Load(object sender, EventArgs e)
        {
            
        }
    }
}
