public class ClaimsIdentity : IIdentity // TypeDefIndex: 4266
{
	// Fields
	private byte[] m_userSerializationData; // 0x10
	private List<Claim> m_instanceClaims; // 0x18
	private Collection<IEnumerable<Claim>> m_externalClaims; // 0x20
	private string m_nameType; // 0x28
	private string m_roleType; // 0x30
	[OptionalField(VersionAdded = 2)]
	private string m_version; // 0x38
	[OptionalField(VersionAdded = 2)]
	private ClaimsIdentity m_actor; // 0x40
	[OptionalField(VersionAdded = 2)]
	private string m_authenticationType; // 0x48
	[OptionalField(VersionAdded = 2)]
	private object m_bootstrapContext; // 0x50
	[OptionalField(VersionAdded = 2)]
	private string m_label; // 0x58
	[OptionalField(VersionAdded = 2)]
	private string m_serializedNameType; // 0x60
	[OptionalField(VersionAdded = 2)]
	private string m_serializedRoleType; // 0x68
	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaims; // 0x70

	// Properties
	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }

	// Methods

	// RVA: 0x1B06490 Offset: 0x1B04E90 VA: 0x181B06490
	public void .ctor() { }

	// RVA: 0x1B06460 Offset: 0x1B04E60 VA: 0x181B06460
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x1B06CF0 Offset: 0x1B056F0 VA: 0x181B06CF0
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x1B06680 Offset: 0x1B05080 VA: 0x181B06680
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x1B064C0 Offset: 0x1B04EC0 VA: 0x181B064C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x1B06DD0 Offset: 0x1B057D0 VA: 0x181B06DD0
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachine(typeof(ClaimsIdentity.<get_Claims>d__51))]
	// RVA: 0x1B06D20 Offset: 0x1B05720 VA: 0x181B06D20 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x1B06DA0 Offset: 0x1B057A0 VA: 0x181B06DA0 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x1B04BB0 Offset: 0x1B035B0 VA: 0x181B04BB0 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x1B06090 Offset: 0x1B04A90 VA: 0x181B06090
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x1B05FF0 Offset: 0x1B049F0 VA: 0x181B05FF0
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x1B056E0 Offset: 0x1B040E0 VA: 0x181B056E0 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializing]
	// RVA: 0x1B05F70 Offset: 0x1B04970 VA: 0x181B05F70
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x1B05DB0 Offset: 0x1B047B0 VA: 0x181B05DB0
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializing]
	// RVA: 0x1B05E90 Offset: 0x1B04890 VA: 0x181B05E90
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x1B058D0 Offset: 0x1B042D0 VA: 0x181B058D0 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B04D80 Offset: 0x1B03780 VA: 0x181B04D80
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x1B062B0 Offset: 0x1B04CB0 VA: 0x181B062B0
	private string SerializeClaims() { }

	// RVA: 0x1B05D60 Offset: 0x1B04760 VA: 0x181B05D60
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x1B05040 Offset: 0x1B03A40 VA: 0x181B05040
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }
}
