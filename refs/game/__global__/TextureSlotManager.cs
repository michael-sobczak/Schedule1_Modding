internal class TextureSlotManager // TypeDefIndex: 7137
{
	// Fields
	internal static readonly int k_SlotCount; // 0x0
	internal static readonly int k_SlotSize; // 0x4
	internal static readonly int[] slotIds; // 0x8
	internal static readonly int textureTableId; // 0x10
	private TextureId[] m_Textures; // 0x10
	private int[] m_Tickets; // 0x18
	private int m_CurrentTicket; // 0x20
	private int m_FirstUsedTicket; // 0x24
	private Vector4[] m_GpuTextures; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <FreeSlots>k__BackingField; // 0x30
	internal TextureRegistry textureRegistry; // 0x38

	// Properties
	public int FreeSlots { get; set; }

	// Methods

	// RVA: 0x2E1FCC0 Offset: 0x2E1E6C0 VA: 0x182E1FCC0
	private static void .cctor() { }

	// RVA: 0x2E1FE70 Offset: 0x2E1E870 VA: 0x182E1FE70
	public void .ctor() { }

	// RVA: 0x2E1F970 Offset: 0x2E1E370 VA: 0x182E1F970
	public void Reset() { }

	// RVA: 0x2E1FC50 Offset: 0x2E1E650 VA: 0x182E1FC50
	public void StartNewBatch() { }

	// RVA: 0x2E1F830 Offset: 0x2E1E230 VA: 0x182E1F830
	public int IndexOf(TextureId id) { }

	// RVA: 0x2E1F910 Offset: 0x2E1E310 VA: 0x182E1F910
	public void MarkUsed(int slotIndex) { }

	[CompilerGenerated]
	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_FreeSlots() { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	private void set_FreeSlots(int value) { }

	// RVA: 0x2E1F760 Offset: 0x2E1E160 VA: 0x182E1F760
	public int FindOldestSlot() { }

	// RVA: 0x2E1F560 Offset: 0x2E1DF60 VA: 0x182E1F560
	public void Bind(TextureId id, float sdfScale, int slot, MaterialPropertyBlock mat) { }

	// RVA: 0x2E1FAC0 Offset: 0x2E1E4C0 VA: 0x182E1FAC0
	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale) { }
}
