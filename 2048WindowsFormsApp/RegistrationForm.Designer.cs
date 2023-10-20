namespace _2048WindowsFormsApp
{
    partial class RegistrationForm
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
            StartWriting = new Label();
            nameTextBox1 = new TextBox();
            startButton = new Button();
            ExitButton = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SuspendLayout();
            // 
            // StartWriting
            // 
            StartWriting.AutoSize = true;
            StartWriting.Location = new Point(90, 18);
            StartWriting.Margin = new Padding(2, 0, 2, 0);
            StartWriting.Name = "StartWriting";
            StartWriting.Size = new Size(202, 30);
            StartWriting.TabIndex = 0;
            StartWriting.Text = "Добро пожаловать в игру 2048!\r\nВведите ваше имя и размеры поля.";
            // 
            // nameTextBox1
            // 
            nameTextBox1.Location = new Point(134, 64);
            nameTextBox1.Margin = new Padding(2);
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Size = new Size(106, 23);
            nameTextBox1.TabIndex = 1;
            // 
            // startButton
            // 
            startButton.Location = new Point(78, 224);
            startButton.Margin = new Padding(2);
            startButton.Name = "startButton";
            startButton.Size = new Size(78, 20);
            startButton.TabIndex = 6;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(216, 226);
            ExitButton.Margin = new Padding(2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(78, 20);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(90, 113);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(43, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "4x4";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(88, 169);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(43, 19);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "5x5";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(249, 116);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(43, 19);
            radioButton3.TabIndex = 10;
            radioButton3.Text = "6x6";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(249, 166);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(43, 19);
            radioButton4.TabIndex = 11;
            radioButton4.Text = "7x7";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 270);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(ExitButton);
            Controls.Add(startButton);
            Controls.Add(nameTextBox1);
            Controls.Add(StartWriting);
            Margin = new Padding(2);
            Name = "RegistrationForm";
            Text = "2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StartWriting;
        private TextBox nameTextBox1;
        private Button startButton;
        private Button ExitButton;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}