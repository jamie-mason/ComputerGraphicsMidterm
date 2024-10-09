Shader "Custom/ToonRampShader"
{
    Properties
    {
        _Colour ("Colour", Color) = (1,1,1,1)
        _RampTex ("Toon Ramp Texture", 2D) = "white" {}

    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200
        CGPROGRAM
        
        #pragma surface surf ToonRamp
        


        sampler2D _RampTex;

        struct Input
        {
            float2 uv_RampTex;
        };

        fixed4 _Colour;

       float4 LightingToonRamp(SurfaceOutput s, fixed3 lightDir, float atten){
            float diff = dot(s.Normal, lightDir);
            float h = diff * 1 + 0.5;
            float2 rh = h;
            float3 ramp = tex2D(_RampTex,rh).rgb;
            
            float4 c;
            c.rgb = s.Albedo * _LightColor0.xyz * (ramp);
            c.a = s.Alpha;
            return c;
       } 
        

        void surf (Input IN, inout SurfaceOutput o)
        {
            o.Albedo = _Colour;
        }
        ENDCG
        
    }
   
    FallBack "Diffuse"
    
}
