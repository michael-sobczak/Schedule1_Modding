internal class InvokableCallList // TypeDefIndex: 11962
{
	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x2CE0E00 Offset: 0x2CDF800 VA: 0x182CE0E00
	public int get_Count() { }

	// RVA: 0x2CE07D0 Offset: 0x2CDF1D0 VA: 0x182CE07D0
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x2CE0710 Offset: 0x2CDF110 VA: 0x182CE0710
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x2CE0AC0 Offset: 0x2CDF4C0 VA: 0x182CE0AC0
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x2CE0950 Offset: 0x2CDF350 VA: 0x182CE0950
	public void Clear() { }

	// RVA: 0x2CE0890 Offset: 0x2CDF290 VA: 0x182CE0890
	public void ClearPersistent() { }

	// RVA: 0x2CE0A10 Offset: 0x2CDF410 VA: 0x182CE0A10
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x2CE0D20 Offset: 0x2CDF720 VA: 0x182CE0D20
	public void .ctor() { }
}
