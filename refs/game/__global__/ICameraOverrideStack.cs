public interface ICameraOverrideStack // TypeDefIndex: 16039
{
	// Properties
	public abstract Vector3 DefaultWorldUp { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReleaseCameraOverride(int overrideId);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 get_DefaultWorldUp();
}
