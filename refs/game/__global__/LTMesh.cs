internal class LTMesh : MeshUtils.Pooled<LTMesh> // TypeDefIndex: 10785
{
	// Fields
	internal MeshUtils.Vertex _vHead; // 0x10
	internal MeshUtils.Face _fHead; // 0x18
	internal MeshUtils.Edge _eHead; // 0x20
	internal MeshUtils.Edge _eHeadSym; // 0x28

	// Methods

	// RVA: 0x535D40 Offset: 0x534740 VA: 0x180535D40
	public void .ctor() { }

	// RVA: 0x535490 Offset: 0x533E90 VA: 0x180535490 Slot: 4
	public override void Reset() { }

	// RVA: 0x535390 Offset: 0x533D90 VA: 0x180535390 Slot: 5
	public override void OnFree() { }

	// RVA: 0x535080 Offset: 0x533A80 VA: 0x180535080
	public MeshUtils.Edge MakeEdge() { }

	// RVA: 0x5354F0 Offset: 0x533EF0 VA: 0x1805354F0
	public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst) { }

	// RVA: 0x534E00 Offset: 0x533800 VA: 0x180534E00
	public void Delete(MeshUtils.Edge eDel) { }

	// RVA: 0x5349F0 Offset: 0x5333F0 VA: 0x1805349F0
	public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg) { }

	// RVA: 0x535660 Offset: 0x534060 VA: 0x180535660
	public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg) { }

	// RVA: 0x534BE0 Offset: 0x5335E0 VA: 0x180534BE0
	public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst) { }

	// RVA: 0x535950 Offset: 0x534350 VA: 0x180535950
	public void ZapFace(MeshUtils.Face fZap) { }

	// RVA: 0x5350F0 Offset: 0x533AF0 VA: 0x1805350F0
	public void MergeConvexFaces(int maxVertsPerFace) { }

	[Conditional("DEBUG")]
	// RVA: 0x534B30 Offset: 0x533530 VA: 0x180534B30
	public void Check() { }
}
