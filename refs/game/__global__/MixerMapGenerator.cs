public class MixerMapGenerator : MonoBehaviour // TypeDefIndex: 1477
{
	// Fields
	public float MapRadius; // 0x20
	public string MapName; // 0x28
	public Transform BasePlateMesh; // 0x30
	public MixMapEffect EffectPrefab; // 0x38

	// Methods

	// RVA: 0x6CA6D0 Offset: 0x6C90D0 VA: 0x1806CA6D0
	private void OnValidate() { }

	[Button]
	// RVA: 0x6CA270 Offset: 0x6C8C70 VA: 0x1806CA270
	public void CreateEffectPrefabs() { }

	[Button]
	// RVA: 0x6CA590 Offset: 0x6C8F90 VA: 0x1806CA590
	public MixMapEffect GetEffect(Effect effect) { }

	// RVA: 0x6CA7B0 Offset: 0x6C91B0 VA: 0x1806CA7B0
	public void .ctor() { }
}
