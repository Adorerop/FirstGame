using UnityEngine;
using UnityEngine.SceneManagement;


public class gamemanager : MonoBehaviour
{

    bool gameHaseEnded = false;
    public float restartdelay = 0f;
    public GameObject completeLevelUI;

    public void CompleteLevel ()
    { 
        completeLevelUI.SetActive(true); 
    }
    
    public void EndGame ()
    {
        if (gameHaseEnded == false)
        {
            gameHaseEnded = true;
            Debug.Log("AHHHHH");
            Invoke("Restart",restartdelay);
        
        }
        
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
