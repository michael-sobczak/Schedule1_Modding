public class ProxyAttribute : Attribute, IContextAttribute // TypeDefIndex: 4303
{
	// Methods

	// RVA: 0x1B11D50 Offset: 0x1B10750 VA: 0x181B11D50 Slot: 9
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x1B11E90 Offset: 0x1B10890 VA: 0x181B11E90 Slot: 10
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[ComVisible(True)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[ComVisible(True)]
	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }
}
