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

namespace TZ_3
{
    public partial class P_insert : Form
    {
        public P_insert()
        {
            InitializeComponent();
        }
        private void combo_load()
        {
            SqlConnection myConnection = new SqlConnection(G_forms.connection);
            string query_W = "SELECT Num_zakaz  FROM Poz where statys not like 'Выполнена'";
            myConnection.Open();

            SqlCommand command_w = new SqlCommand(query_W, myConnection);

            SqlDataReader reader = command_w.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            reader.Close();


            myConnection.Open();


        }
        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_insert_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(G_forms.connection);
            string query_Add = "INSERT INTO `Poz` (`Num_poz`, `Num_zakaz`, `target_char_steel`, `V_poz`, `Unit_mes`, `Statys`) VALUES ( ?, ?, ?, ?, ?, ?)";

            combo_load();

           

            using (SqlCommand command = new SqlCommand(query_Add, myConnection))
            {
                command.Parameters.Add("Param1", SqlDbType.Int).Value = textBox1.Text;
                command.Parameters.Add("Param2", SqlDbType.Int).Value = comboBox1.Text;
                command.Parameters.Add("Param3", SqlDbType.Int).Value = textBox2.Text;
                command.Parameters.Add("Param4", SqlDbType.Char).Value = textBox3.Text;
                command.Parameters.Add("Param5", SqlDbType.Char).Value = textBox4.Text;
                command.Parameters.Add("Param6", SqlDbType.Char).Value = comboBox2.Text;

                command.ExecuteNonQuery();

            }
            myConnection.Close();


        }
    }
}
