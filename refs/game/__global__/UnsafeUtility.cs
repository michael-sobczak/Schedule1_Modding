public static class UnsafeUtility // TypeDefIndex: 11563
{
	// Methods

	[ThreadSafe(ThrowsException = False)]
	[BurstAuthorizedExternalMethod]
	// RVA: 0x2CA13C0 Offset: 0x2C9FDC0 VA: 0x182CA13C0
	internal static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip) { }

	[BurstAuthorizedExternalMethod]
	[ThreadSafe(ThrowsException = False)]
	// RVA: 0x2CA1380 Offset: 0x2C9FD80 VA: 0x182CA1380
	internal static int LeakErase(IntPtr handle, LeakCategory category) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA1410 Offset: 0x2C9FE10 VA: 0x182CA1410
	public static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA0F10 Offset: 0x2C9F910 VA: 0x182CA0F10
	public static void FreeTracked(void* memory, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA1470 Offset: 0x2C9FE70 VA: 0x182CA1470
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA0F50 Offset: 0x2C9F950 VA: 0x182CA0F50
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA15D0 Offset: 0x2C9FFD0 VA: 0x182CA15D0
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA1570 Offset: 0x2C9FF70 VA: 0x182CA1570
	public static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA1630 Offset: 0x2CA0030 VA: 0x182CA1630
	public static void MemMove(void* destination, void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA1690 Offset: 0x2CA0090 VA: 0x182CA1690
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x2CA14C0 Offset: 0x2C9FEC0 VA: 0x182CA14C0
	public static void MemClear(void* destination, long size) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2CA1510 Offset: 0x2C9FF10 VA: 0x182CA1510
	public static int MemCmp(void* ptr1, void* ptr2, long size) { }

	[ThreadSafe]
	// RVA: 0x2CA16F0 Offset: 0x2CA00F0 VA: 0x182CA16F0
	public static int SizeOf(Type type) { }

	[ThreadSafe]
	// RVA: 0x2CA1340 Offset: 0x2C9FD40 VA: 0x182CA1340
	public static bool IsBlittable(Type type) { }

	[ThreadSafe]
	// RVA: 0x2CA1210 Offset: 0x2C9FC10 VA: 0x182CA1210
	internal static int GetScriptingTypeFlags(Type type) { }

	// RVA: 0x2CA12E0 Offset: 0x2C9FCE0 VA: 0x182CA12E0
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x2CA1000 Offset: 0x2C9FA00 VA: 0x182CA1000
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x2CA1250 Offset: 0x2C9FC50 VA: 0x182CA1250
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: 0x2CA0F90 Offset: 0x2C9F990 VA: 0x182CA0F90
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	public static bool IsUnmanaged<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6CA00 Offset: 0xF6B400 VA: 0x180F6CA00
	|-UnsafeUtility.IsUnmanaged<AllocatorManager.Array32768<AllocatorManager.TableEntry>>
	|-UnsafeUtility.IsUnmanaged<int>
	|-UnsafeUtility.IsUnmanaged<IntPtr>
	|-UnsafeUtility.IsUnmanaged<Long1024>
	|-UnsafeUtility.IsUnmanaged<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsValidNativeContainerElementType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6CA70 Offset: 0xF6B470 VA: 0x180F6CA70
	|-UnsafeUtility.IsValidNativeContainerElementType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C580 Offset: 0xF6AF80 VA: 0x180F6C580
	|-UnsafeUtility.AlignOf<UnsafeList<byte>>
	|-UnsafeUtility.AlignOf<UnsafeList<int>>
	|-UnsafeUtility.AlignOf<UnsafeList<IntPtr>>
	|-UnsafeUtility.AlignOf<AttachmentDescriptor>
	|-UnsafeUtility.AlignOf<BatchCullingOutputDrawCommands>
	|-UnsafeUtility.AlignOf<ContactPairHeader>
	|-UnsafeUtility.AlignOf<ConvertMeshJobData>
	|-UnsafeUtility.AlignOf<CopyClosingMeshJobData>
	|-UnsafeUtility.AlignOf<GfxUpdateBufferRange>
	|-UnsafeUtility.AlignOf<IntPtr>
	|-UnsafeUtility.AlignOf<JobHandle>
	|-UnsafeUtility.AlignOf<ModifiableContactPair>
	|-UnsafeUtility.AlignOf<NativeQueueBlockHeader>
	|-UnsafeUtility.AlignOf<NativeQueueBlockPoolData>
	|-UnsafeUtility.AlignOf<NativeQueueData>
	|-UnsafeUtility.AlignOf<NudgeJobData>
	|-UnsafeUtility.AlignOf<UHull>
	|-UnsafeUtility.AlignOf<ulong>
	|-UnsafeUtility.AlignOf<UStar>
	|-UnsafeUtility.AlignOf<UnsafeList>
	|-UnsafeUtility.AlignOf<UnsafeParallelHashMapData>
	|-UnsafeUtility.AlignOf<UnsafePtrList>
	|-UnsafeUtility.AlignOf<UnsafeStreamBlock>
	|-UnsafeUtility.AlignOf<UnsafeStreamBlockData>
	|-UnsafeUtility.AlignOf<UnsafeStreamRange>
	|-UnsafeUtility.AlignOf<UnsafeText>
	|-UnsafeUtility.AlignOf<double2>
	|-UnsafeUtility.AlignOf<RewindableAllocator.MemoryBlock>
	|
	|-RVA: 0xF6C5A0 Offset: 0xF6AFA0 VA: 0x180F6C5A0
	|-UnsafeUtility.AlignOf<bool>
	|-UnsafeUtility.AlignOf<byte>
	|
	|-RVA: 0xF6C5C0 Offset: 0xF6AFC0 VA: 0x180F6C5C0
	|-UnsafeUtility.AlignOf<BoundingSphere>
	|-UnsafeUtility.AlignOf<Color>
	|-UnsafeUtility.AlignOf<Color32>
	|-UnsafeUtility.AlignOf<CullingSplit>
	|-UnsafeUtility.AlignOf<DecalEntity>
	|-UnsafeUtility.AlignOf<DecalSubDrawCall>
	|-UnsafeUtility.AlignOf<DrawBufferRange>
	|-UnsafeUtility.AlignOf<int>
	|-UnsafeUtility.AlignOf<Int32Enum>
	|-UnsafeUtility.AlignOf<Keyframe>
	|-UnsafeUtility.AlignOf<LightDataGI>
	|-UnsafeUtility.AlignOf<Matrix4x4>
	|-UnsafeUtility.AlignOf<Plane>
	|-UnsafeUtility.AlignOf<Quaternion>
	|-UnsafeUtility.AlignOf<RenderStateBlock>
	|-UnsafeUtility.AlignOf<ShaderTagId>
	|-UnsafeUtility.AlignOf<float>
	|-UnsafeUtility.AlignOf<TileData>
	|-UnsafeUtility.AlignOf<Transform3x4>
	|-UnsafeUtility.AlignOf<UEncroachingSegment>
	|-UnsafeUtility.AlignOf<UEvent>
	|-UnsafeUtility.AlignOf<uint>
	|-UnsafeUtility.AlignOf<UTriangle>
	|-UnsafeUtility.AlignOf<Vector2>
	|-UnsafeUtility.AlignOf<Vector3>
	|-UnsafeUtility.AlignOf<Vector3Int>
	|-UnsafeUtility.AlignOf<Vector4>
	|-UnsafeUtility.AlignOf<Vertex>
	|-UnsafeUtility.AlignOf<VisibleLight>
	|-UnsafeUtility.AlignOf<VisibleReflectionProbe>
	|-UnsafeUtility.AlignOf<float2>
	|-UnsafeUtility.AlignOf<float3>
	|-UnsafeUtility.AlignOf<float4>
	|-UnsafeUtility.AlignOf<float4x4>
	|-UnsafeUtility.AlignOf<int2>
	|-UnsafeUtility.AlignOf<int3>
	|-UnsafeUtility.AlignOf<int4>
	|-UnsafeUtility.AlignOf<quaternion>
	|-UnsafeUtility.AlignOf<LightUtility.LightMeshVertex>
	|-UnsafeUtility.AlignOf<ProbeBrickIndex.Brick>
	|-UnsafeUtility.AlignOf<ShaderInput.LightData>
	|-UnsafeUtility.AlignOf<WordStorage.Entry>
	|
	|-RVA: 0xF6C630 Offset: 0xF6B030 VA: 0x180F6C630
	|-UnsafeUtility.AlignOf<InclusiveRange>
	|-UnsafeUtility.AlignOf<short>
	|-UnsafeUtility.AlignOf<ushort>
	|
	|-RVA: 0xF6C5E0 Offset: 0xF6AFE0 VA: 0x180F6C5E0
	|-UnsafeUtility.AlignOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void CopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C760 Offset: 0xF6B160 VA: 0x180F6C760
	|-UnsafeUtility.CopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<DecalUpdateCachedSystem.UpdateTransformsJob>>
	|
	|-RVA: 0xF6C720 Offset: 0xF6B120 VA: 0x180F6C720
	|-UnsafeUtility.CopyPtrToStructure<int>
	|
	|-RVA: 0xF6C6D0 Offset: 0xF6B0D0 VA: 0x180F6C6D0
	|-UnsafeUtility.CopyPtrToStructure<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void InternalCopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C9F0 Offset: 0xF6B3F0 VA: 0x180F6C9F0
	|-UnsafeUtility.InternalCopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<DecalUpdateCachedSystem.UpdateTransformsJob>>
	|
	|-RVA: 0xF6C9E0 Offset: 0xF6B3E0 VA: 0x180F6C9E0
	|-UnsafeUtility.InternalCopyPtrToStructure<int>
	|
	|-RVA: 0xF6C920 Offset: 0xF6B320 VA: 0x180F6C920
	|-UnsafeUtility.InternalCopyPtrToStructure<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void CopyStructureToPtr<T>(ref T input, void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C720 Offset: 0xF6B120 VA: 0x180F6C720
	|-UnsafeUtility.CopyStructureToPtr<int>
	|
	|-RVA: 0xF6C6D0 Offset: 0xF6B0D0 VA: 0x180F6C6D0
	|-UnsafeUtility.CopyStructureToPtr<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void InternalCopyStructureToPtr<T>(ref T input, void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C9E0 Offset: 0xF6B3E0 VA: 0x180F6C9E0
	|-UnsafeUtility.InternalCopyStructureToPtr<int>
	|
	|-RVA: 0xF6C920 Offset: 0xF6B320 VA: 0x180F6C920
	|-UnsafeUtility.InternalCopyStructureToPtr<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6CAE0 Offset: 0xF6B4E0 VA: 0x180F6CAE0
	|-UnsafeUtility.ReadArrayElement<AttachmentDescriptor>
	|-UnsafeUtility.ReadArrayElement<NudgeJobData>
	|
	|-RVA: 0xF6CB40 Offset: 0xF6B540 VA: 0x180F6CB40
	|-UnsafeUtility.ReadArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0xF6CB80 Offset: 0xF6B580 VA: 0x180F6CB80
	|-UnsafeUtility.ReadArrayElement<bool>
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0xF6CB90 Offset: 0xF6B590 VA: 0x180F6CB90
	|-UnsafeUtility.ReadArrayElement<BoundingSphere>
	|-UnsafeUtility.ReadArrayElement<Color>
	|-UnsafeUtility.ReadArrayElement<DrawBufferRange>
	|-UnsafeUtility.ReadArrayElement<GfxUpdateBufferRange>
	|-UnsafeUtility.ReadArrayElement<Hash128>
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|-UnsafeUtility.ReadArrayElement<Plane>
	|-UnsafeUtility.ReadArrayElement<Quaternion>
	|-UnsafeUtility.ReadArrayElement<Vector4>
	|-UnsafeUtility.ReadArrayElement<double2>
	|-UnsafeUtility.ReadArrayElement<float4>
	|-UnsafeUtility.ReadArrayElement<int4>
	|-UnsafeUtility.ReadArrayElement<quaternion>
	|-UnsafeUtility.ReadArrayElement<ProbeBrickIndex.Brick>
	|
	|-RVA: 0xF6CBB0 Offset: 0xF6B5B0 VA: 0x180F6CBB0
	|-UnsafeUtility.ReadArrayElement<Color32>
	|-UnsafeUtility.ReadArrayElement<InclusiveRange>
	|-UnsafeUtility.ReadArrayElement<int>
	|-UnsafeUtility.ReadArrayElement<Int32Enum>
	|-UnsafeUtility.ReadArrayElement<ShaderTagId>
	|-UnsafeUtility.ReadArrayElement<uint>
	|
	|-RVA: 0xF6CBC0 Offset: 0xF6B5C0 VA: 0x180F6CBC0
	|-UnsafeUtility.ReadArrayElement<ContactPairHeader>
	|
	|-RVA: 0xF6CBF0 Offset: 0xF6B5F0 VA: 0x180F6CBF0
	|-UnsafeUtility.ReadArrayElement<ConvertMeshJobData>
	|
	|-RVA: 0xF6CC70 Offset: 0xF6B670 VA: 0x180F6CC70
	|-UnsafeUtility.ReadArrayElement<CopyClosingMeshJobData>
	|-UnsafeUtility.ReadArrayElement<Transform3x4>
	|
	|-RVA: 0xF6CCA0 Offset: 0xF6B6A0 VA: 0x180F6CCA0
	|-UnsafeUtility.ReadArrayElement<CullingSplit>
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|-UnsafeUtility.ReadArrayElement<TileData>
	|
	|-RVA: 0xF6CCF0 Offset: 0xF6B6F0 VA: 0x180F6CCF0
	|-UnsafeUtility.ReadArrayElement<DecalEntity>
	|-UnsafeUtility.ReadArrayElement<DecalSubDrawCall>
	|-UnsafeUtility.ReadArrayElement<ulong>
	|-UnsafeUtility.ReadArrayElement<int2>
	|-UnsafeUtility.ReadArrayElement<WordStorage.Entry>
	|
	|-RVA: 0xF6CD00 Offset: 0xF6B700 VA: 0x180F6CD00
	|-UnsafeUtility.ReadArrayElement<double>
	|
	|-RVA: 0xF6CD10 Offset: 0xF6B710 VA: 0x180F6CD10
	|-UnsafeUtility.ReadArrayElement<short>
	|-UnsafeUtility.ReadArrayElement<ushort>
	|
	|-RVA: 0xF6CD20 Offset: 0xF6B720 VA: 0x180F6CD20
	|-UnsafeUtility.ReadArrayElement<Keyframe>
	|
	|-RVA: 0xF6CD50 Offset: 0xF6B750 VA: 0x180F6CD50
	|-UnsafeUtility.ReadArrayElement<Matrix4x4>
	|-UnsafeUtility.ReadArrayElement<Vertex>
	|-UnsafeUtility.ReadArrayElement<float4x4>
	|
	|-RVA: 0xF6CD80 Offset: 0xF6B780 VA: 0x180F6CD80
	|-UnsafeUtility.ReadArrayElement<ModifiableContactPair>
	|
	|-RVA: 0xF6CDE0 Offset: 0xF6B7E0 VA: 0x180F6CDE0
	|-UnsafeUtility.ReadArrayElement<RenderStateBlock>
	|
	|-RVA: 0xF6CE40 Offset: 0xF6B840 VA: 0x180F6CE40
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0xF6CE50 Offset: 0xF6B850 VA: 0x180F6CE50
	|-UnsafeUtility.ReadArrayElement<UEncroachingSegment>
	|
	|-RVA: 0xF6CE70 Offset: 0xF6B870 VA: 0x180F6CE70
	|-UnsafeUtility.ReadArrayElement<UEvent>
	|-UnsafeUtility.ReadArrayElement<UStar>
	|
	|-RVA: 0xF6CE90 Offset: 0xF6B890 VA: 0x180F6CE90
	|-UnsafeUtility.ReadArrayElement<UHull>
	|
	|-RVA: 0xF6CED0 Offset: 0xF6B8D0 VA: 0x180F6CED0
	|-UnsafeUtility.ReadArrayElement<UTriangle>
	|
	|-RVA: 0xF6CF00 Offset: 0xF6B900 VA: 0x180F6CF00
	|-UnsafeUtility.ReadArrayElement<Vector2>
	|-UnsafeUtility.ReadArrayElement<float2>
	|
	|-RVA: 0xF6CF20 Offset: 0xF6B920 VA: 0x180F6CF20
	|-UnsafeUtility.ReadArrayElement<Vector3>
	|-UnsafeUtility.ReadArrayElement<Vector3Int>
	|-UnsafeUtility.ReadArrayElement<float3>
	|-UnsafeUtility.ReadArrayElement<int3>
	|
	|-RVA: 0xF72780 Offset: 0xF71180 VA: 0x180F72780
	|-UnsafeUtility.ReadArrayElement<VisibleLight>
	|
	|-RVA: 0xF727E0 Offset: 0xF711E0 VA: 0x180F727E0
	|-UnsafeUtility.ReadArrayElement<VisibleReflectionProbe>
	|
	|-RVA: 0xF72660 Offset: 0xF71060 VA: 0x180F72660
	|-UnsafeUtility.ReadArrayElement<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF72750 Offset: 0xF71150 VA: 0x180F72750
	|-UnsafeUtility.ReadArrayElement<LightUtility.LightMeshVertex>
	|
	|-RVA: 0xF72700 Offset: 0xF71100 VA: 0x180F72700
	|-UnsafeUtility.ReadArrayElement<ShaderInput.LightData>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElementWithStride<T>(void* source, int index, int stride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF723D0 Offset: 0xF70DD0 VA: 0x180F723D0
	|-UnsafeUtility.ReadArrayElementWithStride<Color32>
	|
	|-RVA: 0xF723E0 Offset: 0xF70DE0 VA: 0x180F723E0
	|-UnsafeUtility.ReadArrayElementWithStride<ConvertMeshJobData>
	|
	|-RVA: 0xF72460 Offset: 0xF70E60 VA: 0x180F72460
	|-UnsafeUtility.ReadArrayElementWithStride<CopyClosingMeshJobData>
	|-UnsafeUtility.ReadArrayElementWithStride<Transform3x4>
	|
	|-RVA: 0xF72490 Offset: 0xF70E90 VA: 0x180F72490
	|-UnsafeUtility.ReadArrayElementWithStride<DrawBufferRange>
	|-UnsafeUtility.ReadArrayElementWithStride<GfxUpdateBufferRange>
	|-UnsafeUtility.ReadArrayElementWithStride<JobHandle>
	|-UnsafeUtility.ReadArrayElementWithStride<Vector4>
	|
	|-RVA: 0xF72560 Offset: 0xF70F60 VA: 0x180F72560
	|-UnsafeUtility.ReadArrayElementWithStride<int>
	|
	|-RVA: 0xF72570 Offset: 0xF70F70 VA: 0x180F72570
	|-UnsafeUtility.ReadArrayElementWithStride<NudgeJobData>
	|
	|-RVA: 0xF725D0 Offset: 0xF70FD0 VA: 0x180F725D0
	|-UnsafeUtility.ReadArrayElementWithStride<ushort>
	|
	|-RVA: 0xF725E0 Offset: 0xF70FE0 VA: 0x180F725E0
	|-UnsafeUtility.ReadArrayElementWithStride<Vector2>
	|
	|-RVA: 0xF72600 Offset: 0xF71000 VA: 0x180F72600
	|-UnsafeUtility.ReadArrayElementWithStride<Vector3>
	|
	|-RVA: 0xF72620 Offset: 0xF71020 VA: 0x180F72620
	|-UnsafeUtility.ReadArrayElementWithStride<Vertex>
	|
	|-RVA: 0xF724B0 Offset: 0xF70EB0 VA: 0x180F724B0
	|-UnsafeUtility.ReadArrayElementWithStride<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF72DD0 Offset: 0xF717D0 VA: 0x180F72DD0
	|-UnsafeUtility.WriteArrayElement<AttachmentDescriptor>
	|-UnsafeUtility.WriteArrayElement<NudgeJobData>
	|
	|-RVA: 0xF72E30 Offset: 0xF71830 VA: 0x180F72E30
	|-UnsafeUtility.WriteArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0xF72E60 Offset: 0xF71860 VA: 0x180F72E60
	|-UnsafeUtility.WriteArrayElement<bool>
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0xF72E70 Offset: 0xF71870 VA: 0x180F72E70
	|-UnsafeUtility.WriteArrayElement<BoundingSphere>
	|-UnsafeUtility.WriteArrayElement<Color>
	|-UnsafeUtility.WriteArrayElement<DrawBufferRange>
	|-UnsafeUtility.WriteArrayElement<GfxUpdateBufferRange>
	|-UnsafeUtility.WriteArrayElement<JobHandle>
	|-UnsafeUtility.WriteArrayElement<Plane>
	|-UnsafeUtility.WriteArrayElement<Quaternion>
	|-UnsafeUtility.WriteArrayElement<Vector4>
	|-UnsafeUtility.WriteArrayElement<double2>
	|-UnsafeUtility.WriteArrayElement<float4>
	|-UnsafeUtility.WriteArrayElement<int4>
	|-UnsafeUtility.WriteArrayElement<quaternion>
	|-UnsafeUtility.WriteArrayElement<ProbeBrickIndex.Brick>
	|
	|-RVA: 0xF72E80 Offset: 0xF71880 VA: 0x180F72E80
	|-UnsafeUtility.WriteArrayElement<Color32>
	|-UnsafeUtility.WriteArrayElement<InclusiveRange>
	|-UnsafeUtility.WriteArrayElement<int>
	|-UnsafeUtility.WriteArrayElement<Int32Enum>
	|-UnsafeUtility.WriteArrayElement<ShaderTagId>
	|-UnsafeUtility.WriteArrayElement<uint>
	|
	|-RVA: 0xF72E90 Offset: 0xF71890 VA: 0x180F72E90
	|-UnsafeUtility.WriteArrayElement<ContactPairHeader>
	|
	|-RVA: 0xF72EC0 Offset: 0xF718C0 VA: 0x180F72EC0
	|-UnsafeUtility.WriteArrayElement<ConvertMeshJobData>
	|
	|-RVA: 0xF72F40 Offset: 0xF71940 VA: 0x180F72F40
	|-UnsafeUtility.WriteArrayElement<CopyClosingMeshJobData>
	|-UnsafeUtility.WriteArrayElement<Transform3x4>
	|
	|-RVA: 0xF72F70 Offset: 0xF71970 VA: 0x180F72F70
	|-UnsafeUtility.WriteArrayElement<CullingSplit>
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|-UnsafeUtility.WriteArrayElement<TileData>
	|
	|-RVA: 0xF72FC0 Offset: 0xF719C0 VA: 0x180F72FC0
	|-UnsafeUtility.WriteArrayElement<DecalEntity>
	|-UnsafeUtility.WriteArrayElement<DecalSubDrawCall>
	|-UnsafeUtility.WriteArrayElement<IntPtr>
	|-UnsafeUtility.WriteArrayElement<ulong>
	|-UnsafeUtility.WriteArrayElement<Vector2>
	|-UnsafeUtility.WriteArrayElement<float2>
	|-UnsafeUtility.WriteArrayElement<int2>
	|-UnsafeUtility.WriteArrayElement<WordStorage.Entry>
	|
	|-RVA: 0xF72FD0 Offset: 0xF719D0 VA: 0x180F72FD0
	|-UnsafeUtility.WriteArrayElement<double>
	|
	|-RVA: 0xF730D0 Offset: 0xF71AD0 VA: 0x180F730D0
	|-UnsafeUtility.WriteArrayElement<short>
	|-UnsafeUtility.WriteArrayElement<ushort>
	|
	|-RVA: 0xF730E0 Offset: 0xF71AE0 VA: 0x180F730E0
	|-UnsafeUtility.WriteArrayElement<Keyframe>
	|
	|-RVA: 0xF73180 Offset: 0xF71B80 VA: 0x180F73180
	|-UnsafeUtility.WriteArrayElement<Matrix4x4>
	|-UnsafeUtility.WriteArrayElement<Vertex>
	|-UnsafeUtility.WriteArrayElement<float4x4>
	|
	|-RVA: 0xF731B0 Offset: 0xF71BB0 VA: 0x180F731B0
	|-UnsafeUtility.WriteArrayElement<ModifiableContactPair>
	|
	|-RVA: 0xF73200 Offset: 0xF71C00 VA: 0x180F73200
	|-UnsafeUtility.WriteArrayElement<RenderStateBlock>
	|
	|-RVA: 0xF73260 Offset: 0xF71C60 VA: 0x180F73260
	|-UnsafeUtility.WriteArrayElement<float>
	|
	|-RVA: 0xF73270 Offset: 0xF71C70 VA: 0x180F73270
	|-UnsafeUtility.WriteArrayElement<UEncroachingSegment>
	|
	|-RVA: 0xF73290 Offset: 0xF71C90 VA: 0x180F73290
	|-UnsafeUtility.WriteArrayElement<UEvent>
	|-UnsafeUtility.WriteArrayElement<UStar>
	|
	|-RVA: 0xF732B0 Offset: 0xF71CB0 VA: 0x180F732B0
	|-UnsafeUtility.WriteArrayElement<UHull>
	|
	|-RVA: 0xF732F0 Offset: 0xF71CF0 VA: 0x180F732F0
	|-UnsafeUtility.WriteArrayElement<UTriangle>
	|
	|-RVA: 0xF73320 Offset: 0xF71D20 VA: 0x180F73320
	|-UnsafeUtility.WriteArrayElement<Vector3>
	|-UnsafeUtility.WriteArrayElement<Vector3Int>
	|-UnsafeUtility.WriteArrayElement<float3>
	|-UnsafeUtility.WriteArrayElement<int3>
	|
	|-RVA: 0xF73340 Offset: 0xF71D40 VA: 0x180F73340
	|-UnsafeUtility.WriteArrayElement<VisibleLight>
	|
	|-RVA: 0xF733A0 Offset: 0xF71DA0 VA: 0x180F733A0
	|-UnsafeUtility.WriteArrayElement<VisibleReflectionProbe>
	|
	|-RVA: 0xF72FE0 Offset: 0xF719E0 VA: 0x180F72FE0
	|-UnsafeUtility.WriteArrayElement<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xF73150 Offset: 0xF71B50 VA: 0x180F73150
	|-UnsafeUtility.WriteArrayElement<LightUtility.LightMeshVertex>
	|
	|-RVA: 0xF73110 Offset: 0xF71B10 VA: 0x180F73110
	|-UnsafeUtility.WriteArrayElement<ShaderInput.LightData>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF72B00 Offset: 0xF71500 VA: 0x180F72B00
	|-UnsafeUtility.WriteArrayElementWithStride<Color32>
	|-UnsafeUtility.WriteArrayElementWithStride<int>
	|
	|-RVA: 0xF72B10 Offset: 0xF71510 VA: 0x180F72B10
	|-UnsafeUtility.WriteArrayElementWithStride<ConvertMeshJobData>
	|
	|-RVA: 0xF72BA0 Offset: 0xF715A0 VA: 0x180F72BA0
	|-UnsafeUtility.WriteArrayElementWithStride<CopyClosingMeshJobData>
	|-UnsafeUtility.WriteArrayElementWithStride<Transform3x4>
	|
	|-RVA: 0xF72BD0 Offset: 0xF715D0 VA: 0x180F72BD0
	|-UnsafeUtility.WriteArrayElementWithStride<DrawBufferRange>
	|-UnsafeUtility.WriteArrayElementWithStride<GfxUpdateBufferRange>
	|-UnsafeUtility.WriteArrayElementWithStride<JobHandle>
	|-UnsafeUtility.WriteArrayElementWithStride<Vector4>
	|
	|-RVA: 0xF72CE0 Offset: 0xF716E0 VA: 0x180F72CE0
	|-UnsafeUtility.WriteArrayElementWithStride<NudgeJobData>
	|
	|-RVA: 0xF72D50 Offset: 0xF71750 VA: 0x180F72D50
	|-UnsafeUtility.WriteArrayElementWithStride<ushort>
	|
	|-RVA: 0xF72D60 Offset: 0xF71760 VA: 0x180F72D60
	|-UnsafeUtility.WriteArrayElementWithStride<Vector2>
	|
	|-RVA: 0xF72D70 Offset: 0xF71770 VA: 0x180F72D70
	|-UnsafeUtility.WriteArrayElementWithStride<Vector3>
	|
	|-RVA: 0xF72D90 Offset: 0xF71790 VA: 0x180F72D90
	|-UnsafeUtility.WriteArrayElementWithStride<Vertex>
	|
	|-RVA: 0xF72BF0 Offset: 0xF715F0 VA: 0x180F72BF0
	|-UnsafeUtility.WriteArrayElementWithStride<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void* AddressOf<T>(ref T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-UnsafeUtility.AddressOf<UnsafeList<byte>>
	|-UnsafeUtility.AddressOf<UnsafeList<int>>
	|-UnsafeUtility.AddressOf<UnsafeList<IntPtr>>
	|-UnsafeUtility.AddressOf<Bone>
	|-UnsafeUtility.AddressOf<bool>
	|-UnsafeUtility.AddressOf<byte>
	|-UnsafeUtility.AddressOf<Color32>
	|-UnsafeUtility.AddressOf<DeltaStateEvent>
	|-UnsafeUtility.AddressOf<DeviceConfigurationEvent>
	|-UnsafeUtility.AddressOf<DeviceResetEvent>
	|-UnsafeUtility.AddressOf<DisableDeviceCommand>
	|-UnsafeUtility.AddressOf<double>
	|-UnsafeUtility.AddressOf<DualMotorRumbleCommand>
	|-UnsafeUtility.AddressOf<DualSenseHIDUSBOutputReport>
	|-UnsafeUtility.AddressOf<DualShockHIDOutputReport>
	|-UnsafeUtility.AddressOf<EnableDeviceCommand>
	|-UnsafeUtility.AddressOf<EnableIMECompositionCommand>
	|-UnsafeUtility.AddressOf<Eyes>
	|-UnsafeUtility.AddressOf<FixedBytes126>
	|-UnsafeUtility.AddressOf<FixedBytes30>
	|-UnsafeUtility.AddressOf<FixedBytes4094>
	|-UnsafeUtility.AddressOf<FixedBytes510>
	|-UnsafeUtility.AddressOf<FixedBytes62>
	|-UnsafeUtility.AddressOf<FixedString128Bytes>
	|-UnsafeUtility.AddressOf<FixedString32Bytes>
	|-UnsafeUtility.AddressOf<FixedString4096Bytes>
	|-UnsafeUtility.AddressOf<FixedString512Bytes>
	|-UnsafeUtility.AddressOf<FixedString64Bytes>
	|-UnsafeUtility.AddressOf<GetHapticCapabilitiesCommand>
	|-UnsafeUtility.AddressOf<InitiateUserAccountPairingCommand>
	|-UnsafeUtility.AddressOf<InputDeviceCommand>
	|-UnsafeUtility.AddressOf<InputEvent>
	|-UnsafeUtility.AddressOf<int>
	|-UnsafeUtility.AddressOf<Int32Enum>
	|-UnsafeUtility.AddressOf<LightMinMaxZJob>
	|-UnsafeUtility.AddressOf<MouseState>
	|-UnsafeUtility.AddressOf<NativeArrayDisposeJob>
	|-UnsafeUtility.AddressOf<NativeListDisposeJob>
	|-UnsafeUtility.AddressOf<NativeQueueDisposeJob>
	|-UnsafeUtility.AddressOf<NativeReferenceDisposeJob>
	|-UnsafeUtility.AddressOf<PoseState>
	|-UnsafeUtility.AddressOf<PrimitiveValue>
	|-UnsafeUtility.AddressOf<Quaternion>
	|-UnsafeUtility.AddressOf<QueryCanRunInBackground>
	|-UnsafeUtility.AddressOf<QueryEnabledStateCommand>
	|-UnsafeUtility.AddressOf<QueryKeyNameCommand>
	|-UnsafeUtility.AddressOf<QueryKeyboardLayoutCommand>
	|-UnsafeUtility.AddressOf<QueryPairedUserAccountCommand>
	|-UnsafeUtility.AddressOf<QuerySamplingFrequencyCommand>
	|-UnsafeUtility.AddressOf<ReflectionProbeMinMaxZJob>
	|-UnsafeUtility.AddressOf<RequestResetCommand>
	|-UnsafeUtility.AddressOf<RequestSyncCommand>
	|-UnsafeUtility.AddressOf<SendBufferedHapticCommand>
	|-UnsafeUtility.AddressOf<SendHapticImpulseCommand>
	|-UnsafeUtility.AddressOf<SetIMECursorPositionCommand>
	|-UnsafeUtility.AddressOf<SetSamplingFrequencyCommand>
	|-UnsafeUtility.AddressOf<float>
	|-UnsafeUtility.AddressOf<StateEvent>
	|-UnsafeUtility.AddressOf<TextEvent>
	|-UnsafeUtility.AddressOf<TileRangeExpansionJob>
	|-UnsafeUtility.AddressOf<TilingJob>
	|-UnsafeUtility.AddressOf<TouchState>
	|-UnsafeUtility.AddressOf<uint>
	|-UnsafeUtility.AddressOf<ulong>
	|-UnsafeUtility.AddressOf<UnsafeDisposeJob>
	|-UnsafeUtility.AddressOf<UnsafeList>
	|-UnsafeUtility.AddressOf<UnsafeParallelHashMapDataDisposeJob>
	|-UnsafeUtility.AddressOf<UnsafeParallelHashMapDisposeJob>
	|-UnsafeUtility.AddressOf<UnsafePtrList>
	|-UnsafeUtility.AddressOf<Vector2>
	|-UnsafeUtility.AddressOf<Vector3>
	|-UnsafeUtility.AddressOf<WarpMousePositionCommand>
	|-UnsafeUtility.AddressOf<ZBinningJob>
	|-UnsafeUtility.AddressOf<__Il2CppFullySharedGenericStructType>
	|-UnsafeUtility.AddressOf<DecalCreateDrawCallSystem.DrawCallJob>
	|-UnsafeUtility.AddressOf<DecalUpdateCachedSystem.UpdateTransformsJob>
	|-UnsafeUtility.AddressOf<NativeStream.ConstructJob>
	|-UnsafeUtility.AddressOf<NativeStream.ConstructJobList>
	|-UnsafeUtility.AddressOf<OpacityIdAccelerator.OpacityIdUpdateJob>
	|-UnsafeUtility.AddressOf<SwitchProControllerHID.SwitchMagicOutputHIDBluetooth>
	|-UnsafeUtility.AddressOf<SwitchProControllerHID.SwitchMagicOutputHIDUSB>
	|-UnsafeUtility.AddressOf<UnsafeStream.ConstructJob>
	|-UnsafeUtility.AddressOf<UnsafeStream.ConstructJobList>
	|-UnsafeUtility.AddressOf<UnsafeStream.DisposeJob>
	|-UnsafeUtility.AddressOf<xxHash3.StreamingState.StreamingStateData>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB648E0 Offset: 0xB632E0 VA: 0x180B648E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeList<byte>>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeList<int>>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeList<IntPtr>>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<NativeQueueData>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeText>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightUtility.LightMeshVertex>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RewindableAllocator.MemoryBlock>>
	|-UnsafeUtility.SizeOf<ContactPairHeader>
	|
	|-RVA: 0xF728A0 Offset: 0xF712A0 VA: 0x180F728A0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<AttachmentDescriptor>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<NudgeJobData>>
	|-UnsafeUtility.SizeOf<ShaderVariablesProbeVolumes>
	|
	|-RVA: 0xF728B0 Offset: 0xF712B0 VA: 0x180F728B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchCullingOutputDrawCommands>>
	|-UnsafeUtility.SizeOf<Matrix4x4>
	|-UnsafeUtility.SizeOf<Vertex>
	|-UnsafeUtility.SizeOf<float4x4>
	|
	|-RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<bool>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|-UnsafeUtility.SizeOf<short>
	|-UnsafeUtility.SizeOf<ushort>
	|
	|-RVA: 0xAC9260 Offset: 0xAC7C60 VA: 0x180AC9260
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoundingSphere>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<DrawBufferRange>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Quaternion>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector4>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float4>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int4>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<quaternion>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ProbeBrickIndex.Brick>>
	|-UnsafeUtility.SizeOf<InputEvent>
	|-UnsafeUtility.SizeOf<UEncroachingSegment>
	|
	|-RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color32>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Int32Enum>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ShaderTagId>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|-UnsafeUtility.SizeOf<DecalEntity>
	|-UnsafeUtility.SizeOf<DecalSubDrawCall>
	|-UnsafeUtility.SizeOf<double>
	|-UnsafeUtility.SizeOf<IntPtr>
	|-UnsafeUtility.SizeOf<ulong>
	|-UnsafeUtility.SizeOf<Vector2>
	|-UnsafeUtility.SizeOf<float2>
	|-UnsafeUtility.SizeOf<int2>
	|-UnsafeUtility.SizeOf<WordStorage.Entry>
	|
	|-RVA: 0xF72880 Offset: 0xF71280 VA: 0x180F72880
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ContactPairHeader>>
	|-UnsafeUtility.SizeOf<CopyClosingMeshJobData>
	|-UnsafeUtility.SizeOf<Transform3x4>
	|-UnsafeUtility.SizeOf<UnsafeStreamBlockData>
	|
	|-RVA: 0xF72920 Offset: 0xF71320 VA: 0x180F72920
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ConvertMeshJobData>>
	|
	|-RVA: 0xF728E0 Offset: 0xF712E0 VA: 0x180F728E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<CopyClosingMeshJobData>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UTriangle>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeStreamBlockData>>
	|-UnsafeUtility.SizeOf<BatchCullingOutputDrawCommands>
	|-UnsafeUtility.SizeOf<TouchState>
	|
	|-RVA: 0xF72900 Offset: 0xF71300 VA: 0x180F72900
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<CullingSplit>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<TileData>>
	|
	|-RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<DecalEntity>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<DecalSubDrawCall>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector2>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float2>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int2>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<WordStorage.Entry>>
	|-UnsafeUtility.SizeOf<Vector3>
	|-UnsafeUtility.SizeOf<Vector3Int>
	|-UnsafeUtility.SizeOf<float3>
	|-UnsafeUtility.SizeOf<int3>
	|-UnsafeUtility.SizeOf<Touch.ExtraDataPerTouchState>
	|
	|-RVA: 0xF72850 Offset: 0xF71250 VA: 0x180F72850
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<GfxUpdateBufferRange>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<NativeQueueBlockHeader>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UEncroachingSegment>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeStreamBlock>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<double2>>
	|-UnsafeUtility.SizeOf<NativeQueueBlockPoolData>
	|-UnsafeUtility.SizeOf<UEvent>
	|-UnsafeUtility.SizeOf<UStar>
	|-UnsafeUtility.SizeOf<UnsafeList>
	|-UnsafeUtility.SizeOf<UnsafePtrList>
	|-UnsafeUtility.SizeOf<UnsafeStreamRange>
	|
	|-RVA: 0x681E20 Offset: 0x680820 VA: 0x180681E20
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<InclusiveRange>>
	|
	|-RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<short>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ushort>>
	|-UnsafeUtility.SizeOf<Color32>
	|-UnsafeUtility.SizeOf<InclusiveRange>
	|-UnsafeUtility.SizeOf<int>
	|-UnsafeUtility.SizeOf<Int32Enum>
	|-UnsafeUtility.SizeOf<ShaderTagId>
	|-UnsafeUtility.SizeOf<float>
	|-UnsafeUtility.SizeOf<uint>
	|
	|-RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<IntPtr>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ulong>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3Int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int3>>
	|-UnsafeUtility.SizeOf<BoundingSphere>
	|-UnsafeUtility.SizeOf<Color>
	|-UnsafeUtility.SizeOf<DrawBufferRange>
	|-UnsafeUtility.SizeOf<GfxUpdateBufferRange>
	|-UnsafeUtility.SizeOf<JobHandle>
	|-UnsafeUtility.SizeOf<NativeQueueBlockHeader>
	|-UnsafeUtility.SizeOf<Plane>
	|-UnsafeUtility.SizeOf<Quaternion>
	|-UnsafeUtility.SizeOf<UnsafeStreamBlock>
	|-UnsafeUtility.SizeOf<Vector4>
	|-UnsafeUtility.SizeOf<double2>
	|-UnsafeUtility.SizeOf<float4>
	|-UnsafeUtility.SizeOf<int4>
	|-UnsafeUtility.SizeOf<quaternion>
	|-UnsafeUtility.SizeOf<ProbeBrickIndex.Brick>
	|
	|-RVA: 0xF72870 Offset: 0xF71270 VA: 0x180F72870
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Keyframe>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<NativeQueueBlockPoolData>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UStar>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeList>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafePtrList>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeStreamRange>>
	|-UnsafeUtility.SizeOf<UnsafeList<byte>>
	|-UnsafeUtility.SizeOf<UnsafeList<int>>
	|-UnsafeUtility.SizeOf<UnsafeList<IntPtr>>
	|-UnsafeUtility.SizeOf<Bone>
	|-UnsafeUtility.SizeOf<NativeQueueData>
	|-UnsafeUtility.SizeOf<UnsafeText>
	|-UnsafeUtility.SizeOf<RewindableAllocator.MemoryBlock>
	|
	|-RVA: 0xF728C0 Offset: 0xF712C0 VA: 0x180F728C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Matrix4x4>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vertex>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float4x4>>
	|
	|-RVA: 0xF72930 Offset: 0xF71330 VA: 0x180F72930
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ModifiableContactPair>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RenderStateBlock>>
	|
	|-RVA: 0xF728D0 Offset: 0xF712D0 VA: 0x180F728D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Transform3x4>>
	|-UnsafeUtility.SizeOf<UTriangle>
	|
	|-RVA: 0xF72860 Offset: 0xF71260 VA: 0x180F72860
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UEvent>>
	|-UnsafeUtility.SizeOf<Keyframe>
	|-UnsafeUtility.SizeOf<BlitUtility.Vertex>
	|
	|-RVA: 0xF72940 Offset: 0xF71340 VA: 0x180F72940
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UHull>>
	|
	|-RVA: 0xF72890 Offset: 0xF71290 VA: 0x180F72890
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<UnsafeParallelHashMapData>>
	|
	|-RVA: 0xF72950 Offset: 0xF71350 VA: 0x180F72950
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<VisibleLight>>
	|-UnsafeUtility.SizeOf<AttachmentDescriptor>
	|-UnsafeUtility.SizeOf<NudgeJobData>
	|
	|-RVA: 0xF728F0 Offset: 0xF712F0 VA: 0x180F728F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<VisibleReflectionProbe>>
	|
	|-RVA: 0xF72910 Offset: 0xF71310 VA: 0x180F72910
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ShaderInput.LightData>>
	|
	|-RVA: 0xF72960 Offset: 0xF71360 VA: 0x180F72960
	|-UnsafeUtility.SizeOf<AllocatorManager.Array32768<AllocatorManager.TableEntry>>
	|
	|-RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	|-UnsafeUtility.SizeOf<bool>
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0xF72970 Offset: 0xF71370 VA: 0x180F72970
	|-UnsafeUtility.SizeOf<ConvertMeshJobData>
	|
	|-RVA: 0xF72980 Offset: 0xF71380 VA: 0x180F72980
	|-UnsafeUtility.SizeOf<CullingSplit>
	|-UnsafeUtility.SizeOf<LightDataGI>
	|-UnsafeUtility.SizeOf<TileData>
	|
	|-RVA: 0xF72990 Offset: 0xF71390 VA: 0x180F72990
	|-UnsafeUtility.SizeOf<DeltaStateEvent>
	|
	|-RVA: 0xF729A0 Offset: 0xF713A0 VA: 0x180F729A0
	|-UnsafeUtility.SizeOf<Eyes>
	|
	|-RVA: 0xF729B0 Offset: 0xF713B0 VA: 0x180F729B0
	|-UnsafeUtility.SizeOf<FixedBytes126>
	|
	|-RVA: 0xF729C0 Offset: 0xF713C0 VA: 0x180F729C0
	|-UnsafeUtility.SizeOf<FixedBytes30>
	|-UnsafeUtility.SizeOf<MouseState>
	|
	|-RVA: 0xF729D0 Offset: 0xF713D0 VA: 0x180F729D0
	|-UnsafeUtility.SizeOf<FixedBytes4094>
	|
	|-RVA: 0xF729E0 Offset: 0xF713E0 VA: 0x180F729E0
	|-UnsafeUtility.SizeOf<FixedBytes510>
	|
	|-RVA: 0xF729F0 Offset: 0xF713F0 VA: 0x180F729F0
	|-UnsafeUtility.SizeOf<FixedBytes62>
	|
	|-RVA: 0xF72A60 Offset: 0xF71460 VA: 0x180F72A60
	|-UnsafeUtility.SizeOf<Long1024>
	|
	|-RVA: 0xF72A70 Offset: 0xF71470 VA: 0x180F72A70
	|-UnsafeUtility.SizeOf<ModifiableContactPair>
	|
	|-RVA: 0xF72A80 Offset: 0xF71480 VA: 0x180F72A80
	|-UnsafeUtility.SizeOf<PoseState>
	|
	|-RVA: 0xF72A90 Offset: 0xF71490 VA: 0x180F72A90
	|-UnsafeUtility.SizeOf<RenderStateBlock>
	|
	|-RVA: 0xF72AA0 Offset: 0xF714A0 VA: 0x180F72AA0
	|-UnsafeUtility.SizeOf<StateEvent>
	|
	|-RVA: 0xF72AC0 Offset: 0xF714C0 VA: 0x180F72AC0
	|-UnsafeUtility.SizeOf<UHull>
	|
	|-RVA: 0xF72AD0 Offset: 0xF714D0 VA: 0x180F72AD0
	|-UnsafeUtility.SizeOf<UnsafeParallelHashMapData>
	|
	|-RVA: 0xF72AE0 Offset: 0xF714E0 VA: 0x180F72AE0
	|-UnsafeUtility.SizeOf<VisibleLight>
	|
	|-RVA: 0xF72AF0 Offset: 0xF714F0 VA: 0x180F72AF0
	|-UnsafeUtility.SizeOf<VisibleReflectionProbe>
	|
	|-RVA: 0xF6D3F0 Offset: 0xF6BDF0 VA: 0x180F6D3F0
	|-UnsafeUtility.SizeOf<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xF72A00 Offset: 0xF71400 VA: 0x180F72A00
	|-UnsafeUtility.SizeOf<Hammersley.Hammersley2dSeq16>
	|
	|-RVA: 0xF72A10 Offset: 0xF71410 VA: 0x180F72A10
	|-UnsafeUtility.SizeOf<Hammersley.Hammersley2dSeq256>
	|
	|-RVA: 0xF72A20 Offset: 0xF71420 VA: 0x180F72A20
	|-UnsafeUtility.SizeOf<Hammersley.Hammersley2dSeq32>
	|
	|-RVA: 0xF72A30 Offset: 0xF71430 VA: 0x180F72A30
	|-UnsafeUtility.SizeOf<Hammersley.Hammersley2dSeq64>
	|
	|-RVA: 0xA02640 Offset: 0xA01040 VA: 0x180A02640
	|-UnsafeUtility.SizeOf<InputDevice.ControlBitRangeNode>
	|
	|-RVA: 0xF72A50 Offset: 0xF71450 VA: 0x180F72A50
	|-UnsafeUtility.SizeOf<LightUtility.LightMeshVertex>
	|
	|-RVA: 0xF72A40 Offset: 0xF71440 VA: 0x180F72A40
	|-UnsafeUtility.SizeOf<ShaderInput.LightData>
	|
	|-RVA: 0xF72AB0 Offset: 0xF714B0 VA: 0x180F72AB0
	|-UnsafeUtility.SizeOf<xxHash3.StreamingState.StreamingStateData>
	*/

	// RVA: -1 Offset: -1
	public static ref T As<U, T>(ref U from) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-UnsafeUtility.As<double, double>
	|-UnsafeUtility.As<double, int>
	|-UnsafeUtility.As<double, long>
	|-UnsafeUtility.As<double, float>
	|-UnsafeUtility.As<double, ulong>
	|-UnsafeUtility.As<int, double>
	|-UnsafeUtility.As<int, long>
	|-UnsafeUtility.As<int, ulong>
	|-UnsafeUtility.As<long, double>
	|-UnsafeUtility.As<long, int>
	|-UnsafeUtility.As<long, long>
	|-UnsafeUtility.As<long, float>
	|-UnsafeUtility.As<long, ulong>
	|-UnsafeUtility.As<float, double>
	|-UnsafeUtility.As<float, long>
	|-UnsafeUtility.As<float, ulong>
	|-UnsafeUtility.As<ulong, double>
	|-UnsafeUtility.As<ulong, int>
	|-UnsafeUtility.As<ulong, long>
	|-UnsafeUtility.As<ulong, float>
	|-UnsafeUtility.As<ulong, ulong>
	|-UnsafeUtility.As<UnsafePtrList, UnsafeList>
	|-UnsafeUtility.As<UntypedUnsafeList, UnsafeList<byte>>
	|-UnsafeUtility.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	|-UnsafeUtility.AsRef<FixedList128Bytes<byte>>
	|-UnsafeUtility.AsRef<FixedList32Bytes<byte>>
	|-UnsafeUtility.AsRef<FixedList4096Bytes<byte>>
	|-UnsafeUtility.AsRef<FixedList512Bytes<byte>>
	|-UnsafeUtility.AsRef<FixedList64Bytes<byte>>
	|-UnsafeUtility.AsRef<int>
	|-UnsafeUtility.AsRef<long>
	|-UnsafeUtility.AsRef<IntPtr>
	|-UnsafeUtility.AsRef<__Il2CppFullySharedGenericStructType>
	|-UnsafeUtility.AsRef<AllocatorManager.TableEntry>
	|-UnsafeUtility.AsRef<BuddyAllocator.Header>
	*/

	// RVA: -1 Offset: -1
	public static ref T ArrayElementAsRef<T>(void* ptr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C650 Offset: 0xF6B050 VA: 0x180F6C650
	|-UnsafeUtility.ArrayElementAsRef<byte>
	|
	|-RVA: 0xF6C6B0 Offset: 0xF6B0B0 VA: 0x180F6C6B0
	|-UnsafeUtility.ArrayElementAsRef<int>
	|-UnsafeUtility.ArrayElementAsRef<float>
	|
	|-RVA: 0xF6C6C0 Offset: 0xF6B0C0 VA: 0x180F6C6C0
	|-UnsafeUtility.ArrayElementAsRef<VisibleLight>
	|
	|-RVA: 0xF6C660 Offset: 0xF6B060 VA: 0x180F6C660
	|-UnsafeUtility.ArrayElementAsRef<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C900 Offset: 0xF6B300 VA: 0x180F6C900
	|-UnsafeUtility.EnumToInt<Int32Enum>
	|
	|-RVA: 0xF6C8B0 Offset: 0xF6B2B0 VA: 0x180F6C8B0
	|-UnsafeUtility.EnumToInt<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C9E0 Offset: 0xF6B3E0 VA: 0x180F6C9E0
	|-UnsafeUtility.InternalEnumToInt<Int32Enum>
	|-UnsafeUtility.InternalEnumToInt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool EnumEquals<T>(T lhs, T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	|-UnsafeUtility.EnumEquals<Int32Enum>
	|
	|-RVA: 0xF6C790 Offset: 0xF6B190 VA: 0x180F6C790
	|-UnsafeUtility.EnumEquals<__Il2CppFullySharedGenericStructType>
	*/
}
