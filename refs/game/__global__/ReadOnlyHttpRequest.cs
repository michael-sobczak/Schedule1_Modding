internal struct ReadOnlyHttpRequest // TypeDefIndex: 17803
{
	// Fields
	private HttpRequest m_Request; // 0x0

	// Properties
	public string Method { get; }
	public string Url { get; }
	public IReadOnlyDictionary<string, string> Headers { get; }
	public byte[] Body { get; }

	// Methods

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void .ctor(HttpRequest request) { }

	// RVA: 0xD07690 Offset: 0xD06090 VA: 0x180D07690
	public string get_Method() { }

	// RVA: 0x24BB860 Offset: 0x24BA260 VA: 0x1824BB860
	public string get_Url() { }

	// RVA: 0x24BB8B0 Offset: 0x24BA2B0 VA: 0x1824BB8B0
	public IReadOnlyDictionary<string, string> get_Headers() { }

	// RVA: 0x24BB5F0 Offset: 0x24B9FF0 VA: 0x1824BB5F0
	public byte[] get_Body() { }
}
