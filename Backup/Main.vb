Imports Tao.opengl
Imports Tao.devil
Imports Tao.Platform.windows
Imports Tao.freeglut
Imports System.IO
Imports System.math
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadGraphicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BanjoKazooieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DonkeyKong64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CombineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WireframeHighlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AxisMarkerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackfaceCullingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ObjectIsolatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BanjoKazooieToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DonkeyKong64ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MouseToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RotatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CameraOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RAREDecompressorSubDragRWPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutBottlesGlassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.Label1 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label2 = New System.Windows.Forms.Label
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.SimpleOpenGlControl1 = New Tao.Platform.Windows.SimpleOpenGlControl
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 21)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadGraphicsToolStripMenuItem, Me.CombineToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 17)
        Me.FileToolStripMenuItem.Text = "File"
        Me.FileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'LoadGraphicsToolStripMenuItem
        '
        Me.LoadGraphicsToolStripMenuItem.AutoSize = False
        Me.LoadGraphicsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BanjoKazooieToolStripMenuItem, Me.DonkeyKong64ToolStripMenuItem})
        Me.LoadGraphicsToolStripMenuItem.Image = Global.BK_Viewer.My.Resources.Resources.pluma_roja
        Me.LoadGraphicsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.LoadGraphicsToolStripMenuItem.Name = "LoadGraphicsToolStripMenuItem"
        Me.LoadGraphicsToolStripMenuItem.Size = New System.Drawing.Size(152, 20)
        Me.LoadGraphicsToolStripMenuItem.Text = "Load Graphics"
        '
        'BanjoKazooieToolStripMenuItem
        '
        Me.BanjoKazooieToolStripMenuItem.AutoSize = False
        Me.BanjoKazooieToolStripMenuItem.Name = "BanjoKazooieToolStripMenuItem"
        Me.BanjoKazooieToolStripMenuItem.Size = New System.Drawing.Size(163, 20)
        Me.BanjoKazooieToolStripMenuItem.Text = "Banjo Kazooie"
        '
        'DonkeyKong64ToolStripMenuItem
        '
        Me.DonkeyKong64ToolStripMenuItem.AutoSize = False
        Me.DonkeyKong64ToolStripMenuItem.Name = "DonkeyKong64ToolStripMenuItem"
        Me.DonkeyKong64ToolStripMenuItem.Size = New System.Drawing.Size(163, 20)
        Me.DonkeyKong64ToolStripMenuItem.Text = "Donkey Kong 64"
        '
        'CombineToolStripMenuItem
        '
        Me.CombineToolStripMenuItem.Name = "CombineToolStripMenuItem"
        Me.CombineToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CombineToolStripMenuItem.Text = "Combine"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.AutoSize = False
        Me.QuitToolStripMenuItem.Image = Global.BK_Viewer.My.Resources.Resources.grun_s2
        Me.QuitToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(152, 20)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WireframeHighlightToolStripMenuItem, Me.AxisMarkerToolStripMenuItem, Me.BackfaceCullingToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 17)
        Me.OptionsToolStripMenuItem.Text = "Options"
        Me.OptionsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'WireframeHighlightToolStripMenuItem
        '
        Me.WireframeHighlightToolStripMenuItem.AutoSize = False
        Me.WireframeHighlightToolStripMenuItem.Name = "WireframeHighlightToolStripMenuItem"
        Me.WireframeHighlightToolStripMenuItem.Size = New System.Drawing.Size(179, 20)
        Me.WireframeHighlightToolStripMenuItem.Text = "Wireframe Highlight"
        '
        'AxisMarkerToolStripMenuItem
        '
        Me.AxisMarkerToolStripMenuItem.AutoSize = False
        Me.AxisMarkerToolStripMenuItem.Name = "AxisMarkerToolStripMenuItem"
        Me.AxisMarkerToolStripMenuItem.Size = New System.Drawing.Size(179, 20)
        Me.AxisMarkerToolStripMenuItem.Text = "Axis Marker"
        '
        'BackfaceCullingToolStripMenuItem
        '
        Me.BackfaceCullingToolStripMenuItem.Name = "BackfaceCullingToolStripMenuItem"
        Me.BackfaceCullingToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.BackfaceCullingToolStripMenuItem.Text = "Backface Culling"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObjectIsolatorToolStripMenuItem, Me.MouseToolToolStripMenuItem, Me.RAREDecompressorSubDragRWPToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 17)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ObjectIsolatorToolStripMenuItem
        '
        Me.ObjectIsolatorToolStripMenuItem.AutoSize = False
        Me.ObjectIsolatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BanjoKazooieToolStripMenuItem1, Me.DonkeyKong64ToolStripMenuItem1})
        Me.ObjectIsolatorToolStripMenuItem.Name = "ObjectIsolatorToolStripMenuItem"
        Me.ObjectIsolatorToolStripMenuItem.Size = New System.Drawing.Size(262, 20)
        Me.ObjectIsolatorToolStripMenuItem.Text = "Model Isolator"
        '
        'BanjoKazooieToolStripMenuItem1
        '
        Me.BanjoKazooieToolStripMenuItem1.AutoSize = False
        Me.BanjoKazooieToolStripMenuItem1.Name = "BanjoKazooieToolStripMenuItem1"
        Me.BanjoKazooieToolStripMenuItem1.Size = New System.Drawing.Size(163, 20)
        Me.BanjoKazooieToolStripMenuItem1.Text = "Banjo Kazooie"
        '
        'DonkeyKong64ToolStripMenuItem1
        '
        Me.DonkeyKong64ToolStripMenuItem1.AutoSize = False
        Me.DonkeyKong64ToolStripMenuItem1.Name = "DonkeyKong64ToolStripMenuItem1"
        Me.DonkeyKong64ToolStripMenuItem1.Size = New System.Drawing.Size(163, 20)
        Me.DonkeyKong64ToolStripMenuItem1.Text = "Donkey Kong 64"
        '
        'MouseToolToolStripMenuItem
        '
        Me.MouseToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RotatorToolStripMenuItem, Me.CameraOnlyToolStripMenuItem})
        Me.MouseToolToolStripMenuItem.Name = "MouseToolToolStripMenuItem"
        Me.MouseToolToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.MouseToolToolStripMenuItem.Text = "Mouse Tool"
        '
        'RotatorToolStripMenuItem
        '
        Me.RotatorToolStripMenuItem.AutoSize = False
        Me.RotatorToolStripMenuItem.Name = "RotatorToolStripMenuItem"
        Me.RotatorToolStripMenuItem.Size = New System.Drawing.Size(152, 20)
        Me.RotatorToolStripMenuItem.Text = "Rotator"
        '
        'CameraOnlyToolStripMenuItem
        '
        Me.CameraOnlyToolStripMenuItem.AutoSize = False
        Me.CameraOnlyToolStripMenuItem.Name = "CameraOnlyToolStripMenuItem"
        Me.CameraOnlyToolStripMenuItem.Size = New System.Drawing.Size(152, 20)
        Me.CameraOnlyToolStripMenuItem.Text = "Camera Only"
        '
        'RAREDecompressorSubDragRWPToolStripMenuItem
        '
        Me.RAREDecompressorSubDragRWPToolStripMenuItem.AutoSize = False
        Me.RAREDecompressorSubDragRWPToolStripMenuItem.Name = "RAREDecompressorSubDragRWPToolStripMenuItem"
        Me.RAREDecompressorSubDragRWPToolStripMenuItem.Size = New System.Drawing.Size(262, 20)
        Me.RAREDecompressorSubDragRWPToolStripMenuItem.Text = "RARE Decompressor (SubDrag/RWP)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutBottlesGlassesToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 17)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutBottlesGlassesToolStripMenuItem
        '
        Me.AboutBottlesGlassesToolStripMenuItem.AutoSize = False
        Me.AboutBottlesGlassesToolStripMenuItem.Name = "AboutBottlesGlassesToolStripMenuItem"
        Me.AboutBottlesGlassesToolStripMenuItem.Size = New System.Drawing.Size(191, 20)
        Me.AboutBottlesGlassesToolStripMenuItem.Text = "About Bottles' Glasses"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "B-K Models (*.bkm)|*.bkm"
        Me.OpenFileDialog1.Title = "Load Banjo-Kazooie Model"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 551)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(577, 556)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Camera Speed:"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the folder that holds decompressed Banjo Kazooie or Donkey Kong 64 data (R" & _
            "WP's RARE decompressor's output). "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 556)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "  "
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.Location = New System.Drawing.Point(656, 554)
        Me.TrackBar1.Maximum = 90
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 17)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.Value = 20
        '
        'FolderBrowserDialog2
        '
        Me.FolderBrowserDialog2.Description = "Select the folder that you would like to place found models in. DK64 model extens" & _
            "ion is .dkm, BK model extension is .bkm."
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "DK64 Models (*.dkm)|*.dkm"
        Me.OpenFileDialog2.Title = "Load Donkey Kong 64 Model"
        '
        'SimpleOpenGlControl1
        '
        Me.SimpleOpenGlControl1.AccumBits = CType(0, Byte)
        Me.SimpleOpenGlControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleOpenGlControl1.AutoCheckErrors = True
        Me.SimpleOpenGlControl1.AutoFinish = True
        Me.SimpleOpenGlControl1.AutoMakeCurrent = True
        Me.SimpleOpenGlControl1.AutoSwapBuffers = False
        Me.SimpleOpenGlControl1.BackColor = System.Drawing.Color.Black
        Me.SimpleOpenGlControl1.ColorBits = CType(24, Byte)
        Me.SimpleOpenGlControl1.DepthBits = CType(16, Byte)
        Me.SimpleOpenGlControl1.Location = New System.Drawing.Point(0, -22)
        Me.SimpleOpenGlControl1.Name = "SimpleOpenGlControl1"
        Me.SimpleOpenGlControl1.Size = New System.Drawing.Size(792, 595)
        Me.SimpleOpenGlControl1.StencilBits = CType(0, Byte)
        Me.SimpleOpenGlControl1.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SimpleOpenGlControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Bottles' Glasses 0.1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Variables"
    Private pixel(2) As Byte
    Private actorlist(0) As UInt32
    Private actorlistw(0) As UInt32
    Private bfc As Boolean = False
    Private combine As Boolean = False
    Private gostrafe As Boolean = False
    Private highlight As Boolean = False
    Private axis As Boolean = True
    Private wire As Boolean = False
    Private gorot As Boolean = False
    Private selmode As Boolean = False
    Private key_a As Boolean = False
    Private key_s As Boolean = False
    Private key_w As Boolean = False
    Private key_d As Boolean = False
    Private vert_x As New ArrayList
    Private vert_y As New ArrayList
    Private vert_z As New ArrayList
    Private vert_u As New ArrayList
    Private vert_v As New ArrayList
    Private vert_r As New ArrayList
    Private vert_g As New ArrayList
    Private vert_b As New ArrayList
    Private vert_a As New ArrayList
    Private changeoff As New ArrayList
    Private curbase As New ArrayList
    Private polyind As New ArrayList
    Private xrotad, yrotad, zrotad As Decimal
    Private xrot As Single = 0.0
    Private yrot As Single = 0.0
    Private zrot As Single = 0.0
    Private xrotm As Single = 0.0
    Private yrotm As Single = 0.0
    Private zrotm As Single = 0.0
    Private ulength() As Integer = {}
    Private vlength() As Integer = {}
    Private texcnt As Integer = 0
    Private newx, newy As Integer
    Private oldx, oldy As Integer
    Private finalx As Integer = 0
    Private finaly As Integer = 0
    Private finalz As Integer = 0
    Private mouse As Integer = 0
    Private textouse As Integer = 0
    Private camstyle As Integer = 0
    Private linelist As UInt32 = 0
    Private run As Int32 = 20
    Private finaldesc As String = ""
    Private ident As Integer = 0
    Private msover As Boolean = False
    Private bkfile As FileStream = Nothing
#End Region
    Private Sub MainLoop()
        Gl.glEnable(Gl.GL_DITHER)
        Gl.glEnable(Gl.GL_DEPTH_TEST)
        Gl.glShadeModel(Gl.GL_SMOOTH)
        Gl.glDepthFunc(Gl.GL_LEQUAL)
        Gl.glEnable(Gl.GL_BLEND)
        Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA)
        Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST)
        ResizeScene()
        Do
            Application.DoEvents()
            If SimpleOpenGlControl1.Focused = True Then
                DrawMain()
            End If
            SimpleOpenGlControl1.Invalidate()
        Loop
    End Sub
    Private Sub DrawMain()
        Try
            Gl.glClearColor(0, 0.3, 0.7, 1)
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT)
            Gl.glLoadIdentity()
            yrotad = ((yrot * 0.8 / 180) * 3.14159265)
            xrotad = ((xrot * 0.8 / 180) * 3.14159265)
            zrotad = ((zrot * 0.8 / 180) * 3.14159265)
            If key_w = True Then
                If camstyle = 0 Then
                    If xrot >= 85 Or xrot <= -85 Then
                        finaly += Sin(xrotad) * run
                    Else
                        finalx -= Sin(yrotad) * run
                        finalz += Cos(yrotad) * run
                        finaly += Sin(xrotad) * run
                    End If
                Else
                    finalz += 10
                End If
            End If
            If key_s = True Then
                If camstyle = 0 Then
                    If xrot <= -85 Or xrot >= 85 Then
                        finaly -= Sin(xrotad) * run
                    Else
                        finalx += Sin(yrotad) * run
                        finalz -= Cos(yrotad) * run
                        finaly -= Sin(xrotad) * run
                    End If
                Else
                    finalz -= 10
                End If
            End If
            If key_d = True Then
                If camstyle = 0 Then
                    finalx -= Cos(yrotad) * run
                    finalz -= Sin(yrotad) * run
                Else
                    finalx -= 10
                End If
            End If
            If key_a = True Then
                If camstyle = 0 Then
                    finalx += Cos(yrotad) * run
                    finalz += Sin(yrotad) * run
                Else
                    finalx += 10
                End If
            End If
            newx = MousePosition.X
            newy = MousePosition.Y
            If gorot = True Then
                If oldx < newx Then
                    '(MOUSE MOVE RIGHT)
                    If camstyle = 0 Then
                        yrot += newx - oldx
                    Else
                        yrotm += newx - oldx
                    End If
                End If
                If oldx > newx Then
                    '(MOUSE MOVE LEFT)
                    If camstyle = 0 Then
                        yrot -= oldx - newx
                    Else
                        yrotm -= oldx - newx
                    End If
                End If
                If oldy > newy Then
                    '(MOUSE MOVE DOWN)
                    If camstyle = 0 Then
                        If xrot <= -90 Then
                            xrot = -90
                        Else
                            xrot -= oldy - newy
                        End If
                    Else
                        xrotm -= oldy - newy
                    End If
                End If
                If oldy < newy Then
                    '(MOUSE MOVE UP)
                    If camstyle = 0 Then
                        If xrot >= 90 Then
                            xrot = 90
                        Else
                            xrot += newy - oldy
                        End If
                    Else
                        xrotm += newy - oldy
                    End If
                End If
            End If
            If gostrafe = True Then
                If oldy > newy Then
                    '(MOUSE MOVE DOWN)
                    finaly -= oldy - newy
                End If
                If oldy < newy Then
                    '(MOUSE MOVE UP)
                    finaly += newy - oldy
                End If
            End If
            OverflowCheck()
            oldx = MousePosition.X
            oldy = MousePosition.Y
            Gl.glPushMatrix()
            Gl.glRotatef(xrot * 0.8, 1.0F, 0.0F, 0.0F)
            Gl.glRotatef(yrot * 0.8, 0.0F, 1.0F, 0.0F)
            Gl.glRotatef(zrot * 0.8, 0.0F, 0.0F, 1.0F)
            Gl.glTranslatef(finalx, finaly, finalz)
            If actorlist(0) <> 0 Then
                DrawDList()
            End If
            Gl.glPopMatrix()
            SimpleOpenGlControl1.SwapBuffers()
        Catch err As Exception
            MsgBox("Error in the main loop! Stopping operation." & Environment.NewLine & Environment.NewLine & "Debug Info: " & err.Message, MsgBoxStyle.Critical, "Error")
            End
        End Try
    End Sub
    Private Sub OverflowCheck()
        If finalx >= 32767 Then
            finalx = 32767
        ElseIf finalx <= -32768 Then
            finalx = -32768
        End If
        If finaly >= 32767 Then
            finaly = 32767
        ElseIf finaly <= -32768 Then
            finaly = -32768
        End If
        If finalz >= 32767 Then
            finalz = 32767
        ElseIf finalz <= -32768 Then
            finalz = -32768
        End If
        If xrot >= 32767 Then
            xrot = 32767
        ElseIf xrot <= -32768 Then
            xrot = -32768
        End If
    End Sub
    Private Sub DrawDList()
        Try
            Gl.glPushMatrix()
            'Gl.glBindTexture(Gl.GL_TEXTURE_2D, textouse)
            Gl.glRotatef(xrotm, 1.0F, 0.0F, 0.0F)
            Gl.glRotatef(yrotm, 0.0F, 1.0F, 0.0F)
            Gl.glRotatef(zrotm, 0.0F, 0.0F, 1.0F)
            If axis = True Then
                Gl.glPushMatrix()
                Gl.glLineWidth(15)
                Gl.glCallList(linelist)
                Gl.glLineWidth(1)
                Gl.glPopMatrix()
            End If

            For i As Integer = 0 To actorlist.Length - 1
                Gl.glCallList(actorlist(i))
            Next
            Gl.glPopMatrix()
            If highlight = True And wire = False Then
                Gl.glPushMatrix()
                Gl.glRotatef(xrotm, 1.0F, 0.0F, 0.0F)
                Gl.glRotatef(yrotm, 0.0F, 1.0F, 0.0F)
                Gl.glRotatef(zrotm, 0.0F, 0.0F, 1.0F)
                Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE)
                For i As Integer = 0 To actorlistw.Length - 1
                    Gl.glCallList(actorlistw(i))
                Next
                Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL)
                Gl.glPopMatrix()
            End If
        Catch err As Exception
            MsgBox("Loop Error! " & err.Message)
        End Try
    End Sub
    Public Sub ResizeScene()
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
        'Il.ilInit()
        AxisMarkerToolStripMenuItem.Checked = True
        BuildAxisMarker()
        ResetView()
        Me.Show()
        Me.Focus()
        MainLoop()
    End Sub
    Sub BuildAxisMarker()
        Gl.glLineWidth(0.5)
        linelist = Gl.glGenLists(1)
        Gl.glNewList(linelist, Gl.GL_COMPILE)
        Gl.glBegin(Gl.GL_LINES)
        Gl.glColor3f(0, 0, 1)
        Gl.glVertex3f(420, 0.1, 0.1)
        Gl.glVertex3f(-420, 0.1, 0.1)
        Gl.glEnd()
        Gl.glBegin(Gl.GL_LINES)
        Gl.glColor3f(1, 0, 0)
        Gl.glVertex3f(0.1, 420, 0.1)
        Gl.glVertex3f(0.1, -420, 0.1)
        Gl.glEnd()
        Gl.glBegin(Gl.GL_LINES)
        Gl.glColor3f(0, 1, 0)
        Gl.glVertex3f(0.1, 0.1, 420)
        Gl.glVertex3f(0.1, 0.1, -420)
        Gl.glVertex3f(0.1, 0.1, 420)
        Gl.glEnd()
        Gl.glEndList()
        Gl.glLineWidth(1)
    End Sub
    Private Sub simpleopenglcontrol1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SimpleOpenGlControl1.KeyDown
        Select Case e.KeyCode
            Case Keys.T
                If textouse = texcnt - 1 Then
                    textouse = 0
                Else
                    textouse += 1
                End If
            Case Keys.F1
                If wire = True Then
                    wire = False
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_FILL)
                ElseIf wire = False Then
                    wire = True
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE)
                End If
            Case Keys.W
                key_w = True
            Case Keys.D
                key_d = True
            Case Keys.A
                key_a = True
            Case Keys.S
                key_s = True
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
    Sub Cleararrays()
        vert_x.Clear()
        vert_y.Clear()
        vert_z.Clear()
        vert_r.Clear()
        vert_g.Clear()
        vert_b.Clear()
        vert_a.Clear()
        vert_u.Clear()
        vert_v.Clear()
        polyind.Clear()
        curbase.Clear()
        changeoff.Clear()
    End Sub
    Sub ParseDL(ByVal game As Integer)
        If game = 0 Then
            bkfile = New FileStream(OpenFileDialog1.FileName, FileMode.Open)
        ElseIf game = 1 Then
            bkfile = New FileStream(OpenFileDialog2.FileName, FileMode.Open)
        End If
        Dim curcomm(3) As Byte
        Dim gotopoly(2) As Byte
        Dim comtest As Byte
        Dim vertno1 As Byte
        Dim xt(1) As Byte
        Dim yt(1) As Byte
        Dim zt(1) As Byte
        Dim ut(1) As Byte
        Dim vt(1) As Byte
        Dim arraysizet(1) As Byte
        Dim u As Integer = 0
        Dim endoffset As UInt32
        Dim baseoffset As UInt32
        Dim xmode As String = ""
        Dim xuse As String = ""
        Dim ymode As String = ""
        Dim yuse As String = ""
        Dim texbytes As Integer = 0
        Dim deficit As Integer = 0
        Dim returnto As Integer = 0
        texcnt = 0
        Cleararrays()
        If game = 0 Then
            bkfile.Position = 3
            curcomm(0) = bkfile.ReadByte
            If curcomm(0).ToString("X2") = "0B" Then
            Else
                MsgBox("File loaded is not a BK model!")
                bkfile.Dispose()
                Exit Sub
            End If
            bkfile.Position = 17
        ElseIf game = 1 Then
            bkfile.Position = 4
            curcomm(0) = bkfile.ReadByte
            If curcomm(0).ToString("X2") = "3F" Then
            Else
                MsgBox("File loaded is not DK64 a model!")

                bkfile.Dispose()
                Exit Sub
            End If
            bkfile.Position = 73
        End If
        Me.Text = "Bottles' Glasses 0.1 - " & GetFileName(OpenFileDialog1.FileName)
        Dim done As Boolean = False
        Dim done1 As Boolean = False
        curcomm(0) = bkfile.ReadByte
        curcomm(1) = bkfile.ReadByte
        curcomm(2) = bkfile.ReadByte
        If game = 0 Then
            baseoffset = Convert.ToUInt32(curcomm(0).ToString("X2") & curcomm(1).ToString("X2") & curcomm(2).ToString("X2"), 16) + 24
            Dim oldbkfile As Integer = bkfile.Position + 28
            Do Until done = True
                curcomm(0) = bkfile.ReadByte
                If curcomm(0).ToString("X2") <> "00" Then
                    done = True
                    done1 = False
                End If
                If bkfile.Position > oldbkfile Then
                    done = True
                    done1 = True
                End If
            Loop
            bkfile.Position -= 1
        ElseIf game = 1 Then
            baseoffset = Convert.ToUInt32(curcomm(0).ToString("X2") & curcomm(1).ToString("X2") & curcomm(2).ToString("X2"), 16)
            bkfile.Position += 1
        End If
        curcomm(0) = bkfile.ReadByte
        curcomm(1) = bkfile.ReadByte
        curcomm(2) = bkfile.ReadByte
        If game = 0 Then
            If done1 = False Then
                If curcomm(2).ToString("X2") = "00" Then
                    endoffset = Convert.ToUInt32(curcomm(0).ToString("X2") & curcomm(1).ToString("X2"), 16)
                Else
                    endoffset = Convert.ToUInt32(curcomm(0).ToString("X2") & curcomm(1).ToString("X2") & curcomm(2).ToString("X2"), 16)
                End If
            ElseIf done1 = True Then
                endoffset = bkfile.Length - 4
            End If
        Else
            endoffset = Convert.ToUInt32(curcomm(0).ToString("X2") & curcomm(1).ToString("X2") & curcomm(2).ToString("X2"), 16)
        End If
        Debug.WriteLine("Master vertex array at 0x" & Hex(baseoffset) & " - 0x" & Hex(endoffset))

        bkfile.Position = baseoffset
        Me.Invalidate()
        For u = 0 To ((endoffset - baseoffset) / 16) + 1
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            Application.DoEvents()
            Label2.Text = "Scanning master vertex array... "
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            xt(0) = bkfile.ReadByte
            xt(1) = bkfile.ReadByte
            vert_x.Add(Convert.ToInt16(xt(0).ToString("X2") & xt(1).ToString("X2"), 16))
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            yt(0) = bkfile.ReadByte
            yt(1) = bkfile.ReadByte
            vert_y.Add(Convert.ToInt16(yt(0).ToString("X2") & yt(1).ToString("X2"), 16))
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            zt(0) = bkfile.ReadByte
            zt(1) = bkfile.ReadByte
            vert_z.Add(Convert.ToInt16(zt(0).ToString("X2") & zt(1).ToString("X2"), 16))
            bkfile.Position += 2
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            yt(0) = bkfile.ReadByte
            yt(1) = bkfile.ReadByte
            vert_u.Add(Convert.ToInt16(yt(0).ToString("X2") & yt(1).ToString("X2"), 16))
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            zt(0) = bkfile.ReadByte
            zt(1) = bkfile.ReadByte
            vert_v.Add(Convert.ToInt16(zt(0).ToString("X2") & zt(1).ToString("X2"), 16))
            If bkfile.Position >= bkfile.Length - 1 Then
                Exit For
            End If
            xt(0) = bkfile.ReadByte
            vert_r.Add(xt(0))
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            yt(0) = bkfile.ReadByte
            vert_g.Add(yt(0))
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            zt(0) = bkfile.ReadByte
            vert_b.Add(zt(0))
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
            zt(0) = bkfile.ReadByte
            vert_a.Add(zt(0))
            If bkfile.Position >= bkfile.Length Then
                Exit For
            End If
        Next
        Me.Invalidate()
        bkfile.Position = 0
        Dim past0 As Boolean = False
        Me.Invalidate()
        While bkfile.Position < bkfile.Length - 2
            Label2.Text = "Searching for display lists... "
            curcomm(0) = bkfile.ReadByte
            curcomm(1) = bkfile.ReadByte
            Dim currentcommand As String = curcomm(0).ToString("X2") & curcomm(1).ToString("X2")
            If game = 0 Then
                If Mid(currentcommand, 1, 3) = "040" Then
                    bkfile.Position += 6
                    curcomm(0) = bkfile.ReadByte
                    bkfile.Position += 1
                    If curcomm(0).ToString("X2") = "B1" Or curcomm(0).ToString("X2") = "BF" Then
                        bkfile.Position -= 5
                        Dim sizet(2) As Byte
                        sizet(0) = bkfile.ReadByte
                        sizet(1) = bkfile.ReadByte
                        sizet(2) = bkfile.ReadByte
                        changeoff.Add(polyind.Count)
                        curbase.Add((Convert.ToUInt32(sizet(0).ToString("X2") & sizet(1).ToString("X2") & sizet(2).ToString("X2"), 16) / 16))
                        Do
                            comtest = bkfile.ReadByte
                            Dim finalcom As String = comtest.ToString("X2")
                            If finalcom = "B1" Then 'g_tri2
                                For i2 As Integer = 0 To 2
                                    vertno1 = bkfile.ReadByte
                                    polyind.Add(Convert.ToUInt32(vertno1.ToString("X2"), 16) / 2)
                                Next
                                bkfile.Position += 1
                                For i2 As Integer = 0 To 2
                                    vertno1 = bkfile.ReadByte
                                    polyind.Add(Convert.ToUInt32(vertno1.ToString("X2"), 16) / 2)
                                Next
                            ElseIf finalcom = "BF" Or finalcom = "06" Then 'g_tri1
                                bkfile.Position += 4
                                For i2 As Integer = 0 To 2
                                    vertno1 = bkfile.ReadByte
                                    polyind.Add(Convert.ToUInt32(vertno1.ToString("X2"), 16) / 2)
                                Next
                            Else
                                bkfile.Position -= 1
                                Exit Do
                            End If
                        Loop
                    End If
                End If
            ElseIf game = 1 Then
                If currentcommand = "0204" Then
                    If past0 = False Then
                        bkfile.Position -= 4
                        curcomm(0) = bkfile.ReadByte
                        curcomm(1) = bkfile.ReadByte
                        bkfile.Position -= 2
                        If curcomm(0).ToString("X2") & curcomm(1).ToString("X2") = "0500" Or curcomm(0).ToString("X2") & curcomm(1).ToString("X2") = "0600" Then
                            Do
                                comtest = bkfile.ReadByte
                                Dim finalcom As String = comtest.ToString("X2")
                                If finalcom = "06" Then 'g_tri2
                                    For i2 As Integer = 0 To 2
                                        vertno1 = bkfile.ReadByte
                                        polyind.Add(Convert.ToUInt32(vertno1.ToString("X2"), 16) / 2)
                                    Next
                                    bkfile.Position += 1
                                    For i2 As Integer = 0 To 2
                                        vertno1 = bkfile.ReadByte
                                        polyind.Add(Convert.ToUInt32(vertno1.ToString("X2"), 16) / 2)
                                    Next
                                ElseIf finalcom = "05" Then 'g_tri1
                                    bkfile.Position += 4
                                    For i2 As Integer = 0 To 2
                                        vertno1 = bkfile.ReadByte
                                        polyind.Add(Convert.ToUInt32(vertno1.ToString("X2"), 16) / 2)
                                    Next
                                Else
                                    bkfile.Position -= 1
                                    Exit Do
                                End If
                            Loop
                        End If
                    Else

                    End If
                End If
            End If
        End While
        Dim r As Integer = 0
        Dim b As Integer = -1
        If combine = True Then
            ReDim Preserve actorlist(actorlist.Length)
            actorlist(actorlist.Length - 1) = Gl.glGenLists(1)
            Gl.glNewList(actorlist(actorlist.Length - 1), Gl.GL_COMPILE)
        Else
            ReDim actorlist(0)
            actorlist(0) = Gl.glGenLists(1)
            Gl.glNewList(actorlist(0), Gl.GL_COMPILE)
        End If
        Gl.glBegin(Gl.GL_TRIANGLES)
        If game = 0 Then
            For c As Integer = 0 To polyind.Count - 1
                If r + 1 > changeoff.Count Then

                Else
                    If (changeoff(r)) = c Then
                        b += 1
                        r += 1
                    End If
                End If
                If curbase(b) + polyind(c) > vert_x.Count Then
                    Exit For
                End If
                Gl.glColor4ub(vert_r(curbase(b) + polyind(c)), vert_g(curbase(b) + polyind(c)), vert_b(curbase(b) + polyind(c)), vert_a(curbase(b) + polyind(c)))
                Gl.glVertex3i(vert_x(curbase(b) + polyind(c)), vert_y(curbase(b) + polyind(c)), vert_z(curbase(b) + polyind(c)))
            Next
        ElseIf game = 1 Then
            For c As Integer = 0 To polyind.Count - 1
                Gl.glColor4ub(vert_r(polyind(c)), vert_g(polyind(c)), vert_b(polyind(c)), vert_a(polyind(c)))
                Gl.glVertex3i(vert_x(polyind(c)), vert_y(polyind(c)), vert_z(polyind(c)))
            Next
        End If
        Gl.glEnd()
        Gl.glEndList()
        If combine = True Then
            ReDim Preserve actorlistw(actorlistw.Length)
            actorlistw(actorlistw.Length - 1) = Gl.glGenLists(1)
            Gl.glNewList(actorlistw(actorlistw.Length - 1), Gl.GL_COMPILE)
        Else
            ReDim actorlistw(0)
            actorlistw(0) = Gl.glGenLists(1)
            Gl.glNewList(actorlistw(0), Gl.GL_COMPILE)
        End If
        r = 0
        b = -1
        Gl.glBegin(Gl.GL_TRIANGLES)
        If game = 0 Then
            For c As Integer = 0 To polyind.Count - 1
                If r + 1 > changeoff.Count Then

                Else
                    If (changeoff(r)) = c Then
                        b += 1
                        r += 1
                    End If
                End If
                If curbase(b) + polyind(c) > vert_x.Count Then
                    Exit For
                End If
                Gl.glColor3f(0, 0, 0)
                Gl.glVertex3i(vert_x(curbase(b) + polyind(c)), vert_y(curbase(b) + polyind(c)), vert_z(curbase(b) + polyind(c)))
            Next
        Else

        End If
        Gl.glEnd()
        Gl.glEndList()
        r = 0
        b = -1
        GrabTextures()
        Cleararrays()
        bkfile.Dispose()
        Label2.Text = GetFileName(OpenFileDialog1.FileName) & " loaded."
        GC.Collect()
    End Sub
    Sub GrabTextures()
        Dim seeker(1) As Byte
        Dim xmode As Integer = 0
        Dim xuse As String = ""
        Dim ymode As Integer = 0
        Dim yuse As String = ""
        Dim texbytes As Integer = 0
        Dim returnto As UInt32 = 0
        Dim finalbyte As String = ""
        Dim comtest(1) As Byte
        bkfile.Position = 0
        While bkfile.Position < bkfile.Length - 2
            seeker(0) = bkfile.ReadByte
            seeker(1) = bkfile.ReadByte
            Dim currentcommand As String = seeker(0).ToString("X2") & seeker(1).ToString("X2")
            Select Case currentcommand
                Case "FD10", "FD18", "FD20", "FD30", "FD40", "FD50", "FD60", "FD70", "FD80", "FD90"
                    returnto = bkfile.Position
                    bkfile.Position += 2
                    Dim testbk As Byte = bkfile.ReadByte
                    If testbk.ToString("X2") = "02" Then
                        Dim gototext(2) As Byte
                        For i As Integer = 0 To 2
                            gototext(i) = bkfile.ReadByte
                        Next
                        Dim finaltexoff As UInt32 = Convert.ToUInt32(gototext(0).ToString("X2") & gototext(1).ToString("X2") & gototext(2).ToString("X2"), 16)
                        MsgBox(Hex(finaltexoff))
                        If finaltexoff > bkfile.Length Then
                            GC.Collect()
                            Exit Select
                        End If
                        comtest(0) = bkfile.ReadByte
                        comtest(1) = bkfile.ReadByte
                        If comtest(0).ToString("X2") = "F5" Then
                            finalbyte = comtest(0).ToString("X2") & comtest(1).ToString("X2")
                        End If
                        bkfile.Position += 2
                        Dim xtest As Byte
                        Do Until xtest.ToString("X2") = "E3"
                            xtest = bkfile.ReadByte
                        Loop
                        Dim texwidth As Integer = 0
                        Dim texheight As Integer = 0
                        Dim imagearray() As Byte = {}
                        xtest = bkfile.ReadByte
                        If IsNumeric(xtest.ToString("X2")) = True Then
                            Select Case xtest.ToString("X2")
                                Case "01", "09"
                                    xmode = 1
                                    xuse = "Repeat"
                                Case "05"
                                    xmode = 3
                                    xuse = "Mirror"
                                Case Else
                                    xmode = 1
                                    xuse = "Assumed Repeat"
                            End Select
                        Else
                            xmode = 1
                            xuse = "Assumed Repeat"
                        End If
                        Dim ytest As Byte = bkfile.ReadByte
                        If IsNumeric(Mid(ytest.ToString("X2"), 2, 1)) = True Then
                            Select Case CInt(Mid(ytest.ToString("X2"), 2, 1)) * 16
                                Case 0, 20
                                    ymode = 1
                                    yuse = "Repeat"
                                Case 10
                                    ymode = 3
                                    yuse = "Mirror"
                                Case Else
                                    ymode = 1
                                    yuse = "Assumed Repeat"
                            End Select
                        Else
                            ymode = 1
                            yuse = "Assumed Repeat"
                        End If
                        bkfile.Position += 6
                        Dim dimensiontest(1) As Byte
                        dimensiontest(0) = bkfile.ReadByte
                        dimensiontest(1) = bkfile.ReadByte
                        texbytes = Convert.ToUInt32(Mid(dimensiontest(0).ToString("X2") & dimensiontest(1).ToString("X2"), 1, 3), 16) + 1
                        bkfile.Position -= 1
                        Dim linesizetest(1) As Byte
                        linesizetest(0) = bkfile.ReadByte
                        linesizetest(1) = bkfile.ReadByte
                        Dim linesize As Integer = Convert.ToUInt32(Mid(linesizetest(0).ToString("X2") & linesizetest(1).ToString("X2"), 2, 3), 16)
                        Dim formattest(1) As Byte
                        formattest(0) = bkfile.ReadByte
                        formattest(1) = bkfile.ReadByte
                        Dim formatbyte As String = formattest(0).ToString("X2") & formattest(1).ToString("X2")
                        Dim bppmth As Integer = 0
                        Dim colorcomponents As Integer = 0
                        Select Case formatbyte
                            Case "F590"
                                bppmth = 16
                                colorcomponents = 1
                            Case "F588"
                                bppmth = 8
                                colorcomponents = 1
                            Case "F510"
                                bppmth = 16
                                colorcomponents = 4
                            Case "F580"
                                bppmth = 4
                                colorcomponents = 1
                            Case "F540"
                                bppmth = 4
                                colorcomponents = 1
                            Case "F560"
                                bppmth = 4
                                colorcomponents = 2
                            Case "F550"
                                bppmth = 16
                                colorcomponents = 1
                            Case "F570"
                                bppmth = 16
                                colorcomponents = 4
                            Case "F500"
                                bppmth = 4
                                colorcomponents = 4
                            Case "F520"
                                bppmth = 4
                                colorcomponents = 3
                            Case "F508"
                                bppmth = 8
                                colorcomponents = 4
                            Case "F5FF"
                                bppmth = 8
                                colorcomponents = 1
                            Case "F548"
                                bppmth = 8
                                colorcomponents = 1
                            Case "F568"
                                bppmth = 8
                                colorcomponents = 2
                            Case Else
                                bppmth = 8
                                colorcomponents = 1
                        End Select

                        If linesize = 0 Then

                        Else
                            texwidth = (32 / bppmth) * 4096 / linesize
                            texheight = texbytes
                            texheight *= (16 / bppmth)
                            texheight /= texwidth
                            If bppmth = 16 Then
                                texbytes = (texwidth * texheight) * 2
                            ElseIf bppmth = 4 Then
                                texbytes = (texwidth * texheight) / 2
                                texwidth /= 2
                            Else
                                texbytes = (texwidth * texheight)
                            End If
                            ReDim imagearray(texbytes)
                            ReDim Preserve ulength(texcnt)
                            ReDim Preserve vlength(texcnt)
                            If xmode = 3 Then
                                ulength(texcnt) = texwidth * 64
                            Else
                                ulength(texcnt) = texwidth * 32
                            End If
                            If ymode = 3 Then
                                vlength(texcnt) = texheight * 64
                            Else
                                vlength(texcnt) = texheight * 32
                            End If
                            Directory.CreateDirectory("c:/textures")
                            bkfile.Position = finaltexoff
                            bkfile.Read(imagearray, 0, imagearray.Length - 1)
                            File.WriteAllBytes("c:/textures/0x" & Hex(finaltexoff) & ".raw", imagearray)
                            Il.ilLoadData("c:/textures/0x" & Hex(finaltexoff) & ".raw", texwidth, texheight, 1, 2)
                            Il.ilSave(Il.IL_JPG, "c:/textures/0x" & Hex(finaltexoff) & ".jpg")
                            'Gl.glBindTexture(Gl.GL_TEXTURE_2D, texcnt)
                            If colorcomponents <= 2 Then  'I, IA, and CI textures. Not right for CI, but they do work in grayscale.
                                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, 2, texwidth, texheight, 0, Gl.GL_LUMINANCE, Gl.GL_UNSIGNED_BYTE, imagearray)
                            ElseIf colorcomponents = 3 Then 'YUV, never seen any.
                                MsgBox("yuv textures in bk? apparently.")
                            ElseIf colorcomponents = 4 Then 'RGBA.
                                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, texwidth, texheight, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, imagearray)
                            End If
                            If xmode = 1 Then
                                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT)
                            ElseIf xmode = 2 Then
                                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_CLAMP)
                            ElseIf xmode = 3 Then
                                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_MIRRORED_REPEAT)
                            End If
                            If ymode = 1 Then
                                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT)
                            ElseIf ymode = 2 Then
                                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_CLAMP)
                            ElseIf ymode = 3 Then
                                Gl.glTexParameterf(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_MIRRORED_REPEAT)
                            End If
                            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR)
                            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR)
                            texcnt += 1
                        End If
                        bkfile.Position = returnto + 2
                    End If
            End Select
        End While
    End Sub
    Sub MPixelRead()
        selmode = True
        Gl.glDisable(Gl.GL_DITHER)
        Gl.glPushMatrix()
        Gl.glRotatef(xrot * 0.8, 1.0F, 0.0F, 0.0F)
        Gl.glRotatef(yrot * 0.8, 0.0F, 1.0F, 0.0F)
        Gl.glRotatef(zrot * 0.8, 0.0F, 0.0F, 1.0F)
        Gl.glTranslatef(finalx, finaly, finalz)
        DrawDList()
        Gl.glPopMatrix()
        selmode = False
        Dim viewport(3) As Integer
        Gl.glGetIntegerv(Gl.GL_VIEWPORT, viewport)
        Dim LocalMouse As Point = SimpleOpenGlControl1.PointToClient(Windows.Forms.Cursor.Position)
        Gl.glReadPixels(LocalMouse.X, viewport(3) - LocalMouse.Y, 1, 1, Gl.GL_RGB, Gl.GL_UNSIGNED_BYTE, pixel)
        If pixel(0) = 216 And pixel(1) = 102 And pixel(2) = 255 Then
            camstyle = 1
            Exit Sub
        End If
        Gl.glEnable(Gl.GL_DITHER)
    End Sub
    Private Sub SimpleOpenGlControl1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SimpleOpenGlControl1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            gorot = True
            If mouse = 1 And actorlist(0) <> 0 Then
                MPixelRead()
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            gostrafe = True
        End If
    End Sub

    Private Sub SimpleOpenGlControl1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SimpleOpenGlControl1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            SimpleOpenGlControl1.Cursor = Cursors.Arrow
            gorot = False
            camstyle = 0
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            gostrafe = False
        End If
    End Sub
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        If key_w = True Then
            key_w = False
        End If
        If key_d = True Then
            key_d = False
        End If
        If key_a = True Then
            key_a = False
        End If
        If key_s = True Then
            key_s = False
        End If
        run = TrackBar1.Value - 0.5
    End Sub
    Private Sub ResetView()
        xrot = 0
        yrot = 0
        zrot = 0
        finalx = 0
        finaly = -150
        finalz = -500
        xrotm = 0
        yrotm = 0
        zrotm = 0
    End Sub
    Private Sub FlyAroundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ResetView()
        camstyle = 0
    End Sub
    Private Sub RotationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ResetView()
        camstyle = 1
    End Sub
    Private Sub IsolateFiles(ByVal game As Integer) '0 = banjo kazooie, 1 = donkey kong 64
        Try
            Dim delete As Boolean = False
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                FolderBrowserDialog1.Dispose()
            Else
                If FolderBrowserDialog2.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                    FolderBrowserDialog2.Dispose()
                Else
                    If MsgBox("Delete old files after copy?", MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                        delete = True
                    Else
                        delete = False
                    End If
                    Dim files() As String
                    Dim dirtouse As String = FolderBrowserDialog1.SelectedPath & "\"
                    Dim dirtouse1 As String = FolderBrowserDialog2.SelectedPath & "\"
                    files = Directory.GetFiles(dirtouse)
                    Directory.CreateDirectory(dirtouse1)

                    Dim filecnt As Integer = 0
                    For i As Integer = 0 To files.Length - 1
                        Application.DoEvents()
                        Label2.Text = "Scanning file " & GetFileName(files(i)) & "... "
                        Dim file1 As FileStream = New FileStream(files(i), FileMode.Open)
                        Dim tbyte(3) As Byte
                        If file1.Length > 10 And file1.ToString.Contains(".txt") = False Then
                            If game = 0 Then
                                tbyte(0) = file1.ReadByte
                                tbyte(1) = file1.ReadByte
                                tbyte(2) = file1.ReadByte
                                tbyte(3) = file1.ReadByte
                                file1.Dispose()
                                If tbyte(0).ToString("X2") & tbyte(1).ToString("X2") & tbyte(2).ToString("X2") & tbyte(3).ToString("X2") = "0000000B" Then
                                    filecnt += 1
                                    File.Copy(files(i), dirtouse1 & NoExt(GetFileName(files(i))) & ".bkm", True)
                                    If delete = True Then
                                        File.Delete(files(i))
                                    End If
                                End If
                            ElseIf game = 1 Then
                                Dim incr As Integer = 0
                                Dim descb(0) As Byte
                                descb(0) = 1
                                finaldesc = ""
                                file1.Position = 4
                                tbyte(0) = file1.ReadByte
                                tbyte(1) = file1.ReadByte
                                If tbyte(0).ToString("X2") & tbyte(1).ToString("X2") = "3F80" Then
                                    filecnt += 1
                                    file1.Position = 12
                                    Do Until descb(0).ToString("X2") = "00"
                                        descb(0) = file1.ReadByte
                                        finaldesc += System.Text.Encoding.ASCII.GetString(descb)
                                    Loop
                                    finaldesc = Mid(finaldesc, 1, finaldesc.Length - 1)
                                    File.Copy(files(i), dirtouse1 & finaldesc & "_" & NoExt(GetFileName(files(i))) & ".dkm")
                                    file1.Dispose()
                                    If delete = True Then
                                        File.Delete(files(i))
                                    End If
                                Else
                                    file1.Dispose()
                                End If
                            End If
                        End If
                    Next
                    filecnt = 0
                    Label2.Text = "Files isolated successfully."
                    GC.Collect()
                    MsgBox("Banjo Kazooie model files isolated to " & dirtouse1 & " successfully.", MsgBoxStyle.Information, "No problems encountered")
                End If
            End If
        Catch err As Exception
            MsgBox("Could not isolate files!" & Environment.NewLine & Environment.NewLine & "DEBUG: " & err.Message)
            Label2.Text = "Error isolating files!"
            GC.Collect()
        End Try
    End Sub
    Private Sub WireframeHighlightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WireframeHighlightToolStripMenuItem.Click
        If highlight = False Then
            highlight = True
            WireframeHighlightToolStripMenuItem.Checked = True
        ElseIf highlight = True Then
            highlight = False
            WireframeHighlightToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub AxisMarkerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxisMarkerToolStripMenuItem.Click
        If axis = False Then
            axis = True
            AxisMarkerToolStripMenuItem.Checked = True
        ElseIf axis = True Then
            axis = False
            AxisMarkerToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub AboutBottlesGlassesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBottlesGlassesToolStripMenuItem.Click
        AboutBox1.ShowDialog()
        AboutBox1.Focus()
    End Sub
    Private Sub RAREDecompressorSubDragRWPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RAREDecompressorSubDragRWPToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath & "\misc\GEDecompressor.exe")
        Catch err As Exception
            MsgBox("Couldn't find 'GEDecompressor.exe' in 'misc'!", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub BanjoKazooieToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanjoKazooieToolStripMenuItem1.Click
        IsolateFiles(0)
    End Sub
    Private Sub DonkeyKong64ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonkeyKong64ToolStripMenuItem1.Click
        IsolateFiles(1)
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        StartParse(0)
        ident = 0
    End Sub
    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        StartParse(1)
        ident = 1
    End Sub
    Private Sub StartParse(ByVal game As Integer)
        ResetView()
        ParseDL(game)
    End Sub
    Private Sub QuitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub
    Private Sub BanjoKazooieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanjoKazooieToolStripMenuItem.Click
        combine = False

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            OpenFileDialog1.Dispose()
        End If
    End Sub
    Private Sub DonkeyKong64ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonkeyKong64ToolStripMenuItem.Click
        combine = False
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            OpenFileDialog2.Dispose()
        End If
    End Sub

    Private Sub CombineToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombineToolStripMenuItem.Click
        combine = True
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            OpenFileDialog1.Dispose()
        End If
    End Sub

    Private Sub BackfaceCullingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackfaceCullingToolStripMenuItem.Click
        If bfc = True Then
            bfc = False
        ElseIf bfc = False Then
            bfc = True
        End If
    End Sub
End Class
