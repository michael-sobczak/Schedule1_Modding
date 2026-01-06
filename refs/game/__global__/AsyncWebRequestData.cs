internal struct AsyncWebRequestData // TypeDefIndex: 17989
{
	// Fields
	[CompilerGenerated]
	private readonly UnityWebRequest <Request>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly AsyncOperation <Operation>k__BackingField; // 0x8

	// Properties
	public UnityWebRequest Request { get; }
	public AsyncOperation Operation { get; }
	public bool OperationIsDone { get; }
	public bool RequestIsError { get; }
	public string ErrorText { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public UnityWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public AsyncOperation get_Operation() { }

	// RVA: 0x43C790 Offset: 0x43B190 VA: 0x18043C790
	public bool get_OperationIsDone() { }

	// RVA: 0x43C7C0 Offset: 0x43B1C0 VA: 0x18043C7C0
	public bool get_RequestIsError() { }

	// RVA: 0x43C6F0 Offset: 0x43B0F0 VA: 0x18043C6F0
	public string get_ErrorText() { }

	// RVA: 0x43C6B0 Offset: 0x43B0B0 VA: 0x18043C6B0
	public void .ctor(UnityWebRequest request, AsyncOperation operation) { }
}
