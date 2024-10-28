using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace versao01
{
    public partial class ConfigurarCarnesForm : Form
    {
        private Pedidos _pedidos; // Campo para armazenar a referência

        public ConfigurarCarnesForm(Pedidos pedidos)
        {
            InitializeComponent();
            _pedidos = pedidos; // Armazena a referência do formulário principal
        }

        public ConfigurarCarnesForm()
        {
            InitializeComponent();
        }

        private void ConfigurarCarnesForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_AdicionarCarnes_Click(object sender, EventArgs e)
        {
            // Adiciona as carnes
            if (tb_Campo_add_carnes.Text != "")
            {
                checkedListBox1.Items.Add(tb_Campo_add_carnes.Text);
                tb_Campo_add_carnes.Clear();
                tb_Campo_add_carnes.Focus();
            }
        }

        private void btn_LimparOpcoes_Click(object sender, EventArgs e)
        {
            // Apaga todas as opções de carne do checked
            checkedListBox1.Items.Clear();
        }

        private void btn_ResetarCarnes_Click(object sender, EventArgs e)
        {
            // reseta as configurações das carnes para o padrão
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("Boi");
            checkedListBox1.Items.Add("Frango");
            checkedListBox1.Items.Add("Porco");
            checkedListBox1.Items.Add("Ovo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_LimparOpcoes.Visible = true;
        }
    }
}
