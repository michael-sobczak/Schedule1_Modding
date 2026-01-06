public static class ChallengeResponse2 // TypeDefIndex: 17522
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1A57140 Offset: 0x1A55B40 VA: 0x181A57140
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1A57430 Offset: 0x1A55E30 VA: 0x181A57430
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1A57540 Offset: 0x1A55F40 VA: 0x181A57540
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1A575B0 Offset: 0x1A55FB0 VA: 0x181A575B0
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1A577E0 Offset: 0x1A561E0 VA: 0x181A577E0
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1A57D20 Offset: 0x1A56720 VA: 0x181A57D20
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1A57F30 Offset: 0x1A56930 VA: 0x181A57F30
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x1A58310 Offset: 0x1A56D10 VA: 0x181A58310
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1A58190 Offset: 0x1A56B90 VA: 0x181A58190
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1A58500 Offset: 0x1A56F00 VA: 0x181A58500
	private static void .cctor() { }
}
