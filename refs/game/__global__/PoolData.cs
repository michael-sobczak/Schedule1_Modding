public class PoolData // TypeDefIndex: 18187
{
	// Fields
	public readonly GameObject Prefab; // 0x10
	public ListStack<GameObject> Objects; // 0x18
	private float _expirationDuration; // 0x20

	// Methods

	// RVA: 0xDA9030 Offset: 0xDA7A30 VA: 0x180DA9030
	public void .ctor(GameObject prefab, float expirationDuration) { }

	// RVA: 0xDA8FC0 Offset: 0xDA79C0 VA: 0x180DA8FC0
	public bool PoolExpired() { }

	// RVA: 0xDA8F20 Offset: 0xDA7920 VA: 0x180DA8F20
	public List<GameObject> Cull() { }
}
