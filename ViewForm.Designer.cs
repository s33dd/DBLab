namespace DBLab {
  partial class ViewForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.Photo = new System.Windows.Forms.PictureBox();
      this.ObjName = new System.Windows.Forms.Label();
      this.LocationLabel = new System.Windows.Forms.Label();
      this.Location = new System.Windows.Forms.Label();
      this.TypeLabel = new System.Windows.Forms.Label();
      this.Type = new System.Windows.Forms.Label();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.Description = new System.Windows.Forms.RichTextBox();
      this.DeleteBtn = new System.Windows.Forms.Button();
      this.EditBtn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
      this.SuspendLayout();
      // 
      // Photo
      // 
      this.Photo.Location = new System.Drawing.Point(12, 42);
      this.Photo.Name = "Photo";
      this.Photo.Size = new System.Drawing.Size(332, 328);
      this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.Photo.TabIndex = 0;
      this.Photo.TabStop = false;
      // 
      // ObjName
      // 
      this.ObjName.AutoSize = true;
      this.ObjName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ObjName.Location = new System.Drawing.Point(531, 42);
      this.ObjName.Name = "ObjName";
      this.ObjName.Size = new System.Drawing.Size(115, 29);
      this.ObjName.TabIndex = 1;
      this.ObjName.Text = "Sample text";
      // 
      // LocationLabel
      // 
      this.LocationLabel.AutoSize = true;
      this.LocationLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LocationLabel.Location = new System.Drawing.Point(417, 101);
      this.LocationLabel.Name = "LocationLabel";
      this.LocationLabel.Size = new System.Drawing.Size(63, 20);
      this.LocationLabel.TabIndex = 2;
      this.LocationLabel.Text = "Location:";
      // 
      // Location
      // 
      this.Location.AutoSize = true;
      this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Location.Location = new System.Drawing.Point(486, 97);
      this.Location.Name = "Location";
      this.Location.Size = new System.Drawing.Size(108, 24);
      this.Location.TabIndex = 3;
      this.Location.Text = "Sample text";
      // 
      // TypeLabel
      // 
      this.TypeLabel.AutoSize = true;
      this.TypeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TypeLabel.Location = new System.Drawing.Point(437, 153);
      this.TypeLabel.Name = "TypeLabel";
      this.TypeLabel.Size = new System.Drawing.Size(43, 20);
      this.TypeLabel.TabIndex = 4;
      this.TypeLabel.Text = "Type:";
      // 
      // Type
      // 
      this.Type.AutoSize = true;
      this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Type.Location = new System.Drawing.Point(486, 149);
      this.Type.Name = "Type";
      this.Type.Size = new System.Drawing.Size(108, 24);
      this.Type.TabIndex = 5;
      this.Type.Text = "Sample text";
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.DescriptionLabel.Location = new System.Drawing.Point(400, 204);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(80, 20);
      this.DescriptionLabel.TabIndex = 6;
      this.DescriptionLabel.Text = "Description:";
      // 
      // Description
      // 
      this.Description.Cursor = System.Windows.Forms.Cursors.Default;
      this.Description.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Description.Location = new System.Drawing.Point(490, 206);
      this.Description.Name = "Description";
      this.Description.ReadOnly = true;
      this.Description.Size = new System.Drawing.Size(298, 256);
      this.Description.TabIndex = 7;
      this.Description.Text = "";
      // 
      // DeleteBtn
      // 
      this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.DeleteBtn.Location = new System.Drawing.Point(187, 573);
      this.DeleteBtn.Name = "DeleteBtn";
      this.DeleteBtn.Size = new System.Drawing.Size(93, 36);
      this.DeleteBtn.TabIndex = 8;
      this.DeleteBtn.Text = "Delete";
      this.DeleteBtn.UseVisualStyleBackColor = true;
      // 
      // EditBtn
      // 
      this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.EditBtn.Location = new System.Drawing.Point(501, 573);
      this.EditBtn.Name = "EditBtn";
      this.EditBtn.Size = new System.Drawing.Size(93, 36);
      this.EditBtn.TabIndex = 9;
      this.EditBtn.Text = "Edit";
      this.EditBtn.UseVisualStyleBackColor = true;
      // 
      // ViewForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 643);
      this.Controls.Add(this.EditBtn);
      this.Controls.Add(this.DeleteBtn);
      this.Controls.Add(this.Description);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.Type);
      this.Controls.Add(this.TypeLabel);
      this.Controls.Add(this.Location);
      this.Controls.Add(this.LocationLabel);
      this.Controls.Add(this.ObjName);
      this.Controls.Add(this.Photo);
      this.MaximizeBox = false;
      this.Name = "ViewForm";
      this.Text = "View";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewForm_FormClosed);
      this.Load += new System.EventHandler(this.ViewForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox Photo;
    private System.Windows.Forms.Label ObjName;
    private System.Windows.Forms.Label LocationLabel;
    private System.Windows.Forms.Label Location;
    private System.Windows.Forms.Label TypeLabel;
    private System.Windows.Forms.Label Type;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.RichTextBox Description;
    private System.Windows.Forms.Button DeleteBtn;
    private System.Windows.Forms.Button EditBtn;
  }
}