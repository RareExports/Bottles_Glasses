// Decompiled with JetBrains decompiler
// Type: BK_Viewer.My.MyApplication
// Assembly: BK_Viewer, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: ADE61EBF-8BD6-4B49-8807-0356A6D4EFA6
// Assembly location: C:\Users\zelda\OneDrive\Desktop\BottlesGlasses_0.8\BK_Viewer.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace BK_Viewer.My
{
  [GeneratedCode("MyTemplate", "8.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class MyApplication : WindowsFormsApplicationBase
  {
    [DebuggerStepThrough]
    public MyApplication()
      : base(AuthenticationMode.Windows)
    {
      this.IsSingleInstance = false;
      this.EnableVisualStyles = true;
      this.SaveMySettingsOnExit = true;
      this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerHidden]
    [STAThread]
    internal static void Main(string[] Args)
    {
      try
      {
        Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
      }
      finally
      {
      }
      MyProject.Application.Run(Args);
    }

    [DebuggerStepThrough]
    protected override void OnCreateMainForm()
    {
      this.MainForm = (Form) MyProject.Forms.Main;
    }
  }
}
