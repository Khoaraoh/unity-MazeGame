using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject Panel_Win;
    private void OnTriggerEnter(Collider other)
    {
        print("You Win");
        Panel_Win.SetActive(true);
        Time.timeScale = 0;
    }
}
    