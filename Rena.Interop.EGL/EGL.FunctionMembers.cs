namespace Rena.Interop.EGL;

public unsafe partial class EGL
{
    internal static ReadOnlySpan<byte> eglBindAPIFunctionName => "eglBindAPI"u8;
    internal static ReadOnlySpan<byte> eglBindTexImageFunctionName => "eglBindTexImage"u8;
    internal static ReadOnlySpan<byte> eglChooseConfigFunctionName => "eglChooseConfig"u8;
    internal static ReadOnlySpan<byte> eglClientWaitSyncFunctionName => "eglClientWaitSync"u8;
    internal static ReadOnlySpan<byte> eglCopyBuffersFunctionName => "eglCopyBuffers"u8;
    internal static ReadOnlySpan<byte> eglCreateContextFunctionName => "eglCreateContext"u8;
    internal static ReadOnlySpan<byte> eglCreateImageFunctionName => "eglCreateImage"u8;
    internal static ReadOnlySpan<byte> eglCreatePbufferFromClientBufferFunctionName => "eglCreatePbufferFromClientBuffer"u8;
    internal static ReadOnlySpan<byte> eglCreatePbufferSurfaceFunctionName => "eglCreatePbufferSurface"u8;
    internal static ReadOnlySpan<byte> eglCreatePixmapSurfaceFunctionName => "eglCreatePixmapSurface"u8;
    internal static ReadOnlySpan<byte> eglCreatePlatformPixmapSurfaceFunctionName => "eglCreatePlatformPixmapSurface"u8;
    internal static ReadOnlySpan<byte> eglCreatePlatformWindowSurfaceFunctionName => "eglCreatePlatformWindowSurface"u8;
    internal static ReadOnlySpan<byte> eglCreateSyncFunctionName => "eglCreateSync"u8;
    internal static ReadOnlySpan<byte> eglCreateWindowSurfaceFunctionName => "eglCreateWindowSurface"u8;
    internal static ReadOnlySpan<byte> eglDestroyContextFunctionName => "eglDestroyContext"u8;
    internal static ReadOnlySpan<byte> eglDestroyImageFunctionName => "eglDestroyImage"u8;
    internal static ReadOnlySpan<byte> eglDestroySurfaceFunctionName => "eglDestroySurface"u8;
    internal static ReadOnlySpan<byte> eglDestroySyncFunctionName => "eglDestroySync"u8;
    internal static ReadOnlySpan<byte> eglGetConfigAttribFunctionName => "eglGetConfigAttrib"u8;
    internal static ReadOnlySpan<byte> eglGetConfigsFunctionName => "eglGetConfigs"u8;
    internal static ReadOnlySpan<byte> eglGetCurrentContextFunctionName => "eglGetCurrentContext"u8;
    internal static ReadOnlySpan<byte> eglGetCurrentDisplayFunctionName => "eglGetCurrentDisplay"u8;
    internal static ReadOnlySpan<byte> eglGetCurrentSurfaceFunctionName => "eglGetCurrentSurface"u8;
    internal static ReadOnlySpan<byte> eglGetDisplayFunctionName => "eglGetDisplay"u8;
    internal static ReadOnlySpan<byte> eglGetErrorFunctionName => "eglGetError"u8;
    internal static ReadOnlySpan<byte> eglGetPlatformDisplayFunctionName => "eglGetPlatformDisplay"u8;
    internal static ReadOnlySpan<byte> eglGetProcAddressFunctionName => "eglGetProcAddress"u8;
    internal static ReadOnlySpan<byte> eglGetSyncAttribFunctionName => "eglGetSyncAttrib"u8;
    internal static ReadOnlySpan<byte> eglInitializeFunctionName => "eglInitialize"u8;
    internal static ReadOnlySpan<byte> eglMakeCurrentFunctionName => "eglMakeCurrent"u8;
    internal static ReadOnlySpan<byte> eglQueryAPIFunctionName => "eglQueryAPI"u8;
    internal static ReadOnlySpan<byte> eglQueryContextFunctionName => "eglQueryContext"u8;
    internal static ReadOnlySpan<byte> eglQueryStringFunctionName => "eglQueryString"u8;
    internal static ReadOnlySpan<byte> eglQuerySurfaceFunctionName => "eglQuerySurface"u8;
    internal static ReadOnlySpan<byte> eglReleaseTexImageFunctionName => "eglReleaseTexImage"u8;
    internal static ReadOnlySpan<byte> eglReleaseThreadFunctionName => "eglReleaseThread"u8;
    internal static ReadOnlySpan<byte> eglSurfaceAttribFunctionName => "eglSurfaceAttrib"u8;
    internal static ReadOnlySpan<byte> eglSwapBuffersFunctionName => "eglSwapBuffers"u8;
    internal static ReadOnlySpan<byte> eglSwapIntervalFunctionName => "eglSwapInterval"u8;
    internal static ReadOnlySpan<byte> eglTerminateFunctionName => "eglTerminate"u8;
    internal static ReadOnlySpan<byte> eglWaitClientFunctionName => "eglWaitClient"u8;
    internal static ReadOnlySpan<byte> eglWaitGLFunctionName => "eglWaitGL"u8;
    internal static ReadOnlySpan<byte> eglWaitNativeFunctionName => "eglWaitNative"u8;
    internal static ReadOnlySpan<byte> eglWaitSyncFunctionName => "eglWaitSync"u8;
    
    private readonly delegate* unmanaged</* EGLenum */ int, /* EGLBoolean */ int> eglBindAPI;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSurface */ void*, /* EGLint */ int, /* EGLBoolean */ int> eglBindTexImage;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLint */ int*, /* EGLConfig */ void**, /* EGLint */ int, /* EGLint */ int*, /* EGLBoolean */ int> eglChooseConfig;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSync */ void*, /* EGLint */ int, /* EGLTime */ ulong, /* EGLint */ int> eglClientWaitSync;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSurface */ void*, /* EGLNativePixmapType */ void*, /* EGLBoolean */ int> eglCopyBuffers;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLConfig */ void*, /* EGLContext */ void*, /* EGLint */ int*, /* EGLContext */ void*> eglCreateContext;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLContext */ void*, /* EGLenum */ int, /* EGLClientBuffer */ void*, /* EGLAttrib */ nint*, /* EGLImage */ void*> eglCreateImage;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLenum */ int, /* EGLClientBuffer */ void*, /* EGLConfig */ void*, /* EGLint */ int*, /* EGLSurface */ void*> eglCreatePbufferFromClientBuffer;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLConfig */ void*, /* EGLint */ int*, /* EGLSurface */ void*> eglCreatePbufferSurface;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLConfig */ void*, /* EGLNativePixmapType */ void*, /* EGLint */ int*, /* EGLSurface */ void*> eglCreatePixmapSurface;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLConfig */ void*, /* void */ void*, /* EGLAttrib */ nint*, /* EGLSurface */ void*> eglCreatePlatformPixmapSurface;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLConfig */ void*, /* void */ void*, /* EGLAttrib */ nint*, /* EGLSurface */ void*> eglCreatePlatformWindowSurface;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLenum */ int, /* EGLAttrib */ nint*, /* EGLSync */ void*> eglCreateSync;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLConfig */ void*, /* EGLNativeWindowType */ void*, /* EGLint */ int*, /* EGLSurface */ void*> eglCreateWindowSurface;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLContext */ void*, /* EGLBoolean */ int> eglDestroyContext;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLImage */ void*, /* EGLBoolean */ int> eglDestroyImage;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSurface */ void*, /* EGLBoolean */ int> eglDestroySurface;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSync */ void*, /* EGLBoolean */ int> eglDestroySync;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLConfig */ void*, /* EGLint */ int, /* EGLint */ int*, /* EGLBoolean */ int> eglGetConfigAttrib;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLConfig */ void**, /* EGLint */ int, /* EGLint */ int*, /* EGLBoolean */ int> eglGetConfigs;
    private readonly delegate* unmanaged</* EGLContext */ void*> eglGetCurrentContext;
    private readonly delegate* unmanaged</* EGLDisplay */ void*> eglGetCurrentDisplay;
    private readonly delegate* unmanaged</* EGLint */ int, /* EGLSurface */ void*> eglGetCurrentSurface;
    private readonly delegate* unmanaged</* EGLNativeDisplayType */ void*, /* EGLDisplay */ void*> eglGetDisplay;
    private readonly delegate* unmanaged</* EGLint */ int> eglGetError;
    private readonly delegate* unmanaged</* EGLenum */ int, /* void */ void*, /* EGLAttrib */ nint*, /* EGLDisplay */ void*> eglGetPlatformDisplay;
    private readonly delegate* unmanaged</* char */ byte*, /* __eglMustCastToProperFunctionPointerType */ void*> eglGetProcAddress;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSync */ void*, /* EGLint */ int, /* EGLAttrib */ nint*, /* EGLBoolean */ int> eglGetSyncAttrib;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLint */ int*, /* EGLint */ int*, /* EGLBoolean */ int> eglInitialize;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSurface */ void*, /* EGLSurface */ void*, /* EGLContext */ void*, /* EGLBoolean */ int> eglMakeCurrent;
    private readonly delegate* unmanaged</* EGLenum */ int> eglQueryAPI;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLContext */ void*, /* EGLint */ int, /* EGLint */ int*, /* EGLBoolean */ int> eglQueryContext;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLint */ int, /* char */ byte*> eglQueryString;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSurface */ void*, /* EGLint */ int, /* EGLint */ int*, /* EGLBoolean */ int> eglQuerySurface;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSurface */ void*, /* EGLint */ int, /* EGLBoolean */ int> eglReleaseTexImage;
    private readonly delegate* unmanaged</* EGLBoolean */ int> eglReleaseThread;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSurface */ void*, /* EGLint */ int, /* EGLint */ int, /* EGLBoolean */ int> eglSurfaceAttrib;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSurface */ void*, /* EGLBoolean */ int> eglSwapBuffers;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLint */ int, /* EGLBoolean */ int> eglSwapInterval;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLBoolean */ int> eglTerminate;
    private readonly delegate* unmanaged</* EGLBoolean */ int> eglWaitClient;
    private readonly delegate* unmanaged</* EGLBoolean */ int> eglWaitGL;
    private readonly delegate* unmanaged</* EGLint */ int, /* EGLBoolean */ int> eglWaitNative;
    private readonly delegate* unmanaged</* EGLDisplay */ void*, /* EGLSync */ void*, /* EGLint */ int, /* EGLBoolean */ int> eglWaitSync;
}