// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9950,x:33722,y:32698,varname:node_9950,prsc:2|emission-5754-OUT;n:type:ShaderForge.SFN_DepthBlend,id:8080,x:32076,y:32901,varname:node_8080,prsc:2|DIST-1264-OUT;n:type:ShaderForge.SFN_Slider,id:1264,x:31686,y:32905,ptovrint:False,ptlb:DBSize,ptin:_DBSize,varname:node_116,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Color,id:672,x:32931,y:32538,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_4999,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Fresnel,id:738,x:32079,y:32553,varname:node_738,prsc:2|EXP-4648-OUT;n:type:ShaderForge.SFN_Add,id:5196,x:32955,y:32929,varname:node_5196,prsc:2|A-2691-OUT,B-1229-OUT;n:type:ShaderForge.SFN_Slider,id:4648,x:31666,y:32589,ptovrint:False,ptlb:FSize,ptin:_FSize,varname:node_6303,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:5;n:type:ShaderForge.SFN_If,id:2691,x:32474,y:32679,varname:node_2691,prsc:2|A-738-OUT,B-7990-OUT,GT-9095-OUT,EQ-806-OUT,LT-806-OUT;n:type:ShaderForge.SFN_Vector1,id:7990,x:32076,y:32685,varname:node_7990,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:9095,x:32076,y:32743,varname:node_9095,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:806,x:32076,y:32799,varname:node_806,prsc:2,v1:0;n:type:ShaderForge.SFN_If,id:1229,x:32485,y:32870,varname:node_1229,prsc:2|A-8080-OUT,B-7990-OUT,GT-806-OUT,EQ-9095-OUT,LT-9095-OUT;n:type:ShaderForge.SFN_Multiply,id:5754,x:33505,y:32801,varname:node_5754,prsc:2|A-672-RGB,B-672-A,C-18-RGB,D-18-A,E-3214-OUT;n:type:ShaderForge.SFN_Clamp01,id:3214,x:33127,y:32929,varname:node_3214,prsc:2|IN-5196-OUT;n:type:ShaderForge.SFN_VertexColor,id:18,x:32931,y:32689,varname:node_18,prsc:2;proporder:672-1264-4648;pass:END;sub:END;*/

Shader "Custom/S_Wave" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _DBSize ("DBSize", Range(0, 1)) = 1
        _FSize ("FSize", Range(0, 5)) = 1
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 100
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _CameraDepthTexture;
            uniform float _DBSize;
            uniform float4 _Color;
            uniform float _FSize;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD2;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
////// Lighting:
////// Emissive:
                float node_7990 = 0.5;
                float node_2691_if_leA = step(pow(1.0-max(0,dot(normalDirection, viewDirection)),_FSize),node_7990);
                float node_2691_if_leB = step(node_7990,pow(1.0-max(0,dot(normalDirection, viewDirection)),_FSize));
                float node_806 = 0.0;
                float node_9095 = 1.0;
                float node_1229_if_leA = step(saturate((sceneZ-partZ)/_DBSize),node_7990);
                float node_1229_if_leB = step(node_7990,saturate((sceneZ-partZ)/_DBSize));
                float node_3214 = saturate((lerp((node_2691_if_leA*node_806)+(node_2691_if_leB*node_9095),node_806,node_2691_if_leA*node_2691_if_leB)+lerp((node_1229_if_leA*node_9095)+(node_1229_if_leB*node_806),node_9095,node_1229_if_leA*node_1229_if_leB)));
                float3 emissive = (_Color.rgb*_Color.a*i.vertexColor.rgb*i.vertexColor.a*node_3214);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
