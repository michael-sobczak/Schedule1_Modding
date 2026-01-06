public struct NativeSlice<T> : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice<T>> // TypeDefIndex: 11540
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal byte* m_Buffer; // 0x0
	internal int m_Stride; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public T Item { get; set; }
	public int Stride { get; }
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeSlice<T> slice, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1093CC0 Offset: 0x10926C0 VA: 0x181093CC0
	|-NativeSlice<Color32>..ctor
	|-NativeSlice<ConvertMeshJobData>..ctor
	|-NativeSlice<CopyClosingMeshJobData>..ctor
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<NudgeJobData>..ctor
	|-NativeSlice<Transform3x4>..ctor
	|-NativeSlice<ushort>..ctor
	|-NativeSlice<Vector2>..ctor
	|-NativeSlice<Vector3>..ctor
	|-NativeSlice<Vector4>..ctor
	|-NativeSlice<Vertex>..ctor
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10941B0 Offset: 0x1092BB0 VA: 0x1810941B0
	|-NativeSlice<Color32>..ctor
	|
	|-RVA: 0x1094220 Offset: 0x1092C20 VA: 0x181094220
	|-NativeSlice<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x1093DC0 Offset: 0x10927C0 VA: 0x181093DC0
	|-NativeSlice<CopyClosingMeshJobData>..ctor
	|-NativeSlice<Transform3x4>..ctor
	|
	|-RVA: 0x1093CE0 Offset: 0x10926E0 VA: 0x181093CE0
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<Vector4>..ctor
	|
	|-RVA: 0x1093FF0 Offset: 0x10929F0 VA: 0x181093FF0
	|-NativeSlice<NudgeJobData>..ctor
	|
	|-RVA: 0x1093D50 Offset: 0x1092750 VA: 0x181093D50
	|-NativeSlice<ushort>..ctor
	|
	|-RVA: 0x1093F80 Offset: 0x1092980 VA: 0x181093F80
	|-NativeSlice<Vector2>..ctor
	|
	|-RVA: 0x1093F10 Offset: 0x1092910 VA: 0x181093F10
	|-NativeSlice<Vector3>..ctor
	|
	|-RVA: 0x1096690 Offset: 0x1095090 VA: 0x181096690
	|-NativeSlice<Vertex>..ctor
	|
	|-RVA: 0x10967A0 Offset: 0x10951A0 VA: 0x1810967A0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static NativeSlice<T> op_Implicit(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1094990 Offset: 0x1093390 VA: 0x181094990
	|-NativeSlice<Color32>.op_Implicit
	|
	|-RVA: 0x1094C50 Offset: 0x1093650 VA: 0x181094C50
	|-NativeSlice<ConvertMeshJobData>.op_Implicit
	|
	|-RVA: 0x1094A40 Offset: 0x1093440 VA: 0x181094A40
	|-NativeSlice<CopyClosingMeshJobData>.op_Implicit
	|-NativeSlice<Transform3x4>.op_Implicit
	|
	|-RVA: 0x1094AF0 Offset: 0x10934F0 VA: 0x181094AF0
	|-NativeSlice<DrawBufferRange>.op_Implicit
	|-NativeSlice<GfxUpdateBufferRange>.op_Implicit
	|-NativeSlice<JobHandle>.op_Implicit
	|-NativeSlice<Vector4>.op_Implicit
	|
	|-RVA: 0x1094830 Offset: 0x1093230 VA: 0x181094830
	|-NativeSlice<NudgeJobData>.op_Implicit
	|
	|-RVA: 0x10948E0 Offset: 0x10932E0 VA: 0x1810948E0
	|-NativeSlice<ushort>.op_Implicit
	|
	|-RVA: 0x1094780 Offset: 0x1093180 VA: 0x181094780
	|-NativeSlice<Vector2>.op_Implicit
	|
	|-RVA: 0x1094BA0 Offset: 0x10935A0 VA: 0x181094BA0
	|-NativeSlice<Vector3>.op_Implicit
	|
	|-RVA: 0x1096A80 Offset: 0x1095480 VA: 0x181096A80
	|-NativeSlice<Vertex>.op_Implicit
	|
	|-RVA: 0x1096B30 Offset: 0x1095530 VA: 0x181096B30
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1094060 Offset: 0x1092A60 VA: 0x181094060
	|-NativeSlice<Color32>..ctor
	|
	|-RVA: 0x1094300 Offset: 0x1092D00 VA: 0x181094300
	|-NativeSlice<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x1094140 Offset: 0x1092B40 VA: 0x181094140
	|-NativeSlice<CopyClosingMeshJobData>..ctor
	|-NativeSlice<Transform3x4>..ctor
	|
	|-RVA: 0x1093C50 Offset: 0x1092650 VA: 0x181093C50
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<Vector4>..ctor
	|
	|-RVA: 0x10940D0 Offset: 0x1092AD0 VA: 0x1810940D0
	|-NativeSlice<NudgeJobData>..ctor
	|
	|-RVA: 0x1093EA0 Offset: 0x10928A0 VA: 0x181093EA0
	|-NativeSlice<ushort>..ctor
	|
	|-RVA: 0x1094290 Offset: 0x1092C90 VA: 0x181094290
	|-NativeSlice<Vector2>..ctor
	|
	|-RVA: 0x1093E30 Offset: 0x1092830 VA: 0x181093E30
	|-NativeSlice<Vector3>..ctor
	|
	|-RVA: 0x1096620 Offset: 0x1095020 VA: 0x181096620
	|-NativeSlice<Vertex>..ctor
	|
	|-RVA: 0x1096700 Offset: 0x1095100 VA: 0x181096700
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1094720 Offset: 0x1093120 VA: 0x181094720
	|-NativeSlice<Color32>.get_Item
	|
	|-RVA: 0x1094430 Offset: 0x1092E30 VA: 0x181094430
	|-NativeSlice<ConvertMeshJobData>.get_Item
	|
	|-RVA: 0x1094570 Offset: 0x1092F70 VA: 0x181094570
	|-NativeSlice<CopyClosingMeshJobData>.get_Item
	|-NativeSlice<Transform3x4>.get_Item
	|
	|-RVA: 0x10943D0 Offset: 0x1092DD0 VA: 0x1810943D0
	|-NativeSlice<DrawBufferRange>.get_Item
	|-NativeSlice<GfxUpdateBufferRange>.get_Item
	|-NativeSlice<JobHandle>.get_Item
	|-NativeSlice<Vector4>.get_Item
	|
	|-RVA: 0x1094660 Offset: 0x1093060 VA: 0x181094660
	|-NativeSlice<NudgeJobData>.get_Item
	|
	|-RVA: 0x1094520 Offset: 0x1092F20 VA: 0x181094520
	|-NativeSlice<ushort>.get_Item
	|
	|-RVA: 0x1094370 Offset: 0x1092D70 VA: 0x181094370
	|-NativeSlice<Vector2>.get_Item
	|
	|-RVA: 0x10945F0 Offset: 0x1092FF0 VA: 0x1810945F0
	|-NativeSlice<Vector3>.get_Item
	|
	|-RVA: 0x1096890 Offset: 0x1095290 VA: 0x181096890
	|-NativeSlice<Vertex>.get_Item
	|
	|-RVA: 0x1096920 Offset: 0x1095320 VA: 0x181096920
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1094FF0 Offset: 0x10939F0 VA: 0x181094FF0
	|-NativeSlice<Color32>.set_Item
	|
	|-RVA: 0x1094F30 Offset: 0x1093930 VA: 0x181094F30
	|-NativeSlice<ConvertMeshJobData>.set_Item
	|
	|-RVA: 0x1094E20 Offset: 0x1093820 VA: 0x181094E20
	|-NativeSlice<CopyClosingMeshJobData>.set_Item
	|-NativeSlice<Transform3x4>.set_Item
	|
	|-RVA: 0x1094D00 Offset: 0x1093700 VA: 0x181094D00
	|-NativeSlice<DrawBufferRange>.set_Item
	|-NativeSlice<GfxUpdateBufferRange>.set_Item
	|-NativeSlice<JobHandle>.set_Item
	|-NativeSlice<Vector4>.set_Item
	|
	|-RVA: 0x1094E90 Offset: 0x1093890 VA: 0x181094E90
	|-NativeSlice<NudgeJobData>.set_Item
	|
	|-RVA: 0x1094D60 Offset: 0x1093760 VA: 0x181094D60
	|-NativeSlice<ushort>.set_Item
	|
	|-RVA: 0x1094DC0 Offset: 0x10937C0 VA: 0x181094DC0
	|-NativeSlice<Vector2>.set_Item
	|
	|-RVA: 0x1095040 Offset: 0x1093A40 VA: 0x181095040
	|-NativeSlice<Vector3>.set_Item
	|
	|-RVA: 0x1096B90 Offset: 0x1095590 VA: 0x181096B90
	|-NativeSlice<Vertex>.set_Item
	|
	|-RVA: 0x1096C10 Offset: 0x1095610 VA: 0x181096C10
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void CopyFrom(NativeSlice<T> slice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1092540 Offset: 0x1090F40 VA: 0x181092540
	|-NativeSlice<Color32>.CopyFrom
	|
	|-RVA: 0x1091CC0 Offset: 0x10906C0 VA: 0x181091CC0
	|-NativeSlice<ConvertMeshJobData>.CopyFrom
	|
	|-RVA: 0x1091BA0 Offset: 0x10905A0 VA: 0x181091BA0
	|-NativeSlice<CopyClosingMeshJobData>.CopyFrom
	|-NativeSlice<Transform3x4>.CopyFrom
	|
	|-RVA: 0x1092860 Offset: 0x1091260 VA: 0x181092860
	|-NativeSlice<DrawBufferRange>.CopyFrom
	|-NativeSlice<GfxUpdateBufferRange>.CopyFrom
	|-NativeSlice<JobHandle>.CopyFrom
	|-NativeSlice<Vector4>.CopyFrom
	|
	|-RVA: 0x10920E0 Offset: 0x1090AE0 VA: 0x1810920E0
	|-NativeSlice<NudgeJobData>.CopyFrom
	|
	|-RVA: 0x1092980 Offset: 0x1091380 VA: 0x181092980
	|-NativeSlice<ushort>.CopyFrom
	|
	|-RVA: 0x1092320 Offset: 0x1090D20 VA: 0x181092320
	|-NativeSlice<Vector2>.CopyFrom
	|
	|-RVA: 0x1092200 Offset: 0x1090C00 VA: 0x181092200
	|-NativeSlice<Vector3>.CopyFrom
	|
	|-RVA: 0x10959F0 Offset: 0x10943F0 VA: 0x1810959F0
	|-NativeSlice<Vertex>.CopyFrom
	|
	|-RVA: 0x1095DB0 Offset: 0x10947B0 VA: 0x181095DB0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void CopyFrom(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1092760 Offset: 0x1091160 VA: 0x181092760
	|-NativeSlice<Color32>.CopyFrom
	|
	|-RVA: 0x1092660 Offset: 0x1091060 VA: 0x181092660
	|-NativeSlice<ConvertMeshJobData>.CopyFrom
	|
	|-RVA: 0x1091AA0 Offset: 0x10904A0 VA: 0x181091AA0
	|-NativeSlice<CopyClosingMeshJobData>.CopyFrom
	|-NativeSlice<Transform3x4>.CopyFrom
	|
	|-RVA: 0x1091FE0 Offset: 0x10909E0 VA: 0x181091FE0
	|-NativeSlice<DrawBufferRange>.CopyFrom
	|-NativeSlice<GfxUpdateBufferRange>.CopyFrom
	|-NativeSlice<JobHandle>.CopyFrom
	|-NativeSlice<Vector4>.CopyFrom
	|
	|-RVA: 0x1092AA0 Offset: 0x10914A0 VA: 0x181092AA0
	|-NativeSlice<NudgeJobData>.CopyFrom
	|
	|-RVA: 0x1092440 Offset: 0x1090E40 VA: 0x181092440
	|-NativeSlice<ushort>.CopyFrom
	|
	|-RVA: 0x1091DE0 Offset: 0x10907E0 VA: 0x181091DE0
	|-NativeSlice<Vector2>.CopyFrom
	|
	|-RVA: 0x1091EE0 Offset: 0x10908E0 VA: 0x181091EE0
	|-NativeSlice<Vector3>.CopyFrom
	|
	|-RVA: 0x1095B10 Offset: 0x1094510 VA: 0x181095B10
	|-NativeSlice<Vertex>.CopyFrom
	|
	|-RVA: 0x1095C10 Offset: 0x1094610 VA: 0x181095C10
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10931A0 Offset: 0x1091BA0 VA: 0x1810931A0
	|-NativeSlice<Color32>.CopyTo
	|
	|-RVA: 0x1092CA0 Offset: 0x10916A0 VA: 0x181092CA0
	|-NativeSlice<ConvertMeshJobData>.CopyTo
	|
	|-RVA: 0x10930A0 Offset: 0x1091AA0 VA: 0x1810930A0
	|-NativeSlice<CopyClosingMeshJobData>.CopyTo
	|-NativeSlice<Transform3x4>.CopyTo
	|
	|-RVA: 0x1092DA0 Offset: 0x10917A0 VA: 0x181092DA0
	|-NativeSlice<DrawBufferRange>.CopyTo
	|-NativeSlice<GfxUpdateBufferRange>.CopyTo
	|-NativeSlice<JobHandle>.CopyTo
	|-NativeSlice<Vector4>.CopyTo
	|
	|-RVA: 0x1092FA0 Offset: 0x10919A0 VA: 0x181092FA0
	|-NativeSlice<NudgeJobData>.CopyTo
	|
	|-RVA: 0x1092BA0 Offset: 0x10915A0 VA: 0x181092BA0
	|-NativeSlice<ushort>.CopyTo
	|
	|-RVA: 0x1092EA0 Offset: 0x10918A0 VA: 0x181092EA0
	|-NativeSlice<Vector2>.CopyTo
	|
	|-RVA: 0x10932A0 Offset: 0x1091CA0 VA: 0x1810932A0
	|-NativeSlice<Vector3>.CopyTo
	|
	|-RVA: 0x1096150 Offset: 0x1094B50 VA: 0x181096150
	|-NativeSlice<Vertex>.CopyTo
	|
	|-RVA: 0x1095FB0 Offset: 0x10949B0 VA: 0x181095FB0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1093990 Offset: 0x1092390 VA: 0x181093990
	|-NativeSlice<Color32>.ToArray
	|
	|-RVA: 0x1093BA0 Offset: 0x10925A0 VA: 0x181093BA0
	|-NativeSlice<ConvertMeshJobData>.ToArray
	|
	|-RVA: 0x10936D0 Offset: 0x10920D0 VA: 0x1810936D0
	|-NativeSlice<CopyClosingMeshJobData>.ToArray
	|-NativeSlice<Transform3x4>.ToArray
	|
	|-RVA: 0x1093780 Offset: 0x1092180 VA: 0x181093780
	|-NativeSlice<DrawBufferRange>.ToArray
	|-NativeSlice<GfxUpdateBufferRange>.ToArray
	|-NativeSlice<JobHandle>.ToArray
	|-NativeSlice<Vector4>.ToArray
	|
	|-RVA: 0x10938E0 Offset: 0x10922E0 VA: 0x1810938E0
	|-NativeSlice<NudgeJobData>.ToArray
	|
	|-RVA: 0x1093830 Offset: 0x1092230 VA: 0x181093830
	|-NativeSlice<ushort>.ToArray
	|
	|-RVA: 0x1093AF0 Offset: 0x10924F0 VA: 0x181093AF0
	|-NativeSlice<Vector2>.ToArray
	|
	|-RVA: 0x1093A40 Offset: 0x1092440 VA: 0x181093A40
	|-NativeSlice<Vector3>.ToArray
	|
	|-RVA: 0x1096570 Offset: 0x1094F70 VA: 0x181096570
	|-NativeSlice<Vertex>.ToArray
	|
	|-RVA: 0x1096460 Offset: 0x1094E60 VA: 0x181096460
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public int get_Stride() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-NativeSlice<Color32>.get_Stride
	|-NativeSlice<ConvertMeshJobData>.get_Stride
	|-NativeSlice<CopyClosingMeshJobData>.get_Stride
	|-NativeSlice<DrawBufferRange>.get_Stride
	|-NativeSlice<GfxUpdateBufferRange>.get_Stride
	|-NativeSlice<JobHandle>.get_Stride
	|-NativeSlice<NudgeJobData>.get_Stride
	|-NativeSlice<Transform3x4>.get_Stride
	|-NativeSlice<ushort>.get_Stride
	|-NativeSlice<Vector2>.get_Stride
	|-NativeSlice<Vector3>.get_Stride
	|-NativeSlice<Vector4>.get_Stride
	|-NativeSlice<Vertex>.get_Stride
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Stride
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1094770 Offset: 0x1093170 VA: 0x181094770
	|-NativeSlice<Color32>.get_Length
	|-NativeSlice<ConvertMeshJobData>.get_Length
	|-NativeSlice<CopyClosingMeshJobData>.get_Length
	|-NativeSlice<DrawBufferRange>.get_Length
	|-NativeSlice<GfxUpdateBufferRange>.get_Length
	|-NativeSlice<JobHandle>.get_Length
	|-NativeSlice<NudgeJobData>.get_Length
	|-NativeSlice<Transform3x4>.get_Length
	|-NativeSlice<ushort>.get_Length
	|-NativeSlice<Vector2>.get_Length
	|-NativeSlice<Vector3>.get_Length
	|-NativeSlice<Vector4>.get_Length
	|-NativeSlice<Vertex>.get_Length
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public NativeSlice.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10934D0 Offset: 0x1091ED0 VA: 0x1810934D0
	|-NativeSlice<Color32>.GetEnumerator
	|-NativeSlice<ConvertMeshJobData>.GetEnumerator
	|-NativeSlice<CopyClosingMeshJobData>.GetEnumerator
	|-NativeSlice<DrawBufferRange>.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.GetEnumerator
	|-NativeSlice<JobHandle>.GetEnumerator
	|-NativeSlice<NudgeJobData>.GetEnumerator
	|-NativeSlice<Transform3x4>.GetEnumerator
	|-NativeSlice<ushort>.GetEnumerator
	|-NativeSlice<Vector2>.GetEnumerator
	|-NativeSlice<Vector3>.GetEnumerator
	|-NativeSlice<Vector4>.GetEnumerator
	|-NativeSlice<Vertex>.GetEnumerator
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1093570 Offset: 0x1091F70 VA: 0x181093570
	|-NativeSlice<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<ConvertMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<CopyClosingMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<DrawBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<NudgeJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Transform3x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Vertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1093610 Offset: 0x1092010 VA: 0x181093610
	|-NativeSlice<Color32>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<ConvertMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<CopyClosingMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<DrawBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<NudgeJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Transform3x4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<ushort>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Vertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10963A0 Offset: 0x1094DA0 VA: 0x1810963A0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(NativeSlice<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10934B0 Offset: 0x1091EB0 VA: 0x1810934B0
	|-NativeSlice<Color32>.Equals
	|-NativeSlice<ConvertMeshJobData>.Equals
	|-NativeSlice<CopyClosingMeshJobData>.Equals
	|-NativeSlice<DrawBufferRange>.Equals
	|-NativeSlice<GfxUpdateBufferRange>.Equals
	|-NativeSlice<JobHandle>.Equals
	|-NativeSlice<NudgeJobData>.Equals
	|-NativeSlice<Transform3x4>.Equals
	|-NativeSlice<ushort>.Equals
	|-NativeSlice<Vector2>.Equals
	|-NativeSlice<Vector3>.Equals
	|-NativeSlice<Vector4>.Equals
	|-NativeSlice<Vertex>.Equals
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10933A0 Offset: 0x1091DA0 VA: 0x1810933A0
	|-NativeSlice<Color32>.Equals
	|-NativeSlice<ConvertMeshJobData>.Equals
	|-NativeSlice<CopyClosingMeshJobData>.Equals
	|-NativeSlice<DrawBufferRange>.Equals
	|-NativeSlice<GfxUpdateBufferRange>.Equals
	|-NativeSlice<JobHandle>.Equals
	|-NativeSlice<NudgeJobData>.Equals
	|-NativeSlice<Transform3x4>.Equals
	|-NativeSlice<ushort>.Equals
	|-NativeSlice<Vector2>.Equals
	|-NativeSlice<Vector3>.Equals
	|-NativeSlice<Vector4>.Equals
	|-NativeSlice<Vertex>.Equals
	|
	|-RVA: 0x1096250 Offset: 0x1094C50 VA: 0x181096250
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1093550 Offset: 0x1091F50 VA: 0x181093550
	|-NativeSlice<Color32>.GetHashCode
	|-NativeSlice<ConvertMeshJobData>.GetHashCode
	|-NativeSlice<CopyClosingMeshJobData>.GetHashCode
	|-NativeSlice<DrawBufferRange>.GetHashCode
	|-NativeSlice<GfxUpdateBufferRange>.GetHashCode
	|-NativeSlice<JobHandle>.GetHashCode
	|-NativeSlice<NudgeJobData>.GetHashCode
	|-NativeSlice<Transform3x4>.GetHashCode
	|-NativeSlice<ushort>.GetHashCode
	|-NativeSlice<Vector2>.GetHashCode
	|-NativeSlice<Vector3>.GetHashCode
	|-NativeSlice<Vector4>.GetHashCode
	|-NativeSlice<Vertex>.GetHashCode
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/
}
