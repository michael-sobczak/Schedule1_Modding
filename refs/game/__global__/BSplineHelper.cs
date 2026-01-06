public static class BSplineHelper // TypeDefIndex: 10490
{
	// Methods

	// RVA: 0x489F90 Offset: 0x488990 VA: 0x180489F90
	public static Vector3 DeBoorClamped(int p, int k, float u, int nPlus1, Vector3[] pArray) { }

	// RVA: 0x48A250 Offset: 0x488C50 VA: 0x18048A250
	public static Vector3 DeBoorUnclamped(int p, int k, float u, Vector3[] pArray) { }

	// RVA: 0x48A480 Offset: 0x488E80 VA: 0x18048A480
	public static int GetBSplineN(int controlPointsCount, int degree, bool closed) { }

	// RVA: 0x48A490 Offset: 0x488E90 VA: 0x18048A490
	public static void GetBSplineUAndK(float tf, bool isClamped, int p, int n, out float u, out int k) { }
}
