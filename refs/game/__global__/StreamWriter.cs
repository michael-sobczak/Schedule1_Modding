public class StreamWriter : TextWriter // TypeDefIndex: 5065
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream _stream; // 0x30
	private Encoding _encoding; // 0x38
	private Encoder _encoder; // 0x40
	private byte[] _byteBuffer; // 0x48
	private char[] _charBuffer; // 0x50
	private int _charPos; // 0x58
	private int _charLen; // 0x5C
	private bool _autoFlush; // 0x60
	private bool _haveWrittenPreamble; // 0x61
	private bool _closable; // 0x62
	private Task _asyncWriteTask; // 0x68

	// Properties
	private static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public override Encoding Encoding { get; }
	private int CharPos_Prop { set; }
	private bool HaveWrittenPreamble_Prop { set; }

	// Methods

	// RVA: 0x1C16DB0 Offset: 0x1C157B0 VA: 0x181C16DB0
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x1C178D0 Offset: 0x1C162D0 VA: 0x181C178D0
	private static void ThrowAsyncIOInProgress() { }

	// RVA: 0x1C198F0 Offset: 0x1C182F0 VA: 0x181C198F0
	private static Encoding get_UTF8NoBOM() { }

	// RVA: 0x1C19820 Offset: 0x1C18220 VA: 0x181C19820
	internal void .ctor() { }

	// RVA: 0x1C19600 Offset: 0x1C18000 VA: 0x181C19600
	public void .ctor(Stream stream) { }

	// RVA: 0x1C19290 Offset: 0x1C17C90 VA: 0x181C19290
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1C19050 Offset: 0x1C17A50 VA: 0x181C19050
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x1C19770 Offset: 0x1C18170 VA: 0x181C19770
	public void .ctor(string path) { }

	// RVA: 0x1C196B0 Offset: 0x1C180B0 VA: 0x181C196B0
	public void .ctor(string path, bool append) { }

	// RVA: 0x1C192C0 Offset: 0x1C17CC0 VA: 0x181C192C0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x1C17760 Offset: 0x1C16160 VA: 0x181C17760
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x1C16E10 Offset: 0x1C15810 VA: 0x181C16E10 Slot: 8
	public override void Close() { }

	// RVA: 0x1C16E80 Offset: 0x1C15880 VA: 0x181C16E80 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C17530 Offset: 0x1C15F30 VA: 0x181C17530 Slot: 10
	public override void Flush() { }

	// RVA: 0x1C175A0 Offset: 0x1C15FA0 VA: 0x181C175A0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x1C19930 Offset: 0x1C18330 VA: 0x181C19930 Slot: 29
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 30
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1C198E0 Offset: 0x1C182E0 VA: 0x181C198E0
	internal bool get_LeaveOpen() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1C18BB0 Offset: 0x1C175B0 VA: 0x181C18BB0 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x1C18C70 Offset: 0x1C17670 VA: 0x181C18C70 Slot: 14
	public override void Write(char[] buffer) { }

	// RVA: 0x1C18CE0 Offset: 0x1C176E0 VA: 0x181C18CE0 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1C18860 Offset: 0x1C17260 VA: 0x181C18860
	private void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine) { }

	// RVA: 0x1C18B30 Offset: 0x1C17530 VA: 0x181C18B30 Slot: 16
	public override void Write(string value) { }

	// RVA: 0x1C18790 Offset: 0x1C17190 VA: 0x181C18790 Slot: 19
	public override void WriteLine(string value) { }

	// RVA: 0x1C17D40 Offset: 0x1C16740 VA: 0x181C17D40 Slot: 25
	public override Task WriteAsync(char value) { }

	[AsyncStateMachine(typeof(StreamWriter.<WriteAsyncInternal>d__57))]
	// RVA: 0x1C17BF0 Offset: 0x1C165F0 VA: 0x181C17BF0
	private static Task WriteAsyncInternal(StreamWriter _this, char value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine) { }

	// RVA: 0x1C18000 Offset: 0x1C16A00 VA: 0x181C18000 Slot: 26
	public override Task WriteAsync(string value) { }

	[AsyncStateMachine(typeof(StreamWriter.<WriteAsyncInternal>d__59))]
	// RVA: 0x1C17920 Offset: 0x1C16320 VA: 0x181C17920
	private static Task WriteAsyncInternal(StreamWriter _this, string value, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine) { }

	// RVA: 0x1C18310 Offset: 0x1C16D10 VA: 0x181C18310 Slot: 27
	public override Task WriteAsync(char[] buffer, int index, int count) { }

	[AsyncStateMachine(typeof(StreamWriter.<WriteAsyncInternal>d__62))]
	// RVA: 0x1C17A80 Offset: 0x1C16480 VA: 0x181C17A80
	private static Task WriteAsyncInternal(StreamWriter _this, ReadOnlyMemory<char> source, char[] charBuffer, int charPos, int charLen, char[] coreNewLine, bool autoFlush, bool appendNewLine, CancellationToken cancellationToken) { }

	// RVA: 0x1C173A0 Offset: 0x1C15DA0 VA: 0x181C173A0 Slot: 28
	public override Task FlushAsync() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	private void set_CharPos_Prop(int value) { }

	// RVA: 0x848350 Offset: 0x846D50 VA: 0x180848350
	private void set_HaveWrittenPreamble_Prop(bool value) { }

	// RVA: 0x1C170F0 Offset: 0x1C15AF0 VA: 0x181C170F0
	private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, char[] sCharBuffer, int sCharPos, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(StreamWriter.<FlushAsyncInternal>d__74))]
	// RVA: 0x1C16F50 Offset: 0x1C15950 VA: 0x181C16F50
	private static Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, char[] charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, byte[] byteBuffer, Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1C18F40 Offset: 0x1C17940 VA: 0x181C18F40
	private static void .cctor() { }
}
