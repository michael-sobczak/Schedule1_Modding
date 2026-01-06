public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> // TypeDefIndex: 11533
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, Allocator allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1067460 Offset: 0x1065E60 VA: 0x181067460
	|-NativeArray<AttachmentDescriptor>..ctor
	|-NativeArray<NudgeJobData>..ctor
	|
	|-RVA: 0x10672C0 Offset: 0x1065CC0 VA: 0x1810672C0
	|-NativeArray<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x1066FC0 Offset: 0x10659C0 VA: 0x181066FC0
	|-NativeArray<bool>..ctor
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x1074160 Offset: 0x1072B60 VA: 0x181074160
	|-NativeArray<BoundingSphere>..ctor
	|-NativeArray<Color>..ctor
	|-NativeArray<DrawBufferRange>..ctor
	|-NativeArray<Plane>..ctor
	|-NativeArray<Quaternion>..ctor
	|-NativeArray<Vector4>..ctor
	|-NativeArray<float4>..ctor
	|-NativeArray<int4>..ctor
	|-NativeArray<quaternion>..ctor
	|-NativeArray<ProbeBrickIndex.Brick>..ctor
	|
	|-RVA: 0x1073F00 Offset: 0x1072900 VA: 0x181073F00
	|-NativeArray<Color32>..ctor
	|-NativeArray<int>..ctor
	|-NativeArray<Int32Enum>..ctor
	|-NativeArray<ShaderTagId>..ctor
	|-NativeArray<float>..ctor
	|-NativeArray<uint>..ctor
	|
	|-RVA: 0x1074D40 Offset: 0x1073740 VA: 0x181074D40
	|-NativeArray<ContactPairHeader>..ctor
	|
	|-RVA: 0x1074370 Offset: 0x1072D70 VA: 0x181074370
	|-NativeArray<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x10756D0 Offset: 0x10740D0 VA: 0x1810756D0
	|-NativeArray<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x1074730 Offset: 0x1073130 VA: 0x181074730
	|-NativeArray<CullingSplit>..ctor
	|-NativeArray<LightDataGI>..ctor
	|-NativeArray<TileData>..ctor
	|
	|-RVA: 0x1074680 Offset: 0x1073080 VA: 0x181074680
	|-NativeArray<DecalEntity>..ctor
	|-NativeArray<DecalSubDrawCall>..ctor
	|-NativeArray<Vector2>..ctor
	|-NativeArray<float2>..ctor
	|-NativeArray<int2>..ctor
	|-NativeArray<WordStorage.Entry>..ctor
	|
	|-RVA: 0x10753B0 Offset: 0x1073DB0 VA: 0x1810753B0
	|-NativeArray<GfxUpdateBufferRange>..ctor
	|-NativeArray<JobHandle>..ctor
	|-NativeArray<double2>..ctor
	|
	|-RVA: 0x1075980 Offset: 0x1074380 VA: 0x181075980
	|-NativeArray<InclusiveRange>..ctor
	|
	|-RVA: 0x10740B0 Offset: 0x1072AB0 VA: 0x1810740B0
	|-NativeArray<short>..ctor
	|-NativeArray<ushort>..ctor
	|
	|-RVA: 0x1074990 Offset: 0x1073390 VA: 0x181074990
	|-NativeArray<Keyframe>..ctor
	|
	|-RVA: 0x1075B80 Offset: 0x1074580 VA: 0x181075B80
	|-NativeArray<Matrix4x4>..ctor
	|-NativeArray<Vertex>..ctor
	|-NativeArray<float4x4>..ctor
	|
	|-RVA: 0x1075AE0 Offset: 0x10744E0 VA: 0x181075AE0
	|-NativeArray<ModifiableContactPair>..ctor
	|
	|-RVA: 0x1074A30 Offset: 0x1073430 VA: 0x181074A30
	|-NativeArray<RenderStateBlock>..ctor
	|
	|-RVA: 0x1080870 Offset: 0x107F270 VA: 0x181080870
	|-NativeArray<Transform3x4>..ctor
	|
	|-RVA: 0x1081550 Offset: 0x107FF50 VA: 0x181081550
	|-NativeArray<UEncroachingSegment>..ctor
	|
	|-RVA: 0x1080600 Offset: 0x107F000 VA: 0x181080600
	|-NativeArray<UEvent>..ctor
	|
	|-RVA: 0x1081860 Offset: 0x1080260 VA: 0x181081860
	|-NativeArray<UHull>..ctor
	|
	|-RVA: 0x10811E0 Offset: 0x107FBE0 VA: 0x1810811E0
	|-NativeArray<ulong>..ctor
	|
	|-RVA: 0x1081030 Offset: 0x107FA30 VA: 0x181081030
	|-NativeArray<UStar>..ctor
	|
	|-RVA: 0x1080EE0 Offset: 0x107F8E0 VA: 0x181080EE0
	|-NativeArray<UTriangle>..ctor
	|
	|-RVA: 0x1080240 Offset: 0x107EC40 VA: 0x181080240
	|-NativeArray<Vector3>..ctor
	|-NativeArray<Vector3Int>..ctor
	|-NativeArray<float3>..ctor
	|-NativeArray<int3>..ctor
	|
	|-RVA: 0x10817C0 Offset: 0x10801C0 VA: 0x1810817C0
	|-NativeArray<VisibleLight>..ctor
	|
	|-RVA: 0x10807C0 Offset: 0x107F1C0 VA: 0x1810807C0
	|-NativeArray<VisibleReflectionProbe>..ctor
	|
	|-RVA: 0x1080B40 Offset: 0x107F540 VA: 0x181080B40
	|-NativeArray<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x1084F00 Offset: 0x1083900 VA: 0x181084F00
	|-NativeArray<LightUtility.LightMeshVertex>..ctor
	|
	|-RVA: 0x1084DB0 Offset: 0x10837B0 VA: 0x181084DB0
	|-NativeArray<ShaderInput.LightData>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1067210 Offset: 0x1065C10 VA: 0x181067210
	|-NativeArray<AttachmentDescriptor>..ctor
	|-NativeArray<NudgeJobData>..ctor
	|
	|-RVA: 0x1067060 Offset: 0x1065A60 VA: 0x181067060
	|-NativeArray<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x1067600 Offset: 0x1066000 VA: 0x181067600
	|-NativeArray<bool>..ctor
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x1073D50 Offset: 0x1072750 VA: 0x181073D50
	|-NativeArray<BoundingSphere>..ctor
	|-NativeArray<Color>..ctor
	|-NativeArray<DrawBufferRange>..ctor
	|-NativeArray<Plane>..ctor
	|-NativeArray<Quaternion>..ctor
	|-NativeArray<Vector4>..ctor
	|-NativeArray<float4>..ctor
	|-NativeArray<int4>..ctor
	|-NativeArray<quaternion>..ctor
	|-NativeArray<ProbeBrickIndex.Brick>..ctor
	|
	|-RVA: 0x10747E0 Offset: 0x10731E0 VA: 0x1810747E0
	|-NativeArray<Color32>..ctor
	|-NativeArray<int>..ctor
	|-NativeArray<Int32Enum>..ctor
	|-NativeArray<ShaderTagId>..ctor
	|-NativeArray<float>..ctor
	|-NativeArray<uint>..ctor
	|
	|-RVA: 0x1074210 Offset: 0x1072C10 VA: 0x181074210
	|-NativeArray<ContactPairHeader>..ctor
	|
	|-RVA: 0x1075A30 Offset: 0x1074430 VA: 0x181075A30
	|-NativeArray<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x1074C90 Offset: 0x1073690 VA: 0x181074C90
	|-NativeArray<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x10742C0 Offset: 0x1072CC0 VA: 0x1810742C0
	|-NativeArray<CullingSplit>..ctor
	|-NativeArray<LightDataGI>..ctor
	|-NativeArray<TileData>..ctor
	|
	|-RVA: 0x10745D0 Offset: 0x1072FD0 VA: 0x1810745D0
	|-NativeArray<DecalEntity>..ctor
	|-NativeArray<DecalSubDrawCall>..ctor
	|-NativeArray<Vector2>..ctor
	|-NativeArray<float2>..ctor
	|-NativeArray<int2>..ctor
	|-NativeArray<WordStorage.Entry>..ctor
	|
	|-RVA: 0x1074520 Offset: 0x1072F20 VA: 0x181074520
	|-NativeArray<GfxUpdateBufferRange>..ctor
	|-NativeArray<JobHandle>..ctor
	|-NativeArray<double2>..ctor
	|
	|-RVA: 0x10750F0 Offset: 0x1073AF0 VA: 0x1810750F0
	|-NativeArray<InclusiveRange>..ctor
	|
	|-RVA: 0x1075620 Offset: 0x1074020 VA: 0x181075620
	|-NativeArray<short>..ctor
	|-NativeArray<ushort>..ctor
	|
	|-RVA: 0x1073B90 Offset: 0x1072590 VA: 0x181073B90
	|-NativeArray<Keyframe>..ctor
	|
	|-RVA: 0x1073AE0 Offset: 0x10724E0 VA: 0x181073AE0
	|-NativeArray<Matrix4x4>..ctor
	|-NativeArray<Vertex>..ctor
	|-NativeArray<float4x4>..ctor
	|
	|-RVA: 0x1075460 Offset: 0x1073E60 VA: 0x181075460
	|-NativeArray<ModifiableContactPair>..ctor
	|
	|-RVA: 0x1074BE0 Offset: 0x10735E0 VA: 0x181074BE0
	|-NativeArray<RenderStateBlock>..ctor
	|
	|-RVA: 0x10804A0 Offset: 0x107EEA0 VA: 0x1810804A0
	|-NativeArray<Transform3x4>..ctor
	|
	|-RVA: 0x1081710 Offset: 0x1080110 VA: 0x181081710
	|-NativeArray<UEncroachingSegment>..ctor
	|
	|-RVA: 0x107FED0 Offset: 0x107E8D0 VA: 0x18107FED0
	|-NativeArray<UEvent>..ctor
	|
	|-RVA: 0x1080F80 Offset: 0x107F980 VA: 0x181080F80
	|-NativeArray<UHull>..ctor
	|
	|-RVA: 0x1080E30 Offset: 0x107F830 VA: 0x181080E30
	|-NativeArray<ulong>..ctor
	|
	|-RVA: 0x1080550 Offset: 0x107EF50 VA: 0x181080550
	|-NativeArray<UStar>..ctor
	|
	|-RVA: 0x10803F0 Offset: 0x107EDF0 VA: 0x1810803F0
	|-NativeArray<UTriangle>..ctor
	|
	|-RVA: 0x107FF80 Offset: 0x107E980 VA: 0x18107FF80
	|-NativeArray<Vector3>..ctor
	|-NativeArray<Vector3Int>..ctor
	|-NativeArray<float3>..ctor
	|-NativeArray<int3>..ctor
	|
	|-RVA: 0x10814A0 Offset: 0x107FEA0 VA: 0x1810814A0
	|-NativeArray<VisibleLight>..ctor
	|
	|-RVA: 0x1080C80 Offset: 0x107F680 VA: 0x181080C80
	|-NativeArray<VisibleReflectionProbe>..ctor
	|
	|-RVA: 0x1080D30 Offset: 0x107F730 VA: 0x181080D30
	|-NativeArray<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x1084C00 Offset: 0x1083600 VA: 0x181084C00
	|-NativeArray<LightUtility.LightMeshVertex>..ctor
	|
	|-RVA: 0x1084E50 Offset: 0x1083850 VA: 0x181084E50
	|-NativeArray<ShaderInput.LightData>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1067110 Offset: 0x1065B10 VA: 0x181067110
	|-NativeArray<AttachmentDescriptor>..ctor
	|-NativeArray<NudgeJobData>..ctor
	|
	|-RVA: 0x1067360 Offset: 0x1065D60 VA: 0x181067360
	|-NativeArray<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x1067500 Offset: 0x1065F00 VA: 0x181067500
	|-NativeArray<bool>..ctor
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x1073FB0 Offset: 0x10729B0 VA: 0x181073FB0
	|-NativeArray<BoundingSphere>..ctor
	|-NativeArray<Color>..ctor
	|-NativeArray<DrawBufferRange>..ctor
	|-NativeArray<Plane>..ctor
	|-NativeArray<Quaternion>..ctor
	|-NativeArray<Vector4>..ctor
	|-NativeArray<float4>..ctor
	|-NativeArray<int4>..ctor
	|-NativeArray<quaternion>..ctor
	|-NativeArray<ProbeBrickIndex.Brick>..ctor
	|
	|-RVA: 0x1074EF0 Offset: 0x10738F0 VA: 0x181074EF0
	|-NativeArray<Color32>..ctor
	|-NativeArray<int>..ctor
	|-NativeArray<Int32Enum>..ctor
	|-NativeArray<ShaderTagId>..ctor
	|-NativeArray<float>..ctor
	|-NativeArray<uint>..ctor
	|
	|-RVA: 0x1074AD0 Offset: 0x10734D0 VA: 0x181074AD0
	|-NativeArray<ContactPairHeader>..ctor
	|
	|-RVA: 0x10752B0 Offset: 0x1073CB0 VA: 0x1810752B0
	|-NativeArray<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x1075510 Offset: 0x1073F10 VA: 0x181075510
	|-NativeArray<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x1073C40 Offset: 0x1072640 VA: 0x181073C40
	|-NativeArray<CullingSplit>..ctor
	|-NativeArray<LightDataGI>..ctor
	|-NativeArray<TileData>..ctor
	|
	|-RVA: 0x1074FF0 Offset: 0x10739F0 VA: 0x181074FF0
	|-NativeArray<DecalEntity>..ctor
	|-NativeArray<DecalSubDrawCall>..ctor
	|-NativeArray<Vector2>..ctor
	|-NativeArray<float2>..ctor
	|-NativeArray<int2>..ctor
	|-NativeArray<WordStorage.Entry>..ctor
	|
	|-RVA: 0x1073E00 Offset: 0x1072800 VA: 0x181073E00
	|-NativeArray<GfxUpdateBufferRange>..ctor
	|-NativeArray<JobHandle>..ctor
	|-NativeArray<double2>..ctor
	|
	|-RVA: 0x1074890 Offset: 0x1073290 VA: 0x181074890
	|-NativeArray<InclusiveRange>..ctor
	|
	|-RVA: 0x10751A0 Offset: 0x1073BA0 VA: 0x1810751A0
	|-NativeArray<short>..ctor
	|-NativeArray<ushort>..ctor
	|
	|-RVA: 0x1075880 Offset: 0x1074280 VA: 0x181075880
	|-NativeArray<Keyframe>..ctor
	|
	|-RVA: 0x1074DF0 Offset: 0x10737F0 VA: 0x181074DF0
	|-NativeArray<Matrix4x4>..ctor
	|-NativeArray<Vertex>..ctor
	|-NativeArray<float4x4>..ctor
	|
	|-RVA: 0x1075780 Offset: 0x1074180 VA: 0x181075780
	|-NativeArray<ModifiableContactPair>..ctor
	|
	|-RVA: 0x1074420 Offset: 0x1072E20 VA: 0x181074420
	|-NativeArray<RenderStateBlock>..ctor
	|
	|-RVA: 0x10806B0 Offset: 0x107F0B0 VA: 0x1810806B0
	|-NativeArray<Transform3x4>..ctor
	|
	|-RVA: 0x1080A30 Offset: 0x107F430 VA: 0x181080A30
	|-NativeArray<UEncroachingSegment>..ctor
	|
	|-RVA: 0x1080030 Offset: 0x107EA30 VA: 0x181080030
	|-NativeArray<UEvent>..ctor
	|
	|-RVA: 0x1081600 Offset: 0x1080000 VA: 0x181081600
	|-NativeArray<UHull>..ctor
	|
	|-RVA: 0x10802F0 Offset: 0x107ECF0 VA: 0x1810802F0
	|-NativeArray<ulong>..ctor
	|
	|-RVA: 0x1080920 Offset: 0x107F320 VA: 0x181080920
	|-NativeArray<UStar>..ctor
	|
	|-RVA: 0x1080140 Offset: 0x107EB40 VA: 0x181080140
	|-NativeArray<UTriangle>..ctor
	|
	|-RVA: 0x1081390 Offset: 0x107FD90 VA: 0x181081390
	|-NativeArray<Vector3>..ctor
	|-NativeArray<Vector3Int>..ctor
	|-NativeArray<float3>..ctor
	|-NativeArray<int3>..ctor
	|
	|-RVA: 0x1081290 Offset: 0x107FC90 VA: 0x181081290
	|-NativeArray<VisibleLight>..ctor
	|
	|-RVA: 0x10810E0 Offset: 0x107FAE0 VA: 0x1810810E0
	|-NativeArray<VisibleReflectionProbe>..ctor
	|
	|-RVA: 0x1081910 Offset: 0x1080310 VA: 0x181081910
	|-NativeArray<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x1084AF0 Offset: 0x10834F0 VA: 0x181084AF0
	|-NativeArray<LightUtility.LightMeshVertex>..ctor
	|
	|-RVA: 0x1084CB0 Offset: 0x10836B0 VA: 0x181084CB0
	|-NativeArray<ShaderInput.LightData>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Allocate(int length, Allocator allocator, out NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1063F70 Offset: 0x1062970 VA: 0x181063F70
	|-NativeArray<AttachmentDescriptor>.Allocate
	|-NativeArray<NudgeJobData>.Allocate
	|
	|-RVA: 0x1064010 Offset: 0x1062A10 VA: 0x181064010
	|-NativeArray<BatchCullingOutputDrawCommands>.Allocate
	|
	|-RVA: 0x1063ED0 Offset: 0x10628D0 VA: 0x181063ED0
	|-NativeArray<bool>.Allocate
	|-NativeArray<byte>.Allocate
	|
	|-RVA: 0x1067ED0 Offset: 0x10668D0 VA: 0x181067ED0
	|-NativeArray<BoundingSphere>.Allocate
	|-NativeArray<Color>.Allocate
	|-NativeArray<DrawBufferRange>.Allocate
	|-NativeArray<Plane>.Allocate
	|-NativeArray<Quaternion>.Allocate
	|-NativeArray<Vector4>.Allocate
	|-NativeArray<float4>.Allocate
	|-NativeArray<int4>.Allocate
	|-NativeArray<quaternion>.Allocate
	|-NativeArray<ProbeBrickIndex.Brick>.Allocate
	|
	|-RVA: 0x10679D0 Offset: 0x10663D0 VA: 0x1810679D0
	|-NativeArray<Color32>.Allocate
	|-NativeArray<int>.Allocate
	|-NativeArray<Int32Enum>.Allocate
	|-NativeArray<ShaderTagId>.Allocate
	|-NativeArray<float>.Allocate
	|-NativeArray<uint>.Allocate
	|
	|-RVA: 0x1068150 Offset: 0x1066B50 VA: 0x181068150
	|-NativeArray<ContactPairHeader>.Allocate
	|
	|-RVA: 0x1067E30 Offset: 0x1066830 VA: 0x181067E30
	|-NativeArray<ConvertMeshJobData>.Allocate
	|
	|-RVA: 0x1067F70 Offset: 0x1066970 VA: 0x181067F70
	|-NativeArray<CopyClosingMeshJobData>.Allocate
	|
	|-RVA: 0x10681F0 Offset: 0x1066BF0 VA: 0x1810681F0
	|-NativeArray<CullingSplit>.Allocate
	|-NativeArray<LightDataGI>.Allocate
	|-NativeArray<TileData>.Allocate
	|
	|-RVA: 0x1067B10 Offset: 0x1066510 VA: 0x181067B10
	|-NativeArray<DecalEntity>.Allocate
	|-NativeArray<DecalSubDrawCall>.Allocate
	|-NativeArray<Vector2>.Allocate
	|-NativeArray<float2>.Allocate
	|-NativeArray<int2>.Allocate
	|-NativeArray<WordStorage.Entry>.Allocate
	|
	|-RVA: 0x10680B0 Offset: 0x1066AB0 VA: 0x1810680B0
	|-NativeArray<GfxUpdateBufferRange>.Allocate
	|-NativeArray<JobHandle>.Allocate
	|-NativeArray<double2>.Allocate
	|
	|-RVA: 0x1067D90 Offset: 0x1066790 VA: 0x181067D90
	|-NativeArray<InclusiveRange>.Allocate
	|
	|-RVA: 0x1067A70 Offset: 0x1066470 VA: 0x181067A70
	|-NativeArray<short>.Allocate
	|-NativeArray<ushort>.Allocate
	|
	|-RVA: 0x1068010 Offset: 0x1066A10 VA: 0x181068010
	|-NativeArray<Keyframe>.Allocate
	|
	|-RVA: 0x1067BB0 Offset: 0x10665B0 VA: 0x181067BB0
	|-NativeArray<Matrix4x4>.Allocate
	|-NativeArray<Vertex>.Allocate
	|-NativeArray<float4x4>.Allocate
	|
	|-RVA: 0x1067CF0 Offset: 0x10666F0 VA: 0x181067CF0
	|-NativeArray<ModifiableContactPair>.Allocate
	|
	|-RVA: 0x1067C50 Offset: 0x1066650 VA: 0x181067C50
	|-NativeArray<RenderStateBlock>.Allocate
	|
	|-RVA: 0x1076C10 Offset: 0x1075610 VA: 0x181076C10
	|-NativeArray<Transform3x4>.Allocate
	|
	|-RVA: 0x1076890 Offset: 0x1075290 VA: 0x181076890
	|-NativeArray<UEncroachingSegment>.Allocate
	|
	|-RVA: 0x10766B0 Offset: 0x10750B0 VA: 0x1810766B0
	|-NativeArray<UEvent>.Allocate
	|
	|-RVA: 0x1076CB0 Offset: 0x10756B0 VA: 0x181076CB0
	|-NativeArray<UHull>.Allocate
	|
	|-RVA: 0x1076AD0 Offset: 0x10754D0 VA: 0x181076AD0
	|-NativeArray<ulong>.Allocate
	|
	|-RVA: 0x10767F0 Offset: 0x10751F0 VA: 0x1810767F0
	|-NativeArray<UStar>.Allocate
	|
	|-RVA: 0x1076B70 Offset: 0x1075570 VA: 0x181076B70
	|-NativeArray<UTriangle>.Allocate
	|
	|-RVA: 0x1076A30 Offset: 0x1075430 VA: 0x181076A30
	|-NativeArray<Vector3>.Allocate
	|-NativeArray<Vector3Int>.Allocate
	|-NativeArray<float3>.Allocate
	|-NativeArray<int3>.Allocate
	|
	|-RVA: 0x1076D50 Offset: 0x1075750 VA: 0x181076D50
	|-NativeArray<VisibleLight>.Allocate
	|
	|-RVA: 0x1076750 Offset: 0x1075150 VA: 0x181076750
	|-NativeArray<VisibleReflectionProbe>.Allocate
	|
	|-RVA: 0x1076930 Offset: 0x1075330 VA: 0x181076930
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Allocate
	|
	|-RVA: 0x1082670 Offset: 0x1081070 VA: 0x181082670
	|-NativeArray<LightUtility.LightMeshVertex>.Allocate
	|
	|-RVA: 0x10825D0 Offset: 0x1080FD0 VA: 0x1810825D0
	|-NativeArray<ShaderInput.LightData>.Allocate
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1067830 Offset: 0x1066230 VA: 0x181067830
	|-NativeArray<AttachmentDescriptor>.get_Length
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Length
	|-NativeArray<bool>.get_Length
	|-NativeArray<BoundingSphere>.get_Length
	|-NativeArray<byte>.get_Length
	|-NativeArray<Color>.get_Length
	|-NativeArray<Color32>.get_Length
	|-NativeArray<ContactPairHeader>.get_Length
	|-NativeArray<ConvertMeshJobData>.get_Length
	|-NativeArray<CopyClosingMeshJobData>.get_Length
	|-NativeArray<CullingSplit>.get_Length
	|-NativeArray<DecalEntity>.get_Length
	|-NativeArray<DecalSubDrawCall>.get_Length
	|-NativeArray<DrawBufferRange>.get_Length
	|-NativeArray<GfxUpdateBufferRange>.get_Length
	|-NativeArray<InclusiveRange>.get_Length
	|-NativeArray<short>.get_Length
	|-NativeArray<int>.get_Length
	|-NativeArray<Int32Enum>.get_Length
	|-NativeArray<JobHandle>.get_Length
	|-NativeArray<Keyframe>.get_Length
	|-NativeArray<LightDataGI>.get_Length
	|-NativeArray<Matrix4x4>.get_Length
	|-NativeArray<ModifiableContactPair>.get_Length
	|-NativeArray<NudgeJobData>.get_Length
	|-NativeArray<Plane>.get_Length
	|-NativeArray<Quaternion>.get_Length
	|-NativeArray<RenderStateBlock>.get_Length
	|-NativeArray<ShaderTagId>.get_Length
	|-NativeArray<float>.get_Length
	|-NativeArray<TileData>.get_Length
	|-NativeArray<Transform3x4>.get_Length
	|-NativeArray<UEncroachingSegment>.get_Length
	|-NativeArray<UEvent>.get_Length
	|-NativeArray<UHull>.get_Length
	|-NativeArray<ushort>.get_Length
	|-NativeArray<uint>.get_Length
	|-NativeArray<ulong>.get_Length
	|-NativeArray<UStar>.get_Length
	|-NativeArray<UTriangle>.get_Length
	|-NativeArray<Vector2>.get_Length
	|-NativeArray<Vector3>.get_Length
	|-NativeArray<Vector3Int>.get_Length
	|-NativeArray<Vector4>.get_Length
	|-NativeArray<Vertex>.get_Length
	|-NativeArray<VisibleLight>.get_Length
	|-NativeArray<VisibleReflectionProbe>.get_Length
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Length
	|-NativeArray<double2>.get_Length
	|-NativeArray<float2>.get_Length
	|-NativeArray<float3>.get_Length
	|-NativeArray<float4>.get_Length
	|-NativeArray<float4x4>.get_Length
	|-NativeArray<int2>.get_Length
	|-NativeArray<int3>.get_Length
	|-NativeArray<int4>.get_Length
	|-NativeArray<quaternion>.get_Length
	|-NativeArray<LightUtility.LightMeshVertex>.get_Length
	|-NativeArray<ProbeBrickIndex.Brick>.get_Length
	|-NativeArray<ShaderInput.LightData>.get_Length
	|-NativeArray<WordStorage.Entry>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676C0 Offset: 0x10660C0 VA: 0x1810676C0
	|-NativeArray<AttachmentDescriptor>.get_Item
	|-NativeArray<NudgeJobData>.get_Item
	|
	|-RVA: 0x10677B0 Offset: 0x10661B0 VA: 0x1810677B0
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Item
	|
	|-RVA: 0x1067770 Offset: 0x1066170 VA: 0x181067770
	|-NativeArray<bool>.get_Item
	|-NativeArray<byte>.get_Item
	|
	|-RVA: 0x1075C30 Offset: 0x1074630 VA: 0x181075C30
	|-NativeArray<BoundingSphere>.get_Item
	|-NativeArray<Color>.get_Item
	|-NativeArray<DrawBufferRange>.get_Item
	|-NativeArray<GfxUpdateBufferRange>.get_Item
	|-NativeArray<JobHandle>.get_Item
	|-NativeArray<Plane>.get_Item
	|-NativeArray<Quaternion>.get_Item
	|-NativeArray<Vector4>.get_Item
	|-NativeArray<double2>.get_Item
	|-NativeArray<float4>.get_Item
	|-NativeArray<int4>.get_Item
	|-NativeArray<quaternion>.get_Item
	|-NativeArray<ProbeBrickIndex.Brick>.get_Item
	|
	|-RVA: 0x1075F30 Offset: 0x1074930 VA: 0x181075F30
	|-NativeArray<Color32>.get_Item
	|-NativeArray<InclusiveRange>.get_Item
	|-NativeArray<int>.get_Item
	|-NativeArray<Int32Enum>.get_Item
	|-NativeArray<ShaderTagId>.get_Item
	|-NativeArray<uint>.get_Item
	|
	|-RVA: 0x10760B0 Offset: 0x1074AB0 VA: 0x1810760B0
	|-NativeArray<ContactPairHeader>.get_Item
	|
	|-RVA: 0x1075FD0 Offset: 0x10749D0 VA: 0x181075FD0
	|-NativeArray<ConvertMeshJobData>.get_Item
	|
	|-RVA: 0x1075F60 Offset: 0x1074960 VA: 0x181075F60
	|-NativeArray<CopyClosingMeshJobData>.get_Item
	|-NativeArray<Transform3x4>.get_Item
	|
	|-RVA: 0x1075E90 Offset: 0x1074890 VA: 0x181075E90
	|-NativeArray<CullingSplit>.get_Item
	|-NativeArray<LightDataGI>.get_Item
	|-NativeArray<TileData>.get_Item
	|
	|-RVA: 0x1075C80 Offset: 0x1074680 VA: 0x181075C80
	|-NativeArray<DecalEntity>.get_Item
	|-NativeArray<DecalSubDrawCall>.get_Item
	|-NativeArray<ulong>.get_Item
	|-NativeArray<int2>.get_Item
	|-NativeArray<WordStorage.Entry>.get_Item
	|
	|-RVA: 0x1075D30 Offset: 0x1074730 VA: 0x181075D30
	|-NativeArray<short>.get_Item
	|-NativeArray<ushort>.get_Item
	|
	|-RVA: 0x1075CC0 Offset: 0x10746C0 VA: 0x181075CC0
	|-NativeArray<Keyframe>.get_Item
	|
	|-RVA: 0x1075D70 Offset: 0x1074770 VA: 0x181075D70
	|-NativeArray<Matrix4x4>.get_Item
	|-NativeArray<Vertex>.get_Item
	|-NativeArray<float4x4>.get_Item
	|
	|-RVA: 0x1075DF0 Offset: 0x10747F0 VA: 0x181075DF0
	|-NativeArray<ModifiableContactPair>.get_Item
	|
	|-RVA: 0x1076120 Offset: 0x1074B20 VA: 0x181076120
	|-NativeArray<RenderStateBlock>.get_Item
	|
	|-RVA: 0x1082010 Offset: 0x1080A10 VA: 0x181082010
	|-NativeArray<float>.get_Item
	|
	|-RVA: 0x1081C40 Offset: 0x1080640 VA: 0x181081C40
	|-NativeArray<UEncroachingSegment>.get_Item
	|
	|-RVA: 0x1081BE0 Offset: 0x10805E0 VA: 0x181081BE0
	|-NativeArray<UEvent>.get_Item
	|-NativeArray<UStar>.get_Item
	|
	|-RVA: 0x1081F80 Offset: 0x1080980 VA: 0x181081F80
	|-NativeArray<UHull>.get_Item
	|
	|-RVA: 0x1081B20 Offset: 0x1080520 VA: 0x181081B20
	|-NativeArray<UTriangle>.get_Item
	|
	|-RVA: 0x1081BA0 Offset: 0x10805A0 VA: 0x181081BA0
	|-NativeArray<Vector2>.get_Item
	|-NativeArray<float2>.get_Item
	|
	|-RVA: 0x1081AC0 Offset: 0x10804C0 VA: 0x181081AC0
	|-NativeArray<Vector3>.get_Item
	|-NativeArray<Vector3Int>.get_Item
	|-NativeArray<float3>.get_Item
	|-NativeArray<int3>.get_Item
	|
	|-RVA: 0x1081CA0 Offset: 0x10806A0 VA: 0x181081CA0
	|-NativeArray<VisibleLight>.get_Item
	|
	|-RVA: 0x1081EB0 Offset: 0x10808B0 VA: 0x181081EB0
	|-NativeArray<VisibleReflectionProbe>.get_Item
	|
	|-RVA: 0x1081D50 Offset: 0x1080750 VA: 0x181081D50
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Item
	|
	|-RVA: 0x1084FB0 Offset: 0x10839B0 VA: 0x181084FB0
	|-NativeArray<LightUtility.LightMeshVertex>.get_Item
	|
	|-RVA: 0x1085020 Offset: 0x1083A20 VA: 0x181085020
	|-NativeArray<ShaderInput.LightData>.get_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10678D0 Offset: 0x10662D0 VA: 0x1810678D0
	|-NativeArray<AttachmentDescriptor>.set_Item
	|-NativeArray<NudgeJobData>.set_Item
	|
	|-RVA: 0x1067960 Offset: 0x1066360 VA: 0x181067960
	|-NativeArray<BatchCullingOutputDrawCommands>.set_Item
	|
	|-RVA: 0x1067890 Offset: 0x1066290 VA: 0x181067890
	|-NativeArray<bool>.set_Item
	|-NativeArray<byte>.set_Item
	|
	|-RVA: 0x1076360 Offset: 0x1074D60 VA: 0x181076360
	|-NativeArray<BoundingSphere>.set_Item
	|-NativeArray<Color>.set_Item
	|-NativeArray<DrawBufferRange>.set_Item
	|-NativeArray<GfxUpdateBufferRange>.set_Item
	|-NativeArray<JobHandle>.set_Item
	|-NativeArray<Plane>.set_Item
	|-NativeArray<Quaternion>.set_Item
	|-NativeArray<Vector4>.set_Item
	|-NativeArray<float4>.set_Item
	|-NativeArray<int4>.set_Item
	|-NativeArray<quaternion>.set_Item
	|-NativeArray<ProbeBrickIndex.Brick>.set_Item
	|
	|-RVA: 0x1076320 Offset: 0x1074D20 VA: 0x181076320
	|-NativeArray<Color32>.set_Item
	|-NativeArray<InclusiveRange>.set_Item
	|-NativeArray<int>.set_Item
	|-NativeArray<Int32Enum>.set_Item
	|-NativeArray<ShaderTagId>.set_Item
	|-NativeArray<uint>.set_Item
	|
	|-RVA: 0x10763B0 Offset: 0x1074DB0 VA: 0x1810763B0
	|-NativeArray<ContactPairHeader>.set_Item
	|
	|-RVA: 0x10761D0 Offset: 0x1074BD0 VA: 0x1810761D0
	|-NativeArray<ConvertMeshJobData>.set_Item
	|
	|-RVA: 0x10764D0 Offset: 0x1074ED0 VA: 0x1810764D0
	|-NativeArray<CopyClosingMeshJobData>.set_Item
	|-NativeArray<Transform3x4>.set_Item
	|
	|-RVA: 0x1076450 Offset: 0x1074E50 VA: 0x181076450
	|-NativeArray<CullingSplit>.set_Item
	|-NativeArray<LightDataGI>.set_Item
	|-NativeArray<TileData>.set_Item
	|
	|-RVA: 0x1076410 Offset: 0x1074E10 VA: 0x181076410
	|-NativeArray<DecalEntity>.set_Item
	|-NativeArray<DecalSubDrawCall>.set_Item
	|-NativeArray<ulong>.set_Item
	|-NativeArray<int2>.set_Item
	|-NativeArray<WordStorage.Entry>.set_Item
	|
	|-RVA: 0x1076280 Offset: 0x1074C80 VA: 0x181076280
	|-NativeArray<short>.set_Item
	|-NativeArray<ushort>.set_Item
	|
	|-RVA: 0x10762C0 Offset: 0x1074CC0 VA: 0x1810762C0
	|-NativeArray<Keyframe>.set_Item
	|
	|-RVA: 0x10765C0 Offset: 0x1074FC0 VA: 0x1810765C0
	|-NativeArray<Matrix4x4>.set_Item
	|-NativeArray<Vertex>.set_Item
	|-NativeArray<float4x4>.set_Item
	|
	|-RVA: 0x1076630 Offset: 0x1075030 VA: 0x181076630
	|-NativeArray<ModifiableContactPair>.set_Item
	|
	|-RVA: 0x1076530 Offset: 0x1074F30 VA: 0x181076530
	|-NativeArray<RenderStateBlock>.set_Item
	|
	|-RVA: 0x1082220 Offset: 0x1080C20 VA: 0x181082220
	|-NativeArray<float>.set_Item
	|
	|-RVA: 0x1082460 Offset: 0x1080E60 VA: 0x181082460
	|-NativeArray<UEncroachingSegment>.set_Item
	|
	|-RVA: 0x1082510 Offset: 0x1080F10 VA: 0x181082510
	|-NativeArray<UEvent>.set_Item
	|-NativeArray<UStar>.set_Item
	|
	|-RVA: 0x1082560 Offset: 0x1080F60 VA: 0x181082560
	|-NativeArray<UHull>.set_Item
	|
	|-RVA: 0x10824B0 Offset: 0x1080EB0 VA: 0x1810824B0
	|-NativeArray<UTriangle>.set_Item
	|
	|-RVA: 0x1082180 Offset: 0x1080B80 VA: 0x181082180
	|-NativeArray<Vector2>.set_Item
	|-NativeArray<float2>.set_Item
	|
	|-RVA: 0x10821D0 Offset: 0x1080BD0 VA: 0x1810821D0
	|-NativeArray<Vector3>.set_Item
	|-NativeArray<Vector3Int>.set_Item
	|-NativeArray<float3>.set_Item
	|-NativeArray<int3>.set_Item
	|
	|-RVA: 0x10823D0 Offset: 0x1080DD0 VA: 0x1810823D0
	|-NativeArray<VisibleLight>.set_Item
	|
	|-RVA: 0x10820E0 Offset: 0x1080AE0 VA: 0x1810820E0
	|-NativeArray<VisibleReflectionProbe>.set_Item
	|
	|-RVA: 0x1082260 Offset: 0x1080C60 VA: 0x181082260
	|-NativeArray<__Il2CppFullySharedGenericStructType>.set_Item
	|
	|-RVA: 0x1082370 Offset: 0x1080D70 VA: 0x181082370
	|-NativeArray<double2>.set_Item
	|
	|-RVA: 0x1085120 Offset: 0x1083B20 VA: 0x181085120
	|-NativeArray<LightUtility.LightMeshVertex>.set_Item
	|
	|-RVA: 0x10850B0 Offset: 0x1083AB0 VA: 0x1810850B0
	|-NativeArray<ShaderInput.LightData>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-NativeArray<AttachmentDescriptor>.get_IsCreated
	|-NativeArray<BatchCullingOutputDrawCommands>.get_IsCreated
	|-NativeArray<bool>.get_IsCreated
	|-NativeArray<BoundingSphere>.get_IsCreated
	|-NativeArray<byte>.get_IsCreated
	|-NativeArray<Color>.get_IsCreated
	|-NativeArray<Color32>.get_IsCreated
	|-NativeArray<ContactPairHeader>.get_IsCreated
	|-NativeArray<ConvertMeshJobData>.get_IsCreated
	|-NativeArray<CopyClosingMeshJobData>.get_IsCreated
	|-NativeArray<CullingSplit>.get_IsCreated
	|-NativeArray<DecalEntity>.get_IsCreated
	|-NativeArray<DecalSubDrawCall>.get_IsCreated
	|-NativeArray<DrawBufferRange>.get_IsCreated
	|-NativeArray<GfxUpdateBufferRange>.get_IsCreated
	|-NativeArray<InclusiveRange>.get_IsCreated
	|-NativeArray<short>.get_IsCreated
	|-NativeArray<int>.get_IsCreated
	|-NativeArray<Int32Enum>.get_IsCreated
	|-NativeArray<JobHandle>.get_IsCreated
	|-NativeArray<Keyframe>.get_IsCreated
	|-NativeArray<LightDataGI>.get_IsCreated
	|-NativeArray<Matrix4x4>.get_IsCreated
	|-NativeArray<ModifiableContactPair>.get_IsCreated
	|-NativeArray<NudgeJobData>.get_IsCreated
	|-NativeArray<Plane>.get_IsCreated
	|-NativeArray<Quaternion>.get_IsCreated
	|-NativeArray<RenderStateBlock>.get_IsCreated
	|-NativeArray<ShaderTagId>.get_IsCreated
	|-NativeArray<float>.get_IsCreated
	|-NativeArray<TileData>.get_IsCreated
	|-NativeArray<Transform3x4>.get_IsCreated
	|-NativeArray<UEncroachingSegment>.get_IsCreated
	|-NativeArray<UEvent>.get_IsCreated
	|-NativeArray<UHull>.get_IsCreated
	|-NativeArray<ushort>.get_IsCreated
	|-NativeArray<uint>.get_IsCreated
	|-NativeArray<ulong>.get_IsCreated
	|-NativeArray<UStar>.get_IsCreated
	|-NativeArray<UTriangle>.get_IsCreated
	|-NativeArray<Vector2>.get_IsCreated
	|-NativeArray<Vector3>.get_IsCreated
	|-NativeArray<Vector3Int>.get_IsCreated
	|-NativeArray<Vector4>.get_IsCreated
	|-NativeArray<Vertex>.get_IsCreated
	|-NativeArray<VisibleLight>.get_IsCreated
	|-NativeArray<VisibleReflectionProbe>.get_IsCreated
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_IsCreated
	|-NativeArray<double2>.get_IsCreated
	|-NativeArray<float2>.get_IsCreated
	|-NativeArray<float3>.get_IsCreated
	|-NativeArray<float4>.get_IsCreated
	|-NativeArray<float4x4>.get_IsCreated
	|-NativeArray<int2>.get_IsCreated
	|-NativeArray<int3>.get_IsCreated
	|-NativeArray<int4>.get_IsCreated
	|-NativeArray<quaternion>.get_IsCreated
	|-NativeArray<LightUtility.LightMeshVertex>.get_IsCreated
	|-NativeArray<ProbeBrickIndex.Brick>.get_IsCreated
	|-NativeArray<ShaderInput.LightData>.get_IsCreated
	|-NativeArray<WordStorage.Entry>.get_IsCreated
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1065D70 Offset: 0x1064770 VA: 0x181065D70
	|-NativeArray<AttachmentDescriptor>.Dispose
	|-NativeArray<BatchCullingOutputDrawCommands>.Dispose
	|-NativeArray<bool>.Dispose
	|-NativeArray<BoundingSphere>.Dispose
	|-NativeArray<byte>.Dispose
	|-NativeArray<Color>.Dispose
	|-NativeArray<Color32>.Dispose
	|-NativeArray<ContactPairHeader>.Dispose
	|-NativeArray<ConvertMeshJobData>.Dispose
	|-NativeArray<CopyClosingMeshJobData>.Dispose
	|-NativeArray<CullingSplit>.Dispose
	|-NativeArray<DecalEntity>.Dispose
	|-NativeArray<DecalSubDrawCall>.Dispose
	|-NativeArray<DrawBufferRange>.Dispose
	|-NativeArray<GfxUpdateBufferRange>.Dispose
	|-NativeArray<InclusiveRange>.Dispose
	|-NativeArray<short>.Dispose
	|-NativeArray<int>.Dispose
	|-NativeArray<Int32Enum>.Dispose
	|-NativeArray<JobHandle>.Dispose
	|-NativeArray<Keyframe>.Dispose
	|-NativeArray<LightDataGI>.Dispose
	|-NativeArray<Matrix4x4>.Dispose
	|-NativeArray<ModifiableContactPair>.Dispose
	|-NativeArray<NudgeJobData>.Dispose
	|-NativeArray<Plane>.Dispose
	|-NativeArray<Quaternion>.Dispose
	|-NativeArray<RenderStateBlock>.Dispose
	|-NativeArray<ShaderTagId>.Dispose
	|-NativeArray<float>.Dispose
	|-NativeArray<TileData>.Dispose
	|-NativeArray<Transform3x4>.Dispose
	|-NativeArray<UEncroachingSegment>.Dispose
	|-NativeArray<UEvent>.Dispose
	|-NativeArray<UHull>.Dispose
	|-NativeArray<ushort>.Dispose
	|-NativeArray<uint>.Dispose
	|-NativeArray<ulong>.Dispose
	|-NativeArray<UStar>.Dispose
	|-NativeArray<UTriangle>.Dispose
	|-NativeArray<Vector2>.Dispose
	|-NativeArray<Vector3>.Dispose
	|-NativeArray<Vector3Int>.Dispose
	|-NativeArray<Vector4>.Dispose
	|-NativeArray<Vertex>.Dispose
	|-NativeArray<VisibleLight>.Dispose
	|-NativeArray<VisibleReflectionProbe>.Dispose
	|-NativeArray<double2>.Dispose
	|-NativeArray<float2>.Dispose
	|-NativeArray<float3>.Dispose
	|-NativeArray<float4>.Dispose
	|-NativeArray<float4x4>.Dispose
	|-NativeArray<int2>.Dispose
	|-NativeArray<int3>.Dispose
	|-NativeArray<int4>.Dispose
	|-NativeArray<quaternion>.Dispose
	|-NativeArray<LightUtility.LightMeshVertex>.Dispose
	|-NativeArray<ProbeBrickIndex.Brick>.Dispose
	|-NativeArray<ShaderInput.LightData>.Dispose
	|-NativeArray<WordStorage.Entry>.Dispose
	|
	|-RVA: 0x107BA90 Offset: 0x107A490 VA: 0x18107BA90
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1065E10 Offset: 0x1064810 VA: 0x181065E10
	|-NativeArray<AttachmentDescriptor>.Dispose
	|
	|-RVA: 0x1065F30 Offset: 0x1064930 VA: 0x181065F30
	|-NativeArray<BatchCullingOutputDrawCommands>.Dispose
	|
	|-RVA: 0x1066050 Offset: 0x1064A50 VA: 0x181066050
	|-NativeArray<bool>.Dispose
	|
	|-RVA: 0x106FC00 Offset: 0x106E600 VA: 0x18106FC00
	|-NativeArray<BoundingSphere>.Dispose
	|
	|-RVA: 0x10701A0 Offset: 0x106EBA0 VA: 0x1810701A0
	|-NativeArray<byte>.Dispose
	|
	|-RVA: 0x1070500 Offset: 0x106EF00 VA: 0x181070500
	|-NativeArray<Color>.Dispose
	|
	|-RVA: 0x106F540 Offset: 0x106DF40 VA: 0x18106F540
	|-NativeArray<Color32>.Dispose
	|
	|-RVA: 0x106F300 Offset: 0x106DD00 VA: 0x18106F300
	|-NativeArray<ContactPairHeader>.Dispose
	|
	|-RVA: 0x106F660 Offset: 0x106E060 VA: 0x18106F660
	|-NativeArray<ConvertMeshJobData>.Dispose
	|
	|-RVA: 0x106ED60 Offset: 0x106D760 VA: 0x18106ED60
	|-NativeArray<CopyClosingMeshJobData>.Dispose
	|
	|-RVA: 0x106F1E0 Offset: 0x106DBE0 VA: 0x18106F1E0
	|-NativeArray<CullingSplit>.Dispose
	|
	|-RVA: 0x106FF60 Offset: 0x106E960 VA: 0x18106FF60
	|-NativeArray<DecalEntity>.Dispose
	|
	|-RVA: 0x106F9C0 Offset: 0x106E3C0 VA: 0x18106F9C0
	|-NativeArray<DecalSubDrawCall>.Dispose
	|
	|-RVA: 0x106F8A0 Offset: 0x106E2A0 VA: 0x18106F8A0
	|-NativeArray<DrawBufferRange>.Dispose
	|
	|-RVA: 0x106FAE0 Offset: 0x106E4E0 VA: 0x18106FAE0
	|-NativeArray<GfxUpdateBufferRange>.Dispose
	|
	|-RVA: 0x106F0C0 Offset: 0x106DAC0 VA: 0x18106F0C0
	|-NativeArray<InclusiveRange>.Dispose
	|
	|-RVA: 0x106EC40 Offset: 0x106D640 VA: 0x18106EC40
	|-NativeArray<short>.Dispose
	|
	|-RVA: 0x106F780 Offset: 0x106E180 VA: 0x18106F780
	|-NativeArray<int>.Dispose
	|
	|-RVA: 0x106EE80 Offset: 0x106D880 VA: 0x18106EE80
	|-NativeArray<Int32Enum>.Dispose
	|
	|-RVA: 0x1070620 Offset: 0x106F020 VA: 0x181070620
	|-NativeArray<JobHandle>.Dispose
	|
	|-RVA: 0x10702C0 Offset: 0x106ECC0 VA: 0x1810702C0
	|-NativeArray<Keyframe>.Dispose
	|
	|-RVA: 0x1070080 Offset: 0x106EA80 VA: 0x181070080
	|-NativeArray<LightDataGI>.Dispose
	|
	|-RVA: 0x106F420 Offset: 0x106DE20 VA: 0x18106F420
	|-NativeArray<Matrix4x4>.Dispose
	|
	|-RVA: 0x106EFA0 Offset: 0x106D9A0 VA: 0x18106EFA0
	|-NativeArray<ModifiableContactPair>.Dispose
	|
	|-RVA: 0x106FD20 Offset: 0x106E720 VA: 0x18106FD20
	|-NativeArray<NudgeJobData>.Dispose
	|
	|-RVA: 0x106FE40 Offset: 0x106E840 VA: 0x18106FE40
	|-NativeArray<Plane>.Dispose
	|
	|-RVA: 0x10703E0 Offset: 0x106EDE0 VA: 0x1810703E0
	|-NativeArray<Quaternion>.Dispose
	|
	|-RVA: 0x106EB20 Offset: 0x106D520 VA: 0x18106EB20
	|-NativeArray<RenderStateBlock>.Dispose
	|
	|-RVA: 0x107B730 Offset: 0x107A130 VA: 0x18107B730
	|-NativeArray<ShaderTagId>.Dispose
	|
	|-RVA: 0x107D220 Offset: 0x107BC20 VA: 0x18107D220
	|-NativeArray<float>.Dispose
	|
	|-RVA: 0x107BC80 Offset: 0x107A680 VA: 0x18107BC80
	|-NativeArray<TileData>.Dispose
	|
	|-RVA: 0x107C220 Offset: 0x107AC20 VA: 0x18107C220
	|-NativeArray<Transform3x4>.Dispose
	|
	|-RVA: 0x107CFE0 Offset: 0x107B9E0 VA: 0x18107CFE0
	|-NativeArray<UEncroachingSegment>.Dispose
	|
	|-RVA: 0x107C100 Offset: 0x107AB00 VA: 0x18107C100
	|-NativeArray<UEvent>.Dispose
	|
	|-RVA: 0x107B850 Offset: 0x107A250 VA: 0x18107B850
	|-NativeArray<UHull>.Dispose
	|
	|-RVA: 0x107CEC0 Offset: 0x107B8C0 VA: 0x18107CEC0
	|-NativeArray<ushort>.Dispose
	|
	|-RVA: 0x107C6A0 Offset: 0x107B0A0 VA: 0x18107C6A0
	|-NativeArray<uint>.Dispose
	|
	|-RVA: 0x107C580 Offset: 0x107AF80 VA: 0x18107C580
	|-NativeArray<ulong>.Dispose
	|
	|-RVA: 0x107B970 Offset: 0x107A370 VA: 0x18107B970
	|-NativeArray<UStar>.Dispose
	|
	|-RVA: 0x107C7C0 Offset: 0x107B1C0 VA: 0x18107C7C0
	|-NativeArray<UTriangle>.Dispose
	|
	|-RVA: 0x107BB60 Offset: 0x107A560 VA: 0x18107BB60
	|-NativeArray<Vector2>.Dispose
	|
	|-RVA: 0x107BEC0 Offset: 0x107A8C0 VA: 0x18107BEC0
	|-NativeArray<Vector3>.Dispose
	|
	|-RVA: 0x107D340 Offset: 0x107BD40 VA: 0x18107D340
	|-NativeArray<Vector3Int>.Dispose
	|
	|-RVA: 0x107D100 Offset: 0x107BB00 VA: 0x18107D100
	|-NativeArray<Vector4>.Dispose
	|
	|-RVA: 0x107BDA0 Offset: 0x107A7A0 VA: 0x18107BDA0
	|-NativeArray<Vertex>.Dispose
	|
	|-RVA: 0x107C460 Offset: 0x107AE60 VA: 0x18107C460
	|-NativeArray<VisibleLight>.Dispose
	|
	|-RVA: 0x107BFE0 Offset: 0x107A9E0 VA: 0x18107BFE0
	|-NativeArray<VisibleReflectionProbe>.Dispose
	|
	|-RVA: 0x107CA00 Offset: 0x107B400 VA: 0x18107CA00
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Dispose
	|
	|-RVA: 0x107C8E0 Offset: 0x107B2E0 VA: 0x18107C8E0
	|-NativeArray<double2>.Dispose
	|
	|-RVA: 0x107CC80 Offset: 0x107B680 VA: 0x18107CC80
	|-NativeArray<float2>.Dispose
	|
	|-RVA: 0x107C340 Offset: 0x107AD40 VA: 0x18107C340
	|-NativeArray<float3>.Dispose
	|
	|-RVA: 0x107CB60 Offset: 0x107B560 VA: 0x18107CB60
	|-NativeArray<float4>.Dispose
	|
	|-RVA: 0x107CDA0 Offset: 0x107B7A0 VA: 0x18107CDA0
	|-NativeArray<float4x4>.Dispose
	|
	|-RVA: 0x1083C80 Offset: 0x1082680 VA: 0x181083C80
	|-NativeArray<int2>.Dispose
	|
	|-RVA: 0x1084100 Offset: 0x1082B00 VA: 0x181084100
	|-NativeArray<int3>.Dispose
	|
	|-RVA: 0x1083A40 Offset: 0x1082440 VA: 0x181083A40
	|-NativeArray<int4>.Dispose
	|
	|-RVA: 0x1083FE0 Offset: 0x10829E0 VA: 0x181083FE0
	|-NativeArray<quaternion>.Dispose
	|
	|-RVA: 0x1083920 Offset: 0x1082320 VA: 0x181083920
	|-NativeArray<LightUtility.LightMeshVertex>.Dispose
	|
	|-RVA: 0x1083B60 Offset: 0x1082560 VA: 0x181083B60
	|-NativeArray<ProbeBrickIndex.Brick>.Dispose
	|
	|-RVA: 0x1083EC0 Offset: 0x10828C0 VA: 0x181083EC0
	|-NativeArray<ShaderInput.LightData>.Dispose
	|
	|-RVA: 0x1083DA0 Offset: 0x10827A0 VA: 0x181083DA0
	|-NativeArray<WordStorage.Entry>.Dispose
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void CopyFrom(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1064410 Offset: 0x1062E10 VA: 0x181064410
	|-NativeArray<AttachmentDescriptor>.CopyFrom
	|-NativeArray<NudgeJobData>.CopyFrom
	|
	|-RVA: 0x10642B0 Offset: 0x1062CB0 VA: 0x1810642B0
	|-NativeArray<BatchCullingOutputDrawCommands>.CopyFrom
	|
	|-RVA: 0x10643C0 Offset: 0x1062DC0 VA: 0x1810643C0
	|-NativeArray<bool>.CopyFrom
	|-NativeArray<byte>.CopyFrom
	|
	|-RVA: 0x1068350 Offset: 0x1066D50 VA: 0x181068350
	|-NativeArray<BoundingSphere>.CopyFrom
	|-NativeArray<Color>.CopyFrom
	|-NativeArray<DrawBufferRange>.CopyFrom
	|-NativeArray<GfxUpdateBufferRange>.CopyFrom
	|-NativeArray<JobHandle>.CopyFrom
	|-NativeArray<Plane>.CopyFrom
	|-NativeArray<Quaternion>.CopyFrom
	|-NativeArray<Vector4>.CopyFrom
	|-NativeArray<double2>.CopyFrom
	|-NativeArray<float4>.CopyFrom
	|-NativeArray<int4>.CopyFrom
	|-NativeArray<quaternion>.CopyFrom
	|-NativeArray<ProbeBrickIndex.Brick>.CopyFrom
	|
	|-RVA: 0x1068630 Offset: 0x1067030 VA: 0x181068630
	|-NativeArray<Color32>.CopyFrom
	|-NativeArray<InclusiveRange>.CopyFrom
	|-NativeArray<int>.CopyFrom
	|-NativeArray<Int32Enum>.CopyFrom
	|-NativeArray<ShaderTagId>.CopyFrom
	|-NativeArray<float>.CopyFrom
	|-NativeArray<uint>.CopyFrom
	|
	|-RVA: 0x10688A0 Offset: 0x10672A0 VA: 0x1810688A0
	|-NativeArray<ContactPairHeader>.CopyFrom
	|
	|-RVA: 0x1068850 Offset: 0x1067250 VA: 0x181068850
	|-NativeArray<ConvertMeshJobData>.CopyFrom
	|
	|-RVA: 0x1068BD0 Offset: 0x10675D0 VA: 0x181068BD0
	|-NativeArray<CopyClosingMeshJobData>.CopyFrom
	|-NativeArray<Transform3x4>.CopyFrom
	|
	|-RVA: 0x1068C20 Offset: 0x1067620 VA: 0x181068C20
	|-NativeArray<CullingSplit>.CopyFrom
	|-NativeArray<LightDataGI>.CopyFrom
	|-NativeArray<TileData>.CopyFrom
	|
	|-RVA: 0x10688F0 Offset: 0x10672F0 VA: 0x1810688F0
	|-NativeArray<DecalEntity>.CopyFrom
	|-NativeArray<DecalSubDrawCall>.CopyFrom
	|-NativeArray<ulong>.CopyFrom
	|-NativeArray<Vector2>.CopyFrom
	|-NativeArray<float2>.CopyFrom
	|-NativeArray<int2>.CopyFrom
	|-NativeArray<WordStorage.Entry>.CopyFrom
	|
	|-RVA: 0x1068740 Offset: 0x1067140 VA: 0x181068740
	|-NativeArray<short>.CopyFrom
	|-NativeArray<ushort>.CopyFrom
	|
	|-RVA: 0x1068F00 Offset: 0x1067900 VA: 0x181068F00
	|-NativeArray<Keyframe>.CopyFrom
	|
	|-RVA: 0x1068C70 Offset: 0x1067670 VA: 0x181068C70
	|-NativeArray<Matrix4x4>.CopyFrom
	|-NativeArray<Vertex>.CopyFrom
	|-NativeArray<float4x4>.CopyFrom
	|
	|-RVA: 0x10683A0 Offset: 0x1066DA0 VA: 0x1810683A0
	|-NativeArray<ModifiableContactPair>.CopyFrom
	|
	|-RVA: 0x1068B80 Offset: 0x1067580 VA: 0x181068B80
	|-NativeArray<RenderStateBlock>.CopyFrom
	|
	|-RVA: 0x1077520 Offset: 0x1075F20 VA: 0x181077520
	|-NativeArray<UEncroachingSegment>.CopyFrom
	|
	|-RVA: 0x1077430 Offset: 0x1075E30 VA: 0x181077430
	|-NativeArray<UEvent>.CopyFrom
	|-NativeArray<UStar>.CopyFrom
	|
	|-RVA: 0x10774D0 Offset: 0x1075ED0 VA: 0x1810774D0
	|-NativeArray<UHull>.CopyFrom
	|
	|-RVA: 0x1077630 Offset: 0x1076030 VA: 0x181077630
	|-NativeArray<UTriangle>.CopyFrom
	|
	|-RVA: 0x10770F0 Offset: 0x1075AF0 VA: 0x1810770F0
	|-NativeArray<Vector3>.CopyFrom
	|-NativeArray<Vector3Int>.CopyFrom
	|-NativeArray<float3>.CopyFrom
	|-NativeArray<int3>.CopyFrom
	|
	|-RVA: 0x1077200 Offset: 0x1075C00 VA: 0x181077200
	|-NativeArray<VisibleLight>.CopyFrom
	|
	|-RVA: 0x1077480 Offset: 0x1075E80 VA: 0x181077480
	|-NativeArray<VisibleReflectionProbe>.CopyFrom
	|
	|-RVA: 0x10773A0 Offset: 0x1075DA0 VA: 0x1810773A0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopyFrom
	|
	|-RVA: 0x10828E0 Offset: 0x10812E0 VA: 0x1810828E0
	|-NativeArray<LightUtility.LightMeshVertex>.CopyFrom
	|
	|-RVA: 0x1082710 Offset: 0x1081110 VA: 0x181082710
	|-NativeArray<ShaderInput.LightData>.CopyFrom
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void CopyFrom(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1064300 Offset: 0x1062D00 VA: 0x181064300
	|-NativeArray<AttachmentDescriptor>.CopyFrom
	|-NativeArray<NudgeJobData>.CopyFrom
	|
	|-RVA: 0x1064130 Offset: 0x1062B30 VA: 0x181064130
	|-NativeArray<BatchCullingOutputDrawCommands>.CopyFrom
	|
	|-RVA: 0x10641F0 Offset: 0x1062BF0 VA: 0x1810641F0
	|-NativeArray<bool>.CopyFrom
	|-NativeArray<byte>.CopyFrom
	|
	|-RVA: 0x10683F0 Offset: 0x1066DF0 VA: 0x1810683F0
	|-NativeArray<BoundingSphere>.CopyFrom
	|-NativeArray<Color>.CopyFrom
	|-NativeArray<DrawBufferRange>.CopyFrom
	|-NativeArray<GfxUpdateBufferRange>.CopyFrom
	|-NativeArray<JobHandle>.CopyFrom
	|-NativeArray<Plane>.CopyFrom
	|-NativeArray<Quaternion>.CopyFrom
	|-NativeArray<Vector4>.CopyFrom
	|-NativeArray<double2>.CopyFrom
	|-NativeArray<float4>.CopyFrom
	|-NativeArray<int4>.CopyFrom
	|-NativeArray<quaternion>.CopyFrom
	|-NativeArray<ProbeBrickIndex.Brick>.CopyFrom
	|
	|-RVA: 0x1068570 Offset: 0x1066F70 VA: 0x181068570
	|-NativeArray<Color32>.CopyFrom
	|-NativeArray<InclusiveRange>.CopyFrom
	|-NativeArray<int>.CopyFrom
	|-NativeArray<Int32Enum>.CopyFrom
	|-NativeArray<ShaderTagId>.CopyFrom
	|-NativeArray<float>.CopyFrom
	|-NativeArray<uint>.CopyFrom
	|
	|-RVA: 0x1068940 Offset: 0x1067340 VA: 0x181068940
	|-NativeArray<ContactPairHeader>.CopyFrom
	|
	|-RVA: 0x1068D80 Offset: 0x1067780 VA: 0x181068D80
	|-NativeArray<ConvertMeshJobData>.CopyFrom
	|
	|-RVA: 0x1068AC0 Offset: 0x10674C0 VA: 0x181068AC0
	|-NativeArray<CopyClosingMeshJobData>.CopyFrom
	|-NativeArray<Transform3x4>.CopyFrom
	|
	|-RVA: 0x10684B0 Offset: 0x1066EB0 VA: 0x1810684B0
	|-NativeArray<CullingSplit>.CopyFrom
	|-NativeArray<LightDataGI>.CopyFrom
	|-NativeArray<TileData>.CopyFrom
	|
	|-RVA: 0x1068290 Offset: 0x1066C90 VA: 0x181068290
	|-NativeArray<DecalEntity>.CopyFrom
	|-NativeArray<DecalSubDrawCall>.CopyFrom
	|-NativeArray<ulong>.CopyFrom
	|-NativeArray<Vector2>.CopyFrom
	|-NativeArray<float2>.CopyFrom
	|-NativeArray<int2>.CopyFrom
	|-NativeArray<WordStorage.Entry>.CopyFrom
	|
	|-RVA: 0x1068E40 Offset: 0x1067840 VA: 0x181068E40
	|-NativeArray<short>.CopyFrom
	|-NativeArray<ushort>.CopyFrom
	|
	|-RVA: 0x1068790 Offset: 0x1067190 VA: 0x181068790
	|-NativeArray<Keyframe>.CopyFrom
	|
	|-RVA: 0x1068A00 Offset: 0x1067400 VA: 0x181068A00
	|-NativeArray<Matrix4x4>.CopyFrom
	|-NativeArray<Vertex>.CopyFrom
	|-NativeArray<float4x4>.CopyFrom
	|
	|-RVA: 0x1068CC0 Offset: 0x10676C0 VA: 0x181068CC0
	|-NativeArray<ModifiableContactPair>.CopyFrom
	|
	|-RVA: 0x1068680 Offset: 0x1067080 VA: 0x181068680
	|-NativeArray<RenderStateBlock>.CopyFrom
	|
	|-RVA: 0x1076EB0 Offset: 0x10758B0 VA: 0x181076EB0
	|-NativeArray<UEncroachingSegment>.CopyFrom
	|
	|-RVA: 0x10772E0 Offset: 0x1075CE0 VA: 0x1810772E0
	|-NativeArray<UEvent>.CopyFrom
	|-NativeArray<UStar>.CopyFrom
	|
	|-RVA: 0x1077140 Offset: 0x1075B40 VA: 0x181077140
	|-NativeArray<UHull>.CopyFrom
	|
	|-RVA: 0x1077030 Offset: 0x1075A30 VA: 0x181077030
	|-NativeArray<UTriangle>.CopyFrom
	|
	|-RVA: 0x1076F70 Offset: 0x1075970 VA: 0x181076F70
	|-NativeArray<Vector3>.CopyFrom
	|-NativeArray<Vector3Int>.CopyFrom
	|-NativeArray<float3>.CopyFrom
	|-NativeArray<int3>.CopyFrom
	|
	|-RVA: 0x1076DF0 Offset: 0x10757F0 VA: 0x181076DF0
	|-NativeArray<VisibleLight>.CopyFrom
	|
	|-RVA: 0x1077570 Offset: 0x1075F70 VA: 0x181077570
	|-NativeArray<VisibleReflectionProbe>.CopyFrom
	|
	|-RVA: 0x1077250 Offset: 0x1075C50 VA: 0x181077250
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopyFrom
	|
	|-RVA: 0x1082820 Offset: 0x1081220 VA: 0x181082820
	|-NativeArray<LightUtility.LightMeshVertex>.CopyFrom
	|
	|-RVA: 0x1082760 Offset: 0x1081160 VA: 0x181082760
	|-NativeArray<ShaderInput.LightData>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1064D00 Offset: 0x1063700 VA: 0x181064D00
	|-NativeArray<AttachmentDescriptor>.CopyTo
	|-NativeArray<NudgeJobData>.CopyTo
	|
	|-RVA: 0x1064C00 Offset: 0x1063600 VA: 0x181064C00
	|-NativeArray<BatchCullingOutputDrawCommands>.CopyTo
	|
	|-RVA: 0x1064B00 Offset: 0x1063500 VA: 0x181064B00
	|-NativeArray<bool>.CopyTo
	|-NativeArray<byte>.CopyTo
	|
	|-RVA: 0x106ABE0 Offset: 0x10695E0 VA: 0x18106ABE0
	|-NativeArray<BoundingSphere>.CopyTo
	|-NativeArray<Color>.CopyTo
	|-NativeArray<DrawBufferRange>.CopyTo
	|-NativeArray<GfxUpdateBufferRange>.CopyTo
	|-NativeArray<JobHandle>.CopyTo
	|-NativeArray<Plane>.CopyTo
	|-NativeArray<Quaternion>.CopyTo
	|-NativeArray<Vector4>.CopyTo
	|-NativeArray<double2>.CopyTo
	|-NativeArray<float4>.CopyTo
	|-NativeArray<int4>.CopyTo
	|-NativeArray<quaternion>.CopyTo
	|-NativeArray<ProbeBrickIndex.Brick>.CopyTo
	|
	|-RVA: 0x106AC70 Offset: 0x1069670 VA: 0x18106AC70
	|-NativeArray<Color32>.CopyTo
	|-NativeArray<InclusiveRange>.CopyTo
	|-NativeArray<int>.CopyTo
	|-NativeArray<Int32Enum>.CopyTo
	|-NativeArray<ShaderTagId>.CopyTo
	|-NativeArray<float>.CopyTo
	|-NativeArray<uint>.CopyTo
	|
	|-RVA: 0x106AFD0 Offset: 0x10699D0 VA: 0x18106AFD0
	|-NativeArray<ContactPairHeader>.CopyTo
	|
	|-RVA: 0x106AB50 Offset: 0x1069550 VA: 0x18106AB50
	|-NativeArray<ConvertMeshJobData>.CopyTo
	|
	|-RVA: 0x106AEB0 Offset: 0x10698B0 VA: 0x18106AEB0
	|-NativeArray<CopyClosingMeshJobData>.CopyTo
	|-NativeArray<Transform3x4>.CopyTo
	|
	|-RVA: 0x106AF40 Offset: 0x1069940 VA: 0x18106AF40
	|-NativeArray<CullingSplit>.CopyTo
	|-NativeArray<LightDataGI>.CopyTo
	|-NativeArray<TileData>.CopyTo
	|
	|-RVA: 0x106AD90 Offset: 0x1069790 VA: 0x18106AD90
	|-NativeArray<DecalEntity>.CopyTo
	|-NativeArray<DecalSubDrawCall>.CopyTo
	|-NativeArray<ulong>.CopyTo
	|-NativeArray<Vector2>.CopyTo
	|-NativeArray<float2>.CopyTo
	|-NativeArray<int2>.CopyTo
	|-NativeArray<WordStorage.Entry>.CopyTo
	|
	|-RVA: 0x106AD00 Offset: 0x1069700 VA: 0x18106AD00
	|-NativeArray<short>.CopyTo
	|-NativeArray<ushort>.CopyTo
	|
	|-RVA: 0x106B260 Offset: 0x1069C60 VA: 0x18106B260
	|-NativeArray<Keyframe>.CopyTo
	|
	|-RVA: 0x106AE20 Offset: 0x1069820 VA: 0x18106AE20
	|-NativeArray<Matrix4x4>.CopyTo
	|-NativeArray<Vertex>.CopyTo
	|-NativeArray<float4x4>.CopyTo
	|
	|-RVA: 0x106B160 Offset: 0x1069B60 VA: 0x18106B160
	|-NativeArray<ModifiableContactPair>.CopyTo
	|
	|-RVA: 0x106B060 Offset: 0x1069A60 VA: 0x18106B060
	|-NativeArray<RenderStateBlock>.CopyTo
	|
	|-RVA: 0x1078C80 Offset: 0x1077680 VA: 0x181078C80
	|-NativeArray<UEncroachingSegment>.CopyTo
	|
	|-RVA: 0x1078DA0 Offset: 0x10777A0 VA: 0x181078DA0
	|-NativeArray<UEvent>.CopyTo
	|-NativeArray<UStar>.CopyTo
	|
	|-RVA: 0x1078BF0 Offset: 0x10775F0 VA: 0x181078BF0
	|-NativeArray<UHull>.CopyTo
	|
	|-RVA: 0x1078F30 Offset: 0x1077930 VA: 0x181078F30
	|-NativeArray<UTriangle>.CopyTo
	|
	|-RVA: 0x1078B60 Offset: 0x1077560 VA: 0x181078B60
	|-NativeArray<Vector3>.CopyTo
	|-NativeArray<Vector3Int>.CopyTo
	|-NativeArray<float3>.CopyTo
	|-NativeArray<int3>.CopyTo
	|
	|-RVA: 0x1078E30 Offset: 0x1077830 VA: 0x181078E30
	|-NativeArray<VisibleLight>.CopyTo
	|
	|-RVA: 0x1079030 Offset: 0x1077A30 VA: 0x181079030
	|-NativeArray<VisibleReflectionProbe>.CopyTo
	|
	|-RVA: 0x1078D10 Offset: 0x1077710 VA: 0x181078D10
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopyTo
	|
	|-RVA: 0x1082EE0 Offset: 0x10818E0 VA: 0x181082EE0
	|-NativeArray<LightUtility.LightMeshVertex>.CopyTo
	|
	|-RVA: 0x1082DE0 Offset: 0x10817E0 VA: 0x181082DE0
	|-NativeArray<ShaderInput.LightData>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1066BD0 Offset: 0x10655D0 VA: 0x181066BD0
	|-NativeArray<AttachmentDescriptor>.ToArray
	|-NativeArray<NudgeJobData>.ToArray
	|
	|-RVA: 0x1066D20 Offset: 0x1065720 VA: 0x181066D20
	|-NativeArray<BatchCullingOutputDrawCommands>.ToArray
	|
	|-RVA: 0x1066E70 Offset: 0x1065870 VA: 0x181066E70
	|-NativeArray<bool>.ToArray
	|-NativeArray<byte>.ToArray
	|
	|-RVA: 0x1073120 Offset: 0x1071B20 VA: 0x181073120
	|-NativeArray<BoundingSphere>.ToArray
	|-NativeArray<Color>.ToArray
	|-NativeArray<DrawBufferRange>.ToArray
	|-NativeArray<GfxUpdateBufferRange>.ToArray
	|-NativeArray<JobHandle>.ToArray
	|-NativeArray<Plane>.ToArray
	|-NativeArray<Quaternion>.ToArray
	|-NativeArray<Vector4>.ToArray
	|-NativeArray<double2>.ToArray
	|-NativeArray<float4>.ToArray
	|-NativeArray<int4>.ToArray
	|-NativeArray<quaternion>.ToArray
	|-NativeArray<ProbeBrickIndex.Brick>.ToArray
	|
	|-RVA: 0x1073210 Offset: 0x1071C10 VA: 0x181073210
	|-NativeArray<Color32>.ToArray
	|-NativeArray<InclusiveRange>.ToArray
	|-NativeArray<int>.ToArray
	|-NativeArray<Int32Enum>.ToArray
	|-NativeArray<ShaderTagId>.ToArray
	|-NativeArray<float>.ToArray
	|-NativeArray<uint>.ToArray
	|
	|-RVA: 0x1073810 Offset: 0x1072210 VA: 0x181073810
	|-NativeArray<ContactPairHeader>.ToArray
	|
	|-RVA: 0x1073720 Offset: 0x1072120 VA: 0x181073720
	|-NativeArray<ConvertMeshJobData>.ToArray
	|
	|-RVA: 0x1073900 Offset: 0x1072300 VA: 0x181073900
	|-NativeArray<CopyClosingMeshJobData>.ToArray
	|-NativeArray<Transform3x4>.ToArray
	|
	|-RVA: 0x10733F0 Offset: 0x1071DF0 VA: 0x1810733F0
	|-NativeArray<CullingSplit>.ToArray
	|-NativeArray<LightDataGI>.ToArray
	|-NativeArray<TileData>.ToArray
	|
	|-RVA: 0x1073630 Offset: 0x1072030 VA: 0x181073630
	|-NativeArray<DecalEntity>.ToArray
	|-NativeArray<DecalSubDrawCall>.ToArray
	|-NativeArray<ulong>.ToArray
	|-NativeArray<Vector2>.ToArray
	|-NativeArray<float2>.ToArray
	|-NativeArray<int2>.ToArray
	|-NativeArray<WordStorage.Entry>.ToArray
	|
	|-RVA: 0x10739F0 Offset: 0x10723F0 VA: 0x1810739F0
	|-NativeArray<short>.ToArray
	|-NativeArray<ushort>.ToArray
	|
	|-RVA: 0x1072FD0 Offset: 0x10719D0 VA: 0x181072FD0
	|-NativeArray<Keyframe>.ToArray
	|
	|-RVA: 0x1073300 Offset: 0x1071D00 VA: 0x181073300
	|-NativeArray<Matrix4x4>.ToArray
	|-NativeArray<Vertex>.ToArray
	|-NativeArray<float4x4>.ToArray
	|
	|-RVA: 0x1072E80 Offset: 0x1071880 VA: 0x181072E80
	|-NativeArray<ModifiableContactPair>.ToArray
	|
	|-RVA: 0x10734E0 Offset: 0x1071EE0 VA: 0x1810734E0
	|-NativeArray<RenderStateBlock>.ToArray
	|
	|-RVA: 0x107F610 Offset: 0x107E010 VA: 0x18107F610
	|-NativeArray<UEncroachingSegment>.ToArray
	|
	|-RVA: 0x107F940 Offset: 0x107E340 VA: 0x18107F940
	|-NativeArray<UEvent>.ToArray
	|-NativeArray<UStar>.ToArray
	|
	|-RVA: 0x107FCF0 Offset: 0x107E6F0 VA: 0x18107FCF0
	|-NativeArray<UHull>.ToArray
	|
	|-RVA: 0x107FBA0 Offset: 0x107E5A0 VA: 0x18107FBA0
	|-NativeArray<UTriangle>.ToArray
	|
	|-RVA: 0x107F700 Offset: 0x107E100 VA: 0x18107F700
	|-NativeArray<Vector3>.ToArray
	|-NativeArray<Vector3Int>.ToArray
	|-NativeArray<float3>.ToArray
	|-NativeArray<int3>.ToArray
	|
	|-RVA: 0x107F7F0 Offset: 0x107E1F0 VA: 0x18107F7F0
	|-NativeArray<VisibleLight>.ToArray
	|
	|-RVA: 0x107FDE0 Offset: 0x107E7E0 VA: 0x18107FDE0
	|-NativeArray<VisibleReflectionProbe>.ToArray
	|
	|-RVA: 0x107FA30 Offset: 0x107E430 VA: 0x18107FA30
	|-NativeArray<__Il2CppFullySharedGenericStructType>.ToArray
	|
	|-RVA: 0x10848B0 Offset: 0x10832B0 VA: 0x1810848B0
	|-NativeArray<LightUtility.LightMeshVertex>.ToArray
	|
	|-RVA: 0x10849A0 Offset: 0x10833A0 VA: 0x1810849A0
	|-NativeArray<ShaderInput.LightData>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1066340 Offset: 0x1064D40 VA: 0x181066340
	|-NativeArray<AttachmentDescriptor>.GetEnumerator
	|-NativeArray<NudgeJobData>.GetEnumerator
	|
	|-RVA: 0x1066290 Offset: 0x1064C90 VA: 0x181066290
	|-NativeArray<BatchCullingOutputDrawCommands>.GetEnumerator
	|
	|-RVA: 0x1066450 Offset: 0x1064E50 VA: 0x181066450
	|-NativeArray<bool>.GetEnumerator
	|-NativeArray<byte>.GetEnumerator
	|
	|-RVA: 0x1070740 Offset: 0x106F140 VA: 0x181070740
	|-NativeArray<BoundingSphere>.GetEnumerator
	|-NativeArray<Color>.GetEnumerator
	|-NativeArray<DrawBufferRange>.GetEnumerator
	|-NativeArray<Plane>.GetEnumerator
	|-NativeArray<Quaternion>.GetEnumerator
	|-NativeArray<Vector4>.GetEnumerator
	|-NativeArray<float4>.GetEnumerator
	|-NativeArray<int4>.GetEnumerator
	|-NativeArray<quaternion>.GetEnumerator
	|-NativeArray<ProbeBrickIndex.Brick>.GetEnumerator
	|
	|-RVA: 0x10707D0 Offset: 0x106F1D0 VA: 0x1810707D0
	|-NativeArray<Color32>.GetEnumerator
	|-NativeArray<InclusiveRange>.GetEnumerator
	|-NativeArray<int>.GetEnumerator
	|-NativeArray<Int32Enum>.GetEnumerator
	|-NativeArray<ShaderTagId>.GetEnumerator
	|-NativeArray<float>.GetEnumerator
	|-NativeArray<uint>.GetEnumerator
	|
	|-RVA: 0x1070EC0 Offset: 0x106F8C0 VA: 0x181070EC0
	|-NativeArray<ContactPairHeader>.GetEnumerator
	|
	|-RVA: 0x1070AB0 Offset: 0x106F4B0 VA: 0x181070AB0
	|-NativeArray<ConvertMeshJobData>.GetEnumerator
	|
	|-RVA: 0x1070D40 Offset: 0x106F740 VA: 0x181070D40
	|-NativeArray<CopyClosingMeshJobData>.GetEnumerator
	|
	|-RVA: 0x1070F60 Offset: 0x106F960 VA: 0x181070F60
	|-NativeArray<CullingSplit>.GetEnumerator
	|-NativeArray<LightDataGI>.GetEnumerator
	|-NativeArray<TileData>.GetEnumerator
	|
	|-RVA: 0x1070BA0 Offset: 0x106F5A0 VA: 0x181070BA0
	|-NativeArray<DecalEntity>.GetEnumerator
	|-NativeArray<DecalSubDrawCall>.GetEnumerator
	|-NativeArray<Vector2>.GetEnumerator
	|-NativeArray<float2>.GetEnumerator
	|-NativeArray<int2>.GetEnumerator
	|-NativeArray<WordStorage.Entry>.GetEnumerator
	|
	|-RVA: 0x1070C20 Offset: 0x106F620 VA: 0x181070C20
	|-NativeArray<GfxUpdateBufferRange>.GetEnumerator
	|-NativeArray<JobHandle>.GetEnumerator
	|-NativeArray<double2>.GetEnumerator
	|
	|-RVA: 0x1070940 Offset: 0x106F340 VA: 0x181070940
	|-NativeArray<short>.GetEnumerator
	|-NativeArray<ushort>.GetEnumerator
	|
	|-RVA: 0x1070CB0 Offset: 0x106F6B0 VA: 0x181070CB0
	|-NativeArray<Keyframe>.GetEnumerator
	|
	|-RVA: 0x1070DF0 Offset: 0x106F7F0 VA: 0x181070DF0
	|-NativeArray<Matrix4x4>.GetEnumerator
	|-NativeArray<Vertex>.GetEnumerator
	|-NativeArray<float4x4>.GetEnumerator
	|
	|-RVA: 0x1070850 Offset: 0x106F250 VA: 0x181070850
	|-NativeArray<ModifiableContactPair>.GetEnumerator
	|
	|-RVA: 0x10709C0 Offset: 0x106F3C0 VA: 0x1810709C0
	|-NativeArray<RenderStateBlock>.GetEnumerator
	|
	|-RVA: 0x107D6E0 Offset: 0x107C0E0 VA: 0x18107D6E0
	|-NativeArray<Transform3x4>.GetEnumerator
	|
	|-RVA: 0x107D9B0 Offset: 0x107C3B0 VA: 0x18107D9B0
	|-NativeArray<UEncroachingSegment>.GetEnumerator
	|
	|-RVA: 0x107DA40 Offset: 0x107C440 VA: 0x18107DA40
	|-NativeArray<UEvent>.GetEnumerator
	|
	|-RVA: 0x107DAD0 Offset: 0x107C4D0 VA: 0x18107DAD0
	|-NativeArray<UHull>.GetEnumerator
	|
	|-RVA: 0x107D790 Offset: 0x107C190 VA: 0x18107D790
	|-NativeArray<ulong>.GetEnumerator
	|
	|-RVA: 0x107D920 Offset: 0x107C320 VA: 0x18107D920
	|-NativeArray<UStar>.GetEnumerator
	|
	|-RVA: 0x107D630 Offset: 0x107C030 VA: 0x18107D630
	|-NativeArray<UTriangle>.GetEnumerator
	|
	|-RVA: 0x107D5B0 Offset: 0x107BFB0 VA: 0x18107D5B0
	|-NativeArray<Vector3>.GetEnumerator
	|-NativeArray<Vector3Int>.GetEnumerator
	|-NativeArray<float3>.GetEnumerator
	|-NativeArray<int3>.GetEnumerator
	|
	|-RVA: 0x107D810 Offset: 0x107C210 VA: 0x18107D810
	|-NativeArray<VisibleLight>.GetEnumerator
	|
	|-RVA: 0x107DCB0 Offset: 0x107C6B0 VA: 0x18107DCB0
	|-NativeArray<VisibleReflectionProbe>.GetEnumerator
	|
	|-RVA: 0x107DB90 Offset: 0x107C590 VA: 0x18107DB90
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetEnumerator
	|
	|-RVA: 0x1084220 Offset: 0x1082C20 VA: 0x181084220
	|-NativeArray<LightUtility.LightMeshVertex>.GetEnumerator
	|
	|-RVA: 0x10842C0 Offset: 0x1082CC0 VA: 0x1810842C0
	|-NativeArray<ShaderInput.LightData>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1066870 Offset: 0x1065270 VA: 0x181066870
	|-NativeArray<AttachmentDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<NudgeJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1066790 Offset: 0x1065190 VA: 0x181066790
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x10666F0 Offset: 0x10650F0 VA: 0x1810666F0
	|-NativeArray<bool>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1071F40 Offset: 0x1070940 VA: 0x181071F40
	|-NativeArray<BoundingSphere>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<DrawBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<float4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<int4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<ProbeBrickIndex.Brick>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1071EA0 Offset: 0x10708A0 VA: 0x181071EA0
	|-NativeArray<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<InclusiveRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<ShaderTagId>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1071B80 Offset: 0x1070580 VA: 0x181071B80
	|-NativeArray<ContactPairHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1072290 Offset: 0x1070C90 VA: 0x181072290
	|-NativeArray<ConvertMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x10720B0 Offset: 0x1070AB0 VA: 0x1810720B0
	|-NativeArray<CopyClosingMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x10718D0 Offset: 0x10702D0 VA: 0x1810718D0
	|-NativeArray<CullingSplit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<TileData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x10719E0 Offset: 0x10703E0 VA: 0x1810719E0
	|-NativeArray<DecalEntity>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<DecalSubDrawCall>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<float2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<int2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<WordStorage.Entry>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1071D50 Offset: 0x1070750 VA: 0x181071D50
	|-NativeArray<GfxUpdateBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<double2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1071E00 Offset: 0x1070800 VA: 0x181071E00
	|-NativeArray<short>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1071FF0 Offset: 0x10709F0 VA: 0x181071FF0
	|-NativeArray<Keyframe>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1072190 Offset: 0x1070B90 VA: 0x181072190
	|-NativeArray<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<float4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1071A80 Offset: 0x1070480 VA: 0x181071A80
	|-NativeArray<ModifiableContactPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1071C50 Offset: 0x1070650 VA: 0x181071C50
	|-NativeArray<RenderStateBlock>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107E3C0 Offset: 0x107CDC0 VA: 0x18107E3C0
	|-NativeArray<Transform3x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107E4A0 Offset: 0x107CEA0 VA: 0x18107E4A0
	|-NativeArray<UEncroachingSegment>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107EA60 Offset: 0x107D460 VA: 0x18107EA60
	|-NativeArray<UEvent>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107E630 Offset: 0x107D030 VA: 0x18107E630
	|-NativeArray<UHull>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107E810 Offset: 0x107D210 VA: 0x18107E810
	|-NativeArray<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107EB20 Offset: 0x107D520 VA: 0x18107EB20
	|-NativeArray<UStar>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107E550 Offset: 0x107CF50 VA: 0x18107E550
	|-NativeArray<UTriangle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107E8B0 Offset: 0x107D2B0 VA: 0x18107E8B0
	|-NativeArray<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vector3Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<float3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<int3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107E950 Offset: 0x107D350 VA: 0x18107E950
	|-NativeArray<VisibleLight>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107EBE0 Offset: 0x107D5E0 VA: 0x18107EBE0
	|-NativeArray<VisibleReflectionProbe>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x107E730 Offset: 0x107D130 VA: 0x18107E730
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1084620 Offset: 0x1083020 VA: 0x181084620
	|-NativeArray<LightUtility.LightMeshVertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1084510 Offset: 0x1082F10 VA: 0x181084510
	|-NativeArray<ShaderInput.LightData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1066AF0 Offset: 0x10654F0 VA: 0x181066AF0
	|-NativeArray<AttachmentDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<NudgeJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1066980 Offset: 0x1065380 VA: 0x181066980
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1066A30 Offset: 0x1065430 VA: 0x181066A30
	|-NativeArray<bool>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10723A0 Offset: 0x1070DA0 VA: 0x1810723A0
	|-NativeArray<BoundingSphere>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Color>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<DrawBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Plane>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<float4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<int4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<quaternion>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<ProbeBrickIndex.Brick>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072A50 Offset: 0x1071450 VA: 0x181072A50
	|-NativeArray<Color32>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<InclusiveRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<int>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<ShaderTagId>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<float>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072B10 Offset: 0x1071510 VA: 0x181072B10
	|-NativeArray<ContactPairHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10727C0 Offset: 0x10711C0 VA: 0x1810727C0
	|-NativeArray<ConvertMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10729A0 Offset: 0x10713A0 VA: 0x1810729A0
	|-NativeArray<CopyClosingMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072480 Offset: 0x1070E80 VA: 0x181072480
	|-NativeArray<CullingSplit>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<TileData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072700 Offset: 0x1071100 VA: 0x181072700
	|-NativeArray<DecalEntity>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<DecalSubDrawCall>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<float2>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<int2>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<WordStorage.Entry>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072560 Offset: 0x1070F60 VA: 0x181072560
	|-NativeArray<GfxUpdateBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<double2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072DC0 Offset: 0x10717C0 VA: 0x181072DC0
	|-NativeArray<short>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072CE0 Offset: 0x10716E0 VA: 0x181072CE0
	|-NativeArray<Keyframe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072640 Offset: 0x1071040 VA: 0x181072640
	|-NativeArray<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vertex>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<float4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1072C00 Offset: 0x1071600 VA: 0x181072C00
	|-NativeArray<ModifiableContactPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10728C0 Offset: 0x10712C0 VA: 0x1810728C0
	|-NativeArray<RenderStateBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107ECE0 Offset: 0x107D6E0 VA: 0x18107ECE0
	|-NativeArray<Transform3x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107ED90 Offset: 0x107D790 VA: 0x18107ED90
	|-NativeArray<UEncroachingSegment>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107EF50 Offset: 0x107D950 VA: 0x18107EF50
	|-NativeArray<UEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107F120 Offset: 0x107DB20 VA: 0x18107F120
	|-NativeArray<UHull>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107F550 Offset: 0x107DF50 VA: 0x18107F550
	|-NativeArray<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107EE70 Offset: 0x107D870 VA: 0x18107EE70
	|-NativeArray<UStar>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107F2A0 Offset: 0x107DCA0 VA: 0x18107F2A0
	|-NativeArray<UTriangle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107F1E0 Offset: 0x107DBE0 VA: 0x18107F1E0
	|-NativeArray<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<float3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<int3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107F030 Offset: 0x107DA30 VA: 0x18107F030
	|-NativeArray<VisibleLight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107F460 Offset: 0x107DE60 VA: 0x18107F460
	|-NativeArray<VisibleReflectionProbe>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x107F350 Offset: 0x107DD50 VA: 0x18107F350
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10846F0 Offset: 0x10830F0 VA: 0x1810846F0
	|-NativeArray<LightUtility.LightMeshVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10847E0 Offset: 0x10831E0 VA: 0x1810847E0
	|-NativeArray<ShaderInput.LightData>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1066270 Offset: 0x1064C70 VA: 0x181066270
	|-NativeArray<AttachmentDescriptor>.Equals
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|-NativeArray<bool>.Equals
	|-NativeArray<BoundingSphere>.Equals
	|-NativeArray<byte>.Equals
	|-NativeArray<Color>.Equals
	|-NativeArray<Color32>.Equals
	|-NativeArray<ContactPairHeader>.Equals
	|-NativeArray<ConvertMeshJobData>.Equals
	|-NativeArray<CopyClosingMeshJobData>.Equals
	|-NativeArray<CullingSplit>.Equals
	|-NativeArray<DecalEntity>.Equals
	|-NativeArray<DecalSubDrawCall>.Equals
	|-NativeArray<DrawBufferRange>.Equals
	|-NativeArray<GfxUpdateBufferRange>.Equals
	|-NativeArray<InclusiveRange>.Equals
	|-NativeArray<short>.Equals
	|-NativeArray<int>.Equals
	|-NativeArray<Int32Enum>.Equals
	|-NativeArray<JobHandle>.Equals
	|-NativeArray<Keyframe>.Equals
	|-NativeArray<LightDataGI>.Equals
	|-NativeArray<Matrix4x4>.Equals
	|-NativeArray<ModifiableContactPair>.Equals
	|-NativeArray<NudgeJobData>.Equals
	|-NativeArray<Plane>.Equals
	|-NativeArray<Quaternion>.Equals
	|-NativeArray<RenderStateBlock>.Equals
	|-NativeArray<ShaderTagId>.Equals
	|-NativeArray<float>.Equals
	|-NativeArray<TileData>.Equals
	|-NativeArray<Transform3x4>.Equals
	|-NativeArray<UEncroachingSegment>.Equals
	|-NativeArray<UEvent>.Equals
	|-NativeArray<UHull>.Equals
	|-NativeArray<ushort>.Equals
	|-NativeArray<uint>.Equals
	|-NativeArray<ulong>.Equals
	|-NativeArray<UStar>.Equals
	|-NativeArray<UTriangle>.Equals
	|-NativeArray<Vector2>.Equals
	|-NativeArray<Vector3>.Equals
	|-NativeArray<Vector3Int>.Equals
	|-NativeArray<Vector4>.Equals
	|-NativeArray<Vertex>.Equals
	|-NativeArray<VisibleLight>.Equals
	|-NativeArray<VisibleReflectionProbe>.Equals
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	|-NativeArray<double2>.Equals
	|-NativeArray<float2>.Equals
	|-NativeArray<float3>.Equals
	|-NativeArray<float4>.Equals
	|-NativeArray<float4x4>.Equals
	|-NativeArray<int2>.Equals
	|-NativeArray<int3>.Equals
	|-NativeArray<int4>.Equals
	|-NativeArray<quaternion>.Equals
	|-NativeArray<LightUtility.LightMeshVertex>.Equals
	|-NativeArray<ProbeBrickIndex.Brick>.Equals
	|-NativeArray<ShaderInput.LightData>.Equals
	|-NativeArray<WordStorage.Entry>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1066170 Offset: 0x1064B70 VA: 0x181066170
	|-NativeArray<AttachmentDescriptor>.Equals
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|-NativeArray<bool>.Equals
	|-NativeArray<BoundingSphere>.Equals
	|-NativeArray<byte>.Equals
	|-NativeArray<Color>.Equals
	|-NativeArray<Color32>.Equals
	|-NativeArray<ContactPairHeader>.Equals
	|-NativeArray<ConvertMeshJobData>.Equals
	|-NativeArray<CopyClosingMeshJobData>.Equals
	|-NativeArray<CullingSplit>.Equals
	|-NativeArray<DecalEntity>.Equals
	|-NativeArray<DecalSubDrawCall>.Equals
	|-NativeArray<DrawBufferRange>.Equals
	|-NativeArray<GfxUpdateBufferRange>.Equals
	|-NativeArray<InclusiveRange>.Equals
	|-NativeArray<short>.Equals
	|-NativeArray<int>.Equals
	|-NativeArray<Int32Enum>.Equals
	|-NativeArray<JobHandle>.Equals
	|-NativeArray<Keyframe>.Equals
	|-NativeArray<LightDataGI>.Equals
	|-NativeArray<Matrix4x4>.Equals
	|-NativeArray<ModifiableContactPair>.Equals
	|-NativeArray<NudgeJobData>.Equals
	|-NativeArray<Plane>.Equals
	|-NativeArray<Quaternion>.Equals
	|-NativeArray<RenderStateBlock>.Equals
	|-NativeArray<ShaderTagId>.Equals
	|-NativeArray<float>.Equals
	|-NativeArray<TileData>.Equals
	|-NativeArray<Transform3x4>.Equals
	|-NativeArray<UEncroachingSegment>.Equals
	|-NativeArray<UEvent>.Equals
	|-NativeArray<UHull>.Equals
	|-NativeArray<ushort>.Equals
	|-NativeArray<uint>.Equals
	|-NativeArray<ulong>.Equals
	|-NativeArray<UStar>.Equals
	|-NativeArray<UTriangle>.Equals
	|-NativeArray<Vector2>.Equals
	|-NativeArray<Vector3>.Equals
	|-NativeArray<Vector3Int>.Equals
	|-NativeArray<Vector4>.Equals
	|-NativeArray<Vertex>.Equals
	|-NativeArray<VisibleLight>.Equals
	|-NativeArray<VisibleReflectionProbe>.Equals
	|-NativeArray<double2>.Equals
	|-NativeArray<float2>.Equals
	|-NativeArray<float3>.Equals
	|-NativeArray<float4>.Equals
	|-NativeArray<float4x4>.Equals
	|-NativeArray<int2>.Equals
	|-NativeArray<int3>.Equals
	|-NativeArray<int4>.Equals
	|-NativeArray<quaternion>.Equals
	|-NativeArray<LightUtility.LightMeshVertex>.Equals
	|-NativeArray<ProbeBrickIndex.Brick>.Equals
	|-NativeArray<ShaderInput.LightData>.Equals
	|-NativeArray<WordStorage.Entry>.Equals
	|
	|-RVA: 0x107D460 Offset: 0x107BE60 VA: 0x18107D460
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10664D0 Offset: 0x1064ED0 VA: 0x1810664D0
	|-NativeArray<AttachmentDescriptor>.GetHashCode
	|-NativeArray<BatchCullingOutputDrawCommands>.GetHashCode
	|-NativeArray<bool>.GetHashCode
	|-NativeArray<BoundingSphere>.GetHashCode
	|-NativeArray<byte>.GetHashCode
	|-NativeArray<Color>.GetHashCode
	|-NativeArray<Color32>.GetHashCode
	|-NativeArray<ContactPairHeader>.GetHashCode
	|-NativeArray<ConvertMeshJobData>.GetHashCode
	|-NativeArray<CopyClosingMeshJobData>.GetHashCode
	|-NativeArray<CullingSplit>.GetHashCode
	|-NativeArray<DecalEntity>.GetHashCode
	|-NativeArray<DecalSubDrawCall>.GetHashCode
	|-NativeArray<DrawBufferRange>.GetHashCode
	|-NativeArray<GfxUpdateBufferRange>.GetHashCode
	|-NativeArray<InclusiveRange>.GetHashCode
	|-NativeArray<short>.GetHashCode
	|-NativeArray<int>.GetHashCode
	|-NativeArray<Int32Enum>.GetHashCode
	|-NativeArray<JobHandle>.GetHashCode
	|-NativeArray<Keyframe>.GetHashCode
	|-NativeArray<LightDataGI>.GetHashCode
	|-NativeArray<Matrix4x4>.GetHashCode
	|-NativeArray<ModifiableContactPair>.GetHashCode
	|-NativeArray<NudgeJobData>.GetHashCode
	|-NativeArray<Plane>.GetHashCode
	|-NativeArray<Quaternion>.GetHashCode
	|-NativeArray<RenderStateBlock>.GetHashCode
	|-NativeArray<ShaderTagId>.GetHashCode
	|-NativeArray<float>.GetHashCode
	|-NativeArray<TileData>.GetHashCode
	|-NativeArray<Transform3x4>.GetHashCode
	|-NativeArray<UEncroachingSegment>.GetHashCode
	|-NativeArray<UEvent>.GetHashCode
	|-NativeArray<UHull>.GetHashCode
	|-NativeArray<ushort>.GetHashCode
	|-NativeArray<uint>.GetHashCode
	|-NativeArray<ulong>.GetHashCode
	|-NativeArray<UStar>.GetHashCode
	|-NativeArray<UTriangle>.GetHashCode
	|-NativeArray<Vector2>.GetHashCode
	|-NativeArray<Vector3>.GetHashCode
	|-NativeArray<Vector3Int>.GetHashCode
	|-NativeArray<Vector4>.GetHashCode
	|-NativeArray<Vertex>.GetHashCode
	|-NativeArray<VisibleLight>.GetHashCode
	|-NativeArray<VisibleReflectionProbe>.GetHashCode
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetHashCode
	|-NativeArray<double2>.GetHashCode
	|-NativeArray<float2>.GetHashCode
	|-NativeArray<float3>.GetHashCode
	|-NativeArray<float4>.GetHashCode
	|-NativeArray<float4x4>.GetHashCode
	|-NativeArray<int2>.GetHashCode
	|-NativeArray<int3>.GetHashCode
	|-NativeArray<int4>.GetHashCode
	|-NativeArray<quaternion>.GetHashCode
	|-NativeArray<LightUtility.LightMeshVertex>.GetHashCode
	|-NativeArray<ProbeBrickIndex.Brick>.GetHashCode
	|-NativeArray<ShaderInput.LightData>.GetHashCode
	|-NativeArray<WordStorage.Entry>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(NativeArray<T> left, NativeArray<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1067840 Offset: 0x1066240 VA: 0x181067840
	|-NativeArray<AttachmentDescriptor>.op_Equality
	|-NativeArray<BatchCullingOutputDrawCommands>.op_Equality
	|-NativeArray<bool>.op_Equality
	|-NativeArray<BoundingSphere>.op_Equality
	|-NativeArray<byte>.op_Equality
	|-NativeArray<Color>.op_Equality
	|-NativeArray<Color32>.op_Equality
	|-NativeArray<ContactPairHeader>.op_Equality
	|-NativeArray<ConvertMeshJobData>.op_Equality
	|-NativeArray<CopyClosingMeshJobData>.op_Equality
	|-NativeArray<CullingSplit>.op_Equality
	|-NativeArray<DecalEntity>.op_Equality
	|-NativeArray<DecalSubDrawCall>.op_Equality
	|-NativeArray<DrawBufferRange>.op_Equality
	|-NativeArray<GfxUpdateBufferRange>.op_Equality
	|-NativeArray<InclusiveRange>.op_Equality
	|-NativeArray<short>.op_Equality
	|-NativeArray<int>.op_Equality
	|-NativeArray<Int32Enum>.op_Equality
	|-NativeArray<JobHandle>.op_Equality
	|-NativeArray<Keyframe>.op_Equality
	|-NativeArray<LightDataGI>.op_Equality
	|-NativeArray<Matrix4x4>.op_Equality
	|-NativeArray<ModifiableContactPair>.op_Equality
	|-NativeArray<NudgeJobData>.op_Equality
	|-NativeArray<Plane>.op_Equality
	|-NativeArray<Quaternion>.op_Equality
	|-NativeArray<RenderStateBlock>.op_Equality
	|-NativeArray<ShaderTagId>.op_Equality
	|-NativeArray<float>.op_Equality
	|-NativeArray<TileData>.op_Equality
	|-NativeArray<Transform3x4>.op_Equality
	|-NativeArray<UEncroachingSegment>.op_Equality
	|-NativeArray<UEvent>.op_Equality
	|-NativeArray<UHull>.op_Equality
	|-NativeArray<ushort>.op_Equality
	|-NativeArray<uint>.op_Equality
	|-NativeArray<ulong>.op_Equality
	|-NativeArray<UStar>.op_Equality
	|-NativeArray<UTriangle>.op_Equality
	|-NativeArray<Vector2>.op_Equality
	|-NativeArray<Vector3>.op_Equality
	|-NativeArray<Vector3Int>.op_Equality
	|-NativeArray<Vector4>.op_Equality
	|-NativeArray<Vertex>.op_Equality
	|-NativeArray<VisibleLight>.op_Equality
	|-NativeArray<VisibleReflectionProbe>.op_Equality
	|-NativeArray<double2>.op_Equality
	|-NativeArray<float2>.op_Equality
	|-NativeArray<float3>.op_Equality
	|-NativeArray<float4>.op_Equality
	|-NativeArray<float4x4>.op_Equality
	|-NativeArray<int2>.op_Equality
	|-NativeArray<int3>.op_Equality
	|-NativeArray<int4>.op_Equality
	|-NativeArray<quaternion>.op_Equality
	|-NativeArray<LightUtility.LightMeshVertex>.op_Equality
	|-NativeArray<ProbeBrickIndex.Brick>.op_Equality
	|-NativeArray<ShaderInput.LightData>.op_Equality
	|-NativeArray<WordStorage.Entry>.op_Equality
	|
	|-RVA: 0x1082050 Offset: 0x1080A50 VA: 0x181082050
	|-NativeArray<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, NativeArray<T> dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1065640 Offset: 0x1064040 VA: 0x181065640
	|-NativeArray<AttachmentDescriptor>.Copy
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x10658A0 Offset: 0x10642A0 VA: 0x1810658A0
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x1064E00 Offset: 0x1063800 VA: 0x181064E00
	|-NativeArray<bool>.Copy
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x106BDE0 Offset: 0x106A7E0 VA: 0x18106BDE0
	|-NativeArray<BoundingSphere>.Copy
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<double2>.Copy
	|-NativeArray<float4>.Copy
	|-NativeArray<int4>.Copy
	|-NativeArray<quaternion>.Copy
	|-NativeArray<ProbeBrickIndex.Brick>.Copy
	|
	|-RVA: 0x106BC60 Offset: 0x106A660 VA: 0x18106BC60
	|-NativeArray<Color32>.Copy
	|-NativeArray<InclusiveRange>.Copy
	|-NativeArray<int>.Copy
	|-NativeArray<Int32Enum>.Copy
	|-NativeArray<ShaderTagId>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x106DB40 Offset: 0x106C540 VA: 0x18106DB40
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x106C4D0 Offset: 0x106AED0 VA: 0x18106C4D0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x106C420 Offset: 0x106AE20 VA: 0x18106C420
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x106CBF0 Offset: 0x106B5F0 VA: 0x18106CBF0
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x106B520 Offset: 0x1069F20 VA: 0x18106B520
	|-NativeArray<DecalEntity>.Copy
	|-NativeArray<DecalSubDrawCall>.Copy
	|-NativeArray<ulong>.Copy
	|-NativeArray<Vector2>.Copy
	|-NativeArray<float2>.Copy
	|-NativeArray<int2>.Copy
	|-NativeArray<WordStorage.Entry>.Copy
	|
	|-RVA: 0x106D2B0 Offset: 0x106BCB0 VA: 0x18106D2B0
	|-NativeArray<short>.Copy
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x106B6E0 Offset: 0x106A0E0 VA: 0x18106B6E0
	|-NativeArray<Keyframe>.Copy
	|
	|-RVA: 0x106D610 Offset: 0x106C010 VA: 0x18106D610
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x106C0D0 Offset: 0x106AAD0 VA: 0x18106C0D0
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x106D000 Offset: 0x106BA00 VA: 0x18106D000
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x107B680 Offset: 0x107A080 VA: 0x18107B680
	|-NativeArray<UEncroachingSegment>.Copy
	|
	|-RVA: 0x1079D30 Offset: 0x1078730 VA: 0x181079D30
	|-NativeArray<UEvent>.Copy
	|-NativeArray<UStar>.Copy
	|
	|-RVA: 0x107AC20 Offset: 0x1079620 VA: 0x18107AC20
	|-NativeArray<UHull>.Copy
	|
	|-RVA: 0x107B040 Offset: 0x1079A40 VA: 0x18107B040
	|-NativeArray<UTriangle>.Copy
	|
	|-RVA: 0x107B0E0 Offset: 0x1079AE0 VA: 0x18107B0E0
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|-NativeArray<int3>.Copy
	|
	|-RVA: 0x107A0B0 Offset: 0x1078AB0 VA: 0x18107A0B0
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x107B190 Offset: 0x1079B90 VA: 0x18107B190
	|-NativeArray<VisibleReflectionProbe>.Copy
	|
	|-RVA: 0x1079510 Offset: 0x1077F10 VA: 0x181079510
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x1083130 Offset: 0x1081B30 VA: 0x181083130
	|-NativeArray<LightUtility.LightMeshVertex>.Copy
	|
	|-RVA: 0x10832C0 Offset: 0x1081CC0 VA: 0x1810832C0
	|-NativeArray<ShaderInput.LightData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(T[] src, NativeArray<T> dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1064F50 Offset: 0x1063950 VA: 0x181064F50
	|-NativeArray<AttachmentDescriptor>.Copy
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x10650E0 Offset: 0x1063AE0 VA: 0x1810650E0
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x10657B0 Offset: 0x10641B0 VA: 0x1810657B0
	|-NativeArray<bool>.Copy
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x106C9A0 Offset: 0x106B3A0 VA: 0x18106C9A0
	|-NativeArray<BoundingSphere>.Copy
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<double2>.Copy
	|-NativeArray<float4>.Copy
	|-NativeArray<int4>.Copy
	|-NativeArray<quaternion>.Copy
	|-NativeArray<ProbeBrickIndex.Brick>.Copy
	|
	|-RVA: 0x106BAA0 Offset: 0x106A4A0 VA: 0x18106BAA0
	|-NativeArray<Color32>.Copy
	|-NativeArray<InclusiveRange>.Copy
	|-NativeArray<int>.Copy
	|-NativeArray<Int32Enum>.Copy
	|-NativeArray<ShaderTagId>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x106CB00 Offset: 0x106B500 VA: 0x18106CB00
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x106C640 Offset: 0x106B040 VA: 0x18106C640
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x106E510 Offset: 0x106CF10 VA: 0x18106E510
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x106C330 Offset: 0x106AD30 VA: 0x18106C330
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x106DA50 Offset: 0x106C450 VA: 0x18106DA50
	|-NativeArray<DecalEntity>.Copy
	|-NativeArray<DecalSubDrawCall>.Copy
	|-NativeArray<ulong>.Copy
	|-NativeArray<Vector2>.Copy
	|-NativeArray<float2>.Copy
	|-NativeArray<int2>.Copy
	|-NativeArray<WordStorage.Entry>.Copy
	|
	|-RVA: 0x106E100 Offset: 0x106CB00 VA: 0x18106E100
	|-NativeArray<short>.Copy
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x106E420 Offset: 0x106CE20 VA: 0x18106E420
	|-NativeArray<Keyframe>.Copy
	|
	|-RVA: 0x106C240 Offset: 0x106AC40 VA: 0x18106C240
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x106BFE0 Offset: 0x106A9E0 VA: 0x18106BFE0
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x106C8B0 Offset: 0x106B2B0 VA: 0x18106C8B0
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x107A6B0 Offset: 0x10790B0 VA: 0x18107A6B0
	|-NativeArray<UEncroachingSegment>.Copy
	|
	|-RVA: 0x107AB30 Offset: 0x1079530 VA: 0x18107AB30
	|-NativeArray<UEvent>.Copy
	|-NativeArray<UStar>.Copy
	|
	|-RVA: 0x107A470 Offset: 0x1078E70 VA: 0x18107A470
	|-NativeArray<UHull>.Copy
	|
	|-RVA: 0x1079750 Offset: 0x1078150 VA: 0x181079750
	|-NativeArray<UTriangle>.Copy
	|
	|-RVA: 0x1079840 Offset: 0x1078240 VA: 0x181079840
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|-NativeArray<int3>.Copy
	|
	|-RVA: 0x107A7A0 Offset: 0x10791A0 VA: 0x18107A7A0
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x107AE20 Offset: 0x1079820 VA: 0x18107AE20
	|-NativeArray<VisibleReflectionProbe>.Copy
	|
	|-RVA: 0x1079C80 Offset: 0x1078680 VA: 0x181079C80
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x1082F70 Offset: 0x1081970 VA: 0x181082F70
	|-NativeArray<LightUtility.LightMeshVertex>.Copy
	|
	|-RVA: 0x10835E0 Offset: 0x1081FE0 VA: 0x1810835E0
	|-NativeArray<ShaderInput.LightData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, T[] dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1065400 Offset: 0x1063E00 VA: 0x181065400
	|-NativeArray<AttachmentDescriptor>.Copy
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x1065570 Offset: 0x1063F70 VA: 0x181065570
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x1065C20 Offset: 0x1064620 VA: 0x181065C20
	|-NativeArray<bool>.Copy
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x106B800 Offset: 0x106A200 VA: 0x18106B800
	|-NativeArray<BoundingSphere>.Copy
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<double2>.Copy
	|-NativeArray<float4>.Copy
	|-NativeArray<int4>.Copy
	|-NativeArray<quaternion>.Copy
	|-NativeArray<ProbeBrickIndex.Brick>.Copy
	|
	|-RVA: 0x106D9E0 Offset: 0x106C3E0 VA: 0x18106D9E0
	|-NativeArray<Color32>.Copy
	|-NativeArray<InclusiveRange>.Copy
	|-NativeArray<int>.Copy
	|-NativeArray<Int32Enum>.Copy
	|-NativeArray<ShaderTagId>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x106DE10 Offset: 0x106C810 VA: 0x18106DE10
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x106D0A0 Offset: 0x106BAA0 VA: 0x18106D0A0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x106E6D0 Offset: 0x106D0D0 VA: 0x18106E6D0
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x106E3B0 Offset: 0x106CDB0 VA: 0x18106E3B0
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x106B5D0 Offset: 0x1069FD0 VA: 0x18106B5D0
	|-NativeArray<DecalEntity>.Copy
	|-NativeArray<DecalSubDrawCall>.Copy
	|-NativeArray<ulong>.Copy
	|-NativeArray<Vector2>.Copy
	|-NativeArray<float2>.Copy
	|-NativeArray<int2>.Copy
	|-NativeArray<WordStorage.Entry>.Copy
	|
	|-RVA: 0x106D8A0 Offset: 0x106C2A0 VA: 0x18106D8A0
	|-NativeArray<short>.Copy
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x106E900 Offset: 0x106D300 VA: 0x18106E900
	|-NativeArray<Keyframe>.Copy
	|
	|-RVA: 0x106CE40 Offset: 0x106B840 VA: 0x18106CE40
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x106E600 Offset: 0x106D000 VA: 0x18106E600
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x106B870 Offset: 0x106A270 VA: 0x18106B870
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x107B530 Offset: 0x1079F30 VA: 0x18107B530
	|-NativeArray<UEncroachingSegment>.Copy
	|
	|-RVA: 0x107B230 Offset: 0x1079C30 VA: 0x18107B230
	|-NativeArray<UEvent>.Copy
	|-NativeArray<UStar>.Copy
	|
	|-RVA: 0x107AFD0 Offset: 0x10799D0 VA: 0x18107AFD0
	|-NativeArray<UHull>.Copy
	|
	|-RVA: 0x107A5E0 Offset: 0x1078FE0 VA: 0x18107A5E0
	|-NativeArray<UTriangle>.Copy
	|
	|-RVA: 0x10792B0 Offset: 0x1077CB0 VA: 0x1810792B0
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|-NativeArray<int3>.Copy
	|
	|-RVA: 0x1079A00 Offset: 0x1078400 VA: 0x181079A00
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x1079C10 Offset: 0x1078610 VA: 0x181079C10
	|-NativeArray<VisibleReflectionProbe>.Copy
	|
	|-RVA: 0x1079320 Offset: 0x1077D20 VA: 0x181079320
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x10837E0 Offset: 0x10821E0 VA: 0x1810837E0
	|-NativeArray<LightUtility.LightMeshVertex>.Copy
	|
	|-RVA: 0x1083060 Offset: 0x1081A60 VA: 0x181083060
	|-NativeArray<ShaderInput.LightData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10654D0 Offset: 0x1063ED0 VA: 0x1810654D0
	|-NativeArray<AttachmentDescriptor>.Copy
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x1065040 Offset: 0x1063A40 VA: 0x181065040
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x1065AA0 Offset: 0x10644A0 VA: 0x181065AA0
	|-NativeArray<bool>.Copy
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x106CDA0 Offset: 0x106B7A0 VA: 0x18106CDA0
	|-NativeArray<BoundingSphere>.Copy
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<double2>.Copy
	|-NativeArray<float4>.Copy
	|-NativeArray<int4>.Copy
	|-NativeArray<quaternion>.Copy
	|-NativeArray<ProbeBrickIndex.Brick>.Copy
	|
	|-RVA: 0x106D560 Offset: 0x106BF60 VA: 0x18106D560
	|-NativeArray<Color32>.Copy
	|-NativeArray<InclusiveRange>.Copy
	|-NativeArray<int>.Copy
	|-NativeArray<Int32Enum>.Copy
	|-NativeArray<ShaderTagId>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x106BE80 Offset: 0x106A880 VA: 0x18106BE80
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x106E9D0 Offset: 0x106D3D0 VA: 0x18106E9D0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x106B940 Offset: 0x106A340 VA: 0x18106B940
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x106B9F0 Offset: 0x106A3F0 VA: 0x18106B9F0
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x106D720 Offset: 0x106C120 VA: 0x18106D720
	|-NativeArray<DecalEntity>.Copy
	|-NativeArray<DecalSubDrawCall>.Copy
	|-NativeArray<ulong>.Copy
	|-NativeArray<Vector2>.Copy
	|-NativeArray<float2>.Copy
	|-NativeArray<int2>.Copy
	|-NativeArray<WordStorage.Entry>.Copy
	|
	|-RVA: 0x106BF30 Offset: 0x106A930 VA: 0x18106BF30
	|-NativeArray<short>.Copy
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x106E060 Offset: 0x106CA60 VA: 0x18106E060
	|-NativeArray<Keyframe>.Copy
	|
	|-RVA: 0x106EA80 Offset: 0x106D480 VA: 0x18106EA80
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x106B640 Offset: 0x106A040 VA: 0x18106B640
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x106DE80 Offset: 0x106C880 VA: 0x18106DE80
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x1079DE0 Offset: 0x10787E0 VA: 0x181079DE0
	|-NativeArray<UEncroachingSegment>.Copy
	|
	|-RVA: 0x10790C0 Offset: 0x1077AC0 VA: 0x1810790C0
	|-NativeArray<UEvent>.Copy
	|-NativeArray<UStar>.Copy
	|
	|-RVA: 0x107A890 Offset: 0x1079290 VA: 0x18107A890
	|-NativeArray<UHull>.Copy
	|
	|-RVA: 0x107A010 Offset: 0x1078A10 VA: 0x18107A010
	|-NativeArray<UTriangle>.Copy
	|
	|-RVA: 0x1079E90 Offset: 0x1078890 VA: 0x181079E90
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|-NativeArray<int3>.Copy
	|
	|-RVA: 0x107A940 Offset: 0x1079340 VA: 0x18107A940
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x107A230 Offset: 0x1078C30 VA: 0x18107A230
	|-NativeArray<VisibleReflectionProbe>.Copy
	|
	|-RVA: 0x107AF10 Offset: 0x1079910 VA: 0x18107AF10
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x10834B0 Offset: 0x1081EB0 VA: 0x1810834B0
	|-NativeArray<LightUtility.LightMeshVertex>.Copy
	|
	|-RVA: 0x1083740 Offset: 0x1082140 VA: 0x181083740
	|-NativeArray<ShaderInput.LightData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, T[] dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1065B40 Offset: 0x1064540 VA: 0x181065B40
	|-NativeArray<AttachmentDescriptor>.Copy
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x1065320 Offset: 0x1063D20 VA: 0x181065320
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x10659C0 Offset: 0x10643C0 VA: 0x1810659C0
	|-NativeArray<bool>.Copy
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x106B430 Offset: 0x1069E30 VA: 0x18106B430
	|-NativeArray<BoundingSphere>.Copy
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<double2>.Copy
	|-NativeArray<float4>.Copy
	|-NativeArray<int4>.Copy
	|-NativeArray<quaternion>.Copy
	|-NativeArray<ProbeBrickIndex.Brick>.Copy
	|
	|-RVA: 0x106CA90 Offset: 0x106B490 VA: 0x18106CA90
	|-NativeArray<Color32>.Copy
	|-NativeArray<InclusiveRange>.Copy
	|-NativeArray<int>.Copy
	|-NativeArray<Int32Enum>.Copy
	|-NativeArray<ShaderTagId>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x106DFF0 Offset: 0x106C9F0 VA: 0x18106DFF0
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x106DDA0 Offset: 0x106C7A0 VA: 0x18106DDA0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x106E270 Offset: 0x106CC70 VA: 0x18106E270
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x106CEB0 Offset: 0x106B8B0 VA: 0x18106CEB0
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x106CF20 Offset: 0x106B920 VA: 0x18106CF20
	|-NativeArray<DecalEntity>.Copy
	|-NativeArray<DecalSubDrawCall>.Copy
	|-NativeArray<ulong>.Copy
	|-NativeArray<Vector2>.Copy
	|-NativeArray<float2>.Copy
	|-NativeArray<int2>.Copy
	|-NativeArray<WordStorage.Entry>.Copy
	|
	|-RVA: 0x106CF90 Offset: 0x106B990 VA: 0x18106CF90
	|-NativeArray<short>.Copy
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x106E740 Offset: 0x106D140 VA: 0x18106E740
	|-NativeArray<Keyframe>.Copy
	|
	|-RVA: 0x106D6B0 Offset: 0x106C0B0 VA: 0x18106D6B0
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x106DCC0 Offset: 0x106C6C0 VA: 0x18106DCC0
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x106E820 Offset: 0x106D220 VA: 0x18106E820
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x107A1C0 Offset: 0x1078BC0 VA: 0x18107A1C0
	|-NativeArray<UEncroachingSegment>.Copy
	|
	|-RVA: 0x1079170 Offset: 0x1077B70 VA: 0x181079170
	|-NativeArray<UEvent>.Copy
	|-NativeArray<UStar>.Copy
	|
	|-RVA: 0x10796E0 Offset: 0x10780E0 VA: 0x1810796E0
	|-NativeArray<UHull>.Copy
	|
	|-RVA: 0x107A390 Offset: 0x1078D90 VA: 0x18107A390
	|-NativeArray<UTriangle>.Copy
	|
	|-RVA: 0x1079AD0 Offset: 0x10784D0 VA: 0x181079AD0
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|-NativeArray<int3>.Copy
	|
	|-RVA: 0x107B5A0 Offset: 0x1079FA0 VA: 0x18107B5A0
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x107A150 Offset: 0x1078B50 VA: 0x18107A150
	|-NativeArray<VisibleReflectionProbe>.Copy
	|
	|-RVA: 0x107A2E0 Offset: 0x1078CE0 VA: 0x18107A2E0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x10836D0 Offset: 0x10820D0 VA: 0x1810836D0
	|-NativeArray<LightUtility.LightMeshVertex>.Copy
	|
	|-RVA: 0x10831E0 Offset: 0x1081BE0 VA: 0x1810831E0
	|-NativeArray<ShaderInput.LightData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10656E0 Offset: 0x10640E0 VA: 0x1810656E0
	|-NativeArray<AttachmentDescriptor>.Copy
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x1065250 Offset: 0x1063C50 VA: 0x181065250
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x1064E90 Offset: 0x1063890 VA: 0x181064E90
	|-NativeArray<bool>.Copy
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x106D1E0 Offset: 0x106BBE0 VA: 0x18106D1E0
	|-NativeArray<BoundingSphere>.Copy
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<double2>.Copy
	|-NativeArray<float4>.Copy
	|-NativeArray<int4>.Copy
	|-NativeArray<quaternion>.Copy
	|-NativeArray<ProbeBrickIndex.Brick>.Copy
	|
	|-RVA: 0x106BD10 Offset: 0x106A710 VA: 0x18106BD10
	|-NativeArray<Color32>.Copy
	|-NativeArray<InclusiveRange>.Copy
	|-NativeArray<int>.Copy
	|-NativeArray<Int32Enum>.Copy
	|-NativeArray<ShaderTagId>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x106E2E0 Offset: 0x106CCE0 VA: 0x18106E2E0
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x106DBF0 Offset: 0x106C5F0 VA: 0x18106DBF0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x106B360 Offset: 0x1069D60 VA: 0x18106B360
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x106DF20 Offset: 0x106C920 VA: 0x18106DF20
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x106D7D0 Offset: 0x106C1D0 VA: 0x18106D7D0
	|-NativeArray<DecalEntity>.Copy
	|-NativeArray<DecalSubDrawCall>.Copy
	|-NativeArray<ulong>.Copy
	|-NativeArray<Vector2>.Copy
	|-NativeArray<float2>.Copy
	|-NativeArray<int2>.Copy
	|-NativeArray<WordStorage.Entry>.Copy
	|
	|-RVA: 0x106D910 Offset: 0x106C310 VA: 0x18106D910
	|-NativeArray<short>.Copy
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x106C170 Offset: 0x106AB70 VA: 0x18106C170
	|-NativeArray<Keyframe>.Copy
	|
	|-RVA: 0x106D110 Offset: 0x106BB10 VA: 0x18106D110
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x106C570 Offset: 0x106AF70 VA: 0x18106C570
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x106BB90 Offset: 0x106A590 VA: 0x18106BB90
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x1079B40 Offset: 0x1078540 VA: 0x181079B40
	|-NativeArray<UEncroachingSegment>.Copy
	|
	|-RVA: 0x1079610 Offset: 0x1078010 VA: 0x181079610
	|-NativeArray<UEvent>.Copy
	|-NativeArray<UStar>.Copy
	|
	|-RVA: 0x1079F40 Offset: 0x1078940 VA: 0x181079F40
	|-NativeArray<UHull>.Copy
	|
	|-RVA: 0x107B460 Offset: 0x1079E60 VA: 0x18107B460
	|-NativeArray<UTriangle>.Copy
	|
	|-RVA: 0x107A9E0 Offset: 0x10793E0 VA: 0x18107A9E0
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|-NativeArray<int3>.Copy
	|
	|-RVA: 0x1079930 Offset: 0x1078330 VA: 0x181079930
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x10791E0 Offset: 0x1077BE0 VA: 0x1810791E0
	|-NativeArray<VisibleReflectionProbe>.Copy
	|
	|-RVA: 0x107ACD0 Offset: 0x10796D0 VA: 0x18107ACD0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x1083360 Offset: 0x1081D60 VA: 0x181083360
	|-NativeArray<LightUtility.LightMeshVertex>.Copy
	|
	|-RVA: 0x1083850 Offset: 0x1082250 VA: 0x181083850
	|-NativeArray<ShaderInput.LightData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1065CF0 Offset: 0x10646F0 VA: 0x181065CF0
	|-NativeArray<AttachmentDescriptor>.Copy
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x10651D0 Offset: 0x1063BD0 VA: 0x1810651D0
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x1065940 Offset: 0x1064340 VA: 0x181065940
	|-NativeArray<bool>.Copy
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x106CD20 Offset: 0x106B720 VA: 0x18106CD20
	|-NativeArray<BoundingSphere>.Copy
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<double2>.Copy
	|-NativeArray<float4>.Copy
	|-NativeArray<int4>.Copy
	|-NativeArray<quaternion>.Copy
	|-NativeArray<ProbeBrickIndex.Brick>.Copy
	|
	|-RVA: 0x106B4A0 Offset: 0x1069EA0 VA: 0x18106B4A0
	|-NativeArray<Color32>.Copy
	|-NativeArray<InclusiveRange>.Copy
	|-NativeArray<int>.Copy
	|-NativeArray<Int32Enum>.Copy
	|-NativeArray<ShaderTagId>.Copy
	|-NativeArray<float>.Copy
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x106CCA0 Offset: 0x106B6A0 VA: 0x18106CCA0
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x106D4E0 Offset: 0x106BEE0 VA: 0x18106D4E0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x106C730 Offset: 0x106B130 VA: 0x18106C730
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x106C7B0 Offset: 0x106B1B0 VA: 0x18106C7B0
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x106B780 Offset: 0x106A180 VA: 0x18106B780
	|-NativeArray<DecalEntity>.Copy
	|-NativeArray<DecalSubDrawCall>.Copy
	|-NativeArray<ulong>.Copy
	|-NativeArray<Vector2>.Copy
	|-NativeArray<float2>.Copy
	|-NativeArray<int2>.Copy
	|-NativeArray<WordStorage.Entry>.Copy
	|
	|-RVA: 0x106D3E0 Offset: 0x106BDE0 VA: 0x18106D3E0
	|-NativeArray<short>.Copy
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x106C830 Offset: 0x106B230 VA: 0x18106C830
	|-NativeArray<Keyframe>.Copy
	|
	|-RVA: 0x106E1F0 Offset: 0x106CBF0 VA: 0x18106E1F0
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x106D360 Offset: 0x106BD60 VA: 0x18106D360
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x106D460 Offset: 0x106BE60 VA: 0x18106D460
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x1079490 Offset: 0x1077E90 VA: 0x181079490
	|-NativeArray<UEncroachingSegment>.Copy
	|
	|-RVA: 0x107A560 Offset: 0x1078F60 VA: 0x18107A560
	|-NativeArray<UEvent>.Copy
	|-NativeArray<UStar>.Copy
	|
	|-RVA: 0x107B320 Offset: 0x1079D20 VA: 0x18107B320
	|-NativeArray<UHull>.Copy
	|
	|-RVA: 0x107B2A0 Offset: 0x1079CA0 VA: 0x18107B2A0
	|-NativeArray<UTriangle>.Copy
	|
	|-RVA: 0x1079410 Offset: 0x1077E10 VA: 0x181079410
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|-NativeArray<float3>.Copy
	|-NativeArray<int3>.Copy
	|
	|-RVA: 0x107AAB0 Offset: 0x10794B0 VA: 0x18107AAB0
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x107ADA0 Offset: 0x10797A0 VA: 0x18107ADA0
	|-NativeArray<VisibleReflectionProbe>.Copy
	|
	|-RVA: 0x107B3A0 Offset: 0x1079DA0 VA: 0x18107B3A0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x1083560 Offset: 0x1081F60 VA: 0x181083560
	|-NativeArray<LightUtility.LightMeshVertex>.Copy
	|
	|-RVA: 0x1083430 Offset: 0x1081E30 VA: 0x181083430
	|-NativeArray<ShaderInput.LightData>.Copy
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1064460 Offset: 0x1062E60 VA: 0x181064460
	|-NativeArray<AttachmentDescriptor>.CopySafe
	|-NativeArray<NudgeJobData>.CopySafe
	|
	|-RVA: 0x10648C0 Offset: 0x10632C0 VA: 0x1810648C0
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x1064760 Offset: 0x1063160 VA: 0x181064760
	|-NativeArray<bool>.CopySafe
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x1069510 Offset: 0x1067F10 VA: 0x181069510
	|-NativeArray<BoundingSphere>.CopySafe
	|-NativeArray<Color>.CopySafe
	|-NativeArray<DrawBufferRange>.CopySafe
	|-NativeArray<GfxUpdateBufferRange>.CopySafe
	|-NativeArray<JobHandle>.CopySafe
	|-NativeArray<Plane>.CopySafe
	|-NativeArray<Quaternion>.CopySafe
	|-NativeArray<Vector4>.CopySafe
	|-NativeArray<double2>.CopySafe
	|-NativeArray<float4>.CopySafe
	|-NativeArray<int4>.CopySafe
	|-NativeArray<quaternion>.CopySafe
	|-NativeArray<ProbeBrickIndex.Brick>.CopySafe
	|
	|-RVA: 0x106A320 Offset: 0x1068D20 VA: 0x18106A320
	|-NativeArray<Color32>.CopySafe
	|-NativeArray<InclusiveRange>.CopySafe
	|-NativeArray<int>.CopySafe
	|-NativeArray<Int32Enum>.CopySafe
	|-NativeArray<ShaderTagId>.CopySafe
	|-NativeArray<float>.CopySafe
	|-NativeArray<uint>.CopySafe
	|
	|-RVA: 0x106A850 Offset: 0x1069250 VA: 0x18106A850
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x106A570 Offset: 0x1068F70 VA: 0x18106A570
	|-NativeArray<ConvertMeshJobData>.CopySafe
	|
	|-RVA: 0x1069CD0 Offset: 0x10686D0 VA: 0x181069CD0
	|-NativeArray<CopyClosingMeshJobData>.CopySafe
	|-NativeArray<Transform3x4>.CopySafe
	|
	|-RVA: 0x106A7A0 Offset: 0x10691A0 VA: 0x18106A7A0
	|-NativeArray<CullingSplit>.CopySafe
	|-NativeArray<LightDataGI>.CopySafe
	|-NativeArray<TileData>.CopySafe
	|
	|-RVA: 0x10690F0 Offset: 0x1067AF0 VA: 0x1810690F0
	|-NativeArray<DecalEntity>.CopySafe
	|-NativeArray<DecalSubDrawCall>.CopySafe
	|-NativeArray<ulong>.CopySafe
	|-NativeArray<Vector2>.CopySafe
	|-NativeArray<float2>.CopySafe
	|-NativeArray<int2>.CopySafe
	|-NativeArray<WordStorage.Entry>.CopySafe
	|
	|-RVA: 0x106A900 Offset: 0x1069300 VA: 0x18106A900
	|-NativeArray<short>.CopySafe
	|-NativeArray<ushort>.CopySafe
	|
	|-RVA: 0x106A0E0 Offset: 0x1068AE0 VA: 0x18106A0E0
	|-NativeArray<Keyframe>.CopySafe
	|
	|-RVA: 0x1069B50 Offset: 0x1068550 VA: 0x181069B50
	|-NativeArray<Matrix4x4>.CopySafe
	|-NativeArray<Vertex>.CopySafe
	|-NativeArray<float4x4>.CopySafe
	|
	|-RVA: 0x106A700 Offset: 0x1069100 VA: 0x18106A700
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x1069750 Offset: 0x1068150 VA: 0x181069750
	|-NativeArray<RenderStateBlock>.CopySafe
	|
	|-RVA: 0x1078000 Offset: 0x1076A00 VA: 0x181078000
	|-NativeArray<UEncroachingSegment>.CopySafe
	|
	|-RVA: 0x1078310 Offset: 0x1076D10 VA: 0x181078310
	|-NativeArray<UEvent>.CopySafe
	|-NativeArray<UStar>.CopySafe
	|
	|-RVA: 0x1077DA0 Offset: 0x10767A0 VA: 0x181077DA0
	|-NativeArray<UHull>.CopySafe
	|
	|-RVA: 0x10779D0 Offset: 0x10763D0 VA: 0x1810779D0
	|-NativeArray<UTriangle>.CopySafe
	|
	|-RVA: 0x1077760 Offset: 0x1076160 VA: 0x181077760
	|-NativeArray<Vector3>.CopySafe
	|-NativeArray<Vector3Int>.CopySafe
	|-NativeArray<float3>.CopySafe
	|-NativeArray<int3>.CopySafe
	|
	|-RVA: 0x10789F0 Offset: 0x10773F0 VA: 0x1810789F0
	|-NativeArray<VisibleLight>.CopySafe
	|
	|-RVA: 0x10780B0 Offset: 0x1076AB0 VA: 0x1810780B0
	|-NativeArray<VisibleReflectionProbe>.CopySafe
	|
	|-RVA: 0x10784A0 Offset: 0x1076EA0 VA: 0x1810784A0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	|
	|-RVA: 0x1082D30 Offset: 0x1081730 VA: 0x181082D30
	|-NativeArray<LightUtility.LightMeshVertex>.CopySafe
	|
	|-RVA: 0x1082BC0 Offset: 0x10815C0 VA: 0x181082BC0
	|-NativeArray<ShaderInput.LightData>.CopySafe
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1064690 Offset: 0x1063090 VA: 0x181064690
	|-NativeArray<AttachmentDescriptor>.CopySafe
	|-NativeArray<NudgeJobData>.CopySafe
	|
	|-RVA: 0x1064960 Offset: 0x1063360 VA: 0x181064960
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x1064800 Offset: 0x1063200 VA: 0x181064800
	|-NativeArray<bool>.CopySafe
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x10695B0 Offset: 0x1067FB0 VA: 0x1810695B0
	|-NativeArray<BoundingSphere>.CopySafe
	|-NativeArray<Color>.CopySafe
	|-NativeArray<DrawBufferRange>.CopySafe
	|-NativeArray<GfxUpdateBufferRange>.CopySafe
	|-NativeArray<JobHandle>.CopySafe
	|-NativeArray<Plane>.CopySafe
	|-NativeArray<Quaternion>.CopySafe
	|-NativeArray<Vector4>.CopySafe
	|-NativeArray<double2>.CopySafe
	|-NativeArray<float4>.CopySafe
	|-NativeArray<int4>.CopySafe
	|-NativeArray<quaternion>.CopySafe
	|-NativeArray<ProbeBrickIndex.Brick>.CopySafe
	|
	|-RVA: 0x1069BF0 Offset: 0x10685F0 VA: 0x181069BF0
	|-NativeArray<Color32>.CopySafe
	|-NativeArray<InclusiveRange>.CopySafe
	|-NativeArray<int>.CopySafe
	|-NativeArray<Int32Enum>.CopySafe
	|-NativeArray<ShaderTagId>.CopySafe
	|-NativeArray<float>.CopySafe
	|-NativeArray<uint>.CopySafe
	|
	|-RVA: 0x106A9A0 Offset: 0x10693A0 VA: 0x18106A9A0
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x106AA80 Offset: 0x1069480 VA: 0x18106AA80
	|-NativeArray<ConvertMeshJobData>.CopySafe
	|
	|-RVA: 0x10691A0 Offset: 0x1067BA0 VA: 0x1810691A0
	|-NativeArray<CopyClosingMeshJobData>.CopySafe
	|-NativeArray<Transform3x4>.CopySafe
	|
	|-RVA: 0x1069430 Offset: 0x1067E30 VA: 0x181069430
	|-NativeArray<CullingSplit>.CopySafe
	|-NativeArray<LightDataGI>.CopySafe
	|-NativeArray<TileData>.CopySafe
	|
	|-RVA: 0x1069F30 Offset: 0x1068930 VA: 0x181069F30
	|-NativeArray<DecalEntity>.CopySafe
	|-NativeArray<DecalSubDrawCall>.CopySafe
	|-NativeArray<ulong>.CopySafe
	|-NativeArray<Vector2>.CopySafe
	|-NativeArray<float2>.CopySafe
	|-NativeArray<int2>.CopySafe
	|-NativeArray<WordStorage.Entry>.CopySafe
	|
	|-RVA: 0x10698D0 Offset: 0x10682D0 VA: 0x1810698D0
	|-NativeArray<short>.CopySafe
	|-NativeArray<ushort>.CopySafe
	|
	|-RVA: 0x1068F50 Offset: 0x1067950 VA: 0x181068F50
	|-NativeArray<Keyframe>.CopySafe
	|
	|-RVA: 0x106A250 Offset: 0x1068C50 VA: 0x18106A250
	|-NativeArray<Matrix4x4>.CopySafe
	|-NativeArray<Vertex>.CopySafe
	|-NativeArray<float4x4>.CopySafe
	|
	|-RVA: 0x1069D80 Offset: 0x1068780 VA: 0x181069D80
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x1069020 Offset: 0x1067A20 VA: 0x181069020
	|-NativeArray<RenderStateBlock>.CopySafe
	|
	|-RVA: 0x10786C0 Offset: 0x10770C0 VA: 0x1810786C0
	|-NativeArray<UEncroachingSegment>.CopySafe
	|
	|-RVA: 0x1077810 Offset: 0x1076210 VA: 0x181077810
	|-NativeArray<UEvent>.CopySafe
	|-NativeArray<UStar>.CopySafe
	|
	|-RVA: 0x1077680 Offset: 0x1076080 VA: 0x181077680
	|-NativeArray<UHull>.CopySafe
	|
	|-RVA: 0x1077CD0 Offset: 0x10766D0 VA: 0x181077CD0
	|-NativeArray<UTriangle>.CopySafe
	|
	|-RVA: 0x1077A70 Offset: 0x1076470 VA: 0x181077A70
	|-NativeArray<Vector3>.CopySafe
	|-NativeArray<Vector3Int>.CopySafe
	|-NativeArray<float3>.CopySafe
	|-NativeArray<int3>.CopySafe
	|
	|-RVA: 0x1078A90 Offset: 0x1077490 VA: 0x181078A90
	|-NativeArray<VisibleLight>.CopySafe
	|
	|-RVA: 0x1078920 Offset: 0x1077320 VA: 0x181078920
	|-NativeArray<VisibleReflectionProbe>.CopySafe
	|
	|-RVA: 0x10787A0 Offset: 0x10771A0 VA: 0x1810787A0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	|
	|-RVA: 0x1082A10 Offset: 0x1081410 VA: 0x181082A10
	|-NativeArray<LightUtility.LightMeshVertex>.CopySafe
	|
	|-RVA: 0x1082C60 Offset: 0x1081660 VA: 0x181082C60
	|-NativeArray<ShaderInput.LightData>.CopySafe
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10645C0 Offset: 0x1062FC0 VA: 0x1810645C0
	|-NativeArray<AttachmentDescriptor>.CopySafe
	|-NativeArray<NudgeJobData>.CopySafe
	|
	|-RVA: 0x1064A30 Offset: 0x1063430 VA: 0x181064A30
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x1064500 Offset: 0x1062F00 VA: 0x181064500
	|-NativeArray<bool>.CopySafe
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x1069680 Offset: 0x1068080 VA: 0x181069680
	|-NativeArray<BoundingSphere>.CopySafe
	|-NativeArray<Color>.CopySafe
	|-NativeArray<DrawBufferRange>.CopySafe
	|-NativeArray<GfxUpdateBufferRange>.CopySafe
	|-NativeArray<JobHandle>.CopySafe
	|-NativeArray<Plane>.CopySafe
	|-NativeArray<Quaternion>.CopySafe
	|-NativeArray<Vector4>.CopySafe
	|-NativeArray<double2>.CopySafe
	|-NativeArray<float4>.CopySafe
	|-NativeArray<int4>.CopySafe
	|-NativeArray<quaternion>.CopySafe
	|-NativeArray<ProbeBrickIndex.Brick>.CopySafe
	|
	|-RVA: 0x106A620 Offset: 0x1069020 VA: 0x18106A620
	|-NativeArray<Color32>.CopySafe
	|-NativeArray<InclusiveRange>.CopySafe
	|-NativeArray<int>.CopySafe
	|-NativeArray<Int32Enum>.CopySafe
	|-NativeArray<ShaderTagId>.CopySafe
	|-NativeArray<float>.CopySafe
	|-NativeArray<uint>.CopySafe
	|
	|-RVA: 0x1069280 Offset: 0x1067C80 VA: 0x181069280
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x10699A0 Offset: 0x10683A0 VA: 0x1810699A0
	|-NativeArray<ConvertMeshJobData>.CopySafe
	|
	|-RVA: 0x1069E50 Offset: 0x1068850 VA: 0x181069E50
	|-NativeArray<CopyClosingMeshJobData>.CopySafe
	|-NativeArray<Transform3x4>.CopySafe
	|
	|-RVA: 0x1069A70 Offset: 0x1068470 VA: 0x181069A70
	|-NativeArray<CullingSplit>.CopySafe
	|-NativeArray<LightDataGI>.CopySafe
	|-NativeArray<TileData>.CopySafe
	|
	|-RVA: 0x10697F0 Offset: 0x10681F0 VA: 0x1810697F0
	|-NativeArray<DecalEntity>.CopySafe
	|-NativeArray<DecalSubDrawCall>.CopySafe
	|-NativeArray<ulong>.CopySafe
	|-NativeArray<Vector2>.CopySafe
	|-NativeArray<float2>.CopySafe
	|-NativeArray<int2>.CopySafe
	|-NativeArray<WordStorage.Entry>.CopySafe
	|
	|-RVA: 0x106A4A0 Offset: 0x1068EA0 VA: 0x18106A4A0
	|-NativeArray<short>.CopySafe
	|-NativeArray<ushort>.CopySafe
	|
	|-RVA: 0x106A180 Offset: 0x1068B80 VA: 0x18106A180
	|-NativeArray<Keyframe>.CopySafe
	|
	|-RVA: 0x106A010 Offset: 0x1068A10 VA: 0x18106A010
	|-NativeArray<Matrix4x4>.CopySafe
	|-NativeArray<Vertex>.CopySafe
	|-NativeArray<float4x4>.CopySafe
	|
	|-RVA: 0x1069360 Offset: 0x1067D60 VA: 0x181069360
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x106A3D0 Offset: 0x1068DD0 VA: 0x18106A3D0
	|-NativeArray<RenderStateBlock>.CopySafe
	|
	|-RVA: 0x1078160 Offset: 0x1076B60 VA: 0x181078160
	|-NativeArray<UEncroachingSegment>.CopySafe
	|
	|-RVA: 0x10783C0 Offset: 0x1076DC0 VA: 0x1810783C0
	|-NativeArray<UEvent>.CopySafe
	|-NativeArray<UStar>.CopySafe
	|
	|-RVA: 0x1077E50 Offset: 0x1076850 VA: 0x181077E50
	|-NativeArray<UHull>.CopySafe
	|
	|-RVA: 0x10785F0 Offset: 0x1076FF0 VA: 0x1810785F0
	|-NativeArray<UTriangle>.CopySafe
	|
	|-RVA: 0x10778F0 Offset: 0x10762F0 VA: 0x1810778F0
	|-NativeArray<Vector3>.CopySafe
	|-NativeArray<Vector3Int>.CopySafe
	|-NativeArray<float3>.CopySafe
	|-NativeArray<int3>.CopySafe
	|
	|-RVA: 0x1077F30 Offset: 0x1076930 VA: 0x181077F30
	|-NativeArray<VisibleLight>.CopySafe
	|
	|-RVA: 0x1078240 Offset: 0x1076C40 VA: 0x181078240
	|-NativeArray<VisibleReflectionProbe>.CopySafe
	|
	|-RVA: 0x1077B50 Offset: 0x1076550 VA: 0x181077B50
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	|
	|-RVA: 0x1082930 Offset: 0x1081330 VA: 0x181082930
	|-NativeArray<LightUtility.LightMeshVertex>.CopySafe
	|
	|-RVA: 0x1082AF0 Offset: 0x10814F0 VA: 0x181082AF0
	|-NativeArray<ShaderInput.LightData>.CopySafe
	*/

	// RVA: -1 Offset: -1
	private NativeArray<U> InternalReinterpret<U>(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC8AE0 Offset: 0xDC74E0 VA: 0x180DC8AE0
	|-NativeArray<byte>.InternalReinterpret<byte>
	|-NativeArray<byte>.InternalReinterpret<float>
	|-NativeArray<byte>.InternalReinterpret<ushort>
	|-NativeArray<byte>.InternalReinterpret<Vector3>
	|-NativeArray<byte>.InternalReinterpret<ProbeBrickIndex.Brick>
	|-NativeArray<float>.InternalReinterpret<float>
	|-NativeArray<uint>.InternalReinterpret<float4>
	|-NativeArray<float4x4>.InternalReinterpret<Matrix4x4>
	|
	|-RVA: 0xDC8B60 Offset: 0xDC7560 VA: 0x180DC8B60
	|-NativeArray<__Il2CppFullySharedGenericStructType>.InternalReinterpret<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray<U> Reinterpret<U>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC8F20 Offset: 0xDC7920 VA: 0x180DC8F20
	|-NativeArray<float>.Reinterpret<float>
	|-NativeArray<float4x4>.Reinterpret<Matrix4x4>
	|
	|-RVA: 0xDC8E60 Offset: 0xDC7860 VA: 0x180DC8E60
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Reinterpret<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray<U> Reinterpret<U>(int expectedTypeSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC8C90 Offset: 0xDC7690 VA: 0x180DC8C90
	|-NativeArray<byte>.Reinterpret<byte>
	|
	|-RVA: 0xDC8FB0 Offset: 0xDC79B0 VA: 0x180DC8FB0
	|-NativeArray<byte>.Reinterpret<float>
	|
	|-RVA: 0xDC9060 Offset: 0xDC7A60 VA: 0x180DC9060
	|-NativeArray<byte>.Reinterpret<ushort>
	|
	|-RVA: 0xDC9110 Offset: 0xDC7B10 VA: 0x180DC9110
	|-NativeArray<byte>.Reinterpret<Vector3>
	|
	|-RVA: 0xDC8BE0 Offset: 0xDC75E0 VA: 0x180DC8BE0
	|-NativeArray<byte>.Reinterpret<ProbeBrickIndex.Brick>
	|
	|-RVA: 0xDC91D0 Offset: 0xDC7BD0 VA: 0x180DC91D0
	|-NativeArray<uint>.Reinterpret<float4>
	|
	|-RVA: 0xDC8D30 Offset: 0xDC7730 VA: 0x180DC8D30
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Reinterpret<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> GetSubArray(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10664E0 Offset: 0x1064EE0 VA: 0x1810664E0
	|-NativeArray<AttachmentDescriptor>.GetSubArray
	|-NativeArray<NudgeJobData>.GetSubArray
	|
	|-RVA: 0x1066640 Offset: 0x1065040 VA: 0x181066640
	|-NativeArray<BatchCullingOutputDrawCommands>.GetSubArray
	|
	|-RVA: 0x1066590 Offset: 0x1064F90 VA: 0x181066590
	|-NativeArray<bool>.GetSubArray
	|-NativeArray<byte>.GetSubArray
	|
	|-RVA: 0x1071280 Offset: 0x106FC80 VA: 0x181071280
	|-NativeArray<BoundingSphere>.GetSubArray
	|-NativeArray<Color>.GetSubArray
	|-NativeArray<DrawBufferRange>.GetSubArray
	|-NativeArray<GfxUpdateBufferRange>.GetSubArray
	|-NativeArray<JobHandle>.GetSubArray
	|-NativeArray<Plane>.GetSubArray
	|-NativeArray<Quaternion>.GetSubArray
	|-NativeArray<Vector4>.GetSubArray
	|-NativeArray<double2>.GetSubArray
	|-NativeArray<float4>.GetSubArray
	|-NativeArray<int4>.GetSubArray
	|-NativeArray<quaternion>.GetSubArray
	|-NativeArray<ProbeBrickIndex.Brick>.GetSubArray
	|
	|-RVA: 0x1071560 Offset: 0x106FF60 VA: 0x181071560
	|-NativeArray<Color32>.GetSubArray
	|-NativeArray<InclusiveRange>.GetSubArray
	|-NativeArray<int>.GetSubArray
	|-NativeArray<Int32Enum>.GetSubArray
	|-NativeArray<ShaderTagId>.GetSubArray
	|-NativeArray<float>.GetSubArray
	|-NativeArray<uint>.GetSubArray
	|
	|-RVA: 0x10714A0 Offset: 0x106FEA0 VA: 0x1810714A0
	|-NativeArray<ContactPairHeader>.GetSubArray
	|
	|-RVA: 0x1071820 Offset: 0x1070220 VA: 0x181071820
	|-NativeArray<ConvertMeshJobData>.GetSubArray
	|
	|-RVA: 0x1071110 Offset: 0x106FB10 VA: 0x181071110
	|-NativeArray<CopyClosingMeshJobData>.GetSubArray
	|-NativeArray<Transform3x4>.GetSubArray
	|
	|-RVA: 0x10713E0 Offset: 0x106FDE0 VA: 0x1810713E0
	|-NativeArray<CullingSplit>.GetSubArray
	|-NativeArray<LightDataGI>.GetSubArray
	|-NativeArray<TileData>.GetSubArray
	|
	|-RVA: 0x1071330 Offset: 0x106FD30 VA: 0x181071330
	|-NativeArray<DecalEntity>.GetSubArray
	|-NativeArray<DecalSubDrawCall>.GetSubArray
	|-NativeArray<ulong>.GetSubArray
	|-NativeArray<Vector2>.GetSubArray
	|-NativeArray<float2>.GetSubArray
	|-NativeArray<int2>.GetSubArray
	|-NativeArray<WordStorage.Entry>.GetSubArray
	|
	|-RVA: 0x1071770 Offset: 0x1070170 VA: 0x181071770
	|-NativeArray<short>.GetSubArray
	|-NativeArray<ushort>.GetSubArray
	|
	|-RVA: 0x10711D0 Offset: 0x106FBD0 VA: 0x1810711D0
	|-NativeArray<Keyframe>.GetSubArray
	|
	|-RVA: 0x1071610 Offset: 0x1070010 VA: 0x181071610
	|-NativeArray<Matrix4x4>.GetSubArray
	|-NativeArray<Vertex>.GetSubArray
	|-NativeArray<float4x4>.GetSubArray
	|
	|-RVA: 0x10716C0 Offset: 0x10700C0 VA: 0x1810716C0
	|-NativeArray<ModifiableContactPair>.GetSubArray
	|
	|-RVA: 0x1071060 Offset: 0x106FA60 VA: 0x181071060
	|-NativeArray<RenderStateBlock>.GetSubArray
	|
	|-RVA: 0x107E300 Offset: 0x107CD00 VA: 0x18107E300
	|-NativeArray<UEncroachingSegment>.GetSubArray
	|
	|-RVA: 0x107DFD0 Offset: 0x107C9D0 VA: 0x18107DFD0
	|-NativeArray<UEvent>.GetSubArray
	|-NativeArray<UStar>.GetSubArray
	|
	|-RVA: 0x107DDA0 Offset: 0x107C7A0 VA: 0x18107DDA0
	|-NativeArray<UHull>.GetSubArray
	|
	|-RVA: 0x107E090 Offset: 0x107CA90 VA: 0x18107E090
	|-NativeArray<UTriangle>.GetSubArray
	|
	|-RVA: 0x107DF10 Offset: 0x107C910 VA: 0x18107DF10
	|-NativeArray<Vector3>.GetSubArray
	|-NativeArray<Vector3Int>.GetSubArray
	|-NativeArray<float3>.GetSubArray
	|-NativeArray<int3>.GetSubArray
	|
	|-RVA: 0x107DE60 Offset: 0x107C860 VA: 0x18107DE60
	|-NativeArray<VisibleLight>.GetSubArray
	|
	|-RVA: 0x107E250 Offset: 0x107CC50 VA: 0x18107E250
	|-NativeArray<VisibleReflectionProbe>.GetSubArray
	|
	|-RVA: 0x107E140 Offset: 0x107CB40 VA: 0x18107E140
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetSubArray
	|
	|-RVA: 0x1084450 Offset: 0x1082E50 VA: 0x181084450
	|-NativeArray<LightUtility.LightMeshVertex>.GetSubArray
	|
	|-RVA: 0x10843A0 Offset: 0x1082DA0 VA: 0x1810843A0
	|-NativeArray<ShaderInput.LightData>.GetSubArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray.ReadOnly<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10640B0 Offset: 0x1062AB0 VA: 0x1810640B0
	|-NativeArray<AttachmentDescriptor>.AsReadOnly
	|-NativeArray<BatchCullingOutputDrawCommands>.AsReadOnly
	|-NativeArray<bool>.AsReadOnly
	|-NativeArray<BoundingSphere>.AsReadOnly
	|-NativeArray<byte>.AsReadOnly
	|-NativeArray<Color>.AsReadOnly
	|-NativeArray<Color32>.AsReadOnly
	|-NativeArray<ContactPairHeader>.AsReadOnly
	|-NativeArray<ConvertMeshJobData>.AsReadOnly
	|-NativeArray<CopyClosingMeshJobData>.AsReadOnly
	|-NativeArray<CullingSplit>.AsReadOnly
	|-NativeArray<DecalEntity>.AsReadOnly
	|-NativeArray<DecalSubDrawCall>.AsReadOnly
	|-NativeArray<DrawBufferRange>.AsReadOnly
	|-NativeArray<GfxUpdateBufferRange>.AsReadOnly
	|-NativeArray<InclusiveRange>.AsReadOnly
	|-NativeArray<short>.AsReadOnly
	|-NativeArray<int>.AsReadOnly
	|-NativeArray<Int32Enum>.AsReadOnly
	|-NativeArray<JobHandle>.AsReadOnly
	|-NativeArray<Keyframe>.AsReadOnly
	|-NativeArray<LightDataGI>.AsReadOnly
	|-NativeArray<Matrix4x4>.AsReadOnly
	|-NativeArray<ModifiableContactPair>.AsReadOnly
	|-NativeArray<NudgeJobData>.AsReadOnly
	|-NativeArray<Plane>.AsReadOnly
	|-NativeArray<Quaternion>.AsReadOnly
	|-NativeArray<RenderStateBlock>.AsReadOnly
	|-NativeArray<ShaderTagId>.AsReadOnly
	|-NativeArray<float>.AsReadOnly
	|-NativeArray<TileData>.AsReadOnly
	|-NativeArray<Transform3x4>.AsReadOnly
	|-NativeArray<UEncroachingSegment>.AsReadOnly
	|-NativeArray<UEvent>.AsReadOnly
	|-NativeArray<UHull>.AsReadOnly
	|-NativeArray<ushort>.AsReadOnly
	|-NativeArray<uint>.AsReadOnly
	|-NativeArray<ulong>.AsReadOnly
	|-NativeArray<UStar>.AsReadOnly
	|-NativeArray<UTriangle>.AsReadOnly
	|-NativeArray<Vector2>.AsReadOnly
	|-NativeArray<Vector3>.AsReadOnly
	|-NativeArray<Vector3Int>.AsReadOnly
	|-NativeArray<Vector4>.AsReadOnly
	|-NativeArray<Vertex>.AsReadOnly
	|-NativeArray<VisibleLight>.AsReadOnly
	|-NativeArray<VisibleReflectionProbe>.AsReadOnly
	|-NativeArray<__Il2CppFullySharedGenericStructType>.AsReadOnly
	|-NativeArray<double2>.AsReadOnly
	|-NativeArray<float2>.AsReadOnly
	|-NativeArray<float3>.AsReadOnly
	|-NativeArray<float4>.AsReadOnly
	|-NativeArray<float4x4>.AsReadOnly
	|-NativeArray<int2>.AsReadOnly
	|-NativeArray<int3>.AsReadOnly
	|-NativeArray<int4>.AsReadOnly
	|-NativeArray<quaternion>.AsReadOnly
	|-NativeArray<LightUtility.LightMeshVertex>.AsReadOnly
	|-NativeArray<ProbeBrickIndex.Brick>.AsReadOnly
	|-NativeArray<ShaderInput.LightData>.AsReadOnly
	|-NativeArray<WordStorage.Entry>.AsReadOnly
	*/
}
