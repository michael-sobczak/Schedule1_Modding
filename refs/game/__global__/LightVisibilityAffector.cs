public class LightVisibilityAffector : MonoBehaviour // TypeDefIndex: 827
{
	// Fields
	public const float PointLightEffect = 15;
	public const float SpotLightEffect = 10;
	[Header("Settings")]
	public float EffectMultiplier; // 0x20
	public string uniquenessCode; // 0x28
	[Tooltip("How far does the player have to move for visibility to be recalculated?")]
	public int updateDistanceThreshold; // 0x30
	protected Light light; // 0x38
	protected VisibilityAttribute attribute; // 0x40

	// Methods

	// RVA: 0x5A50D0 Offset: 0x5A3AD0 VA: 0x1805A50D0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x5A5450 Offset: 0x5A3E50 VA: 0x1805A5450
	private void PlayerSpawned() { }

	// RVA: 0x5A52F0 Offset: 0x5A3CF0 VA: 0x1805A52F0
	private void OnDestroy() { }

	// RVA: 0x5A5830 Offset: 0x5A4230 VA: 0x1805A5830 Slot: 5
	protected virtual void UpdateVisibility() { }

	// RVA: 0x5A5630 Offset: 0x5A4030 VA: 0x1805A5630
	private void UpdateAttribute(float visibity) { }

	// RVA: 0x5A5230 Offset: 0x5A3C30 VA: 0x1805A5230
	private void ClearAttribute() { }

	// RVA: 0x5A5E50 Offset: 0x5A4850 VA: 0x1805A5E50
	public void .ctor() { }
}
