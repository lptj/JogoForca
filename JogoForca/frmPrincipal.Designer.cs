namespace JogoForca
{
    partial class frmPrincipal
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
            this.rbtnNivel1 = new System.Windows.Forms.RadioButton();
            this.rbtnNivel2 = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDica = new System.Windows.Forms.Label();
            this.gpbJogoForca = new System.Windows.Forms.GroupBox();
            this.btnSortearNov = new System.Windows.Forms.Button();
            this.lblLetrasDigtadas = new System.Windows.Forms.Label();
            this.btnJogarNovamente = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChances = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPalavraSort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbJogoForca.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnNivel1
            // 
            this.rbtnNivel1.AutoSize = true;
            this.rbtnNivel1.Checked = true;
            this.rbtnNivel1.Location = new System.Drawing.Point(74, 90);
            this.rbtnNivel1.Name = "rbtnNivel1";
            this.rbtnNivel1.Size = new System.Drawing.Size(185, 17);
            this.rbtnNivel1.TabIndex = 4;
            this.rbtnNivel1.TabStop = true;
            this.rbtnNivel1.Text = "Nível 1 (10 chances para acertar)";
            this.rbtnNivel1.UseVisualStyleBackColor = true;
            // 
            // rbtnNivel2
            // 
            this.rbtnNivel2.AutoSize = true;
            this.rbtnNivel2.Location = new System.Drawing.Point(74, 113);
            this.rbtnNivel2.Name = "rbtnNivel2";
            this.rbtnNivel2.Size = new System.Drawing.Size(179, 17);
            this.rbtnNivel2.TabIndex = 5;
            this.rbtnNivel2.Text = "Nível 2 (5 chances para acertar)";
            this.rbtnNivel2.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(55, 137);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(226, 34);
            this.btnJogar.TabIndex = 6;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dica:";
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.Location = new System.Drawing.Point(56, 30);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(21, 13);
            this.lblDica.TabIndex = 8;
            this.lblDica.Text = "dc";
            this.lblDica.Visible = false;
            // 
            // gpbJogoForca
            // 
            this.gpbJogoForca.Controls.Add(this.btnSortearNov);
            this.gpbJogoForca.Controls.Add(this.lblLetrasDigtadas);
            this.gpbJogoForca.Controls.Add(this.btnJogarNovamente);
            this.gpbJogoForca.Controls.Add(this.txtLetra);
            this.gpbJogoForca.Controls.Add(this.btnOk);
            this.gpbJogoForca.Controls.Add(this.label3);
            this.gpbJogoForca.Controls.Add(this.lblChances);
            this.gpbJogoForca.Controls.Add(this.label18);
            this.gpbJogoForca.Controls.Add(this.lblDica);
            this.gpbJogoForca.Controls.Add(this.label2);
            this.gpbJogoForca.Controls.Add(this.lblPalavraSort);
            this.gpbJogoForca.Enabled = false;
            this.gpbJogoForca.Location = new System.Drawing.Point(12, 182);
            this.gpbJogoForca.Name = "gpbJogoForca";
            this.gpbJogoForca.Size = new System.Drawing.Size(324, 179);
            this.gpbJogoForca.TabIndex = 9;
            this.gpbJogoForca.TabStop = false;
            this.gpbJogoForca.Text = "Jogo Forca";
            // 
            // btnSortearNov
            // 
            this.btnSortearNov.Location = new System.Drawing.Point(27, 137);
            this.btnSortearNov.Name = "btnSortearNov";
            this.btnSortearNov.Size = new System.Drawing.Size(108, 23);
            this.btnSortearNov.TabIndex = 30;
            this.btnSortearNov.Text = "Sortear Palavra";
            this.btnSortearNov.UseVisualStyleBackColor = true;
            this.btnSortearNov.Click += new System.EventHandler(this.btnSortearNov_Click);
            // 
            // lblLetrasDigtadas
            // 
            this.lblLetrasDigtadas.AutoSize = true;
            this.lblLetrasDigtadas.Location = new System.Drawing.Point(158, 142);
            this.lblLetrasDigtadas.Name = "lblLetrasDigtadas";
            this.lblLetrasDigtadas.Size = new System.Drawing.Size(0, 13);
            this.lblLetrasDigtadas.TabIndex = 29;
            this.lblLetrasDigtadas.Visible = false;
            // 
            // btnJogarNovamente
            // 
            this.btnJogarNovamente.Enabled = false;
            this.btnJogarNovamente.Location = new System.Drawing.Point(161, 137);
            this.btnJogarNovamente.Name = "btnJogarNovamente";
            this.btnJogarNovamente.Size = new System.Drawing.Size(108, 23);
            this.btnJogarNovamente.TabIndex = 28;
            this.btnJogarNovamente.Text = "Jogar Novamente";
            this.btnJogarNovamente.UseVisualStyleBackColor = true;
            this.btnJogarNovamente.Click += new System.EventHandler(this.btnJogarNovamente_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(95, 59);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(34, 20);
            this.txtLetra.TabIndex = 27;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(146, 57);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(37, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Digite uma letra:";
            // 
            // lblChances
            // 
            this.lblChances.AutoSize = true;
            this.lblChances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChances.Location = new System.Drawing.Point(189, 30);
            this.lblChances.Name = "lblChances";
            this.lblChances.Size = new System.Drawing.Size(21, 13);
            this.lblChances.TabIndex = 25;
            this.lblChances.Text = "ch";
            this.lblChances.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(131, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Chances:";
            // 
            // lblPalavraSort
            // 
            this.lblPalavraSort.AutoSize = true;
            this.lblPalavraSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavraSort.Location = new System.Drawing.Point(6, 103);
            this.lblPalavraSort.Name = "lblPalavraSort";
            this.lblPalavraSort.Size = new System.Drawing.Size(19, 20);
            this.lblPalavraSort.TabIndex = 22;
            this.lblPalavraSort.Text = "_";
            this.lblPalavraSort.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jogo da Forca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Escolha um nível abaixo e clique no botão Joga para iniciar";
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.gpbJogoForca);
            this.Controls.Add(this.rbtnNivel2);
            this.Controls.Add(this.rbtnNivel1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.gpbJogoForca.ResumeLayout(false);
            this.gpbJogoForca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnNivel1;
        private System.Windows.Forms.RadioButton rbtnNivel2;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.GroupBox gpbJogoForca;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblChances;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPalavraSort;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnJogarNovamente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLetrasDigtadas;
        private System.Windows.Forms.Button btnSortearNov;
    }
}

