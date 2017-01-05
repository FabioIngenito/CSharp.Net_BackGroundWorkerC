//http://imasters.com.br/artigo/5743/dotnet/trabalhando-com-backgroundworker/

using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BackGroundWorkerC
{
    public partial class frmBackGroundWorker : Form
    {
        DataTable MeuDataTable = new DataTable();

        public frmBackGroundWorker()
        {
            InitializeComponent();
        }

        private void PopularDataTable()
        {
            try
            {
                /*********************************************************
                'Iremos forçar que o nosso aplicativo demore
                'alguns segundos, especificaremos isso na
                'Threading atual, conforme a linha de código abaixo
                '********************************************************/
                System.Threading.Thread.Sleep(10000);

                int intCont;

                /*********************************************************
                'A estrutura de repetição seguir, servirá para
                'adicionarmos itens ao nosso DataTable
                '********************************************************/

                for (intCont = 0; intCont <= 2000; intCont++)
                {
                    DataRow dr;

                    /********************************************************
                    ' Verificando se a quantidade de coluna no datatable
                    ' é menor que 1, sendo será criada um coluna e adicionada
                    ' ao dataTable
                    '*******************************************************/
                    if (this.MeuDataTable.Columns.Count < 1)
                    {
                        DataColumn dc = new DataColumn();

                        dc.ColumnName = "id";

                        this.MeuDataTable.Columns.Add(dc);
                    }

                    /********************************************************
                    ' Criando uma nova Linha para o nosso datatable
                    '*******************************************************/
                    dr = this.MeuDataTable.NewRow();

                    dr[0] = intCont* 2000;

                    /********************************************************
                    ' Adicionando o linha ao DataTable
                    '*******************************************************/
                    this.MeuDataTable.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        ///  Esse evento será o responsável por executar os procedimentos em um nova thread. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwrTeste_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.PopularDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Esse evento só é disparado quando é finalizada a thread criada no evento DoWork.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwrTeste_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.dgvTeste.DataSource = this.MeuDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Nesse evento iremos dizer ao aplicativo que ele deverá iniciar o BackgroundWorker, 
        /// fazendo com que dispare o evento DoWork do componente BackgroundWorker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarregarGrid_Click(object sender, EventArgs e)
        {
            try
            {
                this.bwrTeste.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// O objetivo desse evento nesse contexto é apenas mostrar que mesmo o aplicativo 
        /// carregando o grid, você poderá deixar outra funcionalidades livres.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestarThreading_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Este botão está funcionando, mesmo com o outro ainda processando!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
