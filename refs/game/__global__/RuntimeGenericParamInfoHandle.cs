internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 3465
{
	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x1A8DC10 Offset: 0x1A8C610 VA: 0x181A8DC10
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1A8DFB0 Offset: 0x1A8C9B0 VA: 0x181A8DFB0
	internal Type[] get_Constraints() { }

	// RVA: 0x1A8DF90 Offset: 0x1A8C990 VA: 0x181A8DF90
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x1A8DE40 Offset: 0x1A8C840 VA: 0x181A8DE40
	private Type[] GetConstraints() { }

	// RVA: 0x1A8DE10 Offset: 0x1A8C810 VA: 0x181A8DE10
	private int GetConstraintsCount() { }
}
