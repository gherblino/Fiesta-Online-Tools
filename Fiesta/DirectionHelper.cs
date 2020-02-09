using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiesta
{
	public static class DirectionHelper
	{
		public static Direction GetDirection(int dx, int dy)
		{
			/* Somewhere in the West direction */
			if (dx < 0)
			{
				// North West
				if (dy < 0)
					return Direction.NORTH_WEST;

				// West
				if (dy == 0)
					return Direction.WEST;

				// South West
				return Direction.SOUTH_WEST;
			}

			/* Either North, None or South */
			if (dx == 0)
			{
				// North
				if (dy < 0)
					return Direction.NORTH;

				// None
				if (dy == 0)
					return Direction.NONE;

				// South
				return Direction.SOUTH;
			}

			/* Somewhere in the East direction */
			// North East
			if (dy < 0)
				return Direction.NORTH_EAST;

			// East
			if (dy == 0)
				return Direction.EAST;

			// South East
			return Direction.SOUTH_EAST;
		}

	}
}
