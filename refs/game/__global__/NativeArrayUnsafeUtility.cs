public static class NativeArrayUnsafeUtility // TypeDefIndex: 11559
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF098B0 Offset: 0xF082B0 VA: 0x180F098B0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<AttachmentDescriptor>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchCullingOutputDrawCommands>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<bool>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BoundingSphere>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Color>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Color32>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ContactPairHeader>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ConvertMeshJobData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<CopyClosingMeshJobData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<CullingSplit>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<DecalEntity>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<DecalSubDrawCall>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<DrawBufferRange>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<GfxUpdateBufferRange>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<InclusiveRange>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<short>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Int32Enum>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<JobHandle>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Keyframe>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ModifiableContactPair>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<NudgeJobData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Quaternion>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<RenderStateBlock>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ShaderTagId>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<TileData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Transform3x4>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<UEncroachingSegment>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<UEvent>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<UHull>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ushort>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<uint>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ulong>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<UStar>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<UTriangle>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector2>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3Int>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector4>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vertex>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<VisibleLight>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<VisibleReflectionProbe>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<__Il2CppFullySharedGenericStructType>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<double2>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float2>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float3>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float4>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float4x4>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int2>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int3>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int4>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<quaternion>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightUtility.LightMeshVertex>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ProbeBrickIndex.Brick>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ShaderInput.LightData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<WordStorage.Entry>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	|-NativeArrayUnsafeUtility.GetUnsafePtr<byte>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<Color32>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<int>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<float>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<uint>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<ulong>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<VisibleLight>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<AttachmentDescriptor>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<byte>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<int>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<RenderStateBlock>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ShaderTagId>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<float>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ushort>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<uint>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ulong>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<Vertex>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<VisibleLight>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<float4>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<LightUtility.LightMeshVertex>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ShaderInput.LightData>
	*/

	// RVA: -1 Offset: -1
	public static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<byte>
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<UEvent>
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<__Il2CppFullySharedGenericStructType>
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<int2>
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<int3>
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<int4>
	*/
}
