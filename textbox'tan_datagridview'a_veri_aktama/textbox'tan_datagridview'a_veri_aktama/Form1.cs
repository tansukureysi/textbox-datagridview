using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox_tan_datagridview_a_veri_aktama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("Kategori", typeof(string));
            tablo.Columns.Add("Adet", typeof(int));
            tablo.Columns.Add("Maliyet", typeof(double));
            dataGridView1.DataSource = tablo;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(text_id.Text, textkategori.Text, textadet.Text, textmaliyet.Text);
            dataGridView1.DataSource = tablo;
        }

       
    }
}
