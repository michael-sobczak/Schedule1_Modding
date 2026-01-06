public class MonoBehaviour : Behaviour // TypeDefIndex: 11834
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Properties
	public CancellationToken destroyCancellationToken { get; }
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x2CBFEC0 Offset: 0x2CBE8C0 VA: 0x182CBFEC0
	public CancellationToken get_destroyCancellationToken() { }

	[RequiredByNativeCode]
	// RVA: 0x2CBF760 Offset: 0x2CBE160 VA: 0x182CBF760
	private void RaiseCancellation() { }

	// RVA: 0x2CBF4B0 Offset: 0x2CBDEB0 VA: 0x182CBF4B0
	public bool IsInvoking() { }

	// RVA: 0x2CBF3E0 Offset: 0x2CBDDE0 VA: 0x182CBF3E0
	public void CancelInvoke() { }

	// RVA: 0x2CBF630 Offset: 0x2CBE030 VA: 0x182CBF630
	public void Invoke(string methodName, float time) { }

	// RVA: 0x2CBF560 Offset: 0x2CBDF60 VA: 0x182CBF560
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x2CBF420 Offset: 0x2CBDE20 VA: 0x182CBF420
	public void CancelInvoke(string methodName) { }

	// RVA: 0x2CBF690 Offset: 0x2CBE090 VA: 0x182CBF690
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocs]
	// RVA: 0x2CBF940 Offset: 0x2CBE340 VA: 0x182CBF940
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x2CBFA50 Offset: 0x2CBE450 VA: 0x182CBFA50
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x2CBF830 Offset: 0x2CBE230 VA: 0x182CBF830
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", False)]
	// RVA: 0x2CBF830 Offset: 0x2CBE230 VA: 0x182CBF830
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x2CBFDB0 Offset: 0x2CBE7B0 VA: 0x182CBFDB0
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x2CBFCA0 Offset: 0x2CBE6A0 VA: 0x182CBFCA0
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x2CBFC50 Offset: 0x2CBE650 VA: 0x182CBFC50
	public void StopCoroutine(string methodName) { }

	// RVA: 0x2CBFB70 Offset: 0x2CBE570 VA: 0x182CBFB70
	public void StopAllCoroutines() { }

	// RVA: 0x2CC0050 Offset: 0x2CBEA50 VA: 0x182CC0050
	public bool get_useGUILayout() { }

	// RVA: 0x2CC00E0 Offset: 0x2CBEAE0 VA: 0x182CC00E0
	public void set_useGUILayout(bool value) { }

	// RVA: 0x2CC0090 Offset: 0x2CBEA90 VA: 0x182CC0090
	public static void print(object message) { }

	[FreeFunction("CancelInvoke")]
	// RVA: 0x2CBF3E0 Offset: 0x2CBDDE0 VA: 0x182CBF3E0
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunction("IsInvoking")]
	// RVA: 0x2CBF4B0 Offset: 0x2CBDEB0 VA: 0x182CBF4B0
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunction]
	// RVA: 0x2CBF4F0 Offset: 0x2CBDEF0 VA: 0x182CBF4F0
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunction]
	// RVA: 0x2CBF420 Offset: 0x2CBDE20 VA: 0x182CBF420
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x2CBF690 Offset: 0x2CBE090 VA: 0x182CBF690
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x2CBF6E0 Offset: 0x2CBE0E0 VA: 0x182CBF6E0
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x2CBF7D0 Offset: 0x2CBE1D0 VA: 0x182CBF7D0
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x2CBF780 Offset: 0x2CBE180 VA: 0x182CBF780
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x2CBFC00 Offset: 0x2CBE600 VA: 0x182CBFC00
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x2CBFBB0 Offset: 0x2CBE5B0 VA: 0x182CBFBB0
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x2CBF470 Offset: 0x2CBDE70 VA: 0x182CBF470
	internal string GetScriptClassName() { }

	// RVA: 0x2CBF720 Offset: 0x2CBE120 VA: 0x182CBF720
	private void OnCancellationTokenCreated() { }

	// RVA: 0x2CB9B50 Offset: 0x2CB8550 VA: 0x182CB9B50
	public void .ctor() { }
}
