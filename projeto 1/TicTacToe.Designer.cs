namespace projeto_1
{
    partial class TitTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reset = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            rankingDosJogadoresToolStripMenuItem = new ToolStripMenuItem();
            informarDadosDoJogadorToolStripMenuItem = new ToolStripMenuItem();
            greetings = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // reset
            // 
            reset.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reset.Location = new Point(12, 548);
            reset.Name = "reset";
            reset.Size = new Size(462, 58);
            reset.TabIndex = 0;
            reset.Text = "Reiniciar Partida";
            reset.UseVisualStyleBackColor = true;
            reset.Click += Reset_Game;
            // 
            // button11
            // 
            button11.Cursor = Cursors.Hand;
            button11.Font = new Font("Segoe UI", 35F);
            button11.ForeColor = SystemColors.ControlText;
            button11.Location = new Point(12, 80);
            button11.Name = "button11";
            button11.Size = new Size(150, 150);
            button11.TabIndex = 1;
            button11.UseVisualStyleBackColor = true;
            button11.Click += btn_Click;
            // 
            // button12
            // 
            button12.Cursor = Cursors.Hand;
            button12.Font = new Font("Segoe UI", 35F);
            button12.ForeColor = SystemColors.ControlText;
            button12.Location = new Point(168, 80);
            button12.Name = "button12";
            button12.Size = new Size(150, 150);
            button12.TabIndex = 2;
            button12.UseVisualStyleBackColor = true;
            button12.Click += btn_Click;
            // 
            // button13
            // 
            button13.Cursor = Cursors.Hand;
            button13.Font = new Font("Segoe UI", 35F);
            button13.ForeColor = SystemColors.ControlText;
            button13.Location = new Point(324, 80);
            button13.Name = "button13";
            button13.Size = new Size(150, 150);
            button13.TabIndex = 3;
            button13.UseVisualStyleBackColor = true;
            button13.Click += btn_Click;
            // 
            // button21
            // 
            button21.Cursor = Cursors.Hand;
            button21.Font = new Font("Segoe UI", 35F);
            button21.ForeColor = SystemColors.ControlText;
            button21.Location = new Point(12, 236);
            button21.Name = "button21";
            button21.Size = new Size(150, 150);
            button21.TabIndex = 4;
            button21.UseVisualStyleBackColor = true;
            button21.Click += btn_Click;
            // 
            // button22
            // 
            button22.Cursor = Cursors.Hand;
            button22.Font = new Font("Segoe UI", 35F);
            button22.ForeColor = SystemColors.ControlText;
            button22.Location = new Point(168, 236);
            button22.Name = "button22";
            button22.Size = new Size(150, 150);
            button22.TabIndex = 5;
            button22.UseVisualStyleBackColor = true;
            button22.Click += btn_Click;
            // 
            // button23
            // 
            button23.Cursor = Cursors.Hand;
            button23.Font = new Font("Segoe UI", 35F);
            button23.ForeColor = SystemColors.ControlText;
            button23.Location = new Point(324, 236);
            button23.Name = "button23";
            button23.Size = new Size(150, 150);
            button23.TabIndex = 6;
            button23.UseVisualStyleBackColor = true;
            button23.Click += btn_Click;
            // 
            // button31
            // 
            button31.Cursor = Cursors.Hand;
            button31.Font = new Font("Segoe UI", 35F);
            button31.ForeColor = SystemColors.ControlText;
            button31.Location = new Point(12, 392);
            button31.Name = "button31";
            button31.Size = new Size(150, 150);
            button31.TabIndex = 7;
            button31.UseVisualStyleBackColor = true;
            button31.Click += btn_Click;
            // 
            // button32
            // 
            button32.Cursor = Cursors.Hand;
            button32.Font = new Font("Segoe UI", 35F);
            button32.ForeColor = SystemColors.ControlText;
            button32.Location = new Point(168, 392);
            button32.Name = "button32";
            button32.Size = new Size(150, 150);
            button32.TabIndex = 8;
            button32.UseVisualStyleBackColor = true;
            button32.Click += btn_Click;
            // 
            // button33
            // 
            button33.Cursor = Cursors.Hand;
            button33.Font = new Font("Segoe UI", 35F);
            button33.ForeColor = SystemColors.ControlText;
            button33.Location = new Point(324, 392);
            button33.Name = "button33";
            button33.Size = new Size(150, 150);
            button33.TabIndex = 9;
            button33.UseVisualStyleBackColor = true;
            button33.Click += btn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(480, 33);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rankingDosJogadoresToolStripMenuItem, informarDadosDoJogadorToolStripMenuItem });
            opçõesToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(87, 29);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // rankingDosJogadoresToolStripMenuItem
            // 
            rankingDosJogadoresToolStripMenuItem.Name = "rankingDosJogadoresToolStripMenuItem";
            rankingDosJogadoresToolStripMenuItem.Size = new Size(317, 30);
            rankingDosJogadoresToolStripMenuItem.Text = "Ranking dos jogadores";
            rankingDosJogadoresToolStripMenuItem.Click += rankingDosJogadoresToolStripMenuItem_Click;
            // 
            // informarDadosDoJogadorToolStripMenuItem
            // 
            informarDadosDoJogadorToolStripMenuItem.Name = "informarDadosDoJogadorToolStripMenuItem";
            informarDadosDoJogadorToolStripMenuItem.Size = new Size(317, 30);
            informarDadosDoJogadorToolStripMenuItem.Text = "Informar dados do jogador";
            informarDadosDoJogadorToolStripMenuItem.Click += informarDadosDoJogadorToolStripMenuItem_Click;
            // 
            // greetings
            // 
            greetings.AutoSize = true;
            greetings.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greetings.Location = new Point(12, 46);
            greetings.Name = "greetings";
            greetings.Size = new Size(257, 31);
            greetings.TabIndex = 11;
            greetings.Text = "Olá, [Nome do Jogador]";
            // 
            // TitTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(480, 622);
            Controls.Add(greetings);
            Controls.Add(button33);
            Controls.Add(button32);
            Controls.Add(button31);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(reset);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "TitTacToe";
            Text = "Jogo da Velha";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reset;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button31;
        private Button button32;
        private Button button33;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem rankingDosJogadoresToolStripMenuItem;
        private ToolStripMenuItem informarDadosDoJogadorToolStripMenuItem;
        private Label greetings;
    }
}
