namespace MegaDesk_3_RamonAndrade
{
    partial class SearchQuotes
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
            this.cancelSearchQuoteButton = new System.Windows.Forms.Button();
            this.buttonSendSearchQuote = new System.Windows.Forms.Button();
            this.logoSearchQuotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelSearchQuoteButton
            // 
            this.cancelSearchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchQuoteButton.Location = new System.Drawing.Point(598, 384);
            this.cancelSearchQuoteButton.Name = "cancelSearchQuoteButton";
            this.cancelSearchQuoteButton.Size = new System.Drawing.Size(190, 50);
            this.cancelSearchQuoteButton.TabIndex = 7;
            this.cancelSearchQuoteButton.Text = "Cancel";
            this.cancelSearchQuoteButton.UseVisualStyleBackColor = true;
            this.cancelSearchQuoteButton.Click += new System.EventHandler(this.cancelSearchQuoteButton_Click);
            // 
            // buttonSendSearchQuote
            // 
            this.buttonSendSearchQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendSearchQuote.Location = new System.Drawing.Point(598, 317);
            this.buttonSendSearchQuote.Name = "buttonSendSearchQuote";
            this.buttonSendSearchQuote.Size = new System.Drawing.Size(190, 50);
            this.buttonSendSearchQuote.TabIndex = 6;
            this.buttonSendSearchQuote.Text = "Search";
            this.buttonSendSearchQuote.UseVisualStyleBackColor = true;
            // 
            // logoSearchQuotes
            // 
            this.logoSearchQuotes.AutoSize = true;
            this.logoSearchQuotes.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.logoSearchQuotes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logoSearchQuotes.Location = new System.Drawing.Point(44, 9);
            this.logoSearchQuotes.Name = "logoSearchQuotes";
            this.logoSearchQuotes.Size = new System.Drawing.Size(211, 33);
            this.logoSearchQuotes.TabIndex = 25;
            this.logoSearchQuotes.Text = "Search Quotes";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoSearchQuotes);
            this.Controls.Add(this.cancelSearchQuoteButton);
            this.Controls.Add(this.buttonSendSearchQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelSearchQuoteButton;
        private System.Windows.Forms.Button buttonSendSearchQuote;
        private System.Windows.Forms.Label logoSearchQuotes;
    }
}