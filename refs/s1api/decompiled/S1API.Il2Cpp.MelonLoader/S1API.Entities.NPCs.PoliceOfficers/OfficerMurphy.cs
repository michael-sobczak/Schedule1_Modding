using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerMurphy : NPC
{
	public new static string NPCId => "officermurphy";

	internal OfficerMurphy()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "officermurphy"))
	{
	}
}
