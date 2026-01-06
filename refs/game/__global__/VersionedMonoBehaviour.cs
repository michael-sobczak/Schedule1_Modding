public abstract class VersionedMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver, IVersionedMonoBehaviourInternal // TypeDefIndex: 13311
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private int version; // 0x20

	// Methods

	// RVA: 0xB7B5D0 Offset: 0xB79FD0 VA: 0x180B7B5D0 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0xB7B6B0 Offset: 0xB7A0B0 VA: 0x180B7B6B0 Slot: 8
	protected virtual void Reset() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0xB7B6E0 Offset: 0xB7A0E0 VA: 0x180B7B6E0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 9
	protected virtual int OnUpgradeSerializedData(int version, bool unityThread) { }

	// RVA: 0xB7B640 Offset: 0xB7A040 VA: 0x180B7B640 Slot: 6
	private void Pathfinding.IVersionedMonoBehaviourInternal.UpgradeFromUnityThread() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
