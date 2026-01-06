public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 5069
{
	// Fields
	public static readonly TextReader Null; // 0x0

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1C1A380 Offset: 0x1C18D80 VA: 0x181C1A380 Slot: 7
	public virtual void Close() { }

	// RVA: 0x1C1A3F0 Offset: 0x1C18DF0 VA: 0x181C1A3F0 Slot: 6
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490 Slot: 9
	public virtual int Peek() { }

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490 Slot: 10
	public virtual int Read() { }

	// RVA: 0x1C1AD10 Offset: 0x1C19710 VA: 0x181C1AD10 Slot: 11
	public virtual int Read(char[] buffer, int index, int count) { }

	// RVA: 0x1C1AB00 Offset: 0x1C19500 VA: 0x181C1AB00 Slot: 12
	public virtual int Read(Span<char> buffer) { }

	// RVA: 0x1C1AA00 Offset: 0x1C19400 VA: 0x181C1AA00 Slot: 13
	public virtual string ReadToEnd() { }

	// RVA: 0x1C1A8E0 Offset: 0x1C192E0 VA: 0x181C1A8E0 Slot: 14
	public virtual string ReadLine() { }

	// RVA: 0x1C1A6C0 Offset: 0x1C190C0 VA: 0x181C1A6C0 Slot: 15
	public virtual Task<int> ReadAsync(char[] buffer, int index, int count) { }

	// RVA: 0x1C1A460 Offset: 0x1C18E60 VA: 0x181C1A460 Slot: 16
	internal virtual ValueTask<int> ReadAsyncInternal(Memory<char> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1C1AF30 Offset: 0x1C19930 VA: 0x181C1AF30
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x1C1B030 Offset: 0x1C19A30 VA: 0x181C1B030
	private static void .cctor() { }
}
