public sealed class PostProcessAttribute : Attribute // TypeDefIndex: 16945
{
	// Fields
	public readonly Type renderer; // 0x10
	public readonly PostProcessEvent eventType; // 0x18
	public readonly string menuItem; // 0x20
	public readonly bool allowInSceneView; // 0x28
	internal readonly bool builtinEffect; // 0x29

	// Methods

	// RVA: 0x29A4940 Offset: 0x29A3340 VA: 0x1829A4940
	public void .ctor(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = True) { }

	// RVA: 0x29A48D0 Offset: 0x29A32D0 VA: 0x1829A48D0
	internal void .ctor(Type renderer, string menuItem, bool allowInSceneView = True) { }
}
