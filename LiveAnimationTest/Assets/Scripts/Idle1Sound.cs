using UnityEngine;

public class Idle1Sound : StateMachineBehaviour
{
    public AudioClip idle1;

    void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioSource.PlayClipAtPoint(idle1, animator.transform.position, 1);
    }
}
