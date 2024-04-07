Imports Tao.freeglut
Imports Tao.opengl
Module Functions
    Public BKmodelini As New INIFile(Application.StartupPath & "\misc\BKmodels.ini")
    Public BTmodelini As New INIFile(Application.StartupPath & "\misc\BTmodels.ini")
    Public CurrModel As String = ""
    Public BKModelDir As String = ""
    Public BTModelDir As String = ""
    Public DKModelDir As String = ""
    Public Game As Integer = 0
    Public Sub GLPrintDL(ByVal DList As Integer, ByVal ScaleFactorX As Double, ByVal ScaleFactorY As Double, ByVal ScaleFactorZ As Double, ByVal XPos As Integer, ByVal YPos As Integer, ByVal ZPos As Integer, ByVal XRot As Double, ByVal YRot As Double, ByVal ZRot As Double)
        Gl.glMatrixMode(Gl.GL_PROJECTION)
        Gl.glPushMatrix()
        Gl.glLoadIdentity()

        Gl.glMatrixMode(Gl.GL_MODELVIEW)
        Gl.glPushMatrix()
        Gl.glLoadIdentity()
        Gl.glScalef(ScaleFactorX, ScaleFactorY, ScaleFactorZ)
        Gl.glTranslatef(XPos, YPos, ZPos)
        Gl.glRotatef(XRot, 1.0F, 0.0F, 0.0F)
        Gl.glRotatef(YRot, 0.0F, 1.0F, 0.0F)
        Gl.glRotatef(ZRot, 0.0F, 0.0F, 1.0F)


        'Gl.glRasterPos2f(XPos, Main.SimpleOpenGlControl1.Height - YPos)
        Gl.glCallList(DList)
        Gl.glMatrixMode(Gl.GL_PROJECTION)
        Gl.glPopMatrix()
        Gl.glMatrixMode(Gl.GL_MODELVIEW)
        Gl.glPopMatrix()
    End Sub
    Public Sub GLPrint(ByVal GLText As String, ByVal XPos As Double, ByVal YPos As Double, ByVal ZPos As Double)
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
            Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_TIMES_ROMAN_24, Asc(GLText(am)))
        Next
        Gl.glMatrixMode(Gl.GL_PROJECTION)
        Gl.glPopMatrix()

        Gl.glMatrixMode(Gl.GL_MODELVIEW)
        Gl.glPopMatrix()
    End Sub
    Public Function _ShiftR(ByVal v As UInt32, ByVal s As UInt32, ByVal w As UInt32) As UInt32
        Return (v >> s) And ((&H1 << w) - 1)
    End Function
    Private Function _ShiftL(ByVal v As UInt32, ByVal s As UInt32, ByVal w As UInt32) As UInt32
        Return (v And ((&H1 << w) - 1) << s)
    End Function
    Public Function ReadUInt32(ByVal Buffer() As Byte, ByVal Offset As UInteger) As UInteger
        If Offset >= Buffer.Length - 1 Then
            ReadUInt32 = -1
            Exit Function
        End If
        ReadUInt32 = Buffer(Offset) * &H1000000 _
                                    + Buffer(Offset + 1) * &H10000 _
                                    + Buffer(Offset + 2) * &H100 _
                                    + Buffer(Offset + 3)

    End Function
    Public Function ReadUInt24(ByVal Buffer() As Byte, ByVal Offset As UInteger) As Integer
        If Offset >= Buffer.Length - 1 Then
            ReadUInt24 = -1
            Exit Function
        End If
        ReadUInt24 = Buffer(Offset) * &H10000 _
                            + Buffer(Offset + 1) * &H100 _
                            + Buffer(Offset + 2)
    End Function
    Public Function ReadInt16(ByVal Buffer() As Byte, ByVal Offset As UInteger) As Integer
        If Offset >= Buffer.Length - 1 Then
            ReadInt16 = 0
            Exit Function
        End If
        ReadInt16 = Buffer(Offset) * &H100 + Buffer(Offset + 1)
    End Function
    Public Function WriteInt16(ByRef Buffer() As Byte, ByRef Offset As Short, ByVal Data As Short) As Integer
        Try
            If Offset >= (Buffer.Length - 1) Then
                ReDim Preserve Buffer(Offset + 2)
            End If
            Buffer(Offset + 0) = (Data >> 8) And &HFF
            Buffer(Offset + 1) = (Data >> 0) And &HFF
            Offset += 2
            Return 0
        Catch
            Return -1
        End Try
    End Function
    Public Function WriteInt32(ByRef Buffer() As Byte, ByVal Data As UInteger, ByRef Offset As Integer) As Integer
        Try
            If Offset >= (Buffer.Length - 1) Then
                ReDim Preserve Buffer(Offset + 4)
            End If
            Buffer(Offset + 0) = (Data >> 24) And &HFF
            Buffer(Offset + 1) = (Data >> 16) And &HFF
            Buffer(Offset + 2) = (Data >> 8) And &HFF
            Buffer(Offset + 3) = (Data >> 0) And &HFF
            Offset += 4
            Return 0
        Catch
            Return -1
        End Try
    End Function
    Public Function WriteInt24(ByRef Buffer() As Byte, ByVal Data As UInteger, ByRef Offset As Integer) As Integer
        Try
            If Offset >= (Buffer.Length - 1) Then
                ReDim Preserve Buffer(Offset + 3)
            End If
            Buffer(Offset + 0) = (Data >> 16) And &HFF
            Buffer(Offset + 1) = (Data >> 8) And &HFF
            Buffer(Offset + 2) = (Data >> 0) And &HFF
            Offset += 3
            Return 0
        Catch
            Return -1
        End Try
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
