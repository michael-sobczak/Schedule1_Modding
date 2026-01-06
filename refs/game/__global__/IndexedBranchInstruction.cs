internal abstract class IndexedBranchInstruction : Instruction // TypeDefIndex: 15254
{
	// Fields
	internal readonly int _labelIndex; // 0x10

	// Methods

	// RVA: 0xC23480 Offset: 0xC21E80 VA: 0x180C23480
	public void .ctor(int labelIndex) { }

	// RVA: 0x1FB6080 Offset: 0x1FB4A80 VA: 0x181FB6080
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	// RVA: 0x1FB60E0 Offset: 0x1FB4AE0 VA: 0x181FB60E0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1FB61A0 Offset: 0x1FB4BA0 VA: 0x181FB61A0 Slot: 3
	public override string ToString() { }
}
