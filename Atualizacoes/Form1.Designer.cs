namespace Atualizacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.painelChats = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_Chat1 = new Atualizacoes.UserControls.UC_Chat();
            this.uC_Chat2 = new Atualizacoes.UserControls.UC_Chat();
            this.uC_Chat3 = new Atualizacoes.UserControls.UC_Chat();
            this.uC_Chat4 = new Atualizacoes.UserControls.UC_Chat();
            this.uC_Chat5 = new Atualizacoes.UserControls.UC_Chat();
            this.uC_Chat6 = new Atualizacoes.UserControls.UC_Chat();
            this.painelConteudo = new System.Windows.Forms.Panel();
            this.conteudoDescricao = new System.Windows.Forms.Label();
            this.tituloDescricao = new System.Windows.Forms.Label();
            this.imagemDescricao = new System.Windows.Forms.PictureBox();
            this.painelChats.SuspendLayout();
            this.painelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemDescricao)).BeginInit();
            this.SuspendLayout();
            // 
            // painelChats
            // 
            this.painelChats.Controls.Add(this.uC_Chat1);
            this.painelChats.Controls.Add(this.uC_Chat2);
            this.painelChats.Controls.Add(this.uC_Chat3);
            this.painelChats.Controls.Add(this.uC_Chat4);
            this.painelChats.Controls.Add(this.uC_Chat5);
            this.painelChats.Controls.Add(this.uC_Chat6);
            this.painelChats.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelChats.Location = new System.Drawing.Point(0, 0);
            this.painelChats.Name = "painelChats";
            this.painelChats.Size = new System.Drawing.Size(319, 569);
            this.painelChats.TabIndex = 15;
            // 
            // uC_Chat1
            // 
            this.uC_Chat1.BackColor = System.Drawing.Color.White;
            this.uC_Chat1.ConteudoChat = "Robert Lisboa enviou uma mensagem";
            this.painelChats.SetFlowBreak(this.uC_Chat1, true);
            this.uC_Chat1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.uC_Chat1.ImagemChat = global::Atualizacoes.Properties.Resources.teams;
            this.uC_Chat1.Location = new System.Drawing.Point(3, 3);
            this.uC_Chat1.Name = "uC_Chat1";
            this.uC_Chat1.Size = new System.Drawing.Size(313, 89);
            this.uC_Chat1.TabIndex = 1;
            this.uC_Chat1.TituloChat = "Microsoft Teams";
            // 
            // uC_Chat2
            // 
            this.uC_Chat2.BackColor = System.Drawing.Color.White;
            this.uC_Chat2.ConteudoChat = "[Github] A third-party OAuth application has been added to your account";
            this.painelChats.SetFlowBreak(this.uC_Chat2, true);
            this.uC_Chat2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.uC_Chat2.ImagemChat = global::Atualizacoes.Properties.Resources.github;
            this.uC_Chat2.Location = new System.Drawing.Point(3, 98);
            this.uC_Chat2.Name = "uC_Chat2";
            this.uC_Chat2.Size = new System.Drawing.Size(313, 89);
            this.uC_Chat2.TabIndex = 2;
            this.uC_Chat2.TituloChat = "Github";
            // 
            // uC_Chat3
            // 
            this.uC_Chat3.BackColor = System.Drawing.Color.White;
            this.uC_Chat3.ConteudoChat = "[Atribuição a você] CARD NOTIFICACÃO (ATUALIZAÇÃO SISTEMA)";
            this.painelChats.SetFlowBreak(this.uC_Chat3, true);
            this.uC_Chat3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.uC_Chat3.ImagemChat = global::Atualizacoes.Properties.Resources.monday;
            this.uC_Chat3.Location = new System.Drawing.Point(3, 193);
            this.uC_Chat3.Name = "uC_Chat3";
            this.uC_Chat3.Size = new System.Drawing.Size(313, 89);
            this.uC_Chat3.TabIndex = 3;
            this.uC_Chat3.TituloChat = "Monday";
            // 
            // uC_Chat4
            // 
            this.uC_Chat4.BackColor = System.Drawing.Color.White;
            this.uC_Chat4.ConteudoChat = "Bem-vindo a Alura!";
            this.painelChats.SetFlowBreak(this.uC_Chat4, true);
            this.uC_Chat4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.uC_Chat4.ImagemChat = global::Atualizacoes.Properties.Resources.alura;
            this.uC_Chat4.Location = new System.Drawing.Point(3, 288);
            this.uC_Chat4.Name = "uC_Chat4";
            this.uC_Chat4.Size = new System.Drawing.Size(313, 89);
            this.uC_Chat4.TabIndex = 4;
            this.uC_Chat4.TituloChat = "Alura";
            // 
            // uC_Chat5
            // 
            this.uC_Chat5.BackColor = System.Drawing.Color.White;
            this.uC_Chat5.ConteudoChat = "Bem-vindo ao Opera!";
            this.painelChats.SetFlowBreak(this.uC_Chat5, true);
            this.uC_Chat5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.uC_Chat5.ImagemChat = global::Atualizacoes.Properties.Resources.opera;
            this.uC_Chat5.Location = new System.Drawing.Point(3, 383);
            this.uC_Chat5.Name = "uC_Chat5";
            this.uC_Chat5.Size = new System.Drawing.Size(313, 89);
            this.uC_Chat5.TabIndex = 5;
            this.uC_Chat5.TituloChat = "Opera Software";
            // 
            // uC_Chat6
            // 
            this.uC_Chat6.BackColor = System.Drawing.Color.White;
            this.uC_Chat6.ConteudoChat = "Tenha o aplicativo oficial do Gmail";
            this.painelChats.SetFlowBreak(this.uC_Chat6, true);
            this.uC_Chat6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.uC_Chat6.ImagemChat = global::Atualizacoes.Properties.Resources.gmail;
            this.uC_Chat6.Location = new System.Drawing.Point(3, 478);
            this.uC_Chat6.Name = "uC_Chat6";
            this.uC_Chat6.Size = new System.Drawing.Size(313, 89);
            this.uC_Chat6.TabIndex = 6;
            this.uC_Chat6.TituloChat = "Equipe do Gmail";
            // 
            // painelConteudo
            // 
            this.painelConteudo.Controls.Add(this.conteudoDescricao);
            this.painelConteudo.Controls.Add(this.tituloDescricao);
            this.painelConteudo.Controls.Add(this.imagemDescricao);
            this.painelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelConteudo.Location = new System.Drawing.Point(319, 0);
            this.painelConteudo.Name = "painelConteudo";
            this.painelConteudo.Size = new System.Drawing.Size(557, 569);
            this.painelConteudo.TabIndex = 16;
            // 
            // conteudoDescricao
            // 
            this.conteudoDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conteudoDescricao.ForeColor = System.Drawing.Color.Black;
            this.conteudoDescricao.Location = new System.Drawing.Point(31, 325);
            this.conteudoDescricao.Name = "conteudoDescricao";
            this.conteudoDescricao.Size = new System.Drawing.Size(519, 88);
            this.conteudoDescricao.TabIndex = 12;
            this.conteudoDescricao.Text = "Desde 1987 atuamos no mercado internacional de autopeças, importamos e exportamos" +
    " produtos de altíssima qualidade para os mais renomados distribuidores do segmen" +
    "to automotivo no Brasil e no mundo.";
            this.conteudoDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tituloDescricao
            // 
            this.tituloDescricao.AutoSize = true;
            this.tituloDescricao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloDescricao.ForeColor = System.Drawing.Color.Black;
            this.tituloDescricao.Location = new System.Drawing.Point(127, 281);
            this.tituloDescricao.Name = "tituloDescricao";
            this.tituloDescricao.Size = new System.Drawing.Size(318, 23);
            this.tituloDescricao.TabIndex = 14;
            this.tituloDescricao.Text = "Seja Bem-Vindo a Polo Comércio";
            // 
            // imagemDescricao
            // 
            this.imagemDescricao.Image = ((System.Drawing.Image)(resources.GetObject("imagemDescricao.Image")));
            this.imagemDescricao.Location = new System.Drawing.Point(145, 56);
            this.imagemDescricao.Name = "imagemDescricao";
            this.imagemDescricao.Size = new System.Drawing.Size(284, 219);
            this.imagemDescricao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemDescricao.TabIndex = 13;
            this.imagemDescricao.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 569);
            this.Controls.Add(this.painelConteudo);
            this.Controls.Add(this.painelChats);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painelChats.ResumeLayout(false);
            this.painelConteudo.ResumeLayout(false);
            this.painelConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemDescricao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel painelChats;
        private UserControls.UC_Chat uC_Chat1;
        private UserControls.UC_Chat uC_Chat2;
        private UserControls.UC_Chat uC_Chat3;
        private UserControls.UC_Chat uC_Chat4;
        private UserControls.UC_Chat uC_Chat5;
        private UserControls.UC_Chat uC_Chat6;
        private System.Windows.Forms.Panel painelConteudo;
        private System.Windows.Forms.Label conteudoDescricao;
        private System.Windows.Forms.Label tituloDescricao;
        private System.Windows.Forms.PictureBox imagemDescricao;
    }
}

