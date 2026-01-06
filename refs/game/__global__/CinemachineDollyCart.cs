public class CinemachineDollyCart : MonoBehaviour // TypeDefIndex: 16060
{
	// Fields
	[Tooltip("The path to follow")]
	public CinemachinePathBase m_Path; // 0x20
	[Tooltip("When to move the cart, if Velocity is non-zero")]
	public CinemachineDollyCart.UpdateMethod m_UpdateMethod; // 0x28
	[Tooltip("How to interpret the Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
	public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x2C
	[Tooltip("Move the cart with this speed along the path.  The value is interpreted according to the Position Units setting.")]
	[FormerlySerializedAs("m_Velocity")]
	public float m_Speed; // 0x30
	[FormerlySerializedAs("m_CurrentDistance")]
	[Tooltip("The position along the path at which the cart will be placed.  This can be animated directly or, if the velocity is non-zero, will be updated automatically.  The value is interpreted according to the Position Units setting.")]
	public float m_Position; // 0x34

	// Methods

	// RVA: 0xBEA410 Offset: 0xBE8E10 VA: 0x180BEA410
	private void FixedUpdate() { }

	// RVA: 0xBEA650 Offset: 0xBE9050 VA: 0x180BEA650
	private void Update() { }

	// RVA: 0xBEA460 Offset: 0xBE8E60 VA: 0x180BEA460
	private void LateUpdate() { }

	// RVA: 0xBEA510 Offset: 0xBE8F10 VA: 0x180BEA510
	private void SetCartPosition(float distanceAlongPath) { }

	// RVA: 0xBEA6F0 Offset: 0xBE90F0 VA: 0x180BEA6F0
	public void .ctor() { }
}
