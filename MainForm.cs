using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBLab {
  public partial class MainForm : Form {
    private string dbRoute = @"Data source=.\spaceobjects.db;Mode=ReadWrite";
    private List<SpaceObject> objects;

    public MainForm() {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
      AboutForm about = new AboutForm();
      about.ShowDialog();
    }

    private void MainForm_Load(object sender, EventArgs e) {
      objects = new List<SpaceObject>();
      if (!Properties.Settings.Default.NotShow) {
        AboutForm about = new AboutForm();
        about.ShowDialog();
      }
      using (var db = new SqliteConnection(dbRoute)) {
        try {
          db.Open();
        }
        catch {
          MessageBox.Show("Database not found. Please, check all files.", "Error!");
          Close();
          return;
        }
        string query = "SELECT * FROM Object";
        SqliteCommand command = new SqliteCommand(query, db);
        using (SqliteDataReader reader = command.ExecuteReader()) {
          if (reader.HasRows) {
            while (reader.Read()) {
              SpaceObject obj = new SpaceObject((int)reader["id"]);
              obj.Name = reader["name"].ToString();
              obj.Description = reader["description"].ToString();
              obj.Type = reader["type"].ToString();
              obj.Location = reader["location"].ToString();
              obj.Photo = reader["photo"].ToString();
              objects.Add(obj);
            }
          }
          else {
            MessageBox.Show("Database is empty. Add something.", "Warning!");
          }
        }
      }
/*      for (int i = 1; i <= 90; i++) {
        Label name = new Label();
        name.Text = $"asdasd{i}";
        ObjectList.Controls.Add(name);
        if (i % 3 == 0) {
          ObjectList.RowCount = ObjectList.RowCount + 1;
          ObjectList.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        }
      }*/
    }
  }
}
