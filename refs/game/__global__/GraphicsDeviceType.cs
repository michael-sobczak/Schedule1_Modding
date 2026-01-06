public enum GraphicsDeviceType // TypeDefIndex: 12179
{
	// Fields
	public int value__; // 0x0
	[Obsolete("OpenGL2 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType OpenGL2 = 0;
	[Obsolete("Direct3D 9 is no longer supported in Unity 2017.2+")]
	public const GraphicsDeviceType Direct3D9 = 1;
	public const GraphicsDeviceType Direct3D11 = 2;
	[Obsolete("PS3 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType PlayStation3 = 3;
	public const GraphicsDeviceType Null = 4;
	[Obsolete("Xbox360 is no longer supported in Unity 5.5+")]
	public const GraphicsDeviceType Xbox360 = 6;
	public const GraphicsDeviceType OpenGLES2 = 8;
	public const GraphicsDeviceType OpenGLES3 = 11;
	[Obsolete("PVita is no longer supported as of Unity 2018")]
	public const GraphicsDeviceType PlayStationVita = 12;
	public const GraphicsDeviceType PlayStation4 = 13;
	public const GraphicsDeviceType XboxOne = 14;
	[Obsolete("PlayStationMobile is no longer supported in Unity 5.3+")]
	public const GraphicsDeviceType PlayStationMobile = 15;
	public const GraphicsDeviceType Metal = 16;
	public const GraphicsDeviceType OpenGLCore = 17;
	public const GraphicsDeviceType Direct3D12 = 18;
	[Obsolete("Nintendo 3DS support is unavailable since 2018.1")]
	public const GraphicsDeviceType N3DS = 19;
	public const GraphicsDeviceType Vulkan = 21;
	public const GraphicsDeviceType Switch = 22;
	public const GraphicsDeviceType XboxOneD3D12 = 23;
	public const GraphicsDeviceType GameCoreXboxOne = 24;
	[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
	public const GraphicsDeviceType GameCoreScarlett = -1;
	public const GraphicsDeviceType GameCoreXboxSeries = 25;
	public const GraphicsDeviceType PlayStation5 = 26;
	public const GraphicsDeviceType PlayStation5NGGC = 27;
}
