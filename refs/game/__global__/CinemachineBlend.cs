public class CinemachineBlend // TypeDefIndex: 16128
{
	// Fields
	public ICinemachineCamera CamA; // 0x10
	public ICinemachineCamera CamB; // 0x18
	public AnimationCurve BlendCurve; // 0x20
	public float TimeInBlend; // 0x28
	public float Duration; // 0x2C

	// Properties
	public float BlendWeight { get; }
	public bool IsValid { get; }
	public bool IsComplete { get; }
	public string Description { get; }
	public CameraState State { get; }

	// Methods

	// RVA: 0xC15D70 Offset: 0xC14770 VA: 0x180C15D70
	public float get_BlendWeight() { }

	// RVA: 0xC16020 Offset: 0xC14A20 VA: 0x180C16020
	public bool get_IsValid() { }

	// RVA: 0xC15FF0 Offset: 0xC149F0 VA: 0x180C15FF0
	public bool get_IsComplete() { }

	// RVA: 0xC15E00 Offset: 0xC14800 VA: 0x180C15E00
	public string get_Description() { }

	// RVA: 0xC15BE0 Offset: 0xC145E0 VA: 0x180C15BE0
	public bool Uses(ICinemachineCamera cam) { }

	// RVA: 0xC15CE0 Offset: 0xC146E0 VA: 0x180C15CE0
	public void .ctor(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	// RVA: 0xC15AE0 Offset: 0xC144E0 VA: 0x180C15AE0
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0xC160A0 Offset: 0xC14AA0 VA: 0x180C160A0
	public CameraState get_State() { }
}
