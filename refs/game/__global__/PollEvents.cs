public enum PollEvents // TypeDefIndex: 19228
{
	// Fields
	public short value__; // 0x0
	public const PollEvents POLLIN = 1;
	public const PollEvents POLLPRI = 2;
	public const PollEvents POLLOUT = 4;
	public const PollEvents POLLERR = 8;
	public const PollEvents POLLHUP = 16;
	public const PollEvents POLLNVAL = 32;
	public const PollEvents POLLRDNORM = 64;
	public const PollEvents POLLRDBAND = 128;
	public const PollEvents POLLWRNORM = 256;
	public const PollEvents POLLWRBAND = 512;
}
