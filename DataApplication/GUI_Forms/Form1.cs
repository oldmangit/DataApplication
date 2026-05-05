using DataApplication.Repository;

namespace DataApplication
{
    public partial class Form1 : Form
    {
        private readonly IUserRepository _repo;
        public Form1(IUserRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var data = await _repo.LoadAllAsync();
            dataGridView1.DataSource = data;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit application ? ","Confirm Exit",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
