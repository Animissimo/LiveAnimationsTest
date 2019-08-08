using UnityEngine;

public class OutroSound : StateMachineBehaviour
{
    public AudioClip outro;

    void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioSource.PlayClipAtPoint(outro, animator.transform.position, 1);
    }
}
