// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:488,x:32768,y:32716,varname:node_488,prsc:2|diff-8524-OUT,spec-6290-OUT,gloss-3059-OUT,normal-4114-RGB,alpha-8874-OUT,voffset-8105-OUT;n:type:ShaderForge.SFN_Color,id:604,x:31519,y:32335,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_604,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Slider,id:3059,x:32240,y:32782,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_3059,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Vector1,id:6290,x:32600,y:32747,varname:node_6290,prsc:2,v1:0;n:type:ShaderForge.SFN_Tex2d,id:6060,x:31484,y:33340,ptovrint:False,ptlb:node_6060,ptin:_node_6060,varname:node_6060,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-4660-OUT;n:type:ShaderForge.SFN_Multiply,id:8105,x:31844,y:33299,varname:node_8105,prsc:2|A-4108-OUT,B-6060-RGB,C-4792-OUT;n:type:ShaderForge.SFN_NormalVector,id:4108,x:31484,y:33154,prsc:2,pt:False;n:type:ShaderForge.SFN_ValueProperty,id:4792,x:31484,y:33545,ptovrint:False,ptlb:node_4792,ptin:_node_4792,varname:node_4792,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:2673,x:31071,y:33246,varname:node_2673,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:4660,x:31266,y:33319,varname:node_4660,prsc:2|A-2673-UVOUT,B-7444-OUT;n:type:ShaderForge.SFN_Multiply,id:7444,x:31071,y:33416,varname:node_7444,prsc:2|A-7224-OUT,B-2885-T;n:type:ShaderForge.SFN_Append,id:7224,x:30838,y:33331,varname:node_7224,prsc:2|A-3485-OUT,B-2161-OUT;n:type:ShaderForge.SFN_Time,id:2885,x:30813,y:33496,varname:node_2885,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:3485,x:30590,y:33331,ptovrint:False,ptlb:node_3485,ptin:_node_3485,varname:node_3485,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:2161,x:30590,y:33410,ptovrint:False,ptlb:node_2161,ptin:_node_2161,varname:node_2161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_DepthBlend,id:1501,x:31343,y:32650,varname:node_1501,prsc:2|DIST-4090-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4090,x:31117,y:32650,ptovrint:False,ptlb:node_4090,ptin:_node_4090,varname:node_4090,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Lerp,id:5527,x:31865,y:32405,varname:node_5527,prsc:2|A-3872-RGB,B-604-RGB,T-3460-OUT;n:type:ShaderForge.SFN_Color,id:3872,x:31366,y:32479,ptovrint:False,ptlb:node_3872,ptin:_node_3872,varname:node_3872,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_If,id:3460,x:31637,y:32663,varname:node_3460,prsc:2|A-1501-OUT,B-3016-OUT,GT-2516-OUT,EQ-3483-OUT,LT-3483-OUT;n:type:ShaderForge.SFN_Vector1,id:3016,x:31343,y:32796,varname:node_3016,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:3483,x:31343,y:32898,varname:node_3483,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:2516,x:31343,y:32847,varname:node_2516,prsc:2,v1:1;n:type:ShaderForge.SFN_Tex2d,id:4114,x:31699,y:32950,ptovrint:False,ptlb:node_4114,ptin:_node_4114,varname:node_4114,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Vector1,id:8874,x:32318,y:33013,varname:node_8874,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:8524,x:32429,y:32573,varname:node_8524,prsc:2|A-5527-OUT,B-81-OUT;n:type:ShaderForge.SFN_Add,id:6888,x:31916,y:32871,varname:node_6888,prsc:2|A-6680-OUT,B-4114-RGB;n:type:ShaderForge.SFN_Clamp01,id:81,x:32086,y:32741,varname:node_81,prsc:2|IN-6888-OUT;n:type:ShaderForge.SFN_Slider,id:6680,x:31597,y:32859,ptovrint:False,ptlb:node_6680,ptin:_node_6680,varname:node_6680,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:604-3059-6060-4792-3485-2161-4090-3872-4114-6680;pass:END;sub:END;*/

Shader "Custom/S_Water" {
    Properties {
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _Gloss ("Gloss", Range(0, 1)) = 0
        _node_6060 ("node_6060", 2D) = "white" {}
        _node_4792 ("node_4792", Float ) = 0
        _node_3485 ("node_3485", Float ) = 0
        _node_2161 ("node_2161", Float ) = 0
        _node_4090 ("node_4090", Float ) = 0
        _node_3872 ("node_3872", Color) = (0.5,0.5,0.5,1)
        _node_4114 ("node_4114", 2D) = "white" {}
        _node_6680 ("node_6680", Range(0, 1)) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
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
            #pragma glsl
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _Gloss;
            uniform sampler2D _node_6060; uniform float4 _node_6060_ST;
            uniform float _node_4792;
            uniform float _node_3485;
            uniform float _node_2161;
            uniform float _node_4090;
            uniform float4 _node_3872;
            uniform sampler2D _node_4114; uniform float4 _node_4114_ST;
            uniform float _node_6680;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_2885 = _Time + _TimeEditor;
                float2 node_4660 = (o.uv0+(float2(_node_3485,_node_2161)*node_2885.g));
                float4 _node_6060_var = tex2Dlod(_node_6060,float4(TRANSFORM_TEX(node_4660, _node_6060),0.0,0));
                v.vertex.xyz += (v.normal*_node_6060_var.rgb*_node_4792);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 _node_4114_var = tex2D(_node_4114,TRANSFORM_TEX(i.uv0, _node_4114));
                float3 normalLocal = _node_4114_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float specPow = exp2( gloss * 10.0+1.0);
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float node_3460_if_leA = step(saturate((sceneZ-partZ)/_node_4090),0.5);
                float node_3460_if_leB = step(0.5,saturate((sceneZ-partZ)/_node_4090));
                float node_3483 = 0.0;
                float3 diffuseColor = (lerp(_node_3872.rgb,_Color.rgb,lerp((node_3460_if_leA*node_3483)+(node_3460_if_leB*1.0),node_3483,node_3460_if_leA*node_3460_if_leB))*saturate((_node_6680+_node_4114_var.rgb))); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, GGXTerm(NdotH, 1.0-gloss));
                float specularPBL = (NdotL*visTerm*normTerm) * (UNITY_PI / 4);
                if (IsGammaSpace())
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                specularPBL = max(0, specularPBL * NdotL);
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz)*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor,1.0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _Gloss;
            uniform sampler2D _node_6060; uniform float4 _node_6060_ST;
            uniform float _node_4792;
            uniform float _node_3485;
            uniform float _node_2161;
            uniform float _node_4090;
            uniform float4 _node_3872;
            uniform sampler2D _node_4114; uniform float4 _node_4114_ST;
            uniform float _node_6680;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_2885 = _Time + _TimeEditor;
                float2 node_4660 = (o.uv0+(float2(_node_3485,_node_2161)*node_2885.g));
                float4 _node_6060_var = tex2Dlod(_node_6060,float4(TRANSFORM_TEX(node_4660, _node_6060),0.0,0));
                v.vertex.xyz += (v.normal*_node_6060_var.rgb*_node_4792);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 _node_4114_var = tex2D(_node_4114,TRANSFORM_TEX(i.uv0, _node_4114));
                float3 normalLocal = _node_4114_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float node_3460_if_leA = step(saturate((sceneZ-partZ)/_node_4090),0.5);
                float node_3460_if_leB = step(0.5,saturate((sceneZ-partZ)/_node_4090));
                float node_3483 = 0.0;
                float3 diffuseColor = (lerp(_node_3872.rgb,_Color.rgb,lerp((node_3460_if_leA*node_3483)+(node_3460_if_leB*1.0),node_3483,node_3460_if_leA*node_3460_if_leB))*saturate((_node_6680+_node_4114_var.rgb))); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, GGXTerm(NdotH, 1.0-gloss));
                float specularPBL = (NdotL*visTerm*normTerm) * (UNITY_PI / 4);
                if (IsGammaSpace())
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                specularPBL = max(0, specularPBL * NdotL);
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1.0,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform sampler2D _node_6060; uniform float4 _node_6060_ST;
            uniform float _node_4792;
            uniform float _node_3485;
            uniform float _node_2161;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_2885 = _Time + _TimeEditor;
                float2 node_4660 = (o.uv0+(float2(_node_3485,_node_2161)*node_2885.g));
                float4 _node_6060_var = tex2Dlod(_node_6060,float4(TRANSFORM_TEX(node_4660, _node_6060),0.0,0));
                v.vertex.xyz += (v.normal*_node_6060_var.rgb*_node_4792);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
