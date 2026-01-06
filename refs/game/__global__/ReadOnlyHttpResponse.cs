internal struct ReadOnlyHttpResponse // TypeDefIndex: 17804
{
	// Fields
	private HttpResponse m_Response; // 0x0

	// Properties
	public ReadOnlyHttpRequest Request { get; }
	public IReadOnlyDictionary<string, string> Headers { get; }
	public byte[] Data { get; }
	public long StatusCode { get; }
	public string ErrorMessage { get; }
	public bool IsHttpError { get; }
	public bool IsNetworkError { get; }

	// Methods

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void .ctor(HttpResponse response) { }

	// RVA: 0xD07690 Offset: 0xD06090 VA: 0x180D07690
	public ReadOnlyHttpRequest get_Request() { }

	// RVA: 0x24BB860 Offset: 0x24BA260 VA: 0x1824BB860
	public IReadOnlyDictionary<string, string> get_Headers() { }

	// RVA: 0x24BB8B0 Offset: 0x24BA2B0 VA: 0x1824BB8B0
	public byte[] get_Data() { }

	// RVA: 0x24BB5F0 Offset: 0x24B9FF0 VA: 0x1824BB5F0
	public long get_StatusCode() { }

	// RVA: 0x282A430 Offset: 0x2828E30 VA: 0x18282A430
	public string get_ErrorMessage() { }

	// RVA: 0x2B9F480 Offset: 0x2B9DE80 VA: 0x182B9F480
	public bool get_IsHttpError() { }

	// RVA: 0x2B9F4A0 Offset: 0x2B9DEA0 VA: 0x182B9F4A0
	public bool get_IsNetworkError() { }
}
