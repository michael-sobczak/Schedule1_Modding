internal class FlavorHandler // TypeDefIndex: 5873
{
	// Fields
	internal IntPtr flavorref; // 0x10
	internal IntPtr dragref; // 0x18
	internal IntPtr itemref; // 0x20
	internal int size; // 0x28
	internal uint flags; // 0x2C
	internal byte[] data; // 0x30
	internal string fourcc; // 0x38
	[CompilerGenerated]
	private static Dictionary<string, int> <>f__switch$mapF; // 0x0
	[CompilerGenerated]
	private static Dictionary<string, int> <>f__switch$map10; // 0x8

	// Properties
	internal string DataString { get; }
	internal byte[] DataArray { get; }
	internal IntPtr DataPtr { get; }
	internal bool Supported { get; }

	// Methods

	// RVA: 0x22B6840 Offset: 0x22B5240 VA: 0x1822B6840
	internal void .ctor(IntPtr dragref, IntPtr itemref, uint counter) { }

	// RVA: 0x22B63D0 Offset: 0x22B4DD0 VA: 0x1822B63D0
	internal void GetData() { }

	// RVA: 0x22B6D00 Offset: 0x22B5700 VA: 0x1822B6D00
	internal string get_DataString() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal byte[] get_DataArray() { }

	// RVA: 0x22B6CE0 Offset: 0x22B56E0 VA: 0x1822B6CE0
	internal IntPtr get_DataPtr() { }

	// RVA: 0x22B6D40 Offset: 0x22B5740 VA: 0x1822B6D40
	internal bool get_Supported() { }

	// RVA: 0x22B5F90 Offset: 0x22B4990 VA: 0x1822B5F90
	internal DataObject Convert(ArrayList flavorlist) { }

	// RVA: 0x22B62B0 Offset: 0x22B4CB0 VA: 0x1822B62B0
	internal DataObject DeserializeObject(ArrayList flavorlist) { }

	// RVA: 0x22B5D00 Offset: 0x22B4700 VA: 0x1822B5D00
	internal DataObject ConvertToObject(ArrayList flavorlist) { }

	// RVA: 0x22B58B0 Offset: 0x22B42B0 VA: 0x1822B58B0
	internal DataObject ConvertToFileDrop(ArrayList flavorlist) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x22B6560 Offset: 0x22B4F60 VA: 0x1822B6560
	private static extern int GetFlavorDataSize(IntPtr dragref, IntPtr itemref, IntPtr flavorref, ref int size) { }

	// RVA: 0x22B6610 Offset: 0x22B5010 VA: 0x1822B6610
	private static extern int GetFlavorData(IntPtr dragref, IntPtr itemref, IntPtr flavorref, [In] [Out] byte[] data, ref int size, uint offset) { }

	// RVA: 0x22B66E0 Offset: 0x22B50E0 VA: 0x1822B66E0
	private static extern int GetFlavorFlags(IntPtr dragref, IntPtr itemref, IntPtr flavorref, ref uint flags) { }

	// RVA: 0x22B6790 Offset: 0x22B5190 VA: 0x1822B6790
	private static extern int GetFlavorType(IntPtr dragref, IntPtr itemref, uint index, ref IntPtr flavor) { }
}
