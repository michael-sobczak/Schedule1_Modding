public class TwistSolver // TypeDefIndex: 14140
{
	// Fields
	[Tooltip("The transform that this solver operates on.")]
	public Transform transform; // 0x10
	[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
	public Transform parent; // 0x18
	[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
	public Transform[] children; // 0x20
	[Tooltip("The weight of relaxing the twist of this Transform")]
	[Range(0, 1)]
	public float weight; // 0x28
	[Range(0, 1)]
	[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
	public float parentChildCrossfade; // 0x2C
	[Range(-180, 180)]
	[Tooltip("Rotation offset around the twist axis.")]
	public float twistAngleOffset; // 0x30
	private Vector3 twistAxis; // 0x34
	private Vector3 axis; // 0x40
	private Vector3 axisRelativeToParentDefault; // 0x4C
	private Vector3 axisRelativeToChildDefault; // 0x58
	private Quaternion[] childRotations; // 0x68
	private bool inititated; // 0x70
	private Quaternion defaultLocalRotation; // 0x74
	private Quaternion[] defaultChildLocalRotations; // 0x88

	// Methods

	// RVA: 0x1F175E0 Offset: 0x1F15FE0 VA: 0x181F175E0
	public void .ctor() { }

	// RVA: 0x1F174B0 Offset: 0x1F15EB0 VA: 0x181F174B0
	public void .ctor(Transform t) { }

	// RVA: 0x1F16370 Offset: 0x1F14D70 VA: 0x181F16370
	public void Initiate() { }

	// RVA: 0x1F162A0 Offset: 0x1F14CA0 VA: 0x181F162A0
	public void FixTransforms() { }

	// RVA: 0x1F16A40 Offset: 0x1F15440 VA: 0x181F16A40
	public void Relax() { }
}
