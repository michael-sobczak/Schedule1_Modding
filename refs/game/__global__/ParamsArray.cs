internal struct ParamsArray // TypeDefIndex: 3709
{
	// Fields
	private static readonly object[] s_oneArgArray; // 0x0
	private static readonly object[] s_twoArgArray; // 0x8
	private static readonly object[] s_threeArgArray; // 0x10
	private readonly object _arg0; // 0x0
	private readonly object _arg1; // 0x8
	private readonly object _arg2; // 0x10
	private readonly object[] _args; // 0x18

	// Properties
	public int Length { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1C822A0 Offset: 0x1C80CA0 VA: 0x181C822A0
	public void .ctor(object arg0) { }

	// RVA: 0x1C82400 Offset: 0x1C80E00 VA: 0x181C82400
	public void .ctor(object arg0, object arg1) { }

	// RVA: 0x1C82340 Offset: 0x1C80D40 VA: 0x181C82340
	public void .ctor(object arg0, object arg1, object arg2) { }

	// RVA: 0x1C821D0 Offset: 0x1C80BD0 VA: 0x181C821D0
	public void .ctor(object[] args) { }

	// RVA: 0x11AE000 Offset: 0x11ACA00 VA: 0x1811AE000
	public int get_Length() { }

	// RVA: 0x1C824B0 Offset: 0x1C80EB0 VA: 0x181C824B0
	public object get_Item(int index) { }

	// RVA: 0x1C82090 Offset: 0x1C80A90 VA: 0x181C82090
	private object GetAtSlow(int index) { }

	// RVA: 0x1C820E0 Offset: 0x1C80AE0 VA: 0x181C820E0
	private static void .cctor() { }
}
