Shader "Unlit/MaskShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _StencilRefVal("StencilMask",Range(0,255)) =0 
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Pass
        {
            Stencil
            {
                Ref [_StencilRefVal]          // Value to write
                Comp Always    // Always write to the stencil buffer
                Pass Replace   // Replace existing stencil value
            }
            Cull off
            ColorMask 0       
            ZWrite Off       
        }
    }
}
