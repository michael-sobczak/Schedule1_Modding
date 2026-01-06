internal class RepaintData // TypeDefIndex: 6722
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Matrix4x4 <currentOffset>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <mousePosition>k__BackingField; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Rect <currentWorldClip>k__BackingField; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Event <repaintEvent>k__BackingField; // 0x68

	// Properties
	public Matrix4x4 currentOffset { get; }
	public Rect currentWorldClip { get; }
	public Event repaintEvent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x166C230 Offset: 0x166AC30 VA: 0x18166C230
	public Matrix4x4 get_currentOffset() { }

	[CompilerGenerated]
	// RVA: 0x4F9F10 Offset: 0x4F8910 VA: 0x1804F9F10
	public Rect get_currentWorldClip() { }

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Event get_repaintEvent() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_repaintEvent(Event value) { }

	// RVA: 0x2EB4760 Offset: 0x2EB3160 VA: 0x182EB4760
	public void .ctor() { }
}
