public class TransformLerp // TypeDefIndex: 2336
{
	// Fields
	[SerializeField]
	private Transform _transform; // 0x10
	[SerializeField]
	private Transform _min; // 0x18
	[SerializeField]
	private Transform _max; // 0x20
	[Header("Settings")]
	[SerializeField]
	private bool _lerpPosition; // 0x28
	[SerializeField]
	private bool _lerpRotation; // 0x29
	[SerializeField]
	private bool _lerpScale; // 0x2A
	[SerializeField]
	private bool _disableOnZero; // 0x2B
	private float _currentLerpValue; // 0x2C

	// Methods

	// RVA: 0x86D260 Offset: 0x86BC60 VA: 0x18086D260
	public void SetLerpValue(float lerpValue) { }

	// RVA: 0x86D550 Offset: 0x86BF50 VA: 0x18086D550
	public void .ctor() { }
}
