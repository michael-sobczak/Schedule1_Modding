using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerGreen : NPC
{
	public new static string NPCId => "officergreen";

	internal OfficerGreen()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "officergreen"))
	{
	}
}
