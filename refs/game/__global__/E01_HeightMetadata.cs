public class E01_HeightMetadata : CurvyInterpolatableMetadataBase<float> // TypeDefIndex: 10748
{
	// Fields
	[RangeEx(0, 1, "", "", Slider = True)]
	[SerializeField]
	private float m_Height; // 0x38

	// Properties
	public override float MetaDataValue { get; }

	// Methods

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0 Slot: 10
	public override float get_MetaDataValue() { }

	// RVA: 0x527F00 Offset: 0x526900 VA: 0x180527F00 Slot: 11
	public override float Interpolate(CurvyInterpolatableMetadataBase<float> nextMetadata, float interpolationTime) { }

	// RVA: 0x527FF0 Offset: 0x5269F0 VA: 0x180527FF0
	public void .ctor() { }
}
