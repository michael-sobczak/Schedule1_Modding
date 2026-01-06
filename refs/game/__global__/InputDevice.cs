public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 18908
{
	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x2F5FDA0 Offset: 0x2F5E7A0 VA: 0x182F5FDA0
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x2F5FDB0 Offset: 0x2F5E7B0 VA: 0x182F5FDB0
	private ulong get_deviceId() { }

	// RVA: 0x2F5FC90 Offset: 0x2F5E690 VA: 0x182F5FC90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F5FD40 Offset: 0x2F5E740 VA: 0x182F5FD40 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x2F5FD70 Offset: 0x2F5E770 VA: 0x182F5FD70 Slot: 2
	public override int GetHashCode() { }
}
