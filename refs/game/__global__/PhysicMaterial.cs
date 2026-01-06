public class PhysicMaterial : Object // TypeDefIndex: 18467
{
	// Properties
	public float bounciness { set; }
	public float dynamicFriction { set; }
	public float staticFriction { set; }
	public PhysicMaterialCombine frictionCombine { set; }
	public PhysicMaterialCombine bounceCombine { set; }

	// Methods

	// RVA: 0x2D33D60 Offset: 0x2D32760 VA: 0x182D33D60
	public void .ctor() { }

	// RVA: 0x2D33D10 Offset: 0x2D32710 VA: 0x182D33D10
	private static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name) { }

	// RVA: 0x2D33E30 Offset: 0x2D32830 VA: 0x182D33E30
	public void set_bounciness(float value) { }

	// RVA: 0x2D33E80 Offset: 0x2D32880 VA: 0x182D33E80
	public void set_dynamicFriction(float value) { }

	// RVA: 0x2D33F10 Offset: 0x2D32910 VA: 0x182D33F10
	public void set_staticFriction(float value) { }

	// RVA: 0x2D33ED0 Offset: 0x2D328D0 VA: 0x182D33ED0
	public void set_frictionCombine(PhysicMaterialCombine value) { }

	// RVA: 0x2D33DF0 Offset: 0x2D327F0 VA: 0x182D33DF0
	public void set_bounceCombine(PhysicMaterialCombine value) { }
}
