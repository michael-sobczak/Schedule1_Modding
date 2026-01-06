public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 9741
{
	// Fields
	private TypeConverter _converter; // 0x60
	private Hashtable _valueChangedHandlers; // 0x68
	private object[] _editors; // 0x70
	private Type[] _editorTypes; // 0x78
	private int _editorCount; // 0x80

	// Properties
	public abstract Type ComponentType { get; }
	public virtual TypeConverter Converter { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: 0x2668000 Offset: 0x2666A00 VA: 0x182668000
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x2668010 Offset: 0x2666A10 VA: 0x182668010
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_ComponentType();

	// RVA: 0x266F8E0 Offset: 0x266E2E0 VA: 0x18266F8E0 Slot: 14
	public virtual TypeConverter get_Converter() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool CanResetValue(object component);

	// RVA: 0x266F1F0 Offset: 0x266DBF0 VA: 0x18266F1F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x266EFC0 Offset: 0x266D9C0 VA: 0x18266EFC0
	protected object CreateInstance(Type type) { }

	// RVA: 0x266F380 Offset: 0x266DD80 VA: 0x18266F380 Slot: 11
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x266F3F0 Offset: 0x266DDF0 VA: 0x18266F3F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x266F460 Offset: 0x266DE60 VA: 0x18266F460 Slot: 12
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x266F5F0 Offset: 0x266DFF0 VA: 0x18266F5F0
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract object GetValue(object component);

	// RVA: 0x266F840 Offset: 0x266E240 VA: 0x18266F840 Slot: 19
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ResetValue(object component);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool ShouldSerializeValue(object component);
}
