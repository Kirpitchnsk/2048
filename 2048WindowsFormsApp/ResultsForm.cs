namespace _2048WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            FillTable();
        }
        void FillTable()
        {
            foreach (var item in UserStorage.Users)
            {
                dataGridView1.Rows.Add(item.Name, item.Record);
            }
        }
    }
}
