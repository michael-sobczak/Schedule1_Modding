public abstract class RealProxy // TypeDefIndex: 4305
{
	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x1B131B0 Offset: 0x1B11BB0 VA: 0x181B131B0
	protected void .ctor() { }

	// RVA: 0x1B132E0 Offset: 0x1B11CE0 VA: 0x181B132E0
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x1B13170 Offset: 0x1B11B70 VA: 0x181B13170
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x1B131C0 Offset: 0x1B11BC0 VA: 0x181B131C0
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x1B12270 Offset: 0x1B10C70 VA: 0x181B12270
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x1B12090 Offset: 0x1B10A90 VA: 0x181B12090
	public Type GetProxiedType() { }

	// RVA: 0x1B12020 Offset: 0x1B10A20 VA: 0x181B12020 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x1B12290 Offset: 0x1B10C90 VA: 0x181B12290
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x1B12280 Offset: 0x1B10C80 VA: 0x181B12280 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x1B12130 Offset: 0x1B10B30 VA: 0x181B12130 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x1B11EF0 Offset: 0x1B108F0 VA: 0x181B11EF0
	internal object GetAppDomainTarget() { }

	// RVA: 0x1B12B40 Offset: 0x1B11540 VA: 0x181B12B40
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }
}
