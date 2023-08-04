// Decompiled with JetBrains decompiler
// Type: BK_Viewer.My.MySettings
// Assembly: BK_Viewer, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: ADE61EBF-8BD6-4B49-8807-0356A6D4EFA6
// Assembly location: C:\Users\zelda\OneDrive\Desktop\BottlesGlasses_0.8\BK_Viewer.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BK_Viewer.My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  [CompilerGenerated]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
    private static bool addedHandler;

    public static MySettings Default
    {
      get
      {
        if (!MySettings.addedHandler)
        {
          object handlerLockObject = MySettings.addedHandlerLockObject;
          ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
          Monitor.Enter(handlerLockObject);
          try
          {
            if (!MySettings.addedHandler)
            {
              MyProject.Application.Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!MyProject.Application.SaveMySettingsOnExit)
                  return;
                MySettingsProperty.Settings.Save();
              });
              MySettings.addedHandler = true;
            }
          }
          finally
          {
            Monitor.Exit(handlerLockObject);
          }
        }
        return MySettings.defaultInstance;
      }
    }

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    [DebuggerNonUserCode]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!MyProject.Application.SaveMySettingsOnExit)
        return;
      MySettingsProperty.Settings.Save();
    }
  }
}
