using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class LouisFourier : NPC
{
	public new static string NPCId => "louis_fourier";

	internal LouisFourier()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "louis_fourier"))
	{
	}
}
