// Decompiled with JetBrains decompiler
// Type: BK_Viewer.GettingStarted
// Assembly: BK_Viewer, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: ADE61EBF-8BD6-4B49-8807-0356A6D4EFA6
// Assembly location: C:\Users\zelda\OneDrive\Desktop\BottlesGlasses_0.8\BK_Viewer.exe

using BK_Viewer.My;
using Microsoft.VisualBasic;
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
  public class GettingStarted : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("RadioButton1")]
    private RadioButton _RadioButton1;
    [AccessedThroughProperty("RadioButton2")]
    private RadioButton _RadioButton2;

    internal virtual Button Button1
    {
      [DebuggerNonUserCode] get
      {
        return this._Button1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      [DebuggerNonUserCode] get
      {
        return this._GroupBox1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox1 = value;
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

    internal virtual GroupBox GroupBox2
    {
      [DebuggerNonUserCode] get
      {
        return this._GroupBox2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GroupBox2 = value;
      }
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get
      {
        return this._Label2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual Button Button2
    {
      [DebuggerNonUserCode] get
      {
        return this._Button2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button2 != null)
          this._Button2.Click -= eventHandler;
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += eventHandler;
      }
    }

    internal virtual Button Button3
    {
      [DebuggerNonUserCode] get
      {
        return this._Button3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._Button3 != null)
          this._Button3.Click -= eventHandler;
        this._Button3 = value;
        if (this._Button3 == null)
          return;
        this._Button3.Click += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton1
    {
      [DebuggerNonUserCode] get
      {
        return this._RadioButton1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton1_CheckedChanged);
        if (this._RadioButton1 != null)
          this._RadioButton1.CheckedChanged -= eventHandler;
        this._RadioButton1 = value;
        if (this._RadioButton1 == null)
          return;
        this._RadioButton1.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton2
    {
      [DebuggerNonUserCode] get
      {
        return this._RadioButton2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton2_CheckedChanged);
        if (this._RadioButton2 != null)
          this._RadioButton2.CheckedChanged -= eventHandler;
        this._RadioButton2 = value;
        if (this._RadioButton2 == null)
          return;
        this._RadioButton2.CheckedChanged += eventHandler;
      }
    }

    [DebuggerNonUserCode]
    public GettingStarted()
    {
      this.Load += new EventHandler(this.Dialog1_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GettingStarted));
      this.Button1 = new Button();
      this.GroupBox1 = new GroupBox();
      this.Label1 = new Label();
      this.GroupBox2 = new GroupBox();
      this.RadioButton2 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.Label2 = new Label();
      this.Button2 = new Button();
      this.Button3 = new Button();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      Button button1_1 = this.Button1;
      Point point1 = new Point(126, 213);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(188, 23);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Launch &Decompressor";
      this.Button1.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.Button1);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(12, 12);
      Point point3 = point1;
      groupBox1_1.Location = point3;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(329, 253);
      Size size3 = size1;
      groupBox1_2.Size = size3;
      this.GroupBox1.TabIndex = 1;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Step 1";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(6, 29);
      Point point4 = point1;
      label1_1.Location = point4;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(297, 143);
      Size size4 = size1;
      label1_2.Size = size4;
      this.Label1.TabIndex = 1;
      this.Label1.Text = componentResourceManager.GetString("Label1.Text");
      this.GroupBox2.Controls.Add((Control) this.RadioButton2);
      this.GroupBox2.Controls.Add((Control) this.RadioButton1);
      this.GroupBox2.Controls.Add((Control) this.Label2);
      this.GroupBox2.Controls.Add((Control) this.Button2);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(347, 12);
      Point point5 = point1;
      groupBox2_1.Location = point5;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(353, 253);
      Size size5 = size1;
      groupBox2_2.Size = size5;
      this.GroupBox2.TabIndex = 2;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Step 2";
      this.RadioButton2.AutoSize = true;
      RadioButton radioButton2_1 = this.RadioButton2;
      point1 = new Point(9, 205);
      Point point6 = point1;
      radioButton2_1.Location = point6;
      this.RadioButton2.Name = "RadioButton2";
      RadioButton radioButton2_2 = this.RadioButton2;
      size1 = new Size(82, 17);
      Size size6 = size1;
      radioButton2_2.Size = size6;
      this.RadioButton2.TabIndex = 5;
      this.RadioButton2.Text = "Banjo-Tooie";
      this.RadioButton2.UseVisualStyleBackColor = true;
      this.RadioButton1.AutoSize = true;
      this.RadioButton1.Checked = true;
      RadioButton radioButton1_1 = this.RadioButton1;
      point1 = new Point(9, 186);
      Point point7 = point1;
      radioButton1_1.Location = point7;
      this.RadioButton1.Name = "RadioButton1";
      RadioButton radioButton1_2 = this.RadioButton1;
      size1 = new Size(93, 17);
      Size size7 = size1;
      radioButton1_2.Size = size7;
      this.RadioButton1.TabIndex = 4;
      this.RadioButton1.TabStop = true;
      this.RadioButton1.Text = "Banjo-Kazooie";
      this.RadioButton1.UseVisualStyleBackColor = true;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(6, 29);
      Point point8 = point1;
      label2_1.Location = point8;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(331, 117);
      Size size8 = size1;
      label2_2.Size = size8;
      this.Label2.TabIndex = 1;
      this.Label2.Text = componentResourceManager.GetString("Label2.Text");
      Button button2_1 = this.Button2;
      point1 = new Point(149, 213);
      Point point9 = point1;
      button2_1.Location = point9;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(188, 23);
      Size size9 = size1;
      button2_2.Size = size9;
      this.Button2.TabIndex = 0;
      this.Button2.Text = "Launch &Model Isolator";
      this.Button2.UseVisualStyleBackColor = true;
      Button button3_1 = this.Button3;
      point1 = new Point(625, 282);
      Point point10 = point1;
      button3_1.Location = point10;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(75, 23);
      Size size10 = size1;
      button3_2.Size = size10;
      this.Button3.TabIndex = 3;
      this.Button3.Text = "&Exit";
      this.Button3.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(712, 317);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "GettingStarted";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Getting started - Bottles' Glasses BK/BT Model Viewer & Ripper";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Main.IsolateFiles(Functions.Game);
    }

    private void Dialog1_Load(object sender, EventArgs e)
    {
      Functions.Game = 0;
    }

    private void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
      Functions.Game = 0;
    }

    private void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
      Functions.Game = 1;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      try
      {
        Process.Start(Application.StartupPath + "\\misc\\GEDecompressor.exe");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Couldn't find 'GEDecompressor.exe' in 'misc'!", MsgBoxStyle.Critical, (object) "Error");
        ProjectData.ClearProjectError();
      }
    }
  }
}
