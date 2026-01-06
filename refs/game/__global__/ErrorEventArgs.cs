public class ErrorEventArgs : EventArgs // TypeDefIndex: 11229
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <CurrentObject>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Properties
	[Nullable(2)]
	public object CurrentObject { get; }
	public ErrorContext ErrorContext { get; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public object get_CurrentObject() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ErrorContext get_ErrorContext() { }

	// RVA: 0x1D7F8B0 Offset: 0x1D7E2B0 VA: 0x181D7F8B0
	public void .ctor(object currentObject, ErrorContext errorContext) { }
}
