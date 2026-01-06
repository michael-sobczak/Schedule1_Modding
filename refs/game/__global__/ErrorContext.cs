public class ErrorContext // TypeDefIndex: 11228
{
	// Fields
	[CompilerGenerated]
	private bool <Traced>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Exception <Error>k__BackingField; // 0x18
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <OriginalObject>k__BackingField; // 0x20
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <Member>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <Handled>k__BackingField; // 0x38

	// Properties
	internal bool Traced { get; set; }
	public Exception Error { get; }
	[Nullable(2)]
	public object OriginalObject { get; }
	[Nullable(2)]
	public object Member { get; }
	public string Path { get; }
	public bool Handled { get; set; }

	// Methods

	// RVA: 0x1D7F830 Offset: 0x1D7E230 VA: 0x181D7F830
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	internal bool get_Traced() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	internal void set_Traced(bool value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Exception get_Error() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public object get_OriginalObject() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public object get_Member() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Path() { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_Handled() { }

	[CompilerGenerated]
	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_Handled(bool value) { }
}
