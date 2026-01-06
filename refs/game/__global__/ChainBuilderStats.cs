internal struct ChainBuilderStats // TypeDefIndex: 7114
{
	// Fields
	public uint elementsAdded; // 0x0
	public uint elementsRemoved; // 0x4
	public uint recursiveClipUpdates; // 0x8
	public uint recursiveClipUpdatesExpanded; // 0xC
	public uint nonRecursiveClipUpdates; // 0x10
	public uint recursiveTransformUpdates; // 0x14
	public uint recursiveTransformUpdatesExpanded; // 0x18
	public uint recursiveOpacityUpdates; // 0x1C
	public uint recursiveOpacityUpdatesExpanded; // 0x20
	public uint opacityIdUpdates; // 0x24
	public uint colorUpdates; // 0x28
	public uint colorUpdatesExpanded; // 0x2C
	public uint recursiveVisualUpdates; // 0x30
	public uint recursiveVisualUpdatesExpanded; // 0x34
	public uint nonRecursiveVisualUpdates; // 0x38
	public uint dirtyProcessed; // 0x3C
	public uint nudgeTransformed; // 0x40
	public uint boneTransformed; // 0x44
	public uint skipTransformed; // 0x48
	public uint visualUpdateTransformed; // 0x4C
	public uint updatedMeshAllocations; // 0x50
	public uint newMeshAllocations; // 0x54
	public uint groupTransformElementsChanged; // 0x58
	public uint immedateRenderersActive; // 0x5C
}
