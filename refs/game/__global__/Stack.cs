public struct Stack.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 4998
{
	// Fields
	private readonly Stack<T> _stack; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Stack<T> stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166BC40 Offset: 0x166A640 VA: 0x18166BC40
	|-Stack.Enumerator<int>..ctor
	|-Stack.Enumerator<Int32Enum>..ctor
	|-Stack.Enumerator<TextureId>..ctor
	|
	|-RVA: 0x166BF40 Offset: 0x166A940 VA: 0x18166BF40
	|-Stack.Enumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x166BEB0 Offset: 0x166A8B0 VA: 0x18166BEB0
	|-Stack.Enumerator<object>..ctor
	|-Stack.Enumerator<Vector2>..ctor
	|-Stack.Enumerator<BaseStyleMatcher.MatchContext>..ctor
	|
	|-RVA: 0x16708C0 Offset: 0x166F2C0 VA: 0x1816708C0
	|-Stack.Enumerator<Rect>..ctor
	|-Stack.Enumerator<EventDispatcher.DispatchContext>..ctor
	|-Stack.Enumerator<StyleVariableResolver.ResolveContext>..ctor
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>..ctor
	|
	|-RVA: 0x167A5E0 Offset: 0x1678FE0 VA: 0x18167A5E0
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x167A590 Offset: 0x1678F90 VA: 0x18167A590
	|-Stack.Enumerator<ProbeBrickPool.BrickChunkAlloc>..ctor
	|
	|-RVA: 0x1681AE0 Offset: 0x16804E0 VA: 0x181681AE0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663C00 Offset: 0x1662600 VA: 0x181663C00
	|-Stack.Enumerator<int>.Dispose
	|-Stack.Enumerator<Int32Enum>.Dispose
	|-Stack.Enumerator<Matrix4x4>.Dispose
	|-Stack.Enumerator<object>.Dispose
	|-Stack.Enumerator<Rect>.Dispose
	|-Stack.Enumerator<TextureId>.Dispose
	|-Stack.Enumerator<Vector2>.Dispose
	|-Stack.Enumerator<BaseStyleMatcher.MatchContext>.Dispose
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.Dispose
	|-Stack.Enumerator<ProbeBrickPool.BrickChunkAlloc>.Dispose
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.Dispose
	|-Stack.Enumerator<StyleVariableResolver.ResolveContext>.Dispose
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.Dispose
	|
	|-RVA: 0x1671AA0 Offset: 0x16704A0 VA: 0x181671AA0
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1668840 Offset: 0x1667240 VA: 0x181668840
	|-Stack.Enumerator<int>.MoveNext
	|-Stack.Enumerator<Int32Enum>.MoveNext
	|-Stack.Enumerator<TextureId>.MoveNext
	|
	|-RVA: 0x1667A90 Offset: 0x1666490 VA: 0x181667A90
	|-Stack.Enumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x1668C60 Offset: 0x1667660 VA: 0x181668C60
	|-Stack.Enumerator<object>.MoveNext
	|
	|-RVA: 0x166D0D0 Offset: 0x166BAD0 VA: 0x18166D0D0
	|-Stack.Enumerator<Rect>.MoveNext
	|
	|-RVA: 0x166D2F0 Offset: 0x166BCF0 VA: 0x18166D2F0
	|-Stack.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x1672FC0 Offset: 0x16719C0 VA: 0x181672FC0
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x16752F0 Offset: 0x1673CF0 VA: 0x1816752F0
	|-Stack.Enumerator<BaseStyleMatcher.MatchContext>.MoveNext
	|
	|-RVA: 0x1675E80 Offset: 0x1674880 VA: 0x181675E80
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.MoveNext
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.MoveNext
	|
	|-RVA: 0x1675410 Offset: 0x1673E10 VA: 0x181675410
	|-Stack.Enumerator<ProbeBrickPool.BrickChunkAlloc>.MoveNext
	|
	|-RVA: 0x167DA40 Offset: 0x167C440 VA: 0x18167DA40
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.MoveNext
	|
	|-RVA: 0x167DCE0 Offset: 0x167C6E0 VA: 0x18167DCE0
	|-Stack.Enumerator<StyleVariableResolver.ResolveContext>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166C1F0 Offset: 0x166ABF0 VA: 0x18166C1F0
	|-Stack.Enumerator<int>.get_Current
	|-Stack.Enumerator<Int32Enum>.get_Current
	|-Stack.Enumerator<TextureId>.get_Current
	|
	|-RVA: 0x166CA20 Offset: 0x166B420 VA: 0x18166CA20
	|-Stack.Enumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x166C420 Offset: 0x166AE20 VA: 0x18166C420
	|-Stack.Enumerator<object>.get_Current
	|-Stack.Enumerator<BaseStyleMatcher.MatchContext>.get_Current
	|
	|-RVA: 0x16713C0 Offset: 0x166FDC0 VA: 0x1816713C0
	|-Stack.Enumerator<Rect>.get_Current
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.get_Current
	|-Stack.Enumerator<StyleVariableResolver.ResolveContext>.get_Current
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.get_Current
	|
	|-RVA: 0x16710F0 Offset: 0x166FAF0 VA: 0x1816710F0
	|-Stack.Enumerator<Vector2>.get_Current
	|
	|-RVA: 0x167B240 Offset: 0x1679C40 VA: 0x18167B240
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x167C1C0 Offset: 0x167ABC0 VA: 0x18167C1C0
	|-Stack.Enumerator<ProbeBrickPool.BrickChunkAlloc>.get_Current
	|
	|-RVA: 0x1681E10 Offset: 0x1680810 VA: 0x181681E10
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166B840 Offset: 0x166A240 VA: 0x18166B840
	|-Stack.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<Int32Enum>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<Matrix4x4>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<Rect>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<TextureId>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<Vector2>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<BaseStyleMatcher.MatchContext>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<ProbeBrickPool.BrickChunkAlloc>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<StyleVariableResolver.ResolveContext>.ThrowEnumerationNotStartedOrEnded
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x1678FE0 Offset: 0x16779E0 VA: 0x181678FE0
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166AD80 Offset: 0x1669780 VA: 0x18166AD80
	|-Stack.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-Stack.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-Stack.Enumerator<TextureId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166B370 Offset: 0x1669D70 VA: 0x18166B370
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166B640 Offset: 0x166A040 VA: 0x18166B640
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x16701C0 Offset: 0x166EBC0 VA: 0x1816701C0
	|-Stack.Enumerator<Rect>.System.Collections.IEnumerator.get_Current
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.get_Current
	|-Stack.Enumerator<StyleVariableResolver.ResolveContext>.System.Collections.IEnumerator.get_Current
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1670070 Offset: 0x166EA70 VA: 0x181670070
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110C2B0 Offset: 0x110ACB0 VA: 0x18110C2B0
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1677670 Offset: 0x1676070 VA: 0x181677670
	|-Stack.Enumerator<BaseStyleMatcher.MatchContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1678980 Offset: 0x1677380 VA: 0x181678980
	|-Stack.Enumerator<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x167FEB0 Offset: 0x167E8B0 VA: 0x18167FEB0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16694F0 Offset: 0x1667EF0 VA: 0x1816694F0
	|-Stack.Enumerator<int>.System.Collections.IEnumerator.Reset
	|-Stack.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|-Stack.Enumerator<TextureId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1669970 Offset: 0x1668370 VA: 0x181669970
	|-Stack.Enumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x16696E0 Offset: 0x16680E0 VA: 0x1816696E0
	|-Stack.Enumerator<object>.System.Collections.IEnumerator.Reset
	|-Stack.Enumerator<Vector2>.System.Collections.IEnumerator.Reset
	|-Stack.Enumerator<BaseStyleMatcher.MatchContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x166EA40 Offset: 0x166D440 VA: 0x18166EA40
	|-Stack.Enumerator<Rect>.System.Collections.IEnumerator.Reset
	|-Stack.Enumerator<EventDispatcher.DispatchContext>.System.Collections.IEnumerator.Reset
	|-Stack.Enumerator<StyleVariableResolver.ResolveContext>.System.Collections.IEnumerator.Reset
	|-Stack.Enumerator<BindingRestrictions.TestBuilder.AndNode>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1676B40 Offset: 0x1675540 VA: 0x181676B40
	|-Stack.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1676870 Offset: 0x1675270 VA: 0x181676870
	|-Stack.Enumerator<ProbeBrickPool.BrickChunkAlloc>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x167F5E0 Offset: 0x167DFE0 VA: 0x18167F5E0
	|-Stack.Enumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.Reset
	*/
}
