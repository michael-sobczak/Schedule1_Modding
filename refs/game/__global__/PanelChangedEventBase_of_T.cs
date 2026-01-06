public abstract class PanelChangedEventBase<T> : EventBase<T> // TypeDefIndex: 6609
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private IPanel <originPanel>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private IPanel <destinationPanel>k__BackingField; // 0x0

	// Properties
	public IPanel originPanel { get; set; }
	public IPanel destinationPanel { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public IPanel get_originPanel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	|-PanelChangedEventBase<object>.get_originPanel
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_originPanel(IPanel value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	|-PanelChangedEventBase<object>.set_originPanel
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public IPanel get_destinationPanel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	|-PanelChangedEventBase<object>.get_destinationPanel
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_destinationPanel(IPanel value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	|-PanelChangedEventBase<object>.set_destinationPanel
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0290 Offset: 0x10EEC90 VA: 0x1810F0290
	|-PanelChangedEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F02F0 Offset: 0x10EECF0 VA: 0x1810F02F0
	|-PanelChangedEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(IPanel originPanel, IPanel destinationPanel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0190 Offset: 0x10EEB90 VA: 0x1810F0190
	|-PanelChangedEventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0330 Offset: 0x10EED30 VA: 0x1810F0330
	|-PanelChangedEventBase<object>..ctor
	*/
}
