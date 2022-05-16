using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DBLab {
  public partial class MainForm : Form {
    private List<SpaceObject> objects;

    public MainForm() {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
      AboutForm about = new AboutForm();
      about.ShowDialog();
    }

    public void LoadObjects() {
      objects.Clear();
      DB db = new DB();
      objects = db.GetList();
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

    private void SaveListOfObjectsToolStripMenuItem_Click(object sender, EventArgs e) {
      string title = $"Space objects:{Environment.NewLine}";
      SaveList.Filter = "txt files (*.txt)|*.txt";
      if (objects.Count == 0) {
        MessageBox.Show("Nothing to save!", "Waarning!");
        return;
      }
      if (SaveList.ShowDialog() == DialogResult.OK) {
        string filePath = SaveList.FileName;
        using (StreamWriter writer = new StreamWriter(filePath, false)) {
          writer.WriteLine(title);
          foreach (SpaceObject obj in objects) {
            writer.WriteLine(obj.Name + Environment.NewLine);
          }
        }
      }
    }

    private void MainForm_Activated(object sender, EventArgs e) {
      LoadObjects();
      ShowObjects();
    }
  }
}
