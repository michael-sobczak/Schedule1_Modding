internal class XROcclusionMesh // TypeDefIndex: 13495
{
	// Fields
	private XRPass m_Pass; // 0x10
	private Mesh m_CombinedMesh; // 0x18
	private Material m_Material; // 0x20
	private int m_CombinedMeshHashCode; // 0x28
	private static readonly ProfilingSampler k_OcclusionMeshProfilingSampler; // 0x0

	// Properties
	internal bool hasValidOcclusionMesh { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(XRPass xrPass) { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void SetMaterial(Material mat) { }

	// RVA: 0x29DFB00 Offset: 0x29DE500 VA: 0x1829DFB00
	internal bool get_hasValidOcclusionMesh() { }

	// RVA: 0x29DF180 Offset: 0x29DDB80 VA: 0x1829DF180
	internal void RenderOcclusionMesh(CommandBuffer cmd, float occlusionMeshScale, bool yFlip = False) { }

	// RVA: 0x29DF830 Offset: 0x29DE230 VA: 0x1829DF830
	internal void UpdateCombinedMesh() { }

	// RVA: 0x29DF0E0 Offset: 0x29DDAE0 VA: 0x1829DF0E0
	private bool IsOcclusionMeshSupported() { }

	// RVA: 0x29DF6C0 Offset: 0x29DE0C0 VA: 0x1829DF6C0
	private bool TryGetOcclusionMeshCombinedHashCode(out int hashCode) { }

	// RVA: 0x29DECD0 Offset: 0x29DD6D0 VA: 0x1829DECD0
	private void CreateOcclusionMeshCombined() { }

	// RVA: 0x29DFA70 Offset: 0x29DE470 VA: 0x1829DFA70
	private static void .cctor() { }
}
