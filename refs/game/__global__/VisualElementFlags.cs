internal enum VisualElementFlags // TypeDefIndex: 7020
{
	// Fields
	public int value__; // 0x0
	public const VisualElementFlags WorldTransformDirty = 1;
	public const VisualElementFlags WorldTransformInverseDirty = 2;
	public const VisualElementFlags WorldClipDirty = 4;
	public const VisualElementFlags BoundingBoxDirty = 8;
	public const VisualElementFlags WorldBoundingBoxDirty = 16;
	public const VisualElementFlags EventCallbackParentCategoriesDirty = 32;
	public const VisualElementFlags LayoutManual = 64;
	public const VisualElementFlags CompositeRoot = 128;
	public const VisualElementFlags RequireMeasureFunction = 256;
	public const VisualElementFlags EnableViewDataPersistence = 512;
	public const VisualElementFlags DisableClipping = 1024;
	public const VisualElementFlags NeedsAttachToPanelEvent = 2048;
	public const VisualElementFlags HierarchyDisplayed = 4096;
	public const VisualElementFlags StyleInitialized = 8192;
	public const VisualElementFlags Init = 4159;
}
