internal abstract class ServerIdentity : Identity // TypeDefIndex: 4289
{
	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x1B1B7E0 Offset: 0x1B1A1E0 VA: 0x181B1B7E0
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Type get_ObjectType() { }

	// RVA: 0x1B1B4C0 Offset: 0x1B19EC0 VA: 0x181B1B4C0
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x1B1B4B0 Offset: 0x1B19EB0 VA: 0x181B1B4B0 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x1B1B210 Offset: 0x1B19C10 VA: 0x181B1B210 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1B1B190 Offset: 0x1B19B90 VA: 0x181B1B190
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Lease get_Lease() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public Context get_Context() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x1B1B410 Offset: 0x1B19E10 VA: 0x181B1B410
	protected void DisposeServerObject() { }
}
