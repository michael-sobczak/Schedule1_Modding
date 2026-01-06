internal class ClientIdentity : Identity // TypeDefIndex: 4278
{
	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0x1B070C0 Offset: 0x1B05AC0 VA: 0x181B070C0
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0x1B071A0 Offset: 0x1B05BA0 VA: 0x181B071A0
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0x1B07260 Offset: 0x1B05C60 VA: 0x181B07260
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1B07230 Offset: 0x1B05C30 VA: 0x181B07230
	public string get_TargetUri() { }
}
