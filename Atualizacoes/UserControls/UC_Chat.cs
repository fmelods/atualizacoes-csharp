using System;
using System.Drawing;
using System.Windows.Forms;

namespace Atualizacoes.UserControls
{
    public partial class UC_Chat : UserControl
    {
        public UC_Chat()
        {
            InitializeComponent();
            this.Click += UC_Chat_Click;
            foreach (Control control in this.Controls)
            {
                control.Click += UC_Chat_Click;
            }
        }

        private void UC_Chat_Click(object sender, EventArgs e)
        {
            ChatClicado?.Invoke(this, e);
        }

        public string TituloChat
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string ConteudoChat
        {
            get { return lblConteudo.Text; }
            set { lblConteudo.Text = value; }
        }

        public Image ImagemChat
        {
            get { return imgPerfil.Image; }
            set { imgPerfil.Image = value; }
        }

        public event EventHandler ChatClicado;
    }
}
