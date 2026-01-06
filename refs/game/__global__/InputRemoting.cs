public sealed class InputRemoting : IObservable<InputRemoting.Message>, IObserver<InputRemoting.Message> // TypeDefIndex: 7403
{
	// Fields
	private InputRemoting.Flags m_Flags; // 0x10
	private InputManager m_LocalManager; // 0x18
	private InputRemoting.Subscriber[] m_Subscribers; // 0x20
	private InputRemoting.RemoteSender[] m_Senders; // 0x28

	// Properties
	public bool sending { get; set; }
	internal InputManager manager { get; }

	// Methods

	// RVA: 0x1CE51A0 Offset: 0x1CE3BA0 VA: 0x181CE51A0
	public bool get_sending() { }

	// RVA: 0x2818C90 Offset: 0x2817690 VA: 0x182818C90
	private void set_sending(bool value) { }

	// RVA: 0x2818BF0 Offset: 0x28175F0 VA: 0x182818BF0
	internal void .ctor(InputManager manager, bool startSendingOnConnect = False) { }

	// RVA: 0x2818420 Offset: 0x2816E20 VA: 0x182818420
	public void StartSending() { }

	// RVA: 0x28185F0 Offset: 0x2816FF0 VA: 0x1828185F0
	public void StopSending() { }

	// RVA: 0x28188B0 Offset: 0x28172B0 VA: 0x1828188B0 Slot: 5
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(InputRemoting.Message msg) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x28187B0 Offset: 0x28171B0 VA: 0x1828187B0 Slot: 4
	public IDisposable Subscribe(IObserver<InputRemoting.Message> observer) { }

	// RVA: 0x28180E0 Offset: 0x2816AE0 VA: 0x1828180E0
	private void SendInitialMessages() { }

	// RVA: 0x2817C80 Offset: 0x2816680 VA: 0x182817C80
	private void SendAllGeneratedLayouts() { }

	// RVA: 0x2818230 Offset: 0x2816C30 VA: 0x182818230
	private void SendLayout(string layoutName) { }

	// RVA: 0x2817A80 Offset: 0x2816480 VA: 0x182817A80
	private void SendAllDevices() { }

	// RVA: 0x2817FE0 Offset: 0x28169E0 VA: 0x182817FE0
	private void SendDevice(InputDevice device) { }

	// RVA: 0x2818070 Offset: 0x2816A70 VA: 0x182818070
	private void SendEvent(InputEventPtr eventPtr, InputDevice device) { }

	// RVA: 0x2817E80 Offset: 0x2816880 VA: 0x182817E80
	private void SendDeviceChange(InputDevice device, InputDeviceChange change) { }

	// RVA: 0x2818100 Offset: 0x2816B00 VA: 0x182818100
	private void SendLayoutChange(string layout, InputControlLayoutChange change) { }

	// RVA: 0x28182F0 Offset: 0x2816CF0 VA: 0x1828182F0
	private void Send(InputRemoting.Message msg) { }

	// RVA: 0x2817840 Offset: 0x2816240 VA: 0x182817840
	private int FindOrCreateSenderRecord(int senderId) { }

	// RVA: 0x2817740 Offset: 0x2816140 VA: 0x182817740
	private static InternedString BuildLayoutNamespace(int senderId) { }

	// RVA: 0x28177C0 Offset: 0x28161C0 VA: 0x1828177C0
	private int FindLocalDeviceId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x2818BC0 Offset: 0x28175C0 VA: 0x182818BC0
	private InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal InputManager get_manager() { }

	// RVA: 0x2817900 Offset: 0x2816300 VA: 0x182817900
	public void RemoveRemoteDevices(int participantId) { }

	// RVA: -1 Offset: -1
	private static byte[] SerializeData<TData>(TData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDFC20 Offset: 0xEDE620 VA: 0x180EDFC20
	|-InputRemoting.SerializeData<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xEDFBA0 Offset: 0xEDE5A0 VA: 0x180EDFBA0
	|-InputRemoting.SerializeData<InputRemoting.ChangeUsageMsg.Data>
	|
	|-RVA: 0xEDFA50 Offset: 0xEDE450 VA: 0x180EDFA50
	|-InputRemoting.SerializeData<InputRemoting.NewDeviceMsg.Data>
	|
	|-RVA: 0xEDFB10 Offset: 0xEDE510 VA: 0x180EDFB10
	|-InputRemoting.SerializeData<InputRemoting.NewLayoutMsg.Data>
	*/

	// RVA: -1 Offset: -1
	private static TData DeserializeData<TData>(byte[] data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDF970 Offset: 0xEDE370 VA: 0x180EDF970
	|-InputRemoting.DeserializeData<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xEDF850 Offset: 0xEDE250 VA: 0x180EDF850
	|-InputRemoting.DeserializeData<InputRemoting.ChangeUsageMsg.Data>
	|
	|-RVA: 0xEDF5D0 Offset: 0xEDDFD0 VA: 0x180EDF5D0
	|-InputRemoting.DeserializeData<InputRemoting.NewDeviceMsg.Data>
	|
	|-RVA: 0xEDF720 Offset: 0xEDE120 VA: 0x180EDF720
	|-InputRemoting.DeserializeData<InputRemoting.NewLayoutMsg.Data>
	*/
}
