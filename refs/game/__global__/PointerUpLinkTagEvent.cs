public class PointerUpLinkTagEvent : PointerEventBase<PointerUpLinkTagEvent> // TypeDefIndex: 7206
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkID>k__BackingField; // 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkText>k__BackingField; // 0x118

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x2E4D680 Offset: 0x2E4C080 VA: 0x182E4D680
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	private void set_linkText(string value) { }

	// RVA: 0x2E4D630 Offset: 0x2E4C030 VA: 0x182E4D630 Slot: 12
	protected override void Init() { }

	// RVA: 0x2E4CE80 Offset: 0x2E4B880 VA: 0x182E4CE80
	private void LocalInit() { }

	// RVA: 0x2E4D5A0 Offset: 0x2E4BFA0 VA: 0x182E4D5A0
	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x2E4D760 Offset: 0x2E4C160 VA: 0x182E4D760
	public void .ctor() { }
}
