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

    }
}
