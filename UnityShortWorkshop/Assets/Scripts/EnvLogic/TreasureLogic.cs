using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreasureLogic : MonoBehaviour
{
     
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMovementController>())
            SceneManager.LoadScene("Win");
    }
}
