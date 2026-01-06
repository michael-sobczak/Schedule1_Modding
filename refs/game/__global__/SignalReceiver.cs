public class SignalReceiver : MonoBehaviour, INotificationReceiver // TypeDefIndex: 17422
{
	// Fields
	[SerializeField]
	private SignalReceiver.EventKeyValue m_Events; // 0x20

	// Methods

	// RVA: 0x2C4ADB0 Offset: 0x2C497B0 VA: 0x182C4ADB0 Slot: 4
	public void OnNotify(Playable origin, INotification notification, object context) { }

	// RVA: 0x2C4A6F0 Offset: 0x2C490F0 VA: 0x182C4A6F0
	public void AddReaction(SignalAsset asset, UnityEvent reaction) { }

	// RVA: 0x2C4A680 Offset: 0x2C49080 VA: 0x182C4A680
	public int AddEmptyReaction(UnityEvent reaction) { }

	// RVA: 0x2C4AFD0 Offset: 0x2C499D0 VA: 0x182C4AFD0
	public void Remove(SignalAsset asset) { }

	// RVA: 0x250EFB0 Offset: 0x250D9B0 VA: 0x18250EFB0
	public IEnumerable<SignalAsset> GetRegisteredSignals() { }

	// RVA: 0x2C4ACB0 Offset: 0x2C496B0 VA: 0x182C4ACB0
	public UnityEvent GetReaction(SignalAsset key) { }

	// RVA: 0x2C4ABA0 Offset: 0x2C495A0 VA: 0x182C4ABA0
	public int Count() { }

	// RVA: 0x2C4A920 Offset: 0x2C49320 VA: 0x182C4A920
	public void ChangeSignalAtIndex(int idx, SignalAsset newKey) { }

	// RVA: 0x2C4AED0 Offset: 0x2C498D0 VA: 0x182C4AED0
	public void RemoveAtIndex(int idx) { }

	// RVA: 0x2C4A850 Offset: 0x2C49250 VA: 0x182C4A850
	public void ChangeReactionAtIndex(int idx, UnityEvent reaction) { }

	// RVA: 0x2C4ABF0 Offset: 0x2C495F0 VA: 0x182C4ABF0
	public UnityEvent GetReactionAtIndex(int idx) { }

	// RVA: 0x2C4ACF0 Offset: 0x2C496F0 VA: 0x182C4ACF0
	public SignalAsset GetSignalAssetAtIndex(int idx) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnEnable() { }

	// RVA: 0x2C4B120 Offset: 0x2C49B20 VA: 0x182C4B120
	public void .ctor() { }
}
