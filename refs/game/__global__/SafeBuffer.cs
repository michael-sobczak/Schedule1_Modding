public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 4523
{
	// Fields
	private static readonly UIntPtr Uninitialized; // 0x0
	private UIntPtr _numBytes; // 0x20

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1B74A90 Offset: 0x1B73490 VA: 0x181B74A90
	public void AcquirePointer(ref byte* pointer) { }

	// RVA: 0x1B74BD0 Offset: 0x1B735D0 VA: 0x181B74BD0
	public void ReleasePointer() { }

	// RVA: 0x1B74B70 Offset: 0x1B73570 VA: 0x181B74B70
	private static InvalidOperationException NotInitialized() { }

	// RVA: 0x1B74C90 Offset: 0x1B73690 VA: 0x181B74C90
	private static void .cctor() { }
}
