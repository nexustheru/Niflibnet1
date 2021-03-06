﻿<Serializable()> Public Class Enums
    Public Enum endiantype As Byte
        ENDIAN_BIG
        ENDIAN_LITTLE
    End Enum
    Public Enum HavokMaterial As UInteger
        HAV_MAT_STONE
        HAV_MAT_CLOTH
        HAV_MAT_DIRT
        HAV_MAT_GLASS
        HAV_MAT_GRASS
        HAV_MAT_METAL
        HAV_MAT_ORGANIC
        HAV_MAT_SKIN
        HAV_MAT_WATER
        HAV_MAT_WOOD
        HAV_MAT_HEAVY_STONE
        HAV_MAT_HEAVY_METAL
        HAV_MAT_HEAVY_WOOD
        HAV_MAT_CHAIN
        HAV_MAT_SNOW
        HAV_MAT_STONE_STAIRS
        HAV_MAT_CLOTH_STAIRS
        HAV_MAT_DIRT_STAIRS
        HAV_MAT_GLASS_STAIRS
        HAV_MAT_GRASS_STAIRS
        HAV_MAT_METAL_STAIRS
        HAV_MAT_ORGANIC_STAIRS
        HAV_MAT_SKIN_STAIRS
        HAV_MAT_WATER_STAIRS
        HAV_MAT_WOOD_STAIRS
        HAV_MAT_HEAVY_STONE_STAIRS
        HAV_MAT_HEAVY_METAL_STAIRS
        HAV_MAT_HEAVY_WOOD_STAIRS
        HAV_MAT_CHAIN_STAIRS
        HAV_MAT_SNOW_STAIRS
        HAV_MAT_ELEVATOR
        HAV_MAT_RUBBER
    End Enum
    Public Enum BodyPartslist As UInteger
        BP_TORSO
        BP_HEAD
        BP_HEAD2
        BP_LEFTARM
        BP_LEFTARM2
        BP_RIGHTARM
        BP_RIGHTARM2
        BP_LEFTLEG
        BP_LEFTLEG2
        BP_LEFTLEG3
        BP_RIGHTLEG
        BP_RIGHTLEG2
        BP_RIGHTLEG3
        BP_BRAIN
        BP_SKY_AMULET
        BP_SKY_ARM
        BP_SKY_ARM_1
        BP_SKY_BACK
        BP_SKY_BLOODIED_DRAGON_HEADS
        BP_SKY_BLOODIED_DRAGON_HEADS_1
        BP_SKY_BLOODIED_DRAGON_HEADS_2
        BP_SKY_BODY
        BP_SKY_CALVES
        BP_SKY_CHEST
        BP_SKY_CHEST_1
        BP_SKY_CIRCLET
        BP_SKY_CIRCLETS_ACCESOARIES
        BP_SKY_DECAPITATE
        BP_SKY_DECAPITATED_HEAD
        BP_SKY_DISABLE_EAR_HEADPART
        BP_SKY_DISABLE_HAIR_HEADPART
        BP_SKY_EARS
        BP_SKY_FACE
        BP_SKY_FACE_MOUTH
        BP_SKY_FEET
        BP_SKY_FOREARMS
        BP_SKY_FX01
        BP_SKY_GORE_COVERS_HEAD_NECK
        BP_SKY_HAIR
        BP_SKY_HAND
        BP_SKY_HEAD
        BP_SKY_HELMET
        BP_SKY_LEG
        BP_SKY_LEG_1
        BP_SKY_LONG_HAIR
        BP_SKY_MISC_FX
        BP_SKY_MISC_FX_1
        BP_SKY_NECK
        BP_SKY_NECK_DECAPITATION_POINT
        BP_SKY_OPEN_FACE_HELMET
        BP_SKY_PELVIS
        BP_SKY_PELVIS_1
        BP_SKY_RING
        BP_SKY_SHIELD
        BP_SKY_SHOULDER
        BP_SKY_TAIL
        BP_SECTIONCAP_HEAD
        BP_SECTIONCAP_HEAD2
        BP_SECTIONCAP_LEFTARM
        BP_SECTIONCAP_LEFTARM2
        BP_SECTIONCAP_RIGHTARM
        BP_SECTIONCAP_RIGHTARM2
        BP_SECTIONCAP_LEFTLEG
        BP_SECTIONCAP_LEFTLEG2
        BP_SECTIONCAP_LEFTLEG3
        BP_SECTIONCAP_RIGHTLEG
        BP_SECTIONCAP_RIGHTLEG2
        BP_SECTIONCAP_RIGHTLEG3
        BP_SECTIONCAP_BRAIN
        BP_TORSOCAP_HEAD
        BP_TORSOCAP_HEAD2
        BP_TORSOCAP_LEFTARM
        BP_TORSOCAP_LEFTARM2
        BP_TORSOCAP_RIGHTARM
        BP_TORSOCAP_RIGHTARM2
        BP_TORSOCAP_LEFTLEG
        BP_TORSOCAP_LEFTLEG2
        BP_TORSOCAP_LEFTLEG3
        BP_TORSOCAP_RIGHTLEG
        BP_TORSOCAP_RIGHTLEG2
        BP_TORSOCAP_RIGHTLEG3
        BP_TORSOCAP_BRAIN
        BP_TORSOSECTION_HEAD
        BP_TORSOSECTION_HEAD2
        BP_TORSOSECTION_LEFTARM
        BP_TORSOSECTION_LEFTARM2
        BP_TORSOSECTION_RIGHTARM
        BP_TORSOSECTION_RIGHTARM2
        BP_TORSOSECTION_LEFTLEG
        BP_TORSOSECTION_LEFTLEG2
        BP_TORSOSECTION_LEFTLEG3
        BP_TORSOSECTION_RIGHTLEG
        BP_TORSOSECTION_RIGHTLEG2
        BP_TORSOSECTION_RIGHTLEG3
        BP_TORSOSECTION_BRAIN
    End Enum
    Public Enum WaterShaderFlags As UInteger
        SWSF1_UNKNOWN0
        SWSF1_BYPASS_REFRACTION_MAP
        SWSF1_WATER_TOGGLE
        SWSF1_UNKNOWN3
        SWSF1_UNKNOWN4
        SWSF1_UNKNOWN5
        cSWSF1_HIGHLIGHT_LAYER_TOGGLE
        SWSF1_ENABLED
    End Enum
    Public Enum shaderpropertyflags As UInteger
        SF_SPECULAR
        SF_SKINNED
        SF_LOWDETAIL
        SF_VERTEX_ALPHA
        SF_UNKNOWN_1
        SF_SINGLE_PASS
        SF_EMPTY
        SF_ENVIRONMENT_MAPPING
        SF_ALPHA_TEXTURE
        SF_UNKNOWN_2
        SF_FACEGEN
        SF_PARALLAX_SHADER_INDEX_15
        SF_UNKNOWN_3
        SF_NON_PROJECTIVE_SHADOWS
        SF_UNKNOWN_4
        SF_REFRACTION
        SF_FIRE_REFRACTION
        SF_EYE_ENVIRONMENT_MAPPING
        SF_HAIR
        SF_DYNAMIC_ALPHA
        SF_LOCALMAP_HIDE_SECRET
        SF_WINDOW_ENVIRONMENT_MAPPING
        SF_TREE_BILLBOARD
        SF_SHADOW_FRUSTUM
        SF_MULTIPLE_TEXTURES
        SF_REMAPPABLE_TEXTURES
        SF_DECAL_SINGLE_PASS
        SF_DYNAMIC_DECAL_SINGLE_PASS
        SF_PARALLAX_OCCULSION
        SF_EXTERNAL_EMITTANCE
        SF_SHADOW_MAP
        SF_ZBUFFER_TEST
    End Enum
    Public Enum shaderpropertyflags1 As UInteger
        SLSF1_SPECULAR
        SLSF1_SKINNED
        SLSF1_TEMP_REFRACTION
        SLSF1_VERTEX_ALPHA
        SLSF1_GREYSCALE_TO_PALETTECOLOR
        SLSF1_GREYSCALE_TO_PALETTEALPHA
        SLSF1_USE_FALLOFF
        SLSF1_ENVIRONMENT_MAPPING
        SLSF1_RECIEVE_SHADOWS
        SLSF1_CAST_SHADOWS
        SLSF1_FACEGEN_DETAIL_MAP
        SLSF1_PARALLAX
        SLSF1_MODEL_SPACE_NORMALS
        SLSF1_NON_PROJECTIVE_SHADOWS
        SLSF1_LANDSCAPE
        SLSF1_REFRACTION
        SLSF1_FIRE_REFRACTION
        SLSF1_EYE_ENVIRONMENT_MAPPING
        SLSF1_HAIR_SOFT_LIGHTING
        SLSF1_SCREENDOOR_ALPHA_FADE
        SLSF1_LOCALMAP_HIDE_SECRET
        SLSF1_FACEGEN_RGB_TINT
        SLSF1_OWN_EMIT
        SLSF1_PROJECTED_UV
        SLSF1_MULTIPLE_TEXTURES
        SLSF1_REMAPPABLE_TEXTURES
        SLSF1_DECAL
        SLSF1_DYNAMIC_DECAL
        SLSF1_PARALLAX_OCCLUSION
        SLSF1_EXTERNAL_EMITTANCE
        SLSF1_SOFT_EFFECT
        SLSF1_ZBUFFER_TEST

    End Enum
    Public Enum BSShaderType As UInteger
        SHADER_TALL_GRASS
        SHADER_DEFAULT
        SHADER_SKY
        SHADER_SKIN
        SHADER_WATER
        SHADER_LIGHTING30
        SHADER_TILE
        SHADER_NOLIGHTING
    End Enum
    Public Enum ConsistencyType
        CT_MUTABLE
        CT_STATIC
        CT_VOLATILE
    End Enum
    Public Enum collisiontypes As UInteger
        CT_NONE
        CT_TRIANGLES
        CT_BOUNDINGBOX
        CT_CONTINUE
    End Enum
End Class
