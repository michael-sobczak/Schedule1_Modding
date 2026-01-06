internal abstract class WebReadStream : Stream // TypeDefIndex: 10106
{
	// Fields
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x30
	private bool disposed; // 0x38

	// Properties
	public WebOperation Operation { get; }
	protected Stream InnerStream { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public WebOperation get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	protected Stream get_InnerStream() { }

	// RVA: 0x25D4860 Offset: 0x25D3260 VA: 0x1825D4860
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x25D48F0 Offset: 0x25D32F0 VA: 0x1825D48F0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x25D4930 Offset: 0x25D3330 VA: 0x1825D4930 Slot: 12
	public override long get_Position() { }

	// RVA: 0x25D4970 Offset: 0x25D3370 VA: 0x1825D4970 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x25D47E0 Offset: 0x25D31E0 VA: 0x1825D47E0 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x25D47A0 Offset: 0x25D31A0 VA: 0x1825D47A0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x25D4820 Offset: 0x25D3220 VA: 0x1825D4820 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x25D41D0 Offset: 0x25D2BD0 VA: 0x1825D41D0 Slot: 22
	public override void Flush() { }

	// RVA: 0x25D4210 Offset: 0x25D2C10 VA: 0x1825D4210
	protected Exception GetException(Exception e) { }

	// RVA: 0x25D44E0 Offset: 0x25D2EE0 VA: 0x1825D44E0 Slot: 34
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x25D3D20 Offset: 0x25D2720 VA: 0x1825D3D20 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x25D3FF0 Offset: 0x25D29F0 VA: 0x1825D3FF0 Slot: 25
	public override int EndRead(IAsyncResult r) { }

	[AsyncStateMachine(typeof(WebReadStream.<ReadAsync>d__28))]
	// RVA: 0x25D4390 Offset: 0x25D2D90 VA: 0x1825D4390 Slot: 26
	public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

	// RVA: 0x25D40C0 Offset: 0x25D2AC0 VA: 0x1825D40C0 Slot: 41
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x25D3FA0 Offset: 0x25D29A0 VA: 0x1825D3FA0 Slot: 21
	protected override void Dispose(bool disposing) { }
}
