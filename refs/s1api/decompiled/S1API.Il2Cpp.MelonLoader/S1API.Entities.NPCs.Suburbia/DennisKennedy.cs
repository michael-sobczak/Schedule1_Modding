using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class DennisKennedy : NPC
{
	public new static string NPCId => "dennis_kennedy";

	internal DennisKennedy()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "dennis_kennedy"))
	{
	}
}
