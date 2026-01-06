public class DoWorkEventArgs : CancelEventArgs // TypeDefIndex: 9784
{
	// Fields
	private object result; // 0x18
	private object argument; // 0x20

	// Properties
	[SRDescription("Result from the worker function.")]
	public object Result { get; }

	// Methods

	// RVA: 0x26649F0 Offset: 0x26633F0 VA: 0x1826649F0
	public void .ctor(object argument) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public object get_Result() { }
}
