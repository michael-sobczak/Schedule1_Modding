internal class DecalCulledChunk : DecalChunk // TypeDefIndex: 8855
{
	// Fields
	public Vector3 cameraPosition; // 0x28
	public ulong sceneCullingMask; // 0x38
	public int cullingMask; // 0x40
	public CullingGroup cullingGroups; // 0x48
	public int[] visibleDecalIndexArray; // 0x50
	public NativeArray<int> visibleDecalIndices; // 0x58
	public int visibleDecalCount; // 0x68

	// Methods

	// RVA: 0x2AE04F0 Offset: 0x2ADEEF0 VA: 0x182AE04F0 Slot: 6
	public override void RemoveAtSwapBack(int entityIndex) { }

	// RVA: 0x2AE0580 Offset: 0x2ADEF80 VA: 0x182AE0580 Slot: 7
	public override void SetCapacity(int newCapacity) { }

	// RVA: 0x2AE0460 Offset: 0x2ADEE60 VA: 0x182AE0460 Slot: 8
	public override void Dispose() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
