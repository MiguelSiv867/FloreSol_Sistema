namespace Floresol_ADM
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.estoque = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.delivery = new System.Windows.Forms.DataGridView();
            this.IDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(937, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Estoque e Delivery";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // estoque
            // 
            this.estoque.AllowUserToAddRows = false;
            this.estoque.AllowUserToDeleteRows = false;
            this.estoque.BackgroundColor = System.Drawing.Color.LightGray;
            this.estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estoque.Location = new System.Drawing.Point(12, 64);
            this.estoque.Name = "estoque";
            this.estoque.ReadOnly = true;
            this.estoque.Size = new System.Drawing.Size(442, 330);
            this.estoque.TabIndex = 8;
            this.estoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.estoque_CellContentClick);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(843, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delivery
            // 
            this.delivery.AllowUserToAddRows = false;
            this.delivery.AllowUserToDeleteRows = false;
            this.delivery.BackgroundColor = System.Drawing.Color.LightGray;
            this.delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delivery.Location = new System.Drawing.Point(476, 64);
            this.delivery.Name = "delivery";
            this.delivery.ReadOnly = true;
            this.delivery.Size = new System.Drawing.Size(442, 330);
            this.delivery.TabIndex = 20;
            this.delivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.delivery_CellContentClick);
            // 
            // IDP
            // 
            this.IDP.Location = new System.Drawing.Point(107, 418);
            this.IDP.Name = "IDP";
            this.IDP.Size = new System.Drawing.Size(100, 20);
            this.IDP.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(213, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Código rastreio:";
            // 
            // CR
            // 
            this.CR.Location = new System.Drawing.Point(354, 418);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(100, 20);
            this.CR.TabIndex = 24;
            this.CR.TextChanged += new System.EventHandler(this.CR_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(476, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Enviar código ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(756, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 21);
            this.button3.TabIndex = 26;
            this.button3.Text = "atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDP);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.estoque);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Sistema de administação floresol";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView estoque;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView delivery;
        private System.Windows.Forms.TextBox IDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}
