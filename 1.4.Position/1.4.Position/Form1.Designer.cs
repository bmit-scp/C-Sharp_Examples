namespace _1._4.Position
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
            this.Auto = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Auto
            // 
            this.Auto.BackgroundImage = global::_1._4.Position.Properties.Resources.autores;
            this.Auto.Location = new System.Drawing.Point(10, 10);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(481, 202);
            this.Auto.TabIndex = 0;
            this.Auto.Paint += new System.Windows.Forms.PaintEventHandler(this.Auto_Paint);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(432, 294);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(183, 76);
            this.right.TabIndex = 1;
            this.right.Text = "car right";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.button1_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(212, 294);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(190, 76);
            this.left.TabIndex = 2;
            this.left.Text = "car left";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 484);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.Auto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Auto;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
    }
}

