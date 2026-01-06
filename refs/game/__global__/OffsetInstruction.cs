internal abstract class OffsetInstruction : Instruction // TypeDefIndex: 15249
{
	// Fields
	protected int _offset; // 0x10

	// Properties
	public abstract Instruction[] Cache { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Instruction[] get_Cache();

	// RVA: 0x1FBA020 Offset: 0x1FB8A20 VA: 0x181FBA020
	public Instruction Fixup(int offset) { }

	// RVA: 0x1FBA0C0 Offset: 0x1FB8AC0 VA: 0x181FBA0C0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1FBA180 Offset: 0x1FB8B80 VA: 0x181FBA180 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FA4E80 Offset: 0x1FA3880 VA: 0x181FA4E80
	protected void .ctor() { }
}
