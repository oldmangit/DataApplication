namespace DataApplication.GUI_Forms
{
    partial class BaseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // need to remove bcz it is baseform
            //this.ClientSize = new System.Drawing.Size(800, 450); // need to remove bcz it is baseform
            //this.Text = "BaseForm"; // need to remove bcz it is baseform
        }

    }
}