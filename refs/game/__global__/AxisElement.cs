internal class AxisElement // TypeDefIndex: 8233
{
	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x255C210 Offset: 0x255AC10 VA: 0x18255C210
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x255C200 Offset: 0x255AC00 VA: 0x18255C200
	internal void SetDepth(int depth) { }

	// RVA: 0x255C0B0 Offset: 0x255AAB0 VA: 0x18255C0B0
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x255BF20 Offset: 0x255A920 VA: 0x18255BF20
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }
}
