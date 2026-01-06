public class Container : IContainer, IDisposable // TypeDefIndex: 9781
{
	// Fields
	private ISite[] sites; // 0x10
	private int siteCount; // 0x18
	private ComponentCollection components; // 0x20
	private ContainerFilterService filter; // 0x28
	private bool checkedFilter; // 0x30
	private object syncObj; // 0x38

	// Properties
	public virtual ComponentCollection Components { get; }

	// Methods

	// RVA: 0x265CAC0 Offset: 0x265B4C0 VA: 0x18265CAC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A809B0 Offset: 0x1A7F3B0 VA: 0x181A809B0 Slot: 8
	public virtual void Add(IComponent component) { }

	// RVA: 0x265C330 Offset: 0x265AD30 VA: 0x18265C330 Slot: 9
	public virtual void Add(IComponent component, string name) { }

	// RVA: 0x265C630 Offset: 0x265B030 VA: 0x18265C630 Slot: 10
	protected virtual ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x265C6D0 Offset: 0x265B0D0 VA: 0x18265C6D0 Slot: 7
	public void Dispose() { }

	// RVA: 0x265C740 Offset: 0x265B140 VA: 0x18265C740 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x265CB30 Offset: 0x265B530 VA: 0x18265CB30 Slot: 12
	protected virtual object GetService(Type service) { }

	// RVA: 0x265D1E0 Offset: 0x265BBE0 VA: 0x18265D1E0 Slot: 13
	public virtual ComponentCollection get_Components() { }

	// RVA: 0x265CBC0 Offset: 0x265B5C0 VA: 0x18265CBC0 Slot: 14
	public virtual void Remove(IComponent component) { }

	// RVA: 0x265CBD0 Offset: 0x265B5D0 VA: 0x18265CBD0
	private void Remove(IComponent component, bool preserveSite) { }

	// RVA: 0x265CE10 Offset: 0x265B810 VA: 0x18265CE10 Slot: 15
	protected virtual void ValidateName(IComponent component, string name) { }

	// RVA: 0x265D170 Offset: 0x265BB70 VA: 0x18265D170
	public void .ctor() { }
}
