public class VRIK : IK // TypeDefIndex: 14087
{
	// Fields
	[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
	[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
	public VRIK.References references; // 0x40
	[Tooltip("The VRIK solver.")]
	public IKSolverVR solver; // 0x48

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1ECA340 Offset: 0x1EC8D40 VA: 0x181ECA340 Slot: 8
	protected override void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1ECA280 Offset: 0x1EC8C80 VA: 0x181ECA280 Slot: 9
	protected override void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
	// RVA: 0x1ECA2E0 Offset: 0x1EC8CE0 VA: 0x181ECA2E0
	private void OpenSetupTutorial() { }

	[ContextMenu("Auto-detect References")]
	// RVA: 0x1ECA140 Offset: 0x1EC8B40 VA: 0x181ECA140
	public void AutoDetectReferences() { }

	[ContextMenu("Guess Hand Orientations")]
	// RVA: 0x1ECA170 Offset: 0x1EC8B70 VA: 0x181ECA170
	public void GuessHandOrientations() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80 Slot: 7
	public override IKSolver GetIKSolver() { }

	// RVA: 0x1ECA1A0 Offset: 0x1EC8BA0 VA: 0x181ECA1A0 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x1ECA3A0 Offset: 0x1EC8DA0 VA: 0x181ECA3A0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x1ECA5A0 Offset: 0x1EC8FA0 VA: 0x181ECA5A0
	public void .ctor() { }
}
