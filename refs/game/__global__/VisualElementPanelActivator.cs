internal class VisualElementPanelActivator // TypeDefIndex: 7045
{
	// Fields
	private IVisualElementPanelActivatable m_Activatable; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isActive>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isDetaching>k__BackingField; // 0x19
	private EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback; // 0x20
	private EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback; // 0x28

	// Properties
	public bool isActive { get; set; }
	public bool isDetaching { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4971B0 Offset: 0x495BB0 VA: 0x1804971B0
	public bool get_isActive() { }

	[CompilerGenerated]
	// RVA: 0x698000 Offset: 0x696A00 VA: 0x180698000
	private void set_isActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0xCD85E0 Offset: 0xCD6FE0 VA: 0x180CD85E0
	public bool get_isDetaching() { }

	[CompilerGenerated]
	// RVA: 0xCD85F0 Offset: 0xCD6FF0 VA: 0x180CD85F0
	private void set_isDetaching(bool value) { }

	// RVA: 0x2E0E550 Offset: 0x2E0CF50 VA: 0x182E0E550
	public void .ctor(IVisualElementPanelActivatable activatable) { }

	// RVA: 0x2E0E3F0 Offset: 0x2E0CDF0 VA: 0x182E0E3F0
	public void SetActive(bool action) { }

	// RVA: 0x2E0E310 Offset: 0x2E0CD10 VA: 0x182E0E310
	public void SendActivation() { }

	// RVA: 0x2E0E380 Offset: 0x2E0CD80 VA: 0x182E0E380
	public void SendDeactivation() { }

	// RVA: 0x2E0E2A0 Offset: 0x2E0CCA0 VA: 0x182E0E2A0
	private void OnEnter(AttachToPanelEvent evt) { }

	// RVA: 0x2E0E2B0 Offset: 0x2E0CCB0 VA: 0x182E0E2B0
	private void OnLeave(DetachFromPanelEvent evt) { }
}
