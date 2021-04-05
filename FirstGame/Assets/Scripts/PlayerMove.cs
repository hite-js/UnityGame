using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float playerSpeed;
    public float playerSideways;
    public Transform player;
    public ScoreScript score;
    GameManager gm;

    private void Start() {
        gm = FindObjectOfType<GameManager>();
    }

    void FixedUpdate(){
        rb.AddForce(0,0,playerSpeed * Time.fixedDeltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(playerSideways * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            rb.AddForce(-playerSideways * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1) {
            gm.EndGame();
        }
    }

}
