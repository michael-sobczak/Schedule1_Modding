internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<InputRemoting.Message>, IObservable<InputRemoting.Message> // TypeDefIndex: 7405
{
	// Fields
	public static readonly Guid kNewDeviceMsg; // 0x0
	public static readonly Guid kNewLayoutMsg; // 0x10
	public static readonly Guid kNewEventsMsg; // 0x20
	public static readonly Guid kRemoveDeviceMsg; // 0x30
	public static readonly Guid kChangeUsagesMsg; // 0x40
	public static readonly Guid kStartSendingMsg; // 0x50
	public static readonly Guid kStopSendingMsg; // 0x60
	[SerializeField]
	private IEditorPlayerConnection m_Connection; // 0x18
	private RemoteInputPlayerConnection.Subscriber[] m_Subscribers; // 0x20
	[SerializeField]
	private int[] m_ConnectedIds; // 0x28

	// Methods

	// RVA: 0x281A7C0 Offset: 0x28191C0 VA: 0x18281A7C0
	public void Bind(IEditorPlayerConnection connection, bool isConnected) { }

	// RVA: 0x281B370 Offset: 0x2819D70 VA: 0x18281B370 Slot: 7
	public IDisposable Subscribe(IObserver<InputRemoting.Message> observer) { }

	// RVA: 0x281AFB0 Offset: 0x28199B0 VA: 0x18281AFB0
	private void OnConnected(int id) { }

	// RVA: 0x281B070 Offset: 0x2819A70 VA: 0x18281B070
	private void OnDisconnected(int id) { }

	// RVA: 0x281B140 Offset: 0x2819B40 VA: 0x18281B140
	private void OnNewDevice(MessageEventArgs args) { }

	// RVA: 0x281B160 Offset: 0x2819B60 VA: 0x18281B160
	private void OnNewLayout(MessageEventArgs args) { }

	// RVA: 0x281B150 Offset: 0x2819B50 VA: 0x18281B150
	private void OnNewEvents(MessageEventArgs args) { }

	// RVA: 0x281B170 Offset: 0x2819B70 VA: 0x18281B170
	private void OnRemoveDevice(MessageEventArgs args) { }

	// RVA: 0x281AFA0 Offset: 0x28199A0 VA: 0x18281AFA0
	private void OnChangeUsages(MessageEventArgs args) { }

	// RVA: 0x281B180 Offset: 0x2819B80 VA: 0x18281B180
	private void OnStartSending(MessageEventArgs args) { }

	// RVA: 0x281B190 Offset: 0x2819B90 VA: 0x18281B190
	private void OnStopSending(MessageEventArgs args) { }

	// RVA: 0x281B1A0 Offset: 0x2819BA0 VA: 0x18281B1A0
	private void SendToSubscribers(InputRemoting.MessageType type, MessageEventArgs args) { }

	// RVA: 0x281B580 Offset: 0x2819F80 VA: 0x18281B580 Slot: 4
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(InputRemoting.Message msg) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	private void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }

	// RVA: 0x281B750 Offset: 0x281A150 VA: 0x18281B750
	private static void .cctor() { }
}
