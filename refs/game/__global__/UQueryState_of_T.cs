public struct UQueryState<T> : IEnumerable<T>, IEnumerable, IEquatable<UQueryState<T>> // TypeDefIndex: 6944
{
	// Fields
	private static UQueryState.ActionQueryMatcher<T> s_Action; // 0x0
	private readonly VisualElement m_Element; // 0x0
	internal readonly List<RuleMatcher> m_Matchers; // 0x0
	private static readonly UQueryState.ListQueryMatcher<T, T> s_List; // 0x0
	private static readonly UQueryState.ListQueryMatcher<T, VisualElement> s_EnumerationList; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(VisualElement element, List<RuleMatcher> matchers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C6B0 Offset: 0x43B0B0 VA: 0x18043C6B0
	|-UQueryState<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public UQueryState<T> RebuildOn(VisualElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CA340 Offset: 0x12C8D40 VA: 0x1812CA340
	|-UQueryState<object>.RebuildOn
	*/

	// RVA: -1 Offset: -1
	private T Single(UQuery.SingleQueryMatcher matcher) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CA3C0 Offset: 0x12C8DC0 VA: 0x1812CA3C0
	|-UQueryState<object>.Single
	*/

	// RVA: -1 Offset: -1
	public T First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CA150 Offset: 0x12C8B50 VA: 0x1812CA150
	|-UQueryState<object>.First
	*/

	// RVA: -1 Offset: -1
	public UQueryState.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CA230 Offset: 0x12C8C30 VA: 0x1812CA230
	|-UQueryState<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CA510 Offset: 0x12C8F10 VA: 0x1812CA510
	|-UQueryState<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CA510 Offset: 0x12C8F10 VA: 0x1812CA510
	|-UQueryState<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(UQueryState<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9F10 Offset: 0x12C8910 VA: 0x1812C9F10
	|-UQueryState<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9FA0 Offset: 0x12C89A0 VA: 0x1812C9FA0
	|-UQueryState<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CA290 Offset: 0x12C8C90 VA: 0x1812CA290
	|-UQueryState<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CA610 Offset: 0x12C9010 VA: 0x1812CA610
	|-UQueryState<object>..cctor
	*/
}
