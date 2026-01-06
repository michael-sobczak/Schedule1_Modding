public class PathNode // TypeDefIndex: 13204
{
	// Fields
	public GraphNode node; // 0x10
	public PathNode parent; // 0x18
	public ushort pathID; // 0x20
	public ushort heapIndex; // 0x22
	private uint flags; // 0x24
	private const uint CostMask = 268435455;
	private const int Flag1Offset = 28;
	private const uint Flag1Mask = 268435456;
	private const int Flag2Offset = 29;
	private const uint Flag2Mask = 536870912;
	private uint g; // 0x28
	private uint h; // 0x2C

	// Properties
	public uint cost { get; set; }
	public bool flag1 { get; set; }
	public bool flag2 { get; set; }
	public uint G { get; set; }
	public uint H { get; set; }
	public uint F { get; }

	// Methods

	// RVA: 0xB25C80 Offset: 0xB24680 VA: 0x180B25C80
	public uint get_cost() { }

	// RVA: 0xB25CB0 Offset: 0xB246B0 VA: 0x180B25CB0
	public void set_cost(uint value) { }

	// RVA: 0xB25C90 Offset: 0xB24690 VA: 0x180B25C90
	public bool get_flag1() { }

	// RVA: 0xB25CC0 Offset: 0xB246C0 VA: 0x180B25CC0
	public void set_flag1(bool value) { }

	// RVA: 0xB25CA0 Offset: 0xB246A0 VA: 0x180B25CA0
	public bool get_flag2() { }

	// RVA: 0xB25CF0 Offset: 0xB246F0 VA: 0x180B25CF0
	public void set_flag2(bool value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public uint get_G() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_G(uint value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public uint get_H() { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_H(uint value) { }

	// RVA: 0xB25C70 Offset: 0xB24670 VA: 0x180B25C70
	public uint get_F() { }

	// RVA: 0xB25B00 Offset: 0xB24500 VA: 0x180B25B00
	public void UpdateG(Path path) { }

	// RVA: 0xB25C60 Offset: 0xB24660 VA: 0x180B25C60
	public void .ctor() { }
}
