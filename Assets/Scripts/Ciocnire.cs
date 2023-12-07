
using UnityEngine;

public class Ciocnire : MonoBehaviour
{
    public Movement move;
    
    void OnCollisionEnter(Collision ciocnireInfo)
    {
        if (ciocnireInfo.collider.tag == "Obstacol")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
       
        }
    }
}
