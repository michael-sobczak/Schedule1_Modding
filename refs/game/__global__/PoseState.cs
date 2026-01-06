public struct PoseState : IInputStateTypeInfo // TypeDefIndex: 7457
{
	// Fields
	internal const int kSizeInBytes = 60;
	internal static readonly FourCC s_Format; // 0x0
	[InputControl(displayName = "Is Tracked", layout = "Button", sizeInBits = 8)]
	public bool isTracked; // 0x0
	[InputControl(displayName = "Tracking State", layout = "Integer")]
	public InputTrackingState trackingState; // 0x4
	[InputControl(displayName = "Position", noisy = True)]
	public Vector3 position; // 0x8
	[InputControl(displayName = "Rotation", noisy = True)]
	public Quaternion rotation; // 0x14
	[InputControl(displayName = "Velocity", noisy = True)]
	public Vector3 velocity; // 0x24
	[InputControl(displayName = "Angular Velocity", noisy = True)]
	public Vector3 angularVelocity; // 0x30

	// Properties
	public FourCC format { get; }

	// Methods

	// RVA: 0x28348D0 Offset: 0x28332D0 VA: 0x1828348D0 Slot: 4
	public FourCC get_format() { }

	// RVA: 0x2834880 Offset: 0x2833280 VA: 0x182834880
	public void .ctor(bool isTracked, InputTrackingState trackingState, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity) { }

	// RVA: 0x2834810 Offset: 0x2833210 VA: 0x182834810
	private static void .cctor() { }
}
