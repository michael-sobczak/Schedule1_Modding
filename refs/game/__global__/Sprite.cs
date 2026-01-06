public sealed class Sprite : Object // TypeDefIndex: 11894
{
	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public float pixelsPerUnit { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public bool packed { get; }
	public SpritePackingRotation packingRotation { get; }
	public Vector2[] vertices { get; }
	public ushort[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CC8470 Offset: 0x2CC6E70 VA: 0x182CC8470
	private void .ctor() { }

	// RVA: 0x2CC8390 Offset: 0x2CC6D90 VA: 0x182CC8390
	internal int GetPackingRotation() { }

	// RVA: 0x2CC8350 Offset: 0x2CC6D50 VA: 0x182CC8350
	internal int GetPacked() { }

	// RVA: 0x2CC8260 Offset: 0x2CC6C60 VA: 0x182CC8260
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x2CC8300 Offset: 0x2CC6D00 VA: 0x182CC8300
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x2CC8420 Offset: 0x2CC6E20 VA: 0x182CC8420
	internal Vector4 GetPadding() { }

	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = True)]
	// RVA: 0x2CC7750 Offset: 0x2CC6150 VA: 0x182CC7750
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x2CC85F0 Offset: 0x2CC6FF0 VA: 0x182CC85F0
	public Bounds get_bounds() { }

	// RVA: 0x2CC87C0 Offset: 0x2CC71C0 VA: 0x182CC87C0
	public Rect get_rect() { }

	// RVA: 0x2CC8550 Offset: 0x2CC6F50 VA: 0x182CC8550
	public Vector4 get_border() { }

	// RVA: 0x2CC8810 Offset: 0x2CC7210 VA: 0x182CC8810
	public Texture2D get_texture() { }

	[NativeMethod("GetPixelsToUnits")]
	// RVA: 0x2CC8730 Offset: 0x2CC7130 VA: 0x182CC8730
	public float get_pixelsPerUnit() { }

	[NativeMethod("GetAlphaTexture")]
	// RVA: 0x2CC84C0 Offset: 0x2CC6EC0 VA: 0x182CC84C0
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethod("GetPivotInPixels")]
	// RVA: 0x2CC86E0 Offset: 0x2CC70E0 VA: 0x182CC86E0
	public Vector2 get_pivot() { }

	// RVA: 0x2CC8650 Offset: 0x2CC7050 VA: 0x182CC8650
	public bool get_packed() { }

	// RVA: 0x2CC8390 Offset: 0x2CC6D90 VA: 0x182CC8390
	public SpritePackingRotation get_packingRotation() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	// RVA: 0x2CC88D0 Offset: 0x2CC72D0 VA: 0x182CC88D0
	public Vector2[] get_vertices() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	// RVA: 0x2CC8850 Offset: 0x2CC7250 VA: 0x182CC8850
	public ushort[] get_triangles() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	// RVA: 0x2CC8890 Offset: 0x2CC7290 VA: 0x182CC8890
	public Vector2[] get_uv() { }

	// RVA: 0x2CC7A90 Offset: 0x2CC6490 VA: 0x182CC7A90
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x2CC7B00 Offset: 0x2CC6500 VA: 0x182CC7B00
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	// RVA: 0x2CC77F0 Offset: 0x2CC61F0 VA: 0x182CC77F0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x2CC7850 Offset: 0x2CC6250 VA: 0x182CC7850
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x2CC8140 Offset: 0x2CC6B40 VA: 0x182CC8140
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x2CC79D0 Offset: 0x2CC63D0 VA: 0x182CC79D0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x2CC7920 Offset: 0x2CC6320 VA: 0x182CC7920
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x2CC8210 Offset: 0x2CC6C10 VA: 0x182CC8210
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x2CC82B0 Offset: 0x2CC6CB0 VA: 0x182CC82B0
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x2CC83D0 Offset: 0x2CC6DD0 VA: 0x182CC83D0
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x2CC76D0 Offset: 0x2CC60D0 VA: 0x182CC76D0
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x2CC85A0 Offset: 0x2CC6FA0 VA: 0x182CC85A0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2CC8770 Offset: 0x2CC7170 VA: 0x182CC8770
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2CC8500 Offset: 0x2CC6F00 VA: 0x182CC8500
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x2CC8690 Offset: 0x2CC7090 VA: 0x182CC8690
	private void get_pivot_Injected(out Vector2 ret) { }
}
