using DataApplication.GUI_Forms;
using DataApplication.Repository;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace DataApplication.GUI_Forms
{
    public partial class OnlineForm : BaseForm
    {
        private readonly IUserRepository _repo;
        private GMapControl gMapControl1;
        public event EventHandler CloseOnlineMode;
        
        public OnlineForm(IUserRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (_repo == null)
                return;
            var data = await _repo.LoadAllAsync();
            dataGridView1.DataSource = data;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit Online Mode? ", "Confirm Exit", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                CloseOnlineMode?.Invoke(this, EventArgs.Empty);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
