using System;
using System.Windows.Forms;

namespace DBLab {
  public partial class AboutForm : Form {
    public AboutForm() {
      InitializeComponent();
    }
    private void AgreeBtn_Click(object sender, EventArgs e) {
      Close();
    }

    private void AboutForm_FormClosed(object sender, FormClosedEventArgs e) {
      Properties.Settings.Default.NotShow = NotShowingChkbx.Checked;
      Properties.Settings.Default.Save();
    }

    private void AboutForm_Load(object sender, EventArgs e) {
      NotShowingChkbx.Checked = Properties.Settings.Default.NotShow;
    }
  }
}
