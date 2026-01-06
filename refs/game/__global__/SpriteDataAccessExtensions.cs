public static class SpriteDataAccessExtensions // TypeDefIndex: 11901
{
	// Methods

	// RVA: -1 Offset: -1
	private static void CheckAttributeTypeMatchesAndThrow<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF515E0 Offset: 0xF4FFE0 VA: 0x180F515E0
	|-SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<Color32>
	|-SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<Vector2>
	|-SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<Vector3>
	|-SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static NativeSlice<T> GetVertexAttribute<T>(Sprite sprite, VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF518F0 Offset: 0xF502F0 VA: 0x180F518F0
	|-SpriteDataAccessExtensions.GetVertexAttribute<Color32>
	|-SpriteDataAccessExtensions.GetVertexAttribute<Vector2>
	|-SpriteDataAccessExtensions.GetVertexAttribute<Vector3>
	|
	|-RVA: 0xF519F0 Offset: 0xF503F0 VA: 0x180F519F0
	|-SpriteDataAccessExtensions.GetVertexAttribute<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x2CC74D0 Offset: 0x2CC5ED0 VA: 0x182CC74D0
	public static NativeArray<ushort> GetIndices(Sprite sprite) { }

	[NativeName("HasChannel")]
	[Extension]
	// RVA: 0x2CC7580 Offset: 0x2CC5F80 VA: 0x182CC7580
	public static bool HasVertexAttribute(Sprite sprite, VertexAttribute channel) { }

	// RVA: 0x2CC7470 Offset: 0x2CC5E70 VA: 0x182CC7470
	private static SpriteChannelInfo GetIndicesInfo(Sprite sprite) { }

	// RVA: 0x2CC73C0 Offset: 0x2CC5DC0 VA: 0x182CC73C0
	private static SpriteChannelInfo GetChannelInfo(Sprite sprite, VertexAttribute channel) { }

	// RVA: 0x2CC7420 Offset: 0x2CC5E20 VA: 0x182CC7420
	private static void GetIndicesInfo_Injected(Sprite sprite, out SpriteChannelInfo ret) { }

	// RVA: 0x2CC7370 Offset: 0x2CC5D70 VA: 0x182CC7370
	private static void GetChannelInfo_Injected(Sprite sprite, VertexAttribute channel, out SpriteChannelInfo ret) { }
}
