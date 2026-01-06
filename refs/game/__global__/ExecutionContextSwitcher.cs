internal struct ExecutionContextSwitcher // TypeDefIndex: 3960
{
	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[ReliabilityContract(3, 1)]
	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1CDD200 Offset: 0x1CDBC00 VA: 0x181CDD200
	internal bool UndoNoThrow() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1CDD220 Offset: 0x1CDBC20 VA: 0x181CDD220
	internal void Undo() { }
}
