internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 8248
{
	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0x256A140 Offset: 0x2568B40 VA: 0x18256A140
	public int get_lastDepth() { }

	// RVA: 0x256A0B0 Offset: 0x2568AB0 VA: 0x18256A0B0
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x2569A10 Offset: 0x2568410 VA: 0x182569A10 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x2569CA0 Offset: 0x25686A0 VA: 0x182569CA0
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x2569C00 Offset: 0x2568600 VA: 0x182569C00
	public KeySequence PopKS() { }
}
