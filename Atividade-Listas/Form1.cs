using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Listas
{
    public partial class Form1 : Form
    {
        List<Produto> lista = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            double valorVend = (double.Parse(PrecoAqui.Text) + (double.Parse(PrecoAqui.Text) * (double.Parse(PorcenVenda.Text) / 100)));
            ValorVenda.Text = valorVend.ToString();
            Produto produto = new Produto(Codigo.Text, Descricao.Text, Convert.ToDouble(PrecoAqui.Text), Convert.ToDouble(PorcenVenda.Text), Convert.ToDouble(ValorVenda.Text));
            ValorVenda.Text = valorVend.ToString("C2");
            lista.Add(produto);

            /* BindingSource Tabela = new BindingSource();
             Tabela.DataSource = lista;
             dgv.DataSource = Tabela;*/
            dgv.DataSource = null;
            dgv.Refresh();
            dgv.DataSource = lista;
        }
    }
}
