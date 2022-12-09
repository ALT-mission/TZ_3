namespace TZ_3
{
    partial class Poz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Num_poz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_zakaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target_char_steel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V_poz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_insert = new System.Windows.Forms.Button();
            this.P_del = new System.Windows.Forms.Button();
            this.P_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_poz,
            this.Num_zakaz,
            this.target_char_steel,
            this.V_poz,
            this.Unit_mes,
            this.Statys});
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(606, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(606, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Num_poz
            // 
            this.Num_poz.HeaderText = "№ позиции";
            this.Num_poz.Name = "Num_poz";
            this.Num_poz.ReadOnly = true;
            // 
            // Num_zakaz
            // 
            this.Num_zakaz.HeaderText = "№ заказа";
            this.Num_zakaz.Name = "Num_zakaz";
            this.Num_zakaz.ReadOnly = true;
            // 
            // target_char_steel
            // 
            this.target_char_steel.HeaderText = "Целевые хар.";
            this.target_char_steel.Name = "target_char_steel";
            this.target_char_steel.ReadOnly = true;
            // 
            // V_poz
            // 
            this.V_poz.HeaderText = "Объем позиции";
            this.V_poz.Name = "V_poz";
            this.V_poz.ReadOnly = true;
            // 
            // Unit_mes
            // 
            this.Unit_mes.HeaderText = "Единица измерения";
            this.Unit_mes.Name = "Unit_mes";
            this.Unit_mes.ReadOnly = true;
            // 
            // Statys
            // 
            this.Statys.HeaderText = "Статус";
            this.Statys.Name = "Statys";
            this.Statys.ReadOnly = true;
            // 
            // P_insert
            // 
            this.P_insert.Location = new System.Drawing.Point(12, 220);
            this.P_insert.Name = "P_insert";
            this.P_insert.Size = new System.Drawing.Size(75, 23);
            this.P_insert.TabIndex = 3;
            this.P_insert.Text = "Внести";
            this.P_insert.UseVisualStyleBackColor = true;
            this.P_insert.Click += new System.EventHandler(this.P_insert_Click);
            // 
            // P_del
            // 
            this.P_del.Location = new System.Drawing.Point(287, 220);
            this.P_del.Name = "P_del";
            this.P_del.Size = new System.Drawing.Size(75, 23);
            this.P_del.TabIndex = 4;
            this.P_del.Text = "Удалить";
            this.P_del.UseVisualStyleBackColor = true;
            this.P_del.Click += new System.EventHandler(this.P_del_Click);
            // 
            // P_edit
            // 
            this.P_edit.Location = new System.Drawing.Point(521, 220);
            this.P_edit.Name = "P_edit";
            this.P_edit.Size = new System.Drawing.Size(95, 23);
            this.P_edit.TabIndex = 5;
            this.P_edit.Text = "Редактировать";
            this.P_edit.UseVisualStyleBackColor = true;
            this.P_edit.Click += new System.EventHandler(this.P_edit_Click);
            // 
            // Poz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 255);
            this.Controls.Add(this.P_edit);
            this.Controls.Add(this.P_del);
            this.Controls.Add(this.P_insert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Poz";
            this.Text = "Позиции";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_poz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_zakaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn target_char_steel;
        private System.Windows.Forms.DataGridViewTextBoxColumn V_poz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statys;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button P_insert;
        private System.Windows.Forms.Button P_del;
        private System.Windows.Forms.Button P_edit;
    }
}