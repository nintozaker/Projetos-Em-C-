  using JournalScreenControl.Navigation.Navigator;
using JournalScreenControl.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace JournalScreenControl.UI
{
    public partial class frmMain : Form
    {
        JournalService journalService = new JournalService();

        //*********  Ronaldo
        Graphics g; //*********  Ronaldo
        //define a largura e altura para serem iguais a da tela
        int TelaLargura = Screen.PrimaryScreen.Bounds.Width;
        int TelaAltura = Screen.PrimaryScreen.Bounds.Height;
        //********* //*********  Ronaldo

        public frmMain()
        {
            InitializeComponent();
            notifyIcon1.Icon = new Icon(@"..\..\Resources\active.ico");

            KeyboardListener.Listen();
            KeyboardListener.OnSpaceClick += InterceptClick;
        }
     
        private Navigator navigator = new Navigator();
         
        public void InterceptClick()   
         {
            Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width,
                           Screen.PrimaryScreen.WorkingArea.Height,
                           PixelFormat.Format32bppArgb);

            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.WorkingArea.X, Screen.PrimaryScreen.WorkingArea.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.WorkingArea.Size,
                                        CopyPixelOperation.SourceCopy);

            bmpScreenshot.Save("Screenshot.png", ImageFormat.Png);


            //  observar esta parte ( possivel salvamentod e arq.)  *****   cod Ronaldo  ****************
            //***************************
            //armazena a imagem no bitmap
            Bitmap b = new Bitmap(TelaLargura, TelaAltura);
            //copia  a tela no bitmap
            g = Graphics.FromImage(b);
            g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            //atribui a imagem ao picturebox exibindo-a
            picTela.Image = b;
            this.Show();
            //habilita o botão para salvar a tela
            //btnSalvarTela.Enabled = true;
            //encerra o timer
            //tmTela.Stop();

            //*******    *****
            //abre a janela de dialogo SaveDialog para salvar o arquivo gerado na captura
              DialogResult res = svdTela.ShowDialog();
            //*********  Ronaldo************************
            if (res == DialogResult.OK)
            { //*********  Ronaldo
                var journal4 = journalService.NextJournal();
                //obtem a extensão do arquivo salvo
                string ext = System.IO.Path.GetExtension(svdTela.FileName);
                if (ext == ".jpg")
                    picTela.Image.Save(journal4.Name, System.Drawing.Imaging.ImageFormat.Jpeg);
            } //*********  Ronaldo
            //************* R //*********  Ronaldo


            ThreadPool.QueueUserWorkItem(x =>  
             {
                var journal = journalService.NextJournal();
               
                navigator.Navigate(journal.Url);
            });
        }


        #region Visibility Control
        private bool allowVisible = true;
        private bool allowClose;

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }

            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                allowVisible = false;
                this.Hide();
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            allowVisible = true;
            Show();
        }

        #endregion

        private Mode mode = Mode.Pause;

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.mode == Mode.Pause)
            {
                this.mode = Mode.Active;

                var journal = journalService.NextJournal();

                navigator.Navigate(journal.Url);
            }
            else
            {
                this.mode = Mode.Pause;
            }
        }

        List<TreeNode> listTreeNodes = new List<TreeNode>();

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            this.FillTreeNodes();
        }

        private void FillTreeNodes()
        {
            for (int i = 0; i < 50; i++)
            {
                var journal = journalService.NextJournal();
                treeView1.Nodes.Add(journal.Name);

                treeView1.Nodes[i].Nodes.Add(journal.Sigla);
                //treeView1.Nodes[i].Nodes.Add("Caderno 2");
                //treeView1.Nodes[i].Nodes.Add("Caderno 3");
                //treeView1.Nodes[i].Nodes.Add("Caderno 4");
            }
        }

        private void RemoveCheckedNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    listTreeNodes.Add(node);
                }
                else
                {
                    RemoveCheckedNodes(node.Nodes);
                }
            }

            foreach (TreeNode checkdNode in listTreeNodes)
            {
                nodes.Remove(checkdNode);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
             
        }


       
    }

    public class JournalTreeNode : TreeNode
    {
        public string Url { get; set; }
    }

    public enum Mode
    {
        Active,

        Pause,
    }
}
