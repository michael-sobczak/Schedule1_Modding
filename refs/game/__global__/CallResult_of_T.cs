public sealed class CallResult<T> : CallResult, IDisposable // TypeDefIndex: 14708
{
	// Fields
	[CompilerGenerated]
	private CallResult.APIDispatchDelegate<T> m_Func; // 0x0
	private SteamAPICall_t m_hAPICall; // 0x0
	private bool m_bDisposed; // 0x0

	// Properties
	public SteamAPICall_t Handle { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void add_m_Func(CallResult.APIDispatchDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436CC0 Offset: 0x14356C0 VA: 0x181436CC0
	|-CallResult<EncryptedAppTicketResponse_t>.add_m_Func
	|-CallResult<__Il2CppFullySharedGenericType>.add_m_Func
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void remove_m_Func(CallResult.APIDispatchDelegate<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436D90 Offset: 0x1435790 VA: 0x181436D90
	|-CallResult<EncryptedAppTicketResponse_t>.remove_m_Func
	|-CallResult<__Il2CppFullySharedGenericType>.remove_m_Func
	*/

	// RVA: -1 Offset: -1
	public SteamAPICall_t get_Handle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	|-CallResult<EncryptedAppTicketResponse_t>.get_Handle
	|-CallResult<__Il2CppFullySharedGenericType>.get_Handle
	*/

	// RVA: -1 Offset: -1
	public static CallResult<T> Create(CallResult.APIDispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1435E60 Offset: 0x1434860 VA: 0x181435E60
	|-CallResult<EncryptedAppTicketResponse_t>.Create
	|
	|-RVA: 0x1435DA0 Offset: 0x14347A0 VA: 0x181435DA0
	|-CallResult<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CallResult.APIDispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436BC0 Offset: 0x14355C0 VA: 0x181436BC0
	|-CallResult<EncryptedAppTicketResponse_t>..ctor
	|
	|-RVA: 0x1436C40 Offset: 0x1435640 VA: 0x181436C40
	|-CallResult<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14360C0 Offset: 0x1434AC0 VA: 0x1814360C0
	|-CallResult<EncryptedAppTicketResponse_t>.Finalize
	|
	|-RVA: 0x1436220 Offset: 0x1434C20 VA: 0x181436220
	|-CallResult<__Il2CppFullySharedGenericType>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1435FC0 Offset: 0x14349C0 VA: 0x181435FC0
	|-CallResult<EncryptedAppTicketResponse_t>.Dispose
	|
	|-RVA: 0x1435F40 Offset: 0x1434940 VA: 0x181435F40
	|-CallResult<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Set(SteamAPICall_t hAPICall, CallResult.APIDispatchDelegate<T> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14368C0 Offset: 0x14352C0 VA: 0x1814368C0
	|-CallResult<EncryptedAppTicketResponse_t>.Set
	|
	|-RVA: 0x1436A40 Offset: 0x1435440 VA: 0x181436A40
	|-CallResult<__Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public bool IsActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436360 Offset: 0x1434D60 VA: 0x181436360
	|-CallResult<EncryptedAppTicketResponse_t>.IsActive
	|
	|-RVA: 0x14363D0 Offset: 0x1434DD0 VA: 0x1814363D0
	|-CallResult<__Il2CppFullySharedGenericType>.IsActive
	*/

	// RVA: -1 Offset: -1
	public void Cancel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1435C60 Offset: 0x1434660 VA: 0x181435C60
	|-CallResult<EncryptedAppTicketResponse_t>.Cancel
	|
	|-RVA: 0x1435D20 Offset: 0x1434720 VA: 0x181435D20
	|-CallResult<__Il2CppFullySharedGenericType>.Cancel
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override Type GetCallbackType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436300 Offset: 0x1434D00 VA: 0x181436300
	|-CallResult<EncryptedAppTicketResponse_t>.GetCallbackType
	|
	|-RVA: 0x14362A0 Offset: 0x1434CA0 VA: 0x1814362A0
	|-CallResult<__Il2CppFullySharedGenericType>.GetCallbackType
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436440 Offset: 0x1434E40 VA: 0x181436440
	|-CallResult<EncryptedAppTicketResponse_t>.OnRunCallResult
	|
	|-RVA: 0x14365E0 Offset: 0x1434FE0 VA: 0x1814365E0
	|-CallResult<__Il2CppFullySharedGenericType>.OnRunCallResult
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override void SetUnregistered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1436860 Offset: 0x1435260 VA: 0x181436860
	|-CallResult<EncryptedAppTicketResponse_t>.SetUnregistered
	|
	|-RVA: 0x1436800 Offset: 0x1435200 VA: 0x181436800
	|-CallResult<__Il2CppFullySharedGenericType>.SetUnregistered
	*/
}
