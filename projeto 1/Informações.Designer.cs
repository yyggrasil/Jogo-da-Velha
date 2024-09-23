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
            radioButton1 = new RadioButton();
            difFacil = new RadioButton();
            Dificuldades.SuspendLayout();
            SuspendLayout();
            // 
            // displayNome
            // 
            displayNome.AutoSize = true;
            displayNome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayNome.Location = new Point(43, 9);
            displayNome.Name = "displayNome";
            displayNome.Size = new Size(301, 38);
            displayNome.TabIndex = 0;
            displayNome.Text = "NOME DO JOGADOR:";
            // 
            // NomeJogador
            // 
            NomeJogador.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeJogador.Location = new Point(20, 50);
            NomeJogador.Name = "NomeJogador";
            NomeJogador.Size = new Size(337, 43);
            NomeJogador.TabIndex = 1;
            // 
            // IniciarJogo
            // 
            IniciarJogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IniciarJogo.Location = new Point(17, 288);
            IniciarJogo.Name = "IniciarJogo";
            IniciarJogo.Size = new Size(337, 63);
            IniciarJogo.TabIndex = 6;
            IniciarJogo.Text = "INICAR JOGO";
            IniciarJogo.UseVisualStyleBackColor = true;
            IniciarJogo.Click += IniciarPartida;
            // 
            // Dificuldades
            // 
            Dificuldades.Controls.Add(radioButton1);
            Dificuldades.Controls.Add(difFacil);
            Dificuldades.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dificuldades.Location = new Point(20, 119);
            Dificuldades.Name = "Dificuldades";
            Dificuldades.Size = new Size(334, 151);
            Dificuldades.TabIndex = 7;
            Dificuldades.TabStop = false;
            Dificuldades.Text = "DIFICULDADE";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 16F);
            radioButton1.Location = new Point(23, 93);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(258, 41);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Jogador x Jogador";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // difFacil
            // 
            difFacil.AutoSize = true;
            difFacil.Checked = true;
            difFacil.Font = new Font("Segoe UI", 16F);
            difFacil.Location = new Point(89, 46);
            difFacil.Name = "difFacil";
            difFacil.Size = new Size(102, 41);
            difFacil.TabIndex = 0;
            difFacil.TabStop = true;
            difFacil.Text = "FÁCIL";
            difFacil.UseVisualStyleBackColor = true;
            // 
            // Informações
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 370);
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
        private RadioButton difFacil;
        private RadioButton radioButton1;
    }
}