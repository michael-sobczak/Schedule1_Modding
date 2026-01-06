public struct ProfilerRecorder : IDisposable // TypeDefIndex: 11499
{
	// Fields
	internal ulong handle; // 0x0
	internal const ProfilerRecorderOptions SharedRecorder = 128;

	// Properties
	public bool Valid { get; }
	public long LastValue { get; }
	public int Count { get; }
	public bool IsRunning { get; }

	// Methods

	// RVA: 0x2C9A680 Offset: 0x2C99080 VA: 0x182C9A680
	public void .ctor(ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = 24) { }

	// RVA: 0x2C9A8B0 Offset: 0x2C992B0 VA: 0x182C9A8B0
	public bool get_Valid() { }

	// RVA: 0x2C9A540 Offset: 0x2C98F40 VA: 0x182C9A540
	public void Start() { }

	// RVA: 0x2C9A5E0 Offset: 0x2C98FE0 VA: 0x182C9A5E0
	public void Stop() { }

	// RVA: 0x2C9A820 Offset: 0x2C99220 VA: 0x182C9A820
	public long get_LastValue() { }

	// RVA: 0x2C9A6F0 Offset: 0x2C990F0 VA: 0x182C9A6F0
	public int get_Count() { }

	// RVA: 0x2C9A790 Offset: 0x2C99190 VA: 0x182C9A790
	public bool get_IsRunning() { }

	// RVA: 0x2C9A3F0 Offset: 0x2C98DF0 VA: 0x182C9A3F0
	public ProfilerRecorderSample GetSample(int index) { }

	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x2C9A110 Offset: 0x2C98B10 VA: 0x182C9A110
	private static ProfilerRecorder Create(ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2C9A070 Offset: 0x2C98A70 VA: 0x182C9A070
	private static void Control(ProfilerRecorder handle, ProfilerRecorder.ControlOptions options) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2C9A280 Offset: 0x2C98C80 VA: 0x182C9A280
	private static long GetLastValue(ProfilerRecorder handle) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2C9A200 Offset: 0x2C98C00 VA: 0x182C9A200
	private static int GetCount(ProfilerRecorder handle, ProfilerRecorder.CountOptions countOptions) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2C9A500 Offset: 0x2C98F00 VA: 0x182C9A500
	private static bool GetValid(ProfilerRecorder handle) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2C9A300 Offset: 0x2C98D00 VA: 0x182C9A300
	private static bool GetRunning(ProfilerRecorder handle) { }

	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x2C9A390 Offset: 0x2C98D90 VA: 0x182C9A390
	private static ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index) { }

	// RVA: 0x2C9A170 Offset: 0x2C98B70 VA: 0x182C9A170 Slot: 4
	public void Dispose() { }

	[BurstDiscard]
	// RVA: 0x2C99FC0 Offset: 0x2C989C0 VA: 0x182C99FC0
	private void CheckInitializedAndThrow() { }

	// RVA: 0x2C9A0B0 Offset: 0x2C98AB0 VA: 0x182C9A0B0
	private static void Create_Injected(ref ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret) { }

	// RVA: 0x2C9A030 Offset: 0x2C98A30 VA: 0x182C9A030
	private static void Control_Injected(ref ProfilerRecorder handle, ProfilerRecorder.ControlOptions options) { }

	// RVA: 0x2C9A240 Offset: 0x2C98C40 VA: 0x182C9A240
	private static long GetLastValue_Injected(ref ProfilerRecorder handle) { }

	// RVA: 0x2C9A1C0 Offset: 0x2C98BC0 VA: 0x182C9A1C0
	private static int GetCount_Injected(ref ProfilerRecorder handle, ProfilerRecorder.CountOptions countOptions) { }

	// RVA: 0x2C9A4C0 Offset: 0x2C98EC0 VA: 0x182C9A4C0
	private static bool GetValid_Injected(ref ProfilerRecorder handle) { }

	// RVA: 0x2C9A2C0 Offset: 0x2C98CC0 VA: 0x182C9A2C0
	private static bool GetRunning_Injected(ref ProfilerRecorder handle) { }

	// RVA: 0x2C9A340 Offset: 0x2C98D40 VA: 0x182C9A340
	private static void GetSampleInternal_Injected(ref ProfilerRecorder handle, int index, out ProfilerRecorderSample ret) { }
}
