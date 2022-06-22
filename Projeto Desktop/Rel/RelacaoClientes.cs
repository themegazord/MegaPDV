using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Desktop;
using System.Windows.Forms;

namespace Projeto_Desktop.Rel
{
    public partial class RelacaoClientes : Form
    {
        public RelacaoClientes()
        {
            InitializeComponent();
        }

        private void RelacaoClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.cadcli'. Você pode movê-la ou removê-la conforme necessário.
            this.cadcliTableAdapter.Fill(this.dataSet1.cadcli);

            this.reportViewer1.RefreshReport();
        }
    }
}
