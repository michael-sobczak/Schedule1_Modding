public class CGDataRequestRasterization : CGDataRequestParameter // TypeDefIndex: 10617
{
	// Fields
	public float Start; // 0x10
	public float RasterizedRelativeLength; // 0x14
	public int Resolution; // 0x18
	public float AngleThreshold; // 0x1C
	public CGDataRequestRasterization.ModeEnum Mode; // 0x20

	// Methods

	// RVA: 0x4D7D30 Offset: 0x4D6730 VA: 0x1804D7D30
	public void .ctor(float start, float rasterizedRelativeLength, int resolution, float angle, CGDataRequestRasterization.ModeEnum mode = 0) { }

	// RVA: 0x4D7CE0 Offset: 0x4D66E0 VA: 0x1804D7CE0
	public void .ctor(CGDataRequestRasterization source) { }

	// RVA: 0x4D76C0 Offset: 0x4D60C0 VA: 0x1804D76C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4D7770 Offset: 0x4D6170 VA: 0x1804D7770 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4D7850 Offset: 0x4D6250 VA: 0x1804D7850 Slot: 3
	public override string ToString() { }
}
