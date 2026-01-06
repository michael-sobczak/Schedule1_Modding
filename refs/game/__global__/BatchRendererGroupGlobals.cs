public struct BatchRendererGroupGlobals : IEquatable<BatchRendererGroupGlobals> // TypeDefIndex: 13836
{
	// Fields
	public const string kGlobalsPropertyName = "unity_DOTSInstanceGlobalValues";
	public static readonly int kGlobalsPropertyId; // 0x0
	public Vector4 ProbesOcclusion; // 0x0
	public Vector4 SpecCube0_HDR; // 0x10
	public Vector4 SpecCube1_HDR; // 0x20
	public SHCoefficients SHCoefficients; // 0x30

	// Properties
	public static BatchRendererGroupGlobals Default { get; }

	// Methods

	// RVA: 0x2A30CC0 Offset: 0x2A2F6C0 VA: 0x182A30CC0
	public static BatchRendererGroupGlobals get_Default() { }

	// RVA: 0x2A30800 Offset: 0x2A2F200 VA: 0x182A30800 Slot: 4
	public bool Equals(BatchRendererGroupGlobals other) { }

	// RVA: 0x2A30660 Offset: 0x2A2F060 VA: 0x182A30660 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A30AE0 Offset: 0x2A2F4E0 VA: 0x182A30AE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A30EC0 Offset: 0x2A2F8C0 VA: 0x182A30EC0
	public static bool op_Equality(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right) { }

	// RVA: 0x2A30FA0 Offset: 0x2A2F9A0 VA: 0x182A30FA0
	public static bool op_Inequality(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right) { }

	// RVA: 0x2A30C70 Offset: 0x2A2F670 VA: 0x182A30C70
	private static void .cctor() { }
}
