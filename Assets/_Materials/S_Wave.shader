// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9950,x:33722,y:32698,varname:node_9950,prsc:2|emission-5754-OUT,alpha-1799-OUT;n:type:ShaderForge.SFN_DepthBlend,id:8080,x:32076,y:32901,varname:node_8080,prsc:2|DIST-1264-OUT;n:type:ShaderForge.SFN_Slider,id:1264,x:31562,y:32925,ptovrint:False,ptlb:DBSize,ptin:_DBSize,varname:node_116,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Color,id:672,x:32931,y:32538,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_4999,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Fresnel,id:738,x:32079,y:32553,varname:node_738,prsc:2|EXP-8800-OUT;n:type:ShaderForge.SFN_Add,id:5196,x:32958,y:32945,varname:node_5196,prsc:2|A-2691-OUT,B-1229-OUT;n:type:ShaderForge.SFN_Slider,id:4648,x:31335,y:32537,ptovrint:False,ptlb:FSize,ptin:_FSize,varname:node_6303,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:5;n:type:ShaderForge.SFN_If,id:2691,x:32474,y:32679,varname:node_2691,prsc:2|A-738-OUT,B-7990-OUT,GT-9095-OUT,EQ-806-OUT,LT-806-OUT;n:type:ShaderForge.SFN_Vector1,id:7990,x:32076,y:32685,varname:node_7990,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:9095,x:32076,y:32743,varname:node_9095,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:806,x:32076,y:32799,varname:node_806,prsc:2,v1:0;n:type:ShaderForge.SFN_If,id:1229,x:32485,y:32870,varname:node_1229,prsc:2|A-8080-OUT,B-7990-OUT,GT-806-OUT,EQ-9095-OUT,LT-9095-OUT;n:type:ShaderForge.SFN_Multiply,id:5754,x:33407,y:32799,varname:node_5754,prsc:2|A-672-RGB,B-672-A,C-18-RGB,D-18-A,E-3214-OUT;n:type:ShaderForge.SFN_Clamp01,id:3214,x:33131,y:32956,varname:node_3214,prsc:2|IN-5196-OUT;n:type:ShaderForge.SFN_VertexColor,id:18,x:32931,y:32689,varname:node_18,prsc:2;n:type:ShaderForge.SFN_ObjectScale,id:3758,x:30631,y:32767,varname:node_3758,prsc:2,rcp:False;n:type:ShaderForge.SFN_Multiply,id:8800,x:31752,y:32572,varname:node_8800,prsc:2|A-4648-OUT,B-7538-OUT;n:type:ShaderForge.SFN_Multiply,id:1799,x:33407,y:32952,varname:node_1799,prsc:2|A-18-A,B-3214-OUT,C-672-A;n:type:ShaderForge.SFN_Log,id:2498,x:31263,y:32741,varname:node_2498,prsc:2,lt:0|IN-1706-OUT;n:type:ShaderForge.SFN_Divide,id:7538,x:31562,y:32702,varname:node_7538,prsc:2|A-1377-OUT,B-2498-OUT;n:type:ShaderForge.SFN_Vector1,id:1377,x:31220,y:32658,varname:node_1377,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:1706,x:31100,y:32804,varname:node_1706,prsc:2|A-4310-OUT,B-9584-OUT;n:type:ShaderForge.SFN_Vector1,id:9584,x:30919,y:32944,varname:node_9584,prsc:2,v1:10;n:type:ShaderForge.SFN_Divide,id:4310,x:30919,y:32748,varname:node_4310,prsc:2|A-5890-OUT,B-3758-XYZ;n:type:ShaderForge.SFN_Vector1,id:5890,x:30697,y:32637,varname:node_5890,prsc:2,v1:1;proporder:672-1264-4648;pass:END;sub:END;*/

Shader "Custom/S_Wave" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _DBSize ("DBSize", Range(0, 1)) = 1
        _FSize ("FSize", Range(0, 5)) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
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
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
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
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
////// Lighting:
////// Emissive:
                float node_7990 = 0.5;
                float node_2691_if_leA = step(pow(1.0-max(0,dot(normalDirection, viewDirection)),(_FSize*(1.0/log(((1.0/objScale)*10.0))))),node_7990);
                float node_2691_if_leB = step(node_7990,pow(1.0-max(0,dot(normalDirection, viewDirection)),(_FSize*(1.0/log(((1.0/objScale)*10.0))))));
                float node_806 = 0.0;
                float node_9095 = 1.0;
                float node_1229_if_leA = step(saturate((sceneZ-partZ)/_DBSize),node_7990);
                float node_1229_if_leB = step(node_7990,saturate((sceneZ-partZ)/_DBSize));
                float node_3214 = saturate((lerp((node_2691_if_leA*node_806)+(node_2691_if_leB*node_9095),node_806,node_2691_if_leA*node_2691_if_leB)+lerp((node_1229_if_leA*node_9095)+(node_1229_if_leB*node_806),node_9095,node_1229_if_leA*node_1229_if_leB)));
                float3 emissive = (_Color.rgb*_Color.a*i.vertexColor.rgb*i.vertexColor.a*node_3214);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,(i.vertexColor.a*node_3214*_Color.a));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
