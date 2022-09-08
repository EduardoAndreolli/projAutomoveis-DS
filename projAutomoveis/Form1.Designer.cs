namespace projAutomoveis
{
    partial class frmmenu
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
            this.btncaminhao = new System.Windows.Forms.Button();
            this.btncarro = new System.Windows.Forms.Button();
            this.lblcabecalho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncaminhao
            // 
            this.btncaminhao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncaminhao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaminhao.Location = new System.Drawing.Point(143, 475);
            this.btncaminhao.Name = "btncaminhao";
            this.btncaminhao.Size = new System.Drawing.Size(321, 134);
            this.btncaminhao.TabIndex = 0;
            this.btncaminhao.Text = "Caminhão";
            this.btncaminhao.UseVisualStyleBackColor = false;
            this.btncaminhao.Click += new System.EventHandler(this.btncaminhao_Click);
            // 
            // btncarro
            // 
            this.btncarro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncarro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btncarro.Location = new System.Drawing.Point(856, 475);
            this.btncarro.Name = "btncarro";
            this.btncarro.Size = new System.Drawing.Size(320, 134);
            this.btncarro.TabIndex = 1;
            this.btncarro.Text = "Carro";
            this.btncarro.UseVisualStyleBackColor = false;
            this.btncarro.Click += new System.EventHandler(this.btncarro_Click);
            // 
            // lblcabecalho
            // 
            this.lblcabecalho.AutoSize = true;
            this.lblcabecalho.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcabecalho.Location = new System.Drawing.Point(505, 186);
            this.lblcabecalho.Name = "lblcabecalho";
            this.lblcabecalho.Size = new System.Drawing.Size(322, 68);
            this.lblcabecalho.TabIndex = 2;
            this.lblcabecalho.Text = "TOYFORD";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1342, 741);
            this.Controls.Add(this.lblcabecalho);
            this.Controls.Add(this.btncarro);
            this.Controls.Add(this.btncaminhao);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncaminhao;
        private System.Windows.Forms.Button btncarro;
        private System.Windows.Forms.Label lblcabecalho;
    }
}