public class SignalEmitter : Marker, INotification, INotificationOptionProvider // TypeDefIndex: 17420
{
	// Fields
	[SerializeField]
	private bool m_Retroactive; // 0x28
	[SerializeField]
	private bool m_EmitOnce; // 0x29
	[SerializeField]
	private SignalAsset m_Asset; // 0x30

	// Properties
	public bool retroactive { get; set; }
	public bool emitOnce { get; set; }
	public SignalAsset asset { get; set; }
	private PropertyName UnityEngine.Playables.INotification.id { get; }
	private NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags { get; }

	// Methods

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_retroactive() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_retroactive(bool value) { }

	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_emitOnce() { }

	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	public void set_emitOnce(bool value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public SignalAsset get_asset() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_asset(SignalAsset value) { }

	// RVA: 0x2C4A590 Offset: 0x2C48F90 VA: 0x182C4A590 Slot: 9
	private PropertyName UnityEngine.Playables.INotification.get_id() { }

	// RVA: 0x2C4A650 Offset: 0x2C49050 VA: 0x182C4A650 Slot: 10
	private NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags() { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }
}
