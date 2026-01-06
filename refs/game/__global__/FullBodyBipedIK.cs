public class FullBodyBipedIK : IK // TypeDefIndex: 14079
{
	// Fields
	public BipedReferences references; // 0x40
	public IKSolverFullBodyBiped solver; // 0x48

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1EB9DD0 Offset: 0x1EB87D0 VA: 0x181EB9DD0 Slot: 8
	protected override void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1EB9D10 Offset: 0x1EB8710 VA: 0x181EB9D10 Slot: 9
	protected override void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO (SETUP)")]
	// RVA: 0x1EB9D70 Offset: 0x1EB8770 VA: 0x181EB9D70
	private void OpenSetupTutorial() { }

	[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
	// RVA: 0x1EB9CB0 Offset: 0x1EB86B0 VA: 0x181EB9CB0
	private void OpenInspectorTutorial() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1EBA520 Offset: 0x1EB8F20 VA: 0x181EBA520
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1EB9B60 Offset: 0x1EB8560 VA: 0x181EB9B60
	private void ASThread() { }

	// RVA: 0x1EBA4D0 Offset: 0x1EB8ED0 VA: 0x181EBA4D0
	public void SetReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 7
	public override IKSolver GetIKSolver() { }

	// RVA: 0x1EB9E30 Offset: 0x1EB8830 VA: 0x181EB9E30
	public bool ReferencesError(ref string errorMessage) { }

	// RVA: 0x1EBA090 Offset: 0x1EB8A90 VA: 0x181EBA090
	public bool ReferencesWarning(ref string warningMessage) { }

	[ContextMenu("Reinitiate")]
	// RVA: 0x1EBA470 Offset: 0x1EB8E70 VA: 0x181EBA470
	private void Reinitiate() { }

	[ContextMenu("Auto-detect References")]
	// RVA: 0x1EB9BC0 Offset: 0x1EB85C0 VA: 0x181EB9BC0
	private void AutoDetectReferences() { }

	// RVA: 0x1EBA580 Offset: 0x1EB8F80 VA: 0x181EBA580
	public void .ctor() { }
}
