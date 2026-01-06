public struct ProfilerRecorderHandle // TypeDefIndex: 11505
{
	// Fields
	internal readonly ulong handle; // 0x0

	// Properties
	public bool Valid { get; }

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	internal void .ctor(ulong handle) { }

	// RVA: 0x2C99FA0 Offset: 0x2C989A0 VA: 0x182C99FA0
	public bool get_Valid() { }

	// RVA: 0x2C99EC0 Offset: 0x2C988C0 VA: 0x182C99EC0
	public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2C99DC0 Offset: 0x2C987C0 VA: 0x182C99DC0
	internal static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, byte* name, int nameLen) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2C99E70 Offset: 0x2C98870 VA: 0x182C99E70
	private static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle) { }

	// RVA: 0x2C99D50 Offset: 0x2C98750 VA: 0x182C99D50
	private static void GetByName__Unmanaged_Injected(ref ProfilerCategory category, byte* name, int nameLen, out ProfilerRecorderHandle ret) { }

	// RVA: 0x2C99E20 Offset: 0x2C98820 VA: 0x182C99E20
	private static void GetDescriptionInternal_Injected(ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret) { }
}
