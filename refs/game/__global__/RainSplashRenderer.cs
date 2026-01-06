public class RainSplashRenderer : BaseSpriteInstancedRenderer // TypeDefIndex: 490
{
	// Fields
	private Camera m_DepthCamera; // 0x98
	private float[] m_StartSplashYPositions; // 0xA0
	private float[] m_DepthUs; // 0xA8
	private float[] m_DepthVs; // 0xB0
	private float m_SplashAreaStart; // 0xB8
	private float m_SplashAreaLength; // 0xBC
	private float m_SplashScale; // 0xC0
	private float m_SplashScaleVarience; // 0xC4
	private float m_SplashItensity; // 0xC8
	private float m_SplashSurfaceOffset; // 0xCC
	private SkyProfile m_SkyProfile; // 0xD0
	private float m_TimeOfDay; // 0xD8
	private RainSplashArtItem m_Style; // 0xE0
	private Bounds m_Bounds; // 0xE8

	// Methods

	// RVA: 0xA8C0C0 Offset: 0xA8AAC0 VA: 0x180A8C0C0
	private void Start() { }

	// RVA: 0xA8B7E0 Offset: 0xA8A1E0 VA: 0x180A8B7E0 Slot: 4
	protected override Bounds CalculateMeshBounds() { }

	// RVA: 0xA8BAB0 Offset: 0xA8A4B0 VA: 0x180A8BAB0 Slot: 5
	protected override BaseSpriteItemData CreateSpriteItemData() { }

	// RVA: 0xA8BD00 Offset: 0xA8A700 VA: 0x180A8BD00 Slot: 6
	protected override bool IsRenderingEnabled() { }

	// RVA: 0xA8BCB0 Offset: 0xA8A6B0 VA: 0x180A8BCB0 Slot: 7
	protected override int GetNextSpawnCount() { }

	// RVA: 0xA8B800 Offset: 0xA8A200 VA: 0x180A8B800 Slot: 8
	protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale) { }

	// RVA: 0xA8B8C0 Offset: 0xA8A2C0 VA: 0x180A8B8C0 Slot: 9
	protected override void ConfigureSpriteItemData(BaseSpriteItemData data) { }

	// RVA: 0xA8BF30 Offset: 0xA8A930 VA: 0x180A8BF30 Slot: 10
	protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data) { }

	// RVA: 0xA8BE20 Offset: 0xA8A820 VA: 0x180A8BE20 Slot: 11
	protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0xA8C590 Offset: 0xA8AF90 VA: 0x180A8C590
	public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style) { }

	// RVA: 0xA8C220 Offset: 0xA8AC20 VA: 0x180A8C220
	private void SyncDataFromSkyProfile() { }

	// RVA: 0xA8BB00 Offset: 0xA8A500 VA: 0x180A8BB00
	private Vector3 CreateWorldSplashPoint() { }

	// RVA: 0xA8C650 Offset: 0xA8B050 VA: 0x180A8C650
	public void .ctor() { }
}
