using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Windows.Forms;

namespace DBLab {
  public partial class EditForm : Form {

    private string dbRoute = @"Data source=.\spaceobjects.db;Mode=ReadWrite";
    private string name;
    private string photo;
    private string type;
    private string description;
    private string location;

    public EditForm() {
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

    private void EditForm_Load(object sender, EventArgs e) {
      using (var db = new SqliteConnection(dbRoute)) {
        int id = Properties.Settings.Default.ClickedId;
        db.Open();
        string query = $"SELECT photo, location, description, type, name FROM `Object` WHERE id = {id}";
        SqliteCommand command = new SqliteCommand(query, db);
        using (SqliteDataReader reader = command.ExecuteReader()) {
          reader.Read();
          photo = reader["photo"].ToString();
          PhotoPath.Text = $"File: {reader["photo"].ToString()}";
          DescriptionData.Text = reader["description"].ToString();
          TypeData.Text = reader["type"].ToString();
          LocationData.Text = reader["location"].ToString();
          NameData.Text = reader["name"].ToString();
        }
      }
    }

    private void UpdateBtn_Click(object sender, EventArgs e) {
      string checkString = "File:";
      int id = Properties.Settings.Default.ClickedId;
      if (PhotoPath.Text.Length <= checkString.Length || NameData.Text == "" || TypeData.Text == "" || LocationData.Text == "" || DescriptionData.Text == "") {
        MessageBox.Show("All fields must be filled!", "Error!");
        return;
      }
      name = NameData.Text;
      type = TypeData.Text;
      location = LocationData.Text;
      description = DescriptionData.Text;
      string query = $"UPDATE `Object` SET photo = '{photo}', location = '{location}', description = '{description}', type = '{type}', name = '{name}' WHERE id = {id}";
      using (var db = new SqliteConnection(dbRoute)) {
        db.Open();
        SqliteCommand command = new SqliteCommand();
        command.Connection = db;
        command.CommandText = query;
        command.ExecuteNonQuery();
      }
      MessageBox.Show("Object is updated, Refresh table to see it.", "Success!");
      Close();
    }
  }
}
