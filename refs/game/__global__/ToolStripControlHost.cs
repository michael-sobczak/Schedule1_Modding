public class ToolStripControlHost : ToolStripItem // TypeDefIndex: 5614
{
	// Fields
	private Control control; // 0x180
	private static object EnterEvent; // 0x0
	private static object GotFocusEvent; // 0x8
	private static object KeyDownEvent; // 0x10
	private static object KeyPressEvent; // 0x18
	private static object KeyUpEvent; // 0x20
	private static object LeaveEvent; // 0x28
	private static object LostFocusEvent; // 0x30
	private static object ValidatedEvent; // 0x38
	private static object ValidatingEvent; // 0x40

	// Properties
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public Control Control { get; }

	// Methods

	// RVA: 0x222DA50 Offset: 0x222C450 VA: 0x18222DA50
	private static void .cctor() { }

	// RVA: 0x73B370 Offset: 0x739D70 VA: 0x18073B370
	public Control get_Control() { }

	[EditorBrowsable(2)]
	// RVA: 0x222DA20 Offset: 0x222C420 VA: 0x18222DA20
	public void Focus() { }
}
