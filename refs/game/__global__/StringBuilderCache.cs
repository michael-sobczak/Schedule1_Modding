internal static class StringBuilderCache // TypeDefIndex: 18643
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x23C2C60 Offset: 0x23C1660 VA: 0x1823C2C60
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x23C2DC0 Offset: 0x23C17C0 VA: 0x1823C2DC0
	public static void Release(StringBuilder sb) { }

	// RVA: 0x23C2D30 Offset: 0x23C1730 VA: 0x1823C2D30
	public static string GetStringAndRelease(StringBuilder sb) { }
}
