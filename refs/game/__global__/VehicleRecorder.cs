public class VehicleRecorder : MonoBehaviour // TypeDefIndex: 2197
{
	// Fields
	public static int frameRate; // 0x0
	public bool IS_RECORDING; // 0x20
	public List<VehicleKeyFrame> keyFrames; // 0x28
	private LandVehicle vehicleToRecord; // 0x30
	private float timeSinceKeyFrame; // 0x38

	// Methods

	// RVA: 0x83BAB0 Offset: 0x83A4B0 VA: 0x18083BAB0 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x83B610 Offset: 0x83A010 VA: 0x18083B610
	private VehicleKeyFrame Capture() { }

	// RVA: 0x83B4F0 Offset: 0x839EF0 VA: 0x18083B4F0
	private VehicleKeyFrame.WheelTransform CaptureWheel(Wheel wheel) { }

	// RVA: 0x83BD70 Offset: 0x83A770 VA: 0x18083BD70
	public void .ctor() { }

	// RVA: 0x83BD30 Offset: 0x83A730 VA: 0x18083BD30
	private static void .cctor() { }
}
