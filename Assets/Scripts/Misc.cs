using System.Runtime.CompilerServices;
using UnityEngine;

public static class Misc
{
    /// <summary>
    /// Adds a 4th component "w" to a Vector3
    /// </summary>
    /// <param name="vec3"></param>
    /// <returns>vec4 where vec4.w = 1.0f </returns>
    public static Vector4 toVector4(this Vector3 vec3) 
    {
        return new Vector4(vec3.x,vec3.y,vec3.z,1.0f);
    }
}
