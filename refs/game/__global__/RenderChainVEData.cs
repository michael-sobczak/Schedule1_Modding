internal struct RenderChainVEData // TypeDefIndex: 7123
{
	// Fields
	internal VisualElement prev; // 0x0
	internal VisualElement next; // 0x8
	internal VisualElement groupTransformAncestor; // 0x10
	internal VisualElement boneTransformAncestor; // 0x18
	internal VisualElement prevDirty; // 0x20
	internal VisualElement nextDirty; // 0x28
	internal RenderDataFlags flags; // 0x30
	internal int hierarchyDepth; // 0x34
	internal RenderDataDirtyTypes dirtiedValues; // 0x38
	internal uint dirtyID; // 0x3C
	internal RenderChainCommand firstCommand; // 0x40
	internal RenderChainCommand lastCommand; // 0x48
	internal RenderChainCommand firstClosingCommand; // 0x50
	internal RenderChainCommand lastClosingCommand; // 0x58
	internal bool isInChain; // 0x60
	internal bool isHierarchyHidden; // 0x61
	internal bool localFlipsWinding; // 0x62
	internal bool localTransformScaleZero; // 0x63
	internal bool worldFlipsWinding; // 0x64
	public bool worldTransformScaleZero; // 0x65
	internal ClipMethod clipMethod; // 0x68
	internal int childrenStencilRef; // 0x6C
	internal int childrenMaskDepth; // 0x70
	internal bool disableNudging; // 0x74
	internal MeshHandle data; // 0x78
	internal MeshHandle closingData; // 0x80
	internal Matrix4x4 verticesSpace; // 0x88
	internal int displacementUVStart; // 0xC8
	internal int displacementUVEnd; // 0xCC
	internal BMPAlloc transformID; // 0xD0
	internal BMPAlloc clipRectID; // 0xD8
	internal BMPAlloc opacityID; // 0xE0
	internal BMPAlloc textCoreSettingsID; // 0xE8
	internal BMPAlloc colorID; // 0xF0
	internal BMPAlloc backgroundColorID; // 0xF8
	internal BMPAlloc borderLeftColorID; // 0x100
	internal BMPAlloc borderTopColorID; // 0x108
	internal BMPAlloc borderRightColorID; // 0x110
	internal BMPAlloc borderBottomColorID; // 0x118
	internal BMPAlloc tintColorID; // 0x120
	internal float compositeOpacity; // 0x128
	internal Color backgroundColor; // 0x12C
	internal BasicNode<TextureEntry> textures; // 0x140

	// Properties
	internal RenderChainCommand lastClosingOrLastCommand { get; }
	public bool isIgnoringDynamicColorHint { get; }

	// Methods

	// RVA: 0x2E185F0 Offset: 0x2E16FF0 VA: 0x182E185F0
	internal RenderChainCommand get_lastClosingOrLastCommand() { }

	// RVA: 0x2E18520 Offset: 0x2E16F20 VA: 0x182E18520
	internal static bool AllocatesID(BMPAlloc alloc) { }

	// RVA: 0x2E18580 Offset: 0x2E16F80 VA: 0x182E18580
	internal static bool InheritsID(BMPAlloc alloc) { }

	// RVA: 0x2E185E0 Offset: 0x2E16FE0 VA: 0x182E185E0
	public bool get_isIgnoringDynamicColorHint() { }
}
