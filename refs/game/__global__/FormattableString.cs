public abstract class FormattableString : IFormattable // TypeDefIndex: 3632
{
	// Properties
	public abstract string Format { get; }
	public abstract int ArgumentCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Format();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object[] GetArguments();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_ArgumentCount();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArgument(int index);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string ToString(IFormatProvider formatProvider);

	// RVA: 0x1C5F3B0 Offset: 0x1C5DDB0 VA: 0x181C5F3B0 Slot: 4
	private string System.IFormattable.ToString(string ignored, IFormatProvider formatProvider) { }

	// RVA: 0x1C5F3D0 Offset: 0x1C5DDD0 VA: 0x181C5F3D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
