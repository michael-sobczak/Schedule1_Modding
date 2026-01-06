public abstract class ObserverCondition : ScriptableObject // TypeDefIndex: 12561
{
	// Fields
	[HideInInspector]
	public NetworkObject NetworkObject; // 0x18
	private bool _isEnabled; // 0x20

	// Methods

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool GetIsEnabled() { }

	// RVA: 0xD3A940 Offset: 0xD39340 VA: 0x180D3A940
	public void SetIsEnabled(bool value) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0 Slot: 4
	public virtual void Initialize(NetworkObject networkObject) { }

	// RVA: 0x50B620 Offset: 0x50A020 VA: 0x18050B620 Slot: 5
	public virtual void Deinitialize(bool destroyed) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ConditionMet(NetworkConnection connection, bool currentlyAdded, out bool notProcessed);

	[Obsolete("Use GetConditionType()")]
	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public virtual bool Timed() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	public virtual ObserverConditionType GetConditionType() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ObserverCondition Clone();

	// RVA: 0xD27D30 Offset: 0xD26730 VA: 0x180D27D30
	protected void .ctor() { }
}
