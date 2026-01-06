public class TileAppearance : MonoBehaviour // TypeDefIndex: 664
{
	// Fields
	[SerializeField]
	[Header("References")]
	protected MeshRenderer tileMesh; // 0x20
	[Header("Settings")]
	[SerializeField]
	protected Material mat_White; // 0x28
	[SerializeField]
	protected Material mat_Blue; // 0x30
	[SerializeField]
	protected Material mat_Red; // 0x38

	// Methods

	// RVA: 0xAC9790 Offset: 0xAC8190 VA: 0x180AC9790
	public void Awake() { }

	// RVA: 0x7AC9A0 Offset: 0x7AB3A0 VA: 0x1807AC9A0
	public void SetVisible(bool visible) { }

	// RVA: 0xAC97C0 Offset: 0xAC81C0 VA: 0x180AC97C0
	public void SetColor(ETileColor col) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
