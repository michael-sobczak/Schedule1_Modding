public class SceneManagerAPI // TypeDefIndex: 11982
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static SceneManagerAPI ActiveAPI { get; }
	public static SceneManagerAPI overrideAPI { get; }

	// Methods

	// RVA: 0x2CE8CB0 Offset: 0x2CE76B0 VA: 0x182CE8CB0
	internal static SceneManagerAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x2CE8D60 Offset: 0x2CE7760 VA: 0x182CE8D60
	public static SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected internal void .ctor() { }

	// RVA: 0x2CE8AE0 Offset: 0x2CE74E0 VA: 0x182CE8AE0 Slot: 4
	protected internal virtual int GetNumScenesInBuildSettings() { }

	// RVA: 0x2CE8BE0 Offset: 0x2CE75E0 VA: 0x182CE8BE0 Slot: 5
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x2CE8C40 Offset: 0x2CE7640 VA: 0x182CE8C40
	private static void .cctor() { }
}
