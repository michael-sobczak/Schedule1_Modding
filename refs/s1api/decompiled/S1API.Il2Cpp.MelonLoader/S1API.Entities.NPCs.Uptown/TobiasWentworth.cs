using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class TobiasWentworth : NPC
{
	public new static string NPCId => "tobias_wentworth";

	internal TobiasWentworth()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "tobias_wentworth"))
	{
	}
}
