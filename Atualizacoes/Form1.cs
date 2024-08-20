//VERSÃO 3: CÓDIGO PARA GERAR CONTROLES ATRAVÉS DE UM DATASET
using Atualizacoes.Properties;
using Atualizacoes.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Atualizacoes
{
    public partial class Form1 : Form
    {
        private readonly DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
            try
            {
                dataSet = new DataSet();
                CarregarDataset();
                IniciarChats();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na inicialização do formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                painelChats.AutoScroll = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao configurar a barra de rolagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IniciarChats()
        {
            try
            {
                // Inicializando com 6 controles predefinidos
                List<UC_Chat> chats = new List<UC_Chat>
                {
                    uC_Chat1,
                    uC_Chat2,
                    uC_Chat3,
                    uC_Chat4,
                    uC_Chat5,
                    uC_Chat6
                };

                foreach (var chat in chats)
                {
                    chat.ChatClicado += Chat_ChatClicado;
                    painelChats.Controls.Add(chat);
                }

                AdicionarChatsDoDataset();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar os 6 controles predefinidos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDataset()
        {
            try
            {
                DataTable tabelaChats = new DataTable();
                tabelaChats.Columns.Add("Titulo");
                tabelaChats.Columns.Add("Conteudo");

                for (int i = 1; i <= 340; i++) // Não gera mais que 340 controles (346 linhas)
                {
                    DataRow row = tabelaChats.NewRow();
                    row["Titulo"] = "Chat " + (6 + i); // Os primeiros 6 são os predefinidos
                    row["Conteudo"] = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Número aleatório: " + i;
                    tabelaChats.Rows.Add(row);
                }

                dataSet.Tables.Add(tabelaChats);

                if (tabelaChats.Rows.Count > 0)
                {

                    MessageBox.Show($"Primeira linha - Titulo: {tabelaChats.Rows[0]["Titulo"]}, Conteudo: {tabelaChats.Rows[0]["Conteudo"]}");
                }
                if (dataSet.Tables.Contains("Chats"))
                {
                    DataTable tabela = dataSet.Tables["Chats"];
                    MessageBox.Show($"Número de linhas na tabela: {tabela.Rows.Count}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dataset: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarChatsDoDataset()
        {
            try
            {
                if (dataSet.Tables.Count > 0)
                {
                    DataTable tabelaChats = dataSet.Tables[0];
                    MessageBox.Show($"Número de linhas na tabela: {tabelaChats.Rows.Count}");

                    painelChats.SuspendLayout();
                    painelChats.PerformLayout();

                    foreach (DataRow row in tabelaChats.Rows)
                    {

                        UC_Chat novoChat = new UC_Chat
                        {
                            TituloChat = row["Titulo"].ToString(),
                            ConteudoChat = row["Conteudo"].ToString(),
                        };

                        novoChat.ChatClicado += Chat_ChatClicado;

                        painelChats.Controls.Add(novoChat);
                        painelChats.SetFlowBreak(novoChat, true);
                    }

                    painelChats.FlowDirection = FlowDirection.TopDown;
                    painelChats.WrapContents = false;
                    painelChats.ResumeLayout(false);
                }
                else
                {
                    MessageBox.Show("Nenhuma tabela encontrada no DataSet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar chats/cards do dataset: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Chat_ChatClicado(object sender, EventArgs e)
        {
            try
            {
                if (sender is UC_Chat chatSelecionado)
                {
                    ExibirConteudoCompleto(chatSelecionado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao clicar no chat/card: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExibirConteudoCompleto(UC_Chat chat)
        {
            try
            {
                imagemDescricao.Image = chat.ImagemChat;
                tituloDescricao.Text = chat.TituloChat;
                conteudoDescricao.Text = chat.ConteudoChat;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exibir conteúdo completo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

//VERSÃO 2: CÓDIGO PARA GERAR BOTÕES AO INVÉS DE CONTROLES
//sing Atualizacoes.Properties;
//sing Atualizacoes.UserControls;
//sing System;
//sing System.Collections.Generic;
//sing System.Data;
//sing System.Drawing;
//sing System.Windows.Forms;
//
//amespace Atualizacoes
//
//   public partial class Form1 : Form
//   {
//       private readonly DataSet dataSet;
//
//       public Form1()
//       {
//           InitializeComponent();
//           try
//           {
//               dataSet = new DataSet();
//               CarregarDataset();
//               IniciarChats();
//           }
//           catch (Exception ex)
//           {
//               MessageBox.Show($"Erro na inicialização do formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//           }
//       }
//
//       private void Form1_Load(object sender, EventArgs e)
//       {
//           try
//           {
//               painelChats.AutoScroll = true;
//           }
//           catch (Exception ex)
//           {
//               MessageBox.Show($"Erro ao configurar a barra de rolagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//           }
//       }
//
//       private void IniciarChats()
//       {
//           try
//           {
//               // Inicializando com 6 chats predefinidos
//               List<UC_Chat> chats = new List<UC_Chat>
//               {
//                   uC_Chat1,
//                   uC_Chat2,
//                   uC_Chat3,
//                   uC_Chat4,
//                   uC_Chat5,
//                   uC_Chat6
//               };
//
//               foreach (var chat in chats)
//               {
//                   painelChats.Controls.Add(chat);
//               }
//
//               AdicionarChatsDoDataset();
//           }
//           catch (Exception ex)
//           {
//               MessageBox.Show($"Erro ao iniciar os 6 controles predefinidos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//           }
//       }
//
//       private void CarregarDataset()
//       {
//           try
//           {
//               DataTable tabelaChats = new DataTable();
//               tabelaChats.Columns.Add("Titulo");
//               tabelaChats.Columns.Add("Conteudo");
//
//               for (int i = 1; i <= 1728; i++) // Não gera mais que 1728 controles (1734 linhas)
//               {
//                   DataRow row = tabelaChats.NewRow();
//                   row["Titulo"] = "Chat " + (6 + i); // Os primeiros 6 são os predefinidos
//                   row["Conteudo"] = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Número aleatório: " + i;
//                   tabelaChats.Rows.Add(row);
//               }
//
//               dataSet.Tables.Add(tabelaChats);
//           }
//           catch (Exception ex)
//           {
//               MessageBox.Show($"Erro ao carregar dataset: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//           }
//       }
//
//       private void AdicionarChatsDoDataset()
//       {
//           try
//           {
//               DataTable tabelaChats = dataSet.Tables[0];
//
//               painelChats.SuspendLayout();
//
//               foreach (DataRow row in tabelaChats.Rows)
//               {
//                   Button novoBotao = new Button
//                   {
//                       Text = row["Titulo"].ToString(),
//                       Height = 50,
//                       Tag = row["Conteudo"].ToString()
//                   };
//
//                   novoBotao.Click += Botao_Click;
//
//                   painelChats.Controls.Add(novoBotao);
//               }
//
//               painelChats.ResumeLayout(false);
//           }
//           catch (Exception ex)
//           {
//               MessageBox.Show($"Erro ao adicionar chats/cards do dataset: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//           }
//       }
//
//       private void Botao_Click(object sender, EventArgs e)
//       {
//           try
//           {
//               if (sender is Button botaoSelecionado)
//               {
//                   ExibirConteudoCompleto(botaoSelecionado.Text, botaoSelecionado.Tag.ToString());
//               }
//           }
//           catch (Exception ex)
//           {
//               MessageBox.Show($"Erro ao clicar no botão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//           }
//       }
//
//       private void ExibirConteudoCompleto(string titulo, string conteudo)
//       {
//           try
//           {
//               tituloDescricao.Text = titulo;
//               conteudoDescricao.Text = conteudo;
//           }
//           catch (Exception ex)
//           {
//               MessageBox.Show($"Erro ao exibir conteúdo completo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//           }
//       }
//   }
//

//VERSÃO 1: CÓDIGO PARA GERAR CONTROLES AO CLICAR EM UM BOTÃO
//using Atualizacoes.Properties;
//using Atualizacoes.UserControls;
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Windows.Forms;
//
//namespace Atualizacoes
//{
//    public partial class Form1 : Form
//    {
//        private int numeroDeChats;
//        private readonly List<UC_Chat> listaDeChats;
//
//        public Form1()
//        {
//            InitializeComponent();
//            numeroDeChats = 6;
//            listaDeChats = new List<UC_Chat>();
//            IniciarChats();
//        }
//
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            botaoNovo.Click += BotaoNovo_Click;
//            painelChats.AutoScroll = true;
//        }
//
//        private void IniciarChats()
//        {
//            // Inicializando com 6 chats predefinidos
//            List<UC_Chat> chats = new List<UC_Chat>
//            {
//                uC_Chat1,
//                uC_Chat2,
//                uC_Chat3,
//                uC_Chat4,
//                uC_Chat5,
//                uC_Chat6
//            };
//
//            foreach (var chat in chats)
//            {
//                chat.ChatClicado += Chat_ChatClicado;
//                painelChats.Controls.Add(chat);
//                listaDeChats.Add(chat);
//            }
//        }
//
//        private void BotaoNovo_Click(object sender, EventArgs e)
//        {
//            Random random = new Random();
//            int numeroAleatorio = random.Next(1, 101);
//            string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
//
//            UC_Chat novoChat = new UC_Chat
//            {
//                TituloChat = "Chat " + (numeroDeChats + 1),
//                ConteudoChat = loremIpsum + " Número aleatório: " + numeroAleatorio
//            };
//
//            novoChat.ChatClicado += Chat_ChatClicado;
//
//            painelChats.Controls.Add(novoChat);
//            listaDeChats.Add(novoChat);
//
//            PosicionarChats();
//            numeroDeChats++;
//        }
//
//        private void PosicionarChats()
//        {
//            for (int i = 0; i < listaDeChats.Count; i++)
//            {
//                listaDeChats[i].Location = new Point(0, i * 100);
//            }
//
//            painelChats.AutoScrollMinSize = new Size(0, listaDeChats.Count * 100);
//        }
//
//        private void Chat_ChatClicado(object sender, EventArgs e)
//        {
//            if (sender is UC_Chat chatSelecionado)
//            {
//                ExibirConteudoCompleto(chatSelecionado);
//            }
//        }
//
//        private void ExibirConteudoCompleto(UC_Chat chat)
//        {
//            imagemDescricao.Image = chat.ImagemChat;
//            tituloDescricao.Text = chat.TituloChat;
//            conteudoDescricao.Text = chat.ConteudoChat;
//        }
//    }
//}
