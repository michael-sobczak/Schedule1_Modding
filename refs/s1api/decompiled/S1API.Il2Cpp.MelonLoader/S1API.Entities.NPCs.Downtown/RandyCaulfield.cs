using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class RandyCaulfield : NPC
{
	public new static string NPCId => "randy_caulfield";

	internal RandyCaulfield()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "randy_caulfield"))
	{
	}
}
