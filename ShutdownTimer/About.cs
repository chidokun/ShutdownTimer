using System;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            InitializeLanguage();
        }

        #region Language
        public Language currentLanguage = Program.mainWindow.currentLanguage;
        private void InitializeLanguage()
        {
            lblTitle.Text = currentLanguage.Items["About.Title"];
            lblVersion.Text = currentLanguage.Items["About.Version"] + Application.ProductVersion+ " (151018)";
            btnClose.Text = currentLanguage.Items["About.ButtonClose"];
        }
        #endregion
    }
}
