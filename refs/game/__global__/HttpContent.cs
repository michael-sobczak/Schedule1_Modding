public abstract class HttpContent : IDisposable // TypeDefIndex: 17707
{
	// Fields
	private HttpContent.FixedMemoryStream buffer; // 0x10
	private bool disposed; // 0x18
	private HttpContentHeaders headers; // 0x20

	// Properties
	public HttpContentHeaders Headers { get; }
	internal Nullable<long> LoadedBufferLength { get; }

	// Methods

	// RVA: 0x2184FD0 Offset: 0x21839D0 VA: 0x182184FD0
	public HttpContentHeaders get_Headers() { }

	// RVA: 0x2185090 Offset: 0x2183A90 VA: 0x182185090
	internal Nullable<long> get_LoadedBufferLength() { }

	// RVA: 0x2184960 Offset: 0x2183360 VA: 0x182184960
	public Task CopyToAsync(Stream stream) { }

	// RVA: 0x2184A00 Offset: 0x2183400 VA: 0x182184A00
	public Task CopyToAsync(Stream stream, TransportContext context) { }

	// RVA: 0x2184AA0 Offset: 0x21834A0 VA: 0x182184AA0
	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	// RVA: 0x1EA1F90 Offset: 0x1EA0990 VA: 0x181EA1F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x2184B00 Offset: 0x2183500 VA: 0x182184B00 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2184E50 Offset: 0x2183850 VA: 0x182184E50
	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachine(typeof(HttpContent.<LoadIntoBufferAsync>d__17))]
	// RVA: 0x2184D60 Offset: 0x2183760 VA: 0x182184D60
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachine(typeof(HttpContent.<ReadAsStringAsync>d__20))]
	// RVA: 0x2184E60 Offset: 0x2183860 VA: 0x182184E60
	public Task<string> ReadAsStringAsync() { }

	// RVA: 0x2184B30 Offset: 0x2183530 VA: 0x182184B30
	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	// RVA: 0x2184F60 Offset: 0x2183960 VA: 0x182184F60
	private static int StartsWith(byte[] array, int length, byte[] value) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

	// RVA: -1 Offset: -1 Slot: 7
	protected internal abstract bool TryComputeLength(out long length);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
