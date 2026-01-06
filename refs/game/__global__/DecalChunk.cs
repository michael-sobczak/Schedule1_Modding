internal abstract class DecalChunk : IDisposable // TypeDefIndex: 8837
{
	// Fields
	[CompilerGenerated]
	private int <count>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <capacity>k__BackingField; // 0x14
	[CompilerGenerated]
	private JobHandle <currentJobHandle>k__BackingField; // 0x18

	// Properties
	public int count { get; set; }
	public int capacity { get; set; }
	public JobHandle currentJobHandle { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_count() { }

	[CompilerGenerated]
	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	protected void set_count(int value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_capacity() { }

	[CompilerGenerated]
	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	protected void set_capacity(int value) { }

	[CompilerGenerated]
	// RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	public JobHandle get_currentJobHandle() { }

	[CompilerGenerated]
	// RVA: 0x691670 Offset: 0x690070 VA: 0x180691670
	public void set_currentJobHandle(JobHandle value) { }

	// RVA: 0xB49A10 Offset: 0xB48410 VA: 0x180B49A10 Slot: 5
	public virtual void Push() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void RemoveAtSwapBack(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetCapacity(int capacity);

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public virtual void Dispose() { }

	// RVA: 0x2ADFCA0 Offset: 0x2ADE6A0 VA: 0x182ADFCA0
	protected void ResizeNativeArray(ref TransformAccessArray array, DecalProjector[] decalProjectors, int capacity) { }

	// RVA: -1 Offset: -1
	protected void RemoveAtSwapBack<T>(ref NativeArray<T> array, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE79EA0 Offset: 0xE788A0 VA: 0x180E79EA0
	|-DecalChunk.RemoveAtSwapBack<bool>
	|
	|-RVA: 0xE79EC0 Offset: 0xE788C0 VA: 0x180E79EC0
	|-DecalChunk.RemoveAtSwapBack<BoundingSphere>
	|-DecalChunk.RemoveAtSwapBack<float4>
	|-DecalChunk.RemoveAtSwapBack<quaternion>
	|
	|-RVA: 0xE79F30 Offset: 0xE78930 VA: 0x180E79F30
	|-DecalChunk.RemoveAtSwapBack<DecalEntity>
	|-DecalChunk.RemoveAtSwapBack<DecalSubDrawCall>
	|-DecalChunk.RemoveAtSwapBack<ulong>
	|
	|-RVA: 0xE7A180 Offset: 0xE78B80 VA: 0x180E7A180
	|-DecalChunk.RemoveAtSwapBack<int>
	|-DecalChunk.RemoveAtSwapBack<Int32Enum>
	|-DecalChunk.RemoveAtSwapBack<float>
	|-DecalChunk.RemoveAtSwapBack<uint>
	|
	|-RVA: 0xE7A090 Offset: 0xE78A90 VA: 0x180E7A090
	|-DecalChunk.RemoveAtSwapBack<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xE7A230 Offset: 0xE78C30 VA: 0x180E7A230
	|-DecalChunk.RemoveAtSwapBack<float2>
	|
	|-RVA: 0xE7A260 Offset: 0xE78C60 VA: 0x180E7A260
	|-DecalChunk.RemoveAtSwapBack<float3>
	|
	|-RVA: 0xE7A290 Offset: 0xE78C90 VA: 0x180E7A290
	|-DecalChunk.RemoveAtSwapBack<float4x4>
	*/

	// RVA: -1 Offset: -1
	protected void RemoveAtSwapBack<T>(ref T[] array, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE79EE0 Offset: 0xE788E0 VA: 0x180E79EE0
	|-DecalChunk.RemoveAtSwapBack<BoundingSphere>
	|
	|-RVA: 0xE7A1A0 Offset: 0xE78BA0 VA: 0x180E7A1A0
	|-DecalChunk.RemoveAtSwapBack<int>
	|
	|-RVA: 0xE7A1E0 Offset: 0xE78BE0 VA: 0x180E7A1E0
	|-DecalChunk.RemoveAtSwapBack<object>
	|
	|-RVA: 0xE79F50 Offset: 0xE78950 VA: 0x180E79F50
	|-DecalChunk.RemoveAtSwapBack<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
