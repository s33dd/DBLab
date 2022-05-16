using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Windows.Forms;

namespace DBLab {
  public partial class AddForm : Form {
    private string dbRoute = @"Data source=.\spaceobjects.db;Mode=ReadWrite";
    private string name;
    private string photo;
    private string type;
    private string description;
    private string location;

    public AddForm() {
      InitializeComponent();
    }

    private void PhotoBtn_Click(object sender, EventArgs e) {
      OpenFile.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
      int? num;
      if (OpenFile.ShowDialog() == DialogResult.OK) { 
        string path = OpenFile.FileName;
        PhotoPath.Text = $"File: {path}";
        string query = "SELECT seq FROM `sqlite_sequence` WHERE name = 'Object'";
        using (var db = new SqliteConnection(dbRoute)) {
          db.Open();
          SqliteCommand command = new SqliteCommand(query, db);
          using (SqliteDataReader reader = command.ExecuteReader()) {
            reader.Read();
            num = Int32.Parse(reader["seq"].ToString()) + 1;
          }
        }
        string newPath = $"./img/{num}.jpg";
        File.Copy(path, newPath, true);
        photo = newPath;
      }
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      string checkString = "File:";
      if (PhotoPath.Text.Length <= checkString.Length || NameData.Text == "" || TypeData.Text=="" || LocationData.Text == "" || DescriptionData.Text == "") {
        MessageBox.Show("All fields must be filled!", "Error!");
        return;
      }
      name = NameData.Text;
      type = TypeData.Text;
      location = LocationData.Text;
      description = DescriptionData.Text;
      DB db = new DB();
      db.Add(photo, name, type, location, description);
      MessageBox.Show("Object is added.", "Success!");
      Close();
    }
  }
}
