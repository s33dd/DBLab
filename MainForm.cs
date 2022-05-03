using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
      objects.Clear();
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
      ObjectList.Controls.Clear();
      ObjectList.RowStyles.Clear();
      foreach (SpaceObject obj in objects) {
        if (ObjectList.RowCount < objects.Count) {
          ObjectList.RowCount = ObjectList.RowCount + 1;
          ObjectList.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
        }
        PictureBox pic = new PictureBox();
        FileStream fs = new FileStream(obj.Photo, FileMode.Open);
        pic.Image = Image.FromStream(fs);
        fs.Close();
        pic.SizeMode = PictureBoxSizeMode.StretchImage;
        pic.Dock = DockStyle.Fill;

        Label name = new Label();
        name.Text = obj.Name;
        name.Margin = new Padding(85);
        name.AutoSize = true;
        name.Font = new Font("Arial", 14);

        Button btn = new Button();
        btn.Text = "View";
        btn.Name = $"item{obj.Id}";
        btn.Click += ViewButtonClick;
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

    private void ViewButtonClick(object sender, EventArgs e) {
      Button button = (Button)sender;
      int id = Int32.Parse(button.Name.Remove(0,4));
      Properties.Settings.Default.ClickedId = id;
      ViewForm form = new ViewForm();
      form.ShowDialog();
    }

    private void MainForm_Load(object sender, EventArgs e) {
      Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
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

    private void RefreshToolStripMenuItem_Click(object sender, EventArgs e) {
      LoadObjects();
      ShowObjects();
    }

    private void OnApplicationExit(object sender, EventArgs e) {
      if (Properties.Settings.Default.ToDelete != null) {
        foreach (var id in Properties.Settings.Default.ToDelete) {
          string photo = $"./img/{id}.jpg";
          File.Delete(photo);
        }
        Properties.Settings.Default.ToDelete.Clear();
      }
    }
  }
}
