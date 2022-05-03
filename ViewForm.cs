using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DBLab {
  public partial class ViewForm : Form {

    private string dbRoute = @"Data source=.\spaceobjects.db;Mode=ReadWrite";

    public ViewForm() {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void ViewForm_Load(object sender, EventArgs e) {
      using (var db = new SqliteConnection(dbRoute)) {
        int id = Properties.Settings.Default.ClickedId;
        db.Open();
        string query = $"SELECT photo, location, description, type, name FROM `Object` WHERE id = {id}";
        SqliteCommand command = new SqliteCommand(query, db);
        using (SqliteDataReader reader = command.ExecuteReader()) {
          reader.Read();
          FileStream fs = new FileStream(reader["photo"].ToString(), FileMode.Open);
          Photo.Image = Image.FromStream(fs);
          fs.Close();
          Description.Text = reader["description"].ToString();
          Type.Text = reader["type"].ToString();
          Location.Text = reader["location"].ToString();
          ObjName.Text = reader["name"].ToString();
        }
      }
    }

    private void ViewForm_FormClosed(object sender, FormClosedEventArgs e) {
      Properties.Settings.Default.ClickedId = -1;
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      int id = Properties.Settings.Default.ClickedId;
      string query = $"DELETE FROM `Object` WHERE id = {id}";
      using (var db = new SqliteConnection(dbRoute)) {
        db.Open();
        SqliteCommand command = new SqliteCommand();
        command.Connection = db;
        command.CommandText = query;
        command.ExecuteNonQuery();
      }
      if (Properties.Settings.Default.ToDelete == null) {
        Properties.Settings.Default.ToDelete = new System.Collections.Specialized.StringCollection();
      }
      Properties.Settings.Default.ToDelete.Add(id.ToString());
      MessageBox.Show("Object is deleted, Refresh table to see this.", "Success!");
      Close();
    }

    private void EditBtn_Click(object sender, EventArgs e) {
      EditForm form = new EditForm();
      form.ShowDialog();
    }
  }
}
