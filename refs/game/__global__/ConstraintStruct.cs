internal sealed class ConstraintStruct // TypeDefIndex: 8246
{
	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Properties
	internal int TableDim { get; }

	// Methods

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	internal int get_TableDim() { }

	// RVA: 0x2562980 Offset: 0x2561380 VA: 0x182562980
	internal void .ctor(CompiledIdentityConstraint constraint) { }
}
