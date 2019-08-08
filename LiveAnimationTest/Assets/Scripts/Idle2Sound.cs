using UnityEngine;

public class Idle2Sound : StateMachineBehaviour
{
    public AudioClip idle2;

    void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioSource.PlayClipAtPoint(idle2, animator.transform.position, 1);
    }
}