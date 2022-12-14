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
    public partial class Zak : Form
    {
        public Zak()
        {
            InitializeComponent();
            ShowIcon = false;
            load();
        }
        public void load()
        {
            dataGridView1.Rows.Clear();


            string q_load = "SELECT * FROM Zakaz  ";
            SqlConnection myCon = new SqlConnection(G_forms.connection);
            myCon.Open();

            SqlCommand command = new SqlCommand(q_load, myCon);


            SqlDataReader Reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (Reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = Reader[0].ToString();
                data[data.Count - 1][1] = Reader[1].ToString();
                data[data.Count - 1][2] = Reader[2].ToString();
                data[data.Count - 1][3] = Reader[3].ToString();
                data[data.Count - 1][4] = Reader[4].ToString();
                
            }

            Reader.Close();

            myCon.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void внестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new  Z_insert();
            f.Show();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G_forms.Text1 = string.Concat(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            G_forms.Text2 = string.Concat(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            G_forms.Text3 = string.Concat(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            G_forms.Text4 = string.Concat(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            G_forms.Text5 = string.Concat(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            Form f = new Z_edit();
            f.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string QueryDel = "DELETE FROM Zakaz WHERE ([Num_zakaz]=@p2)";
            SqlConnection myCon = new SqlConnection(connectionString: G_forms.connection);
            myCon.Open();

            SqlCommand command1 = new SqlCommand(QueryDel, myCon);
            string T = string.Concat(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            command1.Parameters.Add("@p2", T);


            command1.ExecuteReader();
            myCon.Close();
           

            load();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Clear();


            string QueryEdit = "SELECT * FROM Рейсы Where Num_zakaz like '%'+@FindOBJ+'%' or [W_shop_P] like '%'+@FindOBJ+'%' or  [Data_start] like '%'+@FindOBJ+'%' or  Data_end like '%'+@FindOBJ+'%' or  [Statys] like '%'+@FindOBJ+'%' ";
            SqlConnection myCon = new SqlConnection(G_forms.connection);
            myCon.Open();

            SqlCommand command = new SqlCommand(QueryEdit, myCon);

            SqlParameter obj = new SqlParameter("@FindOBJ", textBox1.Text);

            command.Parameters.Add(obj);
            SqlDataReader Reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (Reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = Reader[0].ToString();
                data[data.Count - 1][1] = Reader[1].ToString();
                data[data.Count - 1][2] = Reader[2].ToString();
                data[data.Count - 1][3] = Reader[3].ToString();
                data[data.Count - 1][4] = Reader[4].ToString();
              
            }

            Reader.Close();

            myCon.Close();
        }

        private void позицииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new Poz();
            f.Show();
        }

        private void целевыеХаркиМатериалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new T_char_steel();
            f.Show();
        }

        private void цехаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
