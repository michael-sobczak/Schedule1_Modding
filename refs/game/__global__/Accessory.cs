public class Accessory : MonoBehaviour // TypeDefIndex: 3093
{
	// Fields
	[Header("Settings")]
	public string Name; // 0x20
	public string AssetPath; // 0x28
	public bool ReduceFootSize; // 0x30
	[Range(0, 1)]
	public float FootSizeReduction; // 0x34
	public bool ShouldBlockHair; // 0x38
	public bool ColorAllMeshes; // 0x39
	[Header("References")]
	public MeshRenderer[] meshesToColor; // 0x40
	public SkinnedMeshRenderer[] skinnedMeshesToColor; // 0x48
	public SkinnedMeshRenderer[] skinnedMeshesToBind; // 0x50
	public SkinnedMeshRenderer[] shapeKeyMeshRends; // 0x58

	// Methods

	// RVA: 0x98C9E0 Offset: 0x98B3E0 VA: 0x18098C9E0
	private void Awake() { }

	// RVA: 0x98C750 Offset: 0x98B150 VA: 0x18098C750
	public void ApplyColor(Color col) { }

	// RVA: 0x98C910 Offset: 0x98B310 VA: 0x18098C910
	public void ApplyShapeKeys(float gender, float weight) { }

	// RVA: 0x98CA60 Offset: 0x98B460 VA: 0x18098CA60
	public void BindBones(Transform[] bones) { }

	// RVA: 0x98CAD0 Offset: 0x98B4D0 VA: 0x18098CAD0
	public void .ctor() { }
}
