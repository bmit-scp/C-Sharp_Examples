namespace _1._1.CopyButton
{
    partial class Form1
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
            this.lblPaste = new System.Windows.Forms.Label();
            this.boxCopy = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPaste
            // 
            this.lblPaste.AutoSize = true;
            this.lblPaste.Location = new System.Drawing.Point(271, 164);
            this.lblPaste.Name = "lblPaste";
            this.lblPaste.Size = new System.Drawing.Size(62, 25);
            this.lblPaste.TabIndex = 0;
            this.lblPaste.Text = "Paste";
            // 
            // boxCopy
            // 
            this.boxCopy.Location = new System.Drawing.Point(68, 164);
            this.boxCopy.Name = "boxCopy";
            this.boxCopy.Size = new System.Drawing.Size(157, 29);
            this.boxCopy.TabIndex = 1;
            this.boxCopy.Text = "Copy";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(149, 270);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(128, 54);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 394);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.boxCopy);
            this.Controls.Add(this.lblPaste);
            this.Name = "Form1";
            this.Text = "CopyButton";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPaste;
        private System.Windows.Forms.TextBox boxCopy;
        private System.Windows.Forms.Button btnCopy;
    }
}

