internal static class Native // TypeDefIndex: 6154
{
	// Methods

	[FreeFunction]
	// RVA: 0x2DB97B0 Offset: 0x2DB81B0 VA: 0x182DB97B0
	public static IntPtr YGNodeNewWithConfig(IntPtr config) { }

	// RVA: 0x2DB9300 Offset: 0x2DB7D00 VA: 0x182DB9300
	public static void YGNodeFree(IntPtr ygNode) { }

	[FreeFunction(Name = "YGNodeFree", IsThreadSafe = True)]
	// RVA: 0x2DB92C0 Offset: 0x2DB7CC0 VA: 0x182DB92C0
	private static void YGNodeFreeInternal(IntPtr ygNode) { }

	[FreeFunction]
	// RVA: 0x2DBA460 Offset: 0x2DB8E60 VA: 0x182DBA460
	public static void YGSetManagedObject(IntPtr ygNode, YogaNode node) { }

	[FreeFunction]
	// RVA: 0x2DB9880 Offset: 0x2DB8280 VA: 0x182DB9880
	public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2DB9000 Offset: 0x2DB7A00 VA: 0x182DB9000
	public static IntPtr YGConfigGetDefault() { }

	[FreeFunction]
	// RVA: 0x2DB9070 Offset: 0x2DB7A70 VA: 0x182DB9070
	public static IntPtr YGConfigNew() { }

	// RVA: 0x2DB8FB0 Offset: 0x2DB79B0 VA: 0x182DB8FB0
	public static void YGConfigFree(IntPtr config) { }

	[FreeFunction(Name = "YGConfigFree", IsThreadSafe = True)]
	// RVA: 0x2DB8F70 Offset: 0x2DB7970 VA: 0x182DB8F70
	private static void YGConfigFreeInternal(IntPtr config) { }

	[FreeFunction]
	// RVA: 0x2DB90F0 Offset: 0x2DB7AF0 VA: 0x182DB90F0
	public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults) { }

	[FreeFunction]
	// RVA: 0x2DB9030 Offset: 0x2DB7A30 VA: 0x182DB9030
	public static bool YGConfigGetUseWebDefaults(IntPtr config) { }

	[FreeFunction]
	// RVA: 0x2DB90A0 Offset: 0x2DB7AA0 VA: 0x182DB90A0
	public static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint) { }

	[FreeFunction]
	// RVA: 0x2DB9390 Offset: 0x2DB7D90 VA: 0x182DB9390
	public static void YGNodeInsertChild(IntPtr node, IntPtr child, uint index) { }

	[FreeFunction]
	// RVA: 0x2DB97F0 Offset: 0x2DB81F0 VA: 0x182DB97F0
	public static void YGNodeRemoveChild(IntPtr node, IntPtr child) { }

	[FreeFunction]
	// RVA: 0x2DB9200 Offset: 0x2DB7C00 VA: 0x182DB9200
	public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection) { }

	[FreeFunction]
	// RVA: 0x2DB9670 Offset: 0x2DB8070 VA: 0x182DB9670
	public static void YGNodeMarkDirty(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB93F0 Offset: 0x2DB7DF0 VA: 0x182DB93F0
	public static bool YGNodeIsDirty(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB9270 Offset: 0x2DB7C70 VA: 0x182DB9270
	public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode) { }

	[FreeFunction(Name = "YogaCallback::SetMeasureFunc")]
	// RVA: 0x2DB9920 Offset: 0x2DB8320 VA: 0x182DB9920
	public static void YGNodeSetMeasureFunc(IntPtr node) { }

	[FreeFunction(Name = "YogaCallback::RemoveMeasureFunc")]
	// RVA: 0x2DB9840 Offset: 0x2DB8240 VA: 0x182DB9840
	public static void YGNodeRemoveMeasureFunc(IntPtr node) { }

	[RequiredByNativeCode]
	// RVA: 0x2DB96B0 Offset: 0x2DB80B0 VA: 0x182DB96B0
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x2DB9140 Offset: 0x2DB7B40 VA: 0x182DB9140
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	[FreeFunction]
	// RVA: 0x2DB98D0 Offset: 0x2DB82D0 VA: 0x182DB98D0
	public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout) { }

	[FreeFunction]
	// RVA: 0x2DB9350 Offset: 0x2DB7D50 VA: 0x182DB9350
	public static bool YGNodeGetHasNewLayout(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB9960 Offset: 0x2DB8360 VA: 0x182DB9960
	public static YogaDirection YGNodeStyleGetDirection(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB9BD0 Offset: 0x2DB85D0 VA: 0x182DB9BD0
	public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection) { }

	[FreeFunction]
	// RVA: 0x2DB9E20 Offset: 0x2DB8820 VA: 0x182DB9E20
	public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent) { }

	[FreeFunction]
	// RVA: 0x2DB99A0 Offset: 0x2DB83A0 VA: 0x182DB99A0
	public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent) { }

	[FreeFunction]
	// RVA: 0x2DB99E0 Offset: 0x2DB83E0 VA: 0x182DB99E0
	public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems) { }

	[FreeFunction]
	// RVA: 0x2DB9A20 Offset: 0x2DB8420 VA: 0x182DB9A20
	public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf) { }

	[FreeFunction]
	// RVA: 0x2DBA2F0 Offset: 0x2DB8CF0 VA: 0x182DBA2F0
	public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType) { }

	[FreeFunction]
	// RVA: 0x2DB9CB0 Offset: 0x2DB86B0 VA: 0x182DB9CB0
	public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap) { }

	[FreeFunction]
	// RVA: 0x2DBA1C0 Offset: 0x2DB8BC0 VA: 0x182DBA1C0
	public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap) { }

	[FreeFunction]
	// RVA: 0x2DB9AB0 Offset: 0x2DB84B0 VA: 0x182DB9AB0
	public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display) { }

	[FreeFunction]
	// RVA: 0x2DB9CF0 Offset: 0x2DB86F0 VA: 0x182DB9CF0
	public static void YGNodeStyleSetFlex(IntPtr node, float flex) { }

	[FreeFunction]
	// RVA: 0x2DB9C10 Offset: 0x2DB8610 VA: 0x182DB9C10
	public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow) { }

	[FreeFunction]
	// RVA: 0x2DB9C60 Offset: 0x2DB8660 VA: 0x182DB9C60
	public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink) { }

	[FreeFunction]
	// RVA: 0x2DB9B80 Offset: 0x2DB8580 VA: 0x182DB9B80
	public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis) { }

	[FreeFunction]
	// RVA: 0x2DB9B30 Offset: 0x2DB8530 VA: 0x182DB9B30
	public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis) { }

	[FreeFunction]
	// RVA: 0x2DB9AF0 Offset: 0x2DB84F0 VA: 0x182DB9AF0
	public static void YGNodeStyleSetFlexBasisAuto(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DBA410 Offset: 0x2DB8E10 VA: 0x182DBA410
	public static void YGNodeStyleSetWidth(IntPtr node, float width) { }

	[FreeFunction]
	// RVA: 0x2DBA3C0 Offset: 0x2DB8DC0 VA: 0x182DBA3C0
	public static void YGNodeStyleSetWidthPercent(IntPtr node, float width) { }

	[FreeFunction]
	// RVA: 0x2DBA380 Offset: 0x2DB8D80 VA: 0x182DBA380
	public static void YGNodeStyleSetWidthAuto(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB9DD0 Offset: 0x2DB87D0 VA: 0x182DB9DD0
	public static void YGNodeStyleSetHeight(IntPtr node, float height) { }

	[FreeFunction]
	// RVA: 0x2DB9D80 Offset: 0x2DB8780 VA: 0x182DB9D80
	public static void YGNodeStyleSetHeightPercent(IntPtr node, float height) { }

	[FreeFunction]
	// RVA: 0x2DB9D40 Offset: 0x2DB8740 VA: 0x182DB9D40
	public static void YGNodeStyleSetHeightAuto(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DBA170 Offset: 0x2DB8B70 VA: 0x182DBA170
	public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth) { }

	[FreeFunction]
	// RVA: 0x2DBA120 Offset: 0x2DB8B20 VA: 0x182DBA120
	public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth) { }

	[FreeFunction]
	// RVA: 0x2DBA0D0 Offset: 0x2DB8AD0 VA: 0x182DBA0D0
	public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight) { }

	[FreeFunction]
	// RVA: 0x2DBA080 Offset: 0x2DB8A80 VA: 0x182DBA080
	public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight) { }

	[FreeFunction]
	// RVA: 0x2DBA030 Offset: 0x2DB8A30 VA: 0x182DBA030
	public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth) { }

	[FreeFunction]
	// RVA: 0x2DB9FE0 Offset: 0x2DB89E0 VA: 0x182DB9FE0
	public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth) { }

	[FreeFunction]
	// RVA: 0x2DB9F90 Offset: 0x2DB8990 VA: 0x182DB9F90
	public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight) { }

	[FreeFunction]
	// RVA: 0x2DB9F40 Offset: 0x2DB8940 VA: 0x182DB9F40
	public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight) { }

	[FreeFunction]
	// RVA: 0x2DBA330 Offset: 0x2DB8D30 VA: 0x182DBA330
	public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position) { }

	[FreeFunction]
	// RVA: 0x2DBA2A0 Offset: 0x2DB8CA0 VA: 0x182DBA2A0
	public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position) { }

	[FreeFunction]
	// RVA: 0x2DB9EF0 Offset: 0x2DB88F0 VA: 0x182DB9EF0
	public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin) { }

	[FreeFunction]
	// RVA: 0x2DB9EA0 Offset: 0x2DB88A0 VA: 0x182DB9EA0
	public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin) { }

	[FreeFunction]
	// RVA: 0x2DB9E60 Offset: 0x2DB8860 VA: 0x182DB9E60
	public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge) { }

	[FreeFunction]
	// RVA: 0x2DBA250 Offset: 0x2DB8C50 VA: 0x182DBA250
	public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding) { }

	[FreeFunction]
	// RVA: 0x2DBA200 Offset: 0x2DB8C00 VA: 0x182DBA200
	public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding) { }

	[FreeFunction]
	// RVA: 0x2DB9A60 Offset: 0x2DB8460 VA: 0x182DB9A60
	public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border) { }

	[FreeFunction]
	// RVA: 0x2DB94F0 Offset: 0x2DB7EF0 VA: 0x182DB94F0
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB95F0 Offset: 0x2DB7FF0 VA: 0x182DB95F0
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB95B0 Offset: 0x2DB7FB0 VA: 0x182DB95B0
	public static float YGNodeLayoutGetRight(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB9470 Offset: 0x2DB7E70 VA: 0x182DB9470
	public static float YGNodeLayoutGetBottom(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB9630 Offset: 0x2DB8030 VA: 0x182DB9630
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB94B0 Offset: 0x2DB7EB0 VA: 0x182DB94B0
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2DB9530 Offset: 0x2DB7F30 VA: 0x182DB9530
	public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge) { }

	[FreeFunction]
	// RVA: 0x2DB9570 Offset: 0x2DB7F70 VA: 0x182DB9570
	public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge) { }

	[FreeFunction]
	// RVA: 0x2DB9430 Offset: 0x2DB7E30 VA: 0x182DB9430
	public static float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge) { }
}
