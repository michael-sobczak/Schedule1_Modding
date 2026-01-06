public class SpherePoint // TypeDefIndex: 478
{
	// Fields
	public float horizontalRotation; // 0x10
	public float verticalRotation; // 0x14
	public const float MinHorizontalRotation = -3.1415927;
	public const float MaxHorizontalRotation = 3.1415927;
	public const float MinVerticalRotation = -1.5707964;
	public const float MaxVerticalRotation = 1.5707964;

	// Methods

	// RVA: 0x7A8760 Offset: 0x7A7160 VA: 0x1807A8760
	public void .ctor(float horizontalRotation, float verticalRotation) { }

	// RVA: 0xA910D0 Offset: 0xA8FAD0 VA: 0x180A910D0
	public void .ctor(Vector3 worldDirection) { }

	// RVA: 0xA91080 Offset: 0xA8FA80 VA: 0x180A91080
	public void SetFromWorldDirection(Vector3 worldDirection) { }

	// RVA: 0xA90FF0 Offset: 0xA8F9F0 VA: 0x180A90FF0
	public Vector3 GetWorldDirection() { }
}
