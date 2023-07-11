using UnityEngine;

public class endtrigger : MonoBehaviour
{
    
    public gamemanager gameManager;

    void OnTriggerEnter () { 
        gameManager.CompleteLevel();
    }

}
