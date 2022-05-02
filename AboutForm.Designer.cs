namespace DBLab {
  partial class AboutForm {
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
      this.AgreeBtn = new System.Windows.Forms.Button();
      this.AboutMsg = new System.Windows.Forms.Label();
      this.NotShowingChkbx = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // AgreeBtn
      // 
      this.AgreeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.AgreeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.AgreeBtn.Location = new System.Drawing.Point(71, 126);
      this.AgreeBtn.Name = "AgreeBtn";
      this.AgreeBtn.Size = new System.Drawing.Size(64, 20);
      this.AgreeBtn.TabIndex = 0;
      this.AgreeBtn.Text = "OK";
      this.AgreeBtn.UseVisualStyleBackColor = true;
      this.AgreeBtn.Click += new System.EventHandler(this.AgreeBtn_Click);
      // 
      // AboutMsg
      // 
      this.AboutMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.AboutMsg.AutoSize = true;
      this.AboutMsg.Location = new System.Drawing.Point(41, 24);
      this.AboutMsg.Name = "AboutMsg";
      this.AboutMsg.Size = new System.Drawing.Size(132, 52);
      this.AboutMsg.TabIndex = 1;
      this.AboutMsg.Text = "Program was made by \r\nSukhoverikov Denis\r\nstudent of the 403th group\r\nvar 6 \"Spac" +
    "e objects\".";
      this.AboutMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // NotShowingChkbx
      // 
      this.NotShowingChkbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.NotShowingChkbx.AutoSize = true;
      this.NotShowingChkbx.Location = new System.Drawing.Point(53, 94);
      this.NotShowingChkbx.Name = "NotShowingChkbx";
      this.NotShowingChkbx.Size = new System.Drawing.Size(100, 17);
      this.NotShowingChkbx.TabIndex = 2;
      this.NotShowingChkbx.Text = "Not show again";
      this.NotShowingChkbx.UseVisualStyleBackColor = true;
      // 
      // AboutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(209, 156);
      this.Controls.Add(this.NotShowingChkbx);
      this.Controls.Add(this.AboutMsg);
      this.Controls.Add(this.AgreeBtn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutForm_FormClosed);
      this.Load += new System.EventHandler(this.AboutForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button AgreeBtn;
    private System.Windows.Forms.Label AboutMsg;
    private System.Windows.Forms.CheckBox NotShowingChkbx;
  }
}