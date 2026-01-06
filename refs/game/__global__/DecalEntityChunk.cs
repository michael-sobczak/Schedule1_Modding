internal class DecalEntityChunk : DecalChunk // TypeDefIndex: 8846
{
	// Fields
	public Material material; // 0x28
	public NativeArray<DecalEntity> decalEntities; // 0x30
	public DecalProjector[] decalProjectors; // 0x40
	public TransformAccessArray transformAccessArray; // 0x48

	// Methods

	// RVA: 0xB49A10 Offset: 0xB48410 VA: 0x180B49A10 Slot: 5
	public override void Push() { }

	// RVA: 0x2AE20A0 Offset: 0x2AE0AA0 VA: 0x182AE20A0 Slot: 6
	public override void RemoveAtSwapBack(int entityIndex) { }

	// RVA: 0x2AE2140 Offset: 0x2AE0B40 VA: 0x182AE2140 Slot: 7
	public override void SetCapacity(int newCapacity) { }

	// RVA: 0x2AE2030 Offset: 0x2AE0A30 VA: 0x182AE2030 Slot: 8
	public override void Dispose() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
