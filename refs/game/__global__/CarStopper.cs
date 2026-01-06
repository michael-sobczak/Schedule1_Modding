public class CarStopper : MonoBehaviour // TypeDefIndex: 3314
{
	// Fields
	public bool isActive; // 0x20
	[Header("References")]
	[SerializeField]
	protected Transform blocker; // 0x28
	public NavMeshObstacle Obstacle; // 0x30
	private float moveTime; // 0x38

	// Methods

	// RVA: 0xA48BC0 Offset: 0xA475C0 VA: 0x180A48BC0 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x527EF0 Offset: 0x5268F0 VA: 0x180527EF0
	public void .ctor() { }
}
