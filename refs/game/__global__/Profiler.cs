public sealed class Profiler // TypeDefIndex: 11904
{
	// Methods

	[NativeConditional("ENABLE_PROFILER")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void EndThreadProfiling() { }

	[NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = True)]
	// RVA: 0x2CC3CF0 Offset: 0x2CC26F0 VA: 0x182CC3CF0
	public static long GetRuntimeMemorySizeLong(Object o) { }
}
