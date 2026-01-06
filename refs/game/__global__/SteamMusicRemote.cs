public static class SteamMusicRemote // TypeDefIndex: 14343
{
	// Methods

	// RVA: 0xC6E290 Offset: 0xC6CC90 VA: 0x180C6E290
	public static bool RegisterSteamMusicRemote(string pchName) { }

	// RVA: 0xC6DEC0 Offset: 0xC6C8C0 VA: 0x180C6DEC0
	public static bool DeregisterSteamMusicRemote() { }

	// RVA: 0xC6DD70 Offset: 0xC6C770 VA: 0x180C6DD70
	public static bool BIsCurrentMusicRemote() { }

	// RVA: 0xC6DD10 Offset: 0xC6C710 VA: 0x180C6DD10
	public static bool BActivationSuccess(bool bValue) { }

	// RVA: 0xC6E4E0 Offset: 0xC6CEE0 VA: 0x180C6E4E0
	public static bool SetDisplayName(string pchDisplayName) { }

	// RVA: 0xC6E5F0 Offset: 0xC6CFF0 VA: 0x180C6E5F0
	public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength) { }

	// RVA: 0xC6DFD0 Offset: 0xC6C9D0 VA: 0x180C6DFD0
	public static bool EnablePlayPrevious(bool bValue) { }

	// RVA: 0xC6DF70 Offset: 0xC6C970 VA: 0x180C6DF70
	public static bool EnablePlayNext(bool bValue) { }

	// RVA: 0xC6E0F0 Offset: 0xC6CAF0 VA: 0x180C6E0F0
	public static bool EnableShuffled(bool bValue) { }

	// RVA: 0xC6DF10 Offset: 0xC6C910 VA: 0x180C6DF10
	public static bool EnableLooped(bool bValue) { }

	// RVA: 0xC6E090 Offset: 0xC6CA90 VA: 0x180C6E090
	public static bool EnableQueue(bool bValue) { }

	// RVA: 0xC6E030 Offset: 0xC6CA30 VA: 0x180C6E030
	public static bool EnablePlaylists(bool bValue) { }

	// RVA: 0xC6EAD0 Offset: 0xC6D4D0 VA: 0x180C6EAD0
	public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus) { }

	// RVA: 0xC6EB20 Offset: 0xC6D520 VA: 0x180C6EB20
	public static bool UpdateShuffled(bool bValue) { }

	// RVA: 0xC6EA70 Offset: 0xC6D470 VA: 0x180C6EA70
	public static bool UpdateLooped(bool bValue) { }

	// RVA: 0xC6EB80 Offset: 0xC6D580 VA: 0x180C6EB80
	public static bool UpdateVolume(float flValue) { }

	// RVA: 0xC6DE70 Offset: 0xC6C870 VA: 0x180C6DE70
	public static bool CurrentEntryWillChange() { }

	// RVA: 0xC6DE10 Offset: 0xC6C810 VA: 0x180C6DE10
	public static bool CurrentEntryIsAvailable(bool bAvailable) { }

	// RVA: 0xC6E960 Offset: 0xC6D360 VA: 0x180C6E960
	public static bool UpdateCurrentEntryText(string pchText) { }

	// RVA: 0xC6E910 Offset: 0xC6D310 VA: 0x180C6E910
	public static bool UpdateCurrentEntryElapsedSeconds(int nValue) { }

	// RVA: 0xC6E8B0 Offset: 0xC6D2B0 VA: 0x180C6E8B0
	public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength) { }

	// RVA: 0xC6DDC0 Offset: 0xC6C7C0 VA: 0x180C6DDC0
	public static bool CurrentEntryDidChange() { }

	// RVA: 0xC6E240 Offset: 0xC6CC40 VA: 0x180C6E240
	public static bool QueueWillChange() { }

	// RVA: 0xC6E3F0 Offset: 0xC6CDF0 VA: 0x180C6E3F0
	public static bool ResetQueueEntries() { }

	// RVA: 0xC6E780 Offset: 0xC6D180 VA: 0x180C6E780
	public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText) { }

	// RVA: 0xC6E490 Offset: 0xC6CE90 VA: 0x180C6E490
	public static bool SetCurrentQueueEntry(int nID) { }

	// RVA: 0xC6E1F0 Offset: 0xC6CBF0 VA: 0x180C6E1F0
	public static bool QueueDidChange() { }

	// RVA: 0xC6E1A0 Offset: 0xC6CBA0 VA: 0x180C6E1A0
	public static bool PlaylistWillChange() { }

	// RVA: 0xC6E3A0 Offset: 0xC6CDA0 VA: 0x180C6E3A0
	public static bool ResetPlaylistEntries() { }

	// RVA: 0xC6E650 Offset: 0xC6D050 VA: 0x180C6E650
	public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText) { }

	// RVA: 0xC6E440 Offset: 0xC6CE40 VA: 0x180C6E440
	public static bool SetCurrentPlaylistEntry(int nID) { }

	// RVA: 0xC6E150 Offset: 0xC6CB50 VA: 0x180C6E150
	public static bool PlaylistDidChange() { }
}
