public class TriggerZone : MonoBehaviour // TypeDefIndex: 342
{
	// Fields
	public const string ClassName = "TriggerZone";
	public bool setIsTrigger; // 0x20
	public float rangeMultiplier; // 0x24
	private const int kMeshColliderNumSides = 8;
	private VolumetricLightBeamAbstractBase m_Beam; // 0x28
	private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting; // 0x30
	private PolygonCollider2D m_PolygonCollider2D; // 0x38

	// Properties
	private TriggerZone.TriggerZoneUpdateRate updateRate { get; }

	// Methods

	// RVA: 0x7B9B60 Offset: 0x7B8560 VA: 0x1807B9B60
	private TriggerZone.TriggerZoneUpdateRate get_updateRate() { }

	// RVA: 0x7B9920 Offset: 0x7B8320 VA: 0x1807B9920
	private void OnEnable() { }

	// RVA: 0x7B9B30 Offset: 0x7B8530 VA: 0x1807B9B30
	private void OnOcclusionProcessed() { }

	// RVA: 0x7B90B0 Offset: 0x7B7AB0 VA: 0x1807B90B0
	private void ComputeZone() { }

	// RVA: 0x7B9B40 Offset: 0x7B8540 VA: 0x1807B9B40
	public void .ctor() { }
}
