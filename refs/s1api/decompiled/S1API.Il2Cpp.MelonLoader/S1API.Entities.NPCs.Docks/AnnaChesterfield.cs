using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class AnnaChesterfield : NPC
{
	public new static string NPCId => "anna_chesterfield";

	internal AnnaChesterfield()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "anna_chesterfield"))
	{
	}
}
