public sealed class DllImportAttribute : Attribute // TypeDefIndex: 4550
{
	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x1B60680 Offset: 0x1B5F080 VA: 0x181B60680
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0x1B60900 Offset: 0x1B5F300 VA: 0x181B60900
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0x1B60930 Offset: 0x1B5F330 VA: 0x181B60930
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(string dllName) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Value() { }
}
