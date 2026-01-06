internal struct InputStateBuffers // TypeDefIndex: 7710
{
	// Fields
	public uint sizePerBuffer; // 0x0
	public uint totalSize; // 0x4
	public void* defaultStateBuffer; // 0x8
	public void* noiseMaskBuffer; // 0x10
	public void* resetMaskBuffer; // 0x18
	private void* m_AllBuffers; // 0x20
	internal InputStateBuffers.DoubleBuffers m_PlayerStateBuffers; // 0x28
	internal static void* s_DefaultStateBuffer; // 0x0
	internal static void* s_NoiseMaskBuffer; // 0x8
	internal static void* s_ResetMaskBuffer; // 0x10
	internal static InputStateBuffers.DoubleBuffers s_CurrentBuffers; // 0x18

	// Methods

	// RVA: 0x28778F0 Offset: 0x28762F0 VA: 0x1828778F0
	public InputStateBuffers.DoubleBuffers GetDoubleBuffersFor(InputUpdateType updateType) { }

	// RVA: 0x28779D0 Offset: 0x28763D0 VA: 0x1828779D0
	public static void* GetFrontBufferForDevice(int deviceIndex) { }

	// RVA: 0x2877890 Offset: 0x2876290 VA: 0x182877890
	public static void* GetBackBufferForDevice(int deviceIndex) { }

	// RVA: 0x28780B0 Offset: 0x2876AB0 VA: 0x1828780B0
	public static void SwitchTo(InputStateBuffers buffers, InputUpdateType update) { }

	// RVA: 0x28774E0 Offset: 0x2875EE0 VA: 0x1828774E0
	public void AllocateAll(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x2878020 Offset: 0x2876A20 VA: 0x182878020
	private static InputStateBuffers.DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer) { }

	// RVA: 0x28777C0 Offset: 0x28761C0 VA: 0x1828777C0
	public void FreeAll() { }

	// RVA: 0x2877A30 Offset: 0x2876430 VA: 0x182877A30
	public void MigrateAll(InputDevice[] devices, int deviceCount, InputStateBuffers oldBuffers) { }

	// RVA: 0x2877C00 Offset: 0x2876600 VA: 0x182877C00
	private static void MigrateDoubleBuffer(InputStateBuffers.DoubleBuffers newBuffer, InputDevice[] devices, int deviceCount, InputStateBuffers.DoubleBuffers oldBuffer) { }

	// RVA: 0x2877DD0 Offset: 0x28767D0 VA: 0x182877DD0
	private static void MigrateSingleBuffer(void* newBuffer, InputDevice[] devices, int deviceCount, void* oldBuffer) { }

	// RVA: 0x2877640 Offset: 0x2876040 VA: 0x182877640
	private static uint ComputeSizeOfSingleStateBuffer(InputDevice[] devices, int deviceCount) { }

	// RVA: 0x2877F10 Offset: 0x2876910 VA: 0x182877F10
	private static uint NextDeviceOffset(uint currentOffset, InputDevice device) { }
}
