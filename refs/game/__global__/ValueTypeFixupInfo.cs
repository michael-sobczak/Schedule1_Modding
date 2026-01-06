internal sealed class ValueTypeFixupInfo // TypeDefIndex: 4429
{
	// Fields
	private readonly long _containerID; // 0x10
	private readonly FieldInfo _parentField; // 0x18
	private readonly int[] _parentIndex; // 0x20

	// Properties
	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }

	// Methods

	// RVA: 0x1B426A0 Offset: 0x1B410A0 VA: 0x181B426A0
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public long get_ContainerID() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public FieldInfo get_ParentField() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public int[] get_ParentIndex() { }
}
