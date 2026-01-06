public static class TerrainCallbacks // TypeDefIndex: 18996
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2D44900 Offset: 0x2D43300 VA: 0x182D44900
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCode]
	// RVA: 0x2D44A10 Offset: 0x2D43410 VA: 0x182D44A10
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }
}
