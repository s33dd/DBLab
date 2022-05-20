using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBLab {
  public class DB {
    private string dbRoute;

    public DB() {
      dbRoute = @"Data source=.\spaceobjects.db;Mode=ReadWrite";
    }

    public DB(string dbRoute) {
      this.dbRoute = dbRoute;
    }

    public List<SpaceObject> GetList() {
      List<SpaceObject> objects = new List<SpaceObject>();
      using (var db = new SqliteConnection(dbRoute)) {
        try {
          db.Open();
        }
        catch {
          MessageBox.Show("Database not found. Please, check all files.", "Error!");
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
      return objects;
    }

    public SpaceObject GetById(int id) {
      using (var db = new SqliteConnection(dbRoute)) {
        db.Open();
        string query = $"SELECT photo, location, description, type, name FROM `Object` WHERE id = @id";
        SqliteCommand command = new SqliteCommand(query, db);
        command.Parameters.Add(new SqliteParameter("@id", id));
        using (SqliteDataReader reader = command.ExecuteReader()) {
          reader.Read();
          SpaceObject obj = new SpaceObject(id);
          obj.Name = reader["name"].ToString();
          obj.Description = reader["description"].ToString();
          obj.Type = reader["type"].ToString();
          obj.Location = reader["location"].ToString();
          obj.Photo = reader["photo"].ToString();
          return obj;
        }
      }
    }

    public void DeleteById(int id) {
      string query = $"DELETE FROM `Object` WHERE id = @id";
      using (var db = new SqliteConnection(dbRoute)) {
        db.Open();
        SqliteCommand command = new SqliteCommand();
        command.Parameters.Add(new SqliteParameter("@id", id));
        command.Connection = db;
        command.CommandText = query;
        command.ExecuteNonQuery();
      }
      if (Properties.Settings.Default.ToDelete == null) {
        Properties.Settings.Default.ToDelete = new System.Collections.Specialized.StringCollection();
      }
      Properties.Settings.Default.ToDelete.Add(id.ToString());
    }

    public void UpdateById(int id, string photo, string name, string type, string location, string description) {
      string query = $"UPDATE `Object` SET photo = @photo, location = @location, description = @description, type = @type, name = @name WHERE id = @id";
      using (var db = new SqliteConnection(dbRoute)) {
        db.Open();
        SqliteCommand command = new SqliteCommand();
        command.Connection = db;
        command.Parameters.Add(new SqliteParameter("@id", id));
        command.Parameters.Add(new SqliteParameter("@photo", photo));
        command.Parameters.Add(new SqliteParameter("@name", name));
        command.Parameters.Add(new SqliteParameter("@location", location));
        command.Parameters.Add(new SqliteParameter("@description", description));
        command.Parameters.Add(new SqliteParameter("@type", type));
        command.CommandText = query;
        command.ExecuteNonQuery();
      }
    }

    public void Add(string photo, string name, string type, string location, string description) {
      string query = $"INSERT INTO `Object` (photo, location, description, type, name) VALUES (@photo, @location, @description, @type, @name)";
      using (var db = new SqliteConnection(dbRoute)) {
        db.Open();
        SqliteCommand command = new SqliteCommand();
        command.Connection = db;
        command.Parameters.Add(new SqliteParameter("@photo", photo));
        command.Parameters.Add(new SqliteParameter("@name", name));
        command.Parameters.Add(new SqliteParameter("@location", location));
        command.Parameters.Add(new SqliteParameter("@description", description));
        command.Parameters.Add(new SqliteParameter("@type", type));
        command.CommandText = query;
        command.ExecuteNonQuery();
      }
    }

    public void CreateTestTable() {
      using (var db = new SqliteConnection(dbRoute)) {
        db.Open();
        SqliteCommand command = new SqliteCommand();
        command.Connection = db;
        string query = "CREATE TABLE `Object` ( `id`  INTEGER NOT NULL UNIQUE, `photo` TEXT NOT NULL, `location`  TEXT NOT NULL, " +
        "`description` TEXT, `type`  TEXT NOT NULL, " +
        "`name`  TEXT NOT NULL, PRIMARY KEY(`id` AUTOINCREMENT))";
        command.CommandText = query;
        command.ExecuteNonQuery();
      }
    }

    public void DropTest() {
      using (var db = new SqliteConnection(dbRoute)) {
        db.Open();
        SqliteCommand command = new SqliteCommand();
        command.Connection = db;
        string query = "DROP table 'Object'";
        command.CommandText = query;
        command.ExecuteNonQuery();
      }
    }
  }
}
