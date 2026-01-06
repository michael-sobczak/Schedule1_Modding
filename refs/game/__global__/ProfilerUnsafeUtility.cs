public static class ProfilerUnsafeUtility // TypeDefIndex: 11507
{
	// Methods

	[ThreadSafe]
	// RVA: 0x2C9A950 Offset: 0x2C99350 VA: 0x182C9A950
	internal static ushort CreateCategory__Unmanaged(byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	[ThreadSafe]
	// RVA: 0x2C9ABD0 Offset: 0x2C995D0 VA: 0x182C9ABD0
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) { }

	[ThreadSafe]
	// RVA: 0x2C9AAD0 Offset: 0x2C994D0 VA: 0x182C9AAD0
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[ThreadSafe]
	// RVA: 0x2C9AA60 Offset: 0x2C99460 VA: 0x182C9AA60
	internal static IntPtr CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[ThreadSafe]
	// RVA: 0x2C9AC30 Offset: 0x2C99630 VA: 0x182C9AC30
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, byte* name, int nameLen, byte type, byte unit) { }

	[ThreadSafe]
	// RVA: 0x2C9A910 Offset: 0x2C99310 VA: 0x182C9A910
	public static void BeginSample(IntPtr markerPtr) { }

	[ThreadSafe]
	// RVA: 0x2C9AB40 Offset: 0x2C99540 VA: 0x182C9AB40
	public static void EndSample(IntPtr markerPtr) { }

	[ThreadSafe]
	// RVA: 0x2C9A9B0 Offset: 0x2C993B0 VA: 0x182C9A9B0
	internal static void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	// RVA: 0x2C9ACB0 Offset: 0x2C996B0 VA: 0x182C9ACB0
	internal static string Utf8ToString(byte* chars, int charsLen) { }

	// RVA: 0x2C9AB80 Offset: 0x2C99580 VA: 0x182C9AB80
	private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret) { }
}
