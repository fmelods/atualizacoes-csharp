namespace Atualizacoes.UserControls
{
    partial class UC_Chat
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Chat));
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPerfil
            // 
            this.imgPerfil.Image = ((System.Drawing.Image)(resources.GetObject("imgPerfil.Image")));
            this.imgPerfil.Location = new System.Drawing.Point(13, 14);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(53, 50);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 8;
            this.imgPerfil.TabStop = false;
            // 
            // lblConteudo
            // 
            this.lblConteudo.BackColor = System.Drawing.Color.White;
            this.lblConteudo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.ForeColor = System.Drawing.Color.Black;
            this.lblConteudo.Location = new System.Drawing.Point(86, 40);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(186, 39);
            this.lblConteudo.TabIndex = 7;
            this.lblConteudo.Text = "Conteúdo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(86, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Título";
            // 
            // UC_Chat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imgPerfil);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "UC_Chat";
            this.Size = new System.Drawing.Size(313, 89);
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
