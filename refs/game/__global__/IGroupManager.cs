internal interface IGroupManager // TypeDefIndex: 6689
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Init(IGroupBox groupBox);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnOptionSelectionChanged(IGroupBoxOption selectedOption);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RegisterOption(IGroupBoxOption option);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void UnregisterOption(IGroupBoxOption option);
}
