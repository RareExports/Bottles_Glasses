Module F3DEX
    'ALL UCODES - BASIC
    Public Const G_SETCIMG As Byte = &HFF
    Public Const G_SETZIMG As Byte = &HFE
    Public Const G_SETTIMG As Byte = &HFD
    Public Const G_SETCOMBINE As Byte = &HFC
    Public Const G_SETENVCOLOR As Byte = &HFB
    Public Const G_SETBLENDCOLOR As Byte = &HF9
    Public Const G_SETFOGCOLOR As Byte = &HF8
    Public Const G_SETPRIMCOLOR As Byte = &HFA
    Public Const G_SETFILLCOLOR As Byte = &HF7
    Public Const G_FILLRECT As Byte = &HF6
    Public Const G_SETTILE As Byte = &HF5
    Public Const G_LOADTILE As Byte = &HF4
    Public Const G_LOADBLOCK As Byte = &HF3
    Public Const G_SETTILESIZE As Byte = &HF2
    Public Const G_LOADTLUT As Byte = &HF0
    Public Const G_RDPSETOTHERMODE As Byte = &HEF
    Public Const G_SETPRIMDEPTH As Byte = &HEE
    Public Const G_SETSCISSOR As Byte = &HED
    Public Const G_SETCONVERT As Byte = &HEC
    Public Const G_SETKEYR As Byte = &HEB
    Public Const G_SETKEYGB As Byte = &HEA
    Public Const G_RDPFULLSYNC As Byte = &HE9
    Public Const G_RDPTILESYNC As Byte = &HE8
    Public Const G_RDPPIPESYNC As Byte = &HE7
    Public Const G_RDPLOADSYNC As Byte = &HE6
    Public Const G_TEXRECTFLIP As Byte = &HE5
    Public Const G_TEXRECT As Byte = &HE4

    'GEOMETRY MODES
    Public G_CULL_FRONT As Byte = &H2
    Public G_CULL_BACK As Byte = &H4
    Public G_CULL_BOTH As Byte = &H6
    Public G_FOG As Byte = &H10000
    Public G_LIGHTING As Byte = &H20000
    Public G_TEXTURE_GEN As Byte = &H40000
    Public G_TEXTURE_GEN_LINEAR As Byte = &H80000
    Public G_LOD As Byte = &H100000
    Public G_SHADING_SMOOTH As Byte = &H200000
    Public G_CLIPPING As Byte = &H800000

    'F3DEX - SPECIFIC
    Public F3DEX_DL As Byte = 0
    Public F3DEX_POPMTX As Byte = 0
    Public F3DEX_TEXTURE As Byte = 0
    Public F3DEX_SETOTHERMODE_H As Byte = 0
    Public F3DEX_SETOTHERMODE_L As Byte = 0
    Public F3DEX_MTX As Byte = 0
    Public F3DEX_SETGEOMETRYMODE As Byte = 0
    Public F3DEX_CLEARGEOMETRYMODE As Byte = 0
    Public F3DEX_ENDDL As Byte = 0
    Public F3DEX_VTX As Byte = 0
    Public F3DEX_MODIFYVTX As Byte = 0
    Public F3DEX_BRANCH_Z As Byte = 0
    Public F3DEX_TRI1 As Byte = 0
    Public F3DEX_TRI2 As Byte = 0

    Public CCMUX() As String = {"G_CCMUX_COMBINED", "G_CCMUX_TEXEL0", "G_CCMUX_TEXEL1", "G_CCMUX_PRIMITIVE", _
                                      "G_CCMUX_SHADE", "G_CCMUX_ENVIRONMENT", "-1", "G_CCMUX_COMBINED_ALPHA", "G_CCMUX_TEXEL0_ALPHA", "G_CCMUX_TEXEL1_ALPHA", "G_CCMUX_PRIMITIVE_ALPHA", _
                                      "G_CCMUX_SHADE_ALPHA", "G_CCMUX_ENV_ALPHA", "G_CCMUX_LOD_FRACTION", "G_CCMUX_PRIM_LOD_FRAC", "-1", "-1", "G_CCMUX_K5", "-1", "G_CCMUX_0"}
    Public TEXFORMATS() As String = {"RGBA", "", "PALETTED", "IA", "I"}
    Public TEXSIZES() As String = {"8-bit", "4-bit", "16-bit", "32-bit"}

    Public Const G_CCMUX_COMBINED As Byte = 0
    Public Const G_CCMUX_TEXEL0 As Byte = 1
    Public Const G_CCMUX_TEXEL1 As Byte = 2
    Public Const G_CCMUX_PRIMITIVE As Byte = 3
    Public Const G_CCMUX_SHADE As Byte = 4
    Public Const G_CCMUX_ENVIRONMENT As Byte = 5
    Public Const G_CCMUX_CENTER As Byte = 6
    Public Const G_CCMUX_SCALE As Byte = 6
    Public Const G_CCMUX_COMBINED_ALPHA As Byte = 7
    Public Const G_CCMUX_TEXEL0_ALPHA As Byte = 8
    Public Const G_CCMUX_TEXEL1_ALPHA As Byte = 9
    Public Const G_CCMUX_PRIMITIVE_ALPHA As Byte = 10
    Public Const G_CCMUX_SHADE_ALPHA As Byte = 11
    Public Const G_CCMUX_ENV_ALPHA As Byte = 12
    Public Const G_CCMUX_LOD_FRACTION As Byte = 13
    Public Const G_CCMUX_PRIM_LOD_FRAC As Byte = 14
    Public Const G_CCMUX_NOISE As Byte = 7
    Public Const G_CCMUX_K4 As Byte = 7
    Public Const G_CCMUX_K5 As Byte = 15
    Public Const G_CCMUX_1 As Byte = 6
    Public Const G_CCMUX_0 As Byte = 31

    'ALPHA COMBINER
    Public Const G_ACMUX_COMBINED As Byte = 0
    Public Const G_ACMUX_TEXEL0 As Byte = 1
    Public Const G_ACMUX_TEXEL1 As Byte = 2
    Public Const G_ACMUX_PRIMITIVE As Byte = 3
    Public Const G_ACMUX_SHADE As Byte = 4
    Public Const G_ACMUX_ENVIRONMENT As Byte = 5
    Public Const G_ACMUX_LOD_FRACTION As Byte = 0
    Public Const G_ACMUX_PRIM_LOD_FRAC As Byte = 6
    Public Const G_ACMUX_1 As Byte = 6
    Public Const G_ACMUX_0 As Byte = 7

End Module
