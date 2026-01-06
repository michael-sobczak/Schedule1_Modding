public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup> // TypeDefIndex: 10689
{
	// Fields
	public int MaterialID; // 0x28
	public float AspectCorrectionU; // 0x2C
	public float AspectCorrectionV; // 0x30

	// Properties
	public int TriangleCount { get; }
	[Obsolete("Use AspectCorrectionV instead")]
	[UsedImplicitly]
	public float AspectCorrection { get; set; }

	// Methods

	// RVA: 0x50D2B0 Offset: 0x50BCB0 VA: 0x18050D2B0
	public int get_TriangleCount() { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_AspectCorrection() { }

	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	public void set_AspectCorrection(float value) { }

	// RVA: 0x50D140 Offset: 0x50BB40 VA: 0x18050D140
	public void .ctor() { }

	// RVA: 0x50D230 Offset: 0x50BC30 VA: 0x18050D230
	public void .ctor(int capacity) { }

	// RVA: 0x50D1B0 Offset: 0x50BBB0 VA: 0x18050D1B0
	public void .ctor(IEnumerable<SamplePointsMaterialGroup> collection) { }

	// RVA: 0x50CFB0 Offset: 0x50B9B0 VA: 0x18050CFB0
	public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings) { }
}
