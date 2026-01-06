public class Collision // TypeDefIndex: 18459
{
	// Fields
	private ContactPairHeader m_Header; // 0x10
	private ContactPair m_Pair; // 0x38
	private bool m_Flipped; // 0x60
	private ContactPoint[] m_LegacyContacts; // 0x68

	// Properties
	public Vector3 relativeVelocity { get; }
	public Rigidbody rigidbody { get; }
	public Component body { get; }
	public Collider collider { get; }
	public GameObject gameObject { get; }
	internal bool Flipped { set; }
	public int contactCount { get; }
	public ContactPoint[] contacts { get; }

	// Methods

	// RVA: 0x2D331F0 Offset: 0x2D31BF0 VA: 0x182D331F0
	public Vector3 get_relativeVelocity() { }

	// RVA: 0x2D33250 Offset: 0x2D31C50 VA: 0x182D33250
	public Rigidbody get_rigidbody() { }

	// RVA: 0x2D32FF0 Offset: 0x2D319F0 VA: 0x182D32FF0
	public Component get_body() { }

	// RVA: 0x2D33080 Offset: 0x2D31A80 VA: 0x182D33080
	public Collider get_collider() { }

	// RVA: 0x2D33150 Offset: 0x2D31B50 VA: 0x182D33150
	public GameObject get_gameObject() { }

	// RVA: 0x68C180 Offset: 0x68AB80 VA: 0x18068C180
	internal void set_Flipped(bool value) { }

	// RVA: 0x1E06CB0 Offset: 0x1E056B0 VA: 0x181E06CB0
	public int get_contactCount() { }

	// RVA: 0x2D330B0 Offset: 0x2D31AB0 VA: 0x182D330B0
	public ContactPoint[] get_contacts() { }

	// RVA: 0x2D32F90 Offset: 0x2D31990 VA: 0x182D32F90
	public void .ctor() { }

	// RVA: 0x2D32E90 Offset: 0x2D31890 VA: 0x182D32E90
	internal void .ctor(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x2D32E30 Offset: 0x2D31830 VA: 0x182D32E30
	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	// RVA: 0x2D32D40 Offset: 0x2D31740 VA: 0x182D32D40
	public int GetContacts(ContactPoint[] contacts) { }
}
