namespace MegaDesk_3_RamonAndrade
{
    partial class ViewAllQuotes
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
            this.cancelDisplayQuoteButton = new System.Windows.Forms.Button();
            this.logoViewAllQuotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelDisplayQuoteButton
            // 
            this.cancelDisplayQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelDisplayQuoteButton.Location = new System.Drawing.Point(598, 388);
            this.cancelDisplayQuoteButton.Name = "cancelDisplayQuoteButton";
            this.cancelDisplayQuoteButton.Size = new System.Drawing.Size(190, 50);
            this.cancelDisplayQuoteButton.TabIndex = 8;
            this.cancelDisplayQuoteButton.Text = "Main Menu";
            this.cancelDisplayQuoteButton.UseVisualStyleBackColor = true;
            this.cancelDisplayQuoteButton.Click += new System.EventHandler(this.cancelDisplayQuoteButton_Click);
            // 
            // logoViewAllQuotes
            // 
            this.logoViewAllQuotes.AutoSize = true;
            this.logoViewAllQuotes.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.logoViewAllQuotes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logoViewAllQuotes.Location = new System.Drawing.Point(39, 9);
            this.logoViewAllQuotes.Name = "logoViewAllQuotes";
            this.logoViewAllQuotes.Size = new System.Drawing.Size(227, 33);
            this.logoViewAllQuotes.TabIndex = 25;
            this.logoViewAllQuotes.Text = "View All Quotes";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoViewAllQuotes);
            this.Controls.Add(this.cancelDisplayQuoteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelDisplayQuoteButton;
        private System.Windows.Forms.Label logoViewAllQuotes;
    }
}