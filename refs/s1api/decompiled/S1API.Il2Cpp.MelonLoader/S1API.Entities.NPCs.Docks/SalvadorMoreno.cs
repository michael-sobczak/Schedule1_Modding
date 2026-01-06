using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class SalvadorMoreno : NPC
{
	public new static string NPCId => "salvador_moreno";

	internal SalvadorMoreno()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "salvador_moreno"))
	{
	}
}
