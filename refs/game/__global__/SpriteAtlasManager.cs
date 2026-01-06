public class SpriteAtlasManager // TypeDefIndex: 11902
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CC70A0 Offset: 0x2CC5AA0 VA: 0x182CC70A0
	private static bool RequestAtlas(string tag) { }

	[CompilerGenerated]
	// RVA: 0x2CC7150 Offset: 0x2CC5B50 VA: 0x182CC7150
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGenerated]
	// RVA: 0x2CC7230 Offset: 0x2CC5C30 VA: 0x182CC7230
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCode]
	// RVA: 0x2CC7000 Offset: 0x2CC5A00 VA: 0x182CC7000
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x2CC7060 Offset: 0x2CC5A60 VA: 0x182CC7060
	internal static void Register(SpriteAtlas spriteAtlas) { }
}
