using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaProjeto;

namespace Camada_Apresentacao
{
    public partial class Selecao : Form
    {
        private Form CallingForm = null;
        public Selecao(Form callingForm) : this()
        {
            this.CallingForm = callingForm;
        }

        public Selecao()
        {
            InitializeComponent();
        }

        private void Selecao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.CallingForm != null)
                this.CallingForm.Show();
        }
        private void Selecao_Load(object sender, EventArgs e)
        {
            string[] items = {
            "Cliente",
            "Estoque",
            "Pedido",
            "Produto"
            };

            cbbSelecao.Items.AddRange(items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tela = cbbSelecao.SelectedItem.ToString();

            this.Hide();

            if (tela == "Cliente")
            {
                Form f2 = new Cliente(this);
                f2.Show();

            }
            else if(tela == "Estoque")
            {
                Form f2 = new Estoque(this);
                f2.Show();

            }
            else if(tela == "Pedido")
            {
                Form f2 = new Pedido(this);
                f2.Show();

            }
            else if (tela == "Produto")
            {
                Form f2 = new Produto(this);
                f2.Show();

            }
        }
    }
}
