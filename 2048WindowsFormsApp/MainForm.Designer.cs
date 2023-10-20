namespace _2048WindowsFormsApp
{
    partial class MainForm
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
            PointsLabel = new Label();
            menuStrip1 = new MenuStrip();
            игровоеМенюToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            showGameRulesToolStripMenuItem = new ToolStripMenuItem();
            ganeResultsToolStripMenuItem = new ToolStripMenuItem();
            BestLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PointsLabel
            // 
            PointsLabel.AutoSize = true;
            PointsLabel.Location = new Point(155, 5);
            PointsLabel.Margin = new Padding(2, 0, 2, 0);
            PointsLabel.Name = "PointsLabel";
            PointsLabel.Size = new Size(33, 15);
            PointsLabel.TabIndex = 0;
            PointsLabel.Text = "Счёт";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { игровоеМенюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(518, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // игровоеМенюToolStripMenuItem
            // 
            игровоеМенюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartToolStripMenuItem, exitToolStripMenuItem, showGameRulesToolStripMenuItem, ganeResultsToolStripMenuItem });
            игровоеМенюToolStripMenuItem.Name = "игровоеМенюToolStripMenuItem";
            игровоеМенюToolStripMenuItem.Size = new Size(101, 22);
            игровоеМенюToolStripMenuItem.Text = "Игровое меню";
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(180, 22);
            restartToolStripMenuItem.Text = "Перезапуск";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Выйти из игры";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // showGameRulesToolStripMenuItem
            // 
            showGameRulesToolStripMenuItem.Name = "showGameRulesToolStripMenuItem";
            showGameRulesToolStripMenuItem.Size = new Size(180, 22);
            showGameRulesToolStripMenuItem.Text = "Правила игры";
            showGameRulesToolStripMenuItem.Click += showGameRulesToolStripMenuItem_Click;
            // 
            // ganeResultsToolStripMenuItem
            // 
            ganeResultsToolStripMenuItem.Name = "ganeResultsToolStripMenuItem";
            ganeResultsToolStripMenuItem.Size = new Size(180, 22);
            ganeResultsToolStripMenuItem.Text = "Результаты игры";
            ganeResultsToolStripMenuItem.Click += gameResultsToolStripMenuItem_Click;
            // 
            // BestLabel
            // 
            BestLabel.AutoSize = true;
            BestLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            BestLabel.Location = new Point(117, 349);
            BestLabel.Name = "BestLabel";
            BestLabel.Size = new Size(112, 47);
            BestLabel.TabIndex = 2;
            BestLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 461);
            Controls.Add(BestLabel);
            Controls.Add(PointsLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "2048";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PointsLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem игровоеМенюToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem showGameRulesToolStripMenuItem;
        private ToolStripMenuItem ganeResultsToolStripMenuItem;
        private Label BestLabel;
    }
}