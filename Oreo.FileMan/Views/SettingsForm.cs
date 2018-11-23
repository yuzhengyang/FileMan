using Azylee.WinformSkin.FormUI.NoTitle;
using System;

namespace Oreo.FileMan.Views
{
    public partial class SettingsForm : NoTitleForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
