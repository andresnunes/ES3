using Camada_Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaProjeto
{
    public partial class Produto : Form
    {
        private Form CallingForm = null;
        public Produto(Form callingForm) : this()
        {
            this.CallingForm = callingForm;
        }

        public Produto()
        {
            InitializeComponent();
        }

        private void Produto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.CallingForm != null)
                this.CallingForm.Show();
        }


        private void btnVoltaSel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Selecao(this);
            f1.Show();
        }
    }
}
