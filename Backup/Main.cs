// Decompiled with JetBrains decompiler
// Type: BK_Viewer.Main
// Assembly: BK_Viewer, Version=0.0.8.0, Culture=neutral, PublicKeyToken=null
// MVID: ADE61EBF-8BD6-4B49-8807-0356A6D4EFA6
// Assembly location: C:\Users\zelda\OneDrive\Desktop\BottlesGlasses_0.8\BK_Viewer.exe

using BK_Viewer.My;
using CodersLab.Windows.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Tao.DevIl;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace BK_Viewer
{
  [DesignerGenerated]
  public class Main : Form
  {
    [AccessedThroughProperty("FileToolStripMenuItem")]
    private ToolStripMenuItem _FileToolStripMenuItem;
    [AccessedThroughProperty("MenuStrip")]
    private MenuStrip _MenuStrip;
    [AccessedThroughProperty("OptionsToolStripMenuItem")]
    private ToolStripMenuItem _OptionsToolStripMenuItem;
    [AccessedThroughProperty("StatusStrip")]
    private StatusStrip _StatusStrip;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("InputFolderBrowser")]
    private FolderBrowserDialog _InputFolderBrowser;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("CameraSensitivityScroll")]
    private TrackBar _CameraSensitivityScroll;
    [AccessedThroughProperty("ToolsToolStripMenuItem")]
    private ToolStripMenuItem _ToolsToolStripMenuItem;
    [AccessedThroughProperty("OutputFolderBrowser")]
    private FolderBrowserDialog _OutputFolderBrowser;
    [AccessedThroughProperty("RAREDecompressorSubDragRWPToolStripMenuItem")]
    private ToolStripMenuItem _RAREDecompressorSubDragRWPToolStripMenuItem;
    [AccessedThroughProperty("LoadGraphicsToolStripMenuItem")]
    private ToolStripMenuItem _LoadGraphicsToolStripMenuItem;
    [AccessedThroughProperty("QuitToolStripMenuItem")]
    private ToolStripMenuItem _QuitToolStripMenuItem;
    [AccessedThroughProperty("SimpleOpenGlControl1")]
    private SimpleOpenGlControl _SimpleOpenGlControl1;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _TabPage1;
    [AccessedThroughProperty("ModelFolderDialog")]
    private FolderBrowserDialog _ModelFolderDialog;
    [AccessedThroughProperty("ObjectIsolatorToolStripMenuItem")]
    private ToolStripMenuItem _ObjectIsolatorToolStripMenuItem;
    [AccessedThroughProperty("FileTreeContextMenu")]
    private ContextMenuStrip _FileTreeContextMenu;
    [AccessedThroughProperty("ToolStripMenuItem2")]
    private ToolStripMenuItem _ToolStripMenuItem2;
    [AccessedThroughProperty("ExportWavefrontModelToolStripMenuItem")]
    private ToolStripMenuItem _ExportWavefrontModelToolStripMenuItem;
    [AccessedThroughProperty("SaveOBJ")]
    private SaveFileDialog _SaveOBJ;
    [AccessedThroughProperty("OpenTexture")]
    private OpenFileDialog _OpenTexture;
    [AccessedThroughProperty("GameToolStripMenuItem")]
    private ToolStripMenuItem _GameToolStripMenuItem;
    [AccessedThroughProperty("BanjoKazooieToolStripMenuItem")]
    private ToolStripMenuItem _BanjoKazooieToolStripMenuItem;
    [AccessedThroughProperty("BanjoTooieToolStripMenuItem")]
    private ToolStripMenuItem _BanjoTooieToolStripMenuItem;
    [AccessedThroughProperty("GameStatus")]
    private ToolStripStatusLabel _GameStatus;
    [AccessedThroughProperty("BanjoKazooieToolStripMenuItem1")]
    private ToolStripMenuItem _BanjoKazooieToolStripMenuItem1;
    [AccessedThroughProperty("BanjoTooieToolStripMenuItem1")]
    private ToolStripMenuItem _BanjoTooieToolStripMenuItem1;
    [AccessedThroughProperty("ResetToolStripMenuItem")]
    private ToolStripMenuItem _ResetToolStripMenuItem;
    [AccessedThroughProperty("InvertYAxisToolStripMenuItem")]
    private ToolStripMenuItem _InvertYAxisToolStripMenuItem;
    [AccessedThroughProperty("CaptureScreenshotToolStripMenuItem")]
    private ToolStripMenuItem _CaptureScreenshotToolStripMenuItem;
    [AccessedThroughProperty("SaveScreenPNG")]
    private SaveFileDialog _SaveScreenPNG;
    [AccessedThroughProperty("RenameToolStripMenuItem")]
    private ToolStripMenuItem _RenameToolStripMenuItem;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("TreeView1")]
    private CodersLab.Windows.Controls.TreeView _TreeView1;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("DonkeyKong64ToolStripMenuItem")]
    private ToolStripMenuItem _DonkeyKong64ToolStripMenuItem;
    [AccessedThroughProperty("DonkeyKong64ToolStripMenuItem1")]
    private ToolStripMenuItem _DonkeyKong64ToolStripMenuItem1;
    [AccessedThroughProperty("FileTree")]
    private CodersLab.Windows.Controls.TreeView _FileTree;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("ToolStrip")]
    private ToolStrip _ToolStrip;
    [AccessedThroughProperty("Rotate90Left")]
    private ToolStripButton _Rotate90Left;
    [AccessedThroughProperty("Rotate90Right")]
    private ToolStripButton _Rotate90Right;
    [AccessedThroughProperty("Rotate90Up")]
    private ToolStripButton _Rotate90Up;
    [AccessedThroughProperty("Rotate90Down")]
    private ToolStripButton _Rotate90Down;
    [AccessedThroughProperty("ToolStripSeparator1")]
    private ToolStripSeparator _ToolStripSeparator1;
    [AccessedThroughProperty("RotateTimer")]
    private Timer _RotateTimer;
    [AccessedThroughProperty("ToggleTextureButton")]
    private ToolStripButton _ToggleTextureButton;
    [AccessedThroughProperty("AxisMarkerToggle")]
    private ToolStripButton _AxisMarkerToggle;
    [AccessedThroughProperty("ToolStripSeparator2")]
    private ToolStripSeparator _ToolStripSeparator2;
    [AccessedThroughProperty("ToolStripSeparator3")]
    private ToolStripSeparator _ToolStripSeparator3;
    [AccessedThroughProperty("ToggleWireframeButton")]
    private ToolStripButton _ToggleWireframeButton;
    [AccessedThroughProperty("AssociateFilesWithWindowsToolStripMenuItem")]
    private ToolStripMenuItem _AssociateFilesWithWindowsToolStripMenuItem;
    private IContainer components;
    private int rottype;
    private int rotcoef;
    private Main.TexBuffer[] Textures;
    private byte[] MTexBuffer;
    private FileStream CurrFileStream;
    private Main.Collision CollisionVerts;
    private Main.CollisionTris CollisionTriangles;
    private uint GEOMODE;
    private ArrayList SearchFound;
    private int FindTracker;
    private int oldFindTracker;
    private bool InvertY;
    private Random RAND;
    private bool EnableTEX;
    private bool EnableCC;
    private int TextureCount;
    private Main.TextureEditor TextureEd;
    private byte v0;
    private byte n;
    private uint vtxbegin;
    private Main.Vertex3D VertCache;
    private Main.OBJWriteBuffers OBJData;
    private string subdir;
    private ArrayList OBJTextures;
    private bool NewObjGroup;
    private FileStream objstr;
    private StreamWriter objfile;
    private FileStream mtlstr;
    private StreamWriter mtlfile;
    private bool OBJMode;
    private bool AlphaTest;
    private float[] MaxAnisotropy;
    private double XRatio;
    private double YRatio;
    private INIFile ini;
    private int CurrNode;
    private string[] ModelFiles;
    private bool verifyFiles;
    private uint LineSize;
    private uint TexFormat;
    private uint TexelSize;
    private uint CMT;
    private uint CMS;
    private int TexStart;
    private byte[] N64TexIMG;
    private byte[] OGLTexIMG;
    private int baseoffset;
    private int endoffset;
    private int VTCount;
    private ArrayList ShaderLines;
    private byte[] DataBuffer;
    private short V1;
    private short V2;
    private short V3;
    private short V4;
    private short V5;
    private short V6;
    private short x;
    private short y;
    private short z;
    private short u;
    private short v;
    private double r;
    private double g;
    private double b;
    private double a;
    private bool EnableLighting;
    private bool NewTexture;
    private int TIMGOffset;
    private uint CMDLow;
    private uint CMDHigh;
    private double TextureHRatio;
    private double TextureWRatio;
    private byte[] pixel;
    private Main.OGLModel[] OGLDList;
    private int i;
    private int i1;
    private int i2;
    private int i3;
    private int i4;
    private int CurCMD;
    private bool GoStrafe;
    private bool EnableAxisMarker;
    private bool EnableWireFrame;
    private bool RotateSceneClick;
    private bool key_a;
    private bool key_s;
    private bool key_w;
    private bool key_d;
    private bool key_ctrl;
    private double xrotad;
    private double yrotad;
    private double zrotad;
    private float xrot;
    private float yrot;
    private float zrot;
    private int newx;
    private int newy;
    private int oldx;
    private int oldy;
    private double finalx;
    private double finaly;
    private double finalz;
    private uint LineList;
    private double Run;
    private Main.Vertex3D Vertices;
    private Main.DisplayList[] N64Dlist;
    private Main.ColorLUT Extracted;
    private byte[] Palette;
    private int Paloff;
    private int TexBytes;
    private int TextureW;
    private int TextureH;
    private double T_Scale;
    private double S_Scale;
    private bool TriangleCommands;

    internal virtual ToolStripMenuItem FileToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._FileToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._FileToolStripMenuItem = value;
      }
    }

    internal virtual MenuStrip MenuStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._MenuStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._MenuStrip = value;
      }
    }

    internal virtual ToolStripMenuItem OptionsToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._OptionsToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._OptionsToolStripMenuItem = value;
      }
    }

    internal virtual StatusStrip StatusStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._StatusStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._StatusStrip = value;
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

    internal virtual FolderBrowserDialog InputFolderBrowser
    {
      [DebuggerNonUserCode] get
      {
        return this._InputFolderBrowser;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._InputFolderBrowser = value;
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

    internal virtual TrackBar CameraSensitivityScroll
    {
      [DebuggerNonUserCode] get
      {
        return this._CameraSensitivityScroll;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.TrackBar1_Scroll);
        EventHandler eventHandler2 = new EventHandler(this.TrackBar1_Scroll);
        if (this._CameraSensitivityScroll != null)
        {
          this._CameraSensitivityScroll.Scroll -= eventHandler1;
          this._CameraSensitivityScroll.Scroll -= eventHandler2;
        }
        this._CameraSensitivityScroll = value;
        if (this._CameraSensitivityScroll == null)
          return;
        this._CameraSensitivityScroll.Scroll += eventHandler1;
        this._CameraSensitivityScroll.Scroll += eventHandler2;
      }
    }

    internal virtual ToolStripMenuItem ToolsToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._ToolsToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolsToolStripMenuItem = value;
      }
    }

    internal virtual FolderBrowserDialog OutputFolderBrowser
    {
      [DebuggerNonUserCode] get
      {
        return this._OutputFolderBrowser;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._OutputFolderBrowser = value;
      }
    }

    internal virtual ToolStripMenuItem RAREDecompressorSubDragRWPToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._RAREDecompressorSubDragRWPToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RAREDecompressorSubDragRWPToolStripMenuItem_Click);
        if (this._RAREDecompressorSubDragRWPToolStripMenuItem != null)
          this._RAREDecompressorSubDragRWPToolStripMenuItem.Click -= eventHandler;
        this._RAREDecompressorSubDragRWPToolStripMenuItem = value;
        if (this._RAREDecompressorSubDragRWPToolStripMenuItem == null)
          return;
        this._RAREDecompressorSubDragRWPToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem LoadGraphicsToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._LoadGraphicsToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._LoadGraphicsToolStripMenuItem = value;
      }
    }

    internal virtual ToolStripMenuItem QuitToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._QuitToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.QuitToolStripMenuItem_Click_1);
        if (this._QuitToolStripMenuItem != null)
          this._QuitToolStripMenuItem.Click -= eventHandler;
        this._QuitToolStripMenuItem = value;
        if (this._QuitToolStripMenuItem == null)
          return;
        this._QuitToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual SimpleOpenGlControl SimpleOpenGlControl1
    {
      [DebuggerNonUserCode] get
      {
        return this._SimpleOpenGlControl1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.SimpleOpenGlControl1_MouseUp);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.SimpleOpenGlControl1_MouseDown);
        MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.ScrollSensitivity);
        KeyEventHandler keyEventHandler1 = new KeyEventHandler(this.simpleopenglcontrol1_KeyUp);
        KeyEventHandler keyEventHandler2 = new KeyEventHandler(this.simpleopenglcontrol1_KeyDown);
        DragEventHandler dragEventHandler1 = new DragEventHandler(this.SimpleOpenGlControl1_DragEnter);
        DragEventHandler dragEventHandler2 = new DragEventHandler(this.SimpleOpenGlControl1_DragDrop);
        if (this._SimpleOpenGlControl1 != null)
        {
          this._SimpleOpenGlControl1.MouseUp -= mouseEventHandler1;
          this._SimpleOpenGlControl1.MouseDown -= mouseEventHandler2;
          this._SimpleOpenGlControl1.MouseWheel -= mouseEventHandler3;
          this._SimpleOpenGlControl1.KeyUp -= keyEventHandler1;
          this._SimpleOpenGlControl1.KeyDown -= keyEventHandler2;
          this._SimpleOpenGlControl1.DragEnter -= dragEventHandler1;
          this._SimpleOpenGlControl1.DragDrop -= dragEventHandler2;
        }
        this._SimpleOpenGlControl1 = value;
        if (this._SimpleOpenGlControl1 == null)
          return;
        this._SimpleOpenGlControl1.MouseUp += mouseEventHandler1;
        this._SimpleOpenGlControl1.MouseDown += mouseEventHandler2;
        this._SimpleOpenGlControl1.MouseWheel += mouseEventHandler3;
        this._SimpleOpenGlControl1.KeyUp += keyEventHandler1;
        this._SimpleOpenGlControl1.KeyDown += keyEventHandler2;
        this._SimpleOpenGlControl1.DragEnter += dragEventHandler1;
        this._SimpleOpenGlControl1.DragDrop += dragEventHandler2;
      }
    }

    internal virtual TabControl TabControl1
    {
      [DebuggerNonUserCode] get
      {
        return this._TabControl1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabControl1 = value;
      }
    }

    internal virtual TabPage TabPage1
    {
      [DebuggerNonUserCode] get
      {
        return this._TabPage1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TabPage1 = value;
      }
    }

    internal virtual FolderBrowserDialog ModelFolderDialog
    {
      [DebuggerNonUserCode] get
      {
        return this._ModelFolderDialog;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ModelFolderDialog = value;
      }
    }

    internal virtual ToolStripMenuItem ObjectIsolatorToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._ObjectIsolatorToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ObjectIsolatorToolStripMenuItem_Click);
        if (this._ObjectIsolatorToolStripMenuItem != null)
          this._ObjectIsolatorToolStripMenuItem.Click -= eventHandler;
        this._ObjectIsolatorToolStripMenuItem = value;
        if (this._ObjectIsolatorToolStripMenuItem == null)
          return;
        this._ObjectIsolatorToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ContextMenuStrip FileTreeContextMenu
    {
      [DebuggerNonUserCode] get
      {
        return this._FileTreeContextMenu;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._FileTreeContextMenu = value;
      }
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem2
    {
      [DebuggerNonUserCode] get
      {
        return this._ToolStripMenuItem2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem2_Click);
        if (this._ToolStripMenuItem2 != null)
          this._ToolStripMenuItem2.Click -= eventHandler;
        this._ToolStripMenuItem2 = value;
        if (this._ToolStripMenuItem2 == null)
          return;
        this._ToolStripMenuItem2.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ExportWavefrontModelToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._ExportWavefrontModelToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ExportWavefrontModelToolStripMenuItem_Click);
        if (this._ExportWavefrontModelToolStripMenuItem != null)
          this._ExportWavefrontModelToolStripMenuItem.Click -= eventHandler;
        this._ExportWavefrontModelToolStripMenuItem = value;
        if (this._ExportWavefrontModelToolStripMenuItem == null)
          return;
        this._ExportWavefrontModelToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual SaveFileDialog SaveOBJ
    {
      [DebuggerNonUserCode] get
      {
        return this._SaveOBJ;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.SaveOBJ_FileOk);
        if (this._SaveOBJ != null)
          this._SaveOBJ.FileOk -= cancelEventHandler;
        this._SaveOBJ = value;
        if (this._SaveOBJ == null)
          return;
        this._SaveOBJ.FileOk += cancelEventHandler;
      }
    }

    internal virtual OpenFileDialog OpenTexture
    {
      [DebuggerNonUserCode] get
      {
        return this._OpenTexture;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.OpenTexture_FileOk);
        if (this._OpenTexture != null)
          this._OpenTexture.FileOk -= cancelEventHandler;
        this._OpenTexture = value;
        if (this._OpenTexture == null)
          return;
        this._OpenTexture.FileOk += cancelEventHandler;
      }
    }

    internal virtual ToolStripMenuItem GameToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._GameToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._GameToolStripMenuItem = value;
      }
    }

    internal virtual ToolStripMenuItem BanjoKazooieToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._BanjoKazooieToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BanjoKazooieToolStripMenuItem_Click);
        if (this._BanjoKazooieToolStripMenuItem != null)
          this._BanjoKazooieToolStripMenuItem.Click -= eventHandler;
        this._BanjoKazooieToolStripMenuItem = value;
        if (this._BanjoKazooieToolStripMenuItem == null)
          return;
        this._BanjoKazooieToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem BanjoTooieToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._BanjoTooieToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BanjoTooieToolStripMenuItem_Click);
        if (this._BanjoTooieToolStripMenuItem != null)
          this._BanjoTooieToolStripMenuItem.Click -= eventHandler;
        this._BanjoTooieToolStripMenuItem = value;
        if (this._BanjoTooieToolStripMenuItem == null)
          return;
        this._BanjoTooieToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripStatusLabel GameStatus
    {
      [DebuggerNonUserCode] get
      {
        return this._GameStatus;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GameStatus_Click);
        if (this._GameStatus != null)
          this._GameStatus.Click -= eventHandler;
        this._GameStatus = value;
        if (this._GameStatus == null)
          return;
        this._GameStatus.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem BanjoKazooieToolStripMenuItem1
    {
      [DebuggerNonUserCode] get
      {
        return this._BanjoKazooieToolStripMenuItem1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BanjoKazooieToolStripMenuItem1_Click_1);
        if (this._BanjoKazooieToolStripMenuItem1 != null)
          this._BanjoKazooieToolStripMenuItem1.Click -= eventHandler;
        this._BanjoKazooieToolStripMenuItem1 = value;
        if (this._BanjoKazooieToolStripMenuItem1 == null)
          return;
        this._BanjoKazooieToolStripMenuItem1.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem BanjoTooieToolStripMenuItem1
    {
      [DebuggerNonUserCode] get
      {
        return this._BanjoTooieToolStripMenuItem1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.BanjoTooieToolStripMenuItem1_Click);
        if (this._BanjoTooieToolStripMenuItem1 != null)
          this._BanjoTooieToolStripMenuItem1.Click -= eventHandler;
        this._BanjoTooieToolStripMenuItem1 = value;
        if (this._BanjoTooieToolStripMenuItem1 == null)
          return;
        this._BanjoTooieToolStripMenuItem1.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ResetToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._ResetToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ResetToolStripMenuItem_Click);
        if (this._ResetToolStripMenuItem != null)
          this._ResetToolStripMenuItem.Click -= eventHandler;
        this._ResetToolStripMenuItem = value;
        if (this._ResetToolStripMenuItem == null)
          return;
        this._ResetToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem InvertYAxisToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._InvertYAxisToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.InvertYAxisToolStripMenuItem_Click);
        if (this._InvertYAxisToolStripMenuItem != null)
          this._InvertYAxisToolStripMenuItem.Click -= eventHandler;
        this._InvertYAxisToolStripMenuItem = value;
        if (this._InvertYAxisToolStripMenuItem == null)
          return;
        this._InvertYAxisToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem CaptureScreenshotToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._CaptureScreenshotToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CaptureScreenshotToolStripMenuItem_Click);
        if (this._CaptureScreenshotToolStripMenuItem != null)
          this._CaptureScreenshotToolStripMenuItem.Click -= eventHandler;
        this._CaptureScreenshotToolStripMenuItem = value;
        if (this._CaptureScreenshotToolStripMenuItem == null)
          return;
        this._CaptureScreenshotToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual SaveFileDialog SaveScreenPNG
    {
      [DebuggerNonUserCode] get
      {
        return this._SaveScreenPNG;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.SaveScreenBMP_FileOk);
        CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.SaveScreenBMP_FileOk);
        if (this._SaveScreenPNG != null)
        {
          this._SaveScreenPNG.FileOk -= cancelEventHandler1;
          this._SaveScreenPNG.FileOk -= cancelEventHandler2;
        }
        this._SaveScreenPNG = value;
        if (this._SaveScreenPNG == null)
          return;
        this._SaveScreenPNG.FileOk += cancelEventHandler1;
        this._SaveScreenPNG.FileOk += cancelEventHandler2;
      }
    }

    internal virtual ToolStripMenuItem RenameToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._RenameToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RenameToolStripMenuItem_Click);
        if (this._RenameToolStripMenuItem != null)
          this._RenameToolStripMenuItem.Click -= eventHandler;
        this._RenameToolStripMenuItem = value;
        if (this._RenameToolStripMenuItem == null)
          return;
        this._RenameToolStripMenuItem.Click += eventHandler;
      }
    }

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

    internal virtual TextBox TextBox1
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TextBox1_KeyPress);
        if (this._TextBox1 != null)
          this._TextBox1.KeyPress -= pressEventHandler;
        this._TextBox1 = value;
        if (this._TextBox1 == null)
          return;
        this._TextBox1.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get
      {
        return this._Label5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label5 = value;
      }
    }

    internal virtual CodersLab.Windows.Controls.TreeView TreeView1
    {
      [DebuggerNonUserCode] get
      {
        return this._TreeView1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TreeView1_DoubleClick);
        TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.TreeView1_AfterSelect);
        if (this._TreeView1 != null)
        {
          this._TreeView1.DoubleClick -= eventHandler;
          this._TreeView1.AfterSelect -= viewEventHandler;
        }
        this._TreeView1 = value;
        if (this._TreeView1 == null)
          return;
        this._TreeView1.DoubleClick += eventHandler;
        this._TreeView1.AfterSelect += viewEventHandler;
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

    internal virtual ToolStripMenuItem DonkeyKong64ToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._DonkeyKong64ToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DonkeyKong64ToolStripMenuItem_Click);
        if (this._DonkeyKong64ToolStripMenuItem != null)
          this._DonkeyKong64ToolStripMenuItem.Click -= eventHandler;
        this._DonkeyKong64ToolStripMenuItem = value;
        if (this._DonkeyKong64ToolStripMenuItem == null)
          return;
        this._DonkeyKong64ToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem DonkeyKong64ToolStripMenuItem1
    {
      [DebuggerNonUserCode] get
      {
        return this._DonkeyKong64ToolStripMenuItem1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._DonkeyKong64ToolStripMenuItem1 = value;
      }
    }

    internal virtual CodersLab.Windows.Controls.TreeView FileTree
    {
      [DebuggerNonUserCode] get
      {
        return this._FileTree;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FileTree_DoubleClick);
        TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.FileTree_AfterSelect);
        if (this._FileTree != null)
        {
          this._FileTree.DoubleClick -= eventHandler;
          this._FileTree.AfterSelect -= viewEventHandler;
        }
        this._FileTree = value;
        if (this._FileTree == null)
          return;
        this._FileTree.DoubleClick += eventHandler;
        this._FileTree.AfterSelect += viewEventHandler;
      }
    }

    internal virtual ProgressBar ProgressBar1
    {
      [DebuggerNonUserCode] get
      {
        return this._ProgressBar1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ProgressBar1 = value;
      }
    }

    internal virtual ToolStrip ToolStrip
    {
      [DebuggerNonUserCode] get
      {
        return this._ToolStrip;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ToolStripItemClickedEventHandler clickedEventHandler = new ToolStripItemClickedEventHandler(this.ToolStrip_ItemClicked);
        if (this._ToolStrip != null)
          this._ToolStrip.ItemClicked -= clickedEventHandler;
        this._ToolStrip = value;
        if (this._ToolStrip == null)
          return;
        this._ToolStrip.ItemClicked += clickedEventHandler;
      }
    }

    internal virtual ToolStripButton Rotate90Left
    {
      [DebuggerNonUserCode] get
      {
        return this._Rotate90Left;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Rotate90Left_Click);
        if (this._Rotate90Left != null)
          this._Rotate90Left.Click -= eventHandler;
        this._Rotate90Left = value;
        if (this._Rotate90Left == null)
          return;
        this._Rotate90Left.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton Rotate90Right
    {
      [DebuggerNonUserCode] get
      {
        return this._Rotate90Right;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Rotate90Right_Click);
        if (this._Rotate90Right != null)
          this._Rotate90Right.Click -= eventHandler;
        this._Rotate90Right = value;
        if (this._Rotate90Right == null)
          return;
        this._Rotate90Right.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton Rotate90Up
    {
      [DebuggerNonUserCode] get
      {
        return this._Rotate90Up;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Rotate90Up_Click);
        if (this._Rotate90Up != null)
          this._Rotate90Up.Click -= eventHandler;
        this._Rotate90Up = value;
        if (this._Rotate90Up == null)
          return;
        this._Rotate90Up.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton Rotate90Down
    {
      [DebuggerNonUserCode] get
      {
        return this._Rotate90Down;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Rotate90Down_Click);
        if (this._Rotate90Down != null)
          this._Rotate90Down.Click -= eventHandler;
        this._Rotate90Down = value;
        if (this._Rotate90Down == null)
          return;
        this._Rotate90Down.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator1
    {
      [DebuggerNonUserCode] get
      {
        return this._ToolStripSeparator1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolStripSeparator1 = value;
      }
    }

    internal virtual Timer RotateTimer
    {
      [DebuggerNonUserCode] get
      {
        return this._RotateTimer;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RotateTimer_Tick);
        if (this._RotateTimer != null)
          this._RotateTimer.Tick -= eventHandler;
        this._RotateTimer = value;
        if (this._RotateTimer == null)
          return;
        this._RotateTimer.Tick += eventHandler;
      }
    }

    internal virtual ToolStripButton ToggleTextureButton
    {
      [DebuggerNonUserCode] get
      {
        return this._ToggleTextureButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton1_Click);
        if (this._ToggleTextureButton != null)
          this._ToggleTextureButton.Click -= eventHandler;
        this._ToggleTextureButton = value;
        if (this._ToggleTextureButton == null)
          return;
        this._ToggleTextureButton.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton AxisMarkerToggle
    {
      [DebuggerNonUserCode] get
      {
        return this._AxisMarkerToggle;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton1_Click_1);
        if (this._AxisMarkerToggle != null)
          this._AxisMarkerToggle.Click -= eventHandler;
        this._AxisMarkerToggle = value;
        if (this._AxisMarkerToggle == null)
          return;
        this._AxisMarkerToggle.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator2
    {
      [DebuggerNonUserCode] get
      {
        return this._ToolStripSeparator2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolStripSeparator2 = value;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator3
    {
      [DebuggerNonUserCode] get
      {
        return this._ToolStripSeparator3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._ToolStripSeparator3 = value;
      }
    }

    internal virtual ToolStripButton ToggleWireframeButton
    {
      [DebuggerNonUserCode] get
      {
        return this._ToggleWireframeButton;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButton1_Click_2);
        if (this._ToggleWireframeButton != null)
          this._ToggleWireframeButton.Click -= eventHandler;
        this._ToggleWireframeButton = value;
        if (this._ToggleWireframeButton == null)
          return;
        this._ToggleWireframeButton.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem AssociateFilesWithWindowsToolStripMenuItem
    {
      [DebuggerNonUserCode] get
      {
        return this._AssociateFilesWithWindowsToolStripMenuItem;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.AssociateFilesWithWindowsToolStripMenuItem_Click);
        if (this._AssociateFilesWithWindowsToolStripMenuItem != null)
          this._AssociateFilesWithWindowsToolStripMenuItem.Click -= eventHandler;
        this._AssociateFilesWithWindowsToolStripMenuItem = value;
        if (this._AssociateFilesWithWindowsToolStripMenuItem == null)
          return;
        this._AssociateFilesWithWindowsToolStripMenuItem.Click += eventHandler;
      }
    }

    public Main()
    {
      this.Resize += new EventHandler(this.Form1_Resize);
      this.Load += new EventHandler(this.Form1_Load);
      this.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
      this.rottype = 0;
      this.rotcoef = 90;
      this.GEOMODE = 0U;
      this.SearchFound = new ArrayList();
      this.FindTracker = -1;
      this.oldFindTracker = -1;
      this.InvertY = false;
      this.RAND = new Random();
      this.EnableTEX = true;
      this.EnableCC = true;
      this.TextureCount = 0;
      this.TextureEd = new Main.TextureEditor();
      this.VertCache = new Main.Vertex3D();
      this.OBJData = new Main.OBJWriteBuffers();
      this.OBJTextures = new ArrayList();
      this.NewObjGroup = false;
      this.OBJMode = false;
      this.AlphaTest = false;
      this.MaxAnisotropy = new float[1];
      this.XRatio = 0.0;
      this.YRatio = 0.0;
      this.ini = new INIFile(Application.StartupPath + "\\bg.ini");
      this.CurrNode = -1;
      this.verifyFiles = false;
      this.LineSize = 0U;
      this.TexFormat = 0U;
      this.TexelSize = 0U;
      this.CMT = 0U;
      this.CMS = 0U;
      this.TexStart = 0;
      this.baseoffset = 0;
      this.endoffset = 0;
      this.VTCount = 0;
      this.ShaderLines = new ArrayList();
      this.V1 = (short) 0;
      this.V2 = (short) 0;
      this.V3 = (short) 0;
      this.V4 = (short) 0;
      this.V5 = (short) 0;
      this.V6 = (short) 0;
      this.EnableLighting = false;
      this.NewTexture = false;
      this.TIMGOffset = 0;
      this.pixel = new byte[3];
      this.OGLDList = new Main.OGLModel[1];
      this.i = 0;
      this.i1 = 0;
      this.i2 = 0;
      this.i3 = 0;
      this.i4 = 0;
      this.CurCMD = 0;
      this.GoStrafe = false;
      this.EnableAxisMarker = true;
      this.EnableWireFrame = false;
      this.RotateSceneClick = false;
      this.key_a = false;
      this.key_s = false;
      this.key_w = false;
      this.key_d = false;
      this.key_ctrl = false;
      this.xrot = 0.0f;
      this.yrot = 0.0f;
      this.zrot = 0.0f;
      this.finalx = 0.0;
      this.finaly = 0.0;
      this.finalz = 0.0;
      this.LineList = 0U;
      this.Run = 1.0;
      this.N64Dlist = new Main.DisplayList[1];
      this.Extracted = new Main.ColorLUT();
      this.Paloff = 0;
      this.TexBytes = 0;
      this.TextureW = 0;
      this.TextureH = 0;
      this.T_Scale = 0.0;
      this.S_Scale = 0.0;
      this.TriangleCommands = false;
      this.InitializeComponent();
      this.SimpleOpenGlControl1.InitializeContexts();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      this.SimpleOpenGlControl1.DestroyContexts();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Main));
      this.MenuStrip = new MenuStrip();
      this.FileToolStripMenuItem = new ToolStripMenuItem();
      this.LoadGraphicsToolStripMenuItem = new ToolStripMenuItem();
      this.BanjoKazooieToolStripMenuItem1 = new ToolStripMenuItem();
      this.BanjoTooieToolStripMenuItem1 = new ToolStripMenuItem();
      this.DonkeyKong64ToolStripMenuItem1 = new ToolStripMenuItem();
      this.ExportWavefrontModelToolStripMenuItem = new ToolStripMenuItem();
      this.QuitToolStripMenuItem = new ToolStripMenuItem();
      this.OptionsToolStripMenuItem = new ToolStripMenuItem();
      this.GameToolStripMenuItem = new ToolStripMenuItem();
      this.BanjoKazooieToolStripMenuItem = new ToolStripMenuItem();
      this.BanjoTooieToolStripMenuItem = new ToolStripMenuItem();
      this.DonkeyKong64ToolStripMenuItem = new ToolStripMenuItem();
      this.ResetToolStripMenuItem = new ToolStripMenuItem();
      this.CaptureScreenshotToolStripMenuItem = new ToolStripMenuItem();
      this.InvertYAxisToolStripMenuItem = new ToolStripMenuItem();
      this.AssociateFilesWithWindowsToolStripMenuItem = new ToolStripMenuItem();
      this.ToolsToolStripMenuItem = new ToolStripMenuItem();
      this.ObjectIsolatorToolStripMenuItem = new ToolStripMenuItem();
      this.RAREDecompressorSubDragRWPToolStripMenuItem = new ToolStripMenuItem();
      this.StatusStrip = new StatusStrip();
      this.GameStatus = new ToolStripStatusLabel();
      this.Label1 = new Label();
      this.InputFolderBrowser = new FolderBrowserDialog();
      this.Label2 = new Label();
      this.CameraSensitivityScroll = new TrackBar();
      this.OutputFolderBrowser = new FolderBrowserDialog();
      this.SimpleOpenGlControl1 = new SimpleOpenGlControl();
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.TreeView1 = new CodersLab.Windows.Controls.TreeView();
      this.Label5 = new Label();
      this.Button1 = new Button();
      this.TextBox1 = new TextBox();
      this.FileTree = new CodersLab.Windows.Controls.TreeView();
      this.GroupBox1 = new GroupBox();
      this.GroupBox2 = new GroupBox();
      this.ProgressBar1 = new ProgressBar();
      this.FileTreeContextMenu = new ContextMenuStrip(this.components);
      this.ToolStripMenuItem2 = new ToolStripMenuItem();
      this.RenameToolStripMenuItem = new ToolStripMenuItem();
      this.ModelFolderDialog = new FolderBrowserDialog();
      this.SaveOBJ = new SaveFileDialog();
      this.OpenTexture = new OpenFileDialog();
      this.SaveScreenPNG = new SaveFileDialog();
      this.ToolStrip = new ToolStrip();
      this.ToolStripSeparator2 = new ToolStripSeparator();
      this.Rotate90Left = new ToolStripButton();
      this.Rotate90Right = new ToolStripButton();
      this.Rotate90Up = new ToolStripButton();
      this.Rotate90Down = new ToolStripButton();
      this.ToolStripSeparator1 = new ToolStripSeparator();
      this.ToggleTextureButton = new ToolStripButton();
      this.ToggleWireframeButton = new ToolStripButton();
      this.AxisMarkerToggle = new ToolStripButton();
      this.ToolStripSeparator3 = new ToolStripSeparator();
      this.RotateTimer = new Timer(this.components);
      this.MenuStrip.SuspendLayout();
      this.StatusStrip.SuspendLayout();
      this.CameraSensitivityScroll.BeginInit();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.FileTreeContextMenu.SuspendLayout();
      this.ToolStrip.SuspendLayout();
      this.SuspendLayout();
      this.MenuStrip.BackColor = SystemColors.Control;
      this.MenuStrip.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.FileToolStripMenuItem,
        (ToolStripItem) this.OptionsToolStripMenuItem,
        (ToolStripItem) this.ToolsToolStripMenuItem
      });
      MenuStrip menuStrip1 = this.MenuStrip;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      menuStrip1.Location = point2;
      this.MenuStrip.Name = "MenuStrip";
      this.MenuStrip.RenderMode = ToolStripRenderMode.Professional;
      MenuStrip menuStrip2 = this.MenuStrip;
      Size size1 = new Size(856, 24);
      Size size2 = size1;
      menuStrip2.Size = size2;
      this.MenuStrip.TabIndex = 1;
      this.MenuStrip.Text = "MenuStrip1";
      this.FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.LoadGraphicsToolStripMenuItem,
        (ToolStripItem) this.ExportWavefrontModelToolStripMenuItem,
        (ToolStripItem) this.QuitToolStripMenuItem
      });
      this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem1 = this.FileToolStripMenuItem;
      size1 = new Size(37, 20);
      Size size3 = size1;
      toolStripMenuItem1.Size = size3;
      this.FileToolStripMenuItem.Text = "File";
      this.FileToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
      this.LoadGraphicsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.BanjoKazooieToolStripMenuItem1,
        (ToolStripItem) this.BanjoTooieToolStripMenuItem1,
        (ToolStripItem) this.DonkeyKong64ToolStripMenuItem1
      });
      this.LoadGraphicsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.LoadGraphicsToolStripMenuItem.MergeAction = MergeAction.Insert;
      this.LoadGraphicsToolStripMenuItem.Name = "LoadGraphicsToolStripMenuItem";
      this.LoadGraphicsToolStripMenuItem.ShortcutKeys = Keys.O | Keys.Control;
      ToolStripMenuItem toolStripMenuItem2 = this.LoadGraphicsToolStripMenuItem;
      size1 = new Size(220, 22);
      Size size4 = size1;
      toolStripMenuItem2.Size = size4;
      this.LoadGraphicsToolStripMenuItem.Text = "Set model directory";
      this.BanjoKazooieToolStripMenuItem1.Name = "BanjoKazooieToolStripMenuItem1";
      ToolStripMenuItem toolStripMenuItem1_1 = this.BanjoKazooieToolStripMenuItem1;
      size1 = new Size(160, 22);
      Size size5 = size1;
      toolStripMenuItem1_1.Size = size5;
      this.BanjoKazooieToolStripMenuItem1.Text = "Banjo-Kazooie";
      this.BanjoTooieToolStripMenuItem1.Name = "BanjoTooieToolStripMenuItem1";
      ToolStripMenuItem toolStripMenuItem1_2 = this.BanjoTooieToolStripMenuItem1;
      size1 = new Size(160, 22);
      Size size6 = size1;
      toolStripMenuItem1_2.Size = size6;
      this.BanjoTooieToolStripMenuItem1.Text = "Banjo-Tooie";
      this.DonkeyKong64ToolStripMenuItem1.Name = "DonkeyKong64ToolStripMenuItem1";
      ToolStripMenuItem toolStripMenuItem1_3 = this.DonkeyKong64ToolStripMenuItem1;
      size1 = new Size(160, 22);
      Size size7 = size1;
      toolStripMenuItem1_3.Size = size7;
      this.DonkeyKong64ToolStripMenuItem1.Text = "Donkey Kong 64";
      this.ExportWavefrontModelToolStripMenuItem.Name = "ExportWavefrontModelToolStripMenuItem";
      this.ExportWavefrontModelToolStripMenuItem.ShortcutKeys = Keys.E | Keys.Control;
      ToolStripMenuItem toolStripMenuItem3 = this.ExportWavefrontModelToolStripMenuItem;
      size1 = new Size(220, 22);
      Size size8 = size1;
      toolStripMenuItem3.Size = size8;
      this.ExportWavefrontModelToolStripMenuItem.Text = "Export as .OBJ";
      this.QuitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.QuitToolStripMenuItem.MergeAction = MergeAction.Insert;
      this.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
      this.QuitToolStripMenuItem.ShortcutKeys = Keys.Q | Keys.Control;
      ToolStripMenuItem toolStripMenuItem4 = this.QuitToolStripMenuItem;
      size1 = new Size(220, 22);
      Size size9 = size1;
      toolStripMenuItem4.Size = size9;
      this.QuitToolStripMenuItem.Text = "Quit";
      this.OptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.GameToolStripMenuItem,
        (ToolStripItem) this.ResetToolStripMenuItem,
        (ToolStripItem) this.CaptureScreenshotToolStripMenuItem,
        (ToolStripItem) this.InvertYAxisToolStripMenuItem,
        (ToolStripItem) this.AssociateFilesWithWindowsToolStripMenuItem
      });
      this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem5 = this.OptionsToolStripMenuItem;
      size1 = new Size(61, 20);
      Size size10 = size1;
      toolStripMenuItem5.Size = size10;
      this.OptionsToolStripMenuItem.Text = "Options";
      this.OptionsToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
      this.GameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.BanjoKazooieToolStripMenuItem,
        (ToolStripItem) this.BanjoTooieToolStripMenuItem,
        (ToolStripItem) this.DonkeyKong64ToolStripMenuItem
      });
      this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem6 = this.GameToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size11 = size1;
      toolStripMenuItem6.Size = size11;
      this.GameToolStripMenuItem.Text = "Game";
      this.BanjoKazooieToolStripMenuItem.Name = "BanjoKazooieToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem7 = this.BanjoKazooieToolStripMenuItem;
      size1 = new Size(160, 22);
      Size size12 = size1;
      toolStripMenuItem7.Size = size12;
      this.BanjoKazooieToolStripMenuItem.Text = "Banjo-Kazooie";
      this.BanjoTooieToolStripMenuItem.Name = "BanjoTooieToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem8 = this.BanjoTooieToolStripMenuItem;
      size1 = new Size(160, 22);
      Size size13 = size1;
      toolStripMenuItem8.Size = size13;
      this.BanjoTooieToolStripMenuItem.Text = "Banjo-Tooie";
      this.DonkeyKong64ToolStripMenuItem.Name = "DonkeyKong64ToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem9 = this.DonkeyKong64ToolStripMenuItem;
      size1 = new Size(160, 22);
      Size size14 = size1;
      toolStripMenuItem9.Size = size14;
      this.DonkeyKong64ToolStripMenuItem.Text = "Donkey Kong 64";
      this.DonkeyKong64ToolStripMenuItem.Visible = false;
      this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
      this.ResetToolStripMenuItem.ShortcutKeyDisplayString = "R";
      ToolStripMenuItem toolStripMenuItem10 = this.ResetToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size15 = size1;
      toolStripMenuItem10.Size = size15;
      this.ResetToolStripMenuItem.Text = "Reset view";
      this.CaptureScreenshotToolStripMenuItem.Name = "CaptureScreenshotToolStripMenuItem";
      this.CaptureScreenshotToolStripMenuItem.ShortcutKeys = Keys.F5;
      ToolStripMenuItem toolStripMenuItem11 = this.CaptureScreenshotToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size16 = size1;
      toolStripMenuItem11.Size = size16;
      this.CaptureScreenshotToolStripMenuItem.Text = "Capture screenshot";
      this.InvertYAxisToolStripMenuItem.CheckOnClick = true;
      this.InvertYAxisToolStripMenuItem.Name = "InvertYAxisToolStripMenuItem";
      this.InvertYAxisToolStripMenuItem.ShortcutKeys = Keys.Y | Keys.Control;
      ToolStripMenuItem toolStripMenuItem12 = this.InvertYAxisToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size17 = size1;
      toolStripMenuItem12.Size = size17;
      this.InvertYAxisToolStripMenuItem.Text = "Invert Y Axis";
      this.AssociateFilesWithWindowsToolStripMenuItem.Name = "AssociateFilesWithWindowsToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem13 = this.AssociateFilesWithWindowsToolStripMenuItem;
      size1 = new Size(226, 22);
      Size size18 = size1;
      toolStripMenuItem13.Size = size18;
      this.AssociateFilesWithWindowsToolStripMenuItem.Text = "Associate files with Windows";
      this.ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ObjectIsolatorToolStripMenuItem,
        (ToolStripItem) this.RAREDecompressorSubDragRWPToolStripMenuItem
      });
      this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem14 = this.ToolsToolStripMenuItem;
      size1 = new Size(48, 20);
      Size size19 = size1;
      toolStripMenuItem14.Size = size19;
      this.ToolsToolStripMenuItem.Text = "Tools";
      this.ToolsToolStripMenuItem.TextAlign = ContentAlignment.TopLeft;
      this.ObjectIsolatorToolStripMenuItem.Name = "ObjectIsolatorToolStripMenuItem";
      this.ObjectIsolatorToolStripMenuItem.ShortcutKeys = Keys.M | Keys.Control;
      ToolStripMenuItem toolStripMenuItem15 = this.ObjectIsolatorToolStripMenuItem;
      size1 = new Size(309, 22);
      Size size20 = size1;
      toolStripMenuItem15.Size = size20;
      this.ObjectIsolatorToolStripMenuItem.Text = "Model Isolator";
      this.RAREDecompressorSubDragRWPToolStripMenuItem.Name = "RAREDecompressorSubDragRWPToolStripMenuItem";
      this.RAREDecompressorSubDragRWPToolStripMenuItem.ShortcutKeys = Keys.D | Keys.Control;
      ToolStripMenuItem toolStripMenuItem16 = this.RAREDecompressorSubDragRWPToolStripMenuItem;
      size1 = new Size(309, 22);
      Size size21 = size1;
      toolStripMenuItem16.Size = size21;
      this.RAREDecompressorSubDragRWPToolStripMenuItem.Text = "RARE Decompressor (SubDrag/RWP)";
      this.StatusStrip.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.GameStatus
      });
      StatusStrip statusStrip1 = this.StatusStrip;
      point1 = new Point(0, 549);
      Point point3 = point1;
      statusStrip1.Location = point3;
      this.StatusStrip.Name = "StatusStrip";
      StatusStrip statusStrip2 = this.StatusStrip;
      size1 = new Size(856, 24);
      Size size22 = size1;
      statusStrip2.Size = size22;
      this.StatusStrip.TabIndex = 2;
      this.StatusStrip.Text = "StatusStrip1";
      this.GameStatus.BorderSides = ToolStripStatusLabelBorderSides.All;
      this.GameStatus.Name = "GameStatus";
      ToolStripStatusLabel gameStatus = this.GameStatus;
      size1 = new Size(45, 19);
      Size size23 = size1;
      gameStatus.Size = size23;
      this.GameStatus.Text = "Game:";
      this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(649, 556);
      Point point4 = point1;
      label1_1.Location = point4;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(80, 13);
      Size size24 = size1;
      label1_2.Size = size24;
      this.Label1.TabIndex = 4;
      this.Label1.Text = "Camera Speed:";
      this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(115, 556);
      Point point5 = point1;
      label2_1.Location = point5;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(13, 13);
      Size size25 = size1;
      label2_2.Size = size25;
      this.Label2.TabIndex = 6;
      this.Label2.Text = "  ";
      this.CameraSensitivityScroll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.CameraSensitivityScroll.AutoSize = false;
      this.CameraSensitivityScroll.Cursor = Cursors.Hand;
      TrackBar sensitivityScroll1 = this.CameraSensitivityScroll;
      point1 = new Point(724, 553);
      Point point6 = point1;
      sensitivityScroll1.Location = point6;
      this.CameraSensitivityScroll.Maximum = 47;
      this.CameraSensitivityScroll.Minimum = 1;
      this.CameraSensitivityScroll.Name = "CameraSensitivityScroll";
      TrackBar sensitivityScroll2 = this.CameraSensitivityScroll;
      size1 = new Size(111, 19);
      Size size26 = size1;
      sensitivityScroll2.Size = size26;
      this.CameraSensitivityScroll.TabIndex = 7;
      this.CameraSensitivityScroll.Value = 1;
      this.SimpleOpenGlControl1.AccumBits = (byte) 0;
      this.SimpleOpenGlControl1.AllowDrop = true;
      this.SimpleOpenGlControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.SimpleOpenGlControl1.AutoCheckErrors = false;
      this.SimpleOpenGlControl1.AutoFinish = true;
      this.SimpleOpenGlControl1.AutoMakeCurrent = true;
      this.SimpleOpenGlControl1.AutoSwapBuffers = false;
      this.SimpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
      this.SimpleOpenGlControl1.ColorBits = (byte) 32;
      this.SimpleOpenGlControl1.DepthBits = (byte) 16;
      SimpleOpenGlControl simpleOpenGlControl1_1 = this.SimpleOpenGlControl1;
      point1 = new Point(0, 64);
      Point point7 = point1;
      simpleOpenGlControl1_1.Location = point7;
      this.SimpleOpenGlControl1.Name = "SimpleOpenGlControl1";
      SimpleOpenGlControl simpleOpenGlControl1_2 = this.SimpleOpenGlControl1;
      size1 = new Size(610, 487);
      Size size27 = size1;
      simpleOpenGlControl1_2.Size = size27;
      this.SimpleOpenGlControl1.StencilBits = (byte) 0;
      this.SimpleOpenGlControl1.TabIndex = 0;
      this.TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      TabControl tabControl1_1 = this.TabControl1;
      point1 = new Point(611, 23);
      Point point8 = point1;
      tabControl1_1.Location = point8;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.ShowToolTips = true;
      TabControl tabControl1_2 = this.TabControl1;
      size1 = new Size(247, 528);
      Size size28 = size1;
      tabControl1_2.Size = size28;
      this.TabControl1.TabIndex = 8;
      this.TabPage1.Controls.Add((Control) this.TreeView1);
      this.TabPage1.Controls.Add((Control) this.Label5);
      this.TabPage1.Controls.Add((Control) this.Button1);
      this.TabPage1.Controls.Add((Control) this.TextBox1);
      this.TabPage1.Controls.Add((Control) this.FileTree);
      this.TabPage1.Controls.Add((Control) this.GroupBox1);
      this.TabPage1.Controls.Add((Control) this.GroupBox2);
      TabPage tabPage1_1 = this.TabPage1;
      point1 = new Point(4, 22);
      Point point9 = point1;
      tabPage1_1.Location = point9;
      this.TabPage1.Name = "TabPage1";
      this.TabPage1.Padding = new Padding(3);
      TabPage tabPage1_2 = this.TabPage1;
      size1 = new Size(239, 502);
      Size size29 = size1;
      tabPage1_2.Size = size29;
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "Models";
      this.TabPage1.ToolTipText = "A list of models that reside in the directory you've specified (File -> Set model dir...)";
      this.TabPage1.UseVisualStyleBackColor = true;
      this.TreeView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      CodersLab.Windows.Controls.TreeView treeView1_1 = this.TreeView1;
      point1 = new Point(12, 331);
      Point point10 = point1;
      treeView1_1.Location = point10;
      this.TreeView1.Name = "TreeView1";
      this.TreeView1.RightToLeftLayout = true;
      this.TreeView1.SelectionBackColor = SystemColors.Highlight;
      this.TreeView1.SelectionMode = TreeViewSelectionMode.SingleSelect;
      CodersLab.Windows.Controls.TreeView treeView1_2 = this.TreeView1;
      size1 = new Size(217, 110);
      Size size30 = size1;
      treeView1_2.Size = size30;
      this.TreeView1.TabIndex = 17;
      this.Label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(12, 482);
      Point point11 = point1;
      label5_1.Location = point11;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(0, 13);
      Size size31 = size1;
      label5_2.Size = size31;
      this.Label5.TabIndex = 16;
      this.Button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      Button button1_1 = this.Button1;
      point1 = new Point(179, 453);
      Point point12 = point1;
      button1_1.Location = point12;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      size1 = new Size(50, 22);
      Size size32 = size1;
      button1_2.Size = size32;
      this.Button1.TabIndex = 15;
      this.Button1.Text = "Find";
      this.Button1.UseVisualStyleBackColor = true;
      this.TextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(12, 455);
      Point point13 = point1;
      textBox1_1.Location = point13;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(161, 20);
      Size size33 = size1;
      textBox1_2.Size = size33;
      this.TextBox1.TabIndex = 14;
      this.FileTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      CodersLab.Windows.Controls.TreeView fileTree1 = this.FileTree;
      point1 = new Point(12, 25);
      Point point14 = point1;
      fileTree1.Location = point14;
      this.FileTree.Name = "FileTree";
      this.FileTree.RightToLeftLayout = true;
      this.FileTree.SelectionBackColor = SystemColors.Highlight;
      this.FileTree.SelectionMode = TreeViewSelectionMode.SingleSelect;
      CodersLab.Windows.Controls.TreeView fileTree2 = this.FileTree;
      size1 = new Size(217, 275);
      Size size34 = size1;
      fileTree2.Size = size34;
      this.FileTree.TabIndex = 1;
      this.GroupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(6, 312);
      Point point15 = point1;
      groupBox1_1.Location = point15;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(227, 179);
      Size size35 = size1;
      groupBox1_2.Size = size35;
      this.GroupBox1.TabIndex = 19;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Search";
      this.GroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.GroupBox2.Controls.Add((Control) this.ProgressBar1);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(6, 6);
      Point point16 = point1;
      groupBox2_1.Location = point16;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(227, 300);
      Size size36 = size1;
      groupBox2_2.Size = size36;
      this.GroupBox2.TabIndex = 20;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "All";
      this.ProgressBar1.ForeColor = System.Drawing.Color.Red;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(31, 1);
      Point point17 = point1;
      progressBar1_1.Location = point17;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(190, 10);
      Size size37 = size1;
      progressBar1_2.Size = size37;
      this.ProgressBar1.TabIndex = 9;
      this.FileTreeContextMenu.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.ToolStripMenuItem2,
        (ToolStripItem) this.RenameToolStripMenuItem
      });
      this.FileTreeContextMenu.Name = "ContextMenuStrip1";
      ContextMenuStrip fileTreeContextMenu = this.FileTreeContextMenu;
      size1 = new Size(198, 48);
      Size size38 = size1;
      fileTreeContextMenu.Size = size38;
      this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
      ToolStripMenuItem toolStripMenuItem2_1 = this.ToolStripMenuItem2;
      size1 = new Size(197, 22);
      Size size39 = size1;
      toolStripMenuItem2_1.Size = size39;
      this.ToolStripMenuItem2.Text = "Open containing folder";
      this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem17 = this.RenameToolStripMenuItem;
      size1 = new Size(197, 22);
      Size size40 = size1;
      toolStripMenuItem17.Size = size40;
      this.RenameToolStripMenuItem.Text = "Rename description";
      this.ModelFolderDialog.Description = "Please select the folder to which you isolated your BK models (*.bkm).";
      this.SaveOBJ.Filter = "Wavefront OBJ Models|*.obj";
      this.SaveOBJ.Title = "Export to Wavefront OBJ";
      this.OpenTexture.Filter = "Texture Images|*.png;*.jpg;*.bmp";
      this.SaveScreenPNG.Filter = "Portable network graphics files|*.png";
      this.SaveScreenPNG.Title = "Save screenshot";
      this.ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
      this.ToolStrip.Items.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.ToolStripSeparator2,
        (ToolStripItem) this.Rotate90Left,
        (ToolStripItem) this.Rotate90Right,
        (ToolStripItem) this.Rotate90Up,
        (ToolStripItem) this.Rotate90Down,
        (ToolStripItem) this.ToolStripSeparator1,
        (ToolStripItem) this.ToggleTextureButton,
        (ToolStripItem) this.ToggleWireframeButton,
        (ToolStripItem) this.AxisMarkerToggle,
        (ToolStripItem) this.ToolStripSeparator3
      });
      ToolStrip toolStrip1 = this.ToolStrip;
      point1 = new Point(0, 24);
      Point point18 = point1;
      toolStrip1.Location = point18;
      this.ToolStrip.Name = "ToolStrip";
      this.ToolStrip.RenderMode = ToolStripRenderMode.System;
      ToolStrip toolStrip2 = this.ToolStrip;
      size1 = new Size(856, 38);
      Size size41 = size1;
      toolStrip2.Size = size41;
      this.ToolStrip.TabIndex = 9;
      this.ToolStrip.Text = "ToolStrip1";
      this.ToolStripSeparator2.Name = "ToolStripSeparator2";
      ToolStripSeparator toolStripSeparator2 = this.ToolStripSeparator2;
      size1 = new Size(6, 38);
      Size size42 = size1;
      toolStripSeparator2.Size = size42;
      this.Rotate90Left.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.Rotate90Left.Image = (Image) componentResourceManager.GetObject("Rotate90Left.Image");
      this.Rotate90Left.ImageScaling = ToolStripItemImageScaling.None;
      this.Rotate90Left.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.Rotate90Left.Name = "Rotate90Left";
      ToolStripButton rotate90Left = this.Rotate90Left;
      size1 = new Size(30, 35);
      Size size43 = size1;
      rotate90Left.Size = size43;
      this.Rotate90Left.Text = "Rotate 90 degress -X";
      this.Rotate90Left.ToolTipText = "Rotate 90 degress left";
      this.Rotate90Right.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.Rotate90Right.Image = (Image) componentResourceManager.GetObject("Rotate90Right.Image");
      this.Rotate90Right.ImageScaling = ToolStripItemImageScaling.None;
      this.Rotate90Right.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.Rotate90Right.Name = "Rotate90Right";
      ToolStripButton rotate90Right = this.Rotate90Right;
      size1 = new Size(30, 35);
      Size size44 = size1;
      rotate90Right.Size = size44;
      this.Rotate90Right.Text = "Rotate 90 degress +X";
      this.Rotate90Right.ToolTipText = "Rotate 90 degrees right";
      this.Rotate90Up.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.Rotate90Up.Image = (Image) componentResourceManager.GetObject("Rotate90Up.Image");
      this.Rotate90Up.ImageScaling = ToolStripItemImageScaling.None;
      this.Rotate90Up.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.Rotate90Up.Name = "Rotate90Up";
      ToolStripButton rotate90Up = this.Rotate90Up;
      size1 = new Size(23, 35);
      Size size45 = size1;
      rotate90Up.Size = size45;
      this.Rotate90Up.Text = "Rotate 90 degrees +Y";
      this.Rotate90Up.ToolTipText = "Rotate 90 degrees up";
      this.Rotate90Down.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.Rotate90Down.Image = (Image) componentResourceManager.GetObject("Rotate90Down.Image");
      this.Rotate90Down.ImageScaling = ToolStripItemImageScaling.None;
      this.Rotate90Down.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.Rotate90Down.Name = "Rotate90Down";
      ToolStripButton rotate90Down = this.Rotate90Down;
      size1 = new Size(23, 35);
      Size size46 = size1;
      rotate90Down.Size = size46;
      this.Rotate90Down.Text = "Rotate 90 degrees -Y";
      this.Rotate90Down.ToolTipText = "Rotate 90 degrees down";
      this.ToolStripSeparator1.Name = "ToolStripSeparator1";
      ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
      size1 = new Size(6, 38);
      Size size47 = size1;
      toolStripSeparator1.Size = size47;
      this.ToggleTextureButton.AutoSize = false;
      this.ToggleTextureButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToggleTextureButton.Image = (Image) componentResourceManager.GetObject("ToggleTextureButton.Image");
      this.ToggleTextureButton.ImageScaling = ToolStripItemImageScaling.None;
      this.ToggleTextureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToggleTextureButton.Name = "ToggleTextureButton";
      ToolStripButton toggleTextureButton = this.ToggleTextureButton;
      size1 = new Size(36, 35);
      Size size48 = size1;
      toggleTextureButton.Size = size48;
      this.ToggleTextureButton.Text = "Textures ON";
      this.ToggleWireframeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToggleWireframeButton.Image = (Image) componentResourceManager.GetObject("ToggleWireframeButton.Image");
      this.ToggleWireframeButton.ImageScaling = ToolStripItemImageScaling.None;
      this.ToggleWireframeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ToggleWireframeButton.Name = "ToggleWireframeButton";
      ToolStripButton toggleWireframeButton = this.ToggleWireframeButton;
      size1 = new Size(36, 35);
      Size size49 = size1;
      toggleWireframeButton.Size = size49;
      this.ToggleWireframeButton.Text = "Wireframe OFF";
      this.AxisMarkerToggle.AutoSize = false;
      this.AxisMarkerToggle.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.AxisMarkerToggle.Image = (Image) componentResourceManager.GetObject("AxisMarkerToggle.Image");
      this.AxisMarkerToggle.ImageScaling = ToolStripItemImageScaling.None;
      this.AxisMarkerToggle.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.AxisMarkerToggle.Name = "AxisMarkerToggle";
      ToolStripButton axisMarkerToggle = this.AxisMarkerToggle;
      size1 = new Size(36, 35);
      Size size50 = size1;
      axisMarkerToggle.Size = size50;
      this.AxisMarkerToggle.Text = "Axis Marker ON";
      this.ToolStripSeparator3.Name = "ToolStripSeparator3";
      ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
      size1 = new Size(6, 38);
      Size size51 = size1;
      toolStripSeparator3.Size = size51;
      this.RotateTimer.Interval = 5;
      this.AllowDrop = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(856, 573);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.ToolStrip);
      this.Controls.Add((Control) this.CameraSensitivityScroll);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.StatusStrip);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.MenuStrip);
      this.Controls.Add((Control) this.SimpleOpenGlControl1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.MenuStrip;
      this.Name = "Main";
      this.Text = "Bottles' Glasses 0.80";
      this.MenuStrip.ResumeLayout(false);
      this.MenuStrip.PerformLayout();
      this.StatusStrip.ResumeLayout(false);
      this.StatusStrip.PerformLayout();
      this.CameraSensitivityScroll.EndInit();
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.FileTreeContextMenu.ResumeLayout(false);
      this.ToolStrip.ResumeLayout(false);
      this.ToolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void ParseCurrentCommandLimited()
    {
      byte num = this.N64Dlist[0].Commands[this.CurCMD].CMDDword[0];
      if ((int) num == (int) F3DEX.F3DEX_VTX)
        this.VTX();
      else if ((int) num == (int) F3DEX.F3DEX_TRI1)
      {
        this.TriangleCommands = true;
        this.TRI1();
      }
      else
      {
        if ((int) num != (int) F3DEX.F3DEX_TRI2)
          return;
        this.TriangleCommands = true;
        this.TRI2();
      }
    }

    private void ParseCurrentCommand()
    {
      byte num = this.N64Dlist[0].Commands[this.CurCMD].CMDDword[0];
      if ((int) num == (int) F3DEX.F3DEX_TRI1)
      {
        this.TriangleCommands = true;
        this.TRI1();
      }
      else if ((int) num == (int) F3DEX.F3DEX_TRI2)
      {
        this.TriangleCommands = true;
        this.TRI2();
      }
      else if ((int) num == (int) F3DEX.F3DEX_VTX)
        this.VTX();
      else if ((int) num == 253)
        this.SETTIMG();
      else if ((int) num == 242)
        this.SETTILESIZE((ushort) ((ulong) (this.CMDLow >> 14) & 1023UL), (ushort) ((ulong) (this.CMDLow >> 2) & 1023UL), (ushort) ((ulong) (this.CMDHigh >> 14) & 1023UL), (ushort) ((ulong) (this.CMDHigh >> 2) & 1023UL));
      else if ((int) num == 245)
        this.SETTILE();
      else if ((int) num == 240)
        this.LOADTLUT();
      else if ((int) num == (int) F3DEX.F3DEX_TEXTURE)
        this.TEXTURESCALE();
      else if ((int) num == (int) F3DEX.F3DEX_SETOTHERMODE_L)
        this.SETOTHERMODEL();
      else if ((int) num == (int) F3DEX.F3DEX_SETGEOMETRYMODE)
        this.SETGEOMETRYMODE();
      else if ((int) num == (int) F3DEX.F3DEX_CLEARGEOMETRYMODE)
      {
        this.CLEARGEOMETRYMODE();
      }
      else
      {
        if ((int) num != (int) F3DEX.F3DEX_ENDDL || this.CurCMD <= 0)
          return;
        if ((int) this.N64Dlist[0].Commands[this.CurCMD - 1].CMDDword[0] != (int) F3DEX.F3DEX_VTX)
          Gl.glDisable(3553);
        Gl.glDisable(34820);
      }
    }

    private void VTX()
    {
      try
      {
        if (Functions.Game == 0)
        {
          this.v0 = (byte) ((uint) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[1] >> 1);
          this.n = (byte) ((uint) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[2] >> 2);
        }
        else
        {
          this.n = (byte) (((long) this.CMDLow & 4095L) >> 1);
          this.v0 = (byte) ((ulong) this.n - (ulong) (((long) this.CMDLow & 16773120L) >> 12));
        }
        if ((int) this.v0 > 63)
          this.v0 = (byte) 63;
        this.vtxbegin = (uint) ((ulong) (this.CMDHigh << 8 >> 8) / 16UL);
        uint num1 = this.vtxbegin;
        int v0 = (int) this.v0;
        int num2 = (int) (byte) ((uint) this.n + (uint) this.v0) - 1;
        for (int index = v0; index <= num2; ++index)
        {
          if ((long) num1 < (long) this.Vertices.x.Length)
          {
            this.VertCache.x[index] = this.Vertices.x[(int) num1];
            this.VertCache.y[index] = this.Vertices.y[(int) num1];
            this.VertCache.z[index] = this.Vertices.z[(int) num1];
            this.VertCache.u[index] = this.Vertices.u[(int) num1];
            this.VertCache.v[index] = this.Vertices.v[(int) num1];
            this.VertCache.r[index] = this.Vertices.r[(int) num1];
            this.VertCache.g[index] = this.Vertices.g[(int) num1];
            this.VertCache.b[index] = this.Vertices.b[(int) num1];
            this.VertCache.a[index] = this.Vertices.a[(int) num1];
          }
          num1 = (uint) ((ulong) num1 + 1UL);
        }
        if (this.OBJMode & (int) this.v0 == 0)
          this.OBJData.g.Add((object) ("g VTX_SEG_0x" + Conversion.Hex((long) this.vtxbegin * 16L)));
        if (!(this.NewTexture & this.EnableTEX))
          return;
        this.LoadTex();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("G_VTX ERROR NEED FIX FOR GRUNTY BEAUTIFUL" + Environment.NewLine + Environment.NewLine + ex.Message), MsgBoxStyle.Critical, (object) "Error");
        ProjectData.ClearProjectError();
      }
    }

    private void CLEARGEOMETRYMODE()
    {
      uint num = (uint) (((long) this.CMDHigh & 16777215L) << 8 >> 8);
      bool flag1 = ((long) num & 4096L) != 0L;
      bool flag2 = ((long) num & 8192L) != 0L;
      bool flag3 = ((long) num & 12288L) != 0L;
      this.EnableLighting = ((long) num & 131072L) != 0L;
      if (flag1)
      {
        Gl.glDisable(2884);
      }
      else
      {
        if (!flag2)
          return;
        Gl.glDisable(2884);
      }
    }

    private void SETGEOMETRYMODE()
    {
      uint num = (uint) (((long) this.CMDHigh & 16777215L) << 8 >> 8);
      if (Functions.Game == 0)
      {
        bool flag1 = ((long) num & 4096L) != 0L;
        bool flag2 = ((long) num & 8192L) != 0L;
        bool flag3 = ((long) num & 12288L) != 0L;
        this.EnableLighting = ((long) num & 131072L) != 0L;
        if (flag1)
          Gl.glCullFace(1028);
        else if (flag2)
        {
          Gl.glCullFace(1029);
        }
        else
        {
          if (!flag3)
            return;
          Gl.glCullFace(1032);
        }
        Gl.glEnable(2884);
      }
      else
      {
        uint cmdLow = this.CMDLow;
        this.EnableLighting = ((long) num & 131072L) != 0L;
        this.GEOMODE = this.GEOMODE & cmdLow | num;
        if ((this.GEOMODE & (uint) F3DEX.G_CULL_BACK) > 0U)
        {
          Gl.glEnable(2884);
          Gl.glCullFace(1029);
        }
        else if ((this.GEOMODE & (uint) F3DEX.G_CULL_FRONT) > 0U)
        {
          Gl.glEnable(2884);
          Gl.glCullFace(1028);
        }
        else
          Gl.glDisable(2884);
      }
    }

    private void TRI1()
    {
      try
      {
        if (this.Vertices.x.Length <= 0)
          return;
        if (Functions.Game == 0)
        {
          this.V1 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[5] / 2);
          this.V2 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[6] / 2);
          this.V3 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[7] / 2);
        }
        else
        {
          this.V1 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[1] / 2);
          this.V2 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[2] / 2);
          this.V3 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[3] / 2);
        }
        if (this.OBJMode)
        {
          this.V1 = (short) ((long) this.V1 + (long) this.vtxbegin);
          this.V2 = (short) ((long) this.V2 + (long) this.vtxbegin);
          this.V3 = (short) ((long) this.V3 + (long) this.vtxbegin);
          this.OBJData.vt[(int) this.V1] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V1] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V1] * (float) this.TextureHRatio)));
          this.OBJData.vt[(int) this.V2] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V2] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V2] * (float) this.TextureHRatio)));
          this.OBJData.vt[(int) this.V3] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V3] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V3] * (float) this.TextureHRatio)));
          this.V1 = (short) ((int) this.V1 + 1);
          this.V2 = (short) ((int) this.V2 + 1);
          this.V3 = (short) ((int) this.V3 + 1);
          this.OBJData.g.Add((object) ("f " + Conversions.ToString((int) this.V1) + "/" + Conversions.ToString((int) this.V1) + " " + Conversions.ToString((int) this.V2) + "/" + Conversions.ToString((int) this.V2) + " " + Conversions.ToString((int) this.V3) + "/" + Conversions.ToString((int) this.V3)));
        }
        else if (this.EnableLighting | !this.EnableCC)
        {
          Gl.glBegin(4);
          Gl.glColor3f(1f, 1f, 1f);
          Gl.glNormal3f(this.VertCache.r[(int) this.V1], this.VertCache.g[(int) this.V1], this.VertCache.b[(int) this.V1]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V1] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V1] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V1], (float) this.VertCache.y[(int) this.V1], (float) this.VertCache.z[(int) this.V1]);
          Gl.glNormal3f(this.VertCache.r[(int) this.V2], this.VertCache.g[(int) this.V2], this.VertCache.b[(int) this.V2]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V2] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V2] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V2], (float) this.VertCache.y[(int) this.V2], (float) this.VertCache.z[(int) this.V2]);
          Gl.glNormal3f(this.VertCache.r[(int) this.V3], this.VertCache.g[(int) this.V3], this.VertCache.b[(int) this.V3]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V3] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V3] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V3], (float) this.VertCache.y[(int) this.V3], (float) this.VertCache.z[(int) this.V3]);
          Gl.glEnd();
        }
        else
        {
          Gl.glBegin(4);
          Gl.glColor4f(this.VertCache.r[(int) this.V1], this.VertCache.g[(int) this.V1], this.VertCache.b[(int) this.V1], this.VertCache.a[(int) this.V1]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V1] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V1] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V1], (float) this.VertCache.y[(int) this.V1], (float) this.VertCache.z[(int) this.V1]);
          Gl.glColor4f(this.VertCache.r[(int) this.V2], this.VertCache.g[(int) this.V2], this.VertCache.b[(int) this.V2], this.VertCache.a[(int) this.V2]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V2] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V2] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V2], (float) this.VertCache.y[(int) this.V2], (float) this.VertCache.z[(int) this.V2]);
          Gl.glColor4f(this.VertCache.r[(int) this.V3], this.VertCache.g[(int) this.V3], this.VertCache.b[(int) this.V3], this.VertCache.a[(int) this.V3]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V3] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V3] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V3], (float) this.VertCache.y[(int) this.V3], (float) this.VertCache.z[(int) this.V3]);
          Gl.glEnd();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("F3D_TRI1 ERROR NEED FIX FOR GRUNTY BEAUTIFUL!" + Environment.NewLine + Environment.NewLine + ex.Message), MsgBoxStyle.Critical, (object) "Error");
        Gl.glEnd();
        ProjectData.ClearProjectError();
      }
    }

    private void TRI2()
    {
      try
      {
        if (this.Vertices.x.Length <= 0)
          return;
        this.V1 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[1] / 2);
        this.V2 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[2] / 2);
        this.V3 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[3] / 2);
        this.V4 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[5] / 2);
        this.V5 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[6] / 2);
        this.V6 = (short) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[7] / 2);
        if (this.OBJMode)
        {
          this.V1 = (short) ((long) this.V1 + (long) this.vtxbegin);
          this.V2 = (short) ((long) this.V2 + (long) this.vtxbegin);
          this.V3 = (short) ((long) this.V3 + (long) this.vtxbegin);
          this.V4 = (short) ((long) this.V4 + (long) this.vtxbegin);
          this.V5 = (short) ((long) this.V5 + (long) this.vtxbegin);
          this.V6 = (short) ((long) this.V6 + (long) this.vtxbegin);
          this.OBJData.vt[(int) this.V1] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V1] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V1] * (float) this.TextureHRatio)));
          this.OBJData.vt[(int) this.V2] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V2] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V2] * (float) this.TextureHRatio)));
          this.OBJData.vt[(int) this.V3] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V3] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V3] * (float) this.TextureHRatio)));
          this.OBJData.vt[(int) this.V4] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V4] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V4] * (float) this.TextureHRatio)));
          this.OBJData.vt[(int) this.V5] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V5] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V5] * (float) this.TextureHRatio)));
          this.OBJData.vt[(int) this.V6] = (object) ("vt " + Conversions.ToString((float) this.Vertices.u[(int) this.V6] * (float) this.TextureWRatio) + " " + Conversions.ToString(-((float) this.Vertices.v[(int) this.V6] * (float) this.TextureHRatio)));
          this.V1 = (short) ((int) this.V1 + 1);
          this.V2 = (short) ((int) this.V2 + 1);
          this.V3 = (short) ((int) this.V3 + 1);
          this.V4 = (short) ((int) this.V4 + 1);
          this.V5 = (short) ((int) this.V5 + 1);
          this.V6 = (short) ((int) this.V6 + 1);
          this.OBJData.g.Add((object) ("f " + Conversions.ToString((int) this.V1) + "/" + Conversions.ToString((int) this.V1) + " " + Conversions.ToString((int) this.V2) + "/" + Conversions.ToString((int) this.V2) + " " + Conversions.ToString((int) this.V3) + "/" + Conversions.ToString((int) this.V3)));
          this.OBJData.g.Add((object) ("f " + Conversions.ToString((int) this.V4) + "/" + Conversions.ToString((int) this.V4) + " " + Conversions.ToString((int) this.V5) + "/" + Conversions.ToString((int) this.V5) + " " + Conversions.ToString((int) this.V6) + "/" + Conversions.ToString((int) this.V6)));
        }
        else if (this.EnableLighting | !this.EnableCC)
        {
          Gl.glBegin(4);
          Gl.glColor3f(1f, 1f, 1f);
          Gl.glNormal3f(this.VertCache.r[(int) this.V1], this.VertCache.g[(int) this.V1], this.VertCache.b[(int) this.V1]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V1] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V1] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V1], (float) this.VertCache.y[(int) this.V1], (float) this.VertCache.z[(int) this.V1]);
          Gl.glNormal3f(this.VertCache.r[(int) this.V2], this.VertCache.g[(int) this.V2], this.VertCache.b[(int) this.V2]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V2] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V2] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V2], (float) this.VertCache.y[(int) this.V2], (float) this.VertCache.z[(int) this.V2]);
          Gl.glNormal3f(this.VertCache.r[(int) this.V3], this.VertCache.g[(int) this.V3], this.VertCache.b[(int) this.V3]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V3] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V3] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V3], (float) this.VertCache.y[(int) this.V3], (float) this.VertCache.z[(int) this.V3]);
          Gl.glNormal3f(this.VertCache.r[(int) this.V4], this.VertCache.g[(int) this.V4], this.VertCache.b[(int) this.V4]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V4] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V4] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V4], (float) this.VertCache.y[(int) this.V4], (float) this.VertCache.z[(int) this.V4]);
          Gl.glNormal3f(this.VertCache.r[(int) this.V5], this.VertCache.g[(int) this.V5], this.VertCache.b[(int) this.V5]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V5] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V5] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V5], (float) this.VertCache.y[(int) this.V5], (float) this.VertCache.z[(int) this.V5]);
          Gl.glNormal3f(this.VertCache.r[(int) this.V6], this.VertCache.g[(int) this.V6], this.VertCache.b[(int) this.V6]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V6] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V6] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V6], (float) this.VertCache.y[(int) this.V6], (float) this.VertCache.z[(int) this.V6]);
          Gl.glEnd();
        }
        else
        {
          Gl.glBegin(4);
          Gl.glColor4f(this.VertCache.r[(int) this.V1], this.VertCache.g[(int) this.V1], this.VertCache.b[(int) this.V1], this.VertCache.a[(int) this.V1]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V1] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V1] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V1], (float) this.VertCache.y[(int) this.V1], (float) this.VertCache.z[(int) this.V1]);
          Gl.glColor4f(this.VertCache.r[(int) this.V2], this.VertCache.g[(int) this.V2], this.VertCache.b[(int) this.V2], this.VertCache.a[(int) this.V2]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V2] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V2] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V2], (float) this.VertCache.y[(int) this.V2], (float) this.VertCache.z[(int) this.V2]);
          Gl.glColor4f(this.VertCache.r[(int) this.V3], this.VertCache.g[(int) this.V3], this.VertCache.b[(int) this.V3], this.VertCache.a[(int) this.V3]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V3] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V3] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V3], (float) this.VertCache.y[(int) this.V3], (float) this.VertCache.z[(int) this.V3]);
          Gl.glColor4f(this.VertCache.r[(int) this.V4], this.VertCache.g[(int) this.V4], this.VertCache.b[(int) this.V4], this.VertCache.a[(int) this.V4]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V4] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V4] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V4], (float) this.VertCache.y[(int) this.V4], (float) this.VertCache.z[(int) this.V4]);
          Gl.glColor4f(this.VertCache.r[(int) this.V5], this.VertCache.g[(int) this.V5], this.VertCache.b[(int) this.V5], this.VertCache.a[(int) this.V5]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V5] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V5] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V5], (float) this.VertCache.y[(int) this.V5], (float) this.VertCache.z[(int) this.V5]);
          Gl.glColor4f(this.VertCache.r[(int) this.V6], this.VertCache.g[(int) this.V6], this.VertCache.b[(int) this.V6], this.VertCache.a[(int) this.V6]);
          Gl.glTexCoord2f((float) this.VertCache.u[(int) this.V6] * (float) this.TextureWRatio, (float) this.VertCache.v[(int) this.V6] * (float) this.TextureHRatio);
          Gl.glVertex3f((float) this.VertCache.x[(int) this.V6], (float) this.VertCache.y[(int) this.V6], (float) this.VertCache.z[(int) this.V6]);
          Gl.glEnd();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("F3D_TRI2 ERROR NEED FIX FOR GRUNTY BEAUTIFUL!" + Environment.NewLine + Environment.NewLine + ex.Message), MsgBoxStyle.Critical, (object) "Error");
        Gl.glEnd();
        ProjectData.ClearProjectError();
      }
    }

    private void TEXTURESCALE()
    {
      this.S_Scale = (double) (this.CMDHigh >> 16) / 65536.0;
      this.T_Scale = (double) ((long) this.CMDHigh & (long) ushort.MaxValue) / 65536.0;
    }

    private void SETOTHERMODEL()
    {
      byte num1 = (byte) ((ulong) (this.CMDHigh >> 10) & 3UL);
      byte num2 = (byte) ((ulong) (this.CMDHigh >> 12) & 1UL);
      byte num3 = (byte) ((ulong) (this.CMDHigh >> 14) & 1UL);
      byte num4 = (byte) ((ulong) (this.CMDHigh >> 13) & 1UL);
      byte num5 = (byte) ((ulong) (this.CMDHigh >> 4) & 1UL);
      byte num6 = (byte) ((ulong) (this.CMDHigh >> 5) & 1UL);
      switch (32L - ((long) (this.CMDLow >> 8) & (long) byte.MaxValue) - ((long) this.CMDLow & (long) byte.MaxValue) - 1L)
      {
        case 3:
          if ((int) num1 == 3)
          {
            Gl.glEnable(32823);
            Gl.glPolygonOffset(-3f, -3f);
          }
          else
            Gl.glDisable(32823);
          if ((int) num2 == 1)
            Gl.glEnable(3042);
          else
            Gl.glDisable(3042);
          if ((int) num3 == 1)
          {
            Gl.glAlphaFunc(516, 0.0f);
            Gl.glEnable(3008);
            break;
          }
          Gl.glDisable(3008);
          if ((int) num5 == 1)
          {
            Gl.glDepthFunc(515);
            Gl.glEnable(2929);
            break;
          }
          Gl.glDisable(2929);
          break;
      }
    }

    private void SETTILESIZE(ushort ULS, ushort ULT, ushort LRS, ushort LRT)
    {
      this.TextureW = (int) (ushort) ((uint) LRS - (uint) ULS) + 1;
      this.TextureH = (int) (ushort) ((uint) LRT - (uint) ULT) + 1;
      this.TextureHRatio = this.T_Scale / 32.0 / (double) this.TextureH;
      this.TextureWRatio = this.S_Scale / 32.0 / (double) this.TextureW;
    }

    private void LOADTLUT()
    {
      int num1 = (int) ((((long) (this.CMDHigh << 8 >> 8) & 16773120L) >> 14) * 2L + 2L);
      this.Palette = new byte[num1 - 1 + 1];
      int num2 = 0;
      int num3 = num1 - 1;
      for (int index = num2; index <= num3; ++index)
        this.Palette[index] = this.MTexBuffer[this.Paloff + index];
      this.Extracted.r.Clear();
      this.Extracted.g.Clear();
      this.Extracted.b.Clear();
      this.Extracted.a.Clear();
      int num4 = 0;
      int num5 = num1 - 1;
      int index1 = num4;
      while (index1 <= num5)
      {
        byte num6 = (byte) ((uint) this.Palette[index1] >> 3);
        ushort num7 = (ushort) ((uint) (ushort) ((uint) (ushort) ((uint) (ushort) ((uint) this.Palette[index1] * 256U ^ (uint) this.Palette[index1 + 1]) >> 6) << 11) >> 11);
        byte num8 = (byte) ((uint) (byte) ((uint) (byte) ((uint) this.Palette[index1 + 1] >> 1) << 3) >> 3);
        byte num9 = (byte) ((uint) (byte) ((uint) this.Palette[index1 + 1] << 7) >> 7);
        this.Extracted.r.Add((object) ((int) num6 * 8));
        this.Extracted.g.Add((object) ((int) num7 * 8));
        this.Extracted.b.Add((object) ((int) num8 * 8));
        this.Extracted.a.Add((object) ((int) num9 * (int) byte.MaxValue));
        index1 += 2;
      }
    }

    private void DRAWPOINTS()
    {
      Gl.glPointSize(14f);
      Gl.glEnable(2832);
      Gl.glBegin(0);
      int num1 = 0;
      int num2 = this.Vertices.x.Length - 1;
      for (int index = num1; index <= num2; ++index)
      {
        Gl.glColor3f(this.Vertices.r[index], this.Vertices.g[index], this.Vertices.b[index]);
        Gl.glVertex3f((float) this.Vertices.x[index], (float) this.Vertices.y[index], (float) this.Vertices.z[index]);
      }
      Gl.glEnd();
    }

    private void SETTIMG()
    {
      Gl.glDisable(3553);
      if (!this.EnableTEX)
        return;
      int n = 1;
      int num1 = 0;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      int& textures = @num1;
      Gl.glDeleteTextures(n, textures);
      Gl.glBindTexture(3553, 1);
      int num2 = (int) (this.CMDHigh << 8 >> 8);
      if (((int) this.N64Dlist[0].Commands[this.CurCMD + 1].CMDDword[0] == 245 | (int) this.N64Dlist[0].Commands[this.CurCMD + 1].CMDDword[0] == 240) & (int) this.N64Dlist[0].Commands[this.CurCMD + 1].CMDDword[1] == 0)
      {
        this.Paloff = num2;
      }
      else
      {
        this.TIMGOffset = num2;
        Gl.glEnable(3553);
        this.NewTexture = true;
      }
      int num3 = 0;
      int num4 = this.Textures.Length - 1;
      for (int index = num3; index <= num4; ++index)
      {
        if (this.Textures[index].offset == num2 | this.Textures[index].offset + 32 == num2)
        {
          this.SETTILESIZE((ushort) 0, (ushort) 0, (ushort) (this.Textures[index].width - 1), (ushort) (this.Textures[index].height - 1));
          this.TexBytes = this.Textures[index].size;
          break;
        }
      }
    }

    private void SETTILE()
    {
      this.TexFormat = (uint) ((ulong) (this.CMDLow >> 21) & 7UL);
      this.TexelSize = (uint) ((ulong) (this.CMDLow >> 19) & 3UL);
      this.LineSize = (uint) ((ulong) (this.CMDLow >> 9) & 15UL);
      this.CMT = (uint) ((ulong) (this.CMDHigh >> 18) & 2UL);
      this.CMS = (uint) ((ulong) (this.CMDHigh >> 8) & 3UL);
    }

    private void LoadTex()
    {
      try
      {
        if ((long) this.TexelSize < 3L)
        {
          uint num1 = 0;
          uint num2 = 0;
          this.N64TexIMG = new byte[this.TexBytes - 1 + 1];
          this.OGLTexIMG = new byte[this.TexBytes * 4 - 1 + 1];
          this.CurrFileStream.Position = (long) (this.TIMGOffset + this.TexStart);
          this.CurrFileStream.Read(this.N64TexIMG, 0, this.TexBytes);
          switch (this.TexFormat)
          {
            case 0:
              if ((int) this.TexelSize == 2)
              {
                int num3 = 0;
                int num4 = this.TextureH - 1;
                for (int index1 = num3; index1 <= num4; ++index1)
                {
                  int num5 = 0;
                  int num6 = this.TextureW - 1;
                  for (int index2 = num5; index2 <= num6; ++index2)
                  {
                    ushort num7 = (ushort) ((uint) this.N64TexIMG[(int) num2] * 256U + (uint) this.N64TexIMG[(int) ((long) num2 + 1L)]);
                    byte num8 = ((uint) num7 & 1U) <= 0U ? (byte) 0 : byte.MaxValue;
                    this.OGLTexIMG[(int) num1] = (byte) (((int) num7 & 63488) >> 8);
                    this.OGLTexIMG[(int) ((long) num1 + 1L)] = (byte) (((int) num7 & 1984) << 5 >> 8);
                    this.OGLTexIMG[(int) ((long) num1 + 2L)] = (byte) (((int) num7 & 62) << 18 >> 16);
                    this.OGLTexIMG[(int) ((long) num1 + 3L)] = num8;
                    num2 = (uint) ((ulong) num2 + 2UL);
                    num1 = (uint) ((ulong) num1 + 4UL);
                  }
                  if ((long) this.LineSize > 0L)
                    num2 = (uint) ((ulong) num2 + ((ulong) this.LineSize * 4UL - (ulong) this.TextureW));
                }
                break;
              }
              break;
            case 2:
              switch (this.TexelSize)
              {
                case 0:
                  int num9 = 0;
                  int num10 = this.TextureH - 1;
                  for (int index1 = num9; index1 <= num10; ++index1)
                  {
                    int num3 = 0;
                    int num4 = this.TextureW / 2 - 1;
                    for (int index2 = num3; index2 <= num4; ++index2)
                    {
                      byte num5 = (byte) ((uint) this.N64TexIMG[(int) num2] >> 4);
                      byte num6 = (byte) ((uint) (byte) ((uint) this.N64TexIMG[(int) num2] << 4) >> 4);
                      this.OGLTexIMG[(int) num1] = Conversions.ToByte(this.Extracted.r[(int) num5]);
                      this.OGLTexIMG[(int) ((long) num1 + 1L)] = Conversions.ToByte(this.Extracted.g[(int) num5]);
                      this.OGLTexIMG[(int) ((long) num1 + 2L)] = Conversions.ToByte(this.Extracted.b[(int) num5]);
                      this.OGLTexIMG[(int) ((long) num1 + 3L)] = Conversions.ToByte(this.Extracted.a[(int) num5]);
                      this.OGLTexIMG[(int) ((long) num1 + 4L)] = Conversions.ToByte(this.Extracted.r[(int) num6]);
                      this.OGLTexIMG[(int) ((long) num1 + 5L)] = Conversions.ToByte(this.Extracted.g[(int) num6]);
                      this.OGLTexIMG[(int) ((long) num1 + 6L)] = Conversions.ToByte(this.Extracted.b[(int) num6]);
                      this.OGLTexIMG[(int) ((long) num1 + 7L)] = Conversions.ToByte(this.Extracted.a[(int) num6]);
                      num2 = (uint) ((ulong) num2 + 1UL);
                      num1 = (uint) ((ulong) num1 + 8UL);
                    }
                    num2 = (uint) ((ulong) num2 + ((ulong) this.LineSize * 8UL - (ulong) (this.TextureW / 2)));
                  }
                  break;
                case 1:
                  int num11 = 0;
                  int num12 = this.TextureH - 1;
                  for (int index1 = num11; index1 <= num12; ++index1)
                  {
                    int num3 = 0;
                    int num4 = this.TextureW - 1;
                    for (int index2 = num3; index2 <= num4; ++index2)
                    {
                      byte num5 = this.N64TexIMG[(int) num2];
                      this.OGLTexIMG[(int) num1] = Conversions.ToByte(this.Extracted.r[(int) num5]);
                      this.OGLTexIMG[(int) ((long) num1 + 1L)] = Conversions.ToByte(this.Extracted.g[(int) num5]);
                      this.OGLTexIMG[(int) ((long) num1 + 2L)] = Conversions.ToByte(this.Extracted.b[(int) num5]);
                      this.OGLTexIMG[(int) ((long) num1 + 3L)] = Conversions.ToByte(this.Extracted.a[(int) num5]);
                      num2 = (uint) ((ulong) num2 + 1UL);
                      num1 = (uint) ((ulong) num1 + 4UL);
                    }
                    num2 = (uint) ((ulong) num2 + ((ulong) this.LineSize * 8UL - (ulong) this.TextureW));
                  }
                  break;
              }
            case 3:
              switch (this.TexelSize)
              {
                case 1:
                  int num13 = 0;
                  int num14 = this.TextureH - 1;
                  for (int index1 = num13; index1 <= num14; ++index1)
                  {
                    int num3 = 0;
                    int num4 = this.TextureW - 1;
                    for (int index2 = num3; index2 <= num4; ++index2)
                    {
                      byte num5 = (byte) ((uint) this.N64TexIMG[(int) num2] >> 4);
                      byte num6 = (byte) ((uint) (byte) ((uint) this.N64TexIMG[(int) num2] << 4) >> 4);
                      this.OGLTexIMG[(int) num1] = (byte) ((uint) num5 * 17U);
                      this.OGLTexIMG[(int) ((long) num1 + 1L)] = (byte) ((uint) num5 * 17U);
                      this.OGLTexIMG[(int) ((long) num1 + 2L)] = (byte) ((uint) num5 * 17U);
                      this.OGLTexIMG[(int) ((long) num1 + 3L)] = (byte) ((uint) num6 * 17U);
                      num2 = (uint) ((ulong) num2 + 1UL);
                      num1 = (uint) ((ulong) num1 + 4UL);
                    }
                    num2 = (uint) ((ulong) num2 + ((ulong) this.LineSize * 8UL - (ulong) this.TextureW));
                  }
                  break;
                case 2:
                  int num15 = 0;
                  int num16 = this.TextureH - 1;
                  for (int index1 = num15; index1 <= num16; ++index1)
                  {
                    int num3 = 0;
                    int num4 = this.TextureW - 1;
                    for (int index2 = num3; index2 <= num4; ++index2)
                    {
                      byte num5 = this.N64TexIMG[(int) num2];
                      byte num6 = this.N64TexIMG[(int) ((long) num2 + 1L)];
                      this.OGLTexIMG[(int) num1] = num5;
                      this.OGLTexIMG[(int) ((long) num1 + 1L)] = num5;
                      this.OGLTexIMG[(int) ((long) num1 + 2L)] = num5;
                      this.OGLTexIMG[(int) ((long) num1 + 3L)] = num6;
                      num2 = (uint) ((ulong) num2 + 2UL);
                      num1 = (uint) ((ulong) num1 + 4UL);
                    }
                    num2 = (uint) ((ulong) num2 + ((ulong) this.LineSize * 4UL - (ulong) this.TextureW));
                  }
                  break;
              }
            case 4:
              switch (this.TexelSize)
              {
                case 0:
                  int num17 = 0;
                  int num18 = this.TexBytes / 2 - 1;
                  for (int index = num17; index <= num18; ++index)
                  {
                    byte num3 = (byte) ((uint) this.N64TexIMG[index] >> 4);
                    this.OGLTexIMG[index * 8] = (byte) ((uint) num3 * 17U);
                    this.OGLTexIMG[index * 8 + 1] = (byte) ((uint) num3 * 17U);
                    this.OGLTexIMG[index * 8 + 2] = (byte) ((uint) num3 * 17U);
                    this.OGLTexIMG[index * 8 + 3] = (byte) ((uint) num3 * 17U);
                    byte num4 = (byte) ((uint) (byte) ((uint) this.N64TexIMG[index] << 4) >> 4);
                    this.OGLTexIMG[index * 8 + 4] = (byte) ((uint) num4 * 17U);
                    this.OGLTexIMG[index * 8 + 5] = (byte) ((uint) num4 * 17U);
                    this.OGLTexIMG[index * 8 + 6] = (byte) ((uint) num4 * 17U);
                    this.OGLTexIMG[index * 8 + 7] = (byte) ((uint) num4 * 17U);
                  }
                  break;
                case 1:
                  int num19 = 0;
                  int num20 = this.TexBytes / 4 - 1;
                  for (int index = num19; index <= num20; ++index)
                  {
                    byte num3 = (byte) ((uint) this.N64TexIMG[index] / 16U);
                    this.OGLTexIMG[index * 4] = (byte) ((uint) num3 * 17U);
                    this.OGLTexIMG[index * 4 + 1] = (byte) ((uint) num3 * 17U);
                    this.OGLTexIMG[index * 4 + 2] = (byte) ((uint) num3 * 17U);
                    this.OGLTexIMG[index * 4 + 3] = (byte) ((uint) num3 * 17U);
                  }
                  break;
              }
          }
          Gl.glBindTexture(3553, 0);
          Gl.glTexImage2D(3553, 0, 6408, this.TextureW, this.TextureH, 0, 6408, 5121, (object) this.OGLTexIMG);
        }
        else
        {
          this.N64TexIMG = new byte[this.TexBytes - 1 + 1];
          this.CurrFileStream.Position = (long) (this.TIMGOffset + this.TexStart);
          this.CurrFileStream.Read(this.N64TexIMG, 0, this.TexBytes);
          Gl.glBindTexture(3553, 0);
          Gl.glTexImage2D(3553, 0, 6408, this.TextureW, this.TextureH, 0, 6408, 5121, (object) this.N64TexIMG);
        }
        switch (this.CMS)
        {
          case 0:
            Gl.glTexParameteri(3553, 10242, 10497);
            break;
          case 2:
            Gl.glTexParameteri(3553, 10242, 33071);
            break;
        }
        switch (this.CMT)
        {
          case 0:
            Gl.glTexParameteri(3553, 10243, 10497);
            break;
          case 2:
            Gl.glTexParameteri(3553, 10243, 33071);
            break;
        }
        if (this.OBJMode)
        {
          string str = "0x" + Conversion.Hex(this.TIMGOffset);
          if (!this.OBJTextures.Contains((object) this.TIMGOffset))
          {
            this.OBJTextures.Add((object) this.TIMGOffset);
            string FileName = this.subdir + str + ".png";
            if ((long) this.TexelSize == 3L)
              Il.ilLoadDataL(this.N64TexIMG, this.TexBytes * 4, this.TextureW, this.TextureH, 1, (byte) 4);
            else if ((long) this.TexelSize == 2L & (long) this.TexFormat == 0L)
              Il.ilLoadDataL(this.OGLTexIMG, this.TexBytes * 4, this.TextureW, this.TextureH, 1, (byte) 4);
            else
              Il.ilLoadDataL(this.OGLTexIMG, this.TexBytes * 4, this.TextureW, this.TextureH, 1, (byte) 4);
            Il.ilSave(1066, FileName);
            this.mtlfile.WriteLine("newmtl SETTIMG_SEG_" + str);
            this.mtlfile.WriteLine("map_Ka " + str + ".png");
          }
          this.OBJData.g.Add((object) ("usemtl SETTIMG_SEG_" + str));
        }
        this.N64TexIMG = new byte[0];
        this.OGLTexIMG = new byte[0];
        this.NewTexture = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Gl.glDisable(3553);
        this.NewTexture = false;
        ProjectData.ClearProjectError();
      }
    }

    private void StoreMasterVertBuff(ref Main.Vertex3D Vertices, byte[] DataBuffer, int baseoffset, int endoffset, int lpcnt)
    {
      Vertices.x = new short[lpcnt + 1];
      Vertices.y = new short[lpcnt + 1];
      Vertices.z = new short[lpcnt + 1];
      Vertices.u = new short[lpcnt + 1];
      Vertices.v = new short[lpcnt + 1];
      Vertices.r = new float[lpcnt + 1];
      Vertices.g = new float[lpcnt + 1];
      Vertices.b = new float[lpcnt + 1];
      Vertices.a = new float[lpcnt + 1];
      int num1 = 0;
      int num2 = lpcnt;
      for (this.i3 = num1; this.i3 <= num2; ++this.i3)
      {
        this.x = (short) ((int) DataBuffer[baseoffset] * 256 + (int) DataBuffer[baseoffset + 1]);
        this.y = (short) ((int) DataBuffer[baseoffset + 2] * 256 + (int) DataBuffer[baseoffset + 3]);
        this.z = (short) ((int) DataBuffer[baseoffset + 4] * 256 + (int) DataBuffer[baseoffset + 5]);
        this.u = (short) ((int) DataBuffer[baseoffset + 8] * 256 + (int) DataBuffer[baseoffset + 9]);
        this.v = (short) ((int) DataBuffer[baseoffset + 10] * 256 + (int) DataBuffer[baseoffset + 11]);
        this.r = (double) DataBuffer[baseoffset + 12] / (double) byte.MaxValue;
        this.g = (double) DataBuffer[baseoffset + 13] / (double) byte.MaxValue;
        this.b = (double) DataBuffer[baseoffset + 14] / (double) byte.MaxValue;
        this.a = (double) DataBuffer[baseoffset + 15] / (double) byte.MaxValue;
        Vertices.x[this.i3] = this.x;
        Vertices.y[this.i3] = this.y;
        Vertices.z[this.i3] = this.z;
        Vertices.u[this.i3] = this.u;
        Vertices.v[this.i3] = this.v;
        Vertices.r[this.i3] = (float) this.r;
        Vertices.g[this.i3] = (float) this.g;
        Vertices.b[this.i3] = (float) this.b;
        Vertices.a[this.i3] = (float) this.a;
        baseoffset += 16;
      }
    }

    private void StoreCommands(byte[] DataBuffer, Main.DisplayList[] N64Dlist)
    {
      int startpos = N64Dlist[0].startpos;
      N64Dlist[0].Commands = (Main.DLCommand[]) Utils.CopyArray((Array) N64Dlist[0].Commands, (Array) new Main.DLCommand[N64Dlist[0].CommandCount - 1 + 1]);
      int num1 = 0;
      int num2 = N64Dlist[0].CommandCount - 1;
      for (this.CurCMD = num1; this.CurCMD <= num2; ++this.CurCMD)
      {
        N64Dlist[0].Commands[this.CurCMD].CMDDword = new byte[8];
        this.i2 = 0;
        do
        {
          N64Dlist[0].Commands[this.CurCMD].CMDDword[this.i2] = DataBuffer[startpos + this.i2];
          ++this.i2;
        }
        while (this.i2 <= 7);
        startpos += 8;
      }
    }

    private Main.OGLModel[] F3D_To_OpenGL(ref Main.DisplayList[] N64Dlist, ref Main.OGLModel[] OGLDList)
    {
      OGLDList = new Main.OGLModel[1];
      OGLDList[0].DList = (uint) Gl.glGenLists(1);
      Gl.glNewList(OGLDList[0].DList, 4864);
      int num1 = 0;
      int num2 = N64Dlist[0].CommandCount - 1;
      for (this.CurCMD = num1; this.CurCMD <= num2; ++this.CurCMD)
      {
        this.CMDHigh = (uint) ((int) N64Dlist[0].Commands[this.CurCMD].CMDDword[4] * 16777216 + (int) N64Dlist[0].Commands[this.CurCMD].CMDDword[5] * 65536 + (int) N64Dlist[0].Commands[this.CurCMD].CMDDword[6] * 256) + (uint) N64Dlist[0].Commands[this.CurCMD].CMDDword[7];
        this.CMDLow = (uint) ((int) N64Dlist[0].Commands[this.CurCMD].CMDDword[1] * 65536 + (int) N64Dlist[0].Commands[this.CurCMD].CMDDword[2] * 256) + (uint) N64Dlist[0].Commands[this.CurCMD].CMDDword[3];
        this.ParseCurrentCommand();
      }
      if (!this.TriangleCommands)
        this.DRAWPOINTS();
      Gl.glEndList();
      int n = 1;
      int num3 = 0;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      int& textures = @num3;
      Gl.glDeleteTextures(n, textures);
      return OGLDList;
    }

    private void GLInit()
    {
      Wgl.wglSwapIntervalEXT(1);
      Gl.glTexParameterf(3553, 34046, this.MaxAnisotropy[0]);
      Gl.glBindTexture(3553, 0);
      Gl.glTexParameteri(3553, 10240, 9729);
      Gl.glTexParameteri(3553, 10241, 9729);
      Gl.glEnable(2929);
      Gl.glEnable(3042);
      Gl.glShadeModel(7425);
      Gl.glDepthFunc(515);
      Gl.glPolygonOffset(-3f, -3f);
      Gl.glBlendFunc(770, 771);
      Gl.glHint(3152, 4354);
      Gl.glClearColor(0.2f, 0.5f, 0.8f, 1f);
      this.ResizeScene();
    }

    private void BuildAxisMarker()
    {
      Gl.glLineWidth(0.5f);
      this.LineList = (uint) Gl.glGenLists(1);
      Gl.glNewList(this.LineList, 4864);
      Gl.glBegin(1);
      Gl.glColor3f(1f, 0.0f, 0.0f);
      Gl.glVertex3f(420f, 0.1f, 0.1f);
      Gl.glVertex3f(-420f, 0.1f, 0.1f);
      Gl.glEnd();
      Gl.glBegin(1);
      Gl.glColor3f(0.0f, 1f, 0.0f);
      Gl.glVertex3f(0.1f, 420f, 0.1f);
      Gl.glVertex3f(0.1f, -420f, 0.1f);
      Gl.glEnd();
      Gl.glBegin(1);
      Gl.glColor3f(0.0f, 0.0f, 1f);
      Gl.glVertex3f(0.1f, 0.1f, 420f);
      Gl.glVertex3f(0.1f, 0.1f, -420f);
      Gl.glVertex3f(0.1f, 0.1f, 420f);
      Gl.glEnd();
      Gl.glEndList();
      Gl.glLineWidth(1f);
    }

    private void ParseModel()
    {
      if (!File.Exists(Functions.CurrModel))
        return;
      this.DataBuffer = File.ReadAllBytes(Functions.CurrModel);
      this.CurrFileStream = new FileStream(Functions.CurrModel, FileMode.Open);
      if ((int) this.DataBuffer[3] != 11)
      {
        int num = (int) Interaction.MsgBox((object) "File loaded is not a BK or BT model!", MsgBoxStyle.OkOnly, (object) null);
        Functions.CurrModel = "Nothing loaded";
        this.CurrFileStream.Dispose();
        this.DataBuffer = new byte[0];
      }
      else
      {
        this.TriangleCommands = false;
        this.ProgressBar1.Value = 10;
        this.VertCache.x = new short[64];
        this.VertCache.y = new short[64];
        this.VertCache.z = new short[64];
        this.VertCache.u = new short[64];
        this.VertCache.v = new short[64];
        this.VertCache.r = new float[64];
        this.VertCache.g = new float[64];
        this.VertCache.b = new float[64];
        this.VertCache.a = new float[64];
        this.N64TexIMG = new byte[0];
        this.OGLTexIMG = new byte[0];
        this.N64Dlist = new Main.DisplayList[1];
        uint num1 = 0;
        int index1 = this.N64Dlist.Length - 1;
        this.ProgressBar1.Value = 20;
        num1 = (uint) ((int) this.DataBuffer[4] * 16777216 + (int) this.DataBuffer[5] * 65536 + (int) this.DataBuffer[6] * 256 + (int) this.DataBuffer[7] + 24);
        this.N64Dlist[index1].startpos = (int) this.DataBuffer[12] * 16777216 + (int) this.DataBuffer[13] * 65536 + (int) this.DataBuffer[14] * 256 + (int) this.DataBuffer[15] + 8;
        this.N64Dlist[index1].CommandCount = (int) this.DataBuffer[this.N64Dlist[index1].startpos - 6] * 256 + (int) this.DataBuffer[this.N64Dlist[index1].startpos - 5];
        this.N64Dlist[index1].endpos = this.N64Dlist[index1].startpos + this.N64Dlist[index1].CommandCount * 8;
        this.baseoffset = (int) this.DataBuffer[16] * 16777216 + (int) this.DataBuffer[17] * 65536 + (int) this.DataBuffer[18] * 256 + (int) this.DataBuffer[19] + 24;
        int num2 = 0;
        if (Functions.Game == 1)
        {
          int index2 = 88;
          this.VTCount = (int) this.DataBuffer[70] * 256 + (int) this.DataBuffer[71] - 1;
          int num3 = (int) this.DataBuffer[84] * 256 + (int) this.DataBuffer[85];
          if (num3 > 0)
          {
            num2 = (int) this.DataBuffer[81] * 65536 + (int) this.DataBuffer[82] * 256 + (int) this.DataBuffer[83] - num3 * 8 - 8;
            this.TexStart = index2 + num3 * 8;
            this.MTexBuffer = new byte[num2 - 1 + 1];
            this.Textures = new Main.TexBuffer[num3 - 1 + 1];
            int num4 = 0;
            int num5 = num3 - 1;
            for (int index3 = num4; index3 <= num5; ++index3)
            {
              this.Textures[index3] = new Main.TexBuffer();
              this.Textures[index3].offset = (int) this.DataBuffer[index2] * 16777216 + (int) this.DataBuffer[index2 + 1] * 65536 + (int) this.DataBuffer[index2 + 2] * 256 + (int) this.DataBuffer[index2 + 3];
              this.Textures[index3].width = (int) this.DataBuffer[index2 + 6];
              this.Textures[index3].height = (int) this.DataBuffer[index2 + 7];
              this.Textures[index3].size = this.Textures[index3].width * this.Textures[index3].height * 8;
              index2 += 8;
            }
          }
        }
        else
        {
          int index2 = 64;
          this.VTCount = (int) this.DataBuffer[50] * 256 + (int) this.DataBuffer[51] - 1;
          int num3 = (int) this.DataBuffer[60] * 256 + (int) this.DataBuffer[61];
          num2 = (int) this.DataBuffer[57] * 65536 + (int) this.DataBuffer[58] * 256 + (int) this.DataBuffer[59] - num3 * 16 - 8;
          this.TexStart = index2 + num3 * 16;
          this.MTexBuffer = new byte[num2 - 1 + 1];
          this.Textures = new Main.TexBuffer[num3 - 1 + 1];
          int num4 = 0;
          int num5 = num3 - 1;
          for (int index3 = num4; index3 <= num5; ++index3)
          {
            this.Textures[index3] = new Main.TexBuffer();
            this.Textures[index3].offset = (int) this.DataBuffer[index2] * 16777216 + (int) this.DataBuffer[index2 + 1] * 65536 + (int) this.DataBuffer[index2 + 2] * 256 + (int) this.DataBuffer[index2 + 3];
            this.Textures[index3].width = (int) this.DataBuffer[index2 + 8];
            this.Textures[index3].height = (int) this.DataBuffer[index2 + 9];
            this.Textures[index3].size = this.Textures[index3].width * this.Textures[index3].height * 8;
            index2 += 16;
          }
        }
        if (this.TexStart + num2 <= this.DataBuffer.Length)
        {
          int num3 = 0;
          int num4 = num2 - 1;
          for (int index2 = num3; index2 <= num4; ++index2)
            this.MTexBuffer[index2] = this.DataBuffer[this.TexStart + index2];
        }
        this.endoffset = this.baseoffset + this.VTCount * 16;
        if (this.endoffset == 0)
          this.endoffset = this.DataBuffer.Length - 12;
        this.StoreMasterVertBuff(ref this.Vertices, this.DataBuffer, this.baseoffset, this.endoffset, this.VTCount);
        this.ProgressBar1.Value = 40;
        this.StoreCommands(this.DataBuffer, this.N64Dlist);
        this.ProgressBar1.Value = 70;
        this.OGLDList = this.F3D_To_OpenGL(ref this.N64Dlist, ref this.OGLDList);
        this.ProgressBar1.Value = 100;
        this.CurrFileStream.Dispose();
        this.ProgressBar1.Value = 0;
      }
    }

    private void MainLoop()
    {
      this.GLInit();
      while (true)
      {
        Application.DoEvents();
        this.DrawMain();
        this.SimpleOpenGlControl1.Invalidate();
      }
    }

    private void DrawMain()
    {
      Gl.glClear(16640);
      Gl.glLoadIdentity();
      this.yrotad = (double) this.yrot / 180.0 * 3.14159265;
      this.xrotad = (double) this.xrot / 180.0 * 3.14159265;
      this.zrotad = (double) this.zrot / 180.0 * 3.14159265;
      if (this.key_w)
      {
        if ((double) this.xrot >= 85.0 | (double) this.xrot <= -85.0)
        {
          this.finaly = this.finaly + Math.Sin(this.xrotad) * this.Run;
        }
        else
        {
          this.finalx = this.finalx - Math.Sin(this.yrotad) * this.Run;
          this.finalz = this.finalz + Math.Cos(this.yrotad) * this.Run;
          this.finaly = this.finaly + Math.Sin(this.xrotad) * this.Run;
        }
      }
      if (this.key_s)
      {
        if ((double) this.xrot <= -85.0 | (double) this.xrot >= 85.0)
        {
          this.finaly = this.finaly - Math.Sin(this.xrotad) * this.Run;
        }
        else
        {
          this.finalx = this.finalx + Math.Sin(this.yrotad) * this.Run;
          this.finalz = this.finalz - Math.Cos(this.yrotad) * this.Run;
          this.finaly = this.finaly - Math.Sin(this.xrotad) * this.Run;
        }
      }
      if (this.key_d)
      {
        this.finalx = this.finalx - Math.Cos(this.yrotad) * this.Run;
        this.finalz = this.finalz - Math.Sin(this.yrotad) * this.Run;
      }
      if (this.key_a)
      {
        this.finalx = this.finalx + Math.Cos(this.yrotad) * this.Run;
        this.finalz = this.finalz + Math.Sin(this.yrotad) * this.Run;
      }
      Point mousePosition1 = Control.MousePosition;
      this.newx = mousePosition1.X;
      mousePosition1 = Control.MousePosition;
      this.newy = mousePosition1.Y;
      if (this.RotateSceneClick)
      {
        if (this.oldx < this.newx)
          this.yrot = this.yrot + (float) (this.newx - this.oldx) * 0.25f;
        if (this.oldx > this.newx)
          this.yrot = this.yrot - (float) (this.oldx - this.newx) * 0.25f;
        if (this.oldy > this.newy)
          this.xrot = this.InvertY ? ((double) this.xrot < 90.0 ? this.xrot + (float) (this.oldy - this.newy) * 0.25f : 90f) : ((double) this.xrot > -90.0 ? this.xrot - (float) (this.oldy - this.newy) * 0.25f : -90f);
        if (this.oldy < this.newy)
          this.xrot = this.InvertY ? ((double) this.xrot > -90.0 ? this.xrot - (float) (this.newy - this.oldy) * 0.25f : -90f) : ((double) this.xrot < 90.0 ? this.xrot + (float) (this.newy - this.oldy) * 0.25f : 90f);
      }
      if (this.GoStrafe)
      {
        if (this.oldy > this.newy)
          this.finaly = this.finaly - (double) ((this.oldy - this.newy) * 4);
        if (this.oldy < this.newy)
          this.finaly = this.finaly + (double) ((this.newy - this.oldy) * 4);
      }
      Point mousePosition2 = Control.MousePosition;
      this.oldx = mousePosition2.X;
      mousePosition2 = Control.MousePosition;
      this.oldy = mousePosition2.Y;
      Gl.glPushMatrix();
      Gl.glRotatef(this.xrot, 1f, 0.0f, 0.0f);
      Gl.glRotatef(this.yrot, 0.0f, 1f, 0.0f);
      Gl.glRotatef(this.zrot, 0.0f, 0.0f, 1f);
      Gl.glTranslatef((float) this.finalx, (float) this.finaly, (float) this.finalz);
      if ((long) this.OGLDList[0].DList > 0L)
        this.DrawDList();
      Gl.glPopMatrix();
      this.SimpleOpenGlControl1.SwapBuffers();
    }

    private void DrawCollision()
    {
      Gl.glPointSize(10f);
      Gl.glBegin(0);
      Gl.glColor3f(1f, 0.0f, 0.0f);
      int num1 = 0;
      int num2 = this.CollisionVerts.x.Length - 1;
      for (int index = num1; index <= num2; ++index)
        Gl.glVertex3f((float) this.CollisionVerts.x[index], (float) this.CollisionVerts.y[index], (float) this.CollisionVerts.z[index]);
      Gl.glEnd();
    }

    private void DrawDList()
    {
      try
      {
        if (this.EnableAxisMarker)
        {
          Gl.glPushMatrix();
          Gl.glLineWidth(10f);
          Gl.glCallList(this.LineList);
          Gl.glLineWidth(1f);
          Gl.glPopMatrix();
        }
        int num1 = 0;
        int num2 = this.OGLDList.Length - 1;
        for (int index = num1; index <= num2; ++index)
        {
          Gl.glPushMatrix();
          Gl.glTranslatef((float) this.OGLDList[index].XPos, (float) this.OGLDList[index].YPos, (float) this.OGLDList[index].ZPos);
          Gl.glRotatef((float) this.OGLDList[index].XRot, 1f, 0.0f, 0.0f);
          Gl.glRotatef((float) this.OGLDList[index].YRot, 0.0f, 1f, 0.0f);
          Gl.glRotatef((float) this.OGLDList[index].ZRot, 0.0f, 0.0f, 1f);
          Gl.glCallList(this.OGLDList[index].DList);
          Gl.glPopMatrix();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("DList draw function error! " + ex.Message), MsgBoxStyle.Critical, (object) null);
        Gl.glPopMatrix();
        ProjectData.ClearProjectError();
      }
    }

    private void ResizeScene()
    {
      double aspectRatio = (double) (1 * this.SimpleOpenGlControl1.Width) / (double) this.SimpleOpenGlControl1.Height;
      Gl.glViewport(0, 0, this.SimpleOpenGlControl1.Width, this.SimpleOpenGlControl1.Height);
      Gl.glMatrixMode(5889);
      Gl.glLoadIdentity();
      Glu.gluPerspective(60.0, aspectRatio, 1.0, 999999.0);
      Gl.glMatrixMode(5888);
      Gl.glLoadIdentity();
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      this.ResizeScene();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Wgl.ReloadFunctions();
      Gl.ReloadFunctions();
      Il.ilInit();
      Functions.Game = this.ini.GetInteger("Settings", "Game", 0);
      this.Run = (double) this.CameraSensitivityScroll.Value * 2.4564568768678;
      this.OGLDList[0].MPickColor = new byte[3];
      this.N64Dlist[0] = new Main.DisplayList();
      this.EnableTEX = true;
      this.EnableCC = true;
      if (Gl.glGetString(7939).Contains("GL_EXT_texture_filter_anisotropic"))
        Gl.glGetFloatv(34047, this.MaxAnisotropy);
      this.TextureEd.texelsize = new ArrayList();
      this.TextureEd.Format = new ArrayList();
      this.TextureEd.RDRAMOffset = new ArrayList();
      this.TextureEd.Width = new ArrayList();
      this.TextureEd.Height = new ArrayList();
      this.TextureEd.SettileOff = new ArrayList();
      this.OBJData.v = new ArrayList();
      this.OBJData.vt = new ArrayList();
      this.OBJData.g = new ArrayList();
      this.Extracted.r = new ArrayList();
      this.Extracted.g = new ArrayList();
      this.Extracted.b = new ArrayList();
      this.Extracted.a = new ArrayList();
      this.VertCache.x = new short[64];
      this.VertCache.y = new short[64];
      this.VertCache.z = new short[64];
      this.VertCache.u = new short[64];
      this.VertCache.v = new short[64];
      this.VertCache.r = new float[64];
      this.VertCache.g = new float[64];
      this.VertCache.b = new float[64];
      this.VertCache.a = new float[64];
      Functions.BKModelDir = this.ini.GetString("Settings", "BKModelDirectory", (string) null);
      Functions.BTModelDir = this.ini.GetString("Settings", "BTModelDirectory", (string) null);
      if (Operators.CompareString(Functions.BKModelDir, "", false) == 0 & Operators.CompareString(Functions.BTModelDir, "", false) == 0 && Interaction.MsgBox((object) "No model directory specified. Run quick start dialog?", MsgBoxStyle.YesNo, (object) "First time?") == MsgBoxResult.Yes)
      {
        int num = (int) MyProject.Forms.GettingStarted.ShowDialog();
      }
      switch (Functions.Game)
      {
        case 0:
          if (Operators.CompareString(Functions.BKModelDir, "", false) != 0)
            this.PopulateFileTree(Functions.BKModelDir);
          this.Text = "Bottles' Glasses 0.80 - " + Functions.BKModelDir;
          this.BanjoKazooieToolStripMenuItem.Checked = true;
          this.BanjoTooieToolStripMenuItem.Checked = false;
          break;
        case 1:
          if (Operators.CompareString(Functions.BTModelDir, "", false) != 0)
            this.PopulateFileTree(Functions.BTModelDir);
          this.Text = "Bottles' Glasses 0.80 - " + Functions.BTModelDir;
          this.BanjoKazooieToolStripMenuItem.Checked = false;
          this.BanjoTooieToolStripMenuItem.Checked = true;
          break;
      }
      string Left = this.ini.GetString("Settings", "InvertYAxis", (string) null);
      if (Operators.CompareString(Left, "", false) != 0)
        this.InvertY = Conversions.ToBoolean(Left);
      this.InvertYAxisToolStripMenuItem.Checked = this.InvertY;
      string[] commandLineArgs = Environment.GetCommandLineArgs();
      if (commandLineArgs.Length == 2)
      {
        Functions.CurrModel = commandLineArgs[1];
        if (Functions.CurrModel.Contains(".bkm"))
        {
          Functions.Game = 0;
          this.SetGameUcode(0);
          this.BanjoKazooieToolStripMenuItem.Checked = true;
          this.BanjoTooieToolStripMenuItem.Checked = false;
          this.DonkeyKong64ToolStripMenuItem.Checked = false;
          this.ini.WriteInteger("Settings", "Game", 0);
          if (Operators.CompareString(Functions.BKModelDir, "", false) != 0)
            this.PopulateFileTree(Functions.BKModelDir);
        }
        else if (Functions.CurrModel.Contains(".btm"))
        {
          Functions.Game = 1;
          this.SetGameUcode(1);
          this.BanjoKazooieToolStripMenuItem.Checked = true;
          this.BanjoTooieToolStripMenuItem.Checked = false;
          this.DonkeyKong64ToolStripMenuItem.Checked = false;
          this.ini.WriteInteger("Settings", "Game", 1);
          if (Operators.CompareString(Functions.BTModelDir, "", false) != 0)
            this.PopulateFileTree(Functions.BTModelDir);
        }
        else
        {
          this.SetGameUcode(Functions.Game);
          goto label_22;
        }
        this.ParseModel();
        this.Text = "Bottles' Glasses 0.80 - " + Functions.NoExt(Functions.CurrModel) + " (" + Functions.CurrModel + ")";
      }
label_22:
      this.SetGameUcode(Functions.Game);
      this.BuildAxisMarker();
      this.ResetView();
      this.Show();
      this.Focus();
      this.MainLoop();
    }

    private void ToggleWireFrame()
    {
      if (this.EnableWireFrame)
      {
        this.EnableWireFrame = false;
        Gl.glPolygonMode(1032, 6914);
        this.ToggleWireframeButton.Image = (Image) BK_Viewer.My.Resources.Resources.wireframeoff1;
        this.ToggleWireframeButton.ToolTipText = "Wireframe OFF";
      }
      else
      {
        this.EnableWireFrame = true;
        Gl.glPolygonMode(1032, 6913);
        this.ToggleWireframeButton.Image = (Image) BK_Viewer.My.Resources.Resources.wireframeon1;
        this.ToggleWireframeButton.ToolTipText = "Wireframe ON";
      }
    }

    private void simpleopenglcontrol1_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.F1:
          this.ToggleWireFrame();
          break;
        case Keys.F2:
          this.ToggleAxisMarker();
          break;
        case Keys.F3:
          this.ToggleTextures();
          break;
        case Keys.W:
          this.key_w = true;
          break;
        case Keys.D:
          this.key_d = true;
          break;
        case Keys.A:
          this.key_a = true;
          break;
        case Keys.S:
          this.key_s = true;
          break;
        case Keys.ControlKey:
          this.key_ctrl = true;
          break;
        case Keys.R:
          this.ResetView();
          break;
      }
    }

    private void simpleopenglcontrol1_KeyUp(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.W:
          this.key_w = false;
          break;
        case Keys.D:
          this.key_d = false;
          break;
        case Keys.A:
          this.key_a = false;
          break;
        case Keys.S:
          this.key_s = false;
          break;
        case Keys.ControlKey:
          this.key_ctrl = false;
          break;
      }
    }

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.SimpleOpenGlControl1.Dispose();
      ProjectData.EndApp();
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.SimpleOpenGlControl1.Dispose();
      ProjectData.EndApp();
    }

    private void MPixelRead()
    {
      Gl.glPushMatrix();
      Gl.glRotatef(this.xrot, 1f, 0.0f, 0.0f);
      Gl.glRotatef(this.yrot, 0.0f, 1f, 0.0f);
      Gl.glRotatef(this.zrot, 0.0f, 0.0f, 1f);
      Gl.glTranslatef((float) this.finalx, (float) this.finaly, (float) this.finalz);
      this.DrawDList();
      Gl.glPopMatrix();
      int[] @params = new int[4];
      Gl.glGetIntegerv(2978, @params);
      Point client = this.SimpleOpenGlControl1.PointToClient(Cursor.Position);
      Gl.glReadPixels(client.X, @params[3] - client.Y, 1, 2, 6407, 5121, (object) this.pixel);
      int num1 = 0;
      int num2 = this.OGLDList.Length - 1;
      for (int index = num1; index <= num2; ++index)
      {
        if ((int) this.pixel[0] == (int) this.OGLDList[index].MPickColor[0] & (int) this.pixel[1] == (int) this.OGLDList[index].MPickColor[1] & (int) this.pixel[2] == (int) this.OGLDList[index].MPickColor[2])
        {
          int num3 = (int) Interaction.MsgBox((object) ("hit at " + index.ToString()), MsgBoxStyle.OkOnly, (object) null);
          break;
        }
      }
    }

    private void ScrollSensitivity(object sender, MouseEventArgs e)
    {
      if (e.Delta < 0)
      {
        if (this.CameraSensitivityScroll.Value > this.CameraSensitivityScroll.Minimum)
        {
          TrackBar sensitivityScroll = this.CameraSensitivityScroll;
          sensitivityScroll.Value = sensitivityScroll.Value - 1;
        }
        else
          this.CameraSensitivityScroll.Value = this.CameraSensitivityScroll.Minimum;
      }
      else if (this.CameraSensitivityScroll.Value < this.CameraSensitivityScroll.Maximum)
      {
        TrackBar sensitivityScroll = this.CameraSensitivityScroll;
        sensitivityScroll.Value = sensitivityScroll.Value + 1;
      }
      else
        this.CameraSensitivityScroll.Value = this.CameraSensitivityScroll.Maximum;
      if (this.CameraSensitivityScroll.Value == this.CameraSensitivityScroll.Minimum)
        this.Run = 0.0;
      else
        this.Run = (double) this.CameraSensitivityScroll.Value * 2.4564568768678;
    }

    private void SimpleOpenGlControl1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.RotateSceneClick = true;
      }
      else
      {
        if (e.Button != MouseButtons.Right)
          return;
        this.GoStrafe = true;
      }
    }

    private void SimpleOpenGlControl1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        this.SimpleOpenGlControl1.Cursor = Cursors.Arrow;
        this.RotateSceneClick = false;
      }
      else
      {
        if (e.Button != MouseButtons.Right)
          return;
        this.GoStrafe = false;
      }
    }

    private void TrackBar1_Scroll(object sender, EventArgs e)
    {
      if (this.key_w)
        this.key_w = false;
      if (this.key_d)
        this.key_d = false;
      if (this.key_a)
        this.key_a = false;
      if (this.key_s)
        this.key_s = false;
      if (this.key_ctrl)
        this.key_ctrl = false;
      this.Run = (double) this.CameraSensitivityScroll.Value * 2.4564568768678;
    }

    private void ResetView()
    {
      this.xrot = 0.0f;
      this.yrot = 0.0f;
      this.zrot = 0.0f;
      this.finalx = 0.0;
      this.finaly = -200.0;
      this.finalz = -1400.0;
      this.OGLDList[0].XPos = (short) 0;
      this.OGLDList[0].YPos = (short) 0;
      this.OGLDList[0].ZPos = (short) 0;
      this.OGLDList[0].XRot = (short) 0;
      this.OGLDList[0].YRot = (short) 0;
      this.OGLDList[0].ZRot = (short) 0;
    }

    public void IsolateFiles(int game)
    {
      try
      {
        switch (game)
        {
          case 0:
            this.InputFolderBrowser.Description = "Please select the folder containing extracted Banjo Kazooie data.";
            this.OutputFolderBrowser.Description = "Please select the folder you would like to isolate Banjo Kazooie models to.";
            break;
          case 1:
            this.InputFolderBrowser.Description = "Please select the folder containing extracted Banjo Tooie data.";
            this.OutputFolderBrowser.Description = "Please select the folder you would like to isolate  Banjo Tooie models to.";
            break;
          case 2:
            this.InputFolderBrowser.Description = "Please select the folder containing extracted Donkey Kong 64 data.";
            this.OutputFolderBrowser.Description = "Please select the folder you would like to isolate Donkey Kong 64 models to.";
            break;
        }
        if (this.InputFolderBrowser.ShowDialog() == DialogResult.Cancel)
          this.InputFolderBrowser.Dispose();
        else if (this.OutputFolderBrowser.ShowDialog() == DialogResult.Cancel)
        {
          this.OutputFolderBrowser.Dispose();
        }
        else
        {
          bool flag = false;
          if (Interaction.MsgBox((object) "Delete old files after copy?", MsgBoxStyle.YesNo, (object) "Question") == MsgBoxResult.Yes)
            flag = true;
          string path1 = this.InputFolderBrowser.SelectedPath + "\\";
          string path2 = this.OutputFolderBrowser.SelectedPath + "\\";
          string str1 = "";
          string str2 = "";
          string[] files = Directory.GetFiles(path1);
          Directory.CreateDirectory(path2);
          byte[] numArray = new byte[4];
          switch (game)
          {
            case 0:
              str1 = ".bkm";
              str2 = "Banjo-Kazooie";
              break;
            case 1:
              str1 = ".btm";
              str2 = "Banjo-Tooie";
              break;
            case 2:
              str1 = ".dkm";
              str2 = "Donkey Kong 64";
              break;
          }
          int num1 = 0;
          int num2 = files.Length - 1;
          for (int index = num1; index <= num2; ++index)
          {
            if (!files[index].Contains(".txt"))
            {
              FileStream fileStream = new FileStream(files[index], FileMode.Open);
              numArray[0] = (byte) fileStream.ReadByte();
              numArray[1] = (byte) fileStream.ReadByte();
              numArray[2] = (byte) fileStream.ReadByte();
              numArray[3] = (byte) fileStream.ReadByte();
              fileStream.Dispose();
              if ((int) numArray[3] == 11 && (int) numArray[0] == 0 & (int) numArray[1] == 0 & (int) numArray[2] == 0)
              {
                File.Copy(files[index], path2 + Functions.NoExt(Functions.GetFileName(files[index])) + str1, true);
                if (flag)
                  File.Delete(files[index]);
              }
            }
          }
          if (Interaction.MsgBox((object) (str2 + " model files isolated to " + path2 + " successfully. Would you like to set this as your " + str2 + " model directory now?"), MsgBoxStyle.YesNo, (object) "No problems encountered") != MsgBoxResult.Yes)
            return;
          switch (game)
          {
            case 0:
              Functions.BKModelDir = this.OutputFolderBrowser.SelectedPath;
              this.PopulateFileTree(Functions.BKModelDir);
              this.ini.WriteString("Settings", "BKModelDirectory", Functions.BKModelDir);
              break;
            case 1:
              Functions.BTModelDir = this.OutputFolderBrowser.SelectedPath;
              this.PopulateFileTree(Functions.BTModelDir);
              this.ini.WriteString("Settings", "BTModelDirectory", Functions.BTModelDir);
              break;
            case 2:
              Functions.DKModelDir = this.OutputFolderBrowser.SelectedPath;
              this.PopulateFileTree(Functions.DKModelDir);
              this.ini.WriteString("Settings", "DKModelDirectory", Functions.DKModelDir);
              break;
          }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("Could not isolate files!" + Environment.NewLine + Environment.NewLine + "DEBUG: " + ex.Message), MsgBoxStyle.OkOnly, (object) null);
        GC.Collect();
        ProjectData.ClearProjectError();
      }
    }

    private void ToggleAxisMarker()
    {
      if (this.EnableAxisMarker)
      {
        this.EnableAxisMarker = false;
        this.AxisMarkerToggle.Image = (Image) BK_Viewer.My.Resources.Resources.axisoff;
        this.AxisMarkerToggle.ToolTipText = "Axis Marker OFF";
      }
      else
      {
        this.EnableAxisMarker = true;
        this.AxisMarkerToggle.Image = (Image) BK_Viewer.My.Resources.Resources.axison;
        this.AxisMarkerToggle.ToolTipText = "Axis Marker ON";
      }
    }

    private void AxisMarkerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ToggleAxisMarker();
    }

    private void RAREDecompressorSubDragRWPToolStripMenuItem_Click(object sender, EventArgs e)
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

    private void BanjoKazooieToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.IsolateFiles(0);
    }

    private void DonkeyKong64ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.IsolateFiles(1);
    }

    private void QuitToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      ProjectData.EndApp();
    }

    public void PopulateFileTree(string dir)
    {
      this.FileTree.Nodes.Clear();
      string str = "";
      if (!Directory.Exists(dir))
        return;
      this.ModelFiles = Directory.GetFiles(dir);
      int num1 = 0;
      int num2 = this.ModelFiles.Length - 1;
      for (this.i = num1; this.i <= num2; ++this.i)
      {
        if (this.verifyFiles)
        {
          FileStream fileStream = new FileStream(this.ModelFiles[this.i], FileMode.Open);
          fileStream.Position = 3L;
          byte num3 = (byte) fileStream.ReadByte();
          fileStream.Dispose();
          if ((int) num3 != 11)
            continue;
        }
        switch (Functions.Game)
        {
          case 0:
            str = Functions.BKmodelini.GetString("models", Functions.NoExt(this.ModelFiles[this.i]), (string) null);
            break;
          case 1:
            str = Functions.BTmodelini.GetString("models", Functions.NoExt(this.ModelFiles[this.i]), (string) null);
            break;
        }
        if (Operators.CompareString(str, "", false) != 0)
          this.FileTree.Nodes.Add(str);
        else
          this.FileTree.Nodes.Add(Functions.GetFileName(this.ModelFiles[this.i]));
      }
      if (this.FileTree.Nodes.Count != 0)
        return;
      this.FileTree.Nodes.Add("No models found in " + dir + "!");
    }

    private void ToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      switch (Functions.Game)
      {
        case 0:
          Process.Start(Functions.BKModelDir);
          break;
        case 1:
          Process.Start(Functions.BTModelDir);
          break;
      }
    }

    private void ObjectIsolatorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.IsolateFiles(Functions.Game);
    }

    private void ExportWavefrontModelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if ((long) this.OGLDList[0].DList <= 0L)
        return;
      this.SaveOBJ.FileName = Functions.NoExt(Functions.GetFileName(Functions.CurrModel)) + ".obj";
      if (this.SaveOBJ.ShowDialog() != DialogResult.Cancel)
        return;
      this.SaveOBJ.Dispose();
    }

    private void SaveOBJ_FileOk(object sender, CancelEventArgs e)
    {
      this.subdir = Path.GetDirectoryName(this.SaveOBJ.FileName) + "\\" + Functions.NoExt(this.SaveOBJ.FileName) + "\\";
      this.CurrFileStream = new FileStream(Functions.CurrModel, FileMode.Open);
      if (Directory.Exists(this.subdir) && Interaction.MsgBox((object) "Model already exists in this path! Overwrite?", MsgBoxStyle.YesNo, (object) "Overwrite") == MsgBoxResult.No)
        return;
      Directory.CreateDirectory(this.subdir);
      this.objstr = File.Create(this.subdir + Functions.GetFileName(this.SaveOBJ.FileName));
      this.objfile = new StreamWriter((Stream) this.objstr);
      this.mtlstr = File.Create(this.subdir + Functions.NoExt(this.SaveOBJ.FileName) + ".mtl");
      this.mtlfile = new StreamWriter((Stream) this.mtlstr);
      this.OBJMode = true;
      this.objfile.WriteLine("#" + Functions.GetFileName(this.SaveOBJ.FileName) + " - exported from Banjo-Kazooie/Tooie using Bottles' Glasses 0.80");
      this.objfile.WriteLine("#" + Conversions.ToString(this.Vertices.x.Length) + " Vertices and texture coords");
      this.objfile.WriteLine("mtllib " + Functions.NoExt(Functions.GetFileName(this.SaveOBJ.FileName)) + ".mtl");
      int num1 = 0;
      int num2 = this.Vertices.x.Length - 1;
      for (int index = num1; index <= num2; ++index)
        this.OBJData.v.Add((object) ("v " + this.Vertices.x[index].ToString() + " " + this.Vertices.y[index].ToString() + " " + this.Vertices.z[index].ToString()));
      int num3 = 0;
      int num4 = this.Vertices.x.Length - 1;
      for (int index = num3; index <= num4; ++index)
        this.OBJData.vt.Add((object) ("vt " + this.Vertices.u[index].ToString() + " " + this.Vertices.v[index].ToString()));
      int num5 = 0;
      int num6 = this.N64Dlist[0].Commands.Length - 1;
      for (this.CurCMD = num5; this.CurCMD <= num6; ++this.CurCMD)
      {
        this.CMDHigh = (uint) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[4] * 16777216 + (int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[5] * 65536 + (int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[6] * 256) + (uint) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[7];
        this.CMDLow = (uint) ((int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[1] * 65536 + (int) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[2] * 256) + (uint) this.N64Dlist[0].Commands[this.CurCMD].CMDDword[3];
        this.ParseCurrentCommand();
      }
      int num7 = 0;
      int num8 = this.OBJData.v.Count - 1;
      for (this.i = num7; this.i <= num8; ++this.i)
        this.objfile.WriteLine(Conversions.ToString(this.OBJData.v[this.i]));
      int num9 = 0;
      int num10 = this.OBJData.vt.Count - 1;
      for (this.i = num9; this.i <= num10; ++this.i)
        this.objfile.WriteLine(Conversions.ToString(this.OBJData.vt[this.i]));
      int num11 = 0;
      int num12 = this.OBJData.g.Count - 1;
      for (this.i = num11; this.i <= num12; ++this.i)
        this.objfile.WriteLine(Conversions.ToString(this.OBJData.g[this.i]));
      this.OBJData.v.Clear();
      this.OBJData.vt.Clear();
      this.OBJData.g.Clear();
      this.OBJMode = false;
      this.OBJTextures.Clear();
      this.objfile.Dispose();
      this.objstr.Dispose();
      this.mtlfile.Dispose();
      this.mtlstr.Dispose();
      this.CurrFileStream.Dispose();
    }

    private void OpenTexture_FileOk(object sender, CancelEventArgs e)
    {
      if (Il.ilLoadImage(this.OpenTexture.FileName))
        ;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      if (this.OpenTexture.ShowDialog() != DialogResult.Cancel)
        return;
      this.OpenTexture.Dispose();
    }

    private void SetGameUcode(int game)
    {
      switch (game)
      {
        case 0:
          game = 0;
          this.GameStatus.Text = "Game: Banjo-Kazooie";
          F3DEX.F3DEX_DL = (byte) 6;
          F3DEX.F3DEX_POPMTX = (byte) 189;
          F3DEX.F3DEX_TEXTURE = (byte) 187;
          F3DEX.F3DEX_SETOTHERMODE_H = (byte) 186;
          F3DEX.F3DEX_SETOTHERMODE_L = (byte) 185;
          F3DEX.F3DEX_MTX = (byte) 1;
          F3DEX.F3DEX_SETGEOMETRYMODE = (byte) 183;
          F3DEX.F3DEX_CLEARGEOMETRYMODE = (byte) 182;
          F3DEX.F3DEX_ENDDL = (byte) 184;
          F3DEX.F3DEX_VTX = (byte) 4;
          F3DEX.F3DEX_MODIFYVTX = (byte) 178;
          F3DEX.F3DEX_TRI1 = (byte) 191;
          F3DEX.F3DEX_TRI2 = (byte) 177;
          break;
        case 1:
          game = 1;
          this.GameStatus.Text = "Game: Banjo-Tooie/DK64";
          F3DEX.F3DEX_DL = (byte) 222;
          F3DEX.F3DEX_TEXTURE = (byte) 215;
          F3DEX.F3DEX_POPMTX = (byte) 216;
          F3DEX.F3DEX_MTX = (byte) 3;
          F3DEX.F3DEX_SETOTHERMODE_H = (byte) 227;
          F3DEX.F3DEX_SETOTHERMODE_L = (byte) 226;
          F3DEX.F3DEX_SETGEOMETRYMODE = (byte) 217;
          F3DEX.F3DEX_CLEARGEOMETRYMODE = (byte) 0;
          F3DEX.F3DEX_ENDDL = (byte) 223;
          F3DEX.F3DEX_VTX = (byte) 1;
          F3DEX.F3DEX_MODIFYVTX = (byte) 2;
          F3DEX.F3DEX_TRI1 = (byte) 5;
          F3DEX.F3DEX_TRI2 = (byte) 6;
          break;
      }
    }

    private void BanjoKazooieToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Functions.Game = 0;
      this.SetGameUcode(0);
      this.BanjoKazooieToolStripMenuItem.Checked = true;
      this.BanjoTooieToolStripMenuItem.Checked = false;
      this.DonkeyKong64ToolStripMenuItem.Checked = false;
      this.ini.WriteInteger("Settings", "Game", Functions.Game);
      if (Operators.CompareString(Functions.BKModelDir, "", false) == 0)
        return;
      this.PopulateFileTree(Functions.BKModelDir);
    }

    private void BanjoTooieToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Functions.Game = 1;
      this.SetGameUcode(1);
      this.BanjoKazooieToolStripMenuItem.Checked = false;
      this.BanjoTooieToolStripMenuItem.Checked = true;
      this.DonkeyKong64ToolStripMenuItem.Checked = false;
      this.ini.WriteInteger("Settings", "Game", Functions.Game);
      if (Operators.CompareString(Functions.BTModelDir, "", false) == 0)
        return;
      this.PopulateFileTree(Functions.BTModelDir);
    }

    private void BanjoKazooieToolStripMenuItem1_Click_1(object sender, EventArgs e)
    {
      this.ModelFolderDialog.Description = "Please point to the directory which contains your Banjo-Kazooie models (*.bkm).";
      if (this.ModelFolderDialog.ShowDialog() == DialogResult.Cancel)
      {
        this.ModelFolderDialog.Dispose();
      }
      else
      {
        Functions.BKModelDir = this.ModelFolderDialog.SelectedPath;
        this.Text = "Bottles' Glasses 0.80 - " + Functions.BKModelDir;
        this.ini.WriteString("Settings", "BKModelDirectory", Functions.BKModelDir);
        if (Functions.Game != 0)
          return;
        this.PopulateFileTree(Functions.BKModelDir);
      }
    }

    private void BanjoTooieToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.ModelFolderDialog.Description = "Please point to the directory which contains your Banjo-Tooie models (*.btm).";
      if (this.ModelFolderDialog.ShowDialog() == DialogResult.Cancel)
      {
        this.ModelFolderDialog.Dispose();
      }
      else
      {
        Functions.BTModelDir = this.ModelFolderDialog.SelectedPath;
        this.Text = "Bottles' Glasses 0.80 - " + Functions.BTModelDir;
        this.ini.WriteString("Settings", "BTModelDirectory", Functions.BTModelDir);
        if (Functions.Game != 1)
          return;
        this.PopulateFileTree(Functions.BTModelDir);
      }
    }

    private void GameStatus_Click(object sender, EventArgs e)
    {
      switch (Functions.Game)
      {
        case 0:
          Functions.Game = 1;
          this.SetGameUcode(1);
          this.BanjoKazooieToolStripMenuItem.Checked = false;
          this.BanjoTooieToolStripMenuItem.Checked = true;
          this.ini.WriteInteger("Settings", "Game", 1);
          if (Operators.CompareString(Functions.BTModelDir, "", false) == 0)
            break;
          this.PopulateFileTree(Functions.BTModelDir);
          break;
        case 1:
          Functions.Game = 0;
          this.SetGameUcode(0);
          this.BanjoKazooieToolStripMenuItem.Checked = true;
          this.BanjoTooieToolStripMenuItem.Checked = false;
          this.ini.WriteInteger("Settings", "Game", 0);
          if (Operators.CompareString(Functions.BKModelDir, "", false) == 0)
            break;
          this.PopulateFileTree(Functions.BKModelDir);
          break;
      }
    }

    private void FileTree_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (this.TreeView1.SelectedNodes.Count > 0 && Operators.CompareString(this.TreeView1.SelectedNodes[0].Text, this.FileTree.SelectedNodes[0].Text, false) != 0)
        this.TreeView1.SelectedNodes.Clear();
      if (this.ModelFiles.Length <= 0)
        return;
      Functions.CurrModel = this.ModelFiles[e.Node.Index];
      this.Text = "Bottles' Glasses 0.80 - " + e.Node.Text + " (" + Functions.CurrModel + ")";
      this.ParseModel();
      this.ResetView();
    }

    private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ResetView();
    }

    private void InvertYAxisToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.InvertY = !this.InvertY;
      this.ini.WriteBoolean("Settings", "InvertYAxis", this.InvertY);
    }

    private void CaptureScreenshotToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(Functions.CurrModel, "", false) == 0)
        return;
      this.SaveScreenPNG.InitialDirectory = Application.StartupPath;
      this.SaveScreenPNG.FileName = Functions.NoExt(Functions.CurrModel) + "_screen_" + DateTime.Now.ToShortTimeString().Replace(":", "").Replace(" ", "");
      int num = (int) this.SaveScreenPNG.ShowDialog();
    }

    private void SaveScreenData(int[] vp, string filename, ImageFormat format)
    {
      Gl.glGetIntegerv(2978, vp);
      Rectangle rect = new Rectangle(0, 0, vp[2], vp[3]);
      System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(vp[2], vp[3], PixelFormat.Format32bppArgb);
      BitmapData bitmapdata = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
      Gl.glReadPixels(0, 0, vp[2], vp[3], 32993, 5121, bitmapdata.Scan0);
      bitmap.UnlockBits(bitmapdata);
      bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
      bitmap.Save(filename, format);
    }

    private void SaveScreenBMP_FileOk(object sender, CancelEventArgs e)
    {
      int[] numArray = new int[4];
      Gl.glGetIntegerv(2978, numArray);
      this.SaveScreenData(numArray, this.SaveScreenPNG.FileName, ImageFormat.Png);
    }

    private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) MyProject.Forms.RenameFileDescription.ShowDialog();
    }

    public void ToggleTextures()
    {
      if (this.EnableTEX)
      {
        this.EnableTEX = false;
        this.ToggleTextureButton.Image = (Image) BK_Viewer.My.Resources.Resources.texturesoff;
        this.ToggleTextureButton.ToolTipText = "Textures OFF";
      }
      else
      {
        this.EnableTEX = true;
        this.ToggleTextureButton.Image = (Image) BK_Viewer.My.Resources.Resources.textureson;
        this.ToggleTextureButton.ToolTipText = "Textures ON";
      }
      if (Operators.CompareString(Functions.CurrModel, "", false) == 0)
        return;
      this.ParseModel();
    }

    private void WireframeCheck_MouseDown(object sender, MouseEventArgs e)
    {
      this.ToggleWireFrame();
    }

    private void AxisCheck_MouseDown(object sender, MouseEventArgs e)
    {
      this.ToggleAxisMarker();
    }

    private void FileTree_DoubleClick(object sender, EventArgs e)
    {
      if (this.FileTree.SelectedNodes[0].Index <= -1)
        return;
      int num = (int) MyProject.Forms.RenameFileDescription.ShowDialog();
    }

    private void SearchTreeView()
    {
      int num1 = 0;
      this.TreeView1.Nodes.Clear();
      this.SearchFound.Clear();
      int num2 = 0;
      int num3 = this.FileTree.Nodes.Count - 1;
      for (this.i = num2; this.i <= num3; ++this.i)
      {
        if (this.FileTree.Nodes[this.i].Text.ToLower().Contains(this.TextBox1.Text.ToLower()))
        {
          this.TreeView1.Nodes.Add(this.FileTree.Nodes[this.i].Text);
          this.SearchFound.Add((object) this.i);
          ++num1;
        }
      }
      this.Label5.Text = num1.ToString() + " matches found";
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.SearchTreeView();
    }

    private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Strings.Asc(e.KeyChar) != 13)
        return;
      this.SearchTreeView();
    }

    private void AxisCheck_Click(object sender, EventArgs e)
    {
      this.ToggleAxisMarker();
    }

    private void WireframeCheck_Click(object sender, EventArgs e)
    {
      this.ToggleWireFrame();
    }

    private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      int integer = Conversions.ToInteger(this.SearchFound[e.Node.Index]);
      Functions.CurrModel = this.ModelFiles[integer];
      this.FileTree.SelectedNodes.Clear();
      this.FileTree.TopNode = this.FileTree.Nodes[integer];
      this.FileTree.SelectedNodes.Add(this.FileTree.Nodes[integer]);
    }

    private void TreeView1_DoubleClick(object sender, EventArgs e)
    {
      if (this.FileTree.SelectedNodes[0].Index <= -1)
        return;
      int num = (int) MyProject.Forms.RenameFileDescription.ShowDialog();
    }

    private void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
      if (this.verifyFiles)
        this.verifyFiles = false;
      else
        this.verifyFiles = true;
    }

    private void DonkeyKong64ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Functions.Game = 2;
      this.SetGameUcode(1);
      this.BanjoKazooieToolStripMenuItem.Checked = false;
      this.BanjoTooieToolStripMenuItem.Checked = false;
      this.DonkeyKong64ToolStripMenuItem.Checked = true;
      this.ini.WriteInteger("Settings", "Game", Functions.Game);
      if (Operators.CompareString(Functions.BTModelDir, "", false) == 0)
        return;
      this.PopulateFileTree(Functions.BTModelDir);
    }

    private void Rotate90Left_Click(object sender, EventArgs e)
    {
      this.rottype = 0;
      this.RotateTimer.Start();
    }

    private void Rotate90Right_Click(object sender, EventArgs e)
    {
      this.rottype = 1;
      this.RotateTimer.Start();
    }

    private void Rotate90Up_Click(object sender, EventArgs e)
    {
      this.rottype = 2;
      this.RotateTimer.Start();
    }

    private void Rotate90Down_Click(object sender, EventArgs e)
    {
      this.rottype = 3;
      this.RotateTimer.Start();
    }

    private void RotateTimer_Tick(object sender, EventArgs e)
    {
      this.rotcoef = this.rotcoef - 10;
      if (this.rotcoef == 0)
      {
        this.rotcoef = 90;
        this.RotateTimer.Stop();
      }
      switch (this.rottype)
      {
        case 0:
          Main.OGLModel[] ogldList1 = this.OGLDList;
          int index1 = 0;
          int index2 = index1;
          ogldList1[index2].YRot = (short) ((int) this.OGLDList[index1].YRot - 15);
          break;
        case 1:
          Main.OGLModel[] ogldList2 = this.OGLDList;
          int index3 = 0;
          int index4 = index3;
          ogldList2[index4].YRot = (short) ((int) this.OGLDList[index3].YRot + 15);
          break;
        case 2:
          Main.OGLModel[] ogldList3 = this.OGLDList;
          int index5 = 0;
          int index6 = index5;
          ogldList3[index6].XRot = (short) ((int) this.OGLDList[index5].XRot - 15);
          break;
        case 3:
          Main.OGLModel[] ogldList4 = this.OGLDList;
          int index7 = 0;
          int index8 = index7;
          ogldList4[index8].XRot = (short) ((int) this.OGLDList[index7].XRot + 15);
          break;
      }
    }

    private void ToolStripButton1_Click(object sender, EventArgs e)
    {
      this.ToggleTextures();
    }

    private void ToolStripButton1_Click_1(object sender, EventArgs e)
    {
      this.ToggleAxisMarker();
    }

    private void ToolStripButton1_Click_2(object sender, EventArgs e)
    {
      this.ToggleWireFrame();
    }

    private void SimpleOpenGlControl1_DragDrop(object sender, DragEventArgs e)
    {
      Functions.CurrModel = ((string[]) e.Data.GetData(DataFormats.FileDrop))[0];
      if (Functions.CurrModel.Contains(".bkm"))
      {
        Functions.Game = 0;
        this.SetGameUcode(0);
        this.BanjoKazooieToolStripMenuItem.Checked = true;
        this.BanjoTooieToolStripMenuItem.Checked = false;
        this.DonkeyKong64ToolStripMenuItem.Checked = false;
        this.ini.WriteInteger("Settings", "Game", 0);
        if (Operators.CompareString(Functions.BKModelDir, "", false) != 0)
          this.PopulateFileTree(Functions.BKModelDir);
      }
      else if (Functions.CurrModel.Contains(".btm"))
      {
        Functions.Game = 1;
        this.SetGameUcode(1);
        this.BanjoKazooieToolStripMenuItem.Checked = true;
        this.BanjoTooieToolStripMenuItem.Checked = false;
        this.DonkeyKong64ToolStripMenuItem.Checked = false;
        this.ini.WriteInteger("Settings", "Game", 1);
        if (Operators.CompareString(Functions.BTModelDir, "", false) != 0)
          this.PopulateFileTree(Functions.BTModelDir);
      }
      else
        goto label_7;
      this.ParseModel();
      this.Text = "Bottles' Glasses 0.80 - " + Functions.NoExt(Functions.CurrModel) + " (" + Functions.CurrModel + ")";
label_7:
      this.ResetView();
    }

    private void SimpleOpenGlControl1_DragEnter(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      e.Effect = DragDropEffects.Copy;
    }

    private void AssociateFilesWithWindowsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MyProject.Computer.Registry.ClassesRoot.CreateSubKey(".bkm").SetValue("", (object) "Banjo Kazooie Model files", RegistryValueKind.String);
      MyProject.Computer.Registry.ClassesRoot.CreateSubKey("Banjo Kazooie Model files\\shell\\open\\command").SetValue("", (object) (Application.ExecutablePath + " \"%l\" "), RegistryValueKind.String);
      MyProject.Computer.Registry.ClassesRoot.CreateSubKey(".btm").SetValue("", (object) "Banjo Tooie Model files", RegistryValueKind.String);
      MyProject.Computer.Registry.ClassesRoot.CreateSubKey("Banjo Tooie Model files\\shell\\open\\command").SetValue("", (object) (Application.ExecutablePath + " \"%l\" "), RegistryValueKind.String);
      int num = (int) Interaction.MsgBox((object) "Banjo Kazooie and Banjo Tooie models are now associated with Bottles' Glasses. You can double click them in Windows to load them.", MsgBoxStyle.OkOnly, (object) "Shell association successful");
    }

    private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    public struct TexBuffer
    {
      public int offset;
      public byte[] data;
      public int size;
      public int width;
      public int height;
    }

    public struct Collision
    {
      public short[] x;
      public short[] y;
      public short[] z;
    }

    public struct CollisionTris
    {
      public uint[] a;
      public uint[] b;
      public uint[] c;
    }

    public struct OGLModel
    {
      public uint DList;
      public uint WireDList;
      public uint PickDList;
      public byte[] MPickColor;
      public short XPos;
      public short YPos;
      public short ZPos;
      public short XRot;
      public short YRot;
      public short ZRot;
    }

    public struct Vertex3D
    {
      public short[] x;
      public short[] y;
      public short[] z;
      public short[] u;
      public short[] v;
      public float[] r;
      public float[] g;
      public float[] b;
      public float[] a;
    }

    public struct ColorLUT
    {
      public ArrayList r;
      public ArrayList g;
      public ArrayList b;
      public ArrayList a;
    }

    public struct DLCommand
    {
      public byte[] CMDDword;
      public bool SkipCommand;
    }

    public struct DisplayList
    {
      public int startpos;
      public int endpos;
      public int CommandCount;
      public Main.DLCommand[] Commands;
      public uint shader;
    }

    public struct OBJWriteBuffers
    {
      public ArrayList v;
      public ArrayList vt;
      public ArrayList g;
    }

    public struct TextureEditor
    {
      public ArrayList RDRAMOffset;
      public ArrayList Width;
      public ArrayList Height;
      public ArrayList Format;
      public ArrayList texelsize;
      public ArrayList SettileOff;
    }
  }
}
