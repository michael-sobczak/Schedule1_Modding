public class BlendSkyProfiles : MonoBehaviour // TypeDefIndex: 421
{
	// Fields
	[CompilerGenerated]
	private SkyProfile <fromProfile>k__BackingField; // 0x20
	[CompilerGenerated]
	private SkyProfile <toProfile>k__BackingField; // 0x28
	[CompilerGenerated]
	private SkyProfile <blendedProfile>k__BackingField; // 0x30
	[Tooltip("Called when blending finishes.")]
	public Action<BlendSkyProfiles> onBlendComplete; // 0x38
	[HideInInspector]
	private float m_StartTime; // 0x40
	[HideInInspector]
	private float m_EndTime; // 0x44
	[Tooltip("Blender used for basic sky background properties.")]
	public FeatureBlender skyBlender; // 0x48
	[Tooltip("Blender used for the sun properties.")]
	public FeatureBlender sunBlender; // 0x50
	[Tooltip("Blender used moon properties.")]
	public FeatureBlender moonBlender; // 0x58
	[Tooltip("Blender used cloud properties.")]
	public FeatureBlender cloudBlender; // 0x60
	[Tooltip("Blender used star layer 1 properties.")]
	public FeatureBlender starLayer1Blender; // 0x68
	[Tooltip("Blender used star layer 2 properties.")]
	public FeatureBlender starLayer2Blender; // 0x70
	[Tooltip("Blender used star layer 3 properties.")]
	public FeatureBlender starLayer3Blender; // 0x78
	[Tooltip("Blender used by the rain downfall feature.")]
	public FeatureBlender rainBlender; // 0x80
	[Tooltip("Blender used by the rain splash feature.")]
	public FeatureBlender rainSplashBlender; // 0x88
	[Tooltip("Blender used for lightning feature properties.")]
	public FeatureBlender lightningBlender; // 0x90
	[Tooltip("Blender used for fog properties.")]
	public FeatureBlender fogBlender; // 0x98
	private bool m_IsBlendingFirstHalf; // 0xA0
	private ProfileBlendingState m_State; // 0xA8
	private TimeOfDayController m_TimeOfDayController; // 0xD0
	private BlendingHelper blendingHelper; // 0xD8

	// Properties
	public SkyProfile fromProfile { get; set; }
	public SkyProfile toProfile { get; set; }
	public SkyProfile blendedProfile { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public SkyProfile get_fromProfile() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_fromProfile(SkyProfile value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public SkyProfile get_toProfile() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_toProfile(SkyProfile value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public SkyProfile get_blendedProfile() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_blendedProfile(SkyProfile value) { }

	// RVA: 0x9DE350 Offset: 0x9DCD50 VA: 0x1809DE350
	public SkyProfile StartBlending(TimeOfDayController controller, SkyProfile fromProfile, SkyProfile toProfile, float duration) { }

	// RVA: 0x9DE300 Offset: 0x9DCD00 VA: 0x1809DE300
	public void CancelBlending() { }

	// RVA: 0x9DE8C0 Offset: 0x9DD2C0 VA: 0x1809DE8C0
	public void TearDownBlending() { }

	// RVA: 0x9DF010 Offset: 0x9DDA10 VA: 0x1809DF010
	private void Update() { }

	// RVA: 0x9DE980 Offset: 0x9DD380 VA: 0x1809DE980
	private void UpdateBlendedProfile() { }

	// RVA: 0x9DE310 Offset: 0x9DCD10 VA: 0x1809DE310
	private float PercentForMode(ProfileFeatureBlendingMode mode, float percent) { }

	// RVA: 0x9DF080 Offset: 0x9DDA80 VA: 0x1809DF080
	public void .ctor() { }
}
