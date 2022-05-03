using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing;
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

    private void ShowObjects() {
      foreach (SpaceObject obj in objects) {
        if (ObjectList.RowCount < objects.Count) {
          ObjectList.RowCount = ObjectList.RowCount + 1;
          ObjectList.RowStyles.Add(new RowStyle(SizeType.Absolute, 10));
        }
        PictureBox pic = new PictureBox();
        pic.Image = Image.FromFile(obj.Photo);
        pic.SizeMode = PictureBoxSizeMode.StretchImage;
        pic.Dock = DockStyle.Fill;
        Label name = new Label();
        name.Text = obj.Name;
        name.Margin = new Padding(85);
        name.AutoSize = true;
        name.Font = new Font("Arial", 14);
        Button btn = new Button();
        btn.Text = "View";
        btn.Margin = new Padding(85);
        btn.AutoSize = true;
        btn.Font = new Font("Arial", 14);
        btn.Width = 200;
        btn.Cursor = Cursors.Hand;
        ObjectList.Controls.Add(pic);
        ObjectList.Controls.Add(name);
        ObjectList.Controls.Add(btn);
      }
    }

    private void MainForm_Load(object sender, EventArgs e) {
      objects = new List<SpaceObject>();
      if (!Properties.Settings.Default.NotShow) {
        AboutForm about = new AboutForm();
        about.ShowDialog();
      }
      LoadObjects();
      ShowObjects();
    }

    private void AddObjectToolStripMenuItem_Click(object sender, EventArgs e) {
      AddForm form = new AddForm();
      form.ShowDialog();
    }
  }
}
