internal sealed class LocalVariables // TypeDefIndex: 15454
{
	// Fields
	private readonly HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope> _variables; // 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; // 0x18
	private int _localCount; // 0x20
	private int _maxLocalCount; // 0x24

	// Properties
	public int LocalCount { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x1FF0D00 Offset: 0x1FEF700 VA: 0x181FF0D00
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	// RVA: 0x1FF10B0 Offset: 0x1FEFAB0 VA: 0x181FF10B0
	public void UndefineLocal(LocalDefinition definition, int end) { }

	// RVA: 0x1FF0BB0 Offset: 0x1FEF5B0 VA: 0x181FF0BB0
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_LocalCount() { }

	// RVA: 0x1FF0FC0 Offset: 0x1FEF9C0 VA: 0x181FF0FC0
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x1FF0AA0 Offset: 0x1FEF4A0 VA: 0x181FF0AA0
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	// RVA: 0x1FF1190 Offset: 0x1FEFB90 VA: 0x181FF1190
	public void .ctor() { }
}
