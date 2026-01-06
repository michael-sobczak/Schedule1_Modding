public class DebugVolume : CGModule // TypeDefIndex: 10721
{
	// Fields
	[InputSlotInfo(new[] { typeof(CGVolume) }, Name = "Volume")]
	[HideInInspector]
	public CGModuleInputSlot InData; // 0xC0
	[Tab("General")]
	public bool ShowPathSamples; // 0xC8
	public bool ShowCrossSamples; // 0xC9
	[IntRegion(RegionIsOptional = True)]
	[FieldCondition("ShowCrossSamples", True, False, 0, null, 1)]
	public IntRegion LimitCross; // 0xCC
	public bool ShowNormals; // 0xD8
	public bool ShowIndex; // 0xD9
	public bool ShowMap; // 0xDA
	public Color PathColor; // 0xDC
	public Color VolumeColor; // 0xEC
	public Color NormalColor; // 0xFC
	[Tab("Interpolate")]
	public bool Interpolate; // 0x10C
	[RangeEx(-1, 1, "Path", "")]
	public float InterpolatePathF; // 0x110
	[RangeEx(-1, 1, "Cross", "")]
	public float InterpolateCrossF; // 0x114

	// Methods

	// RVA: 0x523C70 Offset: 0x522670 VA: 0x180523C70 Slot: 13
	public override void Reset() { }

	// RVA: 0x523D20 Offset: 0x522720 VA: 0x180523D20
	public void .ctor() { }
}
