namespace Rena.Interop.OpenGL.Generator;

public enum KnownTypeKind : byte
{
    Unknown,
    Pointer,
    Void,
    Bool,
    Byte,
    SByte,
    CChar,
    UShort,
    Short,
    UInt,
    Int,
    ULong,
    Long,
    Float,
    Double,
    IntPtr,
    Size,
    Enum,
    Bitfield,
    DebugProc,
    DebugProcAmd,
    VulkanProcNv,
    EglDebugProc,
}

public static class KnownTypeKindExtensions
{
    public static string ToSharpString(this KnownTypeKind kind)
        => kind switch
        {
            KnownTypeKind.Pointer => "void*",
            KnownTypeKind.Void => "void",
            KnownTypeKind.Bool => "int",
            KnownTypeKind.Byte => "byte",
            KnownTypeKind.SByte => "sbyte",
            KnownTypeKind.CChar => "byte",
            KnownTypeKind.UShort => "ushort",
            KnownTypeKind.Short => "short",
            KnownTypeKind.UInt => "uint",
            KnownTypeKind.Int => "int",
            KnownTypeKind.ULong => "ulong",
            KnownTypeKind.Long => "long",
            KnownTypeKind.Float => "float",
            KnownTypeKind.Double => "double",
            KnownTypeKind.IntPtr => "nint",
            KnownTypeKind.Size => "nint",
            KnownTypeKind.Enum => "int",
            KnownTypeKind.Bitfield => "int",
            KnownTypeKind.DebugProc => "delegate* unmanaged<int, int, uint, int, nint, sbyte*, void*, void>",
            KnownTypeKind.DebugProcAmd => "delegate* unmanaged<uint, int, int, nint, sbyte*, void*, void>",
            KnownTypeKind.VulkanProcNv => "delegate* unmanaged<void>",
            KnownTypeKind.EglDebugProc => "delegate* unmanaged<int, byte*, int, void*, int, byte*, void>",
            _ => "<<Unknown>>"
        };

    public static int GetPointerDepth(this KnownTypeKind kind)
        => kind switch
        {
            KnownTypeKind.Pointer => 1,
            KnownTypeKind.DebugProc => 1,
            KnownTypeKind.DebugProcAmd => 1,
            KnownTypeKind.VulkanProcNv => 1,
            KnownTypeKind.EglDebugProc => 1,
            _ => 0
        };

    public static KnownTypeKind FromString(ReadOnlySpan<char> type)
        => type switch
        {
            // Gl
            "void" => KnownTypeKind.Void,
            "char" => KnownTypeKind.CChar,
            "GLvoid" => KnownTypeKind.Void,
            "GLboolean" => KnownTypeKind.Bool,
            "GLbyte" => KnownTypeKind.Byte,
            "GLchar" => KnownTypeKind.CChar,
            "GLcharARB" => KnownTypeKind.CChar,
            "GLubyte" => KnownTypeKind.Byte,
            "GLshort" => KnownTypeKind.Short,
            "GLushort" => KnownTypeKind.UShort,
            "GLhalf" => KnownTypeKind.UShort,
            "GLhalfARB" => KnownTypeKind.UShort,
            "GLhalfNV" => KnownTypeKind.UShort,
            "GLhandleARB" => KnownTypeKind.UShort,
            "GLint" => KnownTypeKind.Int,
            "GLclampx" => KnownTypeKind.Int,
            "GLsizei" => KnownTypeKind.Int,
            "GLfixed" => KnownTypeKind.UInt,
            "GLuint" => KnownTypeKind.UInt,
            "GLfloat" => KnownTypeKind.Float,
            "GLclampf" => KnownTypeKind.Float,
            "GLdouble" => KnownTypeKind.Double,
            "GLclampd" => KnownTypeKind.Double,
            "GLeglClientBufferEXT" => KnownTypeKind.Pointer,
            "GLeglImageOES" => KnownTypeKind.Pointer,
            "GLintptr" => KnownTypeKind.IntPtr,
            "GLintptrARB" => KnownTypeKind.IntPtr,
            "GLvdpauSurfaceNV" => KnownTypeKind.Pointer,
            "GLsizeiptr" => KnownTypeKind.Size,
            "GLsizeiptrARB" => KnownTypeKind.Size,
            "GLsync" => KnownTypeKind.Pointer,
            "GLint64" => KnownTypeKind.Long,
            "GLint64EXT" => KnownTypeKind.Long,
            "GLuint64" => KnownTypeKind.ULong,
            "GLuint64EXT" => KnownTypeKind.ULong,
            "GLenum" => KnownTypeKind.Enum,
            "GLbitfield" => KnownTypeKind.Bitfield,
            "GLDEBUGPROC" => KnownTypeKind.DebugProc,
            "GLDEBUGPROCARB" => KnownTypeKind.DebugProc,
            "GLDEBUGPROCKHR" => KnownTypeKind.DebugProc,
            "GLDEBUGPROCAMD" => KnownTypeKind.DebugProcAmd,
            "GLVULKANPROCNV" => KnownTypeKind.VulkanProcNv,
            "struct _cl_context" => KnownTypeKind.Void,
            "struct _cl_event" => KnownTypeKind.Void,

            // Egl
            "EGLBoolean" => KnownTypeKind.Bool,
            "EGLint" => KnownTypeKind.Int,
            "EGLenum" => KnownTypeKind.Enum,
            "EGLNativeDisplayType" => KnownTypeKind.Pointer,
            "EGLNativePixmapType" => KnownTypeKind.Pointer,
            "EGLNativeWindowType" => KnownTypeKind.Pointer,
            "NativeDisplayType" => KnownTypeKind.Pointer,
            "NativePixmapType" => KnownTypeKind.Pointer,
            "NativeWindowType" => KnownTypeKind.Pointer,
            "EGLAttribKHR" => KnownTypeKind.IntPtr,
            "EGLAttrib" => KnownTypeKind.IntPtr,
            "EGLClientBuffer" => KnownTypeKind.Pointer,
            "EGLConfig" => KnownTypeKind.Pointer,
            "EGLContext" => KnownTypeKind.Pointer,
            "EGLDeviceEXT" => KnownTypeKind.Pointer,
            "EGLDisplay" => KnownTypeKind.Pointer,
            "EGLImage" => KnownTypeKind.Pointer,
            "EGLImageKHR" => KnownTypeKind.Pointer,
            "EGLLabelKHR" => KnownTypeKind.Pointer,
            "EGLObjectKHR" => KnownTypeKind.Pointer,
            "EGLOutputLayerEXT" => KnownTypeKind.Pointer,
            "EGLOutputPortEXT" => KnownTypeKind.Pointer,
            "EGLStreamKHR" => KnownTypeKind.Pointer,
            "EGLSurface" => KnownTypeKind.Pointer,
            "EGLSync" => KnownTypeKind.Pointer,
            "EGLSyncKHR" => KnownTypeKind.Pointer,
            "EGLSyncNV" => KnownTypeKind.Pointer,
            "EGLTimeKHR" => KnownTypeKind.Pointer,
            "EGLTime" => KnownTypeKind.ULong,
            "EGLTimeNV" => KnownTypeKind.ULong,
            "EGLuint64NV" => KnownTypeKind.ULong,
            "EGLuint64KHR" => KnownTypeKind.ULong,
            "EGLnsecsANDROID" => KnownTypeKind.Long,
            "EGLNativeFileDescriptorKHR" => KnownTypeKind.Int,
            "EGLsizeiANDROID" => KnownTypeKind.Size,
            "EGLDEBUGPROCKHR" => KnownTypeKind.EglDebugProc,
            "__eglMustCastToProperFunctionPointerType" => KnownTypeKind.Pointer,
            _ => KnownTypeKind.Unknown
        };
}