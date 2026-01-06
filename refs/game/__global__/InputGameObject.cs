public class InputGameObject : CGModule // TypeDefIndex: 10727
{
	// Fields
	[HideInInspector]
	[OutputSlotInfo(typeof(CGGameObject), Array = True)]
	public CGModuleOutputSlot OutGameObject; // 0xC0
	[SerializeField]
	[ArrayEx]
	private List<CGGameObjectProperties> m_GameObjects; // 0xC8

	// Properties
	public List<CGGameObjectProperties> GameObjects { get; }
	public bool SupportsIPE { get; }

	// Methods

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	public List<CGGameObjectProperties> get_GameObjects() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool get_SupportsIPE() { }

	// RVA: 0x532940 Offset: 0x531340 VA: 0x180532940 Slot: 13
	public override void Reset() { }

	// RVA: 0x5326D0 Offset: 0x5310D0 VA: 0x1805326D0 Slot: 14
	public override void Refresh() { }

	// RVA: 0x532660 Offset: 0x531060 VA: 0x180532660 Slot: 17
	public override void OnTemplateCreated() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x5329B0 Offset: 0x5313B0 VA: 0x1805329B0
	private void WarnAboutInvalidInputs() { }

	// RVA: 0x532B20 Offset: 0x531520 VA: 0x180532B20
	public void .ctor() { }
}
