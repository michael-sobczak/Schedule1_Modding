internal static class MeshUtils // TypeDefIndex: 10792
{
	// Fields
	public const int Undef = -1;

	// Methods

	// RVA: 0x536320 Offset: 0x534D20 VA: 0x180536320
	public static MeshUtils.Edge MakeEdge(MeshUtils.Edge eNext) { }

	// RVA: 0x5367A0 Offset: 0x5351A0 VA: 0x1805367A0
	public static void Splice(MeshUtils.Edge a, MeshUtils.Edge b) { }

	// RVA: 0x5366B0 Offset: 0x5350B0 VA: 0x1805366B0
	public static void MakeVertex(MeshUtils.Edge eOrig, MeshUtils.Vertex vNext) { }

	// RVA: 0x5365A0 Offset: 0x534FA0 VA: 0x1805365A0
	public static void MakeFace(MeshUtils.Edge eOrig, MeshUtils.Face fNext) { }

	// RVA: 0x5360C0 Offset: 0x534AC0 VA: 0x1805360C0
	public static void KillEdge(MeshUtils.Edge eDel) { }

	// RVA: 0x536260 Offset: 0x534C60 VA: 0x180536260
	public static void KillVertex(MeshUtils.Vertex vDel, MeshUtils.Vertex newOrg) { }

	// RVA: 0x5361A0 Offset: 0x534BA0 VA: 0x1805361A0
	public static void KillFace(MeshUtils.Face fDel, MeshUtils.Face newLFace) { }

	// RVA: 0x536050 Offset: 0x534A50 VA: 0x180536050
	public static float FaceArea(MeshUtils.Face f) { }
}
