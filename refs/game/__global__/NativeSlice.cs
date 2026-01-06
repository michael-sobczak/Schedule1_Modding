public struct NativeSlice.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 11539
{
	// Fields
	private NativeSlice<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeSlice<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16666E0 Offset: 0x16650E0 VA: 0x1816666E0
	|-NativeSlice.Enumerator<Color32>..ctor
	|-NativeSlice.Enumerator<ConvertMeshJobData>..ctor
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>..ctor
	|-NativeSlice.Enumerator<DrawBufferRange>..ctor
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>..ctor
	|-NativeSlice.Enumerator<JobHandle>..ctor
	|-NativeSlice.Enumerator<NudgeJobData>..ctor
	|-NativeSlice.Enumerator<Transform3x4>..ctor
	|-NativeSlice.Enumerator<ushort>..ctor
	|-NativeSlice.Enumerator<Vector2>..ctor
	|-NativeSlice.Enumerator<Vector3>..ctor
	|-NativeSlice.Enumerator<Vector4>..ctor
	|-NativeSlice.Enumerator<Vertex>..ctor
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-NativeSlice.Enumerator<Color32>.Dispose
	|-NativeSlice.Enumerator<ConvertMeshJobData>.Dispose
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.Dispose
	|-NativeSlice.Enumerator<DrawBufferRange>.Dispose
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.Dispose
	|-NativeSlice.Enumerator<JobHandle>.Dispose
	|-NativeSlice.Enumerator<NudgeJobData>.Dispose
	|-NativeSlice.Enumerator<Transform3x4>.Dispose
	|-NativeSlice.Enumerator<ushort>.Dispose
	|-NativeSlice.Enumerator<Vector2>.Dispose
	|-NativeSlice.Enumerator<Vector3>.Dispose
	|-NativeSlice.Enumerator<Vector4>.Dispose
	|-NativeSlice.Enumerator<Vertex>.Dispose
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663000 Offset: 0x1661A00 VA: 0x181663000
	|-NativeSlice.Enumerator<Color32>.MoveNext
	|-NativeSlice.Enumerator<ConvertMeshJobData>.MoveNext
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.MoveNext
	|-NativeSlice.Enumerator<DrawBufferRange>.MoveNext
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.MoveNext
	|-NativeSlice.Enumerator<JobHandle>.MoveNext
	|-NativeSlice.Enumerator<NudgeJobData>.MoveNext
	|-NativeSlice.Enumerator<Transform3x4>.MoveNext
	|-NativeSlice.Enumerator<ushort>.MoveNext
	|-NativeSlice.Enumerator<Vector2>.MoveNext
	|-NativeSlice.Enumerator<Vector3>.MoveNext
	|-NativeSlice.Enumerator<Vector4>.MoveNext
	|-NativeSlice.Enumerator<Vertex>.MoveNext
	|
	|-RVA: 0x16725E0 Offset: 0x1670FE0 VA: 0x1816725E0
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663BF0 Offset: 0x16625F0 VA: 0x181663BF0
	|-NativeSlice.Enumerator<Color32>.Reset
	|-NativeSlice.Enumerator<ConvertMeshJobData>.Reset
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.Reset
	|-NativeSlice.Enumerator<DrawBufferRange>.Reset
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.Reset
	|-NativeSlice.Enumerator<JobHandle>.Reset
	|-NativeSlice.Enumerator<NudgeJobData>.Reset
	|-NativeSlice.Enumerator<Transform3x4>.Reset
	|-NativeSlice.Enumerator<ushort>.Reset
	|-NativeSlice.Enumerator<Vector2>.Reset
	|-NativeSlice.Enumerator<Vector3>.Reset
	|-NativeSlice.Enumerator<Vector4>.Reset
	|-NativeSlice.Enumerator<Vertex>.Reset
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1667230 Offset: 0x1665C30 VA: 0x181667230
	|-NativeSlice.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x1667430 Offset: 0x1665E30 VA: 0x181667430
	|-NativeSlice.Enumerator<ConvertMeshJobData>.get_Current
	|
	|-RVA: 0x1667280 Offset: 0x1665C80 VA: 0x181667280
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.get_Current
	|-NativeSlice.Enumerator<Transform3x4>.get_Current
	|
	|-RVA: 0x166C500 Offset: 0x166AF00 VA: 0x18166C500
	|-NativeSlice.Enumerator<DrawBufferRange>.get_Current
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.get_Current
	|-NativeSlice.Enumerator<JobHandle>.get_Current
	|-NativeSlice.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x166CC50 Offset: 0x166B650 VA: 0x18166CC50
	|-NativeSlice.Enumerator<NudgeJobData>.get_Current
	|
	|-RVA: 0x16711B0 Offset: 0x166FBB0 VA: 0x1816711B0
	|-NativeSlice.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x1671010 Offset: 0x166FA10 VA: 0x181671010
	|-NativeSlice.Enumerator<Vector2>.get_Current
	|
	|-RVA: 0x1671060 Offset: 0x166FA60 VA: 0x181671060
	|-NativeSlice.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x1670EB0 Offset: 0x166F8B0 VA: 0x181670EB0
	|-NativeSlice.Enumerator<Vertex>.get_Current
	|
	|-RVA: 0x167C0B0 Offset: 0x167AAB0 VA: 0x18167C0B0
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1664EE0 Offset: 0x16638E0 VA: 0x181664EE0
	|-NativeSlice.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1665780 Offset: 0x1664180 VA: 0x181665780
	|-NativeSlice.Enumerator<ConvertMeshJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1664D30 Offset: 0x1663730 VA: 0x181664D30
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.System.Collections.IEnumerator.get_Current
	|-NativeSlice.Enumerator<Transform3x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166ACD0 Offset: 0x16696D0 VA: 0x18166ACD0
	|-NativeSlice.Enumerator<DrawBufferRange>.System.Collections.IEnumerator.get_Current
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.System.Collections.IEnumerator.get_Current
	|-NativeSlice.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A6A0 Offset: 0x16690A0 VA: 0x18166A6A0
	|-NativeSlice.Enumerator<NudgeJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166FDE0 Offset: 0x166E7E0 VA: 0x18166FDE0
	|-NativeSlice.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166F330 Offset: 0x166DD30 VA: 0x18166F330
	|-NativeSlice.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166FF20 Offset: 0x166E920 VA: 0x18166FF20
	|-NativeSlice.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1670110 Offset: 0x166EB10 VA: 0x181670110
	|-NativeSlice.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166F560 Offset: 0x166DF60 VA: 0x18166F560
	|-NativeSlice.Enumerator<Vertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1677330 Offset: 0x1675D30 VA: 0x181677330
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}
