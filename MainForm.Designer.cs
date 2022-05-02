﻿namespace DBLab {
  partial class MainForm {
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
      this.MenuStrip = new System.Windows.Forms.MenuStrip();
      this.BaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AddObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.SaveListOfObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ObjectList = new System.Windows.Forms.TableLayoutPanel();
      this.MenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // MenuStrip
      // 
      this.MenuStrip.BackColor = System.Drawing.SystemColors.HighlightText;
      this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseToolStripMenuItem,
            this.AboutToolStripMenuItem});
      this.MenuStrip.Location = new System.Drawing.Point(0, 0);
      this.MenuStrip.Name = "MenuStrip";
      this.MenuStrip.Size = new System.Drawing.Size(783, 24);
      this.MenuStrip.TabIndex = 0;
      // 
      // BaseToolStripMenuItem
      // 
      this.BaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddObjectToolStripMenuItem,
            this.SaveListOfObjectsToolStripMenuItem});
      this.BaseToolStripMenuItem.Name = "BaseToolStripMenuItem";
      this.BaseToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.BaseToolStripMenuItem.Text = "Base";
      // 
      // AddObjectToolStripMenuItem
      // 
      this.AddObjectToolStripMenuItem.Name = "AddObjectToolStripMenuItem";
      this.AddObjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.AddObjectToolStripMenuItem.Text = "Add object";
      // 
      // SaveListOfObjectsToolStripMenuItem
      // 
      this.SaveListOfObjectsToolStripMenuItem.Name = "SaveListOfObjectsToolStripMenuItem";
      this.SaveListOfObjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.SaveListOfObjectsToolStripMenuItem.Text = "Save list of objects";
      // 
      // AboutToolStripMenuItem
      // 
      this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
      this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.AboutToolStripMenuItem.Text = "About";
      this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // ObjectList
      // 
      this.ObjectList.AutoScroll = true;
      this.ObjectList.AutoSize = true;
      this.ObjectList.ColumnCount = 3;
      this.ObjectList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.ObjectList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.ObjectList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.ObjectList.Location = new System.Drawing.Point(12, 27);
      this.ObjectList.Name = "ObjectList";
      this.ObjectList.RowCount = 1;
      this.ObjectList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.ObjectList.Size = new System.Drawing.Size(764, 41);
      this.ObjectList.TabIndex = 1;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoScrollMinSize = new System.Drawing.Size(0, 489);
      this.BackColor = System.Drawing.SystemColors.HighlightText;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ObjectList);
      this.Controls.Add(this.MenuStrip);
      this.MainMenuStrip = this.MenuStrip;
      this.Name = "MainForm";
      this.Text = "DBLab";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.MenuStrip.ResumeLayout(false);
      this.MenuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MenuStrip;
    private System.Windows.Forms.ToolStripMenuItem BaseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AddObjectToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem SaveListOfObjectsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    private System.Windows.Forms.TableLayoutPanel ObjectList;
  }
}

