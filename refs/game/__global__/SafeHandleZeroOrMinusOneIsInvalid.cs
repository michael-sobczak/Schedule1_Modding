public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle // TypeDefIndex: 3547
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x1AA6350 Offset: 0x1AA4D50 VA: 0x181AA6350
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x1AA6360 Offset: 0x1AA4D60 VA: 0x181AA6360 Slot: 5
	public override bool get_IsInvalid() { }
}
