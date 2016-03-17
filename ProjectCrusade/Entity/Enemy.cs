﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectCrusade
{
	public class Enemy : Entity
	{
		public float Health { get; set; }

		/// <summary>
		/// How many pixels/sec the enemy moves.
		/// </summary>
		public float Speed { get; protected set; }

		public enum State { 
			Chasing, 
			Patrolling,
			Stationary
		}
		public State CurrState;
		Vector2 patrollingDirection;
		float patrollingTime = 0.0f;
		const float maxPatrollingTime = 1e3f;//in millis

		const float patrollingSpeedMult = 0.5f;

		public Enemy ()
		{
			Width = 16;
			Height = 16;
			Speed = 120;
			patrollingDirection = new Vector2 (1, 0);
		}

		/// <summary>
		/// Returns a random normal vector
		/// </summary>
		Vector2 randomDirection(Random rand)
		{
			return Vector2.Normalize(new Vector2 ((float)rand.NextDouble () - .5f, (float)rand.NextDouble () - .5f));
		}

		public override void Update (GameTime gameTime, World world) 
		{
			bool line_sight = world.HasLineOfSight (world.WorldToTileCoord (Position), world.WorldToTileCoord (world.Player.Position));


			if (line_sight)
				CurrState = State.Chasing;
			else if (CurrState==State.Chasing) 
				CurrState = State.Patrolling;

			//Change direction
			if (world.rand.NextDouble() < 0.001 * gameTime.ElapsedGameTime.TotalMilliseconds)
			{
				if (CurrState == State.Patrolling)
					CurrState = State.Stationary;
				else if (CurrState == State.Stationary) {
					CurrState = State.Patrolling;
					patrollingDirection = randomDirection (world.rand);
				}
				patrollingTime = 0.0f;
			}
			float displacement = (float)gameTime.ElapsedGameTime.TotalSeconds * Speed;
			switch (CurrState) {
			case State.Chasing:
				const float interactionRadius = 1000;
				if ((world.Player.Position - Position).LengthSquared () < interactionRadius * interactionRadius) {
					Vector2 nvec = Vector2.Normalize (world.Player.Position - Position);
					Position += displacement * nvec;
				}
				break;
			case State.Patrolling:
				Position += patrollingDirection * displacement*patrollingSpeedMult;
				break;
			case State.Stationary:

				break;
			}
			patrollingTime += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
		}

		public override void Draw (SpriteBatch spriteBatch, TextureManager textureManager, FontManager fontManager)
		{
			spriteBatch.Draw (textureManager.GetTexture ("circle"), null, CollisionBox, null, null, 0, null, null, SpriteEffects.None, 1);
		}
	}
}

