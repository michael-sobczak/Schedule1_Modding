internal class DefaultGroupManager : IGroupManager // TypeDefIndex: 6690
{
	// Fields
	private List<IGroupBoxOption> m_GroupOptions; // 0x10
	private IGroupBoxOption m_SelectedOption; // 0x18
	private IGroupBox m_GroupBox; // 0x20

	// Methods

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0 Slot: 4
	public void Init(IGroupBox groupBox) { }

	// RVA: 0x2EA1450 Offset: 0x2E9FE50 VA: 0x182EA1450 Slot: 5
	public void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	// RVA: 0x2EA1620 Offset: 0x2EA0020 VA: 0x182EA1620 Slot: 6
	public void RegisterOption(IGroupBoxOption option) { }

	// RVA: 0x2EA1720 Offset: 0x2EA0120 VA: 0x182EA1720 Slot: 7
	public void UnregisterOption(IGroupBoxOption option) { }

	// RVA: 0x2EA17A0 Offset: 0x2EA01A0 VA: 0x182EA17A0
	public void .ctor() { }
}
