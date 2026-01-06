public class AlignToWaves : MonoBehaviour // TypeDefIndex: 18259
{
	// Fields
	[Tooltip("This reference is required to grab the wave distance and height values")]
	public WaterObject waterObject; // 0x20
	[Tooltip("Automatically find the Water Object below of above the Transform's position. This is slower than assigning a specific Water Object directly.")]
	public bool autoFind; // 0x28
	[Tooltip("Only enable if the material's wave parameters are being changed in realtime, this has some performance overhead.

In edit-mode, the wave parameters are always fetched, so changes are directly visible")]
	public bool dynamicMaterial; // 0x29
	[Tooltip("Configure what should be used to set the base water level. Relative wave height is added to this value")]
	public AlignToWaves.WaterLevelSource waterLevelSource; // 0x2C
	public float waterLevel; // 0x30
	[Tooltip("You can assign a child mesh object here. When assigned, the sample points will rotate/scale with the transform, instead of transform the component is attached to.")]
	public Transform childTransform; // 0x38
	public float heightOffset; // 0x40
	[Min(0)]
	[Tooltip("Controls how strongly the transform should rotate to align with the wave curvature")]
	public float rollAmount; // 0x44
	public List<Vector3> samples; // 0x48
	private Vector3 normal; // 0x50
	private float height; // 0x5C
	private float m_waterLevel; // 0x60
	public static bool Disable; // 0x0

	// Methods

	// RVA: 0x1F65540 Offset: 0x1F63F40 VA: 0x181F65540
	public void FixedUpdate() { }

	// RVA: 0x1F65290 Offset: 0x1F63C90 VA: 0x181F65290
	private void ApplyTransform() { }

	// RVA: 0x1F65450 Offset: 0x1F63E50 VA: 0x181F65450
	public Vector3 ConvertToWorldSpace(Vector3 position) { }

	// RVA: 0x1F65360 Offset: 0x1F63D60 VA: 0x181F65360
	public Vector3 ConvertToLocalSpace(Vector3 position) { }

	// RVA: 0x1F65BF0 Offset: 0x1F645F0 VA: 0x181F65BF0
	public void .ctor() { }
}
