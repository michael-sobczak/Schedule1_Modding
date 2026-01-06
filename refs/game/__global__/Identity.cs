internal abstract class Identity // TypeDefIndex: 4277
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_ObjectUri() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_ObjectUri(string value) { }

	// RVA: 0x82C1F0 Offset: 0x82ABF0 VA: 0x18082C1F0
	public bool get_IsConnected() { }

	// RVA: 0x4988A0 Offset: 0x4972A0 VA: 0x1804988A0
	public bool get_Disposed() { }

	// RVA: 0x498920 Offset: 0x497320 VA: 0x180498920
	public void set_Disposed(bool value) { }

	// RVA: 0x1B0E490 Offset: 0x1B0CE90 VA: 0x181B0E490
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1B0E550 Offset: 0x1B0CF50 VA: 0x181B0E550
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1B0E350 Offset: 0x1B0CD50 VA: 0x181B0E350
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1B0E3F0 Offset: 0x1B0CDF0 VA: 0x181B0E3F0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}
