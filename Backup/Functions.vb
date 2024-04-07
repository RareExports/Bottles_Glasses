Imports Tao.freeglut
Imports Tao.opengl
Module Functions
    Public Function GLPrint(ByVal GLText As String, ByVal XPos As Double, ByVal YPos As Double, ByVal ZPos As Double) As Object
        Gl.glMatrixMode(Gl.GL_PROJECTION)
        Gl.glPushMatrix()
        Gl.glLoadIdentity()
        Gl.glOrtho(0, Main.SimpleOpenGlControl1.Width, 0, Main.SimpleOpenGlControl1.Height, -1, 1)
        Gl.glMatrixMode(Gl.GL_MODELVIEW)
        Gl.glPushMatrix()
        Gl.glLoadIdentity()
        Gl.glColor3f(1, 1, 1)
        Gl.glRasterPos3f(XPos, Main.SimpleOpenGlControl1.Height - YPos, ZPos)
        For am As Integer = 0 To GLText.Length - 1
            If GLText = "*" Then
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_TIMES_ROMAN_24, Asc(GLText(am)))
            Else
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_9_BY_15, Asc(GLText(am)))
            End If
        Next
        Gl.glMatrixMode(Gl.GL_PROJECTION)
        Gl.glPopMatrix()
        Gl.glMatrixMode(Gl.GL_MODELVIEW)
        Gl.glPopMatrix()
        Gl.glEnable(Gl.GL_DEPTH_TEST)
        Return GLText
    End Function
    Public Function GetFileName(ByVal flname As String) As String
        Dim posn As Integer, i As Integer
        Dim fName As String
        For i = 1 To Len(flname)
            If (Mid(flname, i, 1) = "\") Then posn = i
        Next i
        fName = Right(flname, Len(flname) - posn)
        GetFileName = fName
    End Function
    Public Function NoExt(ByVal FullPath _
            As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function
End Module
