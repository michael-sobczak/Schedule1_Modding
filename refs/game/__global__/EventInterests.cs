internal struct EventInterests // TypeDefIndex: 17584
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <wantsMouseMove>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; // 0x1
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <wantsLessLayoutEvents>k__BackingField; // 0x2

	// Properties
	public bool wantsMouseMove { get; set; }
	public bool wantsMouseEnterLeaveWindow { get; set; }
	public bool wantsLessLayoutEvents { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4C5450 Offset: 0x4C3E50 VA: 0x1804C5450
	public bool get_wantsMouseMove() { }

	[CompilerGenerated]
	// RVA: 0x131D950 Offset: 0x131C350 VA: 0x18131D950
	public void set_wantsMouseMove(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x109F810 Offset: 0x109E210 VA: 0x18109F810
	public bool get_wantsMouseEnterLeaveWindow() { }

	[CompilerGenerated]
	// RVA: 0x2776630 Offset: 0x2775030 VA: 0x182776630
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1CDBFD0 Offset: 0x1CDA9D0 VA: 0x181CDBFD0
	public bool get_wantsLessLayoutEvents() { }

	// RVA: 0x2D00F20 Offset: 0x2CFF920 VA: 0x182D00F20
	public bool WantsEvent(EventType type) { }

	// RVA: 0x2D00F40 Offset: 0x2CFF940 VA: 0x182D00F40
	public bool WantsLayoutPass(EventType type) { }
}
