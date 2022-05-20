namespace DBLab {
  partial class EditForm {
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
      this.UpdateBtn = new System.Windows.Forms.Button();
      this.DescriptionData = new System.Windows.Forms.RichTextBox();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.LocationData = new System.Windows.Forms.TextBox();
      this.LocationLabel = new System.Windows.Forms.Label();
      this.TypeData = new System.Windows.Forms.ComboBox();
      this.NameData = new System.Windows.Forms.TextBox();
      this.TypeLabel = new System.Windows.Forms.Label();
      this.NameLabel = new System.Windows.Forms.Label();
      this.PhotoPath = new System.Windows.Forms.Label();
      this.PhotoBtn = new System.Windows.Forms.Button();
      this.PhotoLabel = new System.Windows.Forms.Label();
      this.OpenFile = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // UpdateBtn
      // 
      this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.UpdateBtn.Location = new System.Drawing.Point(320, 395);
      this.UpdateBtn.Name = "UpdateBtn";
      this.UpdateBtn.Size = new System.Drawing.Size(166, 44);
      this.UpdateBtn.TabIndex = 23;
      this.UpdateBtn.Text = "Update object";
      this.UpdateBtn.UseVisualStyleBackColor = true;
      this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
      // 
      // DescriptionData
      // 
      this.DescriptionData.Location = new System.Drawing.Point(84, 206);
      this.DescriptionData.Name = "DescriptionData";
      this.DescriptionData.Size = new System.Drawing.Size(695, 159);
      this.DescriptionData.TabIndex = 22;
      this.DescriptionData.Text = "";
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Location = new System.Drawing.Point(22, 206);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
      this.DescriptionLabel.TabIndex = 21;
      this.DescriptionLabel.Text = "Description:";
      // 
      // LocationData
      // 
      this.LocationData.Location = new System.Drawing.Point(84, 153);
      this.LocationData.Name = "LocationData";
      this.LocationData.Size = new System.Drawing.Size(121, 20);
      this.LocationData.TabIndex = 20;
      // 
      // LocationLabel
      // 
      this.LocationLabel.AutoSize = true;
      this.LocationLabel.Location = new System.Drawing.Point(22, 156);
      this.LocationLabel.Name = "LocationLabel";
      this.LocationLabel.Size = new System.Drawing.Size(51, 13);
      this.LocationLabel.TabIndex = 19;
      this.LocationLabel.Text = "Location:";
      // 
      // TypeData
      // 
      this.TypeData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.TypeData.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.TypeData.FormattingEnabled = true;
      this.TypeData.Items.AddRange(new object[] {
            "Galaxy",
            "Star",
            "Planet",
            "Asteroid",
            "Space body"});
      this.TypeData.Location = new System.Drawing.Point(84, 105);
      this.TypeData.Name = "TypeData";
      this.TypeData.Size = new System.Drawing.Size(121, 21);
      this.TypeData.TabIndex = 18;
      // 
      // NameData
      // 
      this.NameData.Location = new System.Drawing.Point(84, 58);
      this.NameData.Name = "NameData";
      this.NameData.Size = new System.Drawing.Size(121, 20);
      this.NameData.TabIndex = 17;
      // 
      // TypeLabel
      // 
      this.TypeLabel.AutoSize = true;
      this.TypeLabel.Location = new System.Drawing.Point(22, 108);
      this.TypeLabel.Name = "TypeLabel";
      this.TypeLabel.Size = new System.Drawing.Size(34, 13);
      this.TypeLabel.TabIndex = 16;
      this.TypeLabel.Text = "Type:";
      // 
      // NameLabel
      // 
      this.NameLabel.AutoSize = true;
      this.NameLabel.Location = new System.Drawing.Point(22, 61);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.Size = new System.Drawing.Size(38, 13);
      this.NameLabel.TabIndex = 15;
      this.NameLabel.Text = "Name:";
      // 
      // PhotoPath
      // 
      this.PhotoPath.AutoSize = true;
      this.PhotoPath.Location = new System.Drawing.Point(224, 17);
      this.PhotoPath.Name = "PhotoPath";
      this.PhotoPath.Size = new System.Drawing.Size(26, 13);
      this.PhotoPath.TabIndex = 14;
      this.PhotoPath.Text = "File:";
      // 
      // PhotoBtn
      // 
      this.PhotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PhotoBtn.Location = new System.Drawing.Point(84, 12);
      this.PhotoBtn.Name = "PhotoBtn";
      this.PhotoBtn.Size = new System.Drawing.Size(121, 23);
      this.PhotoBtn.TabIndex = 13;
      this.PhotoBtn.Text = "Select file";
      this.PhotoBtn.UseVisualStyleBackColor = true;
      this.PhotoBtn.Click += new System.EventHandler(this.PhotoBtn_Click);
      // 
      // PhotoLabel
      // 
      this.PhotoLabel.AutoSize = true;
      this.PhotoLabel.Location = new System.Drawing.Point(22, 17);
      this.PhotoLabel.Name = "PhotoLabel";
      this.PhotoLabel.Size = new System.Drawing.Size(38, 13);
      this.PhotoLabel.TabIndex = 12;
      this.PhotoLabel.Text = "Photo:";
      // 
      // OpenFile
      // 
      this.OpenFile.FileName = "OpenFile";
      // 
      // EditForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.UpdateBtn);
      this.Controls.Add(this.DescriptionData);
      this.Controls.Add(this.DescriptionLabel);
      this.Controls.Add(this.LocationData);
      this.Controls.Add(this.LocationLabel);
      this.Controls.Add(this.TypeData);
      this.Controls.Add(this.NameData);
      this.Controls.Add(this.TypeLabel);
      this.Controls.Add(this.NameLabel);
      this.Controls.Add(this.PhotoPath);
      this.Controls.Add(this.PhotoBtn);
      this.Controls.Add(this.PhotoLabel);
      this.MaximizeBox = false;
      this.Name = "EditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Edit";
      this.Load += new System.EventHandler(this.EditForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button UpdateBtn;
    private System.Windows.Forms.RichTextBox DescriptionData;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.TextBox LocationData;
    private System.Windows.Forms.Label LocationLabel;
    private System.Windows.Forms.ComboBox TypeData;
    private System.Windows.Forms.TextBox NameData;
    private System.Windows.Forms.Label TypeLabel;
    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.Label PhotoPath;
    private System.Windows.Forms.Button PhotoBtn;
    private System.Windows.Forms.Label PhotoLabel;
    private System.Windows.Forms.OpenFileDialog OpenFile;
  }
}