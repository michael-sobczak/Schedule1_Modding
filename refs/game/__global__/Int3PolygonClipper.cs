internal struct Int3PolygonClipper // TypeDefIndex: 13362
{
	// Fields
	private float[] clipPolygonCache; // 0x0
	private int[] clipPolygonIntCache; // 0x8

	// Methods

	// RVA: 0xBA5E80 Offset: 0xBA4880 VA: 0x180BA5E80
	public void Init() { }

	// RVA: 0xBA5B90 Offset: 0xBA4590 VA: 0x180BA5B90
	public int ClipPolygon(Int3[] vIn, int n, Int3[] vOut, int multi, int offset, int axis) { }
}
