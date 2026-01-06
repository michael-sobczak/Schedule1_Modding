public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 4999
{
	// Fields
	private T[] _array; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E5FC0 Offset: 0x11E49C0 VA: 0x1811E5FC0
	|-Stack<int>..ctor
	|-Stack<Int32Enum>..ctor
	|-Stack<Matrix4x4>..ctor
	|-Stack<object>..ctor
	|-Stack<Rect>..ctor
	|-Stack<TextureId>..ctor
	|-Stack<Vector2>..ctor
	|-Stack<BaseStyleMatcher.MatchContext>..ctor
	|-Stack<EventDispatcher.DispatchContext>..ctor
	|-Stack<ProbeBrickPool.BrickChunkAlloc>..ctor
	|-Stack<SequenceNode.SequenceConstructPosContext>..ctor
	|-Stack<StyleVariableResolver.ResolveContext>..ctor
	|-Stack<BindingRestrictions.TestBuilder.AndNode>..ctor
	|
	|-RVA: 0x110B8E0 Offset: 0x110A2E0 VA: 0x18110B8E0
	|-Stack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110B7F0 Offset: 0x110A1F0 VA: 0x18110B7F0
	|-Stack<int>..ctor
	|-Stack<Int32Enum>..ctor
	|-Stack<Matrix4x4>..ctor
	|-Stack<object>..ctor
	|-Stack<Rect>..ctor
	|-Stack<TextureId>..ctor
	|-Stack<Vector2>..ctor
	|-Stack<__Il2CppFullySharedGenericType>..ctor
	|-Stack<BaseStyleMatcher.MatchContext>..ctor
	|-Stack<EventDispatcher.DispatchContext>..ctor
	|-Stack<ProbeBrickPool.BrickChunkAlloc>..ctor
	|-Stack<SequenceNode.SequenceConstructPosContext>..ctor
	|-Stack<StyleVariableResolver.ResolveContext>..ctor
	|-Stack<BindingRestrictions.TestBuilder.AndNode>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-Stack<int>.get_Count
	|-Stack<Int32Enum>.get_Count
	|-Stack<Matrix4x4>.get_Count
	|-Stack<object>.get_Count
	|-Stack<Rect>.get_Count
	|-Stack<TextureId>.get_Count
	|-Stack<Vector2>.get_Count
	|-Stack<__Il2CppFullySharedGenericType>.get_Count
	|-Stack<BaseStyleMatcher.MatchContext>.get_Count
	|-Stack<EventDispatcher.DispatchContext>.get_Count
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.get_Count
	|-Stack<SequenceNode.SequenceConstructPosContext>.get_Count
	|-Stack<StyleVariableResolver.ResolveContext>.get_Count
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-Stack<int>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<Matrix4x4>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<object>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<Rect>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<TextureId>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<Vector2>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<BaseStyleMatcher.MatchContext>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<EventDispatcher.DispatchContext>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<StyleVariableResolver.ResolveContext>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E5BF0 Offset: 0x11E45F0 VA: 0x1811E5BF0
	|-Stack<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5C60 Offset: 0x11E4660 VA: 0x1811E5C60
	|-Stack<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5D40 Offset: 0x11E4740 VA: 0x1811E5D40
	|-Stack<Matrix4x4>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5DB0 Offset: 0x11E47B0 VA: 0x1811E5DB0
	|-Stack<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5A30 Offset: 0x11E4430 VA: 0x1811E5A30
	|-Stack<Rect>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5E20 Offset: 0x11E4820 VA: 0x1811E5E20
	|-Stack<TextureId>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5CD0 Offset: 0x11E46D0 VA: 0x1811E5CD0
	|-Stack<Vector2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5950 Offset: 0x11E4350 VA: 0x1811E5950
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5B10 Offset: 0x11E4510 VA: 0x1811E5B10
	|-Stack<BaseStyleMatcher.MatchContext>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5E90 Offset: 0x11E4890 VA: 0x1811E5E90
	|-Stack<EventDispatcher.DispatchContext>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5AA0 Offset: 0x11E44A0 VA: 0x1811E5AA0
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5B80 Offset: 0x11E4580 VA: 0x1811E5B80
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E5F00 Offset: 0x11E4900 VA: 0x1811E5F00
	|-Stack<StyleVariableResolver.ResolveContext>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x11E59C0 Offset: 0x11E43C0 VA: 0x1811E59C0
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E2FE0 Offset: 0x11E19E0 VA: 0x1811E2FE0
	|-Stack<int>.Clear
	|-Stack<Int32Enum>.Clear
	|-Stack<Matrix4x4>.Clear
	|-Stack<Rect>.Clear
	|-Stack<TextureId>.Clear
	|-Stack<Vector2>.Clear
	|-Stack<BaseStyleMatcher.MatchContext>.Clear
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.Clear
	|
	|-RVA: 0x11E2FF0 Offset: 0x11E19F0 VA: 0x1811E2FF0
	|-Stack<object>.Clear
	|-Stack<EventDispatcher.DispatchContext>.Clear
	|-Stack<SequenceNode.SequenceConstructPosContext>.Clear
	|-Stack<StyleVariableResolver.ResolveContext>.Clear
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Clear
	|
	|-RVA: 0x11E3020 Offset: 0x11E1A20 VA: 0x1811E3020
	|-Stack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E3110 Offset: 0x11E1B10 VA: 0x1811E3110
	|-Stack<int>.Contains
	|
	|-RVA: 0x11E3210 Offset: 0x11E1C10 VA: 0x1811E3210
	|-Stack<Int32Enum>.Contains
	|
	|-RVA: 0x11E31A0 Offset: 0x11E1BA0 VA: 0x1811E31A0
	|-Stack<Matrix4x4>.Contains
	|
	|-RVA: 0x11E34B0 Offset: 0x11E1EB0 VA: 0x1811E34B0
	|-Stack<object>.Contains
	|
	|-RVA: 0x11E3150 Offset: 0x11E1B50 VA: 0x1811E3150
	|-Stack<Rect>.Contains
	|
	|-RVA: 0x11E3380 Offset: 0x11E1D80 VA: 0x1811E3380
	|-Stack<TextureId>.Contains
	|
	|-RVA: 0x11E30D0 Offset: 0x11E1AD0 VA: 0x1811E30D0
	|-Stack<Vector2>.Contains
	|
	|-RVA: 0x11E3250 Offset: 0x11E1C50 VA: 0x1811E3250
	|-Stack<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x11E3410 Offset: 0x11E1E10 VA: 0x1811E3410
	|-Stack<BaseStyleMatcher.MatchContext>.Contains
	|
	|-RVA: 0x11E33C0 Offset: 0x11E1DC0 VA: 0x1811E33C0
	|-Stack<EventDispatcher.DispatchContext>.Contains
	|
	|-RVA: 0x11E3450 Offset: 0x11E1E50 VA: 0x1811E3450
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.Contains
	|
	|-RVA: 0x11E3070 Offset: 0x11E1A70 VA: 0x1811E3070
	|-Stack<SequenceNode.SequenceConstructPosContext>.Contains
	|
	|-RVA: 0x11E3540 Offset: 0x11E1F40 VA: 0x1811E3540
	|-Stack<StyleVariableResolver.ResolveContext>.Contains
	|
	|-RVA: 0x11E34F0 Offset: 0x11E1EF0 VA: 0x1811E34F0
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E56A0 Offset: 0x11E40A0 VA: 0x1811E56A0
	|-Stack<int>.System.Collections.ICollection.CopyTo
	|-Stack<Int32Enum>.System.Collections.ICollection.CopyTo
	|-Stack<Matrix4x4>.System.Collections.ICollection.CopyTo
	|-Stack<object>.System.Collections.ICollection.CopyTo
	|-Stack<Rect>.System.Collections.ICollection.CopyTo
	|-Stack<TextureId>.System.Collections.ICollection.CopyTo
	|-Stack<Vector2>.System.Collections.ICollection.CopyTo
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|-Stack<BaseStyleMatcher.MatchContext>.System.Collections.ICollection.CopyTo
	|-Stack<EventDispatcher.DispatchContext>.System.Collections.ICollection.CopyTo
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.System.Collections.ICollection.CopyTo
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.CopyTo
	|-Stack<StyleVariableResolver.ResolveContext>.System.Collections.ICollection.CopyTo
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public Stack.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E3730 Offset: 0x11E2130 VA: 0x1811E3730
	|-Stack<int>.GetEnumerator
	|-Stack<Int32Enum>.GetEnumerator
	|-Stack<TextureId>.GetEnumerator
	|
	|-RVA: 0x11E3590 Offset: 0x11E1F90 VA: 0x1811E3590
	|-Stack<Matrix4x4>.GetEnumerator
	|
	|-RVA: 0x11E35D0 Offset: 0x11E1FD0 VA: 0x1811E35D0
	|-Stack<object>.GetEnumerator
	|-Stack<Vector2>.GetEnumerator
	|-Stack<BaseStyleMatcher.MatchContext>.GetEnumerator
	|
	|-RVA: 0x11E36C0 Offset: 0x11E20C0 VA: 0x1811E36C0
	|-Stack<Rect>.GetEnumerator
	|-Stack<EventDispatcher.DispatchContext>.GetEnumerator
	|-Stack<StyleVariableResolver.ResolveContext>.GetEnumerator
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.GetEnumerator
	|
	|-RVA: 0x11E3610 Offset: 0x11E2010 VA: 0x1811E3610
	|-Stack<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x11E3770 Offset: 0x11E2170 VA: 0x1811E3770
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.GetEnumerator
	|
	|-RVA: 0x11E36F0 Offset: 0x11E20F0 VA: 0x1811E36F0
	|-Stack<SequenceNode.SequenceConstructPosContext>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E52F0 Offset: 0x11E3CF0 VA: 0x1811E52F0
	|-Stack<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Stack<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Stack<TextureId>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11E54F0 Offset: 0x11E3EF0 VA: 0x1811E54F0
	|-Stack<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11E5480 Offset: 0x11E3E80 VA: 0x1811E5480
	|-Stack<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Stack<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Stack<BaseStyleMatcher.MatchContext>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11E5410 Offset: 0x11E3E10 VA: 0x1811E5410
	|-Stack<Rect>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Stack<EventDispatcher.DispatchContext>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Stack<StyleVariableResolver.ResolveContext>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11E5360 Offset: 0x11E3D60 VA: 0x1811E5360
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11E5630 Offset: 0x11E4030 VA: 0x1811E5630
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x11E55A0 Offset: 0x11E3FA0 VA: 0x1811E55A0
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E52F0 Offset: 0x11E3CF0 VA: 0x1811E52F0
	|-Stack<int>.System.Collections.IEnumerable.GetEnumerator
	|-Stack<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|-Stack<TextureId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11E54F0 Offset: 0x11E3EF0 VA: 0x1811E54F0
	|-Stack<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11E5480 Offset: 0x11E3E80 VA: 0x1811E5480
	|-Stack<object>.System.Collections.IEnumerable.GetEnumerator
	|-Stack<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|-Stack<BaseStyleMatcher.MatchContext>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11E5410 Offset: 0x11E3E10 VA: 0x1811E5410
	|-Stack<Rect>.System.Collections.IEnumerable.GetEnumerator
	|-Stack<EventDispatcher.DispatchContext>.System.Collections.IEnumerable.GetEnumerator
	|-Stack<StyleVariableResolver.ResolveContext>.System.Collections.IEnumerable.GetEnumerator
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11E5360 Offset: 0x11E3D60 VA: 0x1811E5360
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11E5630 Offset: 0x11E4030 VA: 0x1811E5630
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x11E55A0 Offset: 0x11E3FA0 VA: 0x1811E55A0
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E3B90 Offset: 0x11E2590 VA: 0x1811E3B90
	|-Stack<int>.Peek
	|-Stack<Int32Enum>.Peek
	|-Stack<TextureId>.Peek
	|
	|-RVA: 0x11E3970 Offset: 0x11E2370 VA: 0x1811E3970
	|-Stack<Matrix4x4>.Peek
	|
	|-RVA: 0x11E3900 Offset: 0x11E2300 VA: 0x1811E3900
	|-Stack<object>.Peek
	|-Stack<BaseStyleMatcher.MatchContext>.Peek
	|
	|-RVA: 0x11E37A0 Offset: 0x11E21A0 VA: 0x1811E37A0
	|-Stack<Rect>.Peek
	|-Stack<EventDispatcher.DispatchContext>.Peek
	|-Stack<StyleVariableResolver.ResolveContext>.Peek
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Peek
	|
	|-RVA: 0x11E3B10 Offset: 0x11E2510 VA: 0x1811E3B10
	|-Stack<Vector2>.Peek
	|
	|-RVA: 0x11E3810 Offset: 0x11E2210 VA: 0x1811E3810
	|-Stack<__Il2CppFullySharedGenericType>.Peek
	|
	|-RVA: 0x11E3A00 Offset: 0x11E2400 VA: 0x1811E3A00
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.Peek
	|
	|-RVA: 0x11E3A80 Offset: 0x11E2480 VA: 0x1811E3A80
	|-Stack<SequenceNode.SequenceConstructPosContext>.Peek
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E3E60 Offset: 0x11E2860 VA: 0x1811E3E60
	|-Stack<int>.Pop
	|-Stack<Int32Enum>.Pop
	|-Stack<TextureId>.Pop
	|
	|-RVA: 0x11E3F90 Offset: 0x11E2990 VA: 0x1811E3F90
	|-Stack<Matrix4x4>.Pop
	|
	|-RVA: 0x11E3C00 Offset: 0x11E2600 VA: 0x1811E3C00
	|-Stack<object>.Pop
	|
	|-RVA: 0x11E4280 Offset: 0x11E2C80 VA: 0x1811E4280
	|-Stack<Rect>.Pop
	|
	|-RVA: 0x11E3C90 Offset: 0x11E2690 VA: 0x1811E3C90
	|-Stack<Vector2>.Pop
	|
	|-RVA: 0x11E4030 Offset: 0x11E2A30 VA: 0x1811E4030
	|-Stack<__Il2CppFullySharedGenericType>.Pop
	|
	|-RVA: 0x11E4300 Offset: 0x11E2D00 VA: 0x1811E4300
	|-Stack<BaseStyleMatcher.MatchContext>.Pop
	|
	|-RVA: 0x11E3DA0 Offset: 0x11E27A0 VA: 0x1811E3DA0
	|-Stack<EventDispatcher.DispatchContext>.Pop
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Pop
	|
	|-RVA: 0x11E3D10 Offset: 0x11E2710 VA: 0x1811E3D10
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.Pop
	|
	|-RVA: 0x11E4370 Offset: 0x11E2D70 VA: 0x1811E4370
	|-Stack<SequenceNode.SequenceConstructPosContext>.Pop
	|
	|-RVA: 0x11E3ED0 Offset: 0x11E28D0 VA: 0x1811E3ED0
	|-Stack<StyleVariableResolver.ResolveContext>.Pop
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E4F90 Offset: 0x11E3990 VA: 0x1811E4F90
	|-Stack<int>.Push
	|-Stack<Int32Enum>.Push
	|
	|-RVA: 0x11E5030 Offset: 0x11E3A30 VA: 0x1811E5030
	|-Stack<Matrix4x4>.Push
	|
	|-RVA: 0x11E50D0 Offset: 0x11E3AD0 VA: 0x1811E50D0
	|-Stack<object>.Push
	|
	|-RVA: 0x11E5190 Offset: 0x11E3B90 VA: 0x1811E5190
	|-Stack<Rect>.Push
	|
	|-RVA: 0x11E4FE0 Offset: 0x11E39E0 VA: 0x1811E4FE0
	|-Stack<TextureId>.Push
	|
	|-RVA: 0x11E5280 Offset: 0x11E3C80 VA: 0x1811E5280
	|-Stack<Vector2>.Push
	|
	|-RVA: 0x11E4C50 Offset: 0x11E3650 VA: 0x1811E4C50
	|-Stack<__Il2CppFullySharedGenericType>.Push
	|
	|-RVA: 0x11E5140 Offset: 0x11E3B40 VA: 0x1811E5140
	|-Stack<BaseStyleMatcher.MatchContext>.Push
	|
	|-RVA: 0x11E51F0 Offset: 0x11E3BF0 VA: 0x1811E51F0
	|-Stack<EventDispatcher.DispatchContext>.Push
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Push
	|
	|-RVA: 0x11E4DE0 Offset: 0x11E37E0 VA: 0x1811E4DE0
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.Push
	|
	|-RVA: 0x11E4E50 Offset: 0x11E3850 VA: 0x1811E4E50
	|-Stack<SequenceNode.SequenceConstructPosContext>.Push
	|
	|-RVA: 0x11E4F00 Offset: 0x11E3900 VA: 0x1811E4F00
	|-Stack<StyleVariableResolver.ResolveContext>.Push
	*/

	// RVA: -1 Offset: -1
	private void PushWithResize(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E4810 Offset: 0x11E3210 VA: 0x1811E4810
	|-Stack<int>.PushWithResize
	|-Stack<Int32Enum>.PushWithResize
	|
	|-RVA: 0x11E4590 Offset: 0x11E2F90 VA: 0x1811E4590
	|-Stack<Matrix4x4>.PushWithResize
	|
	|-RVA: 0x11E4B30 Offset: 0x11E3530 VA: 0x1811E4B30
	|-Stack<object>.PushWithResize
	|
	|-RVA: 0x11E4890 Offset: 0x11E3290 VA: 0x1811E4890
	|-Stack<Rect>.PushWithResize
	|
	|-RVA: 0x11E4510 Offset: 0x11E2F10 VA: 0x1811E4510
	|-Stack<TextureId>.PushWithResize
	|
	|-RVA: 0x11E4630 Offset: 0x11E3030 VA: 0x1811E4630
	|-Stack<Vector2>.PushWithResize
	|
	|-RVA: 0x11E49C0 Offset: 0x11E33C0 VA: 0x1811E49C0
	|-Stack<__Il2CppFullySharedGenericType>.PushWithResize
	|
	|-RVA: 0x11E4490 Offset: 0x11E2E90 VA: 0x1811E4490
	|-Stack<BaseStyleMatcher.MatchContext>.PushWithResize
	|
	|-RVA: 0x11E4770 Offset: 0x11E3170 VA: 0x1811E4770
	|-Stack<EventDispatcher.DispatchContext>.PushWithResize
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.PushWithResize
	|
	|-RVA: 0x11E4BC0 Offset: 0x11E35C0 VA: 0x1811E4BC0
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.PushWithResize
	|
	|-RVA: 0x11E46C0 Offset: 0x11E30C0 VA: 0x1811E46C0
	|-Stack<SequenceNode.SequenceConstructPosContext>.PushWithResize
	|
	|-RVA: 0x11E4920 Offset: 0x11E3320 VA: 0x1811E4920
	|-Stack<StyleVariableResolver.ResolveContext>.PushWithResize
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E5F70 Offset: 0x11E4970 VA: 0x1811E5F70
	|-Stack<int>.ThrowForEmptyStack
	|-Stack<Int32Enum>.ThrowForEmptyStack
	|-Stack<Matrix4x4>.ThrowForEmptyStack
	|-Stack<object>.ThrowForEmptyStack
	|-Stack<Rect>.ThrowForEmptyStack
	|-Stack<TextureId>.ThrowForEmptyStack
	|-Stack<Vector2>.ThrowForEmptyStack
	|-Stack<__Il2CppFullySharedGenericType>.ThrowForEmptyStack
	|-Stack<BaseStyleMatcher.MatchContext>.ThrowForEmptyStack
	|-Stack<EventDispatcher.DispatchContext>.ThrowForEmptyStack
	|-Stack<ProbeBrickPool.BrickChunkAlloc>.ThrowForEmptyStack
	|-Stack<SequenceNode.SequenceConstructPosContext>.ThrowForEmptyStack
	|-Stack<StyleVariableResolver.ResolveContext>.ThrowForEmptyStack
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.ThrowForEmptyStack
	*/
}
