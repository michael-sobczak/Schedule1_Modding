public enum InputDeviceChange // TypeDefIndex: 7371
{
	// Fields
	public int value__; // 0x0
	public const InputDeviceChange Added = 0;
	public const InputDeviceChange Removed = 1;
	public const InputDeviceChange Disconnected = 2;
	public const InputDeviceChange Reconnected = 3;
	public const InputDeviceChange Enabled = 4;
	public const InputDeviceChange Disabled = 5;
	public const InputDeviceChange UsageChanged = 6;
	public const InputDeviceChange ConfigurationChanged = 7;
	public const InputDeviceChange SoftReset = 8;
	public const InputDeviceChange HardReset = 9;
	[Obsolete("Destroyed enum has been deprecated.")]
	public const InputDeviceChange Destroyed = 10;
}
