internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 3484
{
	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1A8E710 Offset: 0x1A8D110 VA: 0x181A8E710
	private static IntPtr StringToUtf8_icall(ref string str) { }

	// RVA: 0x1A8E720 Offset: 0x1A8D120 VA: 0x181A8E720
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x1A8E700 Offset: 0x1A8D100 VA: 0x181A8E700
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x1A8E740 Offset: 0x1A8D140 VA: 0x181A8E740
	public void .ctor(string str) { }

	// RVA: 0x1A8E760 Offset: 0x1A8D160 VA: 0x181A8E760
	public IntPtr get_Value() { }

	// RVA: 0x1A8E6C0 Offset: 0x1A8D0C0 VA: 0x181A8E6C0 Slot: 4
	public void Dispose() { }
}
