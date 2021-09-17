using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Botão clicado!");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Volte sempre");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste 1");
        }
    }
}
