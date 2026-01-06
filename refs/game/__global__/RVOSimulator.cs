public class RVOSimulator : VersionedMonoBehaviour // TypeDefIndex: 13432
{
	// Fields
	[CompilerGenerated]
	private static RVOSimulator <active>k__BackingField; // 0x0
	[Tooltip("Desired FPS for rvo simulation. It is usually not necessary to run a crowd simulation at a very high fps.
Usually 10-30 fps is enough, but can be increased for better quality.
The rvo simulation will never run at a higher fps than the game")]
	public int desiredSimulationFPS; // 0x28
	[Tooltip("Number of RVO worker threads. If set to None, no multithreading will be used.")]
	public ThreadCount workerThreads; // 0x2C
	[Tooltip("Calculate local avoidance in between frames.
This can increase jitter in the agents' movement so use it only if you really need the performance boost. It will also reduce the responsiveness of the agents to the commands you send to them.")]
	public bool doubleBuffering; // 0x30
	[Range(0, 0.2)]
	[Tooltip("Bias agents to pass each other on the right side.
If the desired velocity of an agent puts it on a collision course with another agent or an obstacle its desired velocity will be rotated this number of radians (1 radian is approximately 57°) to the right. This helps to break up symmetries and makes it possible to resolve some situations much faster.

When many agents have the same goal this can however have the side effect that the group clustered around the target point may as a whole start to spin around the target point.")]
	public float symmetryBreakingBias; // 0x34
	[Tooltip("Determines if the XY (2D) or XZ (3D) plane is used for movement")]
	public MovementPlane movementPlane; // 0x38
	public bool drawObstacles; // 0x3C
	private Simulator simulator; // 0x40

	// Properties
	public static RVOSimulator active { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBC7910 Offset: 0xBC6310 VA: 0x180BC7910
	public static RVOSimulator get_active() { }

	[CompilerGenerated]
	// RVA: 0xBC7950 Offset: 0xBC6350 VA: 0x180BC7950
	private static void set_active(RVOSimulator value) { }

	// RVA: 0xBC7620 Offset: 0xBC6020 VA: 0x180BC7620
	public Simulator GetSimulator() { }

	// RVA: 0xBC7780 Offset: 0xBC6180 VA: 0x180BC7780
	private void OnEnable() { }

	// RVA: 0xBC74D0 Offset: 0xBC5ED0 VA: 0x180BC74D0 Slot: 7
	protected override void Awake() { }

	// RVA: 0xBC77E0 Offset: 0xBC61E0 VA: 0x180BC77E0
	private void Update() { }

	// RVA: 0xBC7660 Offset: 0xBC6060 VA: 0x180BC7660
	private void OnDestroy() { }

	// RVA: 0xBC78F0 Offset: 0xBC62F0 VA: 0x180BC78F0
	public void .ctor() { }
}
