internal class DecalDrawCallChunk : DecalChunk // TypeDefIndex: 8839
{
	// Fields
	public NativeArray<float4x4> decalToWorlds; // 0x28
	public NativeArray<float4x4> normalToDecals; // 0x38
	public NativeArray<float> renderingLayerMasks; // 0x48
	public NativeArray<DecalSubDrawCall> subCalls; // 0x58
	public NativeArray<int> subCallCounts; // 0x68

	// Properties
	public int subCallCount { get; set; }

	// Methods

	// RVA: 0x2AE0860 Offset: 0x2ADF260 VA: 0x182AE0860
	public void set_subCallCount(int value) { }

	// RVA: 0x2AE0850 Offset: 0x2ADF250 VA: 0x182AE0850
	public int get_subCallCount() { }

	// RVA: 0x2AE06E0 Offset: 0x2ADF0E0 VA: 0x182AE06E0 Slot: 6
	public override void RemoveAtSwapBack(int entityIndex) { }

	// RVA: 0x2AE07B0 Offset: 0x2ADF1B0 VA: 0x182AE07B0 Slot: 7
	public override void SetCapacity(int newCapacity) { }

	// RVA: 0x2AE0630 Offset: 0x2ADF030 VA: 0x182AE0630 Slot: 8
	public override void Dispose() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
