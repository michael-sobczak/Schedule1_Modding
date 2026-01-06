public sealed class LightProbes : Object // TypeDefIndex: 11654
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action lightProbesUpdated; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action tetrahedralizationCompleted; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action needsRetetrahedralization; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2C90310 Offset: 0x2C8ED10 VA: 0x182C90310
	private static void Internal_CallLightProbesUpdatedFunction() { }

	[RequiredByNativeCode]
	// RVA: 0x2C903C0 Offset: 0x2C8EDC0 VA: 0x182C903C0
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	[RequiredByNativeCode]
	// RVA: 0x2C90360 Offset: 0x2C8ED60 VA: 0x182C90360
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	[FreeFunction]
	// RVA: 0x2C90450 Offset: 0x2C8EE50 VA: 0x182C90450
	public static void Tetrahedralize() { }

	[FreeFunction]
	// RVA: 0x2C90420 Offset: 0x2C8EE20 VA: 0x182C90420
	public static void TetrahedralizeAsync() { }
}
