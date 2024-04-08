using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5
{
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();

            AutoValidate = AutoValidate.Disable;
        }

        bool IsNumber(string value)
        {
            if (value == "")
            {
                return false;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsDigit(value[i]))
                    return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o processo?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Registro salvo com sucesso.", "Informação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("É necessário o preenchimento de " +
                                "todos os campos obrigatórios.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {

                e.Cancel = true;
                errProvider.SetError(txtDescricao, "Preencha a descrição.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtDescricao, "");
            }
        }

        private void mskCodBarra_Validating(object sender, CancelEventArgs e)
        {
            string numero = "";

            foreach (char c in mskCodBarra.Text)
            {
                if (char.IsNumber(c))
                    numero += c;
            }

            if (string.IsNullOrEmpty(numero))
            {

                e.Cancel = true;
                errProvider.SetError(mskCodBarra, "Preencha o código.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(mskCodBarra, "");
            }

            if (string.IsNullOrEmpty(numero))
            {
                e.Cancel = true;
                errProvider.SetError(mskCodBarra, "Preencha o código.");
            }

            else if (numero.Length != 13)
            {
                e.Cancel = true;
                errProvider.SetError(mskCodBarra, "Preencha o código corretamente.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(mskCodBarra, "");
            }
        }

        private void cboUnidade_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboUnidade.Text))
            {
                e.Cancel = true;
                errProvider.SetError(cboUnidade, "Selecione a unidade.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(cboUnidade, "");
            }
        }

        private void cboGrupo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboGrupo.Text))
            {
                e.Cancel = true;
                errProvider.SetError(cboGrupo, "Selecione o grupo.");
         
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(cboGrupo, "");
            }
        }

        private void txtPrecoVenda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                e.Cancel = true;
                errProvider.SetError(txtPrecoVenda, "Preencha o preço.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtPrecoVenda, "");
            }

            if (IsNumber(txtPrecoVenda.Text))
            {
                e.Cancel = false;
                errProvider.SetError(txtPrecoVenda, "");
            }
            else
            {
                e.Cancel = true;
                errProvider.SetError(txtPrecoVenda, "Preencha com números.");
            }
        }
    }
}
