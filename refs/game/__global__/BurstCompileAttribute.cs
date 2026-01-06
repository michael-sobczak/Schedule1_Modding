public class BurstCompileAttribute : Attribute // TypeDefIndex: 16282
{
	// Fields
	[CompilerGenerated]
	private FloatMode <FloatMode>k__BackingField; // 0x10
	[CompilerGenerated]
	private FloatPrecision <FloatPrecision>k__BackingField; // 0x14
	internal Nullable<bool> _compileSynchronously; // 0x18
	internal Nullable<bool> _debug; // 0x1A
	internal Nullable<bool> _disableSafetyChecks; // 0x1C
	internal Nullable<bool> _disableDirectCall; // 0x1E
	[CompilerGenerated]
	private OptimizeFor <OptimizeFor>k__BackingField; // 0x20
	[CompilerGenerated]
	private string[] <Options>k__BackingField; // 0x28

	// Properties
	public FloatMode FloatMode { get; set; }
	public FloatPrecision FloatPrecision { get; set; }
	public bool CompileSynchronously { get; set; }
	public bool Debug { get; set; }
	public bool DisableSafetyChecks { get; set; }
	public bool DisableDirectCall { get; set; }
	public OptimizeFor OptimizeFor { get; set; }
	internal string[] Options { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public FloatMode get_FloatMode() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_FloatMode(FloatMode value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public FloatPrecision get_FloatPrecision() { }

	[CompilerGenerated]
	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_FloatPrecision(FloatPrecision value) { }

	// RVA: 0x26D6220 Offset: 0x26D4C20 VA: 0x1826D6220
	public bool get_CompileSynchronously() { }

	// RVA: 0x26D63A0 Offset: 0x26D4DA0 VA: 0x1826D63A0
	public void set_CompileSynchronously(bool value) { }

	// RVA: 0x26D6280 Offset: 0x26D4C80 VA: 0x1826D6280
	public bool get_Debug() { }

	// RVA: 0x26D6400 Offset: 0x26D4E00 VA: 0x1826D6400
	public void set_Debug(bool value) { }

	// RVA: 0x26D6340 Offset: 0x26D4D40 VA: 0x1826D6340
	public bool get_DisableSafetyChecks() { }

	// RVA: 0x26D64C0 Offset: 0x26D4EC0 VA: 0x1826D64C0
	public void set_DisableSafetyChecks(bool value) { }

	// RVA: 0x26D62E0 Offset: 0x26D4CE0 VA: 0x1826D62E0
	public bool get_DisableDirectCall() { }

	// RVA: 0x26D6460 Offset: 0x26D4E60 VA: 0x1826D6460
	public void set_DisableDirectCall(bool value) { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public OptimizeFor get_OptimizeFor() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_OptimizeFor(OptimizeFor value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal string[] get_Options() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_Options(string[] value) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x26D61E0 Offset: 0x26D4BE0 VA: 0x1826D61E0
	public void .ctor(FloatPrecision floatPrecision, FloatMode floatMode) { }

	// RVA: 0x268D240 Offset: 0x268BC40 VA: 0x18268D240
	internal void .ctor(string[] options) { }
}
