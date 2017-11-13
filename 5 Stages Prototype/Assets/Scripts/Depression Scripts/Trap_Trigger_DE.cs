using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Trigger_DE : MonoBehaviour {

    Player_Controller_DE Player;

    public int Trap_Layers;

    private void OnTriggerEnter(Collider other)
    {
 
        if (other.gameObject.name == "Player_Character_DE")
        {
            Player = other.gameObject.GetComponent<Player_Controller_DE>();

            Player.Get_Trapped(Trap_Layers); // change to Main_DE function when implemented
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player_Character_DE")
        {
            Player = other.gameObject.GetComponent<Player_Controller_DE>();

            Player.Get_Free();            // change to Main_DE function when implemented

        }
    }
}
