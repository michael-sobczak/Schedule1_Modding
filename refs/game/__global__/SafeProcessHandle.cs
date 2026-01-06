public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 9483
{
	// Fields
	internal static SafeProcessHandle InvalidHandle; // 0x0

	// Methods

	// RVA: 0x260A930 Offset: 0x2609330 VA: 0x18260A930
	internal void .ctor(IntPtr handle) { }

	// RVA: 0x1E0C8E0 Offset: 0x1E0B2E0 VA: 0x181E0C8E0
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x260A8A0 Offset: 0x26092A0 VA: 0x18260A8A0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x260A8B0 Offset: 0x26092B0 VA: 0x18260A8B0
	private static void .cctor() { }
}
