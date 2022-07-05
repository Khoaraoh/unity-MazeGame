using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public GameObject Panel_Lose;
    private void OnTriggerEnter(Collider other)
    {
        print("You Lose");
        Panel_Lose.SetActive(true);
        Time.timeScale = 0;
    }
}
