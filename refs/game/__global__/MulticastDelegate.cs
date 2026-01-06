public abstract class MulticastDelegate : Delegate // TypeDefIndex: 3865
{
	// Fields
	private Delegate[] delegates; // 0x78

	// Methods

	// RVA: 0x1CBE7A0 Offset: 0x1CBD1A0 VA: 0x181CBE7A0 Slot: 9
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CC5430 Offset: 0x1CC3E30 VA: 0x181CC5430 Slot: 6
	protected sealed override object DynamicInvokeImpl(object[] args) { }

	// RVA: 0x1CC54F0 Offset: 0x1CC3EF0 VA: 0x181CC54F0 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x1CBE540 Offset: 0x1CBCF40 VA: 0x181CBE540 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x1CC5750 Offset: 0x1CC4150 VA: 0x181CC5750 Slot: 8
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x1CC5660 Offset: 0x1CC4060 VA: 0x181CC5660 Slot: 10
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x1CC5080 Offset: 0x1CC3A80 VA: 0x181CC5080 Slot: 11
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x1CC58C0 Offset: 0x1CC42C0 VA: 0x181CC58C0
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x1CC5A50 Offset: 0x1CC4450 VA: 0x181CC5A50 Slot: 12
	protected sealed override Delegate RemoveImpl(Delegate value) { }
}
