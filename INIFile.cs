// Decompiled with JetBrains decompiler
// Type: BK_Viewer.INIFile
// Assembly: BK_Viewer, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: ADE61EBF-8BD6-4B49-8807-0356A6D4EFA6
// Assembly location: C:\Users\zelda\OneDrive\Desktop\BottlesGlasses_0.8\BK_Viewer.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace BK_Viewer
{
  public class INIFile
  {
    private string strFilename;

    public string FileName
    {
      get
      {
        return this.strFilename;
      }
    }

    public INIFile(string Filename)
    {
      this.strFilename = Filename;
    }

    [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetPrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, StringBuilder lpReturnedString, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int WritePrivateProfileString([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileIntA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int GetPrivateProfileInt([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, int nDefault, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    private static extern int FlushPrivateProfileString(int lpApplicationName, int lpKeyName, int lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    public string GetString(string Section, string Key, string Default)
    {
      StringBuilder lpReturnedString = new StringBuilder(256);
      int privateProfileString = INIFile.GetPrivateProfileString(ref Section, ref Key, ref Default, lpReturnedString, lpReturnedString.Capacity, ref this.strFilename);
      return privateProfileString <= 0 ? "" : Strings.Left(lpReturnedString.ToString(), privateProfileString);
    }

    public int GetInteger(string Section, string Key, int Default)
    {
      return INIFile.GetPrivateProfileInt(ref Section, ref Key, Default, ref this.strFilename);
    }

    public bool GetBoolean(string Section, string Key, bool Default)
    {
      return INIFile.GetPrivateProfileInt(ref Section, ref Key, -(Default ? 1 : 0), ref this.strFilename) == 1;
    }

    public void WriteString(string Section, string Key, string Value)
    {
      INIFile.WritePrivateProfileString(ref Section, ref Key, ref Value, ref this.strFilename);
      this.Flush();
    }

    public void WriteInteger(string Section, string Key, int Value)
    {
      this.WriteString(Section, Key, Conversions.ToString(Value));
      this.Flush();
    }

    public void WriteBoolean(string Section, string Key, bool Value)
    {
      this.WriteString(Section, Key, Conversions.ToString(-(Value ? 1 : 0)));
      this.Flush();
    }

    private void Flush()
    {
      INIFile.FlushPrivateProfileString(0, 0, 0, ref this.strFilename);
    }
  }
}
