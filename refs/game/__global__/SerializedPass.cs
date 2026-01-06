public class SerializedPass : ISerializationCallbackReceiver // TypeDefIndex: 10847
{
	// Fields
	[SerializeField]
	private Shader shader; // 0x10
	[SerializeField]
	private List<SerializedPass.SerializedPropertyKeyValuePair> serializedProperties; // 0x18
	private Dictionary<int, SerializedPass.SerializedPassProperty> propertiesById; // 0x20
	private Dictionary<string, SerializedPass.SerializedPassProperty> propertiesByName; // 0x28
	private Material material; // 0x30
	private bool propertiesIsDirty; // 0x38

	// Properties
	public Shader Shader { get; set; }
	public Material Material { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Shader get_Shader() { }

	// RVA: 0x488A40 Offset: 0x487440 VA: 0x180488A40
	public void set_Shader(Shader value) { }

	// RVA: 0x4886F0 Offset: 0x4870F0 VA: 0x1804886F0
	public Material get_Material() { }

	// RVA: 0x487860 Offset: 0x486260 VA: 0x180487860
	public bool HasProperty(string name) { }

	// RVA: 0x487800 Offset: 0x486200 VA: 0x180487800
	public bool HasProperty(int hash) { }

	// RVA: 0x487560 Offset: 0x485F60 VA: 0x180487560
	public Vector4 GetVector(string name) { }

	// RVA: 0x4876A0 Offset: 0x4860A0 VA: 0x1804876A0
	public Vector4 GetVector(int hash) { }

	// RVA: 0x488440 Offset: 0x486E40 VA: 0x180488440
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x4882D0 Offset: 0x486CD0 VA: 0x1804882D0
	public void SetVector(int hash, Vector4 value) { }

	// RVA: 0x487450 Offset: 0x485E50 VA: 0x180487450
	public float GetFloat(string name) { }

	// RVA: 0x487330 Offset: 0x485D30 VA: 0x180487330
	public float GetFloat(int hash) { }

	// RVA: 0x488120 Offset: 0x486B20 VA: 0x180488120
	public void SetFloat(string name, float value) { }

	// RVA: 0x488000 Offset: 0x486A00 VA: 0x180488000
	public void SetFloat(int hash, float value) { }

	// RVA: 0x487100 Offset: 0x485B00 VA: 0x180487100
	public Color GetColor(string name) { }

	// RVA: 0x487210 Offset: 0x485C10 VA: 0x180487210
	public Color GetColor(int hash) { }

	// RVA: 0x487E60 Offset: 0x486860 VA: 0x180487E60
	public void SetColor(string name, Color value) { }

	// RVA: 0x487D30 Offset: 0x486730 VA: 0x180487D30
	public void SetColor(int hash, Color value) { }

	// RVA: 0x487AD0 Offset: 0x4864D0 VA: 0x180487AD0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x4878C0 Offset: 0x4862C0 VA: 0x1804878C0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x4885E0 Offset: 0x486FE0 VA: 0x1804885E0
	public void .ctor() { }
}
