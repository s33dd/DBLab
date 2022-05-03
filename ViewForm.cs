using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
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
          Photo.Image = Image.FromFile(reader["photo"].ToString());
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
  }
}
