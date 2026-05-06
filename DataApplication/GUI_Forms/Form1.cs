using DataApplication.Repository;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace DataApplication
{
    public partial class Form1 : Form
    {
        private readonly IUserRepository _repo;
        private GMapControl gMapControl1;
        public event EventHandler CloseOnlineMode;
        public Form1(IUserRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var data = await _repo.LoadAllAsync();
            dataGridView1.DataSource = data;

            //gMapControl1 = new GMapControl();
            //gMapControl1.Dock = DockStyle.Fill;
            //this.Controls.Add(gMapControl1);


            //gMapControl1.MapProvider = GMapProviders.GoogleMap;
            //GMaps.Instance.Mode = AccessMode.ServerOnly;

            //gMapControl1.Position = new PointLatLng(12.9716, 77.5946);
            //gMapControl1.MinZoom = 2;
            //gMapControl1.MaxZoom = 18;
            //gMapControl1.Zoom = 10;
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
