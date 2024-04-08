namespace Aula5
{
    partial class frmCadProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cboUnidade = new System.Windows.Forms.ComboBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtPrateleira = new System.Windows.Forms.TextBox();
            this.lblPrateleira = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mskCodBarra = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 65);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 85);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(207, 20);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(87, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código de barras";
            // 
            // cboUnidade
            // 
            this.cboUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidade.FormattingEnabled = true;
            this.cboUnidade.Items.AddRange(new object[] {
            "UN",
            "PC",
            "KG",
            "ML",
            "LT"});
            this.cboUnidade.Location = new System.Drawing.Point(265, 85);
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(121, 21);
            this.cboUnidade.TabIndex = 3;
            this.cboUnidade.Validating += new System.ComponentModel.CancelEventHandler(this.cboUnidade_Validating);
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(265, 65);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(47, 13);
            this.lblUnidade.TabIndex = 5;
            this.lblUnidade.Text = "Unidade";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            "Bebidas",
            "Iogurtes",
            "Farinhas",
            "Congelados"});
            this.cboGrupo.Location = new System.Drawing.Point(15, 135);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(121, 21);
            this.cboGrupo.TabIndex = 4;
            this.cboGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.cboGrupo_Validating);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(12, 115);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 7;
            this.lblGrupo.Text = "Grupo";
            // 
            // txtPrateleira
            // 
            this.txtPrateleira.Location = new System.Drawing.Point(265, 135);
            this.txtPrateleira.Name = "txtPrateleira";
            this.txtPrateleira.Size = new System.Drawing.Size(47, 20);
            this.txtPrateleira.TabIndex = 5;
            // 
            // lblPrateleira
            // 
            this.lblPrateleira.AutoSize = true;
            this.lblPrateleira.Location = new System.Drawing.Point(265, 115);
            this.lblPrateleira.Name = "lblPrateleira";
            this.lblPrateleira.Size = new System.Drawing.Size(51, 13);
            this.lblPrateleira.TabIndex = 9;
            this.lblPrateleira.Text = "Prateleira";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(12, 165);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(83, 13);
            this.lblPrecoVenda.TabIndex = 10;
            this.lblPrecoVenda.Text = "Preço de venda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(245, 225);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // mskCodBarra
            // 
            this.mskCodBarra.Location = new System.Drawing.Point(15, 35);
            this.mskCodBarra.Mask = "9999999999999";
            this.mskCodBarra.Name = "mskCodBarra";
            this.mskCodBarra.Size = new System.Drawing.Size(84, 20);
            this.mskCodBarra.TabIndex = 1;
            this.mskCodBarra.Validating += new System.ComponentModel.CancelEventHandler(this.mskCodBarra_Validating);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(13, 185);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(86, 20);
            this.txtPrecoVenda.TabIndex = 6;
            this.txtPrecoVenda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecoVenda_Validating);
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 257);
            this.Controls.Add(this.mskCodBarra);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.lblPrateleira);
            this.Controls.Add(this.txtPrateleira);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.cboUnidade);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cboUnidade;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtPrateleira;
        private System.Windows.Forms.Label lblPrateleira;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.MaskedTextBox mskCodBarra;
        private System.Windows.Forms.TextBox txtPrecoVenda;
    }
}