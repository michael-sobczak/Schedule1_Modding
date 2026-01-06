public class GiveFeedbackEventArgs : EventArgs // TypeDefIndex: 5383
{
	// Fields
	internal DragDropEffects effect; // 0x10
	internal bool use_default_cursors; // 0x14

	// Properties
	public bool UseDefaultCursors { get; }

	// Methods

	// RVA: 0x23410A0 Offset: 0x233FAA0 VA: 0x1823410A0
	public void .ctor(DragDropEffects effect, bool useDefaultCursors) { }

	// RVA: 0x60D730 Offset: 0x60C130 VA: 0x18060D730
	public bool get_UseDefaultCursors() { }
}
