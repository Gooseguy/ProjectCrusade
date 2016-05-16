﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectCrusade
{
	public enum TileType 
	{
		Air=0,
		Grass=1,
		TreeTop=2,
		FlowersGrass=3,
		TreeBottom=18,
		SandCornersTopLeft=34,
		SandTop = 35,
		SandCornersTopRight=36,
		Sand=51,
		SandSideRight=52,
		SandCornersBottomLeft=66,
		SandBottom=67,
		SandCornersBottomRight=68,

		CaveFloor = 21,
		CaveFloorBottomRight = 6,
		CaveFloorBottomLeft = 7,
		CaveFloorTopLeft=22,
		CaveFloorTopRight=23,

		CaveWall=54,
		CaveWallTopLeft=37,
		CaveWallTopRight = 39,
		CaveWallBottomLeft = 69,
		CaveWallBottomRight = 71,
		CaveWallTop = 38,
		CaveWallBottom = 70,
		CaveWallLeft = 53,
		CaveWallRight=55,

		CaveRock = 5,


		IceCaveFloor = 27,
		IceCaveFloorBottomRight = 12,
		IceCaveFloorBottomLeft = 13,
		IceCaveFloorTopLeft=28,
		IceCaveFloorTopRight=29,

		IceCaveWall=60,
		IceCaveWallTopLeft=43,
		IceCaveWallTopRight = 45,
		IceCaveWallBottomLeft = 75,
		IceCaveWallBottomRight = 77,
		IceCaveWallTop = 44,
		IceCaveWallBottom = 76,
		IceCaveWallLeft = 59,
		IceCaveWallRight=61,

		IceCaveRock = 5
	}
	public struct Tile
	{
		//We don't use getters/setters because this is a struct, which encapsulates only data
		public TileType Type;
		public bool Solid;
		public Vector3 Color; //used for lighting purposes

		public enum Orientation
		{
			Up,
			Left,
			Down,
			Right
		}

		static bool[] transparentValues;
		public static void CheckTileTransparency(TextureManager textureManager)
		{
			Texture2D texture = textureManager.GetTexture ("tiles");
			int swidth = World.SpriteSheetWidth / World.TileWidth;
			transparentValues = new bool[swidth * swidth];

			for (int i = 0; i < swidth; i++)
				for (int j = 0; j < swidth; j++) {
					Color[] subdata = new Color[World.TileWidth * World.TileWidth];
					texture.GetData<Color>(0, new Rectangle(i*World.TileWidth,j*World.TileWidth,World.TileWidth,World.TileWidth), subdata, 0, World.TileWidth*World.TileWidth);
					bool anyTransparent = false;

					foreach (Color c in subdata) {
						if (c.A < byte.MaxValue) {
							anyTransparent = true;
							break;
						}
					}
					transparentValues [i + j * swidth] = anyTransparent;
				}
		}


		public bool IsTransparent { get { return transparentValues [(int)Type]; } }

		Orientation TileOrientation;

		public float Rotation {
			get { 
				switch (this.TileOrientation) {
				case Orientation.Up:
					return 0 * (float)Math.PI / 2;
				case Orientation.Left:
					return 1 * (float)Math.PI / 2;
				case Orientation.Down:
					return 2 * (float)Math.PI / 2;
				case Orientation.Right:
					return 3 * (float)Math.PI / 2;
				}
				return 0;
			}
		}

		public Tile (TileType type, bool solid, Vector3 color, Orientation orientation = Orientation.Up)
		{
			Type = type;
			Solid = solid;
			Color = color;
			TileOrientation = orientation;
		}
	}
}

