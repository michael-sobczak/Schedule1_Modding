internal struct UIRVEShaderInfoAllocator // TypeDefIndex: 7149
{
	// Fields
	private BaseShaderInfoStorage m_Storage; // 0x0
	private BitmapAllocator32 m_TransformAllocator; // 0x8
	private BitmapAllocator32 m_ClipRectAllocator; // 0x28
	private BitmapAllocator32 m_OpacityAllocator; // 0x48
	private BitmapAllocator32 m_ColorAllocator; // 0x68
	private BitmapAllocator32 m_TextSettingsAllocator; // 0x88
	private bool m_StorageReallyCreated; // 0xA8
	private bool m_VertexTexturingEnabled; // 0xA9
	private NativeArray<Transform3x4> m_Transforms; // 0xB0
	private NativeArray<Vector4> m_ClipRects; // 0xC0
	internal static readonly Vector2Int identityTransformTexel; // 0x0
	internal static readonly Vector2Int infiniteClipRectTexel; // 0x8
	internal static readonly Vector2Int fullOpacityTexel; // 0x10
	internal static readonly Vector2Int clearColorTexel; // 0x18
	internal static readonly Vector2Int defaultTextCoreSettingsTexel; // 0x20
	internal static readonly Matrix4x4 identityTransformValue; // 0x28
	internal static readonly Vector4 identityTransformRow0Value; // 0x68
	internal static readonly Vector4 identityTransformRow1Value; // 0x78
	internal static readonly Vector4 identityTransformRow2Value; // 0x88
	internal static readonly Vector4 infiniteClipRectValue; // 0x98
	internal static readonly Vector4 fullOpacityValue; // 0xA8
	internal static readonly Vector4 clearColorValue; // 0xB8
	internal static readonly TextCoreSettings defaultTextCoreSettingsValue; // 0xC8
	public static readonly BMPAlloc identityTransform; // 0x108
	public static readonly BMPAlloc infiniteClipRect; // 0x110
	public static readonly BMPAlloc fullOpacity; // 0x118
	public static readonly BMPAlloc clearColor; // 0x120
	public static readonly BMPAlloc defaultTextCoreSettings; // 0x128

	// Properties
	private static int pageWidth { get; }
	private static int pageHeight { get; }
	public NativeSlice<Transform3x4> transformConstants { get; }
	public NativeSlice<Vector4> clipRectConstants { get; }
	public Texture atlas { get; }

	// Methods

	// RVA: 0x2E2D870 Offset: 0x2E2C270 VA: 0x182E2D870
	private static int get_pageWidth() { }

	// RVA: 0x2E2D860 Offset: 0x2E2C260 VA: 0x182E2D860
	private static int get_pageHeight() { }

	// RVA: 0x2E2B020 Offset: 0x2E29A20 VA: 0x182E2B020
	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) { }

	// RVA: 0x2E2AFD0 Offset: 0x2E299D0 VA: 0x182E2AFD0
	private static int AllocToConstantBufferIndex(BMPAlloc alloc) { }

	// RVA: 0x2E2B1F0 Offset: 0x2E29BF0 VA: 0x182E2B1F0
	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	// RVA: 0x2E2D880 Offset: 0x2E2C280 VA: 0x182E2D880
	public NativeSlice<Transform3x4> get_transformConstants() { }

	// RVA: 0x2E2D7F0 Offset: 0x2E2C1F0 VA: 0x182E2D7F0
	public NativeSlice<Vector4> get_clipRectConstants() { }

	// RVA: 0x2E2D750 Offset: 0x2E2C150 VA: 0x182E2D750
	public Texture get_atlas() { }

	// RVA: 0x2E2B5D0 Offset: 0x2E29FD0 VA: 0x182E2B5D0
	public void Construct() { }

	// RVA: 0x2E2BE80 Offset: 0x2E2A880 VA: 0x182E2BE80
	private void ReallyCreateStorage() { }

	// RVA: 0x2E2B910 Offset: 0x2E2A310 VA: 0x182E2B910
	public void Dispose() { }

	// RVA: 0x2E2BD40 Offset: 0x2E2A740 VA: 0x182E2BD40
	public void IssuePendingStorageChanges() { }

	// RVA: 0x2E2B0B0 Offset: 0x2E29AB0 VA: 0x182E2B0B0
	public BMPAlloc AllocTransform() { }

	// RVA: 0x2E2AD40 Offset: 0x2E29740 VA: 0x182E2AD40
	public BMPAlloc AllocClipRect() { }

	// RVA: 0x2E2AEF0 Offset: 0x2E298F0 VA: 0x182E2AEF0
	public BMPAlloc AllocOpacity() { }

	// RVA: 0x2E2AE80 Offset: 0x2E29880 VA: 0x182E2AE80
	public BMPAlloc AllocColor() { }

	// RVA: 0x2E2AF60 Offset: 0x2E29960 VA: 0x182E2AF60
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	// RVA: 0x2E2CE90 Offset: 0x2E2B890 VA: 0x182E2CE90
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	// RVA: 0x2E2C5D0 Offset: 0x2E2AFD0 VA: 0x182E2C5D0
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	// RVA: 0x2E2C930 Offset: 0x2E2B330 VA: 0x182E2C930
	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	// RVA: 0x2E2C780 Offset: 0x2E2B180 VA: 0x182E2C780
	public void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext) { }

	// RVA: 0x2E2CA60 Offset: 0x2E2B460 VA: 0x182E2CA60
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) { }

	// RVA: 0x2E2BCA0 Offset: 0x2E2A6A0 VA: 0x182E2BCA0
	public void FreeTransform(BMPAlloc alloc) { }

	// RVA: 0x2E2BA20 Offset: 0x2E2A420 VA: 0x182E2BA20
	public void FreeClipRect(BMPAlloc alloc) { }

	// RVA: 0x2E2BB60 Offset: 0x2E2A560 VA: 0x182E2BB60
	public void FreeOpacity(BMPAlloc alloc) { }

	// RVA: 0x2E2BAC0 Offset: 0x2E2A4C0 VA: 0x182E2BAC0
	public void FreeColor(BMPAlloc alloc) { }

	// RVA: 0x2E2BC00 Offset: 0x2E2A600 VA: 0x182E2BC00
	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	// RVA: 0x2E2D310 Offset: 0x2E2BD10 VA: 0x182E2D310
	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x2E2B380 Offset: 0x2E29D80 VA: 0x182E2B380
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x2E2BD60 Offset: 0x2E2A760 VA: 0x182E2BD60
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x2E2B4B0 Offset: 0x2E29EB0 VA: 0x182E2B4B0
	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x2E2D1F0 Offset: 0x2E2BBF0 VA: 0x182E2D1F0
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	// RVA: 0x2E2D440 Offset: 0x2E2BE40 VA: 0x182E2D440
	private static void .cctor() { }
}
