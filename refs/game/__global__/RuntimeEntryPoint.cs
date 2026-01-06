public class RuntimeEntryPoint : MonoBehaviour // TypeDefIndex: 18242
{
	// Fields
	private static RuntimeEntryPoint _entryPoint; // 0x0
	[SerializeField]
	private ShaderResources _shaderResources; // 0x20
	internal bool _isDestroyed; // 0x28

	// Properties
	public static RuntimeEntryPoint EntryPoint { get; }
	public ShaderResources Resources { get; }

	// Methods

	// RVA: 0x2F68D50 Offset: 0x2F67750 VA: 0x182F68D50
	public static RuntimeEntryPoint get_EntryPoint() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ShaderResources get_Resources() { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x2F68930 Offset: 0x2F67330 VA: 0x182F68930
	internal static void Load() { }

	// RVA: 0x2F68C80 Offset: 0x2F67680 VA: 0x182F68C80
	internal static void Unload() { }

	// RVA: 0x2F685F0 Offset: 0x2F66FF0 VA: 0x182F685F0
	private static RuntimeEntryPoint CreateEntryPoint() { }

	// RVA: 0x2F686E0 Offset: 0x2F670E0 VA: 0x182F686E0
	private static RuntimeEntryPoint FindExistingEntryPointInScene() { }

	// RVA: 0x2F684C0 Offset: 0x2F66EC0 VA: 0x182F684C0
	private void LoadResources() { }

	// RVA: 0x2F68BF0 Offset: 0x2F675F0 VA: 0x182F68BF0
	private void UnloadResources() { }

	// RVA: 0x2F684C0 Offset: 0x2F66EC0 VA: 0x182F684C0
	private void Awake() { }

	// RVA: 0x2F68B10 Offset: 0x2F67510 VA: 0x182F68B10
	private void OnDestroy() { }

	// RVA: 0x2F68D40 Offset: 0x2F67740 VA: 0x182F68D40
	public void .ctor() { }
}
