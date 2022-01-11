using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcD_301171014_A1
{
	class Sprite
	{
		// fields
		public readonly double Diameter; // diameter of the sprite
		private static List<Sprite> allSprites = new List<Sprite>();

		// properties
		public string Name { get; set; }
		public int XCoordinate { get; private set; }
		public int YCoordinate { get; private set; }

		public Sprite(string spriteName, double diameter, int xCoordinate = 0, int yCoordinate = 0)
        {
			Name = spriteName;
			Diameter = diameter;
			XCoordinate = xCoordinate;
			YCoordinate = yCoordinate;

			// add this object to Sprite list
			allSprites.Add(this);
        }

        public override string ToString()
        {
			return $"{Name}:({XCoordinate}, {YCoordinate}, {Diameter})";
		}

        /*
		 * checks if two Sprites are in collision
		 * @params
		 * encounter - other Sprite object to compare with this current object
		 */
        private bool isCollision(Sprite encounter)
        {
			// compute for the sum of the two Sprite diameters then
			// get the half of it
			double halfsumDiameters = (this.Diameter + encounter.Diameter)/2;

			// compute for square root of x coordinates
			int xAxis = this.XCoordinate - encounter.XCoordinate;
			double xSquared = Math.Pow(xAxis, 2);

			// compute for square root of y coordinates
			int yAxis = this.YCoordinate - encounter.YCoordinate;
			double ySquared = Math.Pow(yAxis, 2);

			// compute distance between the sprites centers
			double spriteCenterDistance = Math.Sqrt((xSquared + ySquared));

            // Sprites are in in collision if the distance between their centers
            // is less than the half of the sum of their diameters
            return (spriteCenterDistance < halfsumDiameters);
		}

		/*
		 * checks if this Sprite collides with other Srite
		 */
        private bool anyCollision()
		{
			bool collisionFound = false;

			foreach(Sprite aSprite in allSprites)
            {
				// skip self
				if(aSprite.Name != this.Name)
                {
					collisionFound = isCollision(aSprite);
					if(collisionFound)
                    {
						break;
                    }
                }
            }

			return collisionFound;
		}

        /*
		 * function to move the Sprite:
		 * Up - increments YCoordinate
		 * Down - decrements YCoordinate
		 * Left - decrements XCoordinate
		 * Right - increments XCoordinate
		 * @params
		 * direction - specify which direction to move
		 */
        public void Move(Direction direction)
        {
			bool isCollisionFound;

			Console.WriteLine ($"Moving {this} {direction}");
			switch (direction)
            {
				case Direction.Up:
					YCoordinate += 1;
					break;
				case Direction.Down:
					YCoordinate -= 1;
					break;
				case Direction.Left:
					XCoordinate -= 1;
					break;
				case Direction.Right:
					XCoordinate += 1;
					break;
            }

			isCollisionFound = anyCollision();

			if (isCollisionFound)
            {
				// revert coordinates on collision
				switch (direction)
				{
					case Direction.Up:
						YCoordinate -= 1;
						break;
					case Direction.Down:
						YCoordinate += 1;
						break;
					case Direction.Left:
						XCoordinate += 1;
						break;
					case Direction.Right:
						XCoordinate -= 1;
						break;
				}
				Console.WriteLine($"Move {direction} failed! Collision. Position:{this}");
			} 
			else
            {
				Console.WriteLine($"Move {direction} successful. Position:{this}");
			}

		}
    }
}
