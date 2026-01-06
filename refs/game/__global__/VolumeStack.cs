public sealed class VolumeStack : IDisposable // TypeDefIndex: 13939
{
	// Fields
	internal readonly Dictionary<Type, VolumeComponent> components; // 0x10
	[TupleElementNames(new[] { "parameter", "defaultValue" })]
	internal ValueTuple<VolumeParameter, VolumeParameter>[] defaultParameters; // 0x18
	internal bool requiresReset; // 0x20

	// Methods

	// RVA: 0x2A5E5C0 Offset: 0x2A5CFC0 VA: 0x182A5E5C0
	internal void .ctor() { }

	// RVA: 0x2A5DF20 Offset: 0x2A5C920 VA: 0x182A5DF20
	internal void Clear() { }

	// RVA: 0x2A5E190 Offset: 0x2A5CB90 VA: 0x182A5E190
	internal void Reload(List<VolumeComponent> componentDefaultStates) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF77730 Offset: 0xF76130 VA: 0x180F77730
	|-VolumeStack.GetComponent<object>
	*/

	// RVA: 0x2A5E120 Offset: 0x2A5CB20 VA: 0x182A5E120
	public VolumeComponent GetComponent(Type type) { }

	// RVA: 0x2A5E110 Offset: 0x2A5CB10 VA: 0x182A5E110 Slot: 4
	public void Dispose() { }
}
