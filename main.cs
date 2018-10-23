using System;
					
public class Program
{
	public static void Main()
	{
		//read no. of players
		WhoFirst() //1. Determine the player who plays first (F) //randomize the tiles for the players, who get the one closer to A starts first. 

		Draw()		//2. All players draw 7 tiles				  //randomize seven tiles which sum up to 30
		Draw()
		Draw()
			
		PlacingTiles()			//3. F forms a word and place it at the center (star＊)
		ifNewWord()	
		ifWordValid()			//4. The score is calculated if the word is valid; F draws # of tiles played to have 7 in hand
		AddScore()
		ifEndTurn()			//5. Play passes to the left

					//6. Forming new words; Refer to Step 3&4 of [1]

				//6a. Words have to be new

					//6b. Blank tiles are not blank when they are on the board

					//7. Each player can pass, exchange some/all of the letters, form words (as in 6 above) and challenge (omitted here) at the beginning of his/her turn.

		ifEndGame()			//8. Play ends when all tiles have been drawn & one of the players used all of the letters

		Score()			//9. Scoring  (How to score Scrabble plays on thesprucecrafts)
		
					//9a. Initial Score (IS) is calculated after each turn with IS=∑l∈WScore(l)LetterSquare(l).

					//9b. Final Score is a multiple (2x/3x) of IS - if any letters are placed on word squares

					//9c. Multipliers are to be used once

					//9d. and so on
	}
}
