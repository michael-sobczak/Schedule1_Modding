public struct GCHandle // TypeDefIndex: 4558
{
	// Fields
	private IntPtr handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	private void .ctor(IntPtr h) { }

	// RVA: 0x1B622C0 Offset: 0x1B60CC0 VA: 0x181B622C0
	private void .ctor(object obj) { }

	// RVA: 0x1B62290 Offset: 0x1B60C90 VA: 0x181B62290
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x180CD00 Offset: 0x180B700 VA: 0x18180CD00
	public bool get_IsAllocated() { }

	// RVA: 0x1B622F0 Offset: 0x1B60CF0 VA: 0x181B622F0
	public object get_Target() { }

	// RVA: 0x1B62360 Offset: 0x1B60D60 VA: 0x181B62360
	public void set_Target(object value) { }

	// RVA: 0x1B61F30 Offset: 0x1B60930 VA: 0x181B61F30
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0x1B62040 Offset: 0x1B60A40 VA: 0x181B62040
	public static GCHandle Alloc(object value) { }

	// RVA: 0x1B62020 Offset: 0x1B60A20 VA: 0x181B62020
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x1B62100 Offset: 0x1B60B00 VA: 0x181B62100
	public void Free() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0x1B621A0 Offset: 0x1B60BA0 VA: 0x181B621A0
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0x1B62050 Offset: 0x1B60A50 VA: 0x181B62050
	private static bool CheckCurrentDomain(IntPtr handle) { }

	// RVA: 0x1B62280 Offset: 0x1B60C80 VA: 0x181B62280
	private static object GetTarget(IntPtr handle) { }

	// RVA: 0x1B62270 Offset: 0x1B60C70 VA: 0x181B62270
	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	// RVA: 0x1B620F0 Offset: 0x1B60AF0 VA: 0x181B620F0
	private static void FreeHandle(IntPtr handle) { }

	// RVA: 0x1B62260 Offset: 0x1B60C60 VA: 0x181B62260
	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x1B62060 Offset: 0x1B60A60 VA: 0x181B62060 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xC7B8A0 Offset: 0xC7A2A0 VA: 0x180C7B8A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B621A0 Offset: 0x1B60BA0 VA: 0x181B621A0
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static IntPtr ToIntPtr(GCHandle value) { }
}
