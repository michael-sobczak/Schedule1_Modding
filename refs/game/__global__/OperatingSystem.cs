public sealed class OperatingSystem : ISerializable, ICloneable // TypeDefIndex: 3777
{
	// Fields
	private readonly Version _version; // 0x10
	private readonly PlatformID _platform; // 0x18
	private readonly string _servicePack; // 0x20
	private string _versionString; // 0x28

	// Properties
	public PlatformID Platform { get; }
	public Version Version { get; }
	public string VersionString { get; }

	// Methods

	// RVA: 0x1C81320 Offset: 0x1C7FD20 VA: 0x181C81320
	public void .ctor(PlatformID platform, Version version) { }

	// RVA: 0x1C81340 Offset: 0x1C7FD40 VA: 0x181C81340
	internal void .ctor(PlatformID platform, Version version, string servicePack) { }

	// RVA: 0x1C812D0 Offset: 0x1C7FCD0 VA: 0x181C812D0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public PlatformID get_Platform() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Version get_Version() { }

	// RVA: 0x1C81250 Offset: 0x1C7FC50 VA: 0x181C81250 Slot: 5
	public object Clone() { }

	// RVA: 0x1C81310 Offset: 0x1C7FD10 VA: 0x181C81310 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C814B0 Offset: 0x1C7FEB0 VA: 0x181C814B0
	public string get_VersionString() { }
}
