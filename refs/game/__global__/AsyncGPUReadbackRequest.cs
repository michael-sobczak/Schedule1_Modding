public struct AsyncGPUReadbackRequest // TypeDefIndex: 12155
{
	// Fields
	internal IntPtr m_Ptr; // 0x0
	internal int m_Version; // 0x8

	// Properties
	public bool done { get; }
	public bool hasError { get; }
	public int layerCount { get; }
	public int layerDataSize { get; }

	// Methods

	// RVA: 0x2CD4370 Offset: 0x2CD2D70 VA: 0x182CD4370
	public void WaitForCompletion() { }

	// RVA: -1 Offset: -1
	public NativeArray<T> GetData<T>(int layer = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4F240 Offset: 0xE4DC40 VA: 0x180E4F240
	|-AsyncGPUReadbackRequest.GetData<byte>
	|
	|-RVA: 0xE4F5B0 Offset: 0xE4DFB0 VA: 0x180E4F5B0
	|-AsyncGPUReadbackRequest.GetData<uint>
	|
	|-RVA: 0xE4F3E0 Offset: 0xE4DDE0 VA: 0x180E4F3E0
	|-AsyncGPUReadbackRequest.GetData<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2CD42E0 Offset: 0x2CD2CE0 VA: 0x182CD42E0
	public bool get_done() { }

	// RVA: 0x2CD42A0 Offset: 0x2CD2CA0 VA: 0x182CD42A0
	public bool get_hasError() { }

	// RVA: 0x2CD4220 Offset: 0x2CD2C20 VA: 0x182CD4220
	public int get_layerCount() { }

	// RVA: 0x2CD4260 Offset: 0x2CD2C60 VA: 0x182CD4260
	public int get_layerDataSize() { }

	// RVA: 0x2CD42E0 Offset: 0x2CD2CE0 VA: 0x182CD42E0
	private bool IsDone() { }

	// RVA: 0x2CD42A0 Offset: 0x2CD2CA0 VA: 0x182CD42A0
	private bool HasError() { }

	// RVA: 0x2CD4220 Offset: 0x2CD2C20 VA: 0x182CD4220
	private int GetLayerCount() { }

	// RVA: 0x2CD4260 Offset: 0x2CD2C60 VA: 0x182CD4260
	private int GetLayerDataSize() { }

	// RVA: 0x2CD4320 Offset: 0x2CD2D20 VA: 0x182CD4320
	internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x2CD41E0 Offset: 0x2CD2BE0 VA: 0x182CD41E0
	private IntPtr GetDataRaw(int layer) { }

	// RVA: 0x2CD4370 Offset: 0x2CD2D70 VA: 0x182CD4370
	private static void WaitForCompletion_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x2CD42E0 Offset: 0x2CD2CE0 VA: 0x182CD42E0
	private static bool IsDone_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x2CD42A0 Offset: 0x2CD2CA0 VA: 0x182CD42A0
	private static bool HasError_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x2CD4220 Offset: 0x2CD2C20 VA: 0x182CD4220
	private static int GetLayerCount_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x2CD4260 Offset: 0x2CD2C60 VA: 0x182CD4260
	private static int GetLayerDataSize_Injected(ref AsyncGPUReadbackRequest _unity_self) { }

	// RVA: 0x2CD4320 Offset: 0x2CD2D20 VA: 0x182CD4320
	private static void SetScriptingCallback_Injected(ref AsyncGPUReadbackRequest _unity_self, Action<AsyncGPUReadbackRequest> callback) { }

	// RVA: 0x2CD41E0 Offset: 0x2CD2BE0 VA: 0x182CD41E0
	private static IntPtr GetDataRaw_Injected(ref AsyncGPUReadbackRequest _unity_self, int layer) { }
}
