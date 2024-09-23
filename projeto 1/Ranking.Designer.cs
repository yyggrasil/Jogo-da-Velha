namespace projeto_1
{
    partial class Ranking
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
            ranks = new ListView();
            Posicao = new ColumnHeader();
            nome = new ColumnHeader();
            Jogos = new ColumnHeader();
            Vitorias = new ColumnHeader();
            Pontuacao = new ColumnHeader();
            resetRank = new Button();
            SuspendLayout();
            // 
            // ranks
            // 
            ranks.Columns.AddRange(new ColumnHeader[] { Posicao, nome, Jogos, Vitorias, Pontuacao });
            ranks.Location = new Point(12, 12);
            ranks.Name = "ranks";
            ranks.Size = new Size(384, 426);
            ranks.TabIndex = 0;
            ranks.UseCompatibleStateImageBehavior = false;
            ranks.View = View.Details;
            // 
            // Posicao
            // 
            Posicao.Text = "Posição";
            Posicao.Width = 80;
            // 
            // nome
            // 
            nome.Text = "Nome";
            // 
            // Jogos
            // 
            Jogos.Text = "Jogos";
            // 
            // Vitorias
            // 
            Vitorias.Text = "Vitórias";
            Vitorias.Width = 80;
            // 
            // Pontuacao
            // 
            Pontuacao.Text = "Pontuação";
            Pontuacao.Width = 100;
            // 
            // resetRank
            // 
            resetRank.Location = new Point(12, 452);
            resetRank.Name = "resetRank";
            resetRank.Size = new Size(384, 40);
            resetRank.TabIndex = 1;
            resetRank.Text = "Reset ranking";
            resetRank.UseVisualStyleBackColor = true;
            resetRank.Click += reset_ranking;
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 504);
            Controls.Add(resetRank);
            Controls.Add(ranks);
            Name = "Ranking";
            Text = "Ranking de Jogadores";
            ResumeLayout(false);
        }

        #endregion

        public ListView ranks;
        private ColumnHeader Posicao;
        private ColumnHeader nome;
        private ColumnHeader Jogos;
        private ColumnHeader Vitorias;
        private ColumnHeader Pontuacao;
        private Button resetRank;
    }
}