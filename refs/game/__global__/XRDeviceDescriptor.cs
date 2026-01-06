public class XRDeviceDescriptor // TypeDefIndex: 7472
{
	// Fields
	public string deviceName; // 0x10
	public string manufacturer; // 0x18
	public string serialNumber; // 0x20
	public InputDeviceCharacteristics characteristics; // 0x28
	public int deviceId; // 0x2C
	public List<XRFeatureDescriptor> inputFeatures; // 0x30

	// Methods

	// RVA: 0x283B650 Offset: 0x283A050 VA: 0x18283B650
	public string ToJson() { }

	// RVA: 0x283B610 Offset: 0x283A010 VA: 0x18283B610
	public static XRDeviceDescriptor FromJson(string json) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
