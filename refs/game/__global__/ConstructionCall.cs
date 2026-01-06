public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 4377
{
	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x1B2C9E0 Offset: 0x1B2B3E0 VA: 0x181B2C9E0
	internal void .ctor(Type type) { }

	// RVA: 0x1B2C920 Offset: 0x1B2B320 VA: 0x181B2C920
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B2C3C0 Offset: 0x1B2ADC0 VA: 0x181B2C3C0 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x979B00 Offset: 0x978500 VA: 0x180979B00
	internal bool get_IsContextOk() { }

	// RVA: 0x979B10 Offset: 0x978510 VA: 0x180979B10
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x1B2CA60 Offset: 0x1B2B460 VA: 0x181B2CA60 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x1B2CB30 Offset: 0x1B2B530 VA: 0x181B2CB30 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x1B2C4D0 Offset: 0x1B2AED0 VA: 0x181B2C4D0 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x1B2C280 Offset: 0x1B2AC80 VA: 0x181B2C280 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B2CBA0 Offset: 0x1B2B5A0 VA: 0x181B2CBA0 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	internal void set_SourceProxy(RemotingProxy value) { }
}
