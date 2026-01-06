internal class MonoChunkParser // TypeDefIndex: 10072
{
	// Fields
	private WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkParser.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x25BA760 Offset: 0x25B9160 VA: 0x1825BA760
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x25BA670 Offset: 0x25B9070 VA: 0x1825BA670
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x25BA120 Offset: 0x25B8B20 VA: 0x1825BA120
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x25BA730 Offset: 0x25B9130 VA: 0x1825BA730
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x25B9C30 Offset: 0x25B8630 VA: 0x1825B9C30
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x25BA940 Offset: 0x25B9340 VA: 0x1825BA940
	public bool get_WantMore() { }

	// RVA: 0x25BA830 Offset: 0x25B9230 VA: 0x1825BA830
	public bool get_DataAvailable() { }

	// RVA: 0x25BA820 Offset: 0x25B9220 VA: 0x1825BA820
	public int get_ChunkLeft() { }

	// RVA: 0x25B9F00 Offset: 0x25B8900 VA: 0x1825B9F00
	private MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x25B9940 Offset: 0x25B8340 VA: 0x1825B9940
	private MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x25BA680 Offset: 0x25B9080 VA: 0x1825BA680
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x25BA040 Offset: 0x25B8A40 VA: 0x1825BA040
	private MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x25BA410 Offset: 0x25B8E10 VA: 0x1825BA410
	private MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x25BA6D0 Offset: 0x25B90D0 VA: 0x1825BA6D0
	private static void ThrowProtocolViolation(string message) { }
}
