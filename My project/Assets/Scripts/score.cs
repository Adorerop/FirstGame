using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;


    //Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        scoreText.text = player.position.z.ToString("0");
    }
}
