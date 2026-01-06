public class EffectAbstractBase : MonoBehaviour // TypeDefIndex: 245
{
	// Fields
	public const string ClassName = "EffectAbstractBase";
	public EffectAbstractBase.ComponentsToChange componentsToChange; // 0x20
	[FormerlySerializedAs("restoreBaseIntensity")]
	public bool restoreIntensityOnDisable; // 0x24
	protected VolumetricLightBeamAbstractBase m_Beam; // 0x28
	protected Light m_Light; // 0x30
	protected VolumetricDustParticles m_Particles; // 0x38
	protected float m_BaseIntensityBeamInside; // 0x40
	protected float m_BaseIntensityBeamOutside; // 0x44
	protected float m_BaseIntensityLight; // 0x48

	// Properties
	[Obsolete("Use 'restoreIntensityOnDisable' instead")]
	public bool restoreBaseIntensity { get; set; }

	// Methods

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_restoreBaseIntensity() { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	public void set_restoreBaseIntensity(bool value) { }

	// RVA: 0x698440 Offset: 0x696E40 VA: 0x180698440 Slot: 4
	public virtual void InitFrom(EffectAbstractBase Source) { }

	// RVA: 0x6983C0 Offset: 0x696DC0 VA: 0x1806983C0
	private void GetIntensity(VolumetricLightBeamSD beam) { }

	// RVA: 0x698350 Offset: 0x696D50 VA: 0x180698350
	private void GetIntensity(VolumetricLightBeamHD beam) { }

	// RVA: 0x6987E0 Offset: 0x6971E0 VA: 0x1806987E0
	private void SetIntensity(VolumetricLightBeamSD beam, float additive) { }

	// RVA: 0x698880 Offset: 0x697280 VA: 0x180698880
	private void SetIntensity(VolumetricLightBeamHD beam, float additive) { }

	// RVA: 0x698500 Offset: 0x696F00 VA: 0x180698500
	protected void SetAdditiveIntensity(float additive) { }

	// RVA: 0x698100 Offset: 0x696B00 VA: 0x180698100
	private void Awake() { }

	// RVA: 0x6984F0 Offset: 0x696EF0 VA: 0x1806984F0 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x6984C0 Offset: 0x696EC0 VA: 0x1806984C0
	private void OnDisable() { }

	// RVA: 0x698940 Offset: 0x697340 VA: 0x180698940
	public void .ctor() { }
}
