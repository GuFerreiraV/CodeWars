
/// <summary>
/// Write a script that will check to see if the player has achieved at least 100 points in his class. 
/// If so, he enters the qualifying stage.
/// In that case, we return,
/// "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.".
/// </summary>

using System;
public class OnlineRPG{
  public static Object PlayerRankUp(int points)
  {
    return points >= 100 ? 
    "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up." 
    : 
    (object)false;
  }
}