public class CinemachineInputProvider : MonoBehaviour, AxisState.IInputAxisProvider // TypeDefIndex: 16194
{
	// Fields
	[Tooltip("Leave this at -1 for single-player games.  For multi-player games, set this to be the player index, and the actions will be read from that player's controls")]
	public int PlayerIndex; // 0x20
	[Tooltip("If set, Input Actions will be auto-enabled at start")]
	public bool AutoEnableInputs; // 0x24
	[Tooltip("Vector2 action for XY movement")]
	public InputActionReference XYAxis; // 0x28
	[Tooltip("Float action for Z movement")]
	public InputActionReference ZAxis; // 0x30
	private const int NUM_AXES = 3;
	private InputAction[] m_cachedActions; // 0x38

	// Methods

	// RVA: 0xC2C760 Offset: 0xC2B160 VA: 0x180C2C760 Slot: 5
	public virtual float GetAxisValue(int axis) { }

	// RVA: 0xC2C860 Offset: 0xC2B260 VA: 0x180C2C860
	protected InputAction ResolveForPlayer(int axis, InputActionReference actionRef) { }

	// RVA: 0x4F4EF0 Offset: 0x4F38F0 VA: 0x1804F4EF0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0xC2CE40 Offset: 0xC2B840 VA: 0x180C2CE40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xC2CD30 Offset: 0xC2B730 VA: 0x180C2CD30
	internal static InputAction <ResolveForPlayer>g__GetFirstMatch|7_0(in InputUser user, InputActionReference aRef) { }
}
