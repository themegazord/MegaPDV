using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class MenuPrincipal : Form
    {   

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor f = new Fornecedor();
            f.ShowDialog();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pais pa = new Pais();
            pa.AtualizaDGV();
            pa.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estados es = new Estados();
            es.AtualizaDGV();
            es.ShowDialog();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cidades c = new Cidades();
            c.AtualizaDGV();
            c.ShowDialog();
        }
    }
}
