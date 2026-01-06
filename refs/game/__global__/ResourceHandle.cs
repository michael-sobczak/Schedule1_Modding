internal struct ResourceHandle // TypeDefIndex: 13543
{
	// Fields
	private const uint kValidityMask = 4294901760;
	private const uint kIndexMask = 65535;
	private uint m_Value; // 0x0
	private static uint s_CurrentValidBit; // 0x0
	private static uint s_SharedResourceValidBit; // 0x4
	[CompilerGenerated]
	private RenderGraphResourceType <type>k__BackingField; // 0x4

	// Properties
	public int index { get; }
	public RenderGraphResourceType type { get; set; }
	public int iType { get; }

	// Methods

	// RVA: 0xCBDF50 Offset: 0xCBC950 VA: 0x180CBDF50
	public int get_index() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public RenderGraphResourceType get_type() { }

	[CompilerGenerated]
	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	private void set_type(RenderGraphResourceType value) { }

	// RVA: 0x29DB220 Offset: 0x29D9C20 VA: 0x1829DB220
	public int get_iType() { }

	// RVA: 0x29DB160 Offset: 0x29D9B60 VA: 0x1829DB160
	internal void .ctor(int value, RenderGraphResourceType type, bool shared) { }

	// RVA: 0x29DB270 Offset: 0x29D9C70 VA: 0x1829DB270
	public static int op_Implicit(ResourceHandle handle) { }

	// RVA: 0x29DAF90 Offset: 0x29D9990 VA: 0x1829DAF90
	public bool IsValid() { }

	// RVA: 0x29DB020 Offset: 0x29D9A20 VA: 0x1829DB020
	public static void NewFrame(int executionIndex) { }

	// RVA: 0x29DB110 Offset: 0x29D9B10 VA: 0x1829DB110
	private static void .cctor() { }
}
