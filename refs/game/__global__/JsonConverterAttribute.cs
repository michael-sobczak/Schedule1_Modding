public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 10991
{
	// Fields
	private readonly Type _converterType; // 0x10
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Properties
	public Type ConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ConverterParameters { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Type get_ConverterType() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public object[] get_ConverterParameters() { }

	// RVA: 0x1D0DAB0 Offset: 0x1D0C4B0 VA: 0x181D0DAB0
	public void .ctor(Type converterType) { }

	// RVA: 0x1D0D9D0 Offset: 0x1D0C3D0 VA: 0x181D0D9D0
	public void .ctor(Type converterType, object[] converterParameters) { }
}
