internal class ScopeExpression : BlockExpression // TypeDefIndex: 15121
{
	// Fields
	private IReadOnlyList<ParameterExpression> _variables; // 0x10

	// Properties
	protected IReadOnlyList<ParameterExpression> VariablesList { get; }

	// Methods

	// RVA: 0x1FA4D30 Offset: 0x1FA3730 VA: 0x181FA4D30
	internal void .ctor(IReadOnlyList<ParameterExpression> variables) { }

	// RVA: 0x1FBADC0 Offset: 0x1FB97C0 VA: 0x181FBADC0 Slot: 13
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	// RVA: 0x1FBAE00 Offset: 0x1FB9800 VA: 0x181FBAE00
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }
}
