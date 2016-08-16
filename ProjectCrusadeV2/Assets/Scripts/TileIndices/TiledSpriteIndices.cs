﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Holds all of the sprite indices as they appear in Tiled.
/// </summary>
public enum TiledSpriteIndices
{
	//These are the tile's sprite indexes as they appear in Tiled.
	//Over world
	GRASS_TILE = 1,
	TREE_TOP = 2,
	TREE_BOTTOM = 20,
	FLOWER_GRASS = 3,
	CLOSED_TREASURE_CHEST = 4,
	OPENED_TREASURE_CHEST = 22,
	ROCK = 5,
	WALKING_AREA_TOP_LEFT = 38,
	WALKING_AREA_TOP = 39,
	WALKING_AREA_TOP_RIGHT = 40,
	WALKING_AREA_LEFT = 56,
	WALKING_AREA_CENTER = 57,
	WALKING_AREA_RIGHT = 58,
	WALKING_AREA_BOTTOM_LEFT = 74,
	WALKING_AREA_BOTTOM = 75,
	WALKING_AREA_BOTTOM_RIGHT = 76,
	STREET_LAMP_TOP = 37,
	STREET_LAMP_BOTTOM = 55,
	HOUSE_ROOF1_TOP_LEFT = 110,
	HOUSE_ROOF1_TOP = 111,
	HOUSE_ROOF1_TOP_RIGHT = 112,
	HOUSE_ROOF1_BOTTOM_LEFT = 128,
	HOUSE_ROOF1_BOTTOM = 129,
	HOUSE_ROOF1_BOTTOM_RIGHT = 130,
	HOUSE_ROOF2_TOP_LEFT = 164,
	HOUSE_ROOF2_TOP = 165,
	HOUSE_ROOF2_TOP_RIGHT = 166,
	HOUSE_ROOF2_BOTTOM_LEFT = 182,
	HOUSE_ROOF2_BOTTOM = 183,
	HOUSE_ROOF2_BOTTOM_RIGHT = 184,
	HOUSE_WALL = 93,
	HOUSE_LEFT1 = 146,
	HOUSE_CENTER1 = 147,
	HOUSE_RIGHT1 = 148,
	HOUSE_LEFT2 = 200,
	HOUSE_CENTER2 = 201,
	HOUSE_RIGHT2 = 202,
	HOUSE_WINDOW = 94,
	RED_DOOR_LEFT = 218,
	RED_DOOR_RIGHT = 219,
	BLUE_DOOR_LEFT = 236,
	BLUE_DOOR_RIGHT = 237,
	RED_CARPET_TOP_LEFT = 152,
	RED_CARPET_TOP = 153,
	RED_CARPET_TOP_RIGHT = 154,
	RED_CARPET_LEFT = 170,
	RED_CARPET_CENTER = 171,
	RED_CARPET_RIGHT = 172,
	RED_CARPET_BOTTOM_LEFT = 188,
	RED_CARPET_BOTTOM = 189,
	RED_CARPET_BOTTOM_RIGHT = 190,
	BLUE_CARPET_TOP_LEFT = 155,
	BLUE_CARPET_TOP = 156,
	BLUE_CARPET_TOP_RIGHT = 157,
	BLUE_CARPET_LEFT = 173,
	BLUE_CARPET_CENTER = 174,
	BLUE_CARPET_RIGHT = 175,
	BLUE_CARPET_BOTTOM_LEFT = 191,
	BLUE_CARPET_BOTTOM = 192,
	BLUE_CARPET_BOTTOM_RIGHT = 193,
	WOOD_FLOOR = 92,

	//Cave area
	TENT1_TOP_LEFT = 95,
	TENT1_TOP = 96,
	TENT1_TOP_RIGHT = 97,
	TENT1_LEFT = 113,
	TENT1_CENTER = 114,
	TENT1_RIGHT = 115,
	TENT2_TOP_LEFT = 98,
	TENT2_TOP = 99,
	TENT2_TOP_RIGHT = 100,
	TENT2_LEFT = 116,
	TENT2_CENTER = 117,
	TENT2_RIGHT = 118,


	CAVE_FLOOR = 23,
	CAVE_BOTTOM_RIGHT = 6,
	CAVE_BOTTOM_LEFT = 7,
	CAVE_TOP_LEFT = 24,
	CAVE_TOP_RIGHT = 25,
	CAVE_WALL_TOP_LEFT = 41,
	CAVE_WALL_TOP = 42,
	CAVE_WALL_TOP_RIGHT = 43,
	CAVE_WALL_LEFT = 59,
	CAVE_WALL_CENTER = 60,
	CAVE_WALL_RIGHT = 61,
	CAVE_WALL_BOTTOM_LEFT = 77,
	CAVE_WALL_BOTTOM = 78,
	CAVE_WALL_BOTTOM_RIGHT = 79,


	//Ice area
	ICE_FLOOR = 26,
	ICE_BOTTOM_RIGHT = 9,
	ICE_BOTTOM_LEFT = 10,
	ICE_TOP_LEFT = 27,
	ICE_TOP_RIGHT = 28,
	ICE_WALL_TOP_LEFT = 44,
	ICE_WALL_TOP = 45,
	ICE_WALL_TOP_RIGHT = 46,
	ICE_WALL_LEFT = 62,
	ICE_WALL_CENTER = 63,
	ICE_WALL_RIGHT = 64,
	ICE_WALL_BOTTOM_LEFT = 80,
	ICE_WALL_BOTTOM = 81,
	ICE_WALL_BOTTOM_RIGHT = 82,


	//Sand area
	SAND_FLOOR = 29,
	SAND_BOTTOM_RIGHT = 12,
	SAND_BOTTOM_LEFT = 13,
	SAND_TOP_LEFT = 30,
	SAND_TOP_RIGHT = 31,
	SAND_WALL_TOP_LEFT = 47,
	SAND_WALL_TOP = 48,
	SAND_WALL_TOP_RIGHT = 49,
	SAND_WALL_LEFT = 65,
	SAND_WALL_CENTER = 66,
	SAND_WALL_RIGHT = 67,
	SAND_WALL_BOTTOM_LEFT = 83,
	SAND_WALL_BOTTOM = 84,
	SAND_WALL_BOTTOM_RIGHT = 85,


	//Green area
	GREEN_FLOOR = 32,
	GREEN_BOTTOM_RIGHT = 15,
	GREEN_BOTTOM_LEFT = 16,
	GREEN_TOP_LEFT = 33,
	GREEN_TOP_RIGHT = 34,
	GREEN_WALL_TOP_LEFT = 50,
	GREEN_WALL_TOP = 51,
	GREEN_WALL_TOP_RIGHT = 52,
	GREEN_WALL_LEFT = 68,
	GREEN_WALL_CENTER = 69,
	GREEN_WALL_RIGHT = 70,
	GREEN_WALL_BOTTOM_LEFT = 85,
	GREEN_WALL_BOTTOM = 87,
	GREEN_WALL_BOTTOM_RIGHT = 88,


	//Stone building
	STONE_LEFT = 221,
	STONE_CENTER = 222,
	STONE_RIGHT = 223,
	STONE_CORNER_TOP_LEFT = 203,
	STONE_TOP = 204,
	STONE_CORNER_TOP_RIGHT = 205,
	STONE_CORNER_BOTTOM_LEFT = 239,
	STONE_BOTTOM = 240,
	STONE_CORNER_BOTTOM_RIGHT = 241,

	STONE_TOP_LEFT = 257,
	STONE_TOP_RIGHT = 258,
	STONE_BOTTOM_LEFT = 275,
	STONE_BOTTOM_RIGHT = 276,
	STONE_WALL_CENTER = 186,


	//Other
	BOUNDARY_TILE = 19,









}
