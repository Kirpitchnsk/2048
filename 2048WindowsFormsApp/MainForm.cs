namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private int mapSize;
        private const int labelInterval = 76;
        private const int spaceBwnFormLabelX = 10;
        private const int spaceBwnFormLabelY = 70;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        private string username;
        private User user;
        private UserStorage storage;
        private bool gameEnd;
        public MainForm(string username = "Guest", int mapSize = 4)
        {
            InitializeComponent();
            this.username = username;
            this.mapSize = mapSize;
        }

        private int getX(int indexColX) => spaceBwnFormLabelX + indexColX * labelInterval;
        private int getY(int indexColY) => spaceBwnFormLabelY + indexColY * labelInterval;
        private void Form1_Load(object sender, EventArgs e)
        {
            gameEnd = false;
            InitMap();
            GenerateNumber();
            ShowScore();
            storage = new UserStorage();
            UserStorage.SortStorage();
            if(UserStorage.Users.Count > 0) BestLabel.Text = "Лучший игрок: " + UserStorage.Users[0].Name + "\nРезультат: " + UserStorage.Users[0].Record;
            else BestLabel.Text = "Лучший игрок: Некто" + "\nРезультат: 0";
        }
        private void ShowScore() => PointsLabel.Text = score.ToString();
        private void GenerateNumber()
        {
            while (true)
            {
                var randomNuberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNuberLabel / mapSize;
                var indexColumn = randomNuberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var randomNumber = random.Next(1, 101);
                    if (randomNumber <= 75)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                    }
                    PaintCell(int.Parse(labelsMap[indexRow, indexColumn].Text), indexRow, indexColumn);
                    break;
                }
                if (CheckEndOfGame())
                {
                    GameEnd(false);
                    break;
                }
                if (gameEnd) break;
            }
        }
        private void PaintCell(int number, int col, int row)
        {
            switch (number)
            {
                case 2: labelsMap[col, row].BackColor = Color.FromArgb(255, 255, 255); break;
                case 4: labelsMap[col, row].BackColor = Color.FromArgb(252, 228, 228); break;
                case 8: labelsMap[col, row].BackColor = Color.FromArgb(237, 153, 153); break;
                case 16: labelsMap[col, row].BackColor = Color.FromArgb(235, 109, 109); break;
                case 32: labelsMap[col, row].BackColor = Color.FromArgb(224, 80, 80); break;
                case 64: labelsMap[col, row].BackColor = Color.FromArgb(255, 84, 84); break;
                case 128: labelsMap[col, row].BackColor = Color.FromArgb(214, 30, 30); break;
                case 256: labelsMap[col, row].BackColor = Color.FromArgb(191, 73, 73); break;
                case 512: labelsMap[col, row].BackColor = Color.FromArgb(171, 81, 81); break;
                case 1024: labelsMap[col, row].BackColor = Color.FromArgb(145, 90, 90); break;
                case 2048: labelsMap[col, row].BackColor = Color.FromArgb(121, 71, 71); break;
                case 0: labelsMap[col, row].BackColor = SystemColors.ButtonShadow; break;
            }
        }
        private void GameEnd(bool result)
        {
            if (result) MessageBox.Show("2048 собран! Вы выйграли");
            else MessageBox.Show("Игра окончена. Ходов больше нет");
            user = new(username, score);
            foreach (var item in UserStorage.Users)
            {
                if (item.Name == username && item.Record < score) UserStorage.Remove(item);
            }
            UserStorage.Add(user);
            gameEnd = true;
        }
        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != String.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != String.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    PaintCell(number * 2, i, j);
                                    PaintCell(0, i, k);
                                    labelsMap[i, k].Text = String.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == String.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != String.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = String.Empty;
                                PaintCell(int.Parse(labelsMap[i, j].Text), i, j);
                                PaintCell(0, i, k);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != String.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != String.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    if (number * 2 == 2048) GameEnd(true);
                                    labelsMap[i, k].Text = String.Empty;
                                    PaintCell(number * 2, i, j);
                                    PaintCell(0, i, k);
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == String.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != String.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                PaintCell(int.Parse(labelsMap[i, j].Text), i, j);
                                labelsMap[i, k].Text = String.Empty;
                                PaintCell(0, i, k);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != String.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != String.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    PaintCell(number * 2, i, j);
                                    PaintCell(0, k, j);
                                    labelsMap[k, j].Text = String.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == String.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != String.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = String.Empty;
                                PaintCell(int.Parse(labelsMap[i, j].Text), i, j);
                                PaintCell(0, k, j);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != String.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != String.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    PaintCell(number * 2, i, j);
                                    PaintCell(0, k, j);
                                    labelsMap[k, j].Text = String.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }


            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == String.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != String.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = String.Empty;
                                PaintCell(int.Parse(labelsMap[i, j].Text), i, j);
                                PaintCell(0, k, j);
                                break;
                            }
                        }
                    }
                }
            }
        }
        private bool CheckEndOfGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == String.Empty) return false;
                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i+1, j].Text || labelsMap[i, j] == labelsMap[i, j + 1]) return false;
                }
            }
            return true;
        }
        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexCol)
        {
            var label = new Label();
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.Text = String.Empty;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point(getX(indexCol), getY(indexRow));
            label.Width = 70;
            label.Height = 70;
            return label;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down) || gameEnd) return;
            if (e.KeyCode == Keys.Right) MoveRight();
            if (e.KeyCode == Keys.Left) MoveLeft();
            if (e.KeyCode == Keys.Up) MoveUp();
            if (e.KeyCode == Keys.Down) MoveDown();
            GenerateNumber();
            ShowScore();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) => Application.Restart();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void showGameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gameRules = "Соединяйте числа и получите число 2048!\n" +
                "Как играть:\nИспользуйте стрелки на клавиатуре чтобы перемещать плитки.\n" +
                "Когда две плитки соприкасаются, они сливаются в одну!\nCreated by kirpitchnsk";
            MessageBox.Show(gameRules);
        }

        private void gameResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new ResultsForm();
            form3.ShowDialog();
        }
    }
}