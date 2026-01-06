public struct NativeArray.ReadOnly<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 11532
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(void* buffer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0D60 Offset: 0x10EF760 VA: 0x1810F0D60
	|-NativeArray.ReadOnly<AttachmentDescriptor>..ctor
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>..ctor
	|-NativeArray.ReadOnly<bool>..ctor
	|-NativeArray.ReadOnly<BoundingSphere>..ctor
	|-NativeArray.ReadOnly<byte>..ctor
	|-NativeArray.ReadOnly<Color>..ctor
	|-NativeArray.ReadOnly<Color32>..ctor
	|-NativeArray.ReadOnly<ContactPairHeader>..ctor
	|-NativeArray.ReadOnly<ConvertMeshJobData>..ctor
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>..ctor
	|-NativeArray.ReadOnly<CullingSplit>..ctor
	|-NativeArray.ReadOnly<DecalEntity>..ctor
	|-NativeArray.ReadOnly<DecalSubDrawCall>..ctor
	|-NativeArray.ReadOnly<DrawBufferRange>..ctor
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>..ctor
	|-NativeArray.ReadOnly<InclusiveRange>..ctor
	|-NativeArray.ReadOnly<short>..ctor
	|-NativeArray.ReadOnly<int>..ctor
	|-NativeArray.ReadOnly<Int32Enum>..ctor
	|-NativeArray.ReadOnly<JobHandle>..ctor
	|-NativeArray.ReadOnly<Keyframe>..ctor
	|-NativeArray.ReadOnly<LightDataGI>..ctor
	|-NativeArray.ReadOnly<Matrix4x4>..ctor
	|-NativeArray.ReadOnly<ModifiableContactPair>..ctor
	|-NativeArray.ReadOnly<NudgeJobData>..ctor
	|-NativeArray.ReadOnly<Plane>..ctor
	|-NativeArray.ReadOnly<Quaternion>..ctor
	|-NativeArray.ReadOnly<RenderStateBlock>..ctor
	|-NativeArray.ReadOnly<ShaderTagId>..ctor
	|-NativeArray.ReadOnly<float>..ctor
	|-NativeArray.ReadOnly<TileData>..ctor
	|-NativeArray.ReadOnly<Transform3x4>..ctor
	|-NativeArray.ReadOnly<UEncroachingSegment>..ctor
	|-NativeArray.ReadOnly<UEvent>..ctor
	|-NativeArray.ReadOnly<UHull>..ctor
	|-NativeArray.ReadOnly<ushort>..ctor
	|-NativeArray.ReadOnly<uint>..ctor
	|-NativeArray.ReadOnly<ulong>..ctor
	|-NativeArray.ReadOnly<UStar>..ctor
	|-NativeArray.ReadOnly<UTriangle>..ctor
	|-NativeArray.ReadOnly<Vector2>..ctor
	|-NativeArray.ReadOnly<Vector3>..ctor
	|-NativeArray.ReadOnly<Vector3Int>..ctor
	|-NativeArray.ReadOnly<Vector4>..ctor
	|-NativeArray.ReadOnly<Vertex>..ctor
	|-NativeArray.ReadOnly<VisibleLight>..ctor
	|-NativeArray.ReadOnly<VisibleReflectionProbe>..ctor
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>..ctor
	|-NativeArray.ReadOnly<double2>..ctor
	|-NativeArray.ReadOnly<float2>..ctor
	|-NativeArray.ReadOnly<float3>..ctor
	|-NativeArray.ReadOnly<float4>..ctor
	|-NativeArray.ReadOnly<float4x4>..ctor
	|-NativeArray.ReadOnly<int2>..ctor
	|-NativeArray.ReadOnly<int3>..ctor
	|-NativeArray.ReadOnly<int4>..ctor
	|-NativeArray.ReadOnly<quaternion>..ctor
	|-NativeArray.ReadOnly<LightUtility.LightMeshVertex>..ctor
	|-NativeArray.ReadOnly<ProbeBrickIndex.Brick>..ctor
	|-NativeArray.ReadOnly<ShaderInput.LightData>..ctor
	|-NativeArray.ReadOnly<WordStorage.Entry>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	|-NativeArray.ReadOnly<AttachmentDescriptor>.get_Length
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.get_Length
	|-NativeArray.ReadOnly<bool>.get_Length
	|-NativeArray.ReadOnly<BoundingSphere>.get_Length
	|-NativeArray.ReadOnly<byte>.get_Length
	|-NativeArray.ReadOnly<Color>.get_Length
	|-NativeArray.ReadOnly<Color32>.get_Length
	|-NativeArray.ReadOnly<ContactPairHeader>.get_Length
	|-NativeArray.ReadOnly<ConvertMeshJobData>.get_Length
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.get_Length
	|-NativeArray.ReadOnly<CullingSplit>.get_Length
	|-NativeArray.ReadOnly<DecalEntity>.get_Length
	|-NativeArray.ReadOnly<DecalSubDrawCall>.get_Length
	|-NativeArray.ReadOnly<DrawBufferRange>.get_Length
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.get_Length
	|-NativeArray.ReadOnly<InclusiveRange>.get_Length
	|-NativeArray.ReadOnly<short>.get_Length
	|-NativeArray.ReadOnly<int>.get_Length
	|-NativeArray.ReadOnly<Int32Enum>.get_Length
	|-NativeArray.ReadOnly<JobHandle>.get_Length
	|-NativeArray.ReadOnly<Keyframe>.get_Length
	|-NativeArray.ReadOnly<LightDataGI>.get_Length
	|-NativeArray.ReadOnly<Matrix4x4>.get_Length
	|-NativeArray.ReadOnly<ModifiableContactPair>.get_Length
	|-NativeArray.ReadOnly<NudgeJobData>.get_Length
	|-NativeArray.ReadOnly<Plane>.get_Length
	|-NativeArray.ReadOnly<Quaternion>.get_Length
	|-NativeArray.ReadOnly<RenderStateBlock>.get_Length
	|-NativeArray.ReadOnly<ShaderTagId>.get_Length
	|-NativeArray.ReadOnly<float>.get_Length
	|-NativeArray.ReadOnly<TileData>.get_Length
	|-NativeArray.ReadOnly<Transform3x4>.get_Length
	|-NativeArray.ReadOnly<UEncroachingSegment>.get_Length
	|-NativeArray.ReadOnly<UEvent>.get_Length
	|-NativeArray.ReadOnly<UHull>.get_Length
	|-NativeArray.ReadOnly<ushort>.get_Length
	|-NativeArray.ReadOnly<uint>.get_Length
	|-NativeArray.ReadOnly<ulong>.get_Length
	|-NativeArray.ReadOnly<UStar>.get_Length
	|-NativeArray.ReadOnly<UTriangle>.get_Length
	|-NativeArray.ReadOnly<Vector2>.get_Length
	|-NativeArray.ReadOnly<Vector3>.get_Length
	|-NativeArray.ReadOnly<Vector3Int>.get_Length
	|-NativeArray.ReadOnly<Vector4>.get_Length
	|-NativeArray.ReadOnly<Vertex>.get_Length
	|-NativeArray.ReadOnly<VisibleLight>.get_Length
	|-NativeArray.ReadOnly<VisibleReflectionProbe>.get_Length
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.get_Length
	|-NativeArray.ReadOnly<double2>.get_Length
	|-NativeArray.ReadOnly<float2>.get_Length
	|-NativeArray.ReadOnly<float3>.get_Length
	|-NativeArray.ReadOnly<float4>.get_Length
	|-NativeArray.ReadOnly<float4x4>.get_Length
	|-NativeArray.ReadOnly<int2>.get_Length
	|-NativeArray.ReadOnly<int3>.get_Length
	|-NativeArray.ReadOnly<int4>.get_Length
	|-NativeArray.ReadOnly<quaternion>.get_Length
	|-NativeArray.ReadOnly<LightUtility.LightMeshVertex>.get_Length
	|-NativeArray.ReadOnly<ProbeBrickIndex.Brick>.get_Length
	|-NativeArray.ReadOnly<ShaderInput.LightData>.get_Length
	|-NativeArray.ReadOnly<WordStorage.Entry>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676C0 Offset: 0x10660C0 VA: 0x1810676C0
	|-NativeArray.ReadOnly<AttachmentDescriptor>.get_Item
	|-NativeArray.ReadOnly<NudgeJobData>.get_Item
	|
	|-RVA: 0x10677B0 Offset: 0x10661B0 VA: 0x1810677B0
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.get_Item
	|
	|-RVA: 0x1067770 Offset: 0x1066170 VA: 0x181067770
	|-NativeArray.ReadOnly<bool>.get_Item
	|-NativeArray.ReadOnly<byte>.get_Item
	|
	|-RVA: 0x1075C30 Offset: 0x1074630 VA: 0x181075C30
	|-NativeArray.ReadOnly<BoundingSphere>.get_Item
	|-NativeArray.ReadOnly<Color>.get_Item
	|-NativeArray.ReadOnly<DrawBufferRange>.get_Item
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.get_Item
	|-NativeArray.ReadOnly<JobHandle>.get_Item
	|-NativeArray.ReadOnly<Plane>.get_Item
	|-NativeArray.ReadOnly<Quaternion>.get_Item
	|-NativeArray.ReadOnly<Vector4>.get_Item
	|-NativeArray.ReadOnly<double2>.get_Item
	|-NativeArray.ReadOnly<float4>.get_Item
	|-NativeArray.ReadOnly<int4>.get_Item
	|-NativeArray.ReadOnly<quaternion>.get_Item
	|-NativeArray.ReadOnly<ProbeBrickIndex.Brick>.get_Item
	|
	|-RVA: 0x1075F30 Offset: 0x1074930 VA: 0x181075F30
	|-NativeArray.ReadOnly<Color32>.get_Item
	|-NativeArray.ReadOnly<InclusiveRange>.get_Item
	|-NativeArray.ReadOnly<int>.get_Item
	|-NativeArray.ReadOnly<Int32Enum>.get_Item
	|-NativeArray.ReadOnly<ShaderTagId>.get_Item
	|-NativeArray.ReadOnly<uint>.get_Item
	|
	|-RVA: 0x10760B0 Offset: 0x1074AB0 VA: 0x1810760B0
	|-NativeArray.ReadOnly<ContactPairHeader>.get_Item
	|
	|-RVA: 0x1075FD0 Offset: 0x10749D0 VA: 0x181075FD0
	|-NativeArray.ReadOnly<ConvertMeshJobData>.get_Item
	|
	|-RVA: 0x1075F60 Offset: 0x1074960 VA: 0x181075F60
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.get_Item
	|-NativeArray.ReadOnly<Transform3x4>.get_Item
	|
	|-RVA: 0x1075E90 Offset: 0x1074890 VA: 0x181075E90
	|-NativeArray.ReadOnly<CullingSplit>.get_Item
	|-NativeArray.ReadOnly<LightDataGI>.get_Item
	|-NativeArray.ReadOnly<TileData>.get_Item
	|
	|-RVA: 0x1075C80 Offset: 0x1074680 VA: 0x181075C80
	|-NativeArray.ReadOnly<DecalEntity>.get_Item
	|-NativeArray.ReadOnly<DecalSubDrawCall>.get_Item
	|-NativeArray.ReadOnly<ulong>.get_Item
	|-NativeArray.ReadOnly<int2>.get_Item
	|-NativeArray.ReadOnly<WordStorage.Entry>.get_Item
	|
	|-RVA: 0x1075D30 Offset: 0x1074730 VA: 0x181075D30
	|-NativeArray.ReadOnly<short>.get_Item
	|-NativeArray.ReadOnly<ushort>.get_Item
	|
	|-RVA: 0x1075CC0 Offset: 0x10746C0 VA: 0x181075CC0
	|-NativeArray.ReadOnly<Keyframe>.get_Item
	|
	|-RVA: 0x1075D70 Offset: 0x1074770 VA: 0x181075D70
	|-NativeArray.ReadOnly<Matrix4x4>.get_Item
	|-NativeArray.ReadOnly<Vertex>.get_Item
	|-NativeArray.ReadOnly<float4x4>.get_Item
	|
	|-RVA: 0x1075DF0 Offset: 0x10747F0 VA: 0x181075DF0
	|-NativeArray.ReadOnly<ModifiableContactPair>.get_Item
	|
	|-RVA: 0x1076120 Offset: 0x1074B20 VA: 0x181076120
	|-NativeArray.ReadOnly<RenderStateBlock>.get_Item
	|
	|-RVA: 0x1082010 Offset: 0x1080A10 VA: 0x181082010
	|-NativeArray.ReadOnly<float>.get_Item
	|
	|-RVA: 0x1081C40 Offset: 0x1080640 VA: 0x181081C40
	|-NativeArray.ReadOnly<UEncroachingSegment>.get_Item
	|
	|-RVA: 0x1081BE0 Offset: 0x10805E0 VA: 0x181081BE0
	|-NativeArray.ReadOnly<UEvent>.get_Item
	|-NativeArray.ReadOnly<UStar>.get_Item
	|
	|-RVA: 0x1081F80 Offset: 0x1080980 VA: 0x181081F80
	|-NativeArray.ReadOnly<UHull>.get_Item
	|
	|-RVA: 0x1081B20 Offset: 0x1080520 VA: 0x181081B20
	|-NativeArray.ReadOnly<UTriangle>.get_Item
	|
	|-RVA: 0x1081BA0 Offset: 0x10805A0 VA: 0x181081BA0
	|-NativeArray.ReadOnly<Vector2>.get_Item
	|-NativeArray.ReadOnly<float2>.get_Item
	|
	|-RVA: 0x1081AC0 Offset: 0x10804C0 VA: 0x181081AC0
	|-NativeArray.ReadOnly<Vector3>.get_Item
	|-NativeArray.ReadOnly<Vector3Int>.get_Item
	|-NativeArray.ReadOnly<float3>.get_Item
	|-NativeArray.ReadOnly<int3>.get_Item
	|
	|-RVA: 0x1081CA0 Offset: 0x10806A0 VA: 0x181081CA0
	|-NativeArray.ReadOnly<VisibleLight>.get_Item
	|
	|-RVA: 0x1081EB0 Offset: 0x10808B0 VA: 0x181081EB0
	|-NativeArray.ReadOnly<VisibleReflectionProbe>.get_Item
	|
	|-RVA: 0x112A3C0 Offset: 0x1128DC0 VA: 0x18112A3C0
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.get_Item
	|
	|-RVA: 0x1084FB0 Offset: 0x10839B0 VA: 0x181084FB0
	|-NativeArray.ReadOnly<LightUtility.LightMeshVertex>.get_Item
	|
	|-RVA: 0x1085020 Offset: 0x1083A20 VA: 0x181085020
	|-NativeArray.ReadOnly<ShaderInput.LightData>.get_Item
	*/

	// RVA: -1 Offset: -1
	public NativeArray.ReadOnly.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1127800 Offset: 0x1126200 VA: 0x181127800
	|-NativeArray.ReadOnly<AttachmentDescriptor>.GetEnumerator
	|-NativeArray.ReadOnly<NudgeJobData>.GetEnumerator
	|
	|-RVA: 0x1128BD0 Offset: 0x11275D0 VA: 0x181128BD0
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.GetEnumerator
	|
	|-RVA: 0x11285A0 Offset: 0x1126FA0 VA: 0x1811285A0
	|-NativeArray.ReadOnly<bool>.GetEnumerator
	|-NativeArray.ReadOnly<byte>.GetEnumerator
	|
	|-RVA: 0x1128260 Offset: 0x1126C60 VA: 0x181128260
	|-NativeArray.ReadOnly<BoundingSphere>.GetEnumerator
	|-NativeArray.ReadOnly<Color>.GetEnumerator
	|-NativeArray.ReadOnly<DrawBufferRange>.GetEnumerator
	|-NativeArray.ReadOnly<Plane>.GetEnumerator
	|-NativeArray.ReadOnly<Quaternion>.GetEnumerator
	|-NativeArray.ReadOnly<Vector4>.GetEnumerator
	|-NativeArray.ReadOnly<float4>.GetEnumerator
	|-NativeArray.ReadOnly<int4>.GetEnumerator
	|-NativeArray.ReadOnly<quaternion>.GetEnumerator
	|-NativeArray.ReadOnly<ProbeBrickIndex.Brick>.GetEnumerator
	|
	|-RVA: 0x1127E30 Offset: 0x1126830 VA: 0x181127E30
	|-NativeArray.ReadOnly<Color32>.GetEnumerator
	|-NativeArray.ReadOnly<InclusiveRange>.GetEnumerator
	|-NativeArray.ReadOnly<int>.GetEnumerator
	|-NativeArray.ReadOnly<Int32Enum>.GetEnumerator
	|-NativeArray.ReadOnly<ShaderTagId>.GetEnumerator
	|-NativeArray.ReadOnly<float>.GetEnumerator
	|-NativeArray.ReadOnly<uint>.GetEnumerator
	|
	|-RVA: 0x1128360 Offset: 0x1126D60 VA: 0x181128360
	|-NativeArray.ReadOnly<ContactPairHeader>.GetEnumerator
	|
	|-RVA: 0x1128400 Offset: 0x1126E00 VA: 0x181128400
	|-NativeArray.ReadOnly<ConvertMeshJobData>.GetEnumerator
	|
	|-RVA: 0x1127FB0 Offset: 0x11269B0 VA: 0x181127FB0
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.GetEnumerator
	|
	|-RVA: 0x1127910 Offset: 0x1126310 VA: 0x181127910
	|-NativeArray.ReadOnly<CullingSplit>.GetEnumerator
	|-NativeArray.ReadOnly<LightDataGI>.GetEnumerator
	|-NativeArray.ReadOnly<TileData>.GetEnumerator
	|
	|-RVA: 0x1127F40 Offset: 0x1126940 VA: 0x181127F40
	|-NativeArray.ReadOnly<DecalEntity>.GetEnumerator
	|-NativeArray.ReadOnly<DecalSubDrawCall>.GetEnumerator
	|-NativeArray.ReadOnly<Vector2>.GetEnumerator
	|-NativeArray.ReadOnly<float2>.GetEnumerator
	|-NativeArray.ReadOnly<int2>.GetEnumerator
	|-NativeArray.ReadOnly<WordStorage.Entry>.GetEnumerator
	|
	|-RVA: 0x11281D0 Offset: 0x1126BD0 VA: 0x1811281D0
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.GetEnumerator
	|-NativeArray.ReadOnly<JobHandle>.GetEnumerator
	|-NativeArray.ReadOnly<double2>.GetEnumerator
	|
	|-RVA: 0x1128060 Offset: 0x1126A60 VA: 0x181128060
	|-NativeArray.ReadOnly<short>.GetEnumerator
	|-NativeArray.ReadOnly<ushort>.GetEnumerator
	|
	|-RVA: 0x1127AD0 Offset: 0x11264D0 VA: 0x181127AD0
	|-NativeArray.ReadOnly<Keyframe>.GetEnumerator
	|
	|-RVA: 0x1127A00 Offset: 0x1126400 VA: 0x181127A00
	|-NativeArray.ReadOnly<Matrix4x4>.GetEnumerator
	|-NativeArray.ReadOnly<Vertex>.GetEnumerator
	|-NativeArray.ReadOnly<float4x4>.GetEnumerator
	|
	|-RVA: 0x11280E0 Offset: 0x1126AE0 VA: 0x1811280E0
	|-NativeArray.ReadOnly<ModifiableContactPair>.GetEnumerator
	|
	|-RVA: 0x1128AE0 Offset: 0x11274E0 VA: 0x181128AE0
	|-NativeArray.ReadOnly<RenderStateBlock>.GetEnumerator
	|
	|-RVA: 0x11284F0 Offset: 0x1126EF0 VA: 0x1811284F0
	|-NativeArray.ReadOnly<Transform3x4>.GetEnumerator
	|
	|-RVA: 0x1127EB0 Offset: 0x11268B0 VA: 0x181127EB0
	|-NativeArray.ReadOnly<UEncroachingSegment>.GetEnumerator
	|
	|-RVA: 0x1127DA0 Offset: 0x11267A0 VA: 0x181127DA0
	|-NativeArray.ReadOnly<UEvent>.GetEnumerator
	|
	|-RVA: 0x11287A0 Offset: 0x11271A0 VA: 0x1811287A0
	|-NativeArray.ReadOnly<UHull>.GetEnumerator
	|
	|-RVA: 0x11282F0 Offset: 0x1126CF0 VA: 0x1811282F0
	|-NativeArray.ReadOnly<ulong>.GetEnumerator
	|
	|-RVA: 0x1128970 Offset: 0x1127370 VA: 0x181128970
	|-NativeArray.ReadOnly<UStar>.GetEnumerator
	|
	|-RVA: 0x1127B60 Offset: 0x1126560 VA: 0x181127B60
	|-NativeArray.ReadOnly<UTriangle>.GetEnumerator
	|
	|-RVA: 0x1127D30 Offset: 0x1126730 VA: 0x181127D30
	|-NativeArray.ReadOnly<Vector3>.GetEnumerator
	|-NativeArray.ReadOnly<Vector3Int>.GetEnumerator
	|-NativeArray.ReadOnly<float3>.GetEnumerator
	|-NativeArray.ReadOnly<int3>.GetEnumerator
	|
	|-RVA: 0x1128860 Offset: 0x1127260 VA: 0x181128860
	|-NativeArray.ReadOnly<VisibleLight>.GetEnumerator
	|
	|-RVA: 0x11286C0 Offset: 0x11270C0 VA: 0x1811286C0
	|-NativeArray.ReadOnly<VisibleReflectionProbe>.GetEnumerator
	|
	|-RVA: 0x1127C10 Offset: 0x1126610 VA: 0x181127C10
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.GetEnumerator
	|
	|-RVA: 0x1128620 Offset: 0x1127020 VA: 0x181128620
	|-NativeArray.ReadOnly<LightUtility.LightMeshVertex>.GetEnumerator
	|
	|-RVA: 0x1128A00 Offset: 0x1127400 VA: 0x181128A00
	|-NativeArray.ReadOnly<ShaderInput.LightData>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1129BB0 Offset: 0x11285B0 VA: 0x181129BB0
	|-NativeArray.ReadOnly<AttachmentDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<NudgeJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129450 Offset: 0x1127E50 VA: 0x181129450
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129EE0 Offset: 0x11288E0 VA: 0x181129EE0
	|-NativeArray.ReadOnly<bool>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1128C80 Offset: 0x1127680 VA: 0x181128C80
	|-NativeArray.ReadOnly<BoundingSphere>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<DrawBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<float4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<int4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<ProbeBrickIndex.Brick>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1128EE0 Offset: 0x11278E0 VA: 0x181128EE0
	|-NativeArray.ReadOnly<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<InclusiveRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<ShaderTagId>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x112A060 Offset: 0x1128A60 VA: 0x18112A060
	|-NativeArray.ReadOnly<ContactPairHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129830 Offset: 0x1128230 VA: 0x181129830
	|-NativeArray.ReadOnly<ConvertMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129D60 Offset: 0x1128760 VA: 0x181129D60
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11292C0 Offset: 0x1127CC0 VA: 0x1811292C0
	|-NativeArray.ReadOnly<CullingSplit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<TileData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129390 Offset: 0x1127D90 VA: 0x181129390
	|-NativeArray.ReadOnly<DecalEntity>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<DecalSubDrawCall>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<float2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<int2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<WordStorage.Entry>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11291F0 Offset: 0x1127BF0 VA: 0x1811291F0
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<double2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129500 Offset: 0x1127F00 VA: 0x181129500
	|-NativeArray.ReadOnly<short>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129AE0 Offset: 0x11284E0 VA: 0x181129AE0
	|-NativeArray.ReadOnly<Keyframe>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1128D50 Offset: 0x1127750 VA: 0x181128D50
	|-NativeArray.ReadOnly<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Vertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<float4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129E10 Offset: 0x1128810 VA: 0x181129E10
	|-NativeArray.ReadOnly<ModifiableContactPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x112A2F0 Offset: 0x1128CF0 VA: 0x18112A2F0
	|-NativeArray.ReadOnly<RenderStateBlock>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11295C0 Offset: 0x1127FC0 VA: 0x1811295C0
	|-NativeArray.ReadOnly<Transform3x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129C90 Offset: 0x1128690 VA: 0x181129C90
	|-NativeArray.ReadOnly<UEncroachingSegment>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1128FA0 Offset: 0x11279A0 VA: 0x181128FA0
	|-NativeArray.ReadOnly<UEvent>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129FA0 Offset: 0x11289A0 VA: 0x181129FA0
	|-NativeArray.ReadOnly<UHull>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129070 Offset: 0x1127A70 VA: 0x181129070
	|-NativeArray.ReadOnly<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129920 Offset: 0x1128320 VA: 0x181129920
	|-NativeArray.ReadOnly<UStar>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x112A240 Offset: 0x1128C40 VA: 0x18112A240
	|-NativeArray.ReadOnly<UTriangle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129130 Offset: 0x1127B30 VA: 0x181129130
	|-NativeArray.ReadOnly<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Vector3Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<float3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<int3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129670 Offset: 0x1128070 VA: 0x181129670
	|-NativeArray.ReadOnly<VisibleLight>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1129750 Offset: 0x1128150 VA: 0x181129750
	|-NativeArray.ReadOnly<VisibleReflectionProbe>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x112A140 Offset: 0x1128B40 VA: 0x18112A140
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11299F0 Offset: 0x11283F0 VA: 0x1811299F0
	|-NativeArray.ReadOnly<LightUtility.LightMeshVertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1128E10 Offset: 0x1127810 VA: 0x181128E10
	|-NativeArray.ReadOnly<ShaderInput.LightData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1129BB0 Offset: 0x11285B0 VA: 0x181129BB0
	|-NativeArray.ReadOnly<AttachmentDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<NudgeJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129450 Offset: 0x1127E50 VA: 0x181129450
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129EE0 Offset: 0x11288E0 VA: 0x181129EE0
	|-NativeArray.ReadOnly<bool>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1128C80 Offset: 0x1127680 VA: 0x181128C80
	|-NativeArray.ReadOnly<BoundingSphere>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Color>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<DrawBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Plane>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<float4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<int4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<quaternion>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<ProbeBrickIndex.Brick>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1128EE0 Offset: 0x11278E0 VA: 0x181128EE0
	|-NativeArray.ReadOnly<Color32>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<InclusiveRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<int>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<ShaderTagId>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<float>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x112A060 Offset: 0x1128A60 VA: 0x18112A060
	|-NativeArray.ReadOnly<ContactPairHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129830 Offset: 0x1128230 VA: 0x181129830
	|-NativeArray.ReadOnly<ConvertMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129D60 Offset: 0x1128760 VA: 0x181129D60
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11292C0 Offset: 0x1127CC0 VA: 0x1811292C0
	|-NativeArray.ReadOnly<CullingSplit>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<TileData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129390 Offset: 0x1127D90 VA: 0x181129390
	|-NativeArray.ReadOnly<DecalEntity>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<DecalSubDrawCall>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<float2>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<int2>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<WordStorage.Entry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11291F0 Offset: 0x1127BF0 VA: 0x1811291F0
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<double2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129500 Offset: 0x1127F00 VA: 0x181129500
	|-NativeArray.ReadOnly<short>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129AE0 Offset: 0x11284E0 VA: 0x181129AE0
	|-NativeArray.ReadOnly<Keyframe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1128D50 Offset: 0x1127750 VA: 0x181128D50
	|-NativeArray.ReadOnly<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Vertex>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<float4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129E10 Offset: 0x1128810 VA: 0x181129E10
	|-NativeArray.ReadOnly<ModifiableContactPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x112A2F0 Offset: 0x1128CF0 VA: 0x18112A2F0
	|-NativeArray.ReadOnly<RenderStateBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11295C0 Offset: 0x1127FC0 VA: 0x1811295C0
	|-NativeArray.ReadOnly<Transform3x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129C90 Offset: 0x1128690 VA: 0x181129C90
	|-NativeArray.ReadOnly<UEncroachingSegment>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1128FA0 Offset: 0x11279A0 VA: 0x181128FA0
	|-NativeArray.ReadOnly<UEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129FA0 Offset: 0x11289A0 VA: 0x181129FA0
	|-NativeArray.ReadOnly<UHull>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129070 Offset: 0x1127A70 VA: 0x181129070
	|-NativeArray.ReadOnly<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129920 Offset: 0x1128320 VA: 0x181129920
	|-NativeArray.ReadOnly<UStar>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x112A240 Offset: 0x1128C40 VA: 0x18112A240
	|-NativeArray.ReadOnly<UTriangle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129130 Offset: 0x1127B30 VA: 0x181129130
	|-NativeArray.ReadOnly<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<float3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<int3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129670 Offset: 0x1128070 VA: 0x181129670
	|-NativeArray.ReadOnly<VisibleLight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1129750 Offset: 0x1128150 VA: 0x181129750
	|-NativeArray.ReadOnly<VisibleReflectionProbe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x112A140 Offset: 0x1128B40 VA: 0x18112A140
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11299F0 Offset: 0x11283F0 VA: 0x1811299F0
	|-NativeArray.ReadOnly<LightUtility.LightMeshVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1128E10 Offset: 0x1127810 VA: 0x181128E10
	|-NativeArray.ReadOnly<ShaderInput.LightData>.System.Collections.IEnumerable.GetEnumerator
	*/
}
