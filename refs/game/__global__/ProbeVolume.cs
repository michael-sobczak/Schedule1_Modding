public class ProbeVolume : MonoBehaviour // TypeDefIndex: 13749
{
	// Fields
	[Tooltip("When set to Global this Probe Volume considers all renderers with Contribute Global Illumination enabled. Local only considers renderers in the scene.
This list updates every time the Scene is saved or the lighting is baked.")]
	public ProbeVolume.Mode mode; // 0x20
	public Vector3 size; // 0x24
	[HideInInspector]
	[Min(0)]
	public bool overrideRendererFilters; // 0x30
	[HideInInspector]
	[Min(0)]
	public float minRendererVolumeSize; // 0x34
	public LayerMask objectLayerMask; // 0x38
	[HideInInspector]
	public int lowestSubdivLevelOverride; // 0x3C
	[HideInInspector]
	public int highestSubdivLevelOverride; // 0x40
	[HideInInspector]
	public bool overridesSubdivLevels; // 0x44
	[SerializeField]
	internal bool mightNeedRebaking; // 0x45
	[SerializeField]
	internal Matrix4x4 cachedTransform; // 0x48
	[SerializeField]
	internal int cachedHashCode; // 0x88
	[Tooltip("Whether spaces with no renderers need to be filled with bricks at lowest subdivision level.")]
	[HideInInspector]
	public bool fillEmptySpaces; // 0x8C
	[SerializeField]
	private ProbeVolume.Version version; // 0x90
	[SerializeField]
	[Obsolete("Use mode instead")]
	public bool globalVolume; // 0x94

	// Methods

	// RVA: 0x2A25DF0 Offset: 0x2A247F0 VA: 0x182A25DF0
	private void Awake() { }

	// RVA: 0x2A25E20 Offset: 0x2A24820 VA: 0x182A25E20
	public void .ctor() { }
}
