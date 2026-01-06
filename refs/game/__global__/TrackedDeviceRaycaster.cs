public class TrackedDeviceRaycaster : BaseRaycaster // TypeDefIndex: 7525
{
	// Fields
	private List<TrackedDeviceRaycaster.RaycastHitData> m_RaycastResultsCache; // 0x28
	internal static InlinedArray<TrackedDeviceRaycaster> s_Instances; // 0x0
	private static readonly List<TrackedDeviceRaycaster.RaycastHitData> s_SortedGraphics; // 0x18
	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	private bool m_IgnoreReversedGraphics; // 0x30
	[SerializeField]
	[FormerlySerializedAs("checkFor2DOcclusion")]
	private bool m_CheckFor2DOcclusion; // 0x31
	[FormerlySerializedAs("checkFor3DOcclusion")]
	[SerializeField]
	private bool m_CheckFor3DOcclusion; // 0x32
	[SerializeField]
	[Tooltip("Maximum distance (in 3D world space) that rays are traced to find a hit.")]
	private float m_MaxDistance; // 0x34
	[SerializeField]
	private LayerMask m_BlockingMask; // 0x38
	private Canvas m_Canvas; // 0x40

	// Properties
	public override Camera eventCamera { get; }
	public LayerMask blockingMask { get; set; }
	public bool checkFor3DOcclusion { get; set; }
	public bool checkFor2DOcclusion { get; set; }
	public bool ignoreReversedGraphics { get; set; }
	public float maxDistance { get; set; }
	private Canvas canvas { get; }

	// Methods

	// RVA: 0x2851B30 Offset: 0x2850530 VA: 0x182851B30 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public LayerMask get_blockingMask() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x231C2D0 Offset: 0x231ACD0 VA: 0x18231C2D0
	public bool get_checkFor3DOcclusion() { }

	// RVA: 0x231C770 Offset: 0x231B170 VA: 0x18231C770
	public void set_checkFor3DOcclusion(bool value) { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_checkFor2DOcclusion() { }

	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	public void set_checkFor2DOcclusion(bool value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_maxDistance() { }

	// RVA: 0x8928D0 Offset: 0x8912D0 VA: 0x1808928D0
	public void set_maxDistance(float value) { }

	// RVA: 0x28506C0 Offset: 0x284F0C0 VA: 0x1828506C0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x28505E0 Offset: 0x284EFE0 VA: 0x1828505E0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2851360 Offset: 0x284FD60 VA: 0x182851360 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x2850740 Offset: 0x284F140 VA: 0x182850740
	internal void PerformRaycast(ExtendedPointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x28513F0 Offset: 0x284FDF0 VA: 0x1828513F0
	private void SortedRaycastGraphics(Canvas canvas, Ray ray, List<TrackedDeviceRaycaster.RaycastHitData> results) { }

	// RVA: 0x2850DB0 Offset: 0x284F7B0 VA: 0x182850DB0
	private static bool RayIntersectsRectTransform(RectTransform transform, Ray ray, out Vector3 worldPosition, out float distance) { }

	// RVA: 0x2851AA0 Offset: 0x28504A0 VA: 0x182851AA0
	private Canvas get_canvas() { }

	// RVA: 0x2851A20 Offset: 0x2850420 VA: 0x182851A20
	public void .ctor() { }

	// RVA: 0x2851990 Offset: 0x2850390 VA: 0x182851990
	private static void .cctor() { }
}
