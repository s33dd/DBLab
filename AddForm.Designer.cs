namespace DBLab {
  partial class AddForm {
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
      this.PhotoLabel = new System.Windows.Forms.Label();
      this.PhotoBtn = new System.Windows.Forms.Button();
      this.PhotoPath = new System.Windows.Forms.Label();
      this.NameLabel = new System.Windows.Forms.Label();
      this.TypeLabel = new System.Windows.Forms.Label();
      this.NameData = new System.Windows.Forms.TextBox();
      this.TypeData = new System.Windows.Forms.ComboBox();
      this.LocationLabel = new System.Windows.Forms.Label();
      this.LocationData = new System.Windows.Forms.TextBox();
      this.DescriptionLabel = new System.Windows.Forms.Label();
      this.DescriptionData = new System.Windows.Forms.RichTextBox();
      this.AddBtn = new System.Windows.Forms.Button();
      this.OpenFile = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // PhotoLabel
      // 
      this.PhotoLabel.AutoSize = true;
      this.PhotoLabel.Location = new System.Drawing.Point(12, 27);
      this.PhotoLabel.Name = "PhotoLabel";
      this.PhotoLabel.Size = new System.Drawing.Size(38, 13);
      this.PhotoLabel.TabIndex = 0;
      this.PhotoLabel.Text = "Photo:";
      // 
      // PhotoBtn
      // 
      this.PhotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PhotoBtn.Location = new System.Drawing.Point(74, 22);
      this.PhotoBtn.Name = "PhotoBtn";
      this.PhotoBtn.Size = new System.Drawing.Size(121, 23);
      this.PhotoBtn.TabIndex = 1;
      this.PhotoBtn.Text = "Select file";
      this.PhotoBtn.UseVisualStyleBackColor = true;
      this.PhotoBtn.Click += new System.EventHandler(this.PhotoBtn_Click);
      // 
      // PhotoPath
      // 
      this.PhotoPath.AutoSize = true;
      this.PhotoPath.Location = new System.Drawing.Point(214, 27);
      this.PhotoPath.Name = "PhotoPath";
      this.PhotoPath.Size = new System.Drawing.Size(26, 13);
      this.PhotoPath.TabIndex = 2;
      this.PhotoPath.Text = "File:";
      // 
      // NameLabel
      // 
      this.NameLabel.AutoSize = true;
      this.NameLabel.Location = new System.Drawing.Point(12, 71);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.Size = new System.Drawing.Size(38, 13);
      this.NameLabel.TabIndex = 3;
      this.NameLabel.Text = "Name:";
      // 
      // TypeLabel
      // 
      this.TypeLabel.AutoSize = true;
      this.TypeLabel.Location = new System.Drawing.Point(12, 118);
      this.TypeLabel.Name = "TypeLabel";
      this.TypeLabel.Size = new System.Drawing.Size(34, 13);
      this.TypeLabel.TabIndex = 4;
      this.TypeLabel.Text = "Type:";
      // 
      // NameData
      // 
      this.NameData.Location = new System.Drawing.Point(74, 68);
      this.NameData.Name = "NameData";
      this.NameData.Size = new System.Drawing.Size(121, 20);
      this.NameData.TabIndex = 5;
      // 
      // TypeData
      // 
      this.TypeData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.TypeData.FormattingEnabled = true;
      this.TypeData.Items.AddRange(new object[] {
            "Galaxy",
            "Star",
            "Planet",
            "Asteroid",
            "Space body"});
      this.TypeData.Location = new System.Drawing.Point(74, 115);
      this.TypeData.Name = "TypeData";
      this.TypeData.Size = new System.Drawing.Size(121, 21);
      this.TypeData.TabIndex = 6;
      // 
      // LocationLabel
      // 
      this.LocationLabel.AutoSize = true;
      this.LocationLabel.Location = new System.Drawing.Point(12, 166);
      this.LocationLabel.Name = "LocationLabel";
      this.LocationLabel.Size = new System.Drawing.Size(51, 13);
      this.LocationLabel.TabIndex = 7;
      this.LocationLabel.Text = "Location:";
      // 
      // LocationData
      // 
      this.LocationData.Location = new System.Drawing.Point(74, 163);
      this.LocationData.Name = "LocationData";
      this.LocationData.Size = new System.Drawing.Size(121, 20);
      this.LocationData.TabIndex = 8;
      // 
      // DescriptionLabel
      // 
      this.DescriptionLabel.AutoSize = true;
      this.DescriptionLabel.Location = new System.Drawing.Point(12, 216);
      this.DescriptionLabel.Name = "DescriptionLabel";
      this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
      this.DescriptionLabel.TabIndex = 9;
      this.DescriptionLabel.Text = "Description:";
      // 
      // DescriptionData
      // 
      this.DescriptionData.Location = new System.Drawing.Point(74, 216);
      this.DescriptionData.Name = "DescriptionData";
      this.DescriptionData.Size = new System.Drawing.Size(695, 159);
      this.DescriptionData.TabIndex = 10;
      this.DescriptionData.Text = "";
      // 
      // AddBtn
      // 
      this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddBtn.Location = new System.Drawing.Point(310, 405);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(166, 44);
      this.AddBtn.TabIndex = 11;
      this.AddBtn.Text = "Add object";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // OpenFile
      // 
      this.OpenFile.FileName = "OpenFile";
      // 
      // AddForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(781, 495);
      this.Controls.Add(this.AddBtn);
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
      this.Name = "AddForm";
      this.Text = "Add object";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label PhotoLabel;
    private System.Windows.Forms.Button PhotoBtn;
    private System.Windows.Forms.Label PhotoPath;
    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.Label TypeLabel;
    private System.Windows.Forms.TextBox NameData;
    private System.Windows.Forms.ComboBox TypeData;
    private System.Windows.Forms.Label LocationLabel;
    private System.Windows.Forms.TextBox LocationData;
    private System.Windows.Forms.Label DescriptionLabel;
    private System.Windows.Forms.RichTextBox DescriptionData;
    private System.Windows.Forms.Button AddBtn;
    private System.Windows.Forms.OpenFileDialog OpenFile;
  }
}