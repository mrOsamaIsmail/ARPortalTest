Shader "Unlit/MaskShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _StencilRefVal("StencilMask",Range(0,255)) =0 
        _CullFace("Culling Face",int) = 0
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
            Cull [_CullFace]
            ColorMask 0       
            ZWrite Off       
        }
    }
}
