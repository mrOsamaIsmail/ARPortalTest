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
                Ref [_StencilRefVal]   
                Comp Always    
                Pass Replace  
            }
            Cull Front
            ColorMask 0       
            ZWrite Off       
        }
    }
}
