public abstract class MouseManipulator : Manipulator // TypeDefIndex: 6707
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private List<ManipulatorActivationFilter> <activators>k__BackingField; // 0x18
	private ManipulatorActivationFilter m_currentActivator; // 0x20

	// Properties
	public List<ManipulatorActivationFilter> activators { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<ManipulatorActivationFilter> get_activators() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_activators(List<ManipulatorActivationFilter> value) { }

	// RVA: 0x2EAB890 Offset: 0x2EAA290 VA: 0x182EAB890
	protected void .ctor() { }

	// RVA: 0x2EAB650 Offset: 0x2EAA050 VA: 0x182EAB650
	protected bool CanStartManipulation(IMouseEvent e) { }

	// RVA: 0x2EAB820 Offset: 0x2EAA220 VA: 0x182EAB820
	protected bool CanStopManipulation(IMouseEvent e) { }
}
