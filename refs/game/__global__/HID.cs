public class HID : InputDevice // TypeDefIndex: 7561
{
	// Fields
	internal const string kHIDInterface = "HID";
	internal const string kHIDNamespace = "HID";
	private bool m_HaveParsedHIDDescriptor; // 0x190
	private HID.HIDDeviceDescriptor m_HIDDescriptor; // 0x198
	private static readonly ProfilerMarker k_HIDParseDescriptorFallback; // 0x0

	// Properties
	public static FourCC QueryHIDReportDescriptorDeviceCommandType { get; }
	public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType { get; }
	public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType { get; }
	public HID.HIDDeviceDescriptor hidDescriptor { get; }

	// Methods

	// RVA: 0x2841F80 Offset: 0x2840980 VA: 0x182841F80
	public static FourCC get_QueryHIDReportDescriptorDeviceCommandType() { }

	// RVA: 0x2841FC0 Offset: 0x28409C0 VA: 0x182841FC0
	public static FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType() { }

	// RVA: 0x2841F40 Offset: 0x2840940 VA: 0x182841F40
	public static FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType() { }

	// RVA: 0x2842000 Offset: 0x2840A00 VA: 0x182842000
	public HID.HIDDeviceDescriptor get_hidDescriptor() { }

	// RVA: 0x2840B60 Offset: 0x283F560 VA: 0x182840B60
	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	// RVA: 0x2841590 Offset: 0x283FF90 VA: 0x182841590
	internal static HID.HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	// RVA: 0x2841DC0 Offset: 0x28407C0 VA: 0x182841DC0
	public static string UsagePageToString(HID.UsagePage usagePage) { }

	// RVA: 0x2841E30 Offset: 0x2840830 VA: 0x182841E30
	public static string UsageToString(HID.UsagePage usagePage, int usage) { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }

	// RVA: 0x2841EE0 Offset: 0x28408E0 VA: 0x182841EE0
	private static void .cctor() { }
}
