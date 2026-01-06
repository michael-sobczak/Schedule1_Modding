public sealed class PointerDownLinkTagEvent : PointerEventBase<PointerDownLinkTagEvent> // TypeDefIndex: 7204
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkID>k__BackingField; // 0x110
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <linkText>k__BackingField; // 0x118

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x2E4CE90 Offset: 0x2E4B890 VA: 0x182E4CE90
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	private void set_linkText(string value) { }

	// RVA: 0x2E4CE30 Offset: 0x2E4B830 VA: 0x182E4CE30 Slot: 12
	protected override void Init() { }

	// RVA: 0x2E4CE80 Offset: 0x2E4B880 VA: 0x182E4CE80
	private void LocalInit() { }

	// RVA: 0x2E4CDA0 Offset: 0x2E4B7A0 VA: 0x182E4CDA0
	public static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x2E4CF70 Offset: 0x2E4B970 VA: 0x182E4CF70
	public void .ctor() { }
}
