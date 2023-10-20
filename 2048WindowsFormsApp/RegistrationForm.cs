namespace _2048WindowsFormsApp
{
    public partial class RegistrationForm : Form
    {
        private string username;
        private int fieldSize = 4;
        private List<RadioButton> radioButtons;
        public RegistrationForm() => InitializeComponent();
        private void startButton_Click(object sender, EventArgs e)
        {
            radioButtons = new List<RadioButton>()
            {
                radioButton1, radioButton2, radioButton3, radioButton4
            };
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked) { fieldSize = int.Parse(radioButton.Text[0].ToString()); break; }
            }
            username = nameTextBox1.Text;
            var mainForm = new MainForm(username, fieldSize);
            mainForm.ShowDialog();
            Close();
        }
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();
    }
}
