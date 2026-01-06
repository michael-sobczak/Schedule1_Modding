public class GoonPool : MonoBehaviour // TypeDefIndex: 2092
{
	// Fields
	public const float MALE_CHANCE = 0.7;
	[Header("References")]
	[SerializeField]
	private CartelGoon[] goons; // 0x20
	[SerializeField]
	private NPCEnterableBuilding[] exitBuildings; // 0x28
	[Header("Appearance Settings")]
	public AvatarSettings[] MaleBaseAppearances; // 0x30
	public AvatarSettings[] FemaleBaseAppearances; // 0x38
	public AvatarSettings[] MaleClothing; // 0x40
	public AvatarSettings[] FemaleClothing; // 0x48
	public VODatabase[] MaleVoices; // 0x50
	public VODatabase[] FemaleVoices; // 0x58
	public Color[] SkinTones; // 0x60
	public Color[] HairColors; // 0x68
	private List<CartelGoon> spawnedGoons; // 0x70
	private List<CartelGoon> unspawnedGoons; // 0x78

	// Properties
	public int UnspawnedGoonCount { get; }

	// Methods

	// RVA: 0x80A330 Offset: 0x808D30 VA: 0x18080A330
	public int get_UnspawnedGoonCount() { }

	// RVA: 0x809770 Offset: 0x808170 VA: 0x180809770 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Update() { }

	// RVA: 0x809F70 Offset: 0x808970 VA: 0x180809F70
	public List<CartelGoon> SpawnMultipleGoons(Vector3 spawnPoint, int requestedAmount, bool setAsGoonMates = True) { }

	// RVA: 0x809AC0 Offset: 0x8084C0 VA: 0x180809AC0
	public CartelGoonAppearance GetRandomAppearance() { }

	// RVA: 0x809E20 Offset: 0x808820 VA: 0x180809E20
	public CartelGoon SpawnGoon(Vector3 spawnPoint) { }

	// RVA: 0x809CC0 Offset: 0x8086C0 VA: 0x180809CC0
	public void ReturnToPool(CartelGoon goon) { }

	// RVA: 0x8098E0 Offset: 0x8082E0 VA: 0x1808098E0
	public NPCEnterableBuilding GetNearestExitBuilding(Vector3 position) { }

	// RVA: 0x80A280 Offset: 0x808C80 VA: 0x18080A280
	public void .ctor() { }
}
