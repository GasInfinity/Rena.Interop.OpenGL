using System.Collections.Immutable;

namespace Rena.Interop.OpenGL.Generator;

[Flags]
public enum Api : byte
{
    GL,
    GLX,
    WGL,
    EGL
}

public static class ApiExtensions
{
    public static string ToFeatureString(this Api api, GLApi glApi = GLApi.GL)
        => api switch
        {
            Api.GL => glApi.ToFeatureString(),
            Api.GLX => "glx",
            Api.WGL => "wgl",
            Api.EGL => "egl",
            _ => string.Empty
        };

    public static Api FromFeatureString(string api, out GLApi glApi)
    {
        glApi = api switch
        {
            "gl" => GLApi.GL,
            "gles1" => GLApi.GLES1,
            "gles2" => GLApi.GLES2,
            "glsc2" => GLApi.GLSC2,
            _ => default
        };

        return api switch
        {
            "glx" => Api.GLX,
            "glw" => Api.WGL,
            "egl" => Api.EGL,
            _ => Api.GL
        };
    }

    public static Api FromSupportedStrings(string supported, out ImmutableArray<GLApi> glSupported, out GLProfile profile)
    {
        if (GLApiExtensions.TryGetSupported(supported, out glSupported, out profile))
            return Api.GL;

        return FromFeatureString(supported, out _);
    }
}