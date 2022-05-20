using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DBLab {
  public partial class ViewForm : Form {

    public ViewForm() {
      InitializeComponent();
      StartPosition = FormStartPosition.CenterScreen;
    }

    private void ViewForm_Load(object sender, EventArgs e) {
      int id = Properties.Settings.Default.ClickedId;
      SpaceObject obj;
      DB db = new DB();
      obj = db.GetById(id);
      FileStream fs = new FileStream(obj.Photo, FileMode.Open);
      Photo.Image = Image.FromStream(fs);
      fs.Close();
      Description.Text = obj.Description;
      Type.Text = obj.Type;
      Location.Text = obj.Location;
      ObjName.Text = obj.Name;
    }

    private void ViewForm_FormClosed(object sender, FormClosedEventArgs e) {
      Properties.Settings.Default.ClickedId = -1;
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      int id = Properties.Settings.Default.ClickedId;
      DialogResult res = MessageBox.Show("Are you sure?", "Deleting", MessageBoxButtons.YesNo);
      if (res == DialogResult.Yes) {
        DB db = new DB();
        db.DeleteById(id);
        MessageBox.Show("Object is deleted.", "Success!");
      }
      Close();
    }

    private void EditBtn_Click(object sender, EventArgs e) {
      EditForm form = new EditForm();
      form.ShowDialog();
      Close();
    }
  }
}
