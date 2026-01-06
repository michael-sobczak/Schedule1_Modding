using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class RayHoffman : NPC
{
	public new static string NPCId => "ray_hoffman";

	internal RayHoffman()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "ray_hoffman"))
	{
	}
}
