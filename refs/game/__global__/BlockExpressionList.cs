internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable // TypeDefIndex: 15126
{
	// Fields
	private readonly BlockExpression _block; // 0x10
	private readonly Expression _arg0; // 0x18

	// Properties
	public Expression Item { get; set; }
	public int Count { get; }
	[ExcludeFromCodeCoverage]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	internal void .ctor(BlockExpression provider, Expression arg0) { }

	// RVA: 0x1FA46B0 Offset: 0x1FA30B0 VA: 0x181FA46B0 Slot: 6
	public int IndexOf(Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA4760 Offset: 0x1FA3160 VA: 0x181FA4760 Slot: 7
	public void Insert(int index, Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA4790 Offset: 0x1FA3190 VA: 0x181FA4790 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x1FA4820 Offset: 0x1FA3220 VA: 0x181FA4820 Slot: 4
	public Expression get_Item(int index) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA4860 Offset: 0x1FA3260 VA: 0x181FA4860 Slot: 5
	public void set_Item(int index, Expression value) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA4300 Offset: 0x1FA2D00 VA: 0x181FA4300 Slot: 11
	public void Add(Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA4330 Offset: 0x1FA2D30 VA: 0x181FA4330 Slot: 12
	public void Clear() { }

	// RVA: 0x1FA4360 Offset: 0x1FA2D60 VA: 0x181FA4360 Slot: 13
	public bool Contains(Expression item) { }

	// RVA: 0x1FA4410 Offset: 0x1FA2E10 VA: 0x181FA4410 Slot: 14
	public void CopyTo(Expression[] array, int index) { }

	// RVA: 0x1B56640 Offset: 0x1B55040 VA: 0x181B56640 Slot: 9
	public int get_Count() { }

	// RVA: 0x1FA47F0 Offset: 0x1FA31F0 VA: 0x181FA47F0 Slot: 10
	public bool get_IsReadOnly() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1FA47C0 Offset: 0x1FA31C0 VA: 0x181FA47C0 Slot: 15
	public bool Remove(Expression item) { }

	[IteratorStateMachine(typeof(BlockExpressionList.<GetEnumerator>d__18))]
	// RVA: 0x1FA4640 Offset: 0x1FA3040 VA: 0x181FA4640 Slot: 16
	public IEnumerator<Expression> GetEnumerator() { }

	// RVA: 0x1FA4640 Offset: 0x1FA3040 VA: 0x181FA4640 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}
