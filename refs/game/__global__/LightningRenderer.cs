public class LightningRenderer : BaseSpriteInstancedRenderer // TypeDefIndex: 485
{
	// Fields
	private static List<LightningSpawnArea> m_SpawnAreas; // 0x0
	private float m_LightningProbability; // 0x98
	private float m_NextSpawnTime; // 0x9C
	private SkyProfile m_SkyProfile; // 0xA0
	private LightningArtItem m_Style; // 0xA8
	private float m_TimeOfDay; // 0xB0
	private AudioSource m_AudioSource; // 0xB8
	private float m_LightningIntensity; // 0xC0
	private float m_ThunderSoundDelay; // 0xC4
	private float m_SpawnCoolDown; // 0xC8
	private const float k_ProbabiltyCheckInterval = 0.5;

	// Methods

	// RVA: 0xA889F0 Offset: 0xA873F0 VA: 0x180A889F0
	private void Start() { }

	// RVA: 0xA87ED0 Offset: 0xA868D0 VA: 0x180A87ED0 Slot: 4
	protected override Bounds CalculateMeshBounds() { }

	// RVA: 0xA88300 Offset: 0xA86D00 VA: 0x180A88300 Slot: 5
	protected override BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: 0xA886E0 Offset: 0xA870E0 VA: 0x180A886E0 Slot: 6
	protected override bool IsRenderingEnabled() { }

	// RVA: 0xA87F40 Offset: 0xA86940 VA: 0x180A87F40 Slot: 8
	protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: 0xA88280 Offset: 0xA86C80 VA: 0x180A88280 Slot: 9
	protected override void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 10
	protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: 0xA888C0 Offset: 0xA872C0 VA: 0x180A888C0 Slot: 11
	protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0xA88350 Offset: 0xA86D50 VA: 0x180A88350 Slot: 7
	protected override int GetNextSpawnCount() { }

	// RVA: 0xA88D60 Offset: 0xA87760 VA: 0x180A88D60
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, LightningArtItem artItem) { }

	// RVA: 0xA88AA0 Offset: 0xA874A0 VA: 0x180A88AA0
	private void SyncDataFromSkyProfile() { }

	// RVA: 0xA883E0 Offset: 0xA86DE0 VA: 0x180A883E0
	private LightningSpawnArea GetRandomLightningSpawnArea() { }

	// RVA: 0xA887D0 Offset: 0xA871D0 VA: 0x180A887D0
	private void PlayThunderBoltSound() { }

	// RVA: 0xA87D60 Offset: 0xA86760 VA: 0x180A87D60
	public static void AddSpawnArea(LightningSpawnArea area) { }

	// RVA: 0xA88920 Offset: 0xA87320 VA: 0x180A88920
	public static void RemoveSpawnArea(LightningSpawnArea area) { }

	// RVA: 0xA885B0 Offset: 0xA86FB0 VA: 0x180A885B0
	private Vector3 GetRandomWorldPositionInsideSpawnArea(LightningSpawnArea area) { }

	// RVA: 0xA87E90 Offset: 0xA86890 VA: 0x180A87E90
	private float CalculateLightningBoltScaleForArea(LightningSpawnArea area) { }

	// RVA: 0xA88F40 Offset: 0xA87940 VA: 0x180A88F40
	public void .ctor() { }

	// RVA: 0xA88EB0 Offset: 0xA878B0 VA: 0x180A88EB0
	private static void .cctor() { }
}
