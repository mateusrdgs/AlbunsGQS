namespace Albuns
{
    partial class fmAlbuns
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
            this.gbAlbuns = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbGravadora = new System.Windows.Forms.TextBox();
            this.mtbAno = new System.Windows.Forms.MaskedTextBox();
            this.tbArtista = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbGravadora = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbArtista = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgvAlbuns = new System.Windows.Forms.DataGridView();
            this.lbFaixas = new System.Windows.Forms.Label();
            this.mtbFaixas = new System.Windows.Forms.MaskedTextBox();
            this.clTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clArtista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGravadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFaixas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAlbuns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbuns)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlbuns
            // 
            this.gbAlbuns.Controls.Add(this.mtbFaixas);
            this.gbAlbuns.Controls.Add(this.lbFaixas);
            this.gbAlbuns.Controls.Add(this.btLimpar);
            this.gbAlbuns.Controls.Add(this.btSalvar);
            this.gbAlbuns.Controls.Add(this.tbGenero);
            this.gbAlbuns.Controls.Add(this.tbGravadora);
            this.gbAlbuns.Controls.Add(this.mtbAno);
            this.gbAlbuns.Controls.Add(this.tbArtista);
            this.gbAlbuns.Controls.Add(this.tbTitulo);
            this.gbAlbuns.Controls.Add(this.lbGenero);
            this.gbAlbuns.Controls.Add(this.lbGravadora);
            this.gbAlbuns.Controls.Add(this.lbAno);
            this.gbAlbuns.Controls.Add(this.lbArtista);
            this.gbAlbuns.Controls.Add(this.lbTitulo);
            this.gbAlbuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlbuns.Location = new System.Drawing.Point(13, 13);
            this.gbAlbuns.Name = "gbAlbuns";
            this.gbAlbuns.Size = new System.Drawing.Size(300, 362);
            this.gbAlbuns.TabIndex = 0;
            this.gbAlbuns.TabStop = false;
            this.gbAlbuns.Text = "Cadastrar novo album";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(7, 332);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(219, 333);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(90, 199);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(204, 22);
            this.tbGenero.TabIndex = 4;
            // 
            // tbGravadora
            // 
            this.tbGravadora.Location = new System.Drawing.Point(90, 145);
            this.tbGravadora.Name = "tbGravadora";
            this.tbGravadora.Size = new System.Drawing.Size(204, 22);
            this.tbGravadora.TabIndex = 3;
            // 
            // mtbAno
            // 
            this.mtbAno.Location = new System.Drawing.Point(257, 257);
            this.mtbAno.Mask = "0000";
            this.mtbAno.Name = "mtbAno";
            this.mtbAno.Size = new System.Drawing.Size(37, 22);
            this.mtbAno.TabIndex = 6;
            // 
            // tbArtista
            // 
            this.tbArtista.Location = new System.Drawing.Point(53, 85);
            this.tbArtista.Name = "tbArtista";
            this.tbArtista.Size = new System.Drawing.Size(241, 22);
            this.tbArtista.TabIndex = 2;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(53, 35);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(241, 22);
            this.tbTitulo.TabIndex = 1;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(6, 202);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(53, 16);
            this.lbGenero.TabIndex = 4;
            this.lbGenero.Text = "Gênero";
            // 
            // lbGravadora
            // 
            this.lbGravadora.AutoSize = true;
            this.lbGravadora.Location = new System.Drawing.Point(6, 148);
            this.lbGravadora.Name = "lbGravadora";
            this.lbGravadora.Size = new System.Drawing.Size(73, 16);
            this.lbGravadora.TabIndex = 3;
            this.lbGravadora.Text = "Gravadora";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(173, 247);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(78, 32);
            this.lbAno.TabIndex = 2;
            this.lbAno.Text = "Ano de\r\nlançamento";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.Location = new System.Drawing.Point(6, 88);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(45, 16);
            this.lbArtista.TabIndex = 1;
            this.lbArtista.Text = "Artista";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(6, 38);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(41, 16);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Título";
            // 
            // dgvAlbuns
            // 
            this.dgvAlbuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTitulo,
            this.clArtista,
            this.clGravadora,
            this.clGenero,
            this.clFaixas,
            this.clAno});
            this.dgvAlbuns.Location = new System.Drawing.Point(319, 12);
            this.dgvAlbuns.Name = "dgvAlbuns";
            this.dgvAlbuns.Size = new System.Drawing.Size(643, 363);
            this.dgvAlbuns.TabIndex = 1;
            // 
            // lbFaixas
            // 
            this.lbFaixas.AutoSize = true;
            this.lbFaixas.Location = new System.Drawing.Point(6, 247);
            this.lbFaixas.Name = "lbFaixas";
            this.lbFaixas.Size = new System.Drawing.Size(62, 32);
            this.lbFaixas.TabIndex = 8;
            this.lbFaixas.Text = "Número\r\nde faixas";
            // 
            // mtbFaixas
            // 
            this.mtbFaixas.Location = new System.Drawing.Point(74, 257);
            this.mtbFaixas.Mask = "00";
            this.mtbFaixas.Name = "mtbFaixas";
            this.mtbFaixas.Size = new System.Drawing.Size(24, 22);
            this.mtbFaixas.TabIndex = 5;
            // 
            // clTitulo
            // 
            this.clTitulo.HeaderText = "Título";
            this.clTitulo.Name = "clTitulo";
            this.clTitulo.ReadOnly = true;
            // 
            // clArtista
            // 
            this.clArtista.HeaderText = "Artista";
            this.clArtista.Name = "clArtista";
            this.clArtista.ReadOnly = true;
            // 
            // clGravadora
            // 
            this.clGravadora.HeaderText = "Gravadora";
            this.clGravadora.Name = "clGravadora";
            this.clGravadora.ReadOnly = true;
            // 
            // clGenero
            // 
            this.clGenero.HeaderText = "Gênero";
            this.clGenero.Name = "clGenero";
            this.clGenero.ReadOnly = true;
            // 
            // clFaixas
            // 
            this.clFaixas.HeaderText = "Faixas";
            this.clFaixas.Name = "clFaixas";
            this.clFaixas.ReadOnly = true;
            // 
            // clAno
            // 
            this.clAno.HeaderText = "Ano de lançamento";
            this.clAno.Name = "clAno";
            this.clAno.ReadOnly = true;
            // 
            // fmAlbuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 384);
            this.Controls.Add(this.dgvAlbuns);
            this.Controls.Add(this.gbAlbuns);
            this.Name = "fmAlbuns";
            this.Text = "Cadastrar";
            this.gbAlbuns.ResumeLayout(false);
            this.gbAlbuns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbuns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlbuns;
        private System.Windows.Forms.DataGridView dgvAlbuns;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbGravadora;
        private System.Windows.Forms.MaskedTextBox mtbAno;
        private System.Windows.Forms.TextBox tbArtista;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbGravadora;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.MaskedTextBox mtbFaixas;
        private System.Windows.Forms.Label lbFaixas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clArtista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGravadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFaixas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAno;
    }
}

