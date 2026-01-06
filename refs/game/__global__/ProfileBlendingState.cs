public struct ProfileBlendingState // TypeDefIndex: 424
{
	// Fields
	public SkyProfile blendedProfile; // 0x0
	public SkyProfile fromProfile; // 0x8
	public SkyProfile toProfile; // 0x10
	public float progress; // 0x18
	public float outProgress; // 0x1C
	public float inProgress; // 0x20
	public float timeOfDay; // 0x24

	// Methods

	// RVA: 0x9DFF60 Offset: 0x9DE960 VA: 0x1809DFF60
	public void .ctor(SkyProfile blendedProfile, SkyProfile fromProfile, SkyProfile toProfile, float progress, float outProgress, float inProgress, float timeOfDay) { }
}
