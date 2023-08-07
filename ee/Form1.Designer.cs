namespace ee
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
            this.gradiente1 = new ee.gradiente();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alphaBlendTextBox2 = new ZBobb.AlphaBlendTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alphaBlendTextBox1 = new ZBobb.AlphaBlendTextBox();
            this.gradiente1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gradiente1
            // 
            this.gradiente1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.gradiente1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.gradiente1.Controls.Add(this.label3);
            this.gradiente1.Controls.Add(this.label2);
            this.gradiente1.Controls.Add(this.button1);
            this.gradiente1.Controls.Add(this.label1);
            this.gradiente1.Controls.Add(this.pictureBox3);
            this.gradiente1.Controls.Add(this.panel2);
            this.gradiente1.Controls.Add(this.alphaBlendTextBox2);
            this.gradiente1.Controls.Add(this.pictureBox2);
            this.gradiente1.Controls.Add(this.panel1);
            this.gradiente1.Controls.Add(this.alphaBlendTextBox1);
            this.gradiente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradiente1.Location = new System.Drawing.Point(0, 0);
            this.gradiente1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradiente1.Name = "gradiente1";
            this.gradiente1.Size = new System.Drawing.Size(613, 800);
            this.gradiente1.TabIndex = 0;
            this.gradiente1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradiente1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 56);
            this.label3.TabIndex = 11;
            this.label3.Text = "CONTROLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 56);
            this.label2.TabIndex = 10;
            this.label2.Text = "SISTEMA DE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(108)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(513, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 56);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ee.Properties.Resources.cadeado_seguro;
            this.pictureBox3.Location = new System.Drawing.Point(45, 469);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(51, 525);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 4);
            this.panel2.TabIndex = 6;
            // 
            // alphaBlendTextBox2
            // 
            this.alphaBlendTextBox2.BackAlpha = 0;
            this.alphaBlendTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.alphaBlendTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaBlendTextBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaBlendTextBox2.ForeColor = System.Drawing.Color.White;
            this.alphaBlendTextBox2.Location = new System.Drawing.Point(108, 480);
            this.alphaBlendTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.alphaBlendTextBox2.MaxLength = 30;
            this.alphaBlendTextBox2.Multiline = true;
            this.alphaBlendTextBox2.Name = "alphaBlendTextBox2";
            this.alphaBlendTextBox2.Size = new System.Drawing.Size(543, 46);
            this.alphaBlendTextBox2.TabIndex = 5;
            this.alphaBlendTextBox2.Text = "Senha";
            this.alphaBlendTextBox2.TextChanged += new System.EventHandler(this.alphaBlendTextBox2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ee.Properties.Resources.do_utilizador;
            this.pictureBox2.Location = new System.Drawing.Point(53, 339);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(51, 396);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 4);
            this.panel1.TabIndex = 3;
            // 
            // alphaBlendTextBox1
            // 
            this.alphaBlendTextBox1.BackAlpha = 0;
            this.alphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.alphaBlendTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alphaBlendTextBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaBlendTextBox1.ForeColor = System.Drawing.Color.White;
            this.alphaBlendTextBox1.Location = new System.Drawing.Point(108, 350);
            this.alphaBlendTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.alphaBlendTextBox1.MaxLength = 30;
            this.alphaBlendTextBox1.Multiline = true;
            this.alphaBlendTextBox1.Name = "alphaBlendTextBox1";
            this.alphaBlendTextBox1.Size = new System.Drawing.Size(543, 46);
            this.alphaBlendTextBox1.TabIndex = 2;
            this.alphaBlendTextBox1.Text = "Usuário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 800);
            this.Controls.Add(this.gradiente1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradiente1.ResumeLayout(false);
            this.gradiente1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private gradiente gradiente1;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private ZBobb.AlphaBlendTextBox alphaBlendTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

