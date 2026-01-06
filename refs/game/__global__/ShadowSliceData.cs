public struct ShadowSliceData // TypeDefIndex: 9015
{
	// Fields
	public Matrix4x4 viewMatrix; // 0x0
	public Matrix4x4 projectionMatrix; // 0x40
	public Matrix4x4 shadowTransform; // 0x80
	public int offsetX; // 0xC0
	public int offsetY; // 0xC4
	public int resolution; // 0xC8
	public ShadowSplitData splitData; // 0xCC

	// Methods

	// RVA: 0x2B28210 Offset: 0x2B26C10 VA: 0x182B28210
	public void Clear() { }
}
