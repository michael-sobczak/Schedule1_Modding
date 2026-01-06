internal interface IStylePainter // TypeDefIndex: 6849
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DrawText(TextElement te);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DrawImmediate(Action callback, bool cullingEnabled);
}
