public class MaterialChanger : MonoBehaviour // TypeDefIndex: 99
{
	// Fields
	[Range(0, 5)]
	[SerializeField]
	private float _value; // 0x20
	[SerializeField]
	private string _changeMaterialSetting; // 0x28
	private Renderer[] _renderers; // 0x30
	private MaterialPropertyBlock _propBlock; // 0x38

	// Methods

	// RVA: 0x576D10 Offset: 0x575710 VA: 0x180576D10
	private void OnEnable() { }

	// RVA: 0x576E90 Offset: 0x575890 VA: 0x180576E90
	private void Update() { }

	// RVA: 0x576D10 Offset: 0x575710 VA: 0x180576D10
	private void FindAllMaterialInChild() { }

	// RVA: 0x576D70 Offset: 0x575770 VA: 0x180576D70
	private void SetNewValueForAllMaterial(float value) { }

	// RVA: 0x577000 Offset: 0x575A00 VA: 0x180577000
	public void .ctor() { }
}
