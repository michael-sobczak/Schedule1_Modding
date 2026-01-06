public sealed class ColorUsageAttribute : PropertyAttribute // TypeDefIndex: 11780
{
	// Fields
	public readonly bool showAlpha; // 0x10
	public readonly bool hdr; // 0x11
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minBrightness; // 0x14
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxBrightness; // 0x18
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minExposureValue; // 0x1C
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxExposureValue; // 0x20

	// Methods

	// RVA: 0x2CB9F20 Offset: 0x2CB8920 VA: 0x182CB9F20
	public void .ctor(bool showAlpha) { }

	// RVA: 0x2CB9EC0 Offset: 0x2CB88C0 VA: 0x182CB9EC0
	public void .ctor(bool showAlpha, bool hdr) { }
}
