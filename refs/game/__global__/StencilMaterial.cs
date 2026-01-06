public static class StencilMaterial // TypeDefIndex: 16480
{
	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use Material.Add instead.", True)]
	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x2F3E0C0 Offset: 0x2F3CAC0 VA: 0x182F3E0C0
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x2F3ED50 Offset: 0x2F3D750 VA: 0x182F3ED50
	private static void LogWarningWhenNotInBatchmode(string warning, Object context) { }

	// RVA: 0x2F3E160 Offset: 0x2F3CB60 VA: 0x182F3E160
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x2F3EDE0 Offset: 0x2F3D7E0 VA: 0x182F3EDE0
	public static void Remove(Material customMat) { }

	// RVA: 0x2F3EBE0 Offset: 0x2F3D5E0 VA: 0x182F3EBE0
	public static void ClearAll() { }

	// RVA: 0x2F3EFB0 Offset: 0x2F3D9B0 VA: 0x182F3EFB0
	private static void .cctor() { }
}
