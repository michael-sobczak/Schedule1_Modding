internal class NativeInputSystem // TypeDefIndex: 19184
{
	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	public static Action<int, string> onDeviceDiscovered { get; set; }
	internal static bool hasDeviceDiscoveredCallback { set; }
	[NativeProperty(IsThreadSafe = True)]
	public static double currentTime { get; }
	[NativeProperty(IsThreadSafe = True)]
	public static double currentTimeOffsetToRealtimeSinceStartup { get; }

	// Methods

	// RVA: 0x2D2B640 Offset: 0x2D2A040 VA: 0x182D2B640
	public static Action<int, string> get_onDeviceDiscovered() { }

	// RVA: 0x2D2B6D0 Offset: 0x2D2A0D0 VA: 0x182D2B6D0
	public static void set_onDeviceDiscovered(Action<int, string> value) { }

	// RVA: 0x2D2B5B0 Offset: 0x2D29FB0 VA: 0x182D2B5B0
	private static void .cctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2D2B2D0 Offset: 0x2D29CD0 VA: 0x182D2B2D0
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCode]
	// RVA: 0x2D2B3C0 Offset: 0x2D29DC0 VA: 0x182D2B3C0
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCode]
	// RVA: 0x2D2B340 Offset: 0x2D29D40 VA: 0x182D2B340
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCode]
	// RVA: 0x2D2B4E0 Offset: 0x2D29EE0 VA: 0x182D2B4E0
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x2D2B690 Offset: 0x2D2A090 VA: 0x182D2B690
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

	// RVA: 0x2D2B610 Offset: 0x2D2A010 VA: 0x182D2B610
	public static double get_currentTime() { }

	// RVA: 0x2D2B5E0 Offset: 0x2D29FE0 VA: 0x182D2B5E0
	public static double get_currentTimeOffsetToRealtimeSinceStartup() { }

	[FreeFunction("AllocateInputDeviceId")]
	// RVA: 0x2D2B240 Offset: 0x2D29C40 VA: 0x182D2B240
	public static int AllocateDeviceId() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2D2B460 Offset: 0x2D29E60 VA: 0x182D2B460
	public static void QueueInputEvent(IntPtr inputEvent) { }

	// RVA: 0x2D2B270 Offset: 0x2D29C70 VA: 0x182D2B270
	public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes) { }

	// RVA: 0x2D2B4A0 Offset: 0x2D29EA0 VA: 0x182D2B4A0
	public static void SetPollingFrequency(float hertz) { }

	// RVA: 0x2D2B570 Offset: 0x2D29F70 VA: 0x182D2B570
	public static void Update(NativeInputUpdateType updateType) { }
}
