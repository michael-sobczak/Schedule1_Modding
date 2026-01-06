internal abstract class AtlasBase // TypeDefIndex: 6163
{
	// Fields
	internal TextureRegistry textureRegistry; // 0x10

	// Methods

	// RVA: 0x2DA87A0 Offset: 0x2DA71A0 VA: 0x182DA87A0 Slot: 4
	public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void Reset() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 7
	protected virtual void OnAssignedToPanel(IPanel panel) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	protected virtual void OnRemovedFromPanel(IPanel panel) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 9
	protected virtual void OnUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x2250F20 Offset: 0x224F920 VA: 0x182250F20
	internal void InvokeAssignedToPanel(IPanel panel) { }

	// RVA: 0x79ED10 Offset: 0x79D710 VA: 0x18079ED10
	internal void InvokeRemovedFromPanel(IPanel panel) { }

	// RVA: 0x2250F40 Offset: 0x224F940 VA: 0x182250F40
	internal void InvokeUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x2DA86B0 Offset: 0x2DA70B0 VA: 0x182DA86B0
	protected static void RepaintTexturedElements(IPanel panel) { }

	// RVA: 0x2DA8780 Offset: 0x2DA7180 VA: 0x182DA8780
	protected void SetDynamicTexture(TextureId id, Texture texture) { }

	// RVA: 0x2DA8810 Offset: 0x2DA7210 VA: 0x182DA8810
	protected void .ctor() { }
}
