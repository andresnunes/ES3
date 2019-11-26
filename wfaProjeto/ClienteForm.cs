using Camada_Apresentacao;
using Camada_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaProjeto
{
    public partial class Cliente : Form


    {
        private Form CallingForm = null;
        public Cliente(Form callingForm) : this()
        {
            this.CallingForm = callingForm;
        }

        public Cliente()
        {
            InitializeComponent();
        }
        private void Cliente_Load(object sender, EventArgs e)
        {
            CamadaNegocios Cli = new CamadaNegocios();
            DataSet ds = new DataSet();
            ds = Cli.ExibirDados("Cliente");
            dtgCliente.DataSource = ds.Tables[0];

        }
        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            CamadaNegocios Cliente = new CamadaNegocios();

            DataSet dtg = new DataSet();

            dtg = Cliente.ExibirDados("Cliente");
            
            dtgCliente.DataSource = dtg.Tables[0];
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            BancoCliente cli = new BancoCliente();
            _ = cli.InserirCliente(txtNomeCliente.Text.ToString(), mskCpf.Text.ToString(), "", txtEmailCliente.Text.ToString(), "", mskTelefone.Text.ToString(), txtEndereco.Text.ToString(), txtBairro.Text.ToString(), txtCidade.Text.ToString(), txtEstado.Text.ToString(), txtComplemento.Text.ToString(), txtNumero.Text.ToString());

            CamadaNegocios Cli = new CamadaNegocios();
            DataSet ds = new DataSet();
            ds = Cli.ExibirDados("Cliente");
            dtgCliente.DataSource = ds.Tables[0];
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            BancoCliente cli = new BancoCliente();
            _ = cli.AlterarCliente(txtNomeCliente.Text.ToString(), mskCpf.Text.ToString(), "", txtEmailCliente.Text.ToString(), "", mskTelefone.Text.ToString(), txtEndereco.Text.ToString(), txtBairro.Text.ToString(), txtCidade.Text.ToString(), txtEstado.Text.ToString(), txtComplemento.Text.ToString(), txtNumero.Text.ToString());

            CamadaNegocios Cli = new CamadaNegocios();
            DataSet ds = new DataSet();
            ds = Cli.ExibirDados("Cliente");
            dtgCliente.DataSource = ds.Tables[0];
        }
    }
}
