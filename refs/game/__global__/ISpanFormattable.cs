internal interface ISpanFormattable // TypeDefIndex: 3669
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
}
