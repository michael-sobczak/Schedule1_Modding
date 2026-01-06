public interface IMeshModifier // TypeDefIndex: 16498
{
	// Methods

	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", False)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyMesh(Mesh mesh);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ModifyMesh(VertexHelper verts);
}
