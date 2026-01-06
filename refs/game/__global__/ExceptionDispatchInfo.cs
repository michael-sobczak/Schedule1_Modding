public sealed class ExceptionDispatchInfo // TypeDefIndex: 4574
{
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0x1B60C50 Offset: 0x1B5F650 VA: 0x181B60C50
	private void .ctor(Exception exception) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0x1B609C0 Offset: 0x1B5F3C0 VA: 0x181B609C0
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Exception get_SourceException() { }

	[StackTraceHidden]
	// RVA: 0x1B60BD0 Offset: 0x1B5F5D0 VA: 0x181B60BD0
	public void Throw() { }

	[StackTraceHidden]
	// RVA: 0x1B60C20 Offset: 0x1B5F620 VA: 0x181B60C20
	public static void Throw(Exception source) { }

	// RVA: 0x1B60DC0 Offset: 0x1B5F7C0 VA: 0x181B60DC0
	internal void .ctor() { }
}
