using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public List<Player> players = new List<Player>();
    
    private void Awake()
    {
        instance = this;
    }

    internal void AssignTurn(int currentPlayerTurn)
    {
        foreach(Player player in players)
        {
            /*if(player.ID == currentPlayerTurn)
            {
                player.myTurn = true;
            }
            else
            {
                player.myTurn = false;
            }*/
            player.myTurn = player.ID == currentPlayerTurn;

        }
        //PlayerManager player = players.Find(x => x.ID == currentPlayerTurn);
        //player.myTurn = true;
    }   

}
