public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase // TypeDefIndex: 323
{
	// Fields
	public const string ClassName = "DynamicOcclusionRaycasting";
	public Dimensions dimensions; // 0x70
	public LayerMask layerMask; // 0x74
	public bool considerTriggers; // 0x78
	public float minOccluderArea; // 0x7C
	public float minSurfaceRatio; // 0x80
	public float maxSurfaceDot; // 0x84
	public PlaneAlignment planeAlignment; // 0x88
	public float planeOffset; // 0x8C
	[FormerlySerializedAs("fadeDistanceToPlane")]
	public float fadeDistanceToSurface; // 0x90
	private DynamicOcclusionRaycasting.HitResult m_CurrentHit; // 0x98
	private float m_RangeMultiplier; // 0xC8
	[CompilerGenerated]
	private Plane <planeEquationWS>k__BackingField; // 0xCC
	private uint m_PrevNonSubHitDirectionId; // 0xDC

	// Properties
	[Obsolete("Use 'fadeDistanceToSurface' instead")]
	public float fadeDistanceToPlane { get; set; }
	public Plane planeEquationWS { get; set; }
	private QueryTriggerInteraction queryTriggerInteraction { get; }
	private float raycastMaxDistance { get; }

	// Methods

	// RVA: 0x4B6130 Offset: 0x4B4B30 VA: 0x1804B6130
	public float get_fadeDistanceToPlane() { }

	// RVA: 0x7B13B0 Offset: 0x7AFDB0 VA: 0x1807B13B0
	public void set_fadeDistanceToPlane(float value) { }

	// RVA: 0x7B01B0 Offset: 0x7AEBB0 VA: 0x1807B01B0
	public bool IsColliderHiddenByDynamicOccluder(Collider collider) { }

	// RVA: 0x7B0180 Offset: 0x7AEB80 VA: 0x1807B0180 Slot: 4
	protected override string GetShaderKeyword() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode() { }

	[CompilerGenerated]
	// RVA: 0x7B1310 Offset: 0x7AFD10 VA: 0x1807B1310
	public Plane get_planeEquationWS() { }

	[CompilerGenerated]
	// RVA: 0x7B1160 Offset: 0x7AFB60 VA: 0x1807B1160
	private void set_planeEquationWS(Plane value) { }

	// RVA: 0x7B0C10 Offset: 0x7AF610 VA: 0x1807B0C10 Slot: 9
	protected override void OnValidateProperties() { }

	// RVA: 0x7B0360 Offset: 0x7AED60 VA: 0x1807B0360 Slot: 8
	protected override void OnEnablePostValidate() { }

	// RVA: 0x7B0340 Offset: 0x7AED40 VA: 0x1807B0340 Slot: 13
	protected override void OnDisable() { }

	// RVA: 0x7B1170 Offset: 0x7AFB70 VA: 0x1807B1170
	private void Start() { }

	// RVA: 0x7B0060 Offset: 0x7AEA60 VA: 0x1807B0060
	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff) { }

	// RVA: 0x7B1320 Offset: 0x7AFD20 VA: 0x1807B1320
	private QueryTriggerInteraction get_queryTriggerInteraction() { }

	// RVA: 0x7B1330 Offset: 0x7AFD30 VA: 0x1807B1330
	private float get_raycastMaxDistance() { }

	// RVA: 0x7AFD80 Offset: 0x7AE780 VA: 0x1807AFD80
	private DynamicOcclusionRaycasting.HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir) { }

	// RVA: 0x7AFA00 Offset: 0x7AE400 VA: 0x1807AFA00
	private DynamicOcclusionRaycasting.HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir) { }

	// RVA: 0x7AF610 Offset: 0x7AE010 VA: 0x1807AF610
	private DynamicOcclusionRaycasting.HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir) { }

	// RVA: 0x7AFE30 Offset: 0x7AE830 VA: 0x1807AFE30
	private uint GetDirectionCount() { }

	// RVA: 0x7AFE50 Offset: 0x7AE850 VA: 0x1807AFE50
	private Vector3 GetDirection(uint dirInt) { }

	// RVA: 0x7B02A0 Offset: 0x7AECA0 VA: 0x1807B02A0
	private bool IsHitValid(ref DynamicOcclusionRaycasting.HitResult hit, Vector3 forwardVec) { }

	// RVA: 0x7B05B0 Offset: 0x7AEFB0 VA: 0x1807B05B0 Slot: 6
	protected override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source) { }

	// RVA: 0x7B0EE0 Offset: 0x7AF8E0 VA: 0x1807B0EE0
	private void SetHit(ref DynamicOcclusionRaycasting.HitResult hit) { }

	// RVA: 0x7B0E60 Offset: 0x7AF860 VA: 0x1807B0E60
	private void SetHitNull() { }

	// RVA: 0x7B03A0 Offset: 0x7AEDA0 VA: 0x1807B03A0 Slot: 7
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner) { }

	// RVA: 0x7B0CB0 Offset: 0x7AF6B0 VA: 0x1807B0CB0
	private void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x7B0C60 Offset: 0x7AF660 VA: 0x1807B0C60
	private void SetClippingPlaneOff() { }

	// RVA: 0x7B1160 Offset: 0x7AFB60 VA: 0x1807B1160
	private void SetPlaneWS(Plane planeWS) { }

	// RVA: 0x7B1240 Offset: 0x7AFC40 VA: 0x1807B1240
	public void .ctor() { }
}
