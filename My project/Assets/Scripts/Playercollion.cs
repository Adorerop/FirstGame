using UnityEngine;

public class Playercollion : MonoBehaviour
{
    public movementscript movment;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movment.enabled = false;
            FindObjectOfType<gamemanager>().EndGame();
        }
    }

}
