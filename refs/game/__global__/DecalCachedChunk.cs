internal class DecalCachedChunk : DecalChunk // TypeDefIndex: 8851
{
	// Fields
	public MaterialPropertyBlock propertyBlock; // 0x28
	public int passIndexDBuffer; // 0x30
	public int passIndexEmissive; // 0x34
	public int passIndexScreenSpace; // 0x38
	public int passIndexGBuffer; // 0x3C
	public int drawOrder; // 0x40
	public bool isCreated; // 0x44
	public NativeArray<float4x4> decalToWorlds; // 0x48
	public NativeArray<float4x4> normalToWorlds; // 0x58
	public NativeArray<float4x4> sizeOffsets; // 0x68
	public NativeArray<float2> drawDistances; // 0x78
	public NativeArray<float2> angleFades; // 0x88
	public NativeArray<float4> uvScaleBias; // 0x98
	public NativeArray<int> layerMasks; // 0xA8
	public NativeArray<ulong> sceneLayerMasks; // 0xB8
	public NativeArray<float> fadeFactors; // 0xC8
	public NativeArray<BoundingSphere> boundingSpheres; // 0xD8
	public NativeArray<DecalScaleMode> scaleModes; // 0xE8
	public NativeArray<uint> renderingLayerMasks; // 0xF8
	public NativeArray<float3> positions; // 0x108
	public NativeArray<quaternion> rotation; // 0x118
	public NativeArray<float3> scales; // 0x128
	public NativeArray<bool> dirty; // 0x138
	public BoundingSphere[] boundingSphereArray; // 0x148

	// Methods

	// RVA: 0x2ADF760 Offset: 0x2ADE160 VA: 0x182ADF760 Slot: 6
	public override void RemoveAtSwapBack(int entityIndex) { }

	// RVA: 0x2ADFA70 Offset: 0x2ADE470 VA: 0x182ADFA70 Slot: 7
	public override void SetCapacity(int newCapacity) { }

	// RVA: 0x2ADF570 Offset: 0x2ADDF70 VA: 0x182ADF570 Slot: 8
	public override void Dispose() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
