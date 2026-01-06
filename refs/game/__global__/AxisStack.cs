internal class AxisStack // TypeDefIndex: 8234
{
	// Fields
	private ArrayList _stack; // 0x10
	private ForwardAxis _subtree; // 0x18
	private ActiveAxis _parent; // 0x20

	// Properties
	internal ForwardAxis Subtree { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x1BF73E0 Offset: 0x1BF5DE0 VA: 0x181BF73E0
	internal int get_Length() { }

	// RVA: 0x255CAB0 Offset: 0x255B4B0 VA: 0x18255CAB0
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x255CA00 Offset: 0x255B400 VA: 0x18255CA00
	internal void Push(int depth) { }

	// RVA: 0x255C9B0 Offset: 0x255B3B0 VA: 0x18255C9B0
	internal void Pop() { }

	// RVA: 0x255C260 Offset: 0x255AC60 VA: 0x18255C260
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x255C6A0 Offset: 0x255B0A0 VA: 0x18255C6A0
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x255C4E0 Offset: 0x255AEE0 VA: 0x18255C4E0
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x255C2E0 Offset: 0x255ACE0 VA: 0x18255C2E0
	internal bool MoveToAttribute(string name, string URN, int depth) { }
}
