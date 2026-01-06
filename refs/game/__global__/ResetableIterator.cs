internal abstract class ResetableIterator : XPathNodeIterator // TypeDefIndex: 8585
{
	// Properties
	public abstract override int CurrentPosition { get; }

	// Methods

	// RVA: 0x24B24B0 Offset: 0x24B0EB0 VA: 0x1824B24B0
	public void .ctor() { }

	// RVA: 0x24B24D0 Offset: 0x24B0ED0 VA: 0x1824B24D0
	protected void .ctor(ResetableIterator other) { }

	// RVA: 0x1663BF0 Offset: 0x16625F0 VA: 0x181663BF0
	protected void ResetCount() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Reset();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract override int get_CurrentPosition();
}
