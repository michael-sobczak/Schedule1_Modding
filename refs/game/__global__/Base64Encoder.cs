internal class Base64Encoder // TypeDefIndex: 11113
{
	// Fields
	private const int Base64LineSize = 76;
	private const int LineSizeInBytes = 57;
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	[Nullable(2)]
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x1D59280 Offset: 0x1D57C80 VA: 0x181D59280
	public void .ctor(TextWriter writer) { }

	// RVA: 0x1D59060 Offset: 0x1D57A60 VA: 0x181D59060
	private void ValidateEncode(byte[] buffer, int index, int count) { }

	// RVA: 0x1D58A60 Offset: 0x1D57460 VA: 0x181D58A60
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x1D58F60 Offset: 0x1D57960 VA: 0x181D58F60
	private void StoreLeftOverBytes(byte[] buffer, int index, ref int count) { }

	// RVA: 0x1D58EA0 Offset: 0x1D578A0 VA: 0x181D58EA0
	private bool FulfillFromLeftover(byte[] buffer, int index, ref int count) { }

	// RVA: 0x1D58DD0 Offset: 0x1D577D0 VA: 0x181D58DD0
	public void Flush() { }

	// RVA: 0x1D59250 Offset: 0x1D57C50 VA: 0x181D59250
	private void WriteChars(char[] chars, int index, int count) { }

	[AsyncStateMachine(typeof(Base64Encoder.<EncodeAsync>d__13))]
	// RVA: 0x1D58920 Offset: 0x1D57320 VA: 0x181D58920
	public Task EncodeAsync(byte[] buffer, int index, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1D591C0 Offset: 0x1D57BC0 VA: 0x181D591C0
	private Task WriteCharsAsync(char[] chars, int index, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1D58C70 Offset: 0x1D57670 VA: 0x181D58C70
	public Task FlushAsync(CancellationToken cancellationToken) { }
}
