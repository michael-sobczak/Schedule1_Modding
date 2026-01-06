internal class ActiveAxis // TypeDefIndex: 8235
{
	// Fields
	private int _currentDepth; // 0x10
	private bool _isActive; // 0x14
	private Asttree _axisTree; // 0x18
	private ArrayList _axisStack; // 0x20

	// Properties
	public int CurrentDepth { get; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_CurrentDepth() { }

	// RVA: 0x255ABF0 Offset: 0x25595F0 VA: 0x18255ABF0
	internal void Reactivate() { }

	// RVA: 0x255AC00 Offset: 0x2559600 VA: 0x18255AC00
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x255AA60 Offset: 0x2559460 VA: 0x18255AA60
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x255A7C0 Offset: 0x25591C0 VA: 0x18255A7C0 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x255A900 Offset: 0x2559300 VA: 0x18255A900
	public bool MoveToAttribute(string localname, string URN) { }
}
