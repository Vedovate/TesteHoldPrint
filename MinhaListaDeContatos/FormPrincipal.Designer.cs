namespace MinhaListaDeContatos
{
    partial class FormPrincipal
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
            this.gvListaContatos = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListaContatos
            // 
            this.gvListaContatos.AllowUserToAddRows = false;
            this.gvListaContatos.AllowUserToDeleteRows = false;
            this.gvListaContatos.AllowUserToResizeRows = false;
            this.gvListaContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvListaContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvListaContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaContatos.Location = new System.Drawing.Point(13, 13);
            this.gvListaContatos.MultiSelect = false;
            this.gvListaContatos.Name = "gvListaContatos";
            this.gvListaContatos.ReadOnly = true;
            this.gvListaContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListaContatos.ShowEditingIcon = false;
            this.gvListaContatos.Size = new System.Drawing.Size(775, 359);
            this.gvListaContatos.TabIndex = 0;
            this.gvListaContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListaContatos_CellClick);
            this.gvListaContatos.SelectionChanged += new System.EventHandler(this.gvListaContatos_SelectionChanged);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCadastrar.Location = new System.Drawing.Point(627, 378);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(161, 60);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "Cadastrar Contato";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletar.Location = new System.Drawing.Point(13, 378);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(115, 60);
            this.btDeletar.TabIndex = 2;
            this.btDeletar.Text = "Deletar Contato Selecionado";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(335, 378);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(109, 60);
            this.btAtualizar.TabIndex = 3;
            this.btAtualizar.Text = "Atualizar Dados";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(168, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Atualizar Contato Selecionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEmail
            // 
            this.btEmail.Location = new System.Drawing.Point(483, 378);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(109, 60);
            this.btEmail.TabIndex = 5;
            this.btEmail.Text = "Enviar Contato Selecionado Por Email";
            this.btEmail.UseVisualStyleBackColor = true;
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.gvListaContatos);
            this.Name = "FormPrincipal";
            this.Text = "Minha Lista de Contatos";
            this.Activated += new System.EventHandler(this.FormPrincipal_Activated);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListaContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListaContatos;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btEmail;
    }
}

