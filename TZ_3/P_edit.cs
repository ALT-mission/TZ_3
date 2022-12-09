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
    public partial class P_edit : Form
    {
        public P_edit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void P_edit_Load(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(G_forms.connection);
            string query_W = "SELECT Num_zakaz  FROM Poz ";
            myConnection.Open();

            SqlCommand command_w = new SqlCommand(query_W, myConnection);

            SqlDataReader reader = command_w.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            reader.Close();


            myConnection.Open();


            textBox1.Text = G_forms.Text1;
            comboBox1.Text = G_forms.Text2;
            textBox2.Text = G_forms.Text3;
            textBox3.Text = G_forms.Text4;
            textBox4.Text = G_forms.Text5;
            comboBox2.Text = G_forms.Text6;
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            string queryED = " UPDATE `Poz` SET  `Num_poz` = ?, `Num_zakaz` = ?, `target_char_steel` = ?, `V_poz` = ?, `Unit_mes` = ?, `Statys` = ? WHERE(`Num_poz` = ?) and (`Num_zakaz` = ?)";
            SqlConnection myConnection = new SqlConnection(G_forms.connection);

            myConnection.Open();

            using (SqlCommand command = new SqlCommand(queryED, myConnection))
            {
                command.Parameters.Add("Param1", SqlDbType.Int).Value = textBox1.Text;
                command.Parameters.Add("Param2", SqlDbType.Int).Value = comboBox1.Text;
                command.Parameters.Add("Param3", SqlDbType.Int).Value = textBox2.Text;
                command.Parameters.Add("Param4", SqlDbType.Int).Value = textBox3.Text;
                command.Parameters.Add("Param5", SqlDbType.Char).Value = textBox4.Text;
                command.Parameters.Add("Param6", SqlDbType.Char).Value = comboBox2.Text;
                command.Parameters.Add("Param7", SqlDbType.Int).Value = G_forms.Text1;
                command.Parameters.Add("Param8", SqlDbType.Int).Value = G_forms.Text2;
                command.ExecuteNonQuery();
            }

            myConnection.Close();




        }
    }
}
