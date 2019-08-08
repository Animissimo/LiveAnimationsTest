using UnityEngine;

public class Run_bSound : StateMachineBehaviour
{
	public AudioClip run;

	void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		AudioSource.PlayClipAtPoint(run, animator.transform.position, 1);
	}
}
