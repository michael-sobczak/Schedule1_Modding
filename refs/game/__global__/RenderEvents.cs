internal static class RenderEvents // TypeDefIndex: 7152
{
	// Fields
	private static readonly float VisibilityTreshold; // 0x0

	// Methods

	// RVA: 0x2E1C4F0 Offset: 0x2E1AEF0 VA: 0x182E1C4F0
	internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1C6A0 Offset: 0x2E1B0A0 VA: 0x182E1C6A0
	internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1C610 Offset: 0x2E1B010 VA: 0x182E1C610
	internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1C7B0 Offset: 0x2E1B1B0 VA: 0x182E1C7B0
	internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1C890 Offset: 0x2E1B290 VA: 0x182E1C890
	internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1B640 Offset: 0x2E1A040 VA: 0x182E1B640
	private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) { }

	// RVA: 0x2E1B350 Offset: 0x2E19D50 VA: 0x182E1B350
	private static Vector4 GetClipRectIDClipInfo(VisualElement ve) { }

	// RVA: 0x2E18600 Offset: 0x2E17000 VA: 0x182E18600
	internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) { }

	// RVA: 0x2E18E60 Offset: 0x2E17860 VA: 0x182E18E60
	internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x2E19C50 Offset: 0x2E18650 VA: 0x182E19C50
	private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1A2D0 Offset: 0x2E18CD0 VA: 0x182E1A2D0
	private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = False) { }

	// RVA: 0x2E1C280 Offset: 0x2E1AC80 VA: 0x182E1C280
	private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1A720 Offset: 0x2E19120 VA: 0x182E1A720
	private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1AC60 Offset: 0x2E19660 VA: 0x182E1AC60
	private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats) { }

	// RVA: 0x2E1D330 Offset: 0x2E1BD30 VA: 0x182E1D330
	private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x2E1C0D0 Offset: 0x2E1AAD0 VA: 0x182E1C0D0
	private static bool IsElementHierarchyHidden(VisualElement ve) { }

	// RVA: 0x2E1B5C0 Offset: 0x2E19FC0 VA: 0x182E1B5C0
	private static VisualElement GetLastDeepestChild(VisualElement ve) { }

	// RVA: 0x2E1B240 Offset: 0x2E19C40 VA: 0x182E1B240
	private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x2E1D1D0 Offset: 0x2E1BBD0 VA: 0x182E1D1D0
	private static bool UpdateLocalFlipsWinding(VisualElement ve) { }

	// RVA: 0x2E1D8F0 Offset: 0x2E1C2F0 VA: 0x182E1D8F0
	private static void UpdateWorldFlipsWinding(VisualElement ve) { }

	// RVA: 0x2E1D960 Offset: 0x2E1C360 VA: 0x182E1D960
	private static void UpdateZeroScaling(VisualElement ve) { }

	// RVA: 0x2E1C240 Offset: 0x2E1AC40 VA: 0x182E1C240
	private static bool NeedsTransformID(VisualElement ve) { }

	// RVA: 0x2E1C130 Offset: 0x2E1AB30 VA: 0x182E1C130
	internal static bool NeedsColorID(VisualElement ve) { }

	// RVA: 0x2E1C150 Offset: 0x2E1AB50 VA: 0x182E1C150
	internal static bool NeedsTextCoreSettings(VisualElement ve) { }

	// RVA: 0x2E1B810 Offset: 0x2E1A210 VA: 0x182E1B810
	private static bool InitColorIDs(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x2E1C9E0 Offset: 0x2E1B3E0 VA: 0x182E1C9E0
	private static void SetColorValues(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x2E1DB70 Offset: 0x2E1C570 VA: 0x182E1DB70
	private static void .cctor() { }
}
