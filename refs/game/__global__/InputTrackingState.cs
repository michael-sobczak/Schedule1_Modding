public enum InputTrackingState // TypeDefIndex: 18906
{
	// Fields
	public uint value__; // 0x0
	public const InputTrackingState None = 0;
	public const InputTrackingState Position = 1;
	public const InputTrackingState Rotation = 2;
	public const InputTrackingState Velocity = 4;
	public const InputTrackingState AngularVelocity = 8;
	public const InputTrackingState Acceleration = 16;
	public const InputTrackingState AngularAcceleration = 32;
	public const InputTrackingState All = 63;
}
