// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9950,x:33783,y:32565,varname:node_9950,prsc:2|emission-249-OUT,alpha-1799-OUT;n:type:ShaderForge.SFN_DepthBlend,id:8080,x:31653,y:32918,varname:node_8080,prsc:2|DIST-1264-OUT;n:type:ShaderForge.SFN_Slider,id:1264,x:31342,y:32918,ptovrint:False,ptlb:DB Size,ptin:_DBSize,varname:_DBSize,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:5;n:type:ShaderForge.SFN_Color,id:672,x:32850,y:32283,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Fresnel,id:738,x:31992,y:32520,varname:node_738,prsc:2|EXP-8800-OUT;n:type:ShaderForge.SFN_Slider,id:4648,x:31335,y:32537,ptovrint:False,ptlb:F Size,ptin:_FSize,varname:_FSize,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:5;n:type:ShaderForge.SFN_If,id:2691,x:32457,y:32645,varname:node_2691,prsc:2|A-9693-OUT,B-7990-OUT,GT-9693-OUT,EQ-7990-OUT,LT-7990-OUT;n:type:ShaderForge.SFN_Vector1,id:7990,x:32065,y:32777,varname:node_7990,prsc:2,v1:0;n:type:ShaderForge.SFN_If,id:1229,x:32472,y:32904,varname:node_1229,prsc:2|A-711-OUT,B-7990-OUT,GT-711-OUT,EQ-7990-OUT,LT-7990-OUT;n:type:ShaderForge.SFN_Multiply,id:5754,x:33348,y:32638,varname:node_5754,prsc:2|A-672-RGB,B-672-A,C-18-RGB,D-18-A,E-4408-OUT;n:type:ShaderForge.SFN_VertexColor,id:18,x:32850,y:32434,varname:node_18,prsc:2;n:type:ShaderForge.SFN_ObjectScale,id:3758,x:30631,y:32767,varname:node_3758,prsc:2,rcp:False;n:type:ShaderForge.SFN_Multiply,id:8800,x:31764,y:32582,varname:node_8800,prsc:2|A-4648-OUT,B-7538-OUT;n:type:ShaderForge.SFN_Multiply,id:1799,x:33336,y:32901,varname:node_1799,prsc:2|A-18-A,B-4408-OUT,C-672-A;n:type:ShaderForge.SFN_Log,id:2498,x:31263,y:32741,varname:node_2498,prsc:2,lt:0|IN-1706-OUT;n:type:ShaderForge.SFN_Divide,id:7538,x:31562,y:32702,varname:node_7538,prsc:2|A-1377-OUT,B-2498-OUT;n:type:ShaderForge.SFN_Vector1,id:1377,x:31220,y:32658,varname:node_1377,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:1706,x:31100,y:32804,varname:node_1706,prsc:2|A-4310-OUT,B-9584-OUT;n:type:ShaderForge.SFN_Vector1,id:9584,x:30919,y:32944,varname:node_9584,prsc:2,v1:10;n:type:ShaderForge.SFN_Divide,id:4310,x:30919,y:32748,varname:node_4310,prsc:2|A-5890-OUT,B-3758-XYZ;n:type:ShaderForge.SFN_Vector1,id:5890,x:30697,y:32637,varname:node_5890,prsc:2,v1:1;n:type:ShaderForge.SFN_RemapRange,id:9693,x:32155,y:32520,varname:node_9693,prsc:2,frmn:0.5,frmx:1,tomn:0,tomx:1|IN-738-OUT;n:type:ShaderForge.SFN_RemapRange,id:711,x:32037,y:32920,varname:node_711,prsc:2,frmn:0.5,frmx:1,tomn:0,tomx:1|IN-423-OUT;n:type:ShaderForge.SFN_OneMinus,id:423,x:31840,y:32920,varname:node_423,prsc:2|IN-8080-OUT;n:type:ShaderForge.SFN_Max,id:4680,x:32672,y:32803,varname:node_4680,prsc:2|A-2691-OUT,B-1229-OUT;n:type:ShaderForge.SFN_ScreenPos,id:1326,x:31776,y:33244,varname:node_1326,prsc:2,sctp:1;n:type:ShaderForge.SFN_Tex2dAsset,id:2550,x:32027,y:33459,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:_Noise,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:772,x:32250,y:33325,varname:node_772,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-6969-OUT,TEX-2550-TEX;n:type:ShaderForge.SFN_Multiply,id:4408,x:32945,y:32965,varname:node_4408,prsc:2|A-4680-OUT,B-3652-OUT;n:type:ShaderForge.SFN_Add,id:3841,x:32604,y:33218,varname:node_3841,prsc:2|A-8670-OUT,B-6038-OUT;n:type:ShaderForge.SFN_Slider,id:3451,x:32037,y:33165,ptovrint:False,ptlb:Noise Intensity,ptin:_NoiseIntensity,varname:_NoiseIntensity,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Clamp01,id:6038,x:32443,y:33325,varname:node_6038,prsc:2|IN-772-R;n:type:ShaderForge.SFN_Clamp01,id:3652,x:32758,y:33108,varname:node_3652,prsc:2|IN-3841-OUT;n:type:ShaderForge.SFN_OneMinus,id:8670,x:32356,y:33155,varname:node_8670,prsc:2|IN-3451-OUT;n:type:ShaderForge.SFN_Add,id:6969,x:32027,y:33299,varname:node_6969,prsc:2|A-1326-UVOUT,B-6971-OUT;n:type:ShaderForge.SFN_Multiply,id:6971,x:31792,y:33433,varname:node_6971,prsc:2|A-8999-OUT,B-3251-T;n:type:ShaderForge.SFN_Time,id:3251,x:31514,y:33538,varname:node_3251,prsc:2;n:type:ShaderForge.SFN_Append,id:8999,x:31514,y:33375,varname:node_8999,prsc:2|A-7446-OUT,B-2559-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7446,x:31328,y:33338,ptovrint:False,ptlb:U Speed,ptin:_USpeed,varname:node_7446,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:2559,x:31328,y:33424,ptovrint:False,ptlb:V Speed,ptin:_VSpeed,varname:node_2559,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Multiply,id:249,x:33562,y:32623,varname:node_249,prsc:2|A-9295-OUT,B-5754-OUT;n:type:ShaderForge.SFN_Slider,id:9295,x:33239,y:32496,ptovrint:False,ptlb:Emission Intensity,ptin:_EmissionIntensity,varname:node_9295,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;proporder:672-1264-4648-2550-3451-2559-7446-9295;pass:END;sub:END;*/

Shader "Custom/S_Wave" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _DBSize ("DB Size", Range(0, 5)) = 1
        _FSize ("F Size", Range(0, 5)) = 1
        _Noise ("Noise", 2D) = "white" {}
        _NoiseIntensity ("Noise Intensity", Range(0, 1)) = 0.5
        _VSpeed ("V Speed", Float ) = 0.1
        _USpeed ("U Speed", Float ) = 0.1
        _EmissionIntensity ("Emission Intensity", Range(0, 10)) = 0
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
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _TimeEditor;
            uniform float _DBSize;
            uniform float4 _Color;
            uniform float _FSize;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float _NoiseIntensity;
            uniform float _USpeed;
            uniform float _VSpeed;
            uniform float _EmissionIntensity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float4 screenPos : TEXCOORD2;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD3;
                UNITY_FOG_COORDS(4)
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
                o.screenPos = o.pos;
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 recipObjScale = float3( length(unity_WorldToObject[0].xyz), length(unity_WorldToObject[1].xyz), length(unity_WorldToObject[2].xyz) );
                float3 objScale = 1.0/recipObjScale;
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
////// Lighting:
////// Emissive:
                float node_9693 = (pow(1.0-max(0,dot(normalDirection, viewDirection)),(_FSize*(1.0/log(((1.0/objScale)*10.0)))))*2.0+-1.0);
                float node_7990 = 0.0;
                float node_2691_if_leA = step(node_9693,node_7990);
                float node_2691_if_leB = step(node_7990,node_9693);
                float node_711 = ((1.0 - saturate((sceneZ-partZ)/_DBSize))*2.0+-1.0);
                float node_1229_if_leA = step(node_711,node_7990);
                float node_1229_if_leB = step(node_7990,node_711);
                float4 node_3251 = _Time + _TimeEditor;
                float2 node_6969 = (float2(i.screenPos.x*(_ScreenParams.r/_ScreenParams.g), i.screenPos.y).rg+(float2(_USpeed,_VSpeed)*node_3251.g));
                float4 node_772 = tex2D(_Noise,TRANSFORM_TEX(node_6969, _Noise));
                float node_4408 = (max(lerp((node_2691_if_leA*node_7990)+(node_2691_if_leB*node_9693),node_7990,node_2691_if_leA*node_2691_if_leB),lerp((node_1229_if_leA*node_7990)+(node_1229_if_leB*node_711),node_7990,node_1229_if_leA*node_1229_if_leB))*saturate(((1.0 - _NoiseIntensity)+saturate(node_772.r))));
                float3 emissive = (_EmissionIntensity*(_Color.rgb*_Color.a*i.vertexColor.rgb*i.vertexColor.a*node_4408));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,(i.vertexColor.a*node_4408*_Color.a));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
