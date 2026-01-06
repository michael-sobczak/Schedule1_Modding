public class CallManager : Singleton<CallManager> // TypeDefIndex: 2093
{
	// Fields
	[CompilerGenerated]
	private PhoneCallData <QueuedCallData>k__BackingField; // 0x28
	[CompilerGenerated]
	private Action<PhoneCallData> OnCallQueued; // 0x30

	// Properties
	private PhoneCallData QueuedCallData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	private PhoneCallData get_QueuedCallData() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_QueuedCallData(PhoneCallData value) { }

	[CompilerGenerated]
	// RVA: 0x7FFF90 Offset: 0x7FE990 VA: 0x1807FFF90
	public void add_OnCallQueued(Action<PhoneCallData> value) { }

	[CompilerGenerated]
	// RVA: 0x800040 Offset: 0x7FEA40 VA: 0x180800040
	public void remove_OnCallQueued(Action<PhoneCallData> value) { }

	// RVA: 0x7FFD20 Offset: 0x7FE720 VA: 0x1807FFD20 Slot: 4
	protected override void Start() { }

	// RVA: 0x7FFAE0 Offset: 0x7FE4E0 VA: 0x1807FFAE0 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x7FFCD0 Offset: 0x7FE6D0 VA: 0x1807FFCD0
	public void QueueCall(PhoneCallData data) { }

	// RVA: 0x7FFA90 Offset: 0x7FE490 VA: 0x1807FFA90
	public void ClearQueuedCall() { }

	// RVA: 0x7FF9F0 Offset: 0x7FE3F0 VA: 0x1807FF9F0
	private void CallCompleted(PhoneCallData call) { }

	// RVA: 0x7FFF50 Offset: 0x7FE950 VA: 0x1807FFF50
	public void .ctor() { }
}
