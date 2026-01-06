public class RadiantGlobalIllumination : VolumeComponent, IPostProcessComponent // TypeDefIndex: 18577
{
	// Fields
	[Tooltip("Intensity of the indirect lighting.")]
	public FloatParameter indirectIntensity; // 0x38
	[Tooltip("Distance attenuation applied to indirect lighting. Reduces indirect intensity by square of distance.")]
	public ClampedFloatParameter indirectDistanceAttenuation; // 0x40
	[Tooltip("Maximum brightness of indirect source.")]
	public FloatParameter indirectMaxSourceBrightness; // 0x48
	[Tooltip("Determines how much influence has the surface normal map when receiving indirect lighting.")]
	public ClampedFloatParameter normalMapInfluence; // 0x50
	[Tooltip("Add one ray bounce.")]
	public BoolParameter rayBounce; // 0x58
	[Tooltip("Only in forward rendering mode: uses pixel luma to enhance results by adding variety to the effect based on the perceptual brigthness. Set this value to 0 to disable this feature.")]
	public FloatParameter lumaInfluence; // 0x60
	[Tooltip("Intensity of the near field obscurance effect. Darkens surfaces occluded by other nearby surfaces.")]
	public FloatParameter nearFieldObscurance; // 0x68
	[Tooltip("Spread or radius of the near field obscurance effect")]
	public ClampedFloatParameter nearFieldObscuranceSpread; // 0x70
	[Tooltip("Maximum distance of Near Field Obscurance effect")]
	public FloatParameter nearFieldObscuranceMaxCameraDistance; // 0x78
	[Tooltip("Distance threshold of the occluder")]
	public ClampedFloatParameter nearFieldObscuranceOccluderDistance; // 0x80
	[ColorUsage(False)]
	[Tooltip("Tint color of Near Field Obscurance effect")]
	public ColorParameter nearFieldObscuranceTintColor; // 0x88
	[Tooltip("Enable user-defined light emitters in the scene.")]
	public BoolParameter virtualEmitters; // 0x90
	[Tooltip("Number of rays per pixel")]
	public ClampedIntParameter rayCount; // 0x98
	[Tooltip("Max ray length. Increasing this value may also require increasing the 'Max Samples' value to avoid losing quality.")]
	public FloatParameter rayMaxLength; // 0xA0
	[Tooltip("Max samples taken during raymarch.")]
	public IntParameter rayMaxSamples; // 0xA8
	[Tooltip("Jitter adds a random offset to the ray direction to reduce banding. Useful when using low sample count.")]
	public FloatParameter rayJitter; // 0xB0
	[Tooltip("The assumed thickness for any geometry. Used to determine if ray crosses a surface.")]
	public FloatParameter thickness; // 0xB8
	[Tooltip("Improves raymarch accuracy by using binary search.")]
	public BoolParameter rayBinarySearch; // 0xC0
	[Tooltip("In case a ray miss a target, reuse rays from previous frames.")]
	public BoolParameter fallbackReuseRays; // 0xC8
	[Tooltip("If a ray misses a target, reuse result from history buffer. This value is the intensity of the previous color in case the ray misses the target.")]
	public ClampedFloatParameter rayReuse; // 0xD0
	[Tooltip("In case a ray miss a target, use nearby probes if they're available.")]
	public BoolParameter fallbackReflectionProbes; // 0xD8
	[Tooltip("Custom global probe intensity multiplier. Note that each probe has also an intensity property.")]
	public FloatParameter probesIntensity; // 0xE0
	[Tooltip("In case a ray miss a target, use reflective shadow map data from the main directional light. You need to add the ReflectiveShadowMap script to the directional light to use this feature.")]
	public BoolParameter fallbackReflectiveShadowMap; // 0xE8
	public ClampedFloatParameter reflectiveShadowMapIntensity; // 0xF0
	[Tooltip("Reduces resolution of all GI stages improving performance")]
	public ClampedFloatParameter downsampling; // 0xF8
	[Tooltip("Raytracing accuracy. Reducing this value will shrink the depth buffer used during raytracing, improving performance in exchange of accuracy.")]
	public ClampedIntParameter raytracerAccuracy; // 0x100
	[Tooltip("Extra blur passes")]
	public ClampedIntParameter smoothing; // 0x108
	[Tooltip("Uses motion vectors to blend into a history buffer to reduce flickering. Only applies in play mode.")]
	public BoolParameter temporalReprojection; // 0x110
	[Tooltip("Reaction speed to screen changes. Higher values reduces ghosting but also the smoothing.")]
	public FloatParameter temporalResponseSpeed; // 0x118
	[Tooltip("Reaction speed to camera position change. Higher values reduces ghosting when camera moves.")]
	public FloatParameter temporalCameraTranslationResponse; // 0x120
	[Tooltip("Difference in depth with current frame to discard history buffer when reusing rays.")]
	public FloatParameter temporalDepthRejection; // 0x128
	[Tooltip("Allowed difference in color between history and current GI buffers.")]
	public ClampedFloatParameter temporalChromaThreshold; // 0x130
	[Tooltip("Renders the effect also in edit mode (when not in play-mode).")]
	public BoolParameter showInEditMode; // 0x138
	[Tooltip("Renders the effect also in Scene View.")]
	public BoolParameter showInSceneView; // 0x140
	[Tooltip("Computes GI emitted by objects with a minimum luminosity.")]
	public FloatParameter brightnessThreshold; // 0x148
	[Tooltip("Maximum GI brightness.")]
	public FloatParameter brightnessMax; // 0x150
	[Tooltip("Amount of GI which adds to specular surfaces. Reduce this value to avoid overexposition of shiny materials.")]
	public ClampedFloatParameter specularContribution; // 0x158
	[Tooltip("Attenuates GI brightness from nearby surfaces.")]
	public FloatParameter nearCameraAttenuation; // 0x160
	[Tooltip("Adjusted color saturation for the computed GI.")]
	public ClampedFloatParameter saturation; // 0x168
	[Tooltip("Applies GI only inside the post processing volume (use only if the volume is local)")]
	public BoolParameter limitToVolumeBounds; // 0x170
	[Tooltip("Enables stencil check during GI composition. This option let you exclude GI over certain objects that also use stencil buffer.")]
	public BoolParameter stencilCheck; // 0x178
	public IntParameter stencilValue; // 0x180
	public RadiantGlobalIllumination.CompareFunctionParameter stencilCompareFunction; // 0x188
	[Tooltip("Integration with URP native screen space ambient occlusion (also with HBAO in Lit AO mode). Amount of ambient occlusion that influences indirect lighting created by Radiant.")]
	public ClampedFloatParameter aoInfluence; // 0x190
	public RadiantGlobalIllumination.DebugViewParameter debugView; // 0x198
	[Tooltip("Depth values multiplier for the depth debug view")]
	public FloatParameter debugDepthMultiplier; // 0x1A0
	public BoolParameter compareMode; // 0x1A8
	public BoolParameter compareSameSide; // 0x1B0
	public ClampedFloatParameter comparePanning; // 0x1B8
	public ClampedFloatParameter compareLineAngle; // 0x1C0
	public ClampedFloatParameter compareLineWidth; // 0x1C8

	// Methods

	// RVA: 0x1E875F0 Offset: 0x1E85FF0 VA: 0x181E875F0 Slot: 8
	public bool IsActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool IsTileCompatible() { }

	// RVA: 0x1E87650 Offset: 0x1E86050 VA: 0x181E87650
	private void OnValidate() { }

	// RVA: 0x1E87A70 Offset: 0x1E86470 VA: 0x181E87A70
	private void Reset() { }

	// RVA: 0x1E87AC0 Offset: 0x1E864C0 VA: 0x181E87AC0
	public void .ctor() { }
}
