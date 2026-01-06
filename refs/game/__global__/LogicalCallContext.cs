public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 4363
{
	// Fields
	private static Type s_callContextType; // 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30
	private Header[] _sendHeaders; // 0x38
	private Header[] _recvHeaders; // 0x40

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1B32AF0 Offset: 0x1B314F0 VA: 0x181B32AF0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B32280 Offset: 0x1B30C80 VA: 0x181B32280 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B31A30 Offset: 0x1B30430 VA: 0x181B31A30 Slot: 5
	public object Clone() { }

	// RVA: 0x1B32650 Offset: 0x1B31050 VA: 0x181B32650
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x1B33280 Offset: 0x1B31C80 VA: 0x181B33280
	public bool get_HasInfo() { }

	// RVA: 0x1B319F0 Offset: 0x1B303F0 VA: 0x181B319F0
	private bool get_HasUserData() { }

	// RVA: 0x1B33210 Offset: 0x1B31C10 VA: 0x181B33210
	private Hashtable get_Datastore() { }

	// RVA: 0x1B321E0 Offset: 0x1B30BE0 VA: 0x181B321E0
	public object GetData(string name) { }

	// RVA: 0x1B32970 Offset: 0x1B31370 VA: 0x181B32970
	public void SetData(string name, object data) { }

	// RVA: 0x1B32A60 Offset: 0x1B31460 VA: 0x181B32A60
	private static void .cctor() { }
}
