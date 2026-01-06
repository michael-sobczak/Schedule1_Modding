public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 11861
{
	// Fields
	private Func<bool> m_Predicate; // 0x10

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x2CD3FF0 Offset: 0x2CD29F0 VA: 0x182CD3FF0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(Func<bool> predicate) { }
}
