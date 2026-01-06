internal class MonoChunkStream : WebReadStream // TypeDefIndex: 10075
{
	// Fields
	[CompilerGenerated]
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Properties
	protected MonoChunkParser Decoder { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x25BAC40 Offset: 0x25B9640 VA: 0x1825BAC40
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<ProcessReadAsync>d__7))]
	// RVA: 0x25BAA70 Offset: 0x25B9470 VA: 0x1825BAA70 Slot: 40
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<FinishReading>d__8))]
	// RVA: 0x25BA960 Offset: 0x25B9360 VA: 0x1825BA960 Slot: 41
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x25BABC0 Offset: 0x25B95C0 VA: 0x1825BABC0
	private static void ThrowExpectingChunkTrailer() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x25BAC30 Offset: 0x25B9630 VA: 0x1825BAC30
	private Task <>n__0(CancellationToken cancellationToken) { }
}
