public abstract class VolumetricLightBeamAbstractBase : MonoBehaviour // TypeDefIndex: 350
{
	// Fields
	public const string ClassName = "VolumetricLightBeamAbstractBase";
	[SerializeField]
	protected int pluginVersion; // 0x20
	protected Light m_CachedLightSpot; // 0x28

	// Properties
	public bool hasGeometry { get; }
	public Bounds bounds { get; }
	public int _INTERNAL_pluginVersion { get; }
	public Light lightSpotAttached { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BeamGeometryAbstractBase GetBeamGeometry();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void SetBeamGeometryNull();

	// RVA: 0x7BF440 Offset: 0x7BDE40 VA: 0x1807BF440
	public bool get_hasGeometry() { }

	// RVA: 0x7BF2C0 Offset: 0x7BDCC0 VA: 0x1807BF2C0
	public Bounds get_bounds() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool IsScalable();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Vector3 GetLossyScale();

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get__INTERNAL_pluginVersion() { }

	// RVA: 0x7BF140 Offset: 0x7BDB40 VA: 0x1807BF140
	public Light GetLightSpotAttachedSlow(out VolumetricLightBeamAbstractBase.AttachedLightType lightType) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Light get_lightSpotAttached() { }

	// RVA: 0x7BF200 Offset: 0x7BDC00 VA: 0x1807BF200
	protected void InitLightSpotAttachedCached() { }

	// RVA: 0x7BF0B0 Offset: 0x7BDAB0 VA: 0x1807BF0B0
	private void OnDestroy() { }

	// RVA: 0x7BF0B0 Offset: 0x7BDAB0 VA: 0x1807BF0B0
	protected void DestroyBeam() { }

	// RVA: 0x7BF2B0 Offset: 0x7BDCB0 VA: 0x1807BF2B0
	protected void .ctor() { }
}
