namespace Atividade_Listas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.PrecoAqui = new System.Windows.Forms.TextBox();
            this.PorcenVenda = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.ValorVenda = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.novoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço de aquisição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Porcentagem de venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor de venda:";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(105, 15);
            this.Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(124, 27);
            this.Codigo.TabIndex = 6;
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(114, 50);
            this.Descricao.Margin = new System.Windows.Forms.Padding(4);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(242, 27);
            this.Descricao.TabIndex = 7;
            // 
            // PrecoAqui
            // 
            this.PrecoAqui.Location = new System.Drawing.Point(180, 85);
            this.PrecoAqui.Margin = new System.Windows.Forms.Padding(4);
            this.PrecoAqui.Name = "PrecoAqui";
            this.PrecoAqui.Size = new System.Drawing.Size(159, 27);
            this.PrecoAqui.TabIndex = 8;
            // 
            // PorcenVenda
            // 
            this.PorcenVenda.Location = new System.Drawing.Point(208, 120);
            this.PorcenVenda.Margin = new System.Windows.Forms.Padding(4);
            this.PorcenVenda.Name = "PorcenVenda";
            this.PorcenVenda.Size = new System.Drawing.Size(124, 27);
            this.PorcenVenda.TabIndex = 9;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(323, 244);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(136, 74);
            this.BtnCadastrar.TabIndex = 11;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(179, 244);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(136, 74);
            this.BtnExcluir.TabIndex = 12;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // ValorVenda
            // 
            this.ValorVenda.Location = new System.Drawing.Point(148, 155);
            this.ValorVenda.Margin = new System.Windows.Forms.Padding(4);
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            this.ValorVenda.Size = new System.Drawing.Size(124, 27);
            this.ValorVenda.TabIndex = 14;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(19, 369);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(682, 204);
            this.dgv.TabIndex = 15;
            // 
            // novoBtn
            // 
            this.novoBtn.Location = new System.Drawing.Point(35, 244);
            this.novoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.novoBtn.Name = "novoBtn";
            this.novoBtn.Size = new System.Drawing.Size(136, 74);
            this.novoBtn.TabIndex = 16;
            this.novoBtn.Text = "Novo";
            this.novoBtn.UseVisualStyleBackColor = true;
            this.novoBtn.Click += new System.EventHandler(this.novoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 645);
            this.Controls.Add(this.novoBtn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ValorVenda);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.PorcenVenda);
            this.Controls.Add(this.PrecoAqui);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Descricao;
        private System.Windows.Forms.TextBox PrecoAqui;
        private System.Windows.Forms.TextBox PorcenVenda;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox ValorVenda;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button novoBtn;
    }
}

