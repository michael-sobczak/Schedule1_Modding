public class ResizableContainer : FloatingContainer // TypeDefIndex: 18214
{
	// Fields
	[Tooltip("Minimum and maximum range for width and height of the RectTransform.")]
	public FloatRange2D SizeLimits; // 0x88

	// Methods

	// RVA: 0xDAA0B0 Offset: 0xDA8AB0 VA: 0x180DAA0B0
	public void SetSizeAndShow(Vector2 size, bool ignoreSizeLimits = False) { }

	// RVA: 0xDA9FE0 Offset: 0xDA89E0 VA: 0x180DA9FE0 Slot: 27
	protected virtual void ResizeAndShow(Vector2 desiredSize, bool ignoreSizeLimits) { }

	// RVA: 0xDAA0D0 Offset: 0xDA8AD0 VA: 0x180DAA0D0
	public void .ctor() { }
}
