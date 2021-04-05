using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    public PlayerMove pv;
   

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            pv.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
