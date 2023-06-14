namespace ProvaORM___Exercicio1
{
    partial class TelaEstacionamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.Clientetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Modelotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Placatxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cadastrarbtn = new System.Windows.Forms.Button();
            this.Salvarbtn = new System.Windows.Forms.Button();
            this.Atualizarbtn = new System.Windows.Forms.Button();
            this.Excluirbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // Idtxt
            // 
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(198, 27);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(100, 26);
            this.Idtxt.TabIndex = 1;
            // 
            // Clientetxt
            // 
            this.Clientetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientetxt.Location = new System.Drawing.Point(198, 84);
            this.Clientetxt.Name = "Clientetxt";
            this.Clientetxt.Size = new System.Drawing.Size(231, 26);
            this.Clientetxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Cliente";
            // 
            // Modelotxt
            // 
            this.Modelotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modelotxt.Location = new System.Drawing.Point(198, 144);
            this.Modelotxt.Name = "Modelotxt";
            this.Modelotxt.Size = new System.Drawing.Size(231, 26);
            this.Modelotxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo do Veículo";
            // 
            // Placatxt
            // 
            this.Placatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placatxt.Location = new System.Drawing.Point(198, 203);
            this.Placatxt.Name = "Placatxt";
            this.Placatxt.Size = new System.Drawing.Size(231, 26);
            this.Placatxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Placa do Veículo";
            // 
            // Cadastrarbtn
            // 
            this.Cadastrarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrarbtn.Location = new System.Drawing.Point(613, 15);
            this.Cadastrarbtn.Name = "Cadastrarbtn";
            this.Cadastrarbtn.Size = new System.Drawing.Size(98, 38);
            this.Cadastrarbtn.TabIndex = 8;
            this.Cadastrarbtn.Text = "Cadastrar";
            this.Cadastrarbtn.UseVisualStyleBackColor = true;
            this.Cadastrarbtn.Click += new System.EventHandler(this.Cadastrarbtn_Click);
            // 
            // Salvarbtn
            // 
            this.Salvarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvarbtn.Location = new System.Drawing.Point(613, 132);
            this.Salvarbtn.Name = "Salvarbtn";
            this.Salvarbtn.Size = new System.Drawing.Size(98, 38);
            this.Salvarbtn.TabIndex = 9;
            this.Salvarbtn.Text = "Salvar";
            this.Salvarbtn.UseVisualStyleBackColor = true;
            this.Salvarbtn.Click += new System.EventHandler(this.Salvarbtn_Click);
            // 
            // Atualizarbtn
            // 
            this.Atualizarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizarbtn.Location = new System.Drawing.Point(613, 72);
            this.Atualizarbtn.Name = "Atualizarbtn";
            this.Atualizarbtn.Size = new System.Drawing.Size(98, 38);
            this.Atualizarbtn.TabIndex = 10;
            this.Atualizarbtn.Text = "Atualizar";
            this.Atualizarbtn.UseVisualStyleBackColor = true;
            // 
            // Excluirbtn
            // 
            this.Excluirbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluirbtn.Location = new System.Drawing.Point(613, 191);
            this.Excluirbtn.Name = "Excluirbtn";
            this.Excluirbtn.Size = new System.Drawing.Size(98, 38);
            this.Excluirbtn.TabIndex = 11;
            this.Excluirbtn.Text = "Excluir";
            this.Excluirbtn.UseVisualStyleBackColor = true;
            this.Excluirbtn.Click += new System.EventHandler(this.Excluirbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(30, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 173);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Horário";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modelo do Veículo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Placa do Veículo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pagamento do Estacionamento";
            this.Column5.Name = "Column5";
            // 
            // TelaEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Excluirbtn);
            this.Controls.Add(this.Atualizarbtn);
            this.Controls.Add(this.Salvarbtn);
            this.Controls.Add(this.Cadastrarbtn);
            this.Controls.Add(this.Placatxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Modelotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clientetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.label1);
            this.Name = "TelaEstacionamento";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox Clientetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Modelotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Placatxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cadastrarbtn;
        private System.Windows.Forms.Button Salvarbtn;
        private System.Windows.Forms.Button Atualizarbtn;
        private System.Windows.Forms.Button Excluirbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

