public interface IConfigurable // TypeDefIndex: 1224
{
	// Properties
	public abstract EntityConfiguration Configuration { get; }
	public abstract ConfigurationReplicator ConfigReplicator { get; }
	public abstract EConfigurableType ConfigurableType { get; }
	public abstract WorldspaceUIElement WorldspaceUI { get; set; }
	public abstract NetworkObject CurrentPlayerConfigurer { get; set; }
	public virtual bool IsBeingConfiguredByOtherPlayer { get; }
	public abstract Sprite TypeIcon { get; }
	public abstract Transform Transform { get; }
	public abstract Transform UIPoint { get; }
	public virtual bool IsDestroyed { get; }
	public abstract bool CanBeSelected { get; }
	public abstract Property ParentProperty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EntityConfiguration get_Configuration();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ConfigurationReplicator get_ConfigReplicator();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract EConfigurableType get_ConfigurableType();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract WorldspaceUIElement get_WorldspaceUI();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_WorldspaceUI(WorldspaceUIElement value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract NetworkObject get_CurrentPlayerConfigurer();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_CurrentPlayerConfigurer(NetworkObject value);

	// RVA: 0x60F800 Offset: 0x60E200 VA: 0x18060F800 Slot: 7
	public virtual bool get_IsBeingConfiguredByOtherPlayer() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Sprite get_TypeIcon();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Transform get_Transform();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Transform get_UIPoint();

	// RVA: 0x60F8C0 Offset: 0x60E2C0 VA: 0x18060F8C0 Slot: 11
	public virtual bool get_IsDestroyed() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_CanBeSelected();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Property get_ParentProperty();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract WorldspaceUIElement CreateWorldspaceUI();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void DestroyWorldspaceUI();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ShowOutline(Color color);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void HideOutline();

	// RVA: 0x60F7A0 Offset: 0x60E1A0 VA: 0x18060F7A0 Slot: 18
	public virtual void Selected() { }

	// RVA: 0x60F740 Offset: 0x60E140 VA: 0x18060F740 Slot: 19
	public virtual void Deselected() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void SetConfigurer(NetworkObject player);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SendConfigurationToClient(NetworkConnection conn);
}
