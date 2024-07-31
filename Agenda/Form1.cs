using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Comando quando o usuario clica no leao
        private void pictureBox1_Click(object sender, EventArgs e)
        {       //messagebox.show é para abrir uma caixa de aviso, na primeira "" segue a mensagem, na segunda "" o nome da caixa
            MessageBox.Show("Agenda do Leãozinho 1.0\nDesenvolvido por Rafael Santana", "Informação!");
        }

        private void pESSOASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pESSOASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDB1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaDB1DataSet.PESSOAS'. Você pode movê-la ou removê-la conforme necessário.
            this.pESSOASTableAdapter.Fill(this.agendaDB1DataSet.PESSOAS);

        }
    }
}
