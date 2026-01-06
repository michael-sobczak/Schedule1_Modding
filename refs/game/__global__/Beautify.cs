public class Beautify : VolumeComponent, IPostProcessComponent // TypeDefIndex: 9294
{
	// Fields
	[DisplayName("Disable Beautify Effects")]
	[GlobalOverride]
	[Tooltip("Ignore all Beautify effects. This option overrides any existing profile.")]
	[GeneralSettings]
	public BoolParameter disabled; // 0x38
	[GeneralSettings]
	[DisplayName("Enable Compare Mode")]
	[ToggleAllFields]
	[GlobalOverride]
	public BoolParameter compareMode; // 0x40
	[GeneralSettings]
	[DisplayName("Style")]
	[DisplayConditionBool("compareMode", True, null, True)]
	public Beautify.BeautifyCompareStyleParameter compareStyle; // 0x48
	[GeneralSettings]
	[DisplayName("Panning")]
	[DisplayConditionEnum("compareStyle", 0, False)]
	public ClampedFloatParameter comparePanning; // 0x50
	[GeneralSettings]
	[DisplayName("Angle")]
	[DisplayConditionBool("compareMode", True, "compareSameSide", False)]
	public FloatParameter compareLineAngle; // 0x58
	[GeneralSettings]
	[DisplayName("Line Width")]
	[DisplayConditionBool("compareMode", True, null, True)]
	public FloatParameter compareLineWidth; // 0x60
	[GlobalOverride]
	[GeneralSettings]
	[Tooltip("Inverts vertical orientation of image when blitting. This option can be used to overcome an issue in certain versions of URP.")]
	[DisplayName("Flip Vertically")]
	public BoolParameter flipY; // 0x68
	[GeneralSettings]
	[DisplayName("Hide In SceneView")]
	[GlobalOverride]
	public BoolParameter hideInSceneView; // 0x70
	[DisplayConditionBool("compareMode", False, null, True)]
	[DisplayName("Debug Output")]
	[GlobalOverride]
	[GeneralSettings]
	public Beautify.BeautifyDebugOutputParameter debugOutput; // 0x78
	[Performance]
	[DisplayName("Prioritize Shader Performance")]
	[GlobalOverride]
	[Tooltip("Sharpen, bloom and anamorphic flares will reduce quality a bit to improve performance. This option can be useful on less powerful platforms or devices.")]
	[GeneralSettings]
	public BoolParameter turboMode; // 0x80
	[GeneralSettings]
	[Performance]
	[DisplayName("Direct Write To Camera")]
	[GlobalOverride]
	[Tooltip("Writes result directly to camera target saving intermediate blits. This option will overwrite any previous post-processing effects so make sure there's no other effects being executed besides Beautify.")]
	public BoolParameter directWrite; // 0x88
	[GeneralSettings]
	[Performance]
	[DisplayName("Downsampling")]
	[GlobalOverride]
	[Tooltip("Reduces camera target before applying Beautify effects This option can contribute to compensate render scale if it's set to greater than 1 or to improve performance.")]
	public BoolParameter downsampling; // 0x90
	[GeneralSettings]
	[Performance]
	[DisplayName("Mode")]
	[GlobalOverride]
	[Tooltip("How downsampling is applied.")]
	[DisplayConditionBool("downsampling", True, null, True)]
	public Beautify.BeautifyDownsamplingModeParameter downsamplingMode; // 0x98
	[GeneralSettings]
	[DisplayName("Multiplier")]
	[GlobalOverride]
	[Tooltip("Downsampling multiplier.")]
	[DisplayConditionBool("downsampling", True, null, True)]
	[Performance]
	public ClampedFloatParameter downsamplingMultiplier; // 0xA0
	[GeneralSettings]
	[Performance]
	[DisplayName("Bilinear Filtering")]
	[GlobalOverride]
	[Tooltip("Enables bilinear filtering when using downsampling.")]
	[DisplayConditionBool("downsampling", True, null, True)]
	public BoolParameter downsamplingBilinear; // 0xA8
	[DisplayName("Automatically Strip Unused Features")]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile any shader features not active in the inspector, reducing build time.")]
	public BoolParameter optimizeBuildBeautifyAuto; // 0xB0
	[GeneralSettings]
	[BuildToggle]
	[GlobalOverride]
	[Tooltip("Do not compile tonemapping shader feature, reducing build time.")]
	[DisplayName("Strip Tonemapping")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[OptimizeBeautifyBuild]
	public BoolParameter stripBeautifyTonemapping; // 0xB8
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Sharpen")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile sharpen shader feature, reducing build time.")]
	public BoolParameter stripBeautifySharpen; // 0xC0
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Dithering")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile dithering shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	public BoolParameter stripBeautifyDithering; // 0xC8
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Edge Antialiasing")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile edge antialiasing shader feature, reducing build time.")]
	public BoolParameter stripBeautifyEdgeAA; // 0xD0
	[BuildToggle]
	[Tooltip("Do not compile LUT shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[GlobalOverride]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	[DisplayName("Strip LUT")]
	public BoolParameter stripBeautifyLUT; // 0xD8
	[Tooltip("Do not compile LUT 3D shader feature, reducing build time.")]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[GlobalOverride]
	[DisplayName("Strip LUT 3D")]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	public BoolParameter stripBeautifyLUT3D; // 0xE0
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile White Balance shader feature, reducing build time.")]
	[BuildToggle]
	[DisplayName("Strip Sepia, Daltonize & White Balance")]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	[GlobalOverride]
	public BoolParameter stripBeautifyColorTweaks; // 0xE8
	[BuildToggle]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Bloom, Anamorphic & Sun Flares")]
	[GlobalOverride]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile Bloom, Anamorphic & Sun Flares shader features, reducing build time.")]
	public BoolParameter stripBeautifyBloom; // 0xF0
	[Tooltip("Do not compile Lens Dirt shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[BuildToggle]
	[GlobalOverride]
	[DisplayName("Strip Lens Dirt")]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	public BoolParameter stripBeautifyLensDirt; // 0xF8
	[GeneralSettings]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile Chromatic Aberration shader feature, reducing build time.")]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Chromatic Aberration")]
	public BoolParameter stripBeautifyChromaticAberration; // 0x100
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Depth of Field")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile Depth Of Field shader feature, reducing build time.")]
	[GeneralSettings]
	public BoolParameter stripBeautifyDoF; // 0x108
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Depth of Field Transparent Support")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile Depth Of Field transparency support shader feature, reducing build time.")]
	public BoolParameter stripBeautifyDoFTransparentSupport; // 0x110
	[GlobalOverride]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Eye Adaptation")]
	[Tooltip("Do not compile Purkinje Shift shader feature, reducing build time.")]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	public BoolParameter stripBeautifyEyeAdaptation; // 0x118
	[Tooltip("Do not compile Purkinje Shift shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[GlobalOverride]
	[DisplayName("Strip Purkinje Shift")]
	[OptimizeBeautifyBuild]
	[GeneralSettings]
	[BuildToggle]
	public BoolParameter stripBeautifyPurkinje; // 0x120
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Vignetting")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile Vignetting shader features, reducing build time.")]
	[GeneralSettings]
	public BoolParameter stripBeautifyVignetting; // 0x128
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile Outline shader feature, reducing build time.")]
	[GeneralSettings]
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Outline")]
	[GlobalOverride]
	[BuildToggle]
	public BoolParameter stripBeautifyOutline; // 0x130
	[OptimizeBeautifyBuild]
	[DisplayName("Strip Night Vision")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile Night Vision shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[GeneralSettings]
	public BoolParameter stripBeautifyNightVision; // 0x138
	[OptimizeBeautifyBuild]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[Tooltip("Do not compile Thermal Vision shader feature, reducing build time.")]
	[GeneralSettings]
	[DisplayName("Strip Thermal Vision")]
	public BoolParameter stripBeautifyThermalVision; // 0x140
	[DisplayConditionBool("optimizeBuildBeautifyAuto", False, null, True)]
	[GeneralSettings]
	[DisplayName("Strip Frame")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile Frame shader features, reducing build time.")]
	[OptimizeBeautifyBuild]
	public BoolParameter stripBeautifyFrame; // 0x148
	[DisplayName("Strip All")]
	[GeneralSettings]
	[OptimizeUnityPostProcessingBuild]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile Unity Post Processing shader features, reducing build time.")]
	public BoolParameter optimizeBuildUnityPPSAuto; // 0x150
	[BuildToggle]
	[GeneralSettings]
	[OptimizeUnityPostProcessingBuild]
	[DisplayName("Strip Film Grain")]
	[GlobalOverride]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", False, null, True)]
	[Tooltip("Do not compile Unity Post Processing's Film Grain shader feature, reducing build time.")]
	public BoolParameter stripUnityFilmGrain; // 0x158
	[Tooltip("Do not compile Unity Post Processing's Dithering shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", False, null, True)]
	[BuildToggle]
	[GlobalOverride]
	[OptimizeUnityPostProcessingBuild]
	[GeneralSettings]
	[DisplayName("Strip Dithering")]
	public BoolParameter stripUnityDithering; // 0x160
	[Tooltip("Do not compile Unity Post Processing's Tonemapping shader feature, reducing build time.")]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", False, null, True)]
	[BuildToggle]
	[GlobalOverride]
	[OptimizeUnityPostProcessingBuild]
	[GeneralSettings]
	[DisplayName("Strip Tonemapping")]
	public BoolParameter stripUnityTonemapping; // 0x168
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", False, null, True)]
	[GeneralSettings]
	[OptimizeUnityPostProcessingBuild]
	[DisplayName("Strip Bloom")]
	[GlobalOverride]
	[BuildToggle]
	[Tooltip("Do not compile Unity Post Processing's Bloom shader feature, reducing build time.")]
	public BoolParameter stripUnityBloom; // 0x170
	[GeneralSettings]
	[DisplayName("Strip Chromatic Aberration")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", False, null, True)]
	[OptimizeUnityPostProcessingBuild]
	[Tooltip("Do not compile Unity Post Processing's Chromatic Aberration shader feature, reducing build time.")]
	public BoolParameter stripUnityChromaticAberration; // 0x178
	[GeneralSettings]
	[DisplayName("Strip Distortion")]
	[GlobalOverride]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", False, null, True)]
	[Tooltip("Do not compile Unity Post Processing's Screen Distortion features, reducing build time.")]
	[OptimizeUnityPostProcessingBuild]
	public BoolParameter stripUnityDistortion; // 0x180
	[GeneralSettings]
	[DisplayName("Strip Debug Variants")]
	[BuildToggle]
	[DisplayConditionBool("optimizeBuildUnityPPSAuto", False, null, True)]
	[Tooltip("Do not compile Unity Post Processing's debug variants, reducing build time.")]
	[GlobalOverride]
	[OptimizeUnityPostProcessingBuild]
	public BoolParameter stripUnityDebugVariants; // 0x188
	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Intensity")]
	[DisplayConditionBool("stripBeautifySharpen", False, null, True)]
	[ShowStrippedLabel]
	public ClampedFloatParameter sharpenIntensity; // 0x190
	[Tooltip("By default, sharpen ignores edges to avoid aliasing. Increase this property to also include edges. Edge detection is based on scene depth.")]
	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Depth Threshold")]
	[DisplayConditionBool("turboMode", False, null, True)]
	public ClampedFloatParameter sharpenDepthThreshold; // 0x198
	[Sharpen]
	[DisplayName("Depth Range")]
	[DisplayConditionBool("turboMode", False, null, True)]
	[ImageEnhancement]
	[Tooltip("Restricts sharpen to a scene depth range.")]
	public Beautify.MinMaxFloatParameter sharpenMinMaxDepth; // 0x1A0
	[DisplayName("Depth Range FallOff")]
	[ImageEnhancement]
	[DisplayConditionBool("turboMode", False, null, True)]
	[Sharpen]
	public ClampedFloatParameter sharpenMinMaxDepthFallOff; // 0x1A8
	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Relaxation")]
	[Tooltip("Reduces sharpen intensity based on area brightness.")]
	public ClampedFloatParameter sharpenRelaxation; // 0x1B0
	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Clamp")]
	[Tooltip("Reduces final sharpen modifier.")]
	public ClampedFloatParameter sharpenClamp; // 0x1B8
	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Motion Sensibility")]
	[Tooltip("Reduces sharpen gracefully when camera moves or rotates. This setting reduces flickering while contributes to a motion blur sense.")]
	public ClampedFloatParameter sharpenMotionSensibility; // 0x1C0
	[ImageEnhancement]
	[Sharpen]
	[DisplayName("Motion Restore Speed")]
	[Tooltip("The speed at which the sharpen intensity restores when camera stops moving.")]
	public ClampedFloatParameter sharpenMotionRestoreSpeed; // 0x1C8
	[ImageEnhancement]
	[EdgeAntialiasing]
	[DisplayName("Strength")]
	[DisplayConditionBool("stripBeautifyEdgeAA", False, null, True)]
	[Tooltip("Strength of the integrated edge antialiasing. A value of 0 disables this feature.")]
	[ShowStrippedLabel]
	public ClampedFloatParameter antialiasStrength; // 0x1D0
	[ImageEnhancement]
	[EdgeAntialiasing]
	[DisplayName("Edge Threshold")]
	[Tooltip("Minimum difference in depth between neighbour pixels to determine if edge antialiasing should be applied.")]
	public ClampedFloatParameter antialiasDepthThreshold; // 0x1D8
	[EdgeAntialiasing]
	[ImageEnhancement]
	[DisplayName("Max Spread")]
	[Tooltip("The maximum extent of antialiasing.")]
	public ClampedFloatParameter antialiasSpread; // 0x1E0
	[ImageEnhancement]
	[EdgeAntialiasing]
	[DisplayName("Depth Attenuation")]
	[Tooltip("Reduces antialias effect on the distance.")]
	public FloatParameter antialiasDepthAttenuation; // 0x1E8
	[TonemappingAndColorGrading]
	[DisplayConditionBool("stripBeautifyTonemapping", False, null, True)]
	[ShowStrippedLabel]
	public Beautify.BeautifyTonemapOperatorParameter tonemap; // 0x1F0
	[TonemappingAndColorGrading]
	[Min(0)]
	[DisplayName("Max Input Brightness")]
	[Tooltip("Clamps input image brightness to avoid artifacts due to NaN or out of range pixel values.")]
	[DisplayConditionEnum("tonemap", 1, True)]
	public FloatParameter tonemapMaxInputBrightness; // 0x1F8
	[TonemappingAndColorGrading]
	[Min(0)]
	[DisplayName("Pre Exposure")]
	[Tooltip("Brightness multiplier before applying tonemap operator.")]
	[DisplayConditionEnum("tonemap", 1, True)]
	public FloatParameter tonemapExposurePre; // 0x200
	[TonemappingAndColorGrading]
	[Min(0)]
	[DisplayName("Post Brightness")]
	[Tooltip("Brightness multiplier after applying tonemap operator.")]
	[DisplayConditionEnum("tonemap", 1, True)]
	public FloatParameter tonemapBrightnessPost; // 0x208
	[TonemappingAndColorGrading]
	public ClampedFloatParameter saturate; // 0x210
	[TonemappingAndColorGrading]
	public ClampedFloatParameter brightness; // 0x218
	[TonemappingAndColorGrading]
	public ClampedFloatParameter contrast; // 0x220
	[ShowStrippedLabel]
	[TonemappingAndColorGrading]
	[DisplayConditionBool("stripBeautifyColorTweaks", False, null, True)]
	public ClampedFloatParameter daltonize; // 0x228
	[TonemappingAndColorGrading]
	[DisplayConditionBool("stripBeautifyColorTweaks", False, null, True)]
	[ShowStrippedLabel]
	public ClampedFloatParameter sepia; // 0x230
	[TonemappingAndColorGrading]
	public ColorParameter tintColor; // 0x238
	[TonemappingAndColorGrading]
	[WhiteBalance]
	[DisplayName("Temperature")]
	[DisplayConditionBool("stripBeautifyColorTweaks", False, null, True)]
	[ShowStrippedLabel]
	public ClampedFloatParameter colorTemp; // 0x240
	[DisplayConditionBool("stripBeautifyColorTweaks", False, null, True)]
	[TonemappingAndColorGrading]
	[WhiteBalance]
	[DisplayName("Blend")]
	public ClampedFloatParameter colorTempBlend; // 0x248
	[ToggleAllFields]
	[TonemappingAndColorGrading]
	[LUT]
	[DisplayName("Enable LUT")]
	[DisplayConditionBool("stripBeautifyLUT", False, null, True)]
	[ShowStrippedLabel]
	public BoolParameter lut; // 0x250
	[TonemappingAndColorGrading]
	[LUT]
	[DisplayName("Intensity")]
	public ClampedFloatParameter lutIntensity; // 0x258
	[TonemappingAndColorGrading]
	[LUT]
	[DisplayName("LUT Texture")]
	public TextureParameter lutTexture; // 0x260
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Intensity")]
	[ShowStrippedLabel]
	[DisplayConditionBool("stripBeautifyBloom", False, null, True)]
	public FloatParameter bloomIntensity; // 0x268
	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Threshold")]
	public FloatParameter bloomThreshold; // 0x270
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Conservative Threshold")]
	[Tooltip("A convervative threshold keeps the ratio of the rgb values after applying the thresholding")]
	public BoolParameter bloomConservativeThreshold; // 0x278
	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Spread")]
	public ClampedFloatParameter bloomSpread; // 0x280
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Max Brightness")]
	public FloatParameter bloomMaxBrightness; // 0x288
	[Bloom]
	[Tooltip("Use Alpha channel to blend original bloom color with the tinted color.")]
	[DisplayName("Tint Color")]
	[LensAndLightingEffects]
	public ColorParameter bloomTint; // 0x290
	[DisplayName("Depth Attenuation")]
	[Bloom]
	[LensAndLightingEffects]
	public FloatParameter bloomDepthAtten; // 0x298
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Near Attenuation")]
	[Min(0)]
	public FloatParameter bloomNearAtten; // 0x2A0
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Exclude Layers")]
	public BoolParameter bloomExcludeLayers; // 0x2A8
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Exclusion Layer Mask")]
	[DisplayConditionBool("bloomExcludeLayers", True, null, True)]
	public Beautify.BeautifyLayerMaskParameter bloomExclusionLayerMask; // 0x2B0
	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Antiflicker")]
	public BoolParameter bloomAntiflicker; // 0x2B8
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Resolution")]
	public ClampedIntParameter bloomResolution; // 0x2C0
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Quicker Blur")]
	public BoolParameter bloomQuickerBlur; // 0x2C8
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Customize")]
	[ToggleAllFields]
	public BoolParameter bloomCustomize; // 0x2D0
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 1 Weight")]
	public ClampedFloatParameter bloomWeight0; // 0x2D8
	[DisplayName("Layer 1 Boost")]
	[Bloom]
	[LensAndLightingEffects]
	public ClampedFloatParameter bloomBoost0; // 0x2E0
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 1 Tint Color")]
	public ColorParameter bloomTint0; // 0x2E8
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 2 Weight")]
	public ClampedFloatParameter bloomWeight1; // 0x2F0
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 2 Boost")]
	public ClampedFloatParameter bloomBoost1; // 0x2F8
	[LensAndLightingEffects]
	[DisplayName("Layer 2 Tint Color")]
	[Bloom]
	public ColorParameter bloomTint1; // 0x300
	[LensAndLightingEffects]
	[DisplayName("Layer 3 Weight")]
	[Bloom]
	public ClampedFloatParameter bloomWeight2; // 0x308
	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Layer 3 Boost")]
	public ClampedFloatParameter bloomBoost2; // 0x310
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 3 Tint Color")]
	public ColorParameter bloomTint2; // 0x318
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 4 Weight")]
	public ClampedFloatParameter bloomWeight3; // 0x320
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 4 Boost")]
	public ClampedFloatParameter bloomBoost3; // 0x328
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 4 Tint Color")]
	public ColorParameter bloomTint3; // 0x330
	[Bloom]
	[LensAndLightingEffects]
	[DisplayName("Layer 5 Weight")]
	public ClampedFloatParameter bloomWeight4; // 0x338
	[Bloom]
	[DisplayName("Layer 5 Boost")]
	[LensAndLightingEffects]
	public ClampedFloatParameter bloomBoost4; // 0x340
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 5 Tint Color")]
	public ColorParameter bloomTint4; // 0x348
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 6 Weight")]
	public ClampedFloatParameter bloomWeight5; // 0x350
	[LensAndLightingEffects]
	[Bloom]
	[DisplayName("Layer 6 Boost")]
	public ClampedFloatParameter bloomBoost5; // 0x358
	[DisplayName("Layer 6 Tint Color")]
	[LensAndLightingEffects]
	[Bloom]
	public ColorParameter bloomTint5; // 0x360
	[DisplayName("Intensity")]
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayConditionBool("stripBeautifyBloom", False, null, True)]
	[ShowStrippedLabel]
	public FloatParameter anamorphicFlaresIntensity; // 0x368
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Threshold")]
	public FloatParameter anamorphicFlaresThreshold; // 0x370
	[AnamorphicFlares]
	[LensAndLightingEffects]
	[DisplayName("Conservative Threshold")]
	[Tooltip("A convervative threshold keeps the ratio of the rgb values after applying the thresholding")]
	public BoolParameter anamorphicFlaresConservativeThreshold; // 0x378
	[Tooltip("Ignore all Beautify effects. This option overrides any existing profile.")]
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Tint Color")]
	public ColorParameter anamorphicFlaresTint; // 0x380
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Vertical")]
	public BoolParameter anamorphicFlaresVertical; // 0x388
	[AnamorphicFlares]
	[DisplayName("Spread")]
	[LensAndLightingEffects]
	public ClampedFloatParameter anamorphicFlaresSpread; // 0x390
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Max Brightness")]
	public FloatParameter anamorphicFlaresMaxBrightness; // 0x398
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Depth Attenuation")]
	public FloatParameter anamorphicFlaresDepthAtten; // 0x3A0
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Near Attenuation")]
	[Min(0)]
	public FloatParameter anamorphicFlaresNearAtten; // 0x3A8
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Exclude Layers")]
	public BoolParameter anamorphicFlaresExcludeLayers; // 0x3B0
	[AnamorphicFlares]
	[DisplayName("Exclusion Layer Mask")]
	[DisplayConditionBool("anamorphicFlaresExcludeLayers", True, null, True)]
	[LensAndLightingEffects]
	public Beautify.BeautifyLayerMaskParameter anamorphicFlaresExclusionLayerMask; // 0x3B8
	[LensAndLightingEffects]
	[DisplayName("Antiflicker")]
	[AnamorphicFlares]
	public BoolParameter anamorphicFlaresAntiflicker; // 0x3C0
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Resolution")]
	public ClampedIntParameter anamorphicFlaresResolution; // 0x3C8
	[LensAndLightingEffects]
	[AnamorphicFlares]
	[DisplayName("Quicker Blur")]
	public BoolParameter anamorphicFlaresQuickerBlur; // 0x3D0
	[LensAndLightingEffects]
	[DisplayName("Global Intensity")]
	[ShowStrippedLabel]
	[DisplayConditionBool("stripBeautifyBloom", False, null, True)]
	[SunFlares]
	public ClampedFloatParameter sunFlaresIntensity; // 0x3D8
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Tint Color")]
	public ColorParameter sunFlaresTint; // 0x3E0
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Solar Wind Speed")]
	public ClampedFloatParameter sunFlaresSolarWindSpeed; // 0x3E8
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Rotation Dead Zone")]
	public BoolParameter sunFlaresRotationDeadZone; // 0x3F0
	[DisplayName("Downsampling")]
	[LensAndLightingEffects]
	[SunFlares]
	public ClampedIntParameter sunFlaresDownsampling; // 0x3F8
	[DisplayName("Depth Occlusion Mode")]
	[SunFlares]
	[Tooltip("None = no depth buffer checking. Simple = sample depth buffer at Sun position. Smooth = sample 4 positions around Sun position and interpolate value across frames.")]
	[LensAndLightingEffects]
	public Beautify.BeautifySunFlaresDepthOcclusionMode sunFlaresDepthOcclusionMode; // 0x400
	[SunFlares]
	[DisplayName("Occlusion Threshold")]
	[DisplayConditionEnum("sunFlaresDepthOcclusionMode", 2, True)]
	[LensAndLightingEffects]
	public ClampedFloatParameter sunFlaresDepthOcclusionThreshold; // 0x408
	[LensAndLightingEffects]
	[DisplayName("Use Layer Mask")]
	[Tooltip("Specifies if occluding objects will be detected by raycasting.")]
	[SunFlares]
	public BoolParameter sunFlaresUseLayerMask; // 0x410
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Occluding Layer Mask")]
	[DisplayConditionBool("sunFlaresUseLayerMask", True, null, True)]
	public Beautify.BeautifyLayerMaskParameter sunFlaresLayerMask; // 0x418
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayConditionBool("sunFlaresUseLayerMask", True, null, True)]
	[DisplayName("Occlusion Speed")]
	[DisplayConditionEnum("sunFlaresDepthOcclusionMode", 2, True)]
	public FloatParameter sunFlaresAttenSpeed; // 0x420
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Intensity")]
	[Header("Sun")]
	public ClampedFloatParameter sunFlaresSunIntensity; // 0x428
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Disk Size")]
	public ClampedFloatParameter sunFlaresSunDiskSize; // 0x430
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Diffraction Intensity")]
	public ClampedFloatParameter sunFlaresSunRayDiffractionIntensity; // 0x438
	[DisplayName("Diffraction Threshold")]
	[LensAndLightingEffects]
	[SunFlares]
	public ClampedFloatParameter sunFlaresSunRayDiffractionThreshold; // 0x440
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Length")]
	[Header("Corona Rays Group 1")]
	public ClampedFloatParameter sunFlaresCoronaRays1Length; // 0x448
	[SunFlares]
	[DisplayName("Streaks")]
	[LensAndLightingEffects]
	public ClampedIntParameter sunFlaresCoronaRays1Streaks; // 0x450
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Spread")]
	public ClampedFloatParameter sunFlaresCoronaRays1Spread; // 0x458
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Angle Offset")]
	public ClampedFloatParameter sunFlaresCoronaRays1AngleOffset; // 0x460
	[Header("Corona Rays Group 2")]
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Length")]
	public ClampedFloatParameter sunFlaresCoronaRays2Length; // 0x468
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Streaks")]
	public ClampedIntParameter sunFlaresCoronaRays2Streaks; // 0x470
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Spread")]
	public ClampedFloatParameter sunFlaresCoronaRays2Spread; // 0x478
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Angle Offset")]
	public ClampedFloatParameter sunFlaresCoronaRays2AngleOffset; // 0x480
	[Header("Ghost 1")]
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Size")]
	public ClampedFloatParameter sunFlaresGhosts1Size; // 0x488
	[SunFlares]
	[DisplayName("Offset")]
	[LensAndLightingEffects]
	public ClampedFloatParameter sunFlaresGhosts1Offset; // 0x490
	[DisplayName("Brightness")]
	[SunFlares]
	[LensAndLightingEffects]
	public ClampedFloatParameter sunFlaresGhosts1Brightness; // 0x498
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Size")]
	[Header("Ghost 2")]
	public ClampedFloatParameter sunFlaresGhosts2Size; // 0x4A0
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Offset")]
	public ClampedFloatParameter sunFlaresGhosts2Offset; // 0x4A8
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Brightness")]
	public ClampedFloatParameter sunFlaresGhosts2Brightness; // 0x4B0
	[Header("Ghost 3")]
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Size")]
	public ClampedFloatParameter sunFlaresGhosts3Size; // 0x4B8
	[LensAndLightingEffects]
	[DisplayName("Offset")]
	[SunFlares]
	public ClampedFloatParameter sunFlaresGhosts3Offset; // 0x4C0
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Brightness")]
	public ClampedFloatParameter sunFlaresGhosts3Brightness; // 0x4C8
	[Header("Ghost 4")]
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Size")]
	public ClampedFloatParameter sunFlaresGhosts4Size; // 0x4D0
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Offset")]
	public ClampedFloatParameter sunFlaresGhosts4Offset; // 0x4D8
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Brightness")]
	public ClampedFloatParameter sunFlaresGhosts4Brightness; // 0x4E0
	[SunFlares]
	[Header("Halo")]
	[LensAndLightingEffects]
	[DisplayName("Offset")]
	public ClampedFloatParameter sunFlaresHaloOffset; // 0x4E8
	[LensAndLightingEffects]
	[SunFlares]
	[DisplayName("Amplitude")]
	public ClampedFloatParameter sunFlaresHaloAmplitude; // 0x4F0
	[SunFlares]
	[LensAndLightingEffects]
	[DisplayName("Intensity")]
	public ClampedFloatParameter sunFlaresHaloIntensity; // 0x4F8
	[DisplayConditionBool("stripBeautifyLensDirt", False, null, True)]
	[Min(0)]
	[DisplayName("Intensity")]
	[ShowStrippedLabel]
	[LensAndLightingEffects]
	[LensDirt]
	public FloatParameter lensDirtIntensity; // 0x500
	[LensDirt]
	[DisplayName("Threshold")]
	[LensAndLightingEffects]
	public ClampedFloatParameter lensDirtThreshold; // 0x508
	[LensAndLightingEffects]
	[LensDirt]
	[DisplayName("Dirt Texture")]
	public TextureParameter lensDirtTexture; // 0x510
	[LensAndLightingEffects]
	[LensDirt]
	[DisplayName("Spread")]
	public ClampedIntParameter lensDirtSpread; // 0x518
	[LensAndLightingEffects]
	[ChromaticAberration]
	[DisplayName("Intensity")]
	[Min(0)]
	[DisplayConditionBool("stripBeautifyChromaticAberration", False, null, True)]
	[ShowStrippedLabel]
	public FloatParameter chromaticAberrationIntensity; // 0x520
	[LensAndLightingEffects]
	[ChromaticAberration]
	[DisplayConditionBool("turboMode", False, null, True)]
	[DisplayName("Hue Shift")]
	[Min(0)]
	public ClampedFloatParameter chromaticAberrationShift; // 0x528
	[DisplayConditionBool("turboMode", False, null, True)]
	[LensAndLightingEffects]
	[ChromaticAberration]
	[DisplayName("Smoothing")]
	public FloatParameter chromaticAberrationSmoothing; // 0x530
	[LensAndLightingEffects]
	[ChromaticAberration]
	[DisplayName("Separate Pass")]
	public BoolParameter chromaticAberrationSeparatePass; // 0x538
	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayName("Enable")]
	[ToggleAllFields]
	[DisplayConditionBool("stripBeautifyDoF", False, null, True)]
	[ShowStrippedLabel]
	public BoolParameter depthOfField; // 0x540
	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayName("Focus Mode")]
	[Header("Focus")]
	public Beautify.BeautifyDoFFocusModeParameter depthOfFieldFocusMode; // 0x548
	[DisplayName("Min Distance")]
	[DepthOfField]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, False)]
	[LensAndLightingEffects]
	public FloatParameter depthOfFieldAutofocusMinDistance; // 0x550
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Max Distance")]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, False)]
	public FloatParameter depthOfFieldAutofocusMaxDistance; // 0x558
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Fallback")]
	[Tooltip("Focus behaviour if object is not visible on the screen")]
	[DisplayConditionEnum("depthOfFieldFocusMode", 2, True)]
	public Beautify.DoFTargetFallbackParameter depthOfFieldTargetFallback; // 0x560
	[DisplayName("Distance")]
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayConditionEnum("depthOfFieldTargetFallback", 2, True)]
	public FloatParameter depthOfFieldTargetFallbackFixedDistance; // 0x568
	[LensAndLightingEffects]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, True)]
	[DisplayName("Viewport Point")]
	[DepthOfField]
	public Vector2Parameter depthOfFieldAutofocusViewportPoint; // 0x570
	[Tooltip("Custom distance adjustment (positive or negative)")]
	[DisplayName("Distance Shift")]
	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, True)]
	public FloatParameter depthOfFieldAutofocusDistanceShift; // 0x578
	[DepthOfField]
	[DisplayName("Layer Mask")]
	[DisplayConditionEnum("depthOfFieldFocusMode", 1, True)]
	[LensAndLightingEffects]
	public Beautify.BeautifyLayerMaskParameter depthOfFieldAutofocusLayerMask; // 0x580
	[DisplayName("Distance")]
	[DisplayConditionEnum("depthOfFieldFocusMode", 0, True)]
	[Min(0)]
	[DepthOfField]
	[LensAndLightingEffects]
	public FloatParameter depthOfFieldDistance; // 0x588
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Camera Lens Settings")]
	public Beautify.BeautifyDoFCameraSettingsParameter depthOfFieldCameraSettings; // 0x590
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Focal Length")]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 0, True)]
	public ClampedFloatParameter depthOfFieldFocalLength; // 0x598
	[DepthOfField]
	[DisplayName("Aperture")]
	[Min(0)]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 0, True)]
	[LensAndLightingEffects]
	public FloatParameter depthOfFieldAperture; // 0x5A0
	[DisplayName("Focal Length")]
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 1, True)]
	[Tooltip("The distance between the lens center and the camera's sensor in mm.")]
	public ClampedFloatParameter depthOfFieldFocalLengthReal; // 0x5A8
	[Tooltip("The F-stop or F-number is the relation between the focal length and the diameter of the aperture")]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 1, True)]
	[DisplayName("F-Stop")]
	[DepthOfField]
	[LensAndLightingEffects]
	public ClampedFloatParameter depthOfFieldFStop; // 0x5B0
	[DepthOfField]
	[DisplayName("Image Sensor Height")]
	[DisplayConditionEnum("depthOfFieldCameraSettings", 1, True)]
	[Tooltip("Represents the height of the virtual image sensor. By default, it uses a 24mm image sensor of a classic full-frame camera")]
	[LensAndLightingEffects]
	public ClampedFloatParameter depthOfFieldImageSensorHeight; // 0x5B8
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Focus Speed")]
	public ClampedFloatParameter depthOfFieldFocusSpeed; // 0x5C0
	[DisplayConditionBool("stripBeautifyDoFTransparentSupport", False, null, True)]
	[DepthOfField]
	[Header("Extra Features")]
	[ShowStrippedLabel]
	[LensAndLightingEffects]
	[DisplayName("Transparency Support")]
	public BoolParameter depthOfFieldTransparentSupport; // 0x5C8
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Layer Mask")]
	[DisplayConditionBool("depthOfFieldTransparentSupport", True, null, True)]
	public Beautify.BeautifyLayerMaskParameter depthOfFieldTransparentLayerMask; // 0x5D0
	[LensAndLightingEffects]
	[DisplayConditionBool("depthOfFieldTransparentSupport", True, null, True)]
	[Tooltip("When enabled, transparent geometry is rendered with cull off.")]
	[DisplayName("Double Sided")]
	[DepthOfField]
	public BoolParameter depthOfFieldTransparentDoubleSided; // 0x5D8
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Transparency Alpha Test Support")]
	[DisplayConditionBool("stripBeautifyDoFTransparentSupport", False, null, True)]
	[ShowStrippedLabel]
	[Tooltip("When enabled, transparent materials using alpha clipping will be included in the transparent mask")]
	public BoolParameter depthOfFieldAlphaTestSupport; // 0x5E0
	[DisplayName("Layer Mask")]
	[DepthOfField]
	[DisplayConditionBool("depthOfFieldAlphaTestSupport", True, null, True)]
	[LensAndLightingEffects]
	public Beautify.BeautifyLayerMaskParameter depthOfFieldAlphaTestLayerMask; // 0x5E8
	[Tooltip("When enabled, transparent geometry is rendered with cull off.")]
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Double Sided")]
	[DisplayConditionBool("depthOfFieldAlphaTestSupport", True, null, True)]
	public BoolParameter depthOfFieldAlphaTestDoubleSided; // 0x5F0
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Foreground Blur")]
	public BoolParameter depthOfFieldForegroundBlur; // 0x5F8
	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayName("Blur HQ")]
	[DisplayConditionBool("depthOfFieldForegroundBlur", True, null, True)]
	public BoolParameter depthOfFieldForegroundBlurHQ; // 0x600
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Blur Spread")]
	[DisplayConditionBool("depthOfFieldForegroundBlurHQ", True, null, True)]
	public ClampedFloatParameter depthOfFieldForegroundBlurHQSpread; // 0x608
	[DepthOfField]
	[LensAndLightingEffects]
	[DisplayName("Distance")]
	[DisplayConditionBool("depthOfFieldForegroundBlur", True, null, True)]
	public FloatParameter depthOfFieldForegroundDistance; // 0x610
	[DisplayName("Bokeh Effect")]
	[DepthOfField]
	[LensAndLightingEffects]
	public BoolParameter depthOfFieldBokeh; // 0x618
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Composition")]
	[DisplayConditionBool("depthOfFieldBokeh", True, null, True)]
	[Tooltip("Specifies if the pass to compute bokeh is integrated (faster) or separated (stronger)")]
	public Beautify.BeautifyDoFBokehCompositionParameter depthOfFieldBokehComposition; // 0x620
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Threshold")]
	[DisplayConditionBool("depthOfFieldBokeh", True, null, True)]
	public ClampedFloatParameter depthOfFieldBokehThreshold; // 0x628
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Intensity")]
	[DisplayConditionBool("depthOfFieldBokeh", True, null, True)]
	public ClampedFloatParameter depthOfFieldBokehIntensity; // 0x630
	[Header("Quality")]
	[DepthOfField]
	[DisplayName("Downsampling")]
	[LensAndLightingEffects]
	public ClampedIntParameter depthOfFieldDownsampling; // 0x638
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Sample Count")]
	public ClampedIntParameter depthOfFieldMaxSamples; // 0x640
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Max Brightness")]
	public FloatParameter depthOfFieldMaxBrightness; // 0x648
	[LensAndLightingEffects]
	[DepthOfField]
	[DisplayName("Max Depth")]
	public ClampedFloatParameter depthOfFieldMaxDistance; // 0x650
	[DepthOfField]
	[DisplayName("Filter Mode")]
	[LensAndLightingEffects]
	public Beautify.BeautifyDoFFilterModeParameter depthOfFieldFilterMode; // 0x658
	[LensAndLightingEffects]
	[EyeAdaptation]
	[DisplayName("Enable")]
	[ToggleAllFields]
	[DisplayConditionBool("stripBeautifyEyeAdaptation", False, null, True)]
	[ShowStrippedLabel]
	public BoolParameter eyeAdaptation; // 0x660
	[LensAndLightingEffects]
	[EyeAdaptation]
	[DisplayName("Min Exposure")]
	public ClampedFloatParameter eyeAdaptationMinExposure; // 0x668
	[LensAndLightingEffects]
	[EyeAdaptation]
	[DisplayName("Max Exposure")]
	public ClampedFloatParameter eyeAdaptationMaxExposure; // 0x670
	[DisplayName("Light Adapt Speed")]
	[EyeAdaptation]
	[LensAndLightingEffects]
	public ClampedFloatParameter eyeAdaptationSpeedToLight; // 0x678
	[LensAndLightingEffects]
	[EyeAdaptation]
	[DisplayName("Dark Adapt Speed")]
	public ClampedFloatParameter eyeAdaptationSpeedToDark; // 0x680
	[DisplayName("Enable")]
	[DisplayConditionBool("stripBeautifyPurkinje", False, null, True)]
	[LensAndLightingEffects]
	[ShowStrippedLabel]
	[PurkinjeShift]
	[ToggleAllFields]
	public BoolParameter purkinje; // 0x688
	[LensAndLightingEffects]
	[PurkinjeShift]
	[DisplayName("Shift Amount")]
	public ClampedFloatParameter purkinjeAmount; // 0x690
	[DisplayName("Threshold")]
	[LensAndLightingEffects]
	[PurkinjeShift]
	public ClampedFloatParameter purkinjeLuminanceThreshold; // 0x698
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Outer Ring")]
	[DisplayConditionBool("stripBeautifyVignetting", False, null, True)]
	[ShowStrippedLabel]
	public ClampedFloatParameter vignettingOuterRing; // 0x6A0
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Inner Ring")]
	public ClampedFloatParameter vignettingInnerRing; // 0x6A8
	[DisplayName("Fade")]
	[ArtisticChoices]
	[Vignette]
	public ClampedFloatParameter vignettingFade; // 0x6B0
	[Vignette]
	[DisplayName("Circular Shape")]
	[ArtisticChoices]
	public BoolParameter vignettingCircularShape; // 0x6B8
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Fit Mode")]
	[DisplayConditionBool("vignettingCircularShape", True, null, True)]
	public Beautify.BeautifyVignetteFitMode vignettingCircularShapeFitMode; // 0x6C0
	[DisplayConditionBool("vignettingCircularShape", False, null, True)]
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Aspect Ratio")]
	public ClampedFloatParameter vignettingAspectRatio; // 0x6C8
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Blink")]
	public ClampedFloatParameter vignettingBlink; // 0x6D0
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Blink Style")]
	public Beautify.BeautifyBlinkStyleParameter vignettingBlinkStyle; // 0x6D8
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Center")]
	public Vector2Parameter vignettingCenter; // 0x6E0
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Tint Color")]
	public ColorParameter vignettingColor; // 0x6E8
	[ArtisticChoices]
	[Vignette]
	[DisplayName("Texture Mask")]
	public TextureParameter vignettingMask; // 0x6F0
	[ArtisticChoices]
	[Outline]
	[DisplayConditionBool("stripBeautifyOutline", False, null, True)]
	[ShowStrippedLabel]
	public BoolParameter outline; // 0x6F8
	[ArtisticChoices]
	[DisplayName("Color")]
	[Outline]
	public ColorParameter outlineColor; // 0x700
	[DisplayName("Threshold")]
	[ArtisticChoices]
	[Outline]
	public ClampedFloatParameter outlineThreshold; // 0x708
	[ArtisticChoices]
	[Outline]
	[DisplayName("Customize")]
	public BoolParameter outlineCustomize; // 0x710
	[DisplayName("Render Stage")]
	[ArtisticChoices]
	[Outline]
	[DisplayConditionBool("outlineCustomize", True, null, True)]
	public Beautify.BeautifyOutlineStageParameter outlineStageParameter; // 0x718
	[Outline]
	[DisplayName("Spread")]
	[DisplayConditionBool("outlineCustomize", True, null, True)]
	[ArtisticChoices]
	public ClampedFloatParameter outlineSpread; // 0x720
	[DisplayConditionBool("outlineCustomize", True, null, True)]
	[DisplayName("Blur Count")]
	[Outline]
	[ArtisticChoices]
	public ClampedIntParameter outlineBlurPassCount; // 0x728
	[Outline]
	[ArtisticChoices]
	[DisplayName("Downscale Blur")]
	[DisplayConditionBool("outlineCustomize", True, null, True)]
	public BoolParameter outlineBlurDownscale; // 0x730
	[ArtisticChoices]
	[Outline]
	[DisplayName("Intensity Multiplier")]
	[DisplayConditionBool("outlineCustomize", True, null, True)]
	public ClampedFloatParameter outlineIntensityMultiplier; // 0x738
	[Tooltip("Maximum distance in meters from the camera")]
	[ArtisticChoices]
	[Outline]
	[DisplayConditionBool("outlineCustomize", True, null, True)]
	[DisplayName("Distance Fade")]
	public FloatParameter outlineDistanceFade; // 0x740
	[NightVision]
	[ArtisticChoices]
	[DisplayName("Enable")]
	[DisplayConditionBool("stripBeautifyNightVision", False, null, True)]
	[ShowStrippedLabel]
	public BoolParameter nightVision; // 0x748
	[DisplayConditionBool("stripBeautifyNightVision", False, null, True)]
	[ArtisticChoices]
	[NightVision]
	[DisplayName("Scan Lines Color")]
	public ColorParameter nightVisionColor; // 0x750
	[ArtisticChoices]
	[NightVision]
	[DisplayName("Max Visible Depth")]
	[DisplayConditionBool("stripBeautifyNightVision", False, null, True)]
	public FloatParameter nightVisionDepth; // 0x758
	[DisplayName("Max Visible Depth Fall Off")]
	[NightVision]
	[DisplayConditionBool("stripBeautifyNightVision", False, null, True)]
	[ArtisticChoices]
	public ClampedFloatParameter nightVisionDepthFallOff; // 0x760
	[ShowStrippedLabel]
	[DisplayConditionBool("stripBeautifyThermalVision", False, null, True)]
	[ThermalVision]
	[ArtisticChoices]
	[DisplayName("Enable")]
	public BoolParameter thermalVision; // 0x768
	[ArtisticChoices]
	[ThermalVision]
	[DisplayName("Scan Lines")]
	[DisplayConditionBool("stripBeautifyThermalVision", False, null, True)]
	public BoolParameter thermalVisionScanLines; // 0x770
	[ArtisticChoices]
	[ThermalVision]
	[DisplayName("Distortion Amount")]
	[DisplayConditionBool("stripBeautifyThermalVision", False, null, True)]
	public ClampedFloatParameter thermalVisionDistortionAmount; // 0x778
	[DisplayName("Intensity")]
	[ImageEnhancement]
	[Dither]
	[DisplayConditionBool("stripBeautifyDithering", False, null, True)]
	[ShowStrippedLabel]
	public ClampedFloatParameter ditherIntensity; // 0x780
	[ArtisticChoices]
	[Frame]
	[DisplayName("Enable")]
	[DisplayConditionBool("stripBeautifyFrame", False, null, True)]
	public BoolParameter frame; // 0x788
	[ArtisticChoices]
	[Frame]
	[DisplayName("Style")]
	public Beautify.BeautifyFrameStyleParameter frameStyle; // 0x790
	[DisplayName("Horizontal Bands Size")]
	[ArtisticChoices]
	[Frame]
	[DisplayConditionEnum("frameStyle", 1, True)]
	public ClampedFloatParameter frameBandHorizontalSize; // 0x798
	[DisplayName("Horizontal Bands Smoothness")]
	[Frame]
	[DisplayConditionEnum("frameStyle", 1, True)]
	[ArtisticChoices]
	public ClampedFloatParameter frameBandHorizontalSmoothness; // 0x7A0
	[DisplayName("Vertical Bands Size")]
	[DisplayConditionEnum("frameStyle", 1, True)]
	[ArtisticChoices]
	[Frame]
	public ClampedFloatParameter frameBandVerticalSize; // 0x7A8
	[DisplayName("Vertical Bands Smoothness")]
	[DisplayConditionEnum("frameStyle", 1, True)]
	[Frame]
	[ArtisticChoices]
	public ClampedFloatParameter frameBandVerticalSmoothness; // 0x7B0
	[DisplayConditionEnum("frameStyle", 0, True)]
	[DisplayName("Color")]
	[Frame]
	[ArtisticChoices]
	public ColorParameter frameColor; // 0x7B8
	[Frame]
	[DisplayName("Texture Mask")]
	[ArtisticChoices]
	public TextureParameter frameMask; // 0x7C0
	[DisplayName("Intensity")]
	[ArtisticChoices]
	[FinalBlur]
	public ClampedFloatParameter blurIntensity; // 0x7C8
	[ArtisticChoices]
	[FinalBlur]
	[DisplayName("Mask")]
	public TextureParameter blurMask; // 0x7D0
	[ArtisticChoices]
	[FinalBlur]
	[DisplayName("Keep Source On Top")]
	public BoolParameter blurKeepSourceOnTop; // 0x7D8
	[ArtisticChoices]
	[FinalBlur]
	[DisplayName("Rect")]
	[DisplayConditionBool("blurKeepSourceOnTop", True, null, True)]
	public Vector4Parameter blurSourceRect; // 0x7E0
	[DisplayName("Edge Blending Width")]
	[ArtisticChoices]
	[FinalBlur]
	[DisplayConditionBool("blurKeepSourceOnTop", True, null, True)]
	public ClampedFloatParameter blurSourceEdgeBlendWidth; // 0x7E8
	[ArtisticChoices]
	[FinalBlur]
	[DisplayName("Edge Blending Strength")]
	[DisplayConditionBool("blurKeepSourceOnTop", True, null, True)]
	public FloatParameter blurSourceEdgeBlendStrength; // 0x7F0
	private int downsamplingUsed; // 0x7F8

	// Methods

	// RVA: 0x2AB9080 Offset: 0x2AB7A80 VA: 0x182AB9080 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x2AB9550 Offset: 0x2AB7F50 VA: 0x182AB9550
	public bool RequiresDepthTexture() { }

	// RVA: 0x2AB90B0 Offset: 0x2AB7AB0 VA: 0x182AB90B0
	private void OnValidate() { }

	// RVA: 0x2AB96C0 Offset: 0x2AB80C0 VA: 0x182AB96C0
	public void .ctor() { }
}
