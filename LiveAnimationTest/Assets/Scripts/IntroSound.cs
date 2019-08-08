using UnityEngine;

public class IntroSound : StateMachineBehaviour {

    public AudioClip Intro;

    void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        AudioSource.PlayClipAtPoint(Intro, animator.transform.position, 1);
    }
}
