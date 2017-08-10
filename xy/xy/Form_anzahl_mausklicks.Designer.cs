namespace xy
{
    partial class Form_anzahl_mausklicks
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_anzahl_mausklicks));
            this.tbAnzahlMouse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAnzahlKeyboard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAnzahlMouse
            // 
            this.tbAnzahlMouse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbAnzahlMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAnzahlMouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbAnzahlMouse.Enabled = false;
            this.tbAnzahlMouse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnzahlMouse.Location = new System.Drawing.Point(161, 74);
            this.tbAnzahlMouse.Name = "tbAnzahlMouse";
            this.tbAnzahlMouse.ReadOnly = true;
            this.tbAnzahlMouse.Size = new System.Drawing.Size(96, 22);
            this.tbAnzahlMouse.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.resetcounter);
            // 
            // tbAnzahlKeyboard
            // 
            this.tbAnzahlKeyboard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbAnzahlKeyboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAnzahlKeyboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbAnzahlKeyboard.Enabled = false;
            this.tbAnzahlKeyboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnzahlKeyboard.Location = new System.Drawing.Point(161, 51);
            this.tbAnzahlKeyboard.Name = "tbAnzahlKeyboard";
            this.tbAnzahlKeyboard.ReadOnly = true;
            this.tbAnzahlKeyboard.Size = new System.Drawing.Size(96, 22);
            this.tbAnzahlKeyboard.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tastaturanschläge:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mausklicks:";
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Enabled = false;
            this.tbDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.Location = new System.Drawing.Point(38, 139);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(219, 14);
            this.tbDate.TabIndex = 6;
            this.tbDate.Visible = false;
            // 
            // Form_anzahl_mausklicks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(308, 208);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAnzahlKeyboard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAnzahlMouse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_anzahl_mausklicks";
            this.Text = "Klickzahl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnzahlMouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAnzahlKeyboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDate;
    }
}

