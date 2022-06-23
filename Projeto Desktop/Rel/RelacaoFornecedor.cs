using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop.Rel
{
    public partial class RelacaoFornecedor : Form
    {
        public RelacaoFornecedor()
        {
            InitializeComponent();
        }

        private void RelacaoFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.cadfor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadforTableAdapter.Fill(this.dataSet1.cadfor);

            this.reportViewer1.RefreshReport();
        }
    }
}
