// Decompiled with JetBrains decompiler
// Type: BK_Viewer.Functions
// Assembly: BK_Viewer, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: ADE61EBF-8BD6-4B49-8807-0356A6D4EFA6
// Assembly location: C:\Users\zelda\OneDrive\Desktop\BottlesGlasses_0.8\BK_Viewer.exe

using BK_Viewer.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.IO;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace BK_Viewer
{
  [StandardModule]
  internal sealed class Functions
  {
    public static INIFile BKmodelini = new INIFile(Application.StartupPath + "\\misc\\BKmodels.ini");
    public static INIFile BTmodelini = new INIFile(Application.StartupPath + "\\misc\\BTmodels.ini");
    public static string CurrModel = "";
    public static string BKModelDir = "";
    public static string BTModelDir = "";
    public static string DKModelDir = "";
    public static int Game = 0;

    public static object GLPrint(string GLText, double XPos, double YPos, double ZPos)
    {
      Gl.glMatrixMode(5889);
      Gl.glPushMatrix();
      Gl.glLoadIdentity();
      Gl.glOrtho(0.0, (double) MyProject.Forms.Main.SimpleOpenGlControl1.Width, 0.0, (double) MyProject.Forms.Main.SimpleOpenGlControl1.Height, -1.0, 1.0);
      Gl.glMatrixMode(5888);
      Gl.glPushMatrix();
      Gl.glLoadIdentity();
      Gl.glColor3f(1f, 1f, 1f);
      Gl.glRasterPos3f((float) XPos, (float) MyProject.Forms.Main.SimpleOpenGlControl1.Height - (float) YPos, (float) ZPos);
      int num1 = 0;
      int num2 = GLText.Length - 1;
      for (int index = num1; index <= num2; ++index)
        Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_TIMES_ROMAN_24, Strings.Asc(GLText[index]));
      Gl.glMatrixMode(5889);
      Gl.glPopMatrix();
      Gl.glMatrixMode(5888);
      Gl.glPopMatrix();
      Gl.glEnable(2929);
      return (object) 0;
    }

    public static uint _ShiftR(uint v, uint s, uint w)
    {
      return (uint) ((ulong) (v >> (int) s) & (ulong) ((1 << (int) w) - 1));
    }

    private static uint _ShiftL(uint v, uint s, uint w)
    {
      return (uint) ((ulong) v & (ulong) ((1 << (int) w) - 1 << (int) s));
    }

    public static string GetFileName(string flname)
    {
      int num1 = 1;
      int num2 = Strings.Len(flname);
      int num3;
      for (int Start = num1; Start <= num2; ++Start)
      {
        if (Operators.CompareString(Strings.Mid(flname, Start, 1), "\\", false) == 0)
          num3 = Start;
      }
      return Strings.Right(flname, Strings.Len(flname) - num3);
    }

    public static string NoExt(string FullPath)
    {
      return Path.GetFileNameWithoutExtension(FullPath);
    }
  }
}
