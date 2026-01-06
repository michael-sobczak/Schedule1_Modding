public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> // TypeDefIndex: 6945
{
	// Fields
	private List<StyleSelector> m_StyleSelectors; // 0x0
	private List<StyleSelectorPart> m_Parts; // 0x0
	private VisualElement m_Element; // 0x0
	private List<RuleMatcher> m_Matchers; // 0x0
	private StyleSelectorRelationship m_Relationship; // 0x0
	private int pseudoStatesMask; // 0x0
	private int negatedPseudoStatesMask; // 0x0

	// Properties
	private List<StyleSelector> styleSelectors { get; }
	private List<StyleSelectorPart> parts { get; }

	// Methods

	// RVA: -1 Offset: -1
	private List<StyleSelector> get_styleSelectors() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9E90 Offset: 0x12C8890 VA: 0x1812C9E90
	|-UQueryBuilder<object>.get_styleSelectors
	*/

	// RVA: -1 Offset: -1
	private List<StyleSelectorPart> get_parts() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9E10 Offset: 0x12C8810 VA: 0x1812C9E10
	|-UQueryBuilder<object>.get_parts
	*/

	// RVA: -1 Offset: -1
	public void .ctor(VisualElement visualElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9D40 Offset: 0x12C8740 VA: 0x1812C9D40
	|-UQueryBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public UQueryBuilder<T> Class(string classname) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C8D80 Offset: 0x12C7780 VA: 0x1812C8D80
	|-UQueryBuilder<object>.Class
	*/

	// RVA: -1 Offset: -1
	public UQueryBuilder<T> Name(string id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9A00 Offset: 0x12C8400 VA: 0x1812C9A00
	|-UQueryBuilder<object>.Name
	*/

	// RVA: -1 Offset: -1
	internal UQueryBuilder<T> SingleBaseType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9B70 Offset: 0x12C8570 VA: 0x1812C9B70
	|-UQueryBuilder<object>.SingleBaseType
	*/

	// RVA: -1 Offset: -1
	private void AddClass(string c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C87D0 Offset: 0x12C71D0 VA: 0x1812C87D0
	|-UQueryBuilder<object>.AddClass
	*/

	// RVA: -1 Offset: -1
	private void AddName(string id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C8900 Offset: 0x12C7300 VA: 0x1812C8900
	|-UQueryBuilder<object>.AddName
	*/

	// RVA: -1 Offset: -1
	private void AddPseudoStatesRuleIfNecessasy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C8A30 Offset: 0x12C7430 VA: 0x1812C8A30
	|-UQueryBuilder<object>.AddPseudoStatesRuleIfNecessasy
	*/

	// RVA: -1 Offset: -1
	private void FinishSelector() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9530 Offset: 0x12C7F30 VA: 0x1812C9530
	|-UQueryBuilder<object>.FinishSelector
	*/

	// RVA: -1 Offset: -1
	private bool CurrentSelectorEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C8EF0 Offset: 0x12C78F0 VA: 0x1812C8EF0
	|-UQueryBuilder<object>.CurrentSelectorEmpty
	*/

	// RVA: -1 Offset: -1
	private void FinishCurrentSelector() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C9340 Offset: 0x12C7D40 VA: 0x1812C9340
	|-UQueryBuilder<object>.FinishCurrentSelector
	*/

	// RVA: -1 Offset: -1
	public UQueryState<T> Build() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C8B70 Offset: 0x12C7570 VA: 0x1812C8B70
	|-UQueryBuilder<object>.Build
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(UQueryBuilder<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C90B0 Offset: 0x12C7AB0 VA: 0x1812C90B0
	|-UQueryBuilder<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C8F90 Offset: 0x12C7990 VA: 0x1812C8F90
	|-UQueryBuilder<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C97A0 Offset: 0x12C81A0 VA: 0x1812C97A0
	|-UQueryBuilder<object>.GetHashCode
	*/
}
