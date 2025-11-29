namespace Floresol_ADM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.textPsw = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(73, 38);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(70, 29);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.Visible = false;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Senha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Senha.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Senha.Location = new System.Drawing.Point(73, 231);
            this.Senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(106, 18);
            this.Senha.TabIndex = 10;
            this.Senha.Text = "Senha do usuário";
            this.Senha.Click += new System.EventHandler(this.label2_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Nome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nome.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nome.Location = new System.Drawing.Point(73, 129);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(101, 18);
            this.Nome.TabIndex = 9;
            this.Nome.Text = "None de usuário";
            // 
            // textPsw
            // 
            this.textPsw.Location = new System.Drawing.Point(73, 253);
            this.textPsw.Margin = new System.Windows.Forms.Padding(4);
            this.textPsw.Name = "textPsw";
            this.textPsw.Size = new System.Drawing.Size(361, 20);
            this.textPsw.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(73, 151);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(361, 20);
            this.textName.TabIndex = 7;
            this.textName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(482, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 466);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Entrar.ForeColor = System.Drawing.Color.White;
            this.Entrar.Location = new System.Drawing.Point(215, 329);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 11;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(994, 495);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.textPsw);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " Sistema de administação floresol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox textPsw;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Entrar;
    }
}

