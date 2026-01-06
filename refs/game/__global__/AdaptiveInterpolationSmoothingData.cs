public struct AdaptiveInterpolationSmoothingData // TypeDefIndex: 12594
{
	// Fields
	[HideInInspector]
	public bool SmoothPosition; // 0x0
	[HideInInspector]
	public bool SmoothRotation; // 0x1
	[HideInInspector]
	public bool SmoothScale; // 0x2
	[HideInInspector]
	public Transform GraphicalObject; // 0x8
	[HideInInspector]
	public NetworkObject NetworkObject; // 0x10
	[HideInInspector]
	public float TeleportThreshold; // 0x18
	[Range(0.01, 5)]
	[Tooltip("Percentage of ping to use as interpolation. Higher values will result in more interpolation.")]
	public float NormalPercent; // 0x1C
	[Tooltip("Percentage of ping to use as interpolation when colliding with an object local client owns.This is used to speed up local interpolation when predicted objects collide with a player as well keep graphics closer to the objects root while colliding.")]
	[Range(0.01, 5)]
	public float CollisionPercent; // 0x20
	[Tooltip("How much per tick to decrease to collision interpolation when colliding with a local player object. Higher values will set interpolation to collision settings faster.")]
	[Range(0.1, 10)]
	public float CollisionStep; // 0x24
	[Tooltip("How much per tick to increase to normal interpolation when not colliding with a local player object. Higher values will set interpolation to normal settings faster.")]
	[Range(0.1, 10)]
	public float NormalStep; // 0x28
	internal const byte BASE_COLLISION_INTERPOLATION = 0;
	internal const byte BASE_NORMAL_INTERPOLATION = 1;
}
