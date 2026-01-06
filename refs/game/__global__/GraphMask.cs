public struct GraphMask // TypeDefIndex: 13125
{
	// Fields
	public int value; // 0x0

	// Properties
	public static GraphMask everything { get; }

	// Methods

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490
	public static GraphMask get_everything() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(int value) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static int op_Implicit(GraphMask mask) { }

	// RVA: 0xB0B4C0 Offset: 0xB09EC0 VA: 0x180B0B4C0
	public static GraphMask op_Implicit(int mask) { }

	// RVA: 0xB0B4A0 Offset: 0xB09EA0 VA: 0x180B0B4A0
	public static GraphMask op_BitwiseAnd(GraphMask lhs, GraphMask rhs) { }

	// RVA: 0xB0B4B0 Offset: 0xB09EB0 VA: 0x180B0B4B0
	public static GraphMask op_BitwiseOr(GraphMask lhs, GraphMask rhs) { }

	// RVA: 0xB0B4D0 Offset: 0xB09ED0 VA: 0x180B0B4D0
	public static GraphMask op_OnesComplement(GraphMask lhs) { }

	// RVA: 0xB0B200 Offset: 0xB09C00 VA: 0x180B0B200
	public bool Contains(int graphIndex) { }

	// RVA: 0xB0B460 Offset: 0xB09E60 VA: 0x180B0B460
	public static GraphMask FromGraph(NavGraph graph) { }

	// RVA: 0xB0B480 Offset: 0xB09E80 VA: 0x180B0B480 Slot: 3
	public override string ToString() { }

	// RVA: 0xB0B210 Offset: 0xB09C10 VA: 0x180B0B210
	public static GraphMask FromGraphName(string graphName) { }
}
