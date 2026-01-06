public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 10998
{
	// Fields
	private MemberSerialization _memberSerialization; // 0x68
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x6C
	internal Nullable<Required> _itemRequired; // 0x74
	internal Nullable<NullValueHandling> _itemNullValueHandling; // 0x7C

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public MissingMemberHandling MissingMemberHandling { get; set; }
	public NullValueHandling ItemNullValueHandling { get; set; }
	public Required ItemRequired { get; set; }

	// Methods

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_MemberSerialization(MemberSerialization value) { }

	// RVA: 0x1D0DEF0 Offset: 0x1D0C8F0 VA: 0x181D0DEF0
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x1D0DFF0 Offset: 0x1D0C9F0 VA: 0x181D0DFF0
	public void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x1D0DE70 Offset: 0x1D0C870 VA: 0x181D0DE70
	public NullValueHandling get_ItemNullValueHandling() { }

	// RVA: 0x1D0DF30 Offset: 0x1D0C930 VA: 0x181D0DF30
	public void set_ItemNullValueHandling(NullValueHandling value) { }

	// RVA: 0x1D0DEB0 Offset: 0x1D0C8B0 VA: 0x181D0DEB0
	public Required get_ItemRequired() { }

	// RVA: 0x1D0DF90 Offset: 0x1D0C990 VA: 0x181D0DF90
	public void set_ItemRequired(Required value) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x1D0DE40 Offset: 0x1D0C840 VA: 0x181D0DE40
	public void .ctor(MemberSerialization memberSerialization) { }

	[NullableContext(1)]
	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(string id) { }
}
