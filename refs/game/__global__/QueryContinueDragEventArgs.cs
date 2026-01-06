public class QueryContinueDragEventArgs : EventArgs // TypeDefIndex: 5539
{
	// Fields
	internal int key_state; // 0x10
	internal bool escape_pressed; // 0x14
	internal DragAction drag_action; // 0x18

	// Properties
	public DragAction Action { get; }

	// Methods

	// RVA: 0x23A5ED0 Offset: 0x23A48D0 VA: 0x1823A5ED0
	public void .ctor(int keyState, bool escapePressed, DragAction action) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public DragAction get_Action() { }
}
