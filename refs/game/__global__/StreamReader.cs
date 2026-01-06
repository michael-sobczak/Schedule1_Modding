public class StreamReader : TextReader // TypeDefIndex: 5060
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream _stream; // 0x18
	private Encoding _encoding; // 0x20
	private Decoder _decoder; // 0x28
	private byte[] _byteBuffer; // 0x30
	private char[] _charBuffer; // 0x38
	private int _charPos; // 0x40
	private int _charLen; // 0x44
	private int _byteLen; // 0x48
	private int _bytePos; // 0x4C
	private int _maxCharsPerBuffer; // 0x50
	private bool _detectEncoding; // 0x54
	private bool _checkPreamble; // 0x55
	private bool _isBlocked; // 0x56
	private bool _closable; // 0x57
	private Task _asyncReadTask; // 0x58

	// Properties
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x1C14050 Offset: 0x1C12A50 VA: 0x181C14050
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x1C16410 Offset: 0x1C14E10 VA: 0x181C16410
	private static void ThrowAsyncIOInProgress() { }

	// RVA: 0x1C16700 Offset: 0x1C15100 VA: 0x181C16700
	internal void .ctor() { }

	// RVA: 0x1C16D30 Offset: 0x1C15730 VA: 0x181C16D30
	public void .ctor(Stream stream) { }

	// RVA: 0x1C167C0 Offset: 0x1C151C0 VA: 0x181C167C0
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x1C166D0 Offset: 0x1C150D0 VA: 0x181C166D0
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1C16820 Offset: 0x1C15220 VA: 0x181C16820
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x1C165F0 Offset: 0x1C14FF0 VA: 0x181C165F0
	public void .ctor(string path) { }

	// RVA: 0x1C16640 Offset: 0x1C15040 VA: 0x181C16640
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x1C166A0 Offset: 0x1C150A0 VA: 0x181C166A0
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x1C16D80 Offset: 0x1C15780 VA: 0x181C16D80
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x1C16A60 Offset: 0x1C15460 VA: 0x181C16A60
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x1C14490 Offset: 0x1C12E90 VA: 0x181C14490
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x1C14470 Offset: 0x1C12E70 VA: 0x181C14470
	internal void Init(Stream stream) { }

	// RVA: 0x1B20DF0 Offset: 0x1B1F7F0 VA: 0x181B20DF0 Slot: 7
	public override void Close() { }

	// RVA: 0x1C143F0 Offset: 0x1C12DF0 VA: 0x181C143F0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 17
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 18
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1C16DA0 Offset: 0x1C157A0 VA: 0x181C16DA0
	internal bool get_LeaveOpen() { }

	// RVA: 0x1C14730 Offset: 0x1C13130 VA: 0x181C14730 Slot: 9
	public override int Peek() { }

	// RVA: 0x1C16130 Offset: 0x1C14B30 VA: 0x181C16130 Slot: 10
	public override int Read() { }

	// RVA: 0x1C16240 Offset: 0x1C14C40 VA: 0x181C16240 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x1C16070 Offset: 0x1C14A70 VA: 0x181C16070 Slot: 12
	public override int Read(Span<char> buffer) { }

	// RVA: 0x1C15C60 Offset: 0x1C14660 VA: 0x181C15C60
	private int ReadSpan(Span<char> buffer) { }

	// RVA: 0x1C15EF0 Offset: 0x1C148F0 VA: 0x181C15EF0 Slot: 13
	public override string ReadToEnd() { }

	// RVA: 0x1C140B0 Offset: 0x1C12AB0 VA: 0x181C140B0
	private void CompressBuffer(int n) { }

	// RVA: 0x1C14100 Offset: 0x1C12B00 VA: 0x181C14100
	private void DetectEncoding() { }

	// RVA: 0x1C14600 Offset: 0x1C13000 VA: 0x181C14600
	private bool IsPreamble() { }

	// RVA: 0x1C14E20 Offset: 0x1C13820 VA: 0x181C14E20 Slot: 19
	internal virtual int ReadBuffer() { }

	// RVA: 0x1C152E0 Offset: 0x1C13CE0 VA: 0x181C152E0
	private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer) { }

	// RVA: 0x1C159C0 Offset: 0x1C143C0 VA: 0x181C159C0 Slot: 14
	public override string ReadLine() { }

	// RVA: 0x1C149E0 Offset: 0x1C133E0 VA: 0x181C149E0 Slot: 15
	public override Task<int> ReadAsync(char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(StreamReader.<ReadAsyncInternal>d__66))]
	// RVA: 0x1C14840 Offset: 0x1C13240 VA: 0x181C14840 Slot: 16
	internal override ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(StreamReader.<ReadBufferAsync>d__69))]
	// RVA: 0x1C14D10 Offset: 0x1C13710 VA: 0x181C14D10
	private Task<int> ReadBufferAsync() { }

	// RVA: 0x1C140F0 Offset: 0x1C12AF0 VA: 0x181C140F0
	internal bool DataAvailable() { }

	// RVA: 0x1C16460 Offset: 0x1C14E60 VA: 0x181C16460
	private static void .cctor() { }
}
