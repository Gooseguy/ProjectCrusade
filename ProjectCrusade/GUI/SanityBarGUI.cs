﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectCrusade
{
	//<summary> This class represents the GUI that displays the player's sanity. </summary>
	public class SanityBarGUI
	{
		Vector2 position;
		float sanity;
		float maxSanity;
		const int Height = 20;
		const int Width = 200;
		Color barColor = new Color ();

		public SanityBarGUI (float sanityAmount) {
			sanity = sanityAmount;
			position = new Vector2 (MainGame.WindowWidth / 2 - Width/2, MainGame.WindowHeight - 35);
		}

		public void Update(GameTime time, float sanityAmount, float maxSanity) {
			sanity = sanityAmount;
			this.maxSanity = maxSanity;
			float fracSanity = sanityAmount / maxSanity;
			float interpRed = MathHelper.Clamp (1 - 2 * fracSanity, 0, 1);
			float interpYellow = 2 * (fracSanity < 0.5f ? (fracSanity) : (1 - fracSanity));
			float interpGreen = MathHelper.Clamp (2 * fracSanity - 1, 0, 1);
			barColor = new Color (Color.Red.ToVector3 () * interpRed + Color.Yellow.ToVector3 () * interpYellow + new Vector3(0,1.0f,0) * interpGreen);
//
//			if (sanity <= maxSanity && sanity > 60) {
//				barColor = new Color(0,255,0);
//			} else if (sanity <= 60 && sanity > 30) {
//				barColor = Color.Yellow;
//			} else {
//				barColor = Color.Red;
//			}
		}

		public void Draw(SpriteBatch spriteBatch, TextureManager textureManager, FontManager fontManager) {
			Texture2D rectangleTexture = new Texture2D (MainGame.graphics.GraphicsDevice, (int)(sanity/maxSanity*Width), Height);
			Color[] data = new Color[(int)sanity*2 * Height];

			for (int i = 0; i < data.Length; i++) {
				data [i] = barColor;
			}

			rectangleTexture.SetData(data);

			spriteBatch.Draw (textureManager.WhitePixel, new Rectangle((int)position.X, (int)position.Y, (int)sanity*2, Height), barColor);

			string barName = "Sanity: ";
			spriteBatch.DrawString (fontManager.GetFont ("Arial"), barName, new Vector2(position.X - 55, position.Y), Color.White);
		}

	} //END OF SANITYBARGUI CLASS



} //END OF NAMESPACE

