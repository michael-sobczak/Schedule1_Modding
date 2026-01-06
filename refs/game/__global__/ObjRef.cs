public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 4280
{
	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x1B115F0 Offset: 0x1B0FFF0 VA: 0x181B115F0
	public void .ctor() { }

	// RVA: 0x1B115A0 Offset: 0x1B0FFA0 VA: 0x181B115A0
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x1B109D0 Offset: 0x1B0F3D0 VA: 0x181B109D0
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x1B10D90 Offset: 0x1B0F790 VA: 0x181B10D90
	internal byte[] SerializeType() { }

	// RVA: 0x1B10F20 Offset: 0x1B0F920 VA: 0x181B10F20
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x1B11040 Offset: 0x1B0FA40 VA: 0x181B11040
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B11610 Offset: 0x1B10010 VA: 0x181B11610
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x1B10B10 Offset: 0x1B0F510 VA: 0x181B10B10 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B10CC0 Offset: 0x1B0F6C0 VA: 0x181B10CC0 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x1B10E20 Offset: 0x1B0F820 VA: 0x181B10E20
	internal void UpdateChannelInfo() { }

	// RVA: 0x1B11670 Offset: 0x1B10070 VA: 0x181B11670
	internal Type get_ServerType() { }

	// RVA: 0x1B10ED0 Offset: 0x1B0F8D0 VA: 0x181B10ED0
	private static void .cctor() { }
}
