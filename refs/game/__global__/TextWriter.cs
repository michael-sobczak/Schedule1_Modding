public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 5073
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static readonly char[] s_coreNewLine; // 0x8
	protected char[] CoreNewLine; // 0x18
	private string CoreNewLineStr; // 0x20
	private IFormatProvider _internalFormatProvider; // 0x28

	// Properties
	public virtual IFormatProvider FormatProvider { get; }
	public abstract Encoding Encoding { get; }
	public virtual string NewLine { get; }

	// Methods

	// RVA: 0x1C1C410 Offset: 0x1C1AE10 VA: 0x181C1C410
	protected void .ctor() { }

	// RVA: 0x1C1C4B0 Offset: 0x1C1AEB0 VA: 0x181C1C4B0
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x1C1C550 Offset: 0x1C1AF50 VA: 0x181C1C550 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x1C1B0E0 Offset: 0x1C19AE0 VA: 0x181C1B0E0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1C1B150 Offset: 0x1C19B50 VA: 0x181C1B150 Slot: 6
	public void Dispose() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 12
	public virtual string get_NewLine() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public virtual void Write(char value) { }

	// RVA: 0x1C1BFF0 Offset: 0x1C1A9F0 VA: 0x181C1BFF0 Slot: 14
	public virtual void Write(char[] buffer) { }

	// RVA: 0x1C1C020 Offset: 0x1C1AA20 VA: 0x181C1C020 Slot: 15
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1C1C230 Offset: 0x1C1AC30 VA: 0x181C1C230 Slot: 16
	public virtual void Write(string value) { }

	// RVA: 0x1C1C270 Offset: 0x1C1AC70 VA: 0x181C1C270 Slot: 17
	public virtual void Write(string format, object arg0) { }

	// RVA: 0x1C1BD90 Offset: 0x1C1A790 VA: 0x181C1BD90 Slot: 18
	public virtual void WriteLine() { }

	// RVA: 0x1C1BCB0 Offset: 0x1C1A6B0 VA: 0x181C1BCB0 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x1C1BE20 Offset: 0x1C1A820 VA: 0x181C1BE20 Slot: 20
	public virtual void WriteLine(object value) { }

	// RVA: 0x1C1BDB0 Offset: 0x1C1A7B0 VA: 0x181C1BDB0 Slot: 21
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x1C1BF70 Offset: 0x1C1A970 VA: 0x181C1BF70 Slot: 22
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x1C1BD00 Offset: 0x1C1A700 VA: 0x181C1BD00 Slot: 23
	public virtual void WriteLine(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1C1BC40 Offset: 0x1C1A640 VA: 0x181C1BC40 Slot: 24
	public virtual void WriteLine(string format, object[] arg) { }

	// RVA: 0x1C1B500 Offset: 0x1C19F00 VA: 0x181C1B500 Slot: 25
	public virtual Task WriteAsync(char value) { }

	// RVA: 0x1C1B9E0 Offset: 0x1C1A3E0 VA: 0x181C1B9E0 Slot: 26
	public virtual Task WriteAsync(string value) { }

	// RVA: 0x1C1B760 Offset: 0x1C1A160 VA: 0x181C1B760 Slot: 27
	public virtual Task WriteAsync(char[] buffer, int index, int count) { }

	// RVA: 0x1C1B1C0 Offset: 0x1C19BC0 VA: 0x181C1B1C0 Slot: 28
	public virtual Task FlushAsync() { }

	// RVA: 0x1C1B3E0 Offset: 0x1C19DE0 VA: 0x181C1B3E0
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x1C1C2E0 Offset: 0x1C1ACE0 VA: 0x181C1C2E0
	private static void .cctor() { }
}
