public class BlendingHelper // TypeDefIndex: 410
{
	// Fields
	private ProfileBlendingState m_State; // 0x10

	// Methods

	// RVA: 0x8C4DF0 Offset: 0x8C37F0 VA: 0x1808C4DF0
	public void .ctor(ProfileBlendingState state) { }

	// RVA: 0x8C4DC0 Offset: 0x8C37C0 VA: 0x1808C4DC0
	public void UpdateState(ProfileBlendingState state) { }

	// RVA: 0x8C4B30 Offset: 0x8C3530 VA: 0x1808C4B30
	public Color ProfileColorForKey(SkyProfile profile, string key) { }

	// RVA: 0x8C4C20 Offset: 0x8C3620 VA: 0x1808C4C20
	public float ProfileNumberForKey(SkyProfile profile, string key) { }

	// RVA: 0x8C4CF0 Offset: 0x8C36F0 VA: 0x1808C4CF0
	public SpherePoint ProfileSpherePointForKey(SkyProfile profile, string key) { }

	// RVA: 0x8C4340 Offset: 0x8C2D40 VA: 0x1808C4340
	public void BlendColor(string key) { }

	// RVA: 0x8C4020 Offset: 0x8C2A20 VA: 0x1808C4020
	public void BlendColorOut(string key) { }

	// RVA: 0x8C3E40 Offset: 0x8C2840 VA: 0x1808C3E40
	public void BlendColorIn(string key) { }

	// RVA: 0x8C4210 Offset: 0x8C2C10 VA: 0x1808C4210
	public void BlendColor(string key, Color from, Color to, float progress) { }

	// RVA: 0x8C4680 Offset: 0x8C3080 VA: 0x1808C4680
	public void BlendNumber(string key) { }

	// RVA: 0x8C4550 Offset: 0x8C2F50 VA: 0x1808C4550
	public void BlendNumberOut(string key, float toValue = 0) { }

	// RVA: 0x8C44F0 Offset: 0x8C2EF0 VA: 0x1808C44F0
	public void BlendNumberIn(string key, float fromValue = 0) { }

	// RVA: 0x8C45B0 Offset: 0x8C2FB0 VA: 0x1808C45B0
	public void BlendNumber(string key, float from, float to, float progress) { }

	// RVA: 0x8C4890 Offset: 0x8C3290 VA: 0x1808C4890
	public void BlendSpherePoint(string key) { }

	// RVA: 0x8C46F0 Offset: 0x8C30F0 VA: 0x1808C46F0
	public void BlendSpherePoint(string key, SpherePoint from, SpherePoint to, float progress) { }

	// RVA: 0x8C4A90 Offset: 0x8C3490 VA: 0x1808C4A90
	public ProfileFeatureBlendingMode GetFeatureAnimationMode(string featureKey) { }
}
