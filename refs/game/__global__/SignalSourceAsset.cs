public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D // TypeDefIndex: 16182
{
	// Properties
	public abstract float SignalDuration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_SignalDuration();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot);

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	protected void .ctor() { }
}
