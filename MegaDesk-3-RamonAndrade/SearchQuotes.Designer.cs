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
            this.searchCancel = new System.Windows.Forms.Button();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quoteList = new System.Windows.Forms.ListView();
            this.logoViewAllQuotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchCancel
            // 
            this.searchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCancel.Location = new System.Drawing.Point(582, 350);
            this.searchCancel.Name = "searchCancel";
            this.searchCancel.Size = new System.Drawing.Size(190, 50);
            this.searchCancel.TabIndex = 0;
            this.searchCancel.Text = "Main Menu";
            this.searchCancel.UseVisualStyleBackColor = true;
            this.searchCancel.Click += new System.EventHandler(this.searchCancel_Click);
            // 
            // materialBox
            // 
            this.materialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Location = new System.Drawing.Point(560, 24);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(212, 33);
            this.materialBox.TabIndex = 1;
            this.materialBox.SelectedIndexChanged += new System.EventHandler(this.materialBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(473, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // quoteList
            // 
            this.quoteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteList.Location = new System.Drawing.Point(12, 76);
            this.quoteList.Name = "quoteList";
            this.quoteList.Size = new System.Drawing.Size(760, 256);
            this.quoteList.TabIndex = 3;
            this.quoteList.UseCompatibleStateImageBehavior = false;
            this.quoteList.View = System.Windows.Forms.View.List;
            // 
            // logoViewAllQuotes
            // 
            this.logoViewAllQuotes.AutoSize = true;
            this.logoViewAllQuotes.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.logoViewAllQuotes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logoViewAllQuotes.Location = new System.Drawing.Point(37, 9);
            this.logoViewAllQuotes.Name = "logoViewAllQuotes";
            this.logoViewAllQuotes.Size = new System.Drawing.Size(211, 33);
            this.logoViewAllQuotes.TabIndex = 26;
            this.logoViewAllQuotes.Text = "Search Quotes";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.logoViewAllQuotes);
            this.Controls.Add(this.quoteList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.searchCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchCancel;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView quoteList;
        private System.Windows.Forms.Label logoViewAllQuotes;
    }
}