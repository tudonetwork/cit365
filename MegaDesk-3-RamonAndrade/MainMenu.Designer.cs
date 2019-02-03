namespace MegaDesk_3_RamonAndrade
{
    partial class MainMenu
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
            this.openAddQuoteButton = new System.Windows.Forms.Button();
            this.openViewQuoteButton = new System.Windows.Forms.Button();
            this.openSearchQuoteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logomegaDesk = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // openAddQuoteButton
            // 
            this.openAddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddQuoteButton.Location = new System.Drawing.Point(487, 73);
            this.openAddQuoteButton.Name = "openAddQuoteButton";
            this.openAddQuoteButton.Size = new System.Drawing.Size(250, 50);
            this.openAddQuoteButton.TabIndex = 0;
            this.openAddQuoteButton.Text = "Add New Quote";
            this.openAddQuoteButton.UseVisualStyleBackColor = true;
            this.openAddQuoteButton.Click += new System.EventHandler(this.openAddQuoteButton_Click);
            // 
            // openViewQuoteButton
            // 
            this.openViewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openViewQuoteButton.Location = new System.Drawing.Point(487, 155);
            this.openViewQuoteButton.Name = "openViewQuoteButton";
            this.openViewQuoteButton.Size = new System.Drawing.Size(250, 50);
            this.openViewQuoteButton.TabIndex = 1;
            this.openViewQuoteButton.Text = "View Quotes";
            this.openViewQuoteButton.UseVisualStyleBackColor = true;
            this.openViewQuoteButton.Click += new System.EventHandler(this.openViewQuoteButton_Click);
            // 
            // openSearchQuoteButton
            // 
            this.openSearchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSearchQuoteButton.Location = new System.Drawing.Point(487, 240);
            this.openSearchQuoteButton.Name = "openSearchQuoteButton";
            this.openSearchQuoteButton.Size = new System.Drawing.Size(250, 50);
            this.openSearchQuoteButton.TabIndex = 2;
            this.openSearchQuoteButton.Text = "Search Quotes";
            this.openSearchQuoteButton.UseVisualStyleBackColor = true;
            this.openSearchQuoteButton.Click += new System.EventHandler(this.openSearchQuoteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(487, 324);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(250, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logomegaDesk
            // 
            this.logomegaDesk.AutoSize = true;
            this.logomegaDesk.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logomegaDesk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logomegaDesk.Location = new System.Drawing.Point(48, 111);
            this.logomegaDesk.Name = "logomegaDesk";
            this.logomegaDesk.Size = new System.Drawing.Size(315, 48);
            this.logomegaDesk.TabIndex = 4;
            this.logomegaDesk.Text = "Mega Desk 1.1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(56, 191);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By Ramon Andrade";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.logomegaDesk);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openSearchQuoteButton);
            this.Controls.Add(this.openViewQuoteButton);
            this.Controls.Add(this.openAddQuoteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Desk - Ramon Andrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openAddQuoteButton;
        private System.Windows.Forms.Button openViewQuoteButton;
        private System.Windows.Forms.Button openSearchQuoteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label logomegaDesk;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

