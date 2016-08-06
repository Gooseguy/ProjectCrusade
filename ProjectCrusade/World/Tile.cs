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


		IceCaveFloor = 24,
		IceCaveFloorBottomRight = 9,
		IceCaveFloorBottomLeft = 10,
		IceCaveFloorTopLeft=25,
		IceCaveFloorTopRight=26,

		IceCaveWall=57,
		IceCaveWallTopLeft=40,
		IceCaveWallTopRight = 42,
		IceCaveWallBottomLeft = 72,
		IceCaveWallBottomRight = 74,
		IceCaveWallTop = 41,
		IceCaveWallBottom = 73,
		IceCaveWallLeft = 56,
		IceCaveWallRight=58,

		IceCaveRock = 5,


		SandCaveFloor = 27,
		SandCaveFloorBottomRight = 12,
		SandCaveFloorBottomLeft = 13,
		SandCaveFloorTopLeft=28,
		SandCaveFloorTopRight=29,

		SandCaveWall=60,
		SandCaveWallTopLeft=43,
		SandCaveWallTopRight = 45,
		SandCaveWallBottomLeft = 75,
		SandCaveWallBottomRight = 77,
		SandCaveWallTop = 44,
		SandCaveWallBottom = 76,
		SandCaveWallLeft = 59,
		SandCaveWallRight=61,

		SandCaveRock = 5,

		GreenCaveFloor = 203,
		GreenCaveFloorBottomRight = 188,
		GreenCaveFloorBottomLeft = 189,
		GreenCaveFloorTopLeft = 204,
		GreenCaveFloorTopRight = 205,

		GreenCaveWall = 236,
		GreenCaveWallTopLeft = 219,
		GreenCaveWallTopRight = 221,
		GreenCaveWallBottomLeft = 251,
		GreenCaveWallBottomRight = 253,
		GreenCaveWallTop = 220,
		GreenCaveWallBottom = 252,
		GreenCaveWallLeft = 235,
		GreenCaveWallRight = 237,

		GreenCaveRock = 5
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

