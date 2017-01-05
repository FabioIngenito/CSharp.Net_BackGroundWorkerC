namespace BackGroundWorkerC
{
    partial class frmBackGroundWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTeste = new System.Windows.Forms.DataGridView();
            this.btnTestarThreading = new System.Windows.Forms.Button();
            this.btnCarregarGrid = new System.Windows.Forms.Button();
            this.bwrTeste = new System.ComponentModel.BackgroundWorker();
            this.lblExplicacao1 = new System.Windows.Forms.Label();
            this.lblExplicacao2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeste
            // 
            this.dgvTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeste.Location = new System.Drawing.Point(12, 12);
            this.dgvTeste.Name = "dgvTeste";
            this.dgvTeste.Size = new System.Drawing.Size(340, 373);
            this.dgvTeste.TabIndex = 2;
            // 
            // btnTestarThreading
            // 
            this.btnTestarThreading.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTestarThreading.Location = new System.Drawing.Point(358, 340);
            this.btnTestarThreading.Name = "btnTestarThreading";
            this.btnTestarThreading.Size = new System.Drawing.Size(100, 45);
            this.btnTestarThreading.TabIndex = 1;
            this.btnTestarThreading.Text = "2 - &Testar Threading";
            this.btnTestarThreading.UseVisualStyleBackColor = true;
            this.btnTestarThreading.Click += new System.EventHandler(this.btnTestarThreading_Click);
            // 
            // btnCarregarGrid
            // 
            this.btnCarregarGrid.Location = new System.Drawing.Point(358, 74);
            this.btnCarregarGrid.Name = "btnCarregarGrid";
            this.btnCarregarGrid.Size = new System.Drawing.Size(100, 45);
            this.btnCarregarGrid.TabIndex = 0;
            this.btnCarregarGrid.Text = "1 - &Carregar Grid";
            this.btnCarregarGrid.UseVisualStyleBackColor = true;
            this.btnCarregarGrid.Click += new System.EventHandler(this.btnCarregarGrid_Click);
            // 
            // bwrTeste
            // 
            this.bwrTeste.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrTeste_DoWork);
            this.bwrTeste.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrTeste_RunWorkerCompleted);
            // 
            // lblExplicacao1
            // 
            this.lblExplicacao1.Location = new System.Drawing.Point(358, 12);
            this.lblExplicacao1.Name = "lblExplicacao1";
            this.lblExplicacao1.Size = new System.Drawing.Size(100, 59);
            this.lblExplicacao1.TabIndex = 3;
            this.lblExplicacao1.Text = "Clique no \"1\" primeiro (ele irá demorar para fazer o processamento)";
            // 
            // lblExplicacao2
            // 
            this.lblExplicacao2.Location = new System.Drawing.Point(358, 242);
            this.lblExplicacao2.Name = "lblExplicacao2";
            this.lblExplicacao2.Size = new System.Drawing.Size(100, 95);
            this.lblExplicacao2.TabIndex = 4;
            this.lblExplicacao2.Text = "Clique no \"2\" na sequência ao clicar o \"1\" (o botão fará o processamento sem espe" +
    "rar a resposta do botão \"1\"!";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(355, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 105);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clique no \"2\"  AGORA (Push button 2 NOW!) NÃO espere terminar o processamento. Do" +
    "n\'t wait the finish of process of 1!";
            // 
            // frmBackGroundWorker
            // 
            this.AcceptButton = this.btnTestarThreading;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTestarThreading;
            this.ClientSize = new System.Drawing.Size(470, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExplicacao2);
            this.Controls.Add(this.lblExplicacao1);
            this.Controls.Add(this.dgvTeste);
            this.Controls.Add(this.btnTestarThreading);
            this.Controls.Add(this.btnCarregarGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackGroundWorker";
            this.Text = "BackGround Worker C#";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvTeste;
        internal System.Windows.Forms.Button btnTestarThreading;
        internal System.Windows.Forms.Button btnCarregarGrid;
        private System.ComponentModel.BackgroundWorker bwrTeste;
        private System.Windows.Forms.Label lblExplicacao1;
        private System.Windows.Forms.Label lblExplicacao2;
        private System.Windows.Forms.Label label1;
    }
}

