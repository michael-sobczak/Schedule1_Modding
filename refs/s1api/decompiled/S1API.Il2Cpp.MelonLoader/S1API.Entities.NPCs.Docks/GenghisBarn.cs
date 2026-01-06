using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class GenghisBarn : NPC
{
	public new static string NPCId => "genghis_barn";

	internal GenghisBarn()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "genghis_barn"))
	{
	}
}
