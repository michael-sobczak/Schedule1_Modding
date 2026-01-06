public class CGDataRequestShapeRasterization : CGDataRequestRasterization // TypeDefIndex: 10618
{
	// Fields
	private SubArray<float> relativeDistances; // 0x28

	// Properties
	public SubArray<float> RelativeDistances { get; set; }
	[Obsolete("Use RelativeDistances instead")]
	[UsedImplicitly]
	public float[] PathF { get; set; }

	// Methods

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public SubArray<float> get_RelativeDistances() { }

	// RVA: 0x4D8590 Offset: 0x4D6F90 VA: 0x1804D8590
	public void set_RelativeDistances(SubArray<float> value) { }

	// RVA: 0x4D8460 Offset: 0x4D6E60 VA: 0x1804D8460
	public float[] get_PathF() { }

	// RVA: 0x4D8520 Offset: 0x4D6F20 VA: 0x1804D8520
	public void set_PathF(float[] value) { }

	// RVA: 0x4D82C0 Offset: 0x4D6CC0 VA: 0x1804D82C0
	public void .ctor(SubArray<float> relativeDistance, float start, float rasterizedRelativeLength, int resolution, float angle, CGDataRequestRasterization.ModeEnum mode = 0) { }

	[Obsolete("Use another constructor instead")]
	[UsedImplicitly]
	// RVA: 0x4D8120 Offset: 0x4D6B20 VA: 0x1804D8120
	public void .ctor(float[] pathF, float start, float rasterizedRelativeLength, int resolution, float angle, CGDataRequestRasterization.ModeEnum mode = 0) { }

	// RVA: 0x4D7DD0 Offset: 0x4D67D0 VA: 0x1804D7DD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4D7F60 Offset: 0x4D6960 VA: 0x1804D7F60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4D8080 Offset: 0x4D6A80 VA: 0x1804D8080 Slot: 3
	public override string ToString() { }
}
