internal struct Range // TypeDefIndex: 12961
{
	// Fields
	private int _min; // 0x0
	private int _max; // 0x4
	private bool _isNotNull; // 0x8

	// Properties
	public int Count { get; }
	public bool IsNull { get; }
	public int Min { get; }

	// Methods

	// RVA: 0x20A29C0 Offset: 0x20A13C0 VA: 0x1820A29C0
	public void .ctor(int min, int max) { }

	// RVA: 0x20A2A10 Offset: 0x20A1410 VA: 0x1820A2A10
	public int get_Count() { }

	// RVA: 0x20A2A30 Offset: 0x20A1430 VA: 0x1820A2A30
	public bool get_IsNull() { }

	// RVA: 0x20A2A40 Offset: 0x20A1440 VA: 0x1820A2A40
	public int get_Min() { }

	// RVA: 0x20A2980 Offset: 0x20A1380 VA: 0x1820A2980
	internal void CheckNull() { }
}
