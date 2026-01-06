public class CutsceneManager : Singleton<CutsceneManager> // TypeDefIndex: 1979
{
	// Fields
	public List<Cutscene> Cutscenes; // 0x28
	[SerializeField]
	[Header("Run cutscene by name")]
	private string cutsceneName; // 0x30
	private Cutscene playingCutscene; // 0x38

	// Methods

	[Button]
	// RVA: 0x7978F0 Offset: 0x7962F0 VA: 0x1807978F0
	private void RunCutscene() { }

	// RVA: 0x797740 Offset: 0x796140 VA: 0x180797740
	public void Play(string name) { }

	// RVA: 0x797690 Offset: 0x796090 VA: 0x180797690
	private void Ended() { }

	// RVA: 0x797AA0 Offset: 0x7964A0 VA: 0x180797AA0
	public void .ctor() { }
}
