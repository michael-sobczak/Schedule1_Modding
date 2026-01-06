public sealed class VolumeManager // TypeDefIndex: 13892
{
	// Fields
	private static readonly Lazy<VolumeManager> s_Instance; // 0x0
	[CompilerGenerated]
	private VolumeStack <stack>k__BackingField; // 0x10
	private static readonly Dictionary<Type, List<ValueTuple<string, Type>>> s_SupportedVolumeComponentsForRenderPipeline; // 0x8
	[CompilerGenerated]
	private Type[] <baseComponentTypeArray>k__BackingField; // 0x18
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<Volume>> m_SortedVolumes; // 0x20
	private readonly List<Volume> m_Volumes; // 0x28
	private readonly Dictionary<int, bool> m_SortNeeded; // 0x30
	private readonly List<VolumeComponent> m_ComponentsDefaultState; // 0x38
	private readonly List<Collider> m_TempColliders; // 0x40
	private VolumeStack m_DefaultStack; // 0x48

	// Properties
	public static VolumeManager instance { get; }
	public VolumeStack stack { get; set; }
	[Obsolete("Please use baseComponentTypeArray instead.")]
	public IEnumerable<Type> baseComponentTypes { get; set; }
	public Type[] baseComponentTypeArray { get; set; }

	// Methods

	// RVA: 0x2A5D2D0 Offset: 0x2A5BCD0 VA: 0x182A5D2D0
	public static VolumeManager get_instance() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public VolumeStack get_stack() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_stack(VolumeStack value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IEnumerable<Type> get_baseComponentTypes() { }

	// RVA: 0x2A5D340 Offset: 0x2A5BD40 VA: 0x182A5D340
	private void set_baseComponentTypes(IEnumerable<Type> value) { }

	// RVA: 0x2A5B7D0 Offset: 0x2A5A1D0 VA: 0x182A5B7D0
	internal static List<ValueTuple<string, Type>> GetSupportedVolumeComponents(Type currentPipelineType) { }

	// RVA: 0x2A5B220 Offset: 0x2A59C20 VA: 0x182A5B220
	private static List<ValueTuple<string, Type>> FilterVolumeComponentTypes(Type[] types, Type currentPipelineType) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Type[] get_baseComponentTypeArray() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_baseComponentTypeArray(Type[] value) { }

	// RVA: 0x2A5B650 Offset: 0x2A5A050 VA: 0x182A5B650
	internal VolumeComponent GetDefaultVolumeComponent(Type volumeComponentType) { }

	// RVA: 0x2A5D060 Offset: 0x2A5BA60 VA: 0x182A5D060
	private void .ctor() { }

	// RVA: 0x2A5B130 Offset: 0x2A59B30 VA: 0x182A5B130
	public VolumeStack CreateStack() { }

	// RVA: 0x2A5C440 Offset: 0x2A5AE40 VA: 0x182A5C440
	public void ResetMainStack() { }

	// RVA: 0x2A5B200 Offset: 0x2A59C00 VA: 0x182A5B200
	public void DestroyStack(VolumeStack stack) { }

	// RVA: 0x2A5C0A0 Offset: 0x2A5AAA0 VA: 0x182A5C0A0
	private void ReloadBaseTypes() { }

	// RVA: 0x2A5BE80 Offset: 0x2A5A880 VA: 0x182A5BE80
	public void Register(Volume volume, int layer) { }

	// RVA: 0x2A5C6E0 Offset: 0x2A5B0E0 VA: 0x182A5C6E0
	public void Unregister(Volume volume, int layer) { }

	// RVA: -1 Offset: -1
	public bool IsComponentActiveInMask<T>(LayerMask layerMask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF76740 Offset: 0xF75140 VA: 0x180F76740
	|-VolumeManager.IsComponentActiveInMask<object>
	*/

	// RVA: 0x2A5C460 Offset: 0x2A5AE60 VA: 0x182A5C460
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x2A5C880 Offset: 0x2A5B280 VA: 0x182A5C880
	internal void UpdateVolumeLayer(Volume volume, int prevLayer, int newLayer) { }

	// RVA: 0x2A5BD90 Offset: 0x2A5A790 VA: 0x182A5BD90
	private void OverrideData(VolumeStack stack, List<VolumeComponent> components, float interpFactor) { }

	// RVA: 0x2A5C370 Offset: 0x2A5AD70 VA: 0x182A5C370
	internal void ReplaceData(VolumeStack stack) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x2A5AE00 Offset: 0x2A59800 VA: 0x182A5AE00
	public void CheckBaseTypes() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x2A5AEB0 Offset: 0x2A598B0 VA: 0x182A5AEB0
	public void CheckStack(VolumeStack stack) { }

	// RVA: 0x2A5B0B0 Offset: 0x2A59AB0 VA: 0x182A5B0B0
	private bool CheckUpdateRequired(VolumeStack stack) { }

	// RVA: 0x2A5CEC0 Offset: 0x2A5B8C0 VA: 0x182A5CEC0
	public void Update(Transform trigger, LayerMask layerMask) { }

	// RVA: 0x2A5C8C0 Offset: 0x2A5B2C0 VA: 0x182A5C8C0
	public void Update(VolumeStack stack, Transform trigger, LayerMask layerMask) { }

	// RVA: 0x2A5B8D0 Offset: 0x2A5A2D0 VA: 0x182A5B8D0
	public Volume[] GetVolumes(LayerMask layerMask) { }

	// RVA: 0x2A5BA20 Offset: 0x2A5A420 VA: 0x182A5BA20
	private List<Volume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x2A5C5C0 Offset: 0x2A5AFC0 VA: 0x182A5C5C0
	private static void SortByPriority(List<Volume> volumes) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private static bool IsVolumeRenderedByCamera(Volume volume, Camera camera) { }

	// RVA: 0x2A5CEF0 Offset: 0x2A5B8F0 VA: 0x182A5CEF0
	private static void .cctor() { }
}
