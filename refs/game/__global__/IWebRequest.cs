internal interface IWebRequest : IDisposable // TypeDefIndex: 17955
{
	// Properties
	public abstract UploadHandler uploadHandler { get; set; }
	public abstract bool IsNetworkError { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract UnityWebRequestAsyncOperation SendWebRequest();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract UploadHandler get_uploadHandler();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_uploadHandler(UploadHandler value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetRequestHeader(string key, string value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsNetworkError();
}
