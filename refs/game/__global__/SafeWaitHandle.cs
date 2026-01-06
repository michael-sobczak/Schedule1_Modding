public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 3546
{
	// Methods

	// RVA: 0x1AA62B0 Offset: 0x1AA4CB0 VA: 0x181AA62B0
	private void .ctor() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1AA6230 Offset: 0x1AA4C30 VA: 0x181AA6230
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x1AA6660 Offset: 0x1AA5060 VA: 0x181AA6660 Slot: 7
	protected override bool ReleaseHandle() { }
}
