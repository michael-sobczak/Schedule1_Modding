internal static class MeshBuilderNative // TypeDefIndex: 6713
{
	// Methods

	// RVA: 0x2EAA8D0 Offset: 0x2EA92D0 VA: 0x182EAA8D0
	public static MeshWriteDataInterface MakeBorder(MeshBuilderNative.NativeBorderParams borderParams, float posZ) { }

	// RVA: 0x2EAA9A0 Offset: 0x2EA93A0 VA: 0x182EAA9A0
	public static MeshWriteDataInterface MakeSolidRect(MeshBuilderNative.NativeRectParams rectParams, float posZ) { }

	// RVA: 0x2EAAA70 Offset: 0x2EA9470 VA: 0x182EAAA70
	public static MeshWriteDataInterface MakeTexturedRect(MeshBuilderNative.NativeRectParams rectParams, float posZ) { }

	// RVA: 0x2EAAC90 Offset: 0x2EA9690 VA: 0x182EAAC90
	public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, MeshBuilderNative.NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount) { }

	// RVA: 0x2EAAB50 Offset: 0x2EA9550 VA: 0x182EAAB50
	public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, MeshBuilderNative.NativeColorPage colorPage, int settingIndexOffset) { }

	// RVA: 0x2EAA870 Offset: 0x2EA9270 VA: 0x182EAA870
	private static void MakeBorder_Injected(ref MeshBuilderNative.NativeBorderParams borderParams, float posZ, out MeshWriteDataInterface ret) { }

	// RVA: 0x2EAA940 Offset: 0x2EA9340 VA: 0x182EAA940
	private static void MakeSolidRect_Injected(ref MeshBuilderNative.NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret) { }

	// RVA: 0x2EAAA10 Offset: 0x2EA9410 VA: 0x182EAAA10
	private static void MakeTexturedRect_Injected(ref MeshBuilderNative.NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret) { }

	// RVA: 0x2EAAC10 Offset: 0x2EA9610 VA: 0x182EAAC10
	private static void MakeVectorGraphicsStretchBackground_Injected(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Rect sourceUV, ScaleMode scaleMode, ref Color tint, ref MeshBuilderNative.NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount, out MeshWriteDataInterface ret) { }

	// RVA: 0x2EAAAE0 Offset: 0x2EA94E0 VA: 0x182EAAAE0
	private static void MakeVectorGraphics9SliceBackground_Injected(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Vector4 sliceLTRB, ref Color tint, ref MeshBuilderNative.NativeColorPage colorPage, int settingIndexOffset, out MeshWriteDataInterface ret) { }
}
