// Decompiled with JetBrains decompiler
// Type: BK_Viewer.RenameFileDescription
// Assembly: BK_Viewer, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: ADE61EBF-8BD6-4B49-8807-0356A6D4EFA6
// Assembly location: C:\Users\zelda\OneDrive\Desktop\BottlesGlasses_0.8\BK_Viewer.exe

using BK_Viewer.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BK_Viewer
{
  [DesignerGenerated]
  public class RenameFileDescription : Form
  {
    private IContainer components;
    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;
    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    internal virtual Button OK_Button
    {
      [DebuggerNonUserCode] get
      {
        return this._OK_Button;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
        if (this._OK_Button != null)
          this._OK_Button.Click -= eventHandler;
        this._OK_Button = value;
        if (this._OK_Button == null)
          return;
        this._OK_Button.Click += eventHandler;
      }
    }

    internal virtual Button Cancel_Button
    {
      [DebuggerNonUserCode] get
      {
        return this._Cancel_Button;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
        if (this._Cancel_Button != null)
          this._Cancel_Button.Click -= eventHandler;
        this._Cancel_Button = value;
        if (this._Cancel_Button == null)
          return;
        this._Cancel_Button.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox1
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox1 = value;
      }
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get
      {
        return this._Label1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    [DebuggerNonUserCode]
    public RenameFileDescription()
    {
      this.Load += new EventHandler(this.RenameFileDescription_Load);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.OK_Button = new Button();
      this.Cancel_Button = new Button();
      this.TextBox1 = new TextBox();
      this.Label1 = new Label();
      this.SuspendLayout();
      this.OK_Button.Anchor = AnchorStyles.None;
      Button okButton1 = this.OK_Button;
      Point point1 = new Point(87, 63);
      Point point2 = point1;
      okButton1.Location = point2;
      this.OK_Button.Name = "OK_Button";
      Button okButton2 = this.OK_Button;
      Size size1 = new Size(67, 23);
      Size size2 = size1;
      okButton2.Size = size2;
      this.OK_Button.TabIndex = 0;
      this.OK_Button.Text = "OK";
      this.Cancel_Button.Anchor = AnchorStyles.None;
      this.Cancel_Button.DialogResult = DialogResult.Cancel;
      Button cancelButton1 = this.Cancel_Button;
      point1 = new Point(160, 63);
      Point point3 = point1;
      cancelButton1.Location = point3;
      this.Cancel_Button.Name = "Cancel_Button";
      Button cancelButton2 = this.Cancel_Button;
      size1 = new Size(67, 23);
      Size size3 = size1;
      cancelButton2.Size = size3;
      this.Cancel_Button.TabIndex = 1;
      this.Cancel_Button.Text = "Cancel";
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(12, 27);
      Point point4 = point1;
      textBox1_1.Location = point4;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(215, 20);
      Size size4 = size1;
      textBox1_2.Size = size4;
      this.TextBox1.TabIndex = 1;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(9, 11);
      Point point5 = point1;
      label1_1.Location = point5;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(83, 13);
      Size size5 = size1;
      label1_2.Size = size5;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "New description";
      this.AcceptButton = (IButtonControl) this.OK_Button;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Cancel_Button;
      size1 = new Size(239, 102);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.OK_Button);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.Cancel_Button);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "RenameFileDescription";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Rename File Description";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.TextBox1.Text, "", false) != 0)
      {
        switch (Functions.Game)
        {
          case 0:
            Functions.BKmodelini.WriteString("models", Functions.NoExt(Functions.CurrModel), this.TextBox1.Text);
            break;
          case 1:
            Functions.BTmodelini.WriteString("models", Functions.NoExt(Functions.CurrModel), this.TextBox1.Text);
            break;
        }
        if (MyProject.Forms.Main.TreeView1.SelectedNodes.Count > 0 && Operators.CompareString(MyProject.Forms.Main.TreeView1.SelectedNodes[0].Text, MyProject.Forms.Main.FileTree.SelectedNodes[0].Text, false) == 0)
          MyProject.Forms.Main.TreeView1.SelectedNodes[0].Text = this.TextBox1.Text;
        MyProject.Forms.Main.FileTree.SelectedNodes[0].Text = this.TextBox1.Text;
      }
      else
      {
        switch (Functions.Game)
        {
          case 0:
            Functions.BKmodelini.WriteString("models", Functions.NoExt(Functions.CurrModel), Functions.CurrModel);
            break;
          case 1:
            Functions.BTmodelini.WriteString("models", Functions.NoExt(Functions.CurrModel), Functions.CurrModel);
            break;
        }
        if (MyProject.Forms.Main.TreeView1.SelectedNodes.Count > 0 && Operators.CompareString(MyProject.Forms.Main.TreeView1.SelectedNodes[0].Text, MyProject.Forms.Main.FileTree.SelectedNodes[0].Text, false) == 0)
          MyProject.Forms.Main.TreeView1.SelectedNodes[0].Text = Functions.CurrModel;
        MyProject.Forms.Main.FileTree.SelectedNodes[0].Text = Functions.CurrModel;
      }
      this.Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void RenameFileDescription_Load(object sender, EventArgs e)
    {
      switch (Functions.Game)
      {
        case 0:
          this.TextBox1.Text = Functions.BKmodelini.GetString("models", Functions.NoExt(Functions.CurrModel), (string) null);
          break;
        case 1:
          this.TextBox1.Text = Functions.BTmodelini.GetString("models", Functions.NoExt(Functions.CurrModel), (string) null);
          break;
      }
    }
  }
}
