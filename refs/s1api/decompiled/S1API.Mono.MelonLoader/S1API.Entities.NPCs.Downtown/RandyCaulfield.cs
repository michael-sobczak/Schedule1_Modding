using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class RandyCaulfield : NPC
{
	public new static string NPCId => "randy_caulfield";

	internal RandyCaulfield()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "randy_caulfield"))
	{
	}
}
