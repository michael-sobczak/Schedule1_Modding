public interface IVertexModifier // TypeDefIndex: 16497
{
	// Methods

	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyVertices(List<UIVertex> verts);
}
