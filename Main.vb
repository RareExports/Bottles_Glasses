Imports Tao.opengl
Imports Tao.devil
Imports Tao.Platform.windows
Imports Tao.freeglut
Imports System.IO
Imports System.Math
Imports System.Runtime.InteropServices
Public Class Main
#Region "SETUP"

    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        SimpleOpenGlControl1.InitializeContexts()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
        SimpleOpenGlControl1.DestroyContexts()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Display Lists")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Textures")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadGraphicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanjoKazooieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanjoTooieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonkeyKong64ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportWavefrontModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanjoKazooieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanjoTooieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonkeyKong64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaptureScreenshotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertYAxisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssociateFilesWithWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObjectIsolatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RAREDecompressorSubDragRWPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.GameStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CameraSensitivityScroll = New System.Windows.Forms.TrackBar()
        Me.OutputFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.SimpleOpenGlControl1 = New Tao.Platform.Windows.SimpleOpenGlControl()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New CodersLab.Windows.Controls.TreeView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FileTree = New CodersLab.Windows.Controls.TreeView()
        Me.FileTreeContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ModelContentTree = New System.Windows.Forms.TreeView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ModelFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveOBJ = New System.Windows.Forms.SaveFileDialog()
        Me.OpenTexture = New System.Windows.Forms.OpenFileDialog()
        Me.SaveScreenPNG = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Rotate90Left = New System.Windows.Forms.ToolStripButton()
        Me.Rotate90Right = New System.Windows.Forms.ToolStripButton()
        Me.Rotate90Up = New System.Windows.Forms.ToolStripButton()
        Me.Rotate90Down = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToggleTextureButton = New System.Windows.Forms.ToolStripButton()
        Me.ToggleWireframeButton = New System.Windows.Forms.ToolStripButton()
        Me.AxisMarkerToggle = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RotateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.CameraSensitivityScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FileTreeContextMenu.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(856, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadGraphicsToolStripMenuItem, Me.ExportWavefrontModelToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        Me.FileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'LoadGraphicsToolStripMenuItem
        '
        Me.LoadGraphicsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BanjoKazooieToolStripMenuItem1, Me.BanjoTooieToolStripMenuItem1, Me.DonkeyKong64ToolStripMenuItem1})
        Me.LoadGraphicsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LoadGraphicsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.LoadGraphicsToolStripMenuItem.Name = "LoadGraphicsToolStripMenuItem"
        Me.LoadGraphicsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LoadGraphicsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.LoadGraphicsToolStripMenuItem.Text = "Set model directory"
        '
        'BanjoKazooieToolStripMenuItem1
        '
        Me.BanjoKazooieToolStripMenuItem1.Name = "BanjoKazooieToolStripMenuItem1"
        Me.BanjoKazooieToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.BanjoKazooieToolStripMenuItem1.Text = "Banjo-Kazooie"
        '
        'BanjoTooieToolStripMenuItem1
        '
        Me.BanjoTooieToolStripMenuItem1.Name = "BanjoTooieToolStripMenuItem1"
        Me.BanjoTooieToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.BanjoTooieToolStripMenuItem1.Text = "Banjo-Tooie"
        '
        'DonkeyKong64ToolStripMenuItem1
        '
        Me.DonkeyKong64ToolStripMenuItem1.Name = "DonkeyKong64ToolStripMenuItem1"
        Me.DonkeyKong64ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.DonkeyKong64ToolStripMenuItem1.Text = "Donkey Kong 64"
        '
        'ExportWavefrontModelToolStripMenuItem
        '
        Me.ExportWavefrontModelToolStripMenuItem.Name = "ExportWavefrontModelToolStripMenuItem"
        Me.ExportWavefrontModelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportWavefrontModelToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ExportWavefrontModelToolStripMenuItem.Text = "Export as .OBJ"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.ResetToolStripMenuItem, Me.CaptureScreenshotToolStripMenuItem, Me.InvertYAxisToolStripMenuItem, Me.AssociateFilesWithWindowsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        Me.OptionsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BanjoKazooieToolStripMenuItem, Me.BanjoTooieToolStripMenuItem, Me.DonkeyKong64ToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'BanjoKazooieToolStripMenuItem
        '
        Me.BanjoKazooieToolStripMenuItem.Name = "BanjoKazooieToolStripMenuItem"
        Me.BanjoKazooieToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BanjoKazooieToolStripMenuItem.Text = "Banjo-Kazooie"
        '
        'BanjoTooieToolStripMenuItem
        '
        Me.BanjoTooieToolStripMenuItem.Name = "BanjoTooieToolStripMenuItem"
        Me.BanjoTooieToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BanjoTooieToolStripMenuItem.Text = "Banjo-Tooie"
        '
        'DonkeyKong64ToolStripMenuItem
        '
        Me.DonkeyKong64ToolStripMenuItem.Name = "DonkeyKong64ToolStripMenuItem"
        Me.DonkeyKong64ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DonkeyKong64ToolStripMenuItem.Text = "Donkey Kong 64"
        Me.DonkeyKong64ToolStripMenuItem.Visible = False
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeyDisplayString = "R"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ResetToolStripMenuItem.Text = "Reset view"
        '
        'CaptureScreenshotToolStripMenuItem
        '
        Me.CaptureScreenshotToolStripMenuItem.Name = "CaptureScreenshotToolStripMenuItem"
        Me.CaptureScreenshotToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.CaptureScreenshotToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.CaptureScreenshotToolStripMenuItem.Text = "Capture screenshot"
        '
        'InvertYAxisToolStripMenuItem
        '
        Me.InvertYAxisToolStripMenuItem.CheckOnClick = True
        Me.InvertYAxisToolStripMenuItem.Name = "InvertYAxisToolStripMenuItem"
        Me.InvertYAxisToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.InvertYAxisToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.InvertYAxisToolStripMenuItem.Text = "Invert Y Axis"
        '
        'AssociateFilesWithWindowsToolStripMenuItem
        '
        Me.AssociateFilesWithWindowsToolStripMenuItem.Name = "AssociateFilesWithWindowsToolStripMenuItem"
        Me.AssociateFilesWithWindowsToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AssociateFilesWithWindowsToolStripMenuItem.Text = "Associate files with Windows"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObjectIsolatorToolStripMenuItem, Me.RAREDecompressorSubDragRWPToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        Me.ToolsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'ObjectIsolatorToolStripMenuItem
        '
        Me.ObjectIsolatorToolStripMenuItem.Name = "ObjectIsolatorToolStripMenuItem"
        Me.ObjectIsolatorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ObjectIsolatorToolStripMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.ObjectIsolatorToolStripMenuItem.Text = "Model Isolator"
        '
        'RAREDecompressorSubDragRWPToolStripMenuItem
        '
        Me.RAREDecompressorSubDragRWPToolStripMenuItem.Name = "RAREDecompressorSubDragRWPToolStripMenuItem"
        Me.RAREDecompressorSubDragRWPToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.RAREDecompressorSubDragRWPToolStripMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.RAREDecompressorSubDragRWPToolStripMenuItem.Text = "RARE Decompressor (SubDrag/RWP)"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 550)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(856, 23)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'GameStatus
        '
        Me.GameStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.GameStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.GameStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameStatus.Name = "GameStatus"
        Me.GameStatus.Size = New System.Drawing.Size(46, 18)
        Me.GameStatus.Text = "Game:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(649, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Camera Speed:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 556)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "  "
        '
        'CameraSensitivityScroll
        '
        Me.CameraSensitivityScroll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CameraSensitivityScroll.AutoSize = False
        Me.CameraSensitivityScroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CameraSensitivityScroll.Location = New System.Drawing.Point(724, 553)
        Me.CameraSensitivityScroll.Maximum = 47
        Me.CameraSensitivityScroll.Minimum = 1
        Me.CameraSensitivityScroll.Name = "CameraSensitivityScroll"
        Me.CameraSensitivityScroll.Size = New System.Drawing.Size(111, 19)
        Me.CameraSensitivityScroll.TabIndex = 7
        Me.CameraSensitivityScroll.Value = 20
        '
        'SimpleOpenGlControl1
        '
        Me.SimpleOpenGlControl1.AccumBits = CType(0, Byte)
        Me.SimpleOpenGlControl1.AllowDrop = True
        Me.SimpleOpenGlControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleOpenGlControl1.AutoCheckErrors = False
        Me.SimpleOpenGlControl1.AutoFinish = True
        Me.SimpleOpenGlControl1.AutoMakeCurrent = True
        Me.SimpleOpenGlControl1.AutoSwapBuffers = False
        Me.SimpleOpenGlControl1.BackColor = System.Drawing.Color.Black
        Me.SimpleOpenGlControl1.ColorBits = CType(32, Byte)
        Me.SimpleOpenGlControl1.DepthBits = CType(16, Byte)
        Me.SimpleOpenGlControl1.Location = New System.Drawing.Point(0, 56)
        Me.SimpleOpenGlControl1.Name = "SimpleOpenGlControl1"
        Me.SimpleOpenGlControl1.Size = New System.Drawing.Size(610, 495)
        Me.SimpleOpenGlControl1.StencilBits = CType(0, Byte)
        Me.SimpleOpenGlControl1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(611, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(247, 527)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TreeView1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.FileTree)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(239, 501)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Models"
        Me.TabPage1.ToolTipText = "A list of models that reside in the directory you've specified (File -> Set model" & _
            " dir...)"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(12, 330)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.RightToLeftLayout = True
        Me.TreeView1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.TreeView1.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.SingleSelect
        Me.TreeView1.Size = New System.Drawing.Size(217, 110)
        Me.TreeView1.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 481)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(179, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 22)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(12, 454)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 20)
        Me.TextBox1.TabIndex = 14
        '
        'FileTree
        '
        Me.FileTree.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileTree.ContextMenuStrip = Me.FileTreeContextMenu
        Me.FileTree.Location = New System.Drawing.Point(12, 25)
        Me.FileTree.Name = "FileTree"
        Me.FileTree.RightToLeftLayout = True
        Me.FileTree.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.FileTree.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.SingleSelect
        Me.FileTree.Size = New System.Drawing.Size(217, 274)
        Me.FileTree.TabIndex = 1
        '
        'FileTreeContextMenu
        '
        Me.FileTreeContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.RenameToolStripMenuItem})
        Me.FileTreeContextMenu.Name = "ContextMenuStrip1"
        Me.FileTreeContextMenu.Size = New System.Drawing.Size(198, 48)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(197, 22)
        Me.ToolStripMenuItem2.Text = "Open containing folder"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RenameToolStripMenuItem.Text = "Rename description"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 311)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 179)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 299)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "All"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(31, 1)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(190, 10)
        Me.ProgressBar1.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ModelContentTree)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(239, 501)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Current Model"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ModelContentTree
        '
        Me.ModelContentTree.CheckBoxes = True
        Me.ModelContentTree.Location = New System.Drawing.Point(7, 10)
        Me.ModelContentTree.Name = "ModelContentTree"
        TreeNode1.Name = "DLNode"
        TreeNode1.Text = "Display Lists"
        TreeNode2.Name = "TextureNode"
        TreeNode2.Text = "Textures"
        Me.ModelContentTree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.ModelContentTree.Size = New System.Drawing.Size(226, 422)
        Me.ModelContentTree.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(88, 438)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Enable all but selected"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(88, 467)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Disable all but selected"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 452)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Enable all"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ModelFolderDialog
        '
        Me.ModelFolderDialog.Description = "Please select the folder to which you isolated your BK models (*.bkm)."
        '
        'SaveOBJ
        '
        Me.SaveOBJ.Filter = "Wavefront OBJ Models|*.obj"
        Me.SaveOBJ.Title = "Export to Wavefront OBJ"
        '
        'OpenTexture
        '
        Me.OpenTexture.Filter = "Texture Images|*.png;*.jpg;*.bmp"
        '
        'SaveScreenPNG
        '
        Me.SaveScreenPNG.Filter = "Portable network graphics files|*.png"
        Me.SaveScreenPNG.Title = "Save screenshot"
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.Rotate90Left, Me.Rotate90Right, Me.Rotate90Up, Me.Rotate90Down, Me.ToolStripSeparator1, Me.ToggleTextureButton, Me.ToggleWireframeButton, Me.AxisMarkerToggle, Me.ToolStripSeparator3})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(856, 44)
        Me.ToolStrip.TabIndex = 9
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'Rotate90Left
        '
        Me.Rotate90Left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rotate90Left.Image = CType(resources.GetObject("Rotate90Left.Image"), System.Drawing.Image)
        Me.Rotate90Left.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Rotate90Left.Name = "Rotate90Left"
        Me.Rotate90Left.Size = New System.Drawing.Size(23, 41)
        Me.Rotate90Left.Text = "Rotate 90 degress -X"
        Me.Rotate90Left.ToolTipText = "Rotate 90 degress left"
        '
        'Rotate90Right
        '
        Me.Rotate90Right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rotate90Right.Image = CType(resources.GetObject("Rotate90Right.Image"), System.Drawing.Image)
        Me.Rotate90Right.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Rotate90Right.Name = "Rotate90Right"
        Me.Rotate90Right.Size = New System.Drawing.Size(23, 41)
        Me.Rotate90Right.Text = "Rotate 90 degress +X"
        Me.Rotate90Right.ToolTipText = "Rotate 90 degrees right"
        '
        'Rotate90Up
        '
        Me.Rotate90Up.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rotate90Up.Image = CType(resources.GetObject("Rotate90Up.Image"), System.Drawing.Image)
        Me.Rotate90Up.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Rotate90Up.Name = "Rotate90Up"
        Me.Rotate90Up.Size = New System.Drawing.Size(23, 41)
        Me.Rotate90Up.Text = "Rotate 90 degrees +Y"
        Me.Rotate90Up.ToolTipText = "Rotate 90 degrees up"
        '
        'Rotate90Down
        '
        Me.Rotate90Down.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rotate90Down.Image = CType(resources.GetObject("Rotate90Down.Image"), System.Drawing.Image)
        Me.Rotate90Down.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Rotate90Down.Name = "Rotate90Down"
        Me.Rotate90Down.Size = New System.Drawing.Size(23, 41)
        Me.Rotate90Down.Text = "Rotate 90 degrees -Y"
        Me.Rotate90Down.ToolTipText = "Rotate 90 degrees down"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'ToggleTextureButton
        '
        Me.ToggleTextureButton.AutoSize = False
        Me.ToggleTextureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToggleTextureButton.Image = CType(resources.GetObject("ToggleTextureButton.Image"), System.Drawing.Image)
        Me.ToggleTextureButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToggleTextureButton.Name = "ToggleTextureButton"
        Me.ToggleTextureButton.Size = New System.Drawing.Size(36, 35)
        Me.ToggleTextureButton.Text = "Textures ON"
        '
        'ToggleWireframeButton
        '
        Me.ToggleWireframeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToggleWireframeButton.Image = CType(resources.GetObject("ToggleWireframeButton.Image"), System.Drawing.Image)
        Me.ToggleWireframeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToggleWireframeButton.Name = "ToggleWireframeButton"
        Me.ToggleWireframeButton.Size = New System.Drawing.Size(23, 41)
        Me.ToggleWireframeButton.Text = "Wireframe OFF"
        '
        'AxisMarkerToggle
        '
        Me.AxisMarkerToggle.AutoSize = False
        Me.AxisMarkerToggle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AxisMarkerToggle.Image = CType(resources.GetObject("AxisMarkerToggle.Image"), System.Drawing.Image)
        Me.AxisMarkerToggle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AxisMarkerToggle.Name = "AxisMarkerToggle"
        Me.AxisMarkerToggle.Size = New System.Drawing.Size(36, 35)
        Me.AxisMarkerToggle.Text = "Axis Marker ON"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 44)
        '
        'RotateTimer
        '
        Me.RotateTimer.Interval = 5
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 573)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.CameraSensitivityScroll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.SimpleOpenGlControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.Text = "Bottles' Glasses 0.80"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.CameraSensitivityScroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.FileTreeContextMenu.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 'INITIAL SETUP FOR OGL
#Region "STRUCTS" 'DATA STORAGE
    Structure TexCache
        Dim id As Integer
        Dim offset As UInteger
    End Structure
    Structure TexBuffer
        Dim fmtid As String
        Dim offset As Integer
        Dim data() As Byte
        Dim size As Integer
        Dim width As Integer
        Dim height As Integer
        Dim bpp As Integer
    End Structure
    Structure Camera
        Dim XPos As Int16
        Dim YPos As Int16
        Dim ZPos As Int16
        Dim XRot As Int16
        Dim YRot As Int16
        Dim ZRot As Int16
    End Structure
    Structure Vertex3D
        Dim x() As Int16
        Dim y() As Int16
        Dim z() As Int16
        Dim u() As Int16
        Dim v() As Int16
        Dim r() As Single
        Dim g() As Single
        Dim b() As Single
        Dim a() As Single
    End Structure
    Structure ColorLUT
        Dim r As ArrayList
        Dim g As ArrayList
        Dim b As ArrayList
        Dim a As ArrayList
    End Structure
    Structure DLCommand
        Dim CMDLow As UInteger
        Dim CMDHigh As UInteger
        Dim CMDDword() As Byte
        Dim SkipCommand As Boolean
    End Structure
    Structure DisplayList
        Dim Skip As Boolean
        Dim StartPos As Integer
        Dim EndPos As Integer
        Dim DrawPosition As Camera
        Dim Commands() As DLCommand
    End Structure
    Structure OBJWriteBuffers
        Dim v As ArrayList
        Dim vt As ArrayList
        Dim g As ArrayList
    End Structure
    Structure TextureEditor
        Dim RDRAMOffset As ArrayList
        Dim Width As ArrayList
        Dim Height As ArrayList
        Dim Format As ArrayList
        Dim texelsize As ArrayList
        Dim SettileOff As ArrayList
    End Structure
#End Region 'DATA STORAGE
#Region "Variables"

    Private rottype As Integer = 0
    Private rotcoef As Integer = 90

    Private Textures() As TexBuffer
    Private MTexBuffer() As Byte
    Private TextureCache() As TexCache
    Private GEOMODE As UInt32 = 0
    Private tGeoSet As String = ""
    Private tGeoClear As String = ""
    Private SearchFound As New ArrayList
    Private FindTracker As Integer = -1
    Private oldFindTracker As Integer = -1
    Private InvertY As Boolean = False
    Private RAND As New Random
    Private EnableTEX As Boolean = True
    Private EnableCC As Boolean = True
    Private TextureCount As Integer = 0
    Private TextureEd As New TextureEditor
    Private v0 As Byte
    Private n As Byte
    Private vtxbegin As UInt32
    Private VertCache As New Vertex3D
    Private OBJData As New OBJWriteBuffers
    Private subdir As String
    Private OBJTextures As New ArrayList
    Private NewObjGroup As Boolean = False
    Private objstr As FileStream
    Private objfile As StreamWriter
    Private mtlstr As FileStream
    Private mtlfile As StreamWriter
    Private OBJMode As Boolean = False
    Private AlphaTest As Boolean = False
    Private MaxAnisotropy(0) As Single
    Private XRatio As Double = 0.0
    Private YRatio As Double = 0.0
    Private ini As New INIFile(Application.StartupPath & "\bg.ini")
    Private CurrNode As Integer = -1
    Private ModelFiles() As String
    Private verifyFiles As Boolean = False
    Private LineSize As UInt32 = 0
    Private TexFormat As UInt32 = 0
    Private TexelSize As UInt32 = 0
    Private TexCnt As UInteger = 0
    Private CMT As UInt32 = 0
    Private CMS As UInt32 = 0
    Private TexStart As Integer = 0
    Private N64TexIMG() As Byte
    Private OGLTexIMG() As Byte
    Private baseoffset As Integer = 0
    Private endoffset As Integer = 0
    Private VTCount As Integer = 0
    Private ShaderLines As New ArrayList
    Private DataBuffer() As Byte
    Private V1 As Int16 = 0
    Private V2 As Int16 = 0
    Private V3 As Int16 = 0
    Private V4 As Int16 = 0
    Private V5 As Int16 = 0
    Private V6 As Int16 = 0
    Private x As Int16
    Private y As Int16
    Private z As Int16
    Private u As Int16
    Private v As Int16
    Private r As Double
    Private g As Double
    Private b As Double
    Private a As Double
    Private EnableLighting As Boolean = False
    Private NewTexture As Boolean = False
    Private TIMGOffset As Integer = 0
    Private CMDLow As UInt32
    Private CMDHigh As UInt32
    Private NxtCMDLow As UInt32
    Private NxtCMDHigh As UInt32
    Private TextureHRatio As Double
    Private TextureWRatio As Double
    Private pixel(2) As Byte

    Private i As Integer = 0
    Private i1 As Integer = 0
    Private i2 As Integer = 0
    Private i3 As Integer = 0
    Private i4 As Integer = 0
    Private CurCMD As Integer = 0
    Private GoStrafe As Boolean = False
    Private EnableAxisMarker As Boolean = True
    Private EnableWireFrame As Boolean = False
    Private RotateSceneClick As Boolean = False
    Private key_a As Boolean = False
    Private key_s As Boolean = False
    Private key_w As Boolean = False
    Private key_d As Boolean = False
    Private key_ctrl As Boolean = False
    Private xrotad, yrotad, zrotad As Double
    Private xrot As Single = 0.0
    Private yrot As Single = 0.0
    Private zrot As Single = 0.0
    Private newx, newy As Integer
    Private oldx, oldy As Integer
    Private finalx As Double = 0
    Private finaly As Double = 0
    Private finalz As Double = 0
    Private LineList As UInt32 = 0
    Private Run As Double = 1
    Private Vertices As Vertex3D
    Private N64Dlist(-1) As DisplayList
    Private Extracted As New ColorLUT
    Private Palette() As Byte
    Private Paloff As Integer = 0
    Private TexBytes As Integer = 0
    Private CurrentTex As Integer = 0
    Private TextureW As Integer = 0
    Private TextureH As Integer = 0
    Private T_Scale As Double = 0.0
    Private S_Scale As Double = 0.0
    Private COMBINE0 As UInt32 = 0
    Private COMBINE1 As UInt32 = 0
    Private NewOtherModeL As Boolean = False
    Private NewOtherModeH As Boolean = False
    Private NewCombine As Boolean = False
    Private NewGeoSet As Boolean = False
    Private NewGeoClear As Boolean = False
    Private OtherModeHStr As String = ""
    Private OtherModeLStr As String = ""
    Private cA(1) As Integer
    Private cB(1) As Integer
    Private cC(1) As Integer
    Private cD(1) As Integer
    Private aA(1) As Integer
    Private aB(1) As Integer
    Private aC(1) As Integer
    Private aD(1) As Integer
#End Region 'VARIABLES
#Region "F3D(EX) Display list processor"
    Private Sub ParseCurrentCommandLimited()
        Select Case n64dlist(0).Commands(curCMD).CMDDword(0)
            Case F3DEX_VTX
                VTX()
            Case F3DEX_TRI1

                TRI1()
            Case F3DEX_TRI2

                TRI2()
        End Select
    End Sub
    Private Sub ParseDL(ByVal n64dlist As DisplayList)
        For i As Integer = 0 To n64dlist.Commands.Length - 1
            CMDHigh = (n64dlist.Commands(i).CMDHigh << 8 >> 8)
            CMDLow = n64dlist.Commands(i).CMDLow

            If (i + 1) < n64dlist.Commands.Length Then
                NxtCMDHigh = (n64dlist.Commands(i + 1).CMDHigh)
                NxtCMDLow = n64dlist.Commands(i + 1).CMDLow
            Else
                NxtCMDHigh = 0
                NxtCMDLow = 0
            End If
            Select Case n64dlist.Commands(i).CMDDword(0)
                Case F3DEX_TRI1
                    TRI1()
                Case F3DEX_TRI2
                    TRI2()
                Case F3DEX_VTX
                    VTX()
                    NewCombine = False
                    NewGeoClear = False
                    NewGeoSet = False
                    NewOtherModeH = False
                    NewOtherModeL = False
                Case G_SETTIMG
                    SETTIMG()
                Case G_SETTILESIZE
                    SETTILESIZE((CMDHigh >> 14) And &H3FF, (CMDHigh >> 2) And &H3FF, (CMDLow >> 14) And &H3FF, (CMDLow >> 2) And &H3FF)
                Case G_SETTILE
                    SETTILE()
                Case G_LOADTLUT
                    LOADTLUT()
                Case F3DEX_TEXTURE
                    TEXTURESCALE()
                Case F3DEX_SETOTHERMODE_L
                    SETOTHERMODEL()
                Case F3DEX_SETGEOMETRYMODE
                    SETGEOMETRYMODE()
                Case F3DEX_CLEARGEOMETRYMODE
                    CLEARGEOMETRYMODE()
                Case F3DEX_SETOTHERMODE_H
                    NewOtherModeH = True
                    OtherModeHStr = "omh 0xBA" & CMDHigh.ToString("X6") & CMDLow.ToString("X8")
                Case F3DEX_SETOTHERMODE_L
                    NewOtherModeL = True
                    OtherModeLStr = "oml 0xB9" & CMDHigh.ToString("X6") & CMDLow.ToString("X8")
                Case F3DEX_ENDDL
                    If i > 0 Then
                        If n64dlist.Commands(i - 1).CMDDword(0) <> F3DEX_VTX Then
                            Gl.glDisable(Gl.GL_TEXTURE_2D)
                        End If
                    End If
            End Select
        Next
    End Sub

    Private Sub VTX()
        Try
            If Game = 0 Then
                v0 = ((CMDHigh >> 16) And &HFF) >> 1
                n = (CMDHigh >> 8 And &HFF) >> 2
            Else
                n = (CMDHigh And &HFFF) >> 1
                v0 = n - ((CMDHigh And &HFFF000) >> 12)
            End If
            If v0 > 31 Then v0 = 31
            Dim Offset As UInteger = ((CMDLow << 8) >> 8) \ 16
            Dim v As UInteger = Offset
            For iv As Integer = v0 To (n + v0) - 1
                If v < Vertices.x.Length Then
                    With VertCache
                        .x(iv) = Vertices.x(v)
                        .y(iv) = Vertices.y(v)
                        .z(iv) = Vertices.z(v)
                        .u(iv) = Vertices.u(v)
                        .v(iv) = Vertices.v(v)
                        .r(iv) = Vertices.r(v)
                        .g(iv) = Vertices.g(v)
                        .b(iv) = Vertices.b(v)
                        .a(iv) = Vertices.a(v)
                    End With
                End If
                v += 1
            Next
            If OBJMode And v0 = 0 Then
                OBJData.g.Add("g " & "VTX_SEG_0x" & Hex(Offset))
                If NewGeoClear Then OBJData.g.Add(tGeoClear)
                If NewGeoSet Then OBJData.g.Add(tGeoSet)
                If NewOtherModeH Then OBJData.g.Add(OtherModeHStr)
                If NewOtherModeL Then OBJData.g.Add(OtherModeLStr)
                If NewCombine Then
                    OBJData.g.Add("cmb 0xFC" & COMBINE0.ToString("X2") & COMBINE1.ToString("X2"))
                End If
            End If
            If EnableTEX And NewTexture Then LoadTex()
        Catch err As Exception
            MsgBox("G_VTX ERROR NEED FIX FOR GRUNTY BEAUTIFUL" & Environment.NewLine & Environment.NewLine & err.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CLEARGEOMETRYMODE()
        NewGeoClear = True
        Dim MCLEAR As UInt32 = ((CMDLow And &HFFFFFF) << 8) >> 8
        Dim CULL_FRONT As Boolean = (MCLEAR And &H1000) <> 0
        Dim CULL_BACK As Boolean = (MCLEAR And &H2000) <> 0
        Dim CULL_BOTH As Boolean = (MCLEAR And &H3000) <> 0
        EnableLighting = (MCLEAR And &H20000) <> 0
        If CULL_FRONT Then
            Gl.glDisable(Gl.GL_CULL_FACE)
        ElseIf CULL_BACK Then
            Gl.glDisable(Gl.GL_CULL_FACE)
        End If
        If OBJMode Then tGeoClear = "gclear 0xB6" & CMDHigh.ToString("X6") & CMDLow.ToString("X8")
    End Sub
    Private Sub SETGEOMETRYMODE()
        Dim MSET As UInt32 = ((CMDLow And &HFFFFFF) << 8) >> 8
        NewGeoSet = True
        If Game = 0 Then
            Dim CULL_FRONT As Boolean = (MSET And &H1000) <> 0
            Dim CULL_BACK As Boolean = (MSET And &H2000) <> 0
            Dim CULL_BOTH As Boolean = (MSET And &H3000) <> 0
            EnableLighting = (MSET And &H20000) <> 0
            If CULL_FRONT Then
                Gl.glCullFace(Gl.GL_FRONT)
            ElseIf CULL_BACK Then
                Gl.glCullFace(Gl.GL_BACK)
            ElseIf CULL_BOTH Then
                Gl.glCullFace(Gl.GL_FRONT_AND_BACK)
            Else
                Exit Sub
            End If
            Gl.glEnable(Gl.GL_CULL_FACE)
            If OBJMode Then tGeoSet = "gset 0xB7" & CMDHigh.ToString("X6") & CMDLow.ToString("X8")
        Else
            Dim MCLEAR As UInt32 = CMDHigh
            EnableLighting = (MSET And &H20000) <> 0
            GEOMODE = (GEOMODE And MCLEAR) Or MSET
            If (GEOMODE And G_CULL_BACK) Then
                Gl.glEnable(Gl.GL_CULL_FACE)
                Gl.glCullFace(Gl.GL_BACK)
            ElseIf (GEOMODE And G_CULL_FRONT) Then
                Gl.glEnable(Gl.GL_CULL_FACE)
                Gl.glCullFace(Gl.GL_FRONT)
            Else
                Gl.glDisable(Gl.GL_CULL_FACE)
            End If
        End If
    End Sub

    Private Sub TRI1()
        Try
            If Vertices.x.Length > 0 Then

                If Game = 0 Then
                    V4 = (((CMDLow >> 16) And &HFF) >> 1)
                    V5 = (((CMDLow >> 8) And &HFF) >> 1)
                    V6 = (((CMDLow >> 0) And &HFF) >> 1)
                Else
                    V1 = (((CMDHigh >> 16) And &HFF) >> 1)
                    V2 = (((CMDHigh >> 8) And &HFF) >> 1)
                    V3 = (((CMDHigh >> 0) And &HFF) >> 1)
                End If
                If OBJMode Then
                    V1 += vtxbegin
                    V2 += vtxbegin
                    V3 += vtxbegin
                    With OBJData
                        .vt(V1) = "vt " & CSng(Vertices.u(V1) * TextureWRatio) & " " & -CSng(Vertices.v(V1) * TextureHRatio)
                        .vt(V2) = "vt " & CSng(Vertices.u(V2) * TextureWRatio) & " " & -CSng(Vertices.v(V2) * TextureHRatio)
                        .vt(V3) = "vt " & CSng(Vertices.u(V3) * TextureWRatio) & " " & -CSng(Vertices.v(V3) * TextureHRatio)
                        V1 += 1
                        V2 += 1
                        V3 += 1
                        .g.Add("f " & V1 & "/" & _
                                V1 & " " _
                                     & V2 & "/" & V2 & _
                                        " " & V3 & "/" & V3)
                    End With
                    Exit Sub
                End If
                If EnableLighting Or Not EnableCC Then
                    Gl.glBegin(Gl.GL_TRIANGLES)
                    Gl.glColor3f(1, 1, 1)
                    Gl.glNormal3f(VertCache.r(V1), VertCache.g(V1), VertCache.b(V1))
                    Gl.glTexCoord2f(VertCache.u(V1) * TextureWRatio, VertCache.v(V1) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V1), VertCache.y(V1), VertCache.z(V1))

                    Gl.glNormal3f(VertCache.r(V2), VertCache.g(V2), VertCache.b(V2))
                    Gl.glTexCoord2f(VertCache.u(V2) * TextureWRatio, VertCache.v(V2) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V2), VertCache.y(V2), VertCache.z(V2))

                    Gl.glNormal3f(VertCache.r(V3), VertCache.g(V3), VertCache.b(V3))
                    Gl.glTexCoord2f(VertCache.u(V3) * TextureWRatio, VertCache.v(V3) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V3), VertCache.y(V3), VertCache.z(V3))
                    Gl.glEnd()
                Else
                    Gl.glBegin(Gl.GL_TRIANGLES)
                    Gl.glColor4f(VertCache.r(V1), VertCache.g(V1), VertCache.b(V1), VertCache.a(V1))
                    Gl.glTexCoord2f(VertCache.u(V1) * TextureWRatio, VertCache.v(V1) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V1), VertCache.y(V1), VertCache.z(V1))

                    Gl.glColor4f(VertCache.r(V2), VertCache.g(V2), VertCache.b(V2), VertCache.a(V2))
                    Gl.glTexCoord2f(VertCache.u(V2) * TextureWRatio, VertCache.v(V2) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V2), VertCache.y(V2), VertCache.z(V2))

                    Gl.glColor4f(VertCache.r(V3), VertCache.g(V3), VertCache.b(V3), VertCache.a(V3))
                    Gl.glTexCoord2f(VertCache.u(V3) * TextureWRatio, VertCache.v(V3) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V3), VertCache.y(V3), VertCache.z(V3))
                    Gl.glEnd()
                End If
            End If
        Catch ex As Exception
            MsgBox("F3D_TRI1 ERROR NEED FIX FOR GRUNTY BEAUTIFUL!" & Environment.NewLine & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Gl.glEnd()
        End Try
    End Sub
    Private Sub TRI2()
        Try
            If Vertices.x.Length > 0 Then

                V1 = (((CMDHigh >> 16) And &HFF) \ 2)
                V2 = (((CMDHigh >> 8) And &HFF) \ 2)
                V3 = (((CMDHigh) And &HFF) \ 2)
                V4 = (((CMDLow >> 16) And &HFF) \ 2)
                V5 = (((CMDLow >> 8) And &HFF) \ 2)
                V6 = (((CMDLow) And &HFF) \ 2)

                If OBJMode Then
                    V1 += vtxbegin
                    V2 += vtxbegin
                    V3 += vtxbegin
                    V4 += vtxbegin
                    V5 += vtxbegin
                    V6 += vtxbegin
                    With OBJData
                        .vt(V1) = "vt " & CSng(Vertices.u(V1) * TextureWRatio) & " " & -CSng(Vertices.v(V1) * TextureHRatio)
                        .vt(V2) = "vt " & CSng(Vertices.u(V2) * TextureWRatio) & " " & -CSng(Vertices.v(V2) * TextureHRatio)
                        .vt(V3) = "vt " & CSng(Vertices.u(V3) * TextureWRatio) & " " & -CSng(Vertices.v(V3) * TextureHRatio)
                        .vt(V4) = "vt " & CSng(Vertices.u(V4) * TextureWRatio) & " " & -CSng(Vertices.v(V4) * TextureHRatio)
                        .vt(V5) = "vt " & CSng(Vertices.u(V5) * TextureWRatio) & " " & -CSng(Vertices.v(V5) * TextureHRatio)
                        .vt(V6) = "vt " & CSng(Vertices.u(V6) * TextureWRatio) & " " & -CSng(Vertices.v(V6) * TextureHRatio)
                        V1 += 1
                        V2 += 1
                        V3 += 1
                        V4 += 1
                        V5 += 1
                        V6 += 1
                        .g.Add("f " & V1 & "/" & _
                                        V1 & " " _
                                         & V2 & "/" & V2 & _
                                            " " & V3 & "/" & V3)

                        .g.Add("f " & V4 & "/" & _
                                          V4 & " " _
                                          & V5 & "/" & V5 & _
                                          " " & V6 & "/" & V6)
                    End With
                    Exit Sub
                End If
                If EnableLighting Or Not EnableCC Then
                    Gl.glBegin(Gl.GL_TRIANGLES)

                    Gl.glColor3f(1, 1, 1)
                    Gl.glNormal3f(VertCache.r(V1), VertCache.g(V1), VertCache.b(V1))
                    Gl.glTexCoord2f(VertCache.u(V1) * TextureWRatio, VertCache.v(V1) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V1), VertCache.y(V1), VertCache.z(V1))

                    Gl.glNormal3f(VertCache.r(V2), VertCache.g(V2), VertCache.b(V2))
                    Gl.glTexCoord2f(VertCache.u(V2) * TextureWRatio, VertCache.v(V2) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V2), VertCache.y(V2), VertCache.z(V2))

                    Gl.glNormal3f(VertCache.r(V3), VertCache.g(V3), VertCache.b(V3))
                    Gl.glTexCoord2f(VertCache.u(V3) * TextureWRatio, VertCache.v(V3) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V3), VertCache.y(V3), VertCache.z(V3))

                    Gl.glNormal3f(VertCache.r(V4), VertCache.g(V4), VertCache.b(V4))
                    Gl.glTexCoord2f(VertCache.u(V4) * TextureWRatio, VertCache.v(V4) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V4), VertCache.y(V4), VertCache.z(V4))

                    Gl.glNormal3f(VertCache.r(V5), VertCache.g(V5), VertCache.b(V5))
                    Gl.glTexCoord2f(VertCache.u(V5) * TextureWRatio, VertCache.v(V5) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V5), VertCache.y(V5), VertCache.z(V5))

                    Gl.glNormal3f(VertCache.r(V6), VertCache.g(V6), VertCache.b(V6))
                    Gl.glTexCoord2f(VertCache.u(V6) * TextureWRatio, VertCache.v(V6) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V6), VertCache.y(V6), VertCache.z(V6))

                    Gl.glEnd()
                Else
                    Gl.glBegin(Gl.GL_TRIANGLES)

                    Gl.glColor4f(VertCache.r(V1), VertCache.g(V1), VertCache.b(V1), VertCache.a(V1))
                    Gl.glTexCoord2f(VertCache.u(V1) * TextureWRatio, VertCache.v(V1) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V1), VertCache.y(V1), VertCache.z(V1))

                    Gl.glColor4f(VertCache.r(V2), VertCache.g(V2), VertCache.b(V2), VertCache.a(V2))
                    Gl.glTexCoord2f(VertCache.u(V2) * TextureWRatio, VertCache.v(V2) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V2), VertCache.y(V2), VertCache.z(V2))

                    Gl.glColor4f(VertCache.r(V3), VertCache.g(V3), VertCache.b(V3), VertCache.a(V3))
                    Gl.glTexCoord2f(VertCache.u(V3) * TextureWRatio, VertCache.v(V3) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V3), VertCache.y(V3), VertCache.z(V3))

                    Gl.glColor4f(VertCache.r(V4), VertCache.g(V4), VertCache.b(V4), VertCache.a(V4))
                    Gl.glTexCoord2f(VertCache.u(V4) * TextureWRatio, VertCache.v(V4) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V4), VertCache.y(V4), VertCache.z(V4))

                    Gl.glColor4f(VertCache.r(V5), VertCache.g(V5), VertCache.b(V5), VertCache.a(V5))
                    Gl.glTexCoord2f(VertCache.u(V5) * TextureWRatio, VertCache.v(V5) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V5), VertCache.y(V5), VertCache.z(V5))

                    Gl.glColor4f(VertCache.r(V6), VertCache.g(V6), VertCache.b(V6), VertCache.a(V6))
                    Gl.glTexCoord2f(VertCache.u(V6) * TextureWRatio, VertCache.v(V6) * TextureHRatio)
                    Gl.glVertex3f(VertCache.x(V6), VertCache.y(V6), VertCache.z(V6))

                    Gl.glEnd()
                End If
            End If
        Catch ex As Exception
            MsgBox("F3D_TRI2 ERROR NEED FIX FOR GRUNTY BEAUTIFUL!" & Environment.NewLine & Environment.NewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Gl.glEnd()
        End Try
    End Sub
    Private Sub TEXTURESCALE()
        S_Scale = (CMDLow >> 16) / 65536
        T_Scale = (CMDLow And &HFFFF) / 65536
    End Sub
    Private Sub SETOTHERMODEL()
        Dim zmode As Byte = (CMDLow >> 10) And 3
        Dim forceblend As Byte = (CMDLow >> 12) And 1
        Dim cvgXalpha As Byte = (CMDLow >> 14) And 1
        Dim alphacvgsel As Byte = (CMDLow >> 13) And 1
        Dim zcompare As Byte = (CMDLow >> 4) And 1
        Dim zupdate As Byte = (CMDLow >> 5) And 1
        Select Case 32 - ((CMDHigh >> 8) And &HFF) - (CMDHigh And &HFF) - 1
            Case 0 'alphacompare
            Case 2 'zsrcsel  
            Case 3 'rendermode
                If zmode = 3 Then
                    Gl.glEnable(Gl.GL_POLYGON_OFFSET_FILL)
                    Gl.glPolygonOffset(-3, -3)
                Else
                    Gl.glDisable(Gl.GL_POLYGON_OFFSET_FILL)
                End If
                If forceblend = 1 Then
                    Gl.glEnable(Gl.GL_BLEND)
                Else
                    Gl.glDisable(Gl.GL_BLEND)
                End If
                If cvgXalpha = 1 Then
                    Gl.glAlphaFunc(Gl.GL_GREATER, 0.0F)
                    Gl.glEnable(Gl.GL_ALPHA_TEST)
                    Exit Sub
                Else
                    Gl.glDisable(Gl.GL_ALPHA_TEST)
                End If
                If zcompare = 1 Then
                    Gl.glDepthFunc(Gl.GL_LEQUAL)
                    Gl.glEnable(Gl.GL_DEPTH_TEST)
                Else
                    Gl.glDisable(Gl.GL_DEPTH_TEST)
                End If
            Case Else 'blender

        End Select
    End Sub
    Private Sub SETTILESIZE(ByVal ULS As UInt16, ByVal ULT As UInt16, ByVal LRS As UInt16, ByVal LRT As UInt16)
        TextureW = ((LRS - ULS) + 1)
        TextureH = ((LRT - ULT) + 1)
        TextureHRatio = T_Scale / 32 / TextureH
        TextureWRatio = S_Scale / 32 / TextureW
    End Sub
    Private Sub LOADTLUT()
        Dim palbytes As Integer = (((CMDLow >> 14) And &H3FF) * 2) + 2
        ReDim Palette(palbytes - 1)
        Dim rExtract As Byte = 0
        Dim gExtract As UInt16 = 0
        Dim bExtract As Byte = 0
        Dim aExtract As Byte = 0
        For j As Integer = 0 To palbytes - 1
            Palette(j) = MTexBuffer(Paloff + j)
        Next
        Extracted.r.Clear()
        Extracted.g.Clear()
        Extracted.b.Clear()
        Extracted.a.Clear()
        For iw As Integer = 0 To palbytes - 1 Step 2
            rExtract = Palette(iw) >> 3
            gExtract = Palette(iw) * 256 Xor Palette(iw + 1)
            gExtract >>= 6
            gExtract <<= 11
            gExtract >>= 11
            bExtract = Palette(iw + 1) >> 1
            bExtract <<= 3
            bExtract >>= 3
            aExtract = Palette(iw + 1) << 7
            aExtract >>= 7

            Extracted.r.Add(rExtract * 8)
            Extracted.g.Add(gExtract * 8)
            Extracted.b.Add(bExtract * 8)
            Extracted.a.Add(aExtract * 255)
        Next
    End Sub

    Private Sub SETTIMG()
        If EnableTEX Then
            Dim tmpoff As Integer = ((CMDLow << 8) >> 8)
            Dim nxtCmd As Byte = (NxtCMDHigh >> 24)
            Dim palette As Boolean = (nxtCmd = &HF0) Or ((nxtCmd = &HF5) And (NxtCMDHigh << 8 >> 24 = 0))

            If palette Then
                Paloff = tmpoff
            Else
                TIMGOffset = tmpoff
                Gl.glEnable(Gl.GL_TEXTURE_2D)
                NewTexture = True
            End If
            For i As Integer = 0 To Textures.Length - 1
                If Textures(i).offset = tmpoff Or Textures(i).offset + 32 = tmpoff Then
                    For j As Integer = 0 To TextureCache.Length - 1
                        If tmpoff = TextureCache(j).offset Then
                            NewTexture = False
                            Gl.glBindTexture(Gl.GL_TEXTURE_2D, TextureCache(j).id)
                            Exit For
                        End If
                    Next
                    SETTILESIZE(0, 0, Textures(i).width - 1, Textures(i).height - 1)
                    TexBytes = Textures(i).size * (Textures(i).bpp)
                    CurrentTex = i
                    Exit Sub
                End If
            Next
        End If
    End Sub
    Private Sub SETTILE()
        TexFormat = (CMDHigh >> 21) And &H7
        TexelSize = (CMDHigh >> 19) And &H3
        Textures(CurrentTex).fmtid = TEXFORMATS(TexFormat) & " " & TEXSIZES(TexelSize)
        ModelContentTree.Nodes(1).Nodes(CurrentTex).Nodes(0).Text = Textures(CurrentTex).fmtid
        LineSize = (CMDHigh >> 9) And &HF
        CMT = (CMDLow >> 18) And &H2
        CMS = (CMDLow >> 8) And &H3
    End Sub
    Private Sub LoadTex()
        Try
            NewTexture = False
            If TexelSize < 3 Then
                Dim texposogl As UInteger = 0
                Dim texposn64 As UInteger = 0
                Dim texSizeReal As UInteger = (TexBytes \ ((LineSize) \ (Textures(CurrentTex).bpp * 2)))
                ReDim N64TexIMG((texSizeReal * 2) - 1)
                ReDim OGLTexIMG((texSizeReal * 8) - 1)
                ReDim Preserve TextureCache(TexCnt)
                TextureCache(TexCnt).offset = TIMGOffset
                Array.Copy(MTexBuffer, TIMGOffset, N64TexIMG, 0, texSizeReal \ 2)
                Select Case TexFormat
                    Case 0 'RGBA - red, green, blue, alpha
                        Select Case TexelSize
                            Case 2
                                Dim RGBA5551 As UInt16
                                Dim aExtract As Byte
                                For i As Integer = 0 To TextureH - 1
                                    For j As Integer = 0 To TextureW - 1
                                        RGBA5551 = ReadInt16(N64TexIMG, texposn64)
                                        If RGBA5551 And 1 Then
                                            aExtract = 255
                                        Else
                                            aExtract = 0
                                        End If
                                        OGLTexIMG(texposogl) = (RGBA5551 And &HF800) >> 8
                                        OGLTexIMG(texposogl + 1) = ((RGBA5551 And &H7C0) << 5) >> 8
                                        OGLTexIMG(texposogl + 2) = ((RGBA5551 And &H3E) << 18) >> 16
                                        OGLTexIMG(texposogl + 3) = aExtract
                                        texposn64 += 2
                                        texposogl += 4
                                    Next
                                    If LineSize > 0 Then texposn64 += (LineSize * 4) - TextureW
                                Next
                        End Select
                    Case 2 'CI - 16bpp RGBA palette with 4/8texelsize array of indices
                        Select Case TexelSize
                            Case 0
                                Dim n1 As Byte = 0
                                Dim n2 As Byte = 0
                                For i As Integer = 0 To (TextureH - 1)
                                    For j As Integer = 0 To (TextureW \ 2) - 1
                                        n1 = (N64TexIMG(texposn64) >> 4)
                                        n2 = N64TexIMG(texposn64) << 4 >> 4

                                        OGLTexIMG(texposogl) = CByte(Extracted.r(n1))
                                        OGLTexIMG(texposogl + 1) = CByte(Extracted.g(n1))
                                        OGLTexIMG(texposogl + 2) = CByte(Extracted.b(n1))
                                        OGLTexIMG(texposogl + 3) = CByte(Extracted.a(n1))
                                        OGLTexIMG(texposogl + 4) = CByte(Extracted.r(n2))
                                        OGLTexIMG(texposogl + 5) = CByte(Extracted.g(n2))
                                        OGLTexIMG(texposogl + 6) = CByte(Extracted.b(n2))
                                        OGLTexIMG(texposogl + 7) = CByte(Extracted.a(n2))
                                        texposn64 += 1
                                        texposogl += 8
                                    Next
                                    texposn64 += (LineSize * 8) - (TextureW \ 2)
                                Next
                            Case 1
                                Dim n1 As Byte
                                For i As Integer = 0 To (TextureH - 1)
                                    For j As Integer = 0 To (TextureW - 1)
                                        n1 = N64TexIMG(texposn64)
                                        OGLTexIMG(texposogl) = CByte(Extracted.r(n1))
                                        OGLTexIMG(texposogl + 1) = CByte(Extracted.g(n1))
                                        OGLTexIMG(texposogl + 2) = CByte(Extracted.b(n1))
                                        OGLTexIMG(texposogl + 3) = CByte(Extracted.a(n1))
                                        texposn64 += 1
                                        texposogl += 4
                                    Next
                                    texposn64 += (LineSize * 8) - (TextureW)
                                Next
                        End Select
                    Case 3 'IA - grayscale with alpha
                        Select Case TexelSize
                            Case 2
                                Dim bright As Byte = 0
                                Dim alpha As Byte = 0
                                For i As Integer = 0 To TextureH - 1
                                    For j As Integer = 0 To TextureW - 1
                                        bright = N64TexIMG(texposn64)
                                        alpha = N64TexIMG(texposn64 + 1)
                                        OGLTexIMG(texposogl) = bright
                                        OGLTexIMG(texposogl + 1) = bright
                                        OGLTexIMG(texposogl + 2) = bright
                                        OGLTexIMG(texposogl + 3) = alpha
                                        texposn64 += 2
                                        texposogl += 4
                                    Next
                                    texposn64 += (LineSize * 4) - TextureW
                                Next
                            Case 1
                                Dim bright As Byte = 0
                                Dim alpha As Byte = 0
                                For i As Integer = 0 To TextureH - 1
                                    For j As Integer = 0 To TextureW - 1
                                        bright = N64TexIMG(texposn64) >> 4
                                        alpha = (N64TexIMG(texposn64) << 4) >> 4
                                        OGLTexIMG(texposogl) = bright * 17
                                        OGLTexIMG(texposogl + 1) = bright * 17
                                        OGLTexIMG(texposogl + 2) = bright * 17
                                        OGLTexIMG(texposogl + 3) = alpha * 17
                                        texposn64 += 1
                                        texposogl += 4
                                    Next
                                    texposn64 += (LineSize * 8) - (TextureW)
                                Next
                        End Select
                    Case 4 'I - grayscale
                        Select Case TexelSize
                            Case 1
                                Dim bright As Byte = 0
                                For iw As Integer = 0 To (TexBytes \ 4) - 1
                                    bright = N64TexIMG(iw) \ 16
                                    OGLTexIMG(iw * 4) = bright * 17
                                    OGLTexIMG(iw * 4 + 1) = bright * 17
                                    OGLTexIMG(iw * 4 + 2) = bright * 17
                                    OGLTexIMG(iw * 4 + 3) = bright * 17
                                Next
                            Case 0
                                Dim bright As Byte = 0
                                For iw As Integer = 0 To (TexBytes \ 2) - 1
                                    bright = N64TexIMG(iw)
                                    bright >>= 4
                                    OGLTexIMG(iw * 8) = bright * 17
                                    OGLTexIMG(iw * 8 + 1) = bright * 17
                                    OGLTexIMG(iw * 8 + 2) = bright * 17
                                    OGLTexIMG(iw * 8 + 3) = bright * 17
                                    bright = N64TexIMG(iw)
                                    bright <<= 4
                                    bright >>= 4
                                    OGLTexIMG(iw * 8 + 4) = bright * 17
                                    OGLTexIMG(iw * 8 + 5) = bright * 17
                                    OGLTexIMG(iw * 8 + 6) = bright * 17
                                    OGLTexIMG(iw * 8 + 7) = bright * 17
                                Next
                        End Select
                End Select
                Gl.glGenTextures(1, TextureCache(TexCnt).id)
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, TextureCache(TexCnt).id)
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, TextureW, TextureH, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, OGLTexIMG)
            Else '32bpp raw rgba (8888)
                ReDim N64TexIMG(TexBytes * 8)
                Array.Copy(MTexBuffer, TIMGOffset, N64TexIMG, 0, TexBytes \ 4)

                Gl.glGenTextures(1, TextureCache(TexCnt).id)
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, TextureCache(TexCnt).id)
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, TextureW, TextureH, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, N64TexIMG)
            End If

            Select Case CMS
                Case 0
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT)
                Case 2
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_CLAMP_TO_EDGE)
            End Select
            Select Case CMT
                Case 0
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT)
                Case 2
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_CLAMP_TO_EDGE)
            End Select
            If OBJMode Then
                Dim texfilename As String = "0x" & Hex(TIMGOffset)
                If Not OBJTextures.Contains(TIMGOffset) Then
                    OBJTextures.Add(TIMGOffset)
                    Dim texfile As String = subdir & texfilename & ".png"
                    If TexelSize = 3 Then
                        Il.ilLoadDataL(N64TexIMG, TexBytes * 4, TextureW, TextureH, 1, 4)
                    Else
                        If TexelSize = 2 And TexFormat = 0 Then
                            Il.ilLoadDataL(OGLTexIMG, TexBytes * 4, TextureW, TextureH, 1, 4)
                        Else
                            Il.ilLoadDataL(OGLTexIMG, TexBytes * 4, TextureW, TextureH, 1, 4)
                        End If
                    End If
                    Il.ilSave(Il.IL_PNG, texfile)
                    mtlfile.WriteLine("newmtl " & "SETTIMG_SEG_" & texfilename)
                    mtlfile.WriteLine("map_Ka " & texfilename & ".png")
                End If
                OBJData.g.Add("usemtl " & "SETTIMG_SEG_" & texfilename)
            End If
            ReDim N64TexIMG(-1)
            ReDim OGLTexIMG(-1)
            NewTexture = False
        Catch err As Exception
            Gl.glDisable(Gl.GL_TEXTURE_2D)
            NewTexture = False
        End Try
    End Sub
    Private Sub StoreMasterVertBuff(ByRef Vertices As Vertex3D, ByVal DataBuffer() As Byte, ByVal baseoffset As Integer, ByVal endoffset As Integer, ByVal lpcnt As Integer)
        With Vertices
            ReDim .x(lpcnt)
            ReDim .y(lpcnt)
            ReDim .z(lpcnt)
            ReDim .u(lpcnt)
            ReDim .v(lpcnt)
            ReDim .r(lpcnt)
            ReDim .g(lpcnt)
            ReDim .b(lpcnt)
            ReDim .a(lpcnt)
        End With
        For i3 = 0 To lpcnt
            x = (DataBuffer(baseoffset) * &H100) + DataBuffer(baseoffset + 1)
            y = (DataBuffer(baseoffset + 2) * &H100) + DataBuffer(baseoffset + 3)
            z = (DataBuffer(baseoffset + 4) * &H100) + DataBuffer(baseoffset + 5)
            u = (DataBuffer(baseoffset + 8) * &H100) + DataBuffer(baseoffset + 9)
            v = (DataBuffer(baseoffset + 10) * &H100) + DataBuffer(baseoffset + 11)
            r = DataBuffer(baseoffset + 12) / 255
            g = DataBuffer(baseoffset + 13) / 255
            b = DataBuffer(baseoffset + 14) / 255
            a = DataBuffer(baseoffset + 15) / 255
            With Vertices
                'Vertex x(l)-y(w)-z(d) coordinates
                .x(i3) = x
                .y(i3) = y
                .z(i3) = z
                .u(i3) = u
                .v(i3) = v
                .r(i3) = r
                .g(i3) = g
                .b(i3) = b
                .a(i3) = a
            End With
            baseoffset += 16
        Next
    End Sub
    Private Sub StoreDisplayLists(ByVal DataBuffer() As Byte, ByRef N64Dlist() As DisplayList, ByVal Start As UInteger, ByVal EndOff As UInteger)
        Dim curDL As Integer = 0
        Dim curCMD As Integer = 0

        ModelContentTree.Nodes(0).Nodes.Add("Display list at 0x" & Start.ToString("X8"))

        ModelContentTree.Nodes(0).Nodes(0).Checked = True

        Dim geoChanged As Boolean = False

        While Start < EndOff
            ReDim Preserve N64Dlist(curDL).Commands(curCMD)

            ReDim N64Dlist(curDL).Commands(curCMD).CMDDword(7)

            N64Dlist(curDL).Commands(curCMD).CMDHigh = ReadUInt32(DataBuffer, Start)
            N64Dlist(curDL).Commands(curCMD).CMDLow = ReadUInt32(DataBuffer, Start + 4)

            ModelContentTree.Nodes(0).Nodes(curDL).Nodes.Add("0x" & (N64Dlist(curDL).Commands(curCMD).CMDHigh >> 24 And &HFF).ToString("X2"))

            For i2 = 0 To 7
                N64Dlist(curDL).Commands(curCMD).CMDDword(i2) = DataBuffer(Start + i2)
            Next

            If (N64Dlist(curDL).Commands(curCMD).CMDDword(0) = F3DEX_VTX) Then
                geoChanged = True
            End If

            If (N64Dlist(curDL).Commands(curCMD).CMDDword(0) = F3DEX_ENDDL And curCMD > 0) And (Start + 8 < EndOff) And geoChanged Then
                geoChanged = False
                curCMD = -1
                curDL += 1
                ModelContentTree.Nodes(0).Nodes.Add("Display list at 0x" & (Start + 8).ToString("X8"))

                ModelContentTree.Nodes(0).Nodes(curDL).Checked = True

                ReDim Preserve N64Dlist(curDL)
            End If

            curCMD += 1
            Start += 8
        End While
    End Sub

#End Region 'DLIST PROCESSOR
#Region "Application Interaction"    'OTHER FUNCTIONS
    Private Sub GLInit()
        Wgl.wglSwapIntervalEXT(1)
        Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAX_ANISOTROPY_EXT, MaxAnisotropy(0))
        Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR)
        Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR)
        Gl.glEnable(Gl.GL_DEPTH_TEST)
        Gl.glEnable(Gl.GL_BLEND)
        Gl.glShadeModel(Gl.GL_SMOOTH)
        Gl.glDepthFunc(Gl.GL_LEQUAL)
        Gl.glPolygonOffset(-3, -3)
        Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA)
        Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST)
        Gl.glClearColor(0.2, 0.5, 0.8, 1)
        ResizeScene()
    End Sub

    Private Sub BuildAxisMarker()
        Gl.glLineWidth(0.5)
        linelist = Gl.glGenLists(1)
        Gl.glNewList(linelist, Gl.GL_COMPILE)
        Gl.glBegin(Gl.GL_LINES)
        Gl.glColor3f(1, 0, 0)
        Gl.glVertex3f(420, 0.1, 0.1)
        Gl.glVertex3f(-420, 0.1, 0.1)
        Gl.glEnd()
        Gl.glBegin(Gl.GL_LINES)
        Gl.glColor3f(0, 1, 0)
        Gl.glVertex3f(0.1, 420, 0.1)
        Gl.glVertex3f(0.1, -420, 0.1)
        Gl.glEnd()
        Gl.glBegin(Gl.GL_LINES)
        Gl.glColor3f(0, 0, 1)
        Gl.glVertex3f(0.1, 0.1, 420)
        Gl.glVertex3f(0.1, 0.1, -420)
        Gl.glVertex3f(0.1, 0.1, 420)
        Gl.glEnd()
        Gl.glEndList()
        Gl.glLineWidth(1)
    End Sub

    Private Sub ParseModel()
        If File.Exists(CurrModel) Then
            DataBuffer = File.ReadAllBytes(CurrModel)

            If ReadUInt32(DataBuffer, 0) <> &HB Then
                MsgBox("File loaded is not a BK or BT model!")
                CurrModel = "Nothing to load."
                ReDim DataBuffer(-1)
                Exit Sub
            End If
            ProgressBar1.Value = 10
            With VertCache
                ReDim .x(31)
                ReDim .y(31)
                ReDim .z(31)
                ReDim .u(31)
                ReDim .v(31)
                ReDim .r(31)
                ReDim .g(31)
                ReDim .b(31)
                ReDim .a(31)
            End With
            Dim state As Integer = -1
            Dim offinc As Integer = 0
            Dim offsearch As UInt32 = 0
            ReDim N64TexIMG(-1)
            ReDim OGLTexIMG(-1)
            ReDim n64dlist(0)

            Dim MasterDLStart As UInteger = 0
            Dim MasterDLEnd As UInteger = 0
            Dim MasterDLCnt As UInteger = 0

            ProgressBar1.Value = 20

            MasterDLStart = ReadUInt32(DataBuffer, &HC) + 8
            MasterDLCnt = CUInt(ReadInt16(DataBuffer, MasterDLStart - 6))
            MasterDLEnd = MasterDLStart + (MasterDLCnt * 8)
            baseoffset = ReadUInt32(DataBuffer, &H10) + &H18

            ModelContentTree.Nodes.Clear()
            ModelContentTree.Nodes.Add("Display Lists")
            ModelContentTree.Nodes.Add("Textures")

            Dim offincr As Integer = 0
            Dim TextureCount As Integer = 0
            Dim mtexsize As Integer = 0
            Dim tpos As Integer = 0
            Dim texloc As Integer = 0

            If Game = 1 Then
                tpos = &H58
                VTCount = ReadInt16(DataBuffer, &H46) - 1
                TextureCount = ReadInt16(DataBuffer, &H54)
                If TextureCount > 0 Then
                    mtexsize = ((ReadUInt24(DataBuffer, &H51) - (TextureCount * 8) - 8))
                    TexStart = tpos + (TextureCount * 8)
                    ReDim MTexBuffer(mtexsize - 1)
                    ReDim Textures(TextureCount - 1)
                    For i As Integer = 0 To TextureCount - 1
                        Textures(i) = New TexBuffer
                        Textures(i).offset = ReadUInt32(DataBuffer, tpos)
                        Textures(i).bpp = DataBuffer(tpos + 5)
                        Textures(i).width = DataBuffer(tpos + 6)
                        Textures(i).height = DataBuffer(tpos + 7)
                        Textures(i).size = (Textures(i).width * Textures(i).height)
                        ModelContentTree.Nodes(1).Nodes.Add("Texture 0x" & Textures(i).offset.ToString("X8"))
                        ModelContentTree.Nodes(1).Nodes(i).Nodes.Add("")
                        tpos += 8
                    Next
                End If
            Else
                tpos = &H40
                VTCount = ReadInt16(DataBuffer, &H32) - 1
                TextureCount = ReadInt16(DataBuffer, &H3C)
                If TextureCount > 0 Then
                    mtexsize = ReadUInt24(DataBuffer, &H39) - (TextureCount * 16) - 8
                    TexStart = tpos + (TextureCount * 16)
                    ReDim MTexBuffer(mtexsize - 1)
                    ReDim Textures(TextureCount - 1)
                    For i As Integer = 0 To TextureCount - 1
                        Textures(i) = New TexBuffer
                        Textures(i).offset = ReadUInt32(DataBuffer, tpos)
                        Textures(i).bpp = DataBuffer(tpos + 5)
                        Textures(i).width = DataBuffer(tpos + 8)
                        Textures(i).height = DataBuffer(tpos + 9)
                        Textures(i).size = (Textures(i).width * Textures(i).height)
                        ModelContentTree.Nodes(1).Nodes.Add("Texture 0x" & Textures(i).offset.ToString("X8"))
                        ModelContentTree.Nodes(1).Nodes(i).Nodes.Add("")
                        tpos += 16
                    Next
                End If
                End If

                If TexStart + mtexsize <= DataBuffer.Length Then
                    For i As Integer = 0 To mtexsize - 1
                        MTexBuffer(i) = DataBuffer(TexStart + i)
                    Next
                End If

                endoffset = baseoffset + (VTCount * 16)
                If endoffset = 0 Then
                    endoffset = DataBuffer.Length - &HC
                End If

                StoreMasterVertBuff(Vertices, DataBuffer, baseoffset, endoffset, VTCount)
                ProgressBar1.Value = 40

                StoreDisplayLists(DataBuffer, N64Dlist, MasterDLStart, MasterDLEnd)

                ProgressBar1.Value = 100

                ProgressBar1.Value = 0
        End If
    End Sub
    Private Sub MainLoop()
        GLInit()
        Do
            Application.DoEvents()
            DrawMain()
            SimpleOpenGlControl1.Invalidate()
        Loop
    End Sub
    Private Sub DrawMain()
        Gl.glClear(Gl.GL_COLOR_BUFFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT)
        Gl.glLoadIdentity()
        yrotad = ((yrot / 180) * 3.14159265)
        xrotad = ((xrot / 180) * 3.14159265)
        zrotad = ((zrot / 180) * 3.14159265)
        If key_w Then
            If xrot >= 85 Or xrot <= -85 Then
                finaly += Sin(xrotad) * run
            Else
                finalx -= Sin(yrotad) * run
                finalz += Cos(yrotad) * run
                finaly += Sin(xrotad) * run
            End If
        End If
        If key_s Then
            If xrot <= -85 Or xrot >= 85 Then
                finaly -= Sin(xrotad) * run
            Else
                finalx += Sin(yrotad) * run
                finalz -= Cos(yrotad) * run
                finaly -= Sin(xrotad) * run
            End If
        End If
        If key_d Then
            finalx -= Cos(yrotad) * run
            finalz -= Sin(yrotad) * run
        End If
        If key_a Then
            finalx += Cos(yrotad) * run
            finalz += Sin(yrotad) * run
        End If
        newx = MousePosition.X
        newy = MousePosition.Y
        If RotateSceneClick Then
            If oldx < newx Then
                '(MOUSE MOVE RIGHT)
                yrot += (newx - oldx) * 0.25
            End If
            If oldx > newx Then
                '(MOUSE MOVE LEFT)
                yrot -= (oldx - newx) * 0.25
            End If
            If oldy > newy Then
                '(MOUSE MOVE DOWN)
                If Not InvertY Then
                    If xrot <= -90 Then
                        xrot = -90
                    Else
                        xrot -= (oldy - newy) * 0.25
                    End If
                Else
                    If xrot >= 90 Then
                        xrot = 90
                    Else
                        xrot += (oldy - newy) * 0.25
                    End If
                End If
            End If
            If oldy < newy Then
                '(MOUSE MOVE UP)
                If Not InvertY Then
                    If xrot >= 90 Then
                        xrot = 90
                    Else
                        xrot += (newy - oldy) * 0.25
                    End If
                Else
                    If xrot <= -90 Then
                        xrot = -90
                    Else
                        xrot -= (newy - oldy) * 0.25
                    End If
                End If

            End If
        End If
        If gostrafe Then
            If oldy > newy Then
                '(MOUSE MOVE DOWN)
                finaly -= (oldy - newy) * 4
            End If
            If oldy < newy Then
                '(MOUSE MOVE UP)
                finaly += (newy - oldy) * 4
            End If
        End If
        oldx = MousePosition.X
        oldy = MousePosition.Y
        Gl.glPushMatrix()
        Gl.glRotatef(xrot, 1.0F, 0.0F, 0.0F)
        Gl.glRotatef(yrot, 0.0F, 1.0F, 0.0F)
        Gl.glRotatef(zrot, 0.0F, 0.0F, 1.0F)
        Gl.glTranslatef(finalx, finaly, finalz)

        If EnableAxisMarker Then
            Gl.glDisable(Gl.GL_TEXTURE_2D)
            Gl.glPushMatrix()
            Gl.glLineWidth(10)

            GLPrintDL(LineList, 0.1, 0.1, 0.1, 20, 0, 0, xrot, yrot, zrot)
            Gl.glLineWidth(1)
            Gl.glPopMatrix()
        End If

        If N64Dlist.Length > 0 Then
            DrawGraphics()
        End If

        Gl.glPopMatrix()
        SimpleOpenGlControl1.SwapBuffers()
    End Sub
    Private Sub DrawGraphics()
        Try
            For i As Integer = 0 To N64Dlist.Length - 1
                If Not N64Dlist(i).Skip Then
                    ParseDL(N64Dlist(i))
                End If
            Next
        Catch err As Exception
            MsgBox("DList draw function error! " & err.Message, MsgBoxStyle.Critical)
            Gl.glPopMatrix()
        End Try
    End Sub

    Private Sub ResizeScene()
        Dim ratio As Double = 1 * SimpleOpenGlControl1.Width / SimpleOpenGlControl1.Height
        Gl.glViewport(0, 0, SimpleOpenGlControl1.Width, SimpleOpenGlControl1.Height)
        Gl.glMatrixMode(Gl.GL_PROJECTION)
        Gl.glLoadIdentity()
        Glu.gluPerspective(60.0F, ratio, 1.0F, 999999.0F)
        Gl.glMatrixMode(Gl.GL_MODELVIEW)
        Gl.glLoadIdentity()
    End Sub

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ResizeScene()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Wgl.ReloadFunctions()
        Gl.ReloadFunctions()
        Il.ilInit()


        Game = ini.GetInteger("Settings", "Game", 0)

        run = CameraSensitivityScroll.Value * 2.4564568768678
        EnableTEX = True
        EnableCC = True
        If Gl.glGetString(Gl.GL_EXTENSIONS).Contains("GL_EXT_texture_filter_anisotropic") Then
            Gl.glGetFloatv(Gl.GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT, MaxAnisotropy)
        End If
        With TextureEd
            .texelsize = New ArrayList
            .Format = New ArrayList
            .RDRAMOffset = New ArrayList
            .Width = New ArrayList
            .Height = New ArrayList
            .SettileOff = New ArrayList
        End With
        With OBJData
            .v = New ArrayList
            .vt = New ArrayList
            .g = New ArrayList
        End With
        With extracted
            .r = New ArrayList
            .g = New ArrayList
            .b = New ArrayList
            .a = New ArrayList
        End With
        With VertCache
            ReDim .x(63)
            ReDim .y(63)
            ReDim .z(63)
            ReDim .u(63)
            ReDim .v(63)
            ReDim .r(63)
            ReDim .g(63)
            ReDim .b(63)
            ReDim .a(63)
        End With
        ReDim TextureCache(-1)

        BKModelDir = ini.GetString("Settings", "BKModelDirectory", Nothing)
        BTModelDir = ini.GetString("Settings", "BTModelDirectory", Nothing)
        If (BKModelDir = "" And BTModelDir = "") Then
            Dim startq As DialogResult = MsgBox("No model directory specified. Run quick start dialog?", MsgBoxStyle.YesNo, "First time?")
            If startq = Windows.Forms.DialogResult.Yes Then
                GettingStarted.ShowDialog()
            End If
        End If
        Select Case Game
            Case 0
                If BKModelDir <> "" Then PopulateFileTree(BKModelDir)
                Me.Text = "Bottles' Glasses 0.90 - " & BKModelDir
                BanjoKazooieToolStripMenuItem.Checked = True
                BanjoTooieToolStripMenuItem.Checked = False
            Case 1
                If BTModelDir <> "" Then PopulateFileTree(BTModelDir)
                Me.Text = "Bottles' Glasses 0.90 - " & BTModelDir
                BanjoKazooieToolStripMenuItem.Checked = False
                BanjoTooieToolStripMenuItem.Checked = True
        End Select
        Dim invystr As String = ini.GetString("Settings", "InvertYAxis", Nothing)
        If invystr <> "" Then InvertY = CBool(invystr)
        If InvertY Then InvertYAxisToolStripMenuItem.Checked = True Else InvertYAxisToolStripMenuItem.Checked = False
        Dim args() As String = Environment.GetCommandLineArgs
        If args.Length = 2 Then
            CurrModel = args(1)
            If CurrModel.Contains(".bkm") Then
                Game = 0
                SetGameUcode(0)
                BanjoKazooieToolStripMenuItem.Checked = True
                BanjoTooieToolStripMenuItem.Checked = False
                DonkeyKong64ToolStripMenuItem.Checked = False
                ini.WriteInteger("Settings", "Game", 0)
                If BKModelDir <> "" Then
                    PopulateFileTree(BKModelDir)
                End If
                GoTo beginparse
            ElseIf CurrModel.Contains(".btm") Then
                Game = 1
                SetGameUcode(1)
                BanjoKazooieToolStripMenuItem.Checked = True
                BanjoTooieToolStripMenuItem.Checked = False
                DonkeyKong64ToolStripMenuItem.Checked = False
                ini.WriteInteger("Settings", "Game", 1)
                If BTModelDir <> "" Then
                    PopulateFileTree(BTModelDir)
                End If
                GoTo beginparse
            Else
                SetGameUcode(Game)
                GoTo noparse
            End If
beginparse: ParseModel()
            Me.Text = "Bottles' Glasses 0.90 - " & NoExt(CurrModel) & " (" & CurrModel & ")"
noparse:
        End If
        SetGameUcode(Game)
        BuildAxisMarker()
        ResetView()
        Me.Show()
        Me.Focus()
        MainLoop()
    End Sub
    Private Sub ToggleWireFrame()
        If EnableWireFrame Then
            EnableWireFrame = False
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL)
            ToggleWireframeButton.Image = My.Resources.wireframeoff1
            ToggleWireframeButton.ToolTipText = "Wireframe OFF"
        Else
            EnableWireFrame = True
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE)
            ToggleWireframeButton.Image = My.Resources.wireframeon1
            ToggleWireframeButton.ToolTipText = "Wireframe ON"
        End If
    End Sub
    Private Sub simpleopenglcontrol1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SimpleOpenGlControl1.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                ToggleWireFrame()
            Case Keys.F2
                ToggleAxisMarker()
            Case Keys.F3
                ToggleTextures()
            Case Keys.W
                key_w = True
            Case Keys.D
                key_d = True
            Case Keys.A
                key_a = True
            Case Keys.S
                key_s = True
            Case Keys.ControlKey
                key_ctrl = True
            Case Keys.R
                ResetView()
        End Select
    End Sub

    Private Sub simpleopenglcontrol1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SimpleOpenGlControl1.KeyUp
        Select Case e.KeyCode
            Case Keys.W
                key_w = False
            Case Keys.D
                key_d = False
            Case Keys.A
                key_a = False
            Case Keys.S
                key_s = False
            Case Keys.ControlKey
                key_ctrl = False
        End Select
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SimpleOpenGlControl1.Dispose()
        End
    End Sub

    Private Sub Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SimpleOpenGlControl1.Dispose()
        End
    End Sub

    Private Sub MPixelRead(ByVal r As Byte, ByVal g As Byte, ByVal b As Byte)
        Gl.glPushMatrix()
        Gl.glRotatef(xrot, 1.0F, 0.0F, 0.0F)
        Gl.glRotatef(yrot, 0.0F, 1.0F, 0.0F)
        Gl.glRotatef(zrot, 0.0F, 0.0F, 1.0F)
        Gl.glTranslatef(finalx, finaly, finalz)
        DrawGraphics()
        Gl.glPopMatrix()
        Dim viewport(3) As Integer
        Gl.glGetIntegerv(Gl.GL_VIEWPORT, viewport)
        Dim LocalMouse As Point = SimpleOpenGlControl1.PointToClient(Windows.Forms.Cursor.Position)
        Gl.glReadPixels(LocalMouse.X, viewport(3) - LocalMouse.Y, 1, 2, Gl.GL_RGB, Gl.GL_UNSIGNED_BYTE, pixel)

        'If pixel(0) = r And pixel(1) = g And pixel(2) = b Then
        '    MsgBox("hit at " & c.ToString)

        'End If

    End Sub
    Private Sub ScrollSensitivity(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SimpleOpenGlControl1.MouseWheel
        If e.Delta < 0 Then
            If CameraSensitivityScroll.Value > CameraSensitivityScroll.Minimum Then
                CameraSensitivityScroll.Value -= 1
            Else
                CameraSensitivityScroll.Value = CameraSensitivityScroll.Minimum
            End If
        Else
            If CameraSensitivityScroll.Value < CameraSensitivityScroll.Maximum Then
                CameraSensitivityScroll.Value += 1
            Else
                CameraSensitivityScroll.Value = CameraSensitivityScroll.Maximum
            End If
        End If
        If CameraSensitivityScroll.Value = CameraSensitivityScroll.Minimum Then
            run = 0
        Else
            run = CameraSensitivityScroll.Value * 2.4564568768678
        End If
    End Sub
    Private Sub SimpleOpenGlControl1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SimpleOpenGlControl1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            RotateSceneClick = True
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            gostrafe = True
        End If
    End Sub

    Private Sub SimpleOpenGlControl1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SimpleOpenGlControl1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            SimpleOpenGlControl1.Cursor = Cursors.Arrow
            RotateSceneClick = False
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            gostrafe = False
        End If
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CameraSensitivityScroll.Scroll, CameraSensitivityScroll.Scroll
        If key_w Then
            key_w = False
        End If
        If key_d Then
            key_d = False
        End If
        If key_a Then
            key_a = False
        End If
        If key_s Then
            key_s = False
        End If
        If key_ctrl Then
            key_ctrl = False
        End If
        run = CameraSensitivityScroll.Value * 2.4564568768678
    End Sub

    Private Sub ResetView()
        xrot = 0
        yrot = 0
        zrot = 0
        finalx = 0
        finaly = -200
        finalz = -1400
    End Sub

    Public Sub IsolateFiles(ByVal game As Integer) '0 = banjo kazooie, 1 = Banjo Tooie
        Try
            Select Case game
                Case 0
                    InputFolderBrowser.Description = "Please select the folder containing extracted Banjo Kazooie data."
                    OutputFolderBrowser.Description = "Please select the folder you would like to isolate Banjo Kazooie models to."
                Case 1
                    InputFolderBrowser.Description = "Please select the folder containing extracted Banjo Tooie data."
                    OutputFolderBrowser.Description = "Please select the folder you would like to isolate  Banjo Tooie models to."
                Case 2
                    InputFolderBrowser.Description = "Please select the folder containing extracted Donkey Kong 64 data."
                    OutputFolderBrowser.Description = "Please select the folder you would like to isolate Donkey Kong 64 models to."
            End Select
            If InputFolderBrowser.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                InputFolderBrowser.Dispose()
            Else
                If OutputFolderBrowser.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                    OutputFolderBrowser.Dispose()
                Else
                    Dim delete As Boolean = False
                    If MsgBox("Delete old files after copy?", MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                        delete = True
                    End If
                    Dim files() As String
                    Dim dirtouse As String = InputFolderBrowser.SelectedPath & "\"
                    Dim dirtouse1 As String = OutputFolderBrowser.SelectedPath & "\"
                    Dim ext As String = ""
                    Dim gamename As String = ""
                    files = Directory.GetFiles(dirtouse)
                    Directory.CreateDirectory(dirtouse1)
                    Dim file1 As FileStream
                    Dim tbyte(3) As Byte
                    Select Case game
                        Case 0
                            ext = ".bkm"
                            gamename = "Banjo-Kazooie"
                        Case 1
                            ext = ".btm"
                            gamename = "Banjo-Tooie"
                        Case 2
                            ext = ".dkm"
                            gamename = "Donkey Kong 64"
                    End Select
                    For i As Integer = 0 To files.Length - 1
                        If Not files(i).Contains(".txt") Then
                            file1 = New FileStream(files(i), FileMode.Open)
                            tbyte(0) = file1.ReadByte
                            tbyte(1) = file1.ReadByte
                            tbyte(2) = file1.ReadByte
                            tbyte(3) = file1.ReadByte
                            file1.Dispose()
                            If tbyte(3) = &HB Then
                                If tbyte(0) = 0 And tbyte(1) = 0 And tbyte(2) = 0 Then
                                    File.Copy(files(i), dirtouse1 & NoExt(GetFileName(files(i))) & ext, True)
                                    If delete Then File.Delete(files(i))
                                End If
                            End If
                        End If
                    Next
                    Dim q1 As DialogResult = MsgBox(gamename & " model files isolated to " & dirtouse1 & " successfully. Would you like to set this as your " & gamename & " model directory now?", MsgBoxStyle.YesNo, "No problems encountered")
                    If q1 = Windows.Forms.DialogResult.Yes Then
                        Select Case game
                            Case 0
                                BKModelDir = OutputFolderBrowser.SelectedPath
                                PopulateFileTree(BKModelDir)
                                ini.WriteString("Settings", "BKModelDirectory", BKModelDir)
                            Case 1
                                BTModelDir = OutputFolderBrowser.SelectedPath
                                PopulateFileTree(BTModelDir)
                                ini.WriteString("Settings", "BTModelDirectory", BTModelDir)
                            Case 2
                                DKModelDir = OutputFolderBrowser.SelectedPath
                                PopulateFileTree(DKModelDir)
                                ini.WriteString("Settings", "DKModelDirectory", DKModelDir)
                        End Select
                    End If
                End If
            End If
        Catch err As Exception
            MsgBox("Could not isolate files!" & Environment.NewLine & Environment.NewLine & "DEBUG: " & err.Message)
            GC.Collect()
        End Try
    End Sub
    Private Sub ToggleAxisMarker()
        If EnableAxisMarker Then
            EnableAxisMarker = False
            AxisMarkerToggle.Image = My.Resources.axisoff
            AxisMarkerToggle.ToolTipText = "Axis Marker OFF"
        Else
            EnableAxisMarker = True
            AxisMarkerToggle.Image = My.Resources.axison
            AxisMarkerToggle.ToolTipText = "Axis Marker ON"
        End If
    End Sub
    Private Sub AxisMarkerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToggleAxisMarker()
    End Sub

    Private Sub RAREDecompressorSubDragRWPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RAREDecompressorSubDragRWPToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\misc\GEDecompressor.exe")
        Catch err As Exception
            MsgBox("Couldn't find 'GEDecompressor.exe' in 'misc'!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BanjoKazooieToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IsolateFiles(0)
    End Sub

    Private Sub DonkeyKong64ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IsolateFiles(1)
    End Sub

    Private Sub QuitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    Public Sub PopulateFileTree(ByVal dir As String)
        FileTree.Nodes.Clear()
        Dim modelstr As String = ""
        Dim filetest As Byte = 0
        Dim filetestrd As FileStream
        If Directory.Exists(dir) Then
            ModelFiles = Directory.GetFiles(dir)
            For i = 0 To ModelFiles.Length - 1
                If verifyFiles Then
                    filetestrd = New FileStream(ModelFiles(i), FileMode.Open)
                    filetestrd.Position = 3
                    filetest = filetestrd.ReadByte
                    filetestrd.Dispose()
                Else
                    GoTo verified
                End If
                If filetest = &HB Then
verified:           Select Case Game
                        Case 0
                            modelstr = BKmodelini.GetString("models", NoExt(ModelFiles(i)), Nothing)
                        Case 1
                            modelstr = BTmodelini.GetString("models", NoExt(ModelFiles(i)), Nothing)
                    End Select
                    If modelstr <> "" Then FileTree.Nodes.Add(modelstr) Else FileTree.Nodes.Add(GetFileName(ModelFiles(i)))
                End If
            Next
            If FileTree.Nodes.Count = 0 Then
                FileTree.Nodes.Add("No models found in " & dir & "!")
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Select Case Game
            Case 0
                Process.Start(BKModelDir)
            Case 1
                Process.Start(BTModelDir)
        End Select
    End Sub

    Private Sub ObjectIsolatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObjectIsolatorToolStripMenuItem.Click
        IsolateFiles(Game)
    End Sub

    Private Sub ExportWavefrontModelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportWavefrontModelToolStripMenuItem.Click
        If N64Dlist.Length > 0 Then
            SaveOBJ.FileName = NoExt(GetFileName(CurrModel)) & ".obj"
            If SaveOBJ.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                SaveOBJ.Dispose()
            End If
        End If
    End Sub
    Private Sub SaveOBJ_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveOBJ.FileOk
        subdir = Path.GetDirectoryName(SaveOBJ.FileName) & "\" & NoExt(SaveOBJ.FileName) & "\"
        If Directory.Exists(subdir) Then
            Dim q As MsgBoxResult = MsgBox("Model already exists in this path! Overwrite?", MsgBoxStyle.YesNo, "Overwrite")
            If q = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        Directory.CreateDirectory(subdir)
        objstr = File.Create(subdir & GetFileName(SaveOBJ.FileName))
        objfile = New StreamWriter(objstr)
        mtlstr = File.Create(subdir & NoExt(SaveOBJ.FileName) & ".mtl")
        mtlfile = New StreamWriter(mtlstr)
        OBJMode = True
        objfile.WriteLine("#" & GetFileName(SaveOBJ.FileName) & " - exported from Banjo-Kazooie/Tooie using Bottles' Glasses 0.80")
        objfile.WriteLine("#" & Vertices.x.Length & " Vertices and texture coords")
        objfile.WriteLine("mtllib " & NoExt(GetFileName(SaveOBJ.FileName)) & ".mtl")
        For i As Integer = 0 To Vertices.x.Length - 1
            OBJData.v.Add("v " & Vertices.x(i).ToString & " " & Vertices.y(i).ToString & " " & Vertices.z(i).ToString)
        Next
        For i As Integer = 0 To Vertices.x.Length - 1
            OBJData.vt.Add("vt " & Vertices.u(i).ToString & " " & Vertices.v(i).ToString)
        Next
        For i As Integer = 0 To Vertices.x.Length - 1
            OBJData.vt.Add("vc " & Vertices.r(i).ToString & " " & Vertices.g(i).ToString & " " & Vertices.b(i).ToString & " " & Vertices.a(i).ToString)
        Next

        For i = 0 To N64Dlist.Length - 1
            If Not N64Dlist(i).Skip Then
                ParseDL(N64Dlist(i))
            End If
        Next

        For i = 0 To OBJData.v.Count - 1
            objfile.WriteLine(CStr(OBJData.v(i)))
        Next
        For i = 0 To OBJData.vt.Count - 1
            objfile.WriteLine(CStr(OBJData.vt(i)))
        Next
        For i = 0 To OBJData.g.Count - 1
            objfile.WriteLine(CStr(OBJData.g(i)))
        Next
        With OBJData
            .v.Clear()
            .vt.Clear()
            .g.Clear()
        End With
        OBJMode = False
        OBJTextures.Clear()
        objfile.Dispose()
        objstr.Dispose()
        mtlfile.Dispose()
        mtlstr.Dispose()
    End Sub

    Private Sub OpenTexture_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenTexture.FileOk
        If Il.ilLoadImage(OpenTexture.FileName) Then

        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If OpenTexture.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            OpenTexture.Dispose()
        End If
    End Sub
    Private Sub SetGameUcode(ByVal gameNo As Integer)
        Select Case gameNo
            Case 0 'Banjo-Kazooie
                Game = 0
                GameStatus.Text = "Game: Banjo-Kazooie"
                F3DEX_DL = &H6
                F3DEX_POPMTX = &HBD
                F3DEX_TEXTURE = &HBB
                F3DEX_SETOTHERMODE_H = &HBA
                F3DEX_SETOTHERMODE_L = &HB9
                F3DEX_MTX = &H1
                F3DEX_SETGEOMETRYMODE = &HB7
                F3DEX_CLEARGEOMETRYMODE = &HB6
                F3DEX_ENDDL = &HB8
                F3DEX_VTX = &H4
                F3DEX_MODIFYVTX = &HB2
                F3DEX_TRI1 = &HBF
                F3DEX_TRI2 = &HB1
            Case 1 'Banjo-Tooie
                Game = 1
                GameStatus.Text = "Game: Banjo-Tooie/DK64"
                F3DEX_DL = &HDE
                F3DEX_TEXTURE = &HD7
                F3DEX_POPMTX = &HD8
                F3DEX_MTX = &H3
                F3DEX_SETOTHERMODE_H = &HE3
                F3DEX_SETOTHERMODE_L = &HE2
                F3DEX_SETGEOMETRYMODE = &HD9
                F3DEX_CLEARGEOMETRYMODE = 0
                F3DEX_ENDDL = &HDF
                F3DEX_VTX = &H1
                F3DEX_MODIFYVTX = &H2
                F3DEX_TRI1 = &H5
                F3DEX_TRI2 = &H6
        End Select
    End Sub

    Private Sub BanjoKazooieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanjoKazooieToolStripMenuItem.Click
        Game = 0
        SetGameUcode(0)
        BanjoKazooieToolStripMenuItem.Checked = True
        BanjoTooieToolStripMenuItem.Checked = False
        DonkeyKong64ToolStripMenuItem.Checked = False
        ini.WriteInteger("Settings", "Game", Game)
        If BKModelDir <> "" Then
            PopulateFileTree(BKModelDir)
        End If
    End Sub

    Private Sub BanjoTooieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanjoTooieToolStripMenuItem.Click
        Game = 1
        SetGameUcode(1)
        BanjoKazooieToolStripMenuItem.Checked = False
        BanjoTooieToolStripMenuItem.Checked = True
        DonkeyKong64ToolStripMenuItem.Checked = False
        ini.WriteInteger("Settings", "Game", Game)
        If BTModelDir <> "" Then
            PopulateFileTree(BTModelDir)
        End If
    End Sub

    Private Sub BanjoKazooieToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanjoKazooieToolStripMenuItem1.Click
        ModelFolderDialog.Description = "Please point to the directory which contains your Banjo-Kazooie models (*.bkm)."
        If ModelFolderDialog.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            ModelFolderDialog.Dispose()
        Else
            BKModelDir = ModelFolderDialog.SelectedPath
            Me.Text = "Bottles' Glasses 0.80 - " & BKModelDir
            ini.WriteString("Settings", "BKModelDirectory", BKModelDir)
            If Game = 0 Then
                PopulateFileTree(BKModelDir)
            End If
        End If
    End Sub

    Private Sub BanjoTooieToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanjoTooieToolStripMenuItem1.Click
        ModelFolderDialog.Description = "Please point to the directory which contains your Banjo-Tooie models (*.btm)."
        If ModelFolderDialog.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            ModelFolderDialog.Dispose()
        Else
            BTModelDir = ModelFolderDialog.SelectedPath
            Me.Text = "Bottles' Glasses 0.80 - " & BTModelDir
            ini.WriteString("Settings", "BTModelDirectory", BTModelDir)
            If Game = 1 Then
                PopulateFileTree(BTModelDir)
            End If
        End If
    End Sub

    Private Sub GameStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameStatus.Click
        Select Case Game
            Case 0
                Game = 1
                SetGameUcode(1)
                BanjoKazooieToolStripMenuItem.Checked = False
                BanjoTooieToolStripMenuItem.Checked = True
                ini.WriteInteger("Settings", "Game", 1)
                If BTModelDir <> "" Then
                    PopulateFileTree(BTModelDir)
                End If
            Case 1
                Game = 0
                SetGameUcode(0)
                BanjoKazooieToolStripMenuItem.Checked = True
                BanjoTooieToolStripMenuItem.Checked = False
                ini.WriteInteger("Settings", "Game", 0)
                If BKModelDir <> "" Then
                    PopulateFileTree(BKModelDir)
                End If
        End Select
    End Sub

    Private Sub FileTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles FileTree.AfterSelect
        If TreeView1.SelectedNodes.Count > 0 Then
            If TreeView1.SelectedNodes(0).Text <> FileTree.SelectedNodes(0).Text Then TreeView1.SelectedNodes.Clear()
        End If
        If ModelFiles.Length > 0 Then
            CurrModel = ModelFiles(e.Node.Index)
            Me.Text = "Bottles' Glasses 0.80 - " & e.Node.Text & " (" & CurrModel & ")"
            ParseModel()
            ResetView()
        End If
    End Sub


    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        ResetView()
    End Sub

    Private Sub InvertYAxisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvertYAxisToolStripMenuItem.Click
        If InvertY Then InvertY = False Else InvertY = True
        ini.WriteBoolean("Settings", "InvertYAxis", InvertY)
    End Sub

    Private Sub CaptureScreenshotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureScreenshotToolStripMenuItem.Click
        If CurrModel <> "" Then
            SaveScreenPNG.InitialDirectory = Application.StartupPath
            SaveScreenPNG.FileName = NoExt(CurrModel) & "_screen_" & Date.Now.ToShortTimeString.Replace(":", "").Replace(" ", "")
            SaveScreenPNG.ShowDialog()
        End If
    End Sub
    Private Sub SaveScreenData(ByVal vp() As Integer, ByVal filename As String, ByVal format As Imaging.ImageFormat)
        Dim b As Bitmap
        Dim bd As Imaging.BitmapData
        Dim rect0 As Rectangle
        Gl.glGetIntegerv(Gl.GL_VIEWPORT, vp)
        rect0 = New Rectangle(0, 0, vp(2), vp(3))
        b = New Bitmap(vp(2), vp(3), Imaging.PixelFormat.Format32bppArgb)
        bd = b.LockBits(rect0, Imaging.ImageLockMode.WriteOnly, Imaging.PixelFormat.Format32bppArgb)
        Gl.glReadPixels(0, 0, vp(2), vp(3), Gl.GL_BGRA, Gl.GL_UNSIGNED_BYTE, bd.Scan0)
        b.UnlockBits(bd)
        b.RotateFlip(RotateFlipType.RotateNoneFlipY)
        b.Save(filename, format)
    End Sub
    Private Sub SaveScreenBMP_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveScreenPNG.FileOk, SaveScreenPNG.FileOk
        Dim tvp(3) As Integer
        Gl.glGetIntegerv(Gl.GL_VIEWPORT, tvp)
        SaveScreenData(tvp, SaveScreenPNG.FileName, Imaging.ImageFormat.Png)
    End Sub

    Private Sub RenameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        RenameFileDescription.ShowDialog()
    End Sub
    Sub ToggleTextures()
        If EnableTEX Then
            EnableTEX = False
            ToggleTextureButton.Image = My.Resources.texturesoff
            ToggleTextureButton.ToolTipText = "Textures OFF"
        Else
            EnableTEX = True
            ToggleTextureButton.Image = My.Resources.textureson
            ToggleTextureButton.ToolTipText = "Textures ON"
        End If
    End Sub

    Private Sub WireframeCheck_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ToggleWireFrame()
    End Sub

    Private Sub AxisCheck_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ToggleAxisMarker()
    End Sub


    Private Sub FileTree_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileTree.DoubleClick
        If FileTree.SelectedNodes(0).Index > -1 Then
            RenameFileDescription.ShowDialog()
        End If
    End Sub
    Private Sub SearchTreeView()
        Dim found As Integer = 0
        TreeView1.Nodes.Clear()
        SearchFound.Clear()
        For i = 0 To FileTree.Nodes.Count - 1
            If FileTree.Nodes(i).Text.ToLower.Contains(TextBox1.Text.ToLower) Then
                TreeView1.Nodes.Add(FileTree.Nodes(i).Text)
                SearchFound.Add(i)
                found += 1
            End If
        Next
        Label5.Text = found.ToString & " matches found"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SearchTreeView()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then SearchTreeView()
    End Sub

    Private Sub AxisCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToggleAxisMarker()
    End Sub

    Private Sub WireframeCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToggleWireFrame()
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim mainind As Integer = CInt(SearchFound(e.Node.Index))
        CurrModel = ModelFiles(mainind)
        FileTree.SelectedNodes.Clear()
        FileTree.TopNode = FileTree.Nodes(mainind)
        FileTree.SelectedNodes.Add(FileTree.Nodes(mainind))
    End Sub
    Private Sub TreeView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        If FileTree.SelectedNodes(0).Index > -1 Then
            RenameFileDescription.ShowDialog()
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If verifyFiles Then verifyFiles = False Else verifyFiles = True
    End Sub

    Private Sub DonkeyKong64ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonkeyKong64ToolStripMenuItem.Click
        Game = 2
        SetGameUcode(1)
        BanjoKazooieToolStripMenuItem.Checked = False
        BanjoTooieToolStripMenuItem.Checked = False
        DonkeyKong64ToolStripMenuItem.Checked = True
        ini.WriteInteger("Settings", "Game", Game)
        If BTModelDir <> "" Then
            PopulateFileTree(BTModelDir)
        End If
    End Sub

    Private Sub Rotate90Left_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rotate90Left.Click
        rottype = 0
        RotateTimer.Start()
    End Sub
    Private Sub Rotate90Right_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rotate90Right.Click
        rottype = 1
        RotateTimer.Start()
    End Sub

    Private Sub Rotate90Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rotate90Up.Click
        rottype = 2
        RotateTimer.Start()
    End Sub

    Private Sub Rotate90Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rotate90Down.Click
        rottype = 3
        RotateTimer.Start()
    End Sub
    Private Sub RotateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateTimer.Tick
        rotcoef -= 15
        If rotcoef = 0 Then
            rotcoef = 90
            RotateTimer.Stop()
        End If
        For i As Integer = 0 To N64Dlist.Length - 1
            If Not N64Dlist(i).Skip Then
                Select Case rottype
                    Case 0
                        N64Dlist(i).DrawPosition.YRot -= 15
                    Case 1
                        N64Dlist(i).DrawPosition.YRot += 15
                    Case 2
                        N64Dlist(i).DrawPosition.XRot -= 15
                    Case 3
                        N64Dlist(i).DrawPosition.XRot += 15
                End Select
            End If
        Next
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToggleTextureButton.Click
        ToggleTextures()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxisMarkerToggle.Click
        ToggleAxisMarker()
    End Sub

    Private Sub ToolStripButton1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToggleWireframeButton.Click
        ToggleWireFrame()
    End Sub
    Private Sub SimpleOpenGlControl1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SimpleOpenGlControl1.DragDrop
        Dim tmp() As String
        tmp = e.Data.GetData(DataFormats.FileDrop)
        CurrModel = tmp(0)
        If CurrModel.Contains(".bkm") Then
            Game = 0
            SetGameUcode(0)
            BanjoKazooieToolStripMenuItem.Checked = True
            BanjoTooieToolStripMenuItem.Checked = False
            DonkeyKong64ToolStripMenuItem.Checked = False
            ini.WriteInteger("Settings", "Game", 0)
            If BKModelDir <> "" Then
                PopulateFileTree(BKModelDir)
            End If
            GoTo parse
        ElseIf CurrModel.Contains(".btm") Then
            Game = 1
            SetGameUcode(1)
            BanjoKazooieToolStripMenuItem.Checked = True
            BanjoTooieToolStripMenuItem.Checked = False
            DonkeyKong64ToolStripMenuItem.Checked = False
            ini.WriteInteger("Settings", "Game", 1)
            If BTModelDir <> "" Then
                PopulateFileTree(BTModelDir)
            End If
            GoTo parse
        Else
            GoTo noparse
        End If
parse:
        ParseModel()
        Me.Text = "Bottles' Glasses 0.80 - " & NoExt(CurrModel) & " (" & CurrModel & ")"
noparse:
        ResetView()
    End Sub

    Private Sub SimpleOpenGlControl1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SimpleOpenGlControl1.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub AssociateFilesWithWindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssociateFilesWithWindowsToolStripMenuItem.Click
        My.Computer.Registry.ClassesRoot.CreateSubKey(".bkm").SetValue("", "Banjo Kazooie Model files", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.ClassesRoot.CreateSubKey("Banjo Kazooie Model files\shell\open\command").SetValue("", Application.ExecutablePath & " ""%l"" ", Microsoft.Win32.RegistryValueKind.String)

        My.Computer.Registry.ClassesRoot.CreateSubKey(".btm").SetValue("", "Banjo Tooie Model files", Microsoft.Win32.RegistryValueKind.String)
        My.Computer.Registry.ClassesRoot.CreateSubKey("Banjo Tooie Model files\shell\open\command").SetValue("", Application.ExecutablePath & " ""%l"" ", Microsoft.Win32.RegistryValueKind.String)

        MsgBox("Banjo Kazooie and Banjo Tooie models are now associated with Bottles' Glasses. You can double click them in Windows to load them.", MsgBoxStyle.OkOnly, "Shell association successful")
    End Sub
    Private Function OBJToF3DEX(ByVal fn As String) As DisplayList
        Dim tempDL As New DisplayList
        Dim curCmdCode As Byte = 0

        Dim cmdCnt As Integer = 0
        Dim objFile As StreamReader = New StreamReader(fn)
        Dim curLine As String = ""
        Dim curLineDelim() As String
        While objFile.Peek <> -1
            curLine = objFile.ReadLine
            curLineDelim = curLine.Split(" ")
            Select Case curLineDelim(0)
                Case "v"

                Case "g"
                    tempDL.Commands(cmdCnt).CMDDword(0) = &H4
                Case "f"
                    tempDL.Commands(cmdCnt).CMDDword(0) = &HBF
            End Select
        End While
        Return tempDL
    End Function
#End Region 'Application level code


    Private Sub CheckedListBox1_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)

    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    For i As Integer = 0 To CheckedListBox1.Items.Count - 1
    '        CheckedListBox1.SetItemCheckState(i, CheckState.Checked)
    '    Next
    'End Sub

    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    If CInt(CheckedListBox1.SelectedIndex) > -1 Then
    '        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
    '            If i <> CheckedListBox1.SelectedIndex Then
    '                CheckedListBox1.SetItemCheckState(i, CheckState.Checked)
    '            Else
    '                CheckedListBox1.SetItemCheckState(i, CheckState.Unchecked)
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    If CInt(CheckedListBox1.SelectedIndex) > -1 Then
    '        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
    '            If i <> CheckedListBox1.SelectedIndex Then
    '                CheckedListBox1.SetItemCheckState(i, CheckState.Unchecked)
    '            Else
    '                CheckedListBox1.SetItemCheckState(i, CheckState.Checked)
    '            End If
    '        Next
    '    End If
    'End Sub
    Private Sub ModelContentTree_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles ModelContentTree.AfterCheck
        If e.Node.Parent.Index <> Nothing Then
            Select Case e.Node.Parent.Index
                Case 0
                    If CInt(e.Node.Index) < N64Dlist.Length Then
                        N64Dlist(e.Node.Index).Skip = ModelContentTree.Nodes(0).Nodes(e.Node.Index).Checked = False
                    End If
                Case 1

            End Select
            If e.Node.Parent.Index = 0 Then

            ElseIf e.Node.Parent.Index = 1 Then

            End If
        End If
    End Sub
End Class