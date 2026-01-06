internal enum EventMask // TypeDefIndex: 5767
{
	// Fields
	public int value__; // 0x0
	public const EventMask NoEventMask = 0;
	public const EventMask KeyPressMask = 1;
	public const EventMask KeyReleaseMask = 2;
	public const EventMask ButtonPressMask = 4;
	public const EventMask ButtonReleaseMask = 8;
	public const EventMask EnterWindowMask = 16;
	public const EventMask LeaveWindowMask = 32;
	public const EventMask PointerMotionMask = 64;
	public const EventMask PointerMotionHintMask = 128;
	public const EventMask Button1MotionMask = 256;
	public const EventMask Button2MotionMask = 512;
	public const EventMask Button3MotionMask = 1024;
	public const EventMask Button4MotionMask = 2048;
	public const EventMask Button5MotionMask = 4096;
	public const EventMask ButtonMotionMask = 8192;
	public const EventMask KeymapStateMask = 16384;
	public const EventMask ExposureMask = 32768;
	public const EventMask VisibilityChangeMask = 65536;
	public const EventMask StructureNotifyMask = 131072;
	public const EventMask ResizeRedirectMask = 262144;
	public const EventMask SubstructureNotifyMask = 524288;
	public const EventMask SubstructureRedirectMask = 1048576;
	public const EventMask FocusChangeMask = 2097152;
	public const EventMask PropertyChangeMask = 4194304;
	public const EventMask ColormapChangeMask = 8388608;
	public const EventMask OwnerGrabButtonMask = 16777216;
}
