namespace Splitter
{
    public partial class FormSplitter : Form
    {
        public FormSplitter()
        {
            InitializeComponent();
            (new Core.DropShadow()).ApplyShadows(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}