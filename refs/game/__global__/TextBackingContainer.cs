internal struct TextBackingContainer // TypeDefIndex: 16740
{
	// Fields
	private uint[] m_Array; // 0x0
	private int m_Count; // 0x8

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x13FB420 Offset: 0x13F9E20 VA: 0x1813FB420
	public int get_Capacity() { }

	// RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	public int get_Count() { }

	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_Count(int value) { }

	// RVA: 0x11ED980 Offset: 0x11EC380 VA: 0x1811ED980
	public uint get_Item(int index) { }

	// RVA: 0x2D7DE10 Offset: 0x2D7C810 VA: 0x182D7DE10
	public void set_Item(int index, uint value) { }

	// RVA: 0x2D7DDB0 Offset: 0x2D7C7B0 VA: 0x182D7DDB0
	public void .ctor(int size) { }

	// RVA: 0x2D7DD60 Offset: 0x2D7C760 VA: 0x182D7DD60
	public void Resize(int size) { }
}
