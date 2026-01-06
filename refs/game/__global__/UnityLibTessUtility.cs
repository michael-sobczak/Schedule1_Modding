public static class UnityLibTessUtility // TypeDefIndex: 10808
{
	// Methods

	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	// RVA: 0x5543D0 Offset: 0x552DD0 VA: 0x1805543D0
	public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = False) { }

	// RVA: 0x5542F0 Offset: 0x552CF0 VA: 0x1805542F0
	public static ContourVertex[] ToContourVertex(SubArray<Vector3> v, bool zeroZ = False) { }

	// RVA: 0x554020 Offset: 0x552A20 VA: 0x180554020
	public static void FromContourVertex(ContourVertex[] v, SubArray<Vector3> output) { }

	// RVA: 0x553ED0 Offset: 0x5528D0 VA: 0x180553ED0
	public static SubArray<Vector3> ContourVerticesToPositions(ContourVertex[] v) { }

	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	// RVA: 0x5540B0 Offset: 0x552AB0 VA: 0x1805540B0
	public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray) { }

	[Obsolete("No more used in Curvy. Will get removed. Copy it if you still need it")]
	// RVA: 0x5541D0 Offset: 0x552BD0 VA: 0x1805541D0
	public static void SetToContourVertex(ref ContourVertex[] cvArray, ref Vector3[] v3Array) { }
}
