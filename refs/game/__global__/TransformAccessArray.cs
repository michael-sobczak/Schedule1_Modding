public struct TransformAccessArray : IDisposable // TypeDefIndex: 11914
{
	// Fields
	private IntPtr m_TransformArray; // 0x0

	// Properties
	public bool isCreated { get; }
	public Transform Item { get; }
	public int length { get; }

	// Methods

	// RVA: 0x2CCC0D0 Offset: 0x2CCAAD0 VA: 0x182CCC0D0
	public void .ctor(int capacity, int desiredJobCount = -1) { }

	// RVA: 0x2CCBE10 Offset: 0x2CCA810 VA: 0x182CCBE10
	public static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array) { }

	// RVA: 0x2CCC180 Offset: 0x2CCAB80 VA: 0x182CCC180
	public bool get_isCreated() { }

	// RVA: 0x2CCBEF0 Offset: 0x2CCA8F0 VA: 0x182CCBEF0 Slot: 4
	public void Dispose() { }

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	internal IntPtr GetTransformAccessArrayForSchedule() { }

	// RVA: 0x2CCC140 Offset: 0x2CCAB40 VA: 0x182CCC140
	public Transform get_Item(int index) { }

	// RVA: 0x2CCC190 Offset: 0x2CCAB90 VA: 0x182CCC190
	public int get_length() { }

	// RVA: 0x2CCBDC0 Offset: 0x2CCA7C0 VA: 0x182CCBDC0
	public void Add(Transform transform) { }

	// RVA: 0x2CCC050 Offset: 0x2CCAA50 VA: 0x182CCC050
	public void RemoveAtSwapBack(int index) { }

	[NativeMethod(Name = "TransformAccessArrayBindings::Create", IsFreeFunction = True)]
	// RVA: 0x2CCBE70 Offset: 0x2CCA870 VA: 0x182CCBE70
	private static IntPtr Create(int capacity, int desiredJobCount) { }

	[NativeMethod(Name = "DestroyTransformAccessArray", IsFreeFunction = True)]
	// RVA: 0x2CCBEB0 Offset: 0x2CCA8B0 VA: 0x182CCBEB0
	private static void DestroyTransformAccessArray(IntPtr transformArray) { }

	[NativeMethod(Name = "TransformAccessArrayBindings::AddTransform", IsFreeFunction = True)]
	// RVA: 0x2CCBD70 Offset: 0x2CCA770 VA: 0x182CCBD70
	private static void Add(IntPtr transformArrayIntPtr, Transform transform) { }

	[NativeMethod(Name = "TransformAccessArrayBindings::RemoveAtSwapBack", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CCC090 Offset: 0x2CCAA90 VA: 0x182CCC090
	private static void RemoveAtSwapBack(IntPtr transformArrayIntPtr, int index) { }

	[NativeMethod(Name = "TransformAccessArrayBindings::GetSortedTransformAccess", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CCBFD0 Offset: 0x2CCA9D0 VA: 0x182CCBFD0
	internal static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr) { }

	[NativeMethod(Name = "TransformAccessArrayBindings::GetSortedToUserIndex", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CCBF90 Offset: 0x2CCA990 VA: 0x182CCBF90
	internal static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr) { }

	[NativeMethod(Name = "TransformAccessArrayBindings::GetLength", IsFreeFunction = True)]
	// RVA: 0x2CCBF50 Offset: 0x2CCA950 VA: 0x182CCBF50
	internal static int GetLength(IntPtr transformArrayIntPtr) { }

	[NativeMethod(Name = "TransformAccessArrayBindings::GetTransform", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CCC010 Offset: 0x2CCAA10 VA: 0x182CCC010
	internal static Transform GetTransform(IntPtr transformArrayIntPtr, int index) { }
}
