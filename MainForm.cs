using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace DBLab {
  public partial class MainForm : Form {
    private string dbRoute = @"Data source=.\spaceobjects.db;Mode=ReadWrite";

    public MainForm() {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
      AboutForm about = new AboutForm();
      about.ShowDialog();
    }

    private void MainForm_Load(object sender, EventArgs e) {
      if (!Properties.Settings.Default.NotShow) {
        AboutForm about = new AboutForm();
        about.ShowDialog();
      }
    }
  }
}
