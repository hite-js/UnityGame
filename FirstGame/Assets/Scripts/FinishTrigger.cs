using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public GameManager gm;

    private void OnTriggerEnter() {
        gm.CompleteLevel();
    }
}
