public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter> // TypeDefIndex: 6702
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private MouseButton <button>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private EventModifiers <modifiers>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x8

	// Properties
	public MouseButton button { get; set; }
	public EventModifiers modifiers { get; set; }
	public int clickCount { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public MouseButton get_button() { }

	[CompilerGenerated]
	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_button(MouseButton value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x50B590 Offset: 0x509F90 VA: 0x18050B590
	public EventModifiers get_modifiers() { }

	[CompilerGenerated]
	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_modifiers(EventModifiers value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_clickCount() { }

	// RVA: 0x2EAA2E0 Offset: 0x2EA8CE0 VA: 0x182EAA2E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CDE060 Offset: 0x2CDCA60 VA: 0x182CDE060 Slot: 4
	public bool Equals(ManipulatorActivationFilter other) { }

	// RVA: 0x2EAA390 Offset: 0x2EA8D90 VA: 0x182EAA390 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2EAA730 Offset: 0x2EA9130 VA: 0x182EAA730
	public bool Matches(IMouseEvent e) { }

	// RVA: 0x2EAA4F0 Offset: 0x2EA8EF0 VA: 0x182EAA4F0
	private bool HasModifiers(IMouseEvent e) { }

	// RVA: 0x2EAA660 Offset: 0x2EA9060 VA: 0x182EAA660
	public bool Matches(IPointerEvent e) { }

	// RVA: 0x2EAA400 Offset: 0x2EA8E00 VA: 0x182EAA400
	private bool HasModifiers(IPointerEvent e) { }

	// RVA: 0x2EAA5E0 Offset: 0x2EA8FE0 VA: 0x182EAA5E0
	private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command) { }
}
