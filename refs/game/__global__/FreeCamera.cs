public class FreeCamera : MonoBehaviour // TypeDefIndex: 13553
{
	// Fields
	private const float k_MouseSensitivityMultiplier = 0.01;
	public float m_LookSpeedController; // 0x20
	public float m_LookSpeedMouse; // 0x24
	public float m_MoveSpeed; // 0x28
	public float m_MoveSpeedIncrement; // 0x2C
	public float m_Turbo; // 0x30
	private InputAction lookAction; // 0x38
	private InputAction moveAction; // 0x40
	private InputAction speedAction; // 0x48
	private InputAction yMoveAction; // 0x50
	private float inputRotateAxisX; // 0x58
	private float inputRotateAxisY; // 0x5C
	private float inputChangeSpeed; // 0x60
	private float inputVertical; // 0x64
	private float inputHorizontal; // 0x68
	private float inputYAxis; // 0x6C
	private bool leftShiftBoost; // 0x70
	private bool leftShift; // 0x71
	private bool fire1; // 0x72

	// Methods

	// RVA: 0x29F47F0 Offset: 0x29F31F0 VA: 0x1829F47F0
	private void OnEnable() { }

	// RVA: 0x29F4800 Offset: 0x29F3200 VA: 0x1829F4800
	private void RegisterInputs() { }

	// RVA: 0x29F4FC0 Offset: 0x29F39C0 VA: 0x1829F4FC0
	private void UpdateInputs() { }

	// RVA: 0x29F5270 Offset: 0x29F3C70 VA: 0x1829F5270
	private void Update() { }

	// RVA: 0x29F5730 Offset: 0x29F4130 VA: 0x1829F5730
	public void .ctor() { }
}
