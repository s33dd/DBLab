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

    private void LoadObjects() {
      using (var db = new SqliteConnection(dbRoute)) {
        try {
          db.Open();
        }
        catch {
          MessageBox.Show("Database not found. Please, check all files.", "Error!");
          Close();
          return;
        }
        string query = "SELECT * FROM `Object`";
        SqliteCommand command = new SqliteCommand(query, db);
        using (SqliteDataReader reader = command.ExecuteReader()) {
          if (reader.HasRows) {
            while (reader.Read()) {
              SpaceObject obj = new SpaceObject(Int32.Parse(reader["id"].ToString()));
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
    }

    private void MainForm_Load(object sender, EventArgs e) {
      objects = new List<SpaceObject>();
      if (!Properties.Settings.Default.NotShow) {
        AboutForm about = new AboutForm();
        about.ShowDialog();
      }
      LoadObjects();
    }

    private void AddObjectToolStripMenuItem_Click(object sender, EventArgs e) {
      AddForm form = new AddForm();
      form.ShowDialog();
    }
  }
}
