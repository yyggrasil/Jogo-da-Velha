namespace projeto_1
{
    partial class Informações
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
            displayNome = new Label();
            NomeJogador = new TextBox();
            IniciarJogo = new Button();
            Dificuldades = new GroupBox();
            difDificil = new RadioButton();
            difFacil = new RadioButton();
            Dificuldades.SuspendLayout();
            SuspendLayout();
            // 
            // displayNome
            // 
            displayNome.AutoSize = true;
            displayNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayNome.Location = new Point(44, 28);
            displayNome.Name = "displayNome";
            displayNome.Size = new Size(215, 28);
            displayNome.TabIndex = 0;
            displayNome.Text = "NOME DO JOGADOR:";
            // 
            // NomeJogador
            // 
            NomeJogador.Location = new Point(20, 59);
            NomeJogador.Name = "NomeJogador";
            NomeJogador.Size = new Size(250, 27);
            NomeJogador.TabIndex = 1;
            // 
            // IniciarJogo
            // 
            IniciarJogo.Location = new Point(20, 276);
            IniciarJogo.Name = "IniciarJogo";
            IniciarJogo.Size = new Size(250, 29);
            IniciarJogo.TabIndex = 6;
            IniciarJogo.Text = "INICAR JOGO";
            IniciarJogo.UseVisualStyleBackColor = true;
            IniciarJogo.Click += button1_Click;
            // 
            // Dificuldades
            // 
            Dificuldades.Controls.Add(difDificil);
            Dificuldades.Controls.Add(difFacil);
            Dificuldades.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dificuldades.Location = new Point(20, 119);
            Dificuldades.Name = "Dificuldades";
            Dificuldades.Size = new Size(250, 125);
            Dificuldades.TabIndex = 7;
            Dificuldades.TabStop = false;
            Dificuldades.Text = "DIFICULDADE";
            // 
            // difDificil
            // 
            difDificil.AutoSize = true;
            difDificil.Location = new Point(125, 51);
            difDificil.Name = "difDificil";
            difDificil.Size = new Size(85, 27);
            difDificil.TabIndex = 1;
            difDificil.TabStop = true;
            difDificil.Text = "DIFÍCIL";
            difDificil.UseVisualStyleBackColor = true;
            // 
            // difFacil
            // 
            difFacil.AutoSize = true;
            difFacil.Checked = true;
            difFacil.Location = new Point(6, 51);
            difFacil.Name = "difFacil";
            difFacil.Size = new Size(73, 27);
            difFacil.TabIndex = 0;
            difFacil.TabStop = true;
            difFacil.Text = "FÁCIL";
            difFacil.UseVisualStyleBackColor = true;
            // 
            // Informações
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 331);
            Controls.Add(Dificuldades);
            Controls.Add(IniciarJogo);
            Controls.Add(NomeJogador);
            Controls.Add(displayNome);
            Name = "Informações";
            Text = "Dados do Jogador";
            Dificuldades.ResumeLayout(false);
            Dificuldades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label displayNome;
        private TextBox NomeJogador;
        private Button IniciarJogo;
        private GroupBox Dificuldades;
        private RadioButton difDificil;
        private RadioButton difFacil;
    }
}