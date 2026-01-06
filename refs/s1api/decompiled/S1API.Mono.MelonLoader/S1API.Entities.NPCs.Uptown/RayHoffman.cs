using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class RayHoffman : NPC
{
	public new static string NPCId => "ray_hoffman";

	internal RayHoffman()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "ray_hoffman"))
	{
	}
}
