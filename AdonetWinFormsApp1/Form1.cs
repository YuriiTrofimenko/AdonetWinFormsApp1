using AdonetWinFormsApp1Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdonetWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Repo.AddData();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Repo.GetDataTable();
        }
    }
}
