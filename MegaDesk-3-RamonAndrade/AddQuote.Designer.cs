namespace MegaDesk_3_RamonAndrade
{
    partial class AddQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonSendAddQuote = new System.Windows.Forms.Button();
            this.cancelAddQuoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surfaceInput = new System.Windows.Forms.ComboBox();
            this.drawersInput = new System.Windows.Forms.ComboBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.rushInput = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.logomegaDesk = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSendAddQuote
            // 
            this.buttonSendAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendAddQuote.Location = new System.Drawing.Point(598, 321);
            this.buttonSendAddQuote.Name = "buttonSendAddQuote";
            this.buttonSendAddQuote.Size = new System.Drawing.Size(190, 50);
            this.buttonSendAddQuote.TabIndex = 4;
            this.buttonSendAddQuote.Text = "Add Quote";
            this.buttonSendAddQuote.UseVisualStyleBackColor = true;
            this.buttonSendAddQuote.Click += new System.EventHandler(this.buttonSendAddQuote_Click);
            // 
            // cancelAddQuoteButton
            // 
            this.cancelAddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddQuoteButton.Location = new System.Drawing.Point(598, 388);
            this.cancelAddQuoteButton.Name = "cancelAddQuoteButton";
            this.cancelAddQuoteButton.Size = new System.Drawing.Size(190, 50);
            this.cancelAddQuoteButton.TabIndex = 5;
            this.cancelAddQuoteButton.Text = "Cancel";
            this.cancelAddQuoteButton.UseVisualStyleBackColor = true;
            this.cancelAddQuoteButton.Click += new System.EventHandler(this.cancelAddQuoteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(45, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Name";
            // 
            // customerInput
            // 
            this.customerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInput.Location = new System.Drawing.Point(274, 86);
            this.customerInput.Name = "customerInput";
            this.customerInput.Size = new System.Drawing.Size(380, 32);
            this.customerInput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(45, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size of desk (Width)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(45, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Size of desk (Depth)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(45, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(45, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Surface material";
            // 
            // surfaceInput
            // 
            this.surfaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceInput.FormattingEnabled = true;
            this.surfaceInput.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceInput.Location = new System.Drawing.Point(274, 301);
            this.surfaceInput.Name = "surfaceInput";
            this.surfaceInput.Size = new System.Drawing.Size(238, 33);
            this.surfaceInput.TabIndex = 18;
            // 
            // drawersInput
            // 
            this.drawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersInput.FormattingEnabled = true;
            this.drawersInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawersInput.Location = new System.Drawing.Point(274, 247);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(238, 33);
            this.drawersInput.TabIndex = 19;
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.Location = new System.Drawing.Point(274, 139);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(238, 32);
            this.widthInput.TabIndex = 20;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validated);
            this.widthInput.Validated += new System.EventHandler(this.widthInput_Validating);
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthInput.Location = new System.Drawing.Point(274, 193);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(238, 32);
            this.depthInput.TabIndex = 21;
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.depthInput_Validated);
            this.depthInput.Validated += new System.EventHandler(this.depthInput_Validating);

            // 
            // rushInput
            // 
            this.rushInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushInput.FormattingEnabled = true;
            this.rushInput.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushInput.Location = new System.Drawing.Point(274, 354);
            this.rushInput.Name = "rushInput";
            this.rushInput.Size = new System.Drawing.Size(238, 33);
            this.rushInput.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(45, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rush order";
            // 
            // logomegaDesk
            // 
            this.logomegaDesk.AutoSize = true;
            this.logomegaDesk.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.logomegaDesk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logomegaDesk.Location = new System.Drawing.Point(44, 9);
            this.logomegaDesk.Name = "logomegaDesk";
            this.logomegaDesk.Size = new System.Drawing.Size(157, 33);
            this.logomegaDesk.TabIndex = 24;
            this.logomegaDesk.Text = "Add Quote";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // AddQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logomegaDesk);
            this.Controls.Add(this.rushInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.surfaceInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelAddQuoteButton);
            this.Controls.Add(this.buttonSendAddQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQuoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Desk - Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendAddQuote;
        private System.Windows.Forms.Button cancelAddQuoteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox surfaceInput;
        private System.Windows.Forms.ComboBox drawersInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.ComboBox rushInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label logomegaDesk;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}