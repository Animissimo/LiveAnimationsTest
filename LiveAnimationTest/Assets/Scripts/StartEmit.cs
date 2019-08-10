using UnityEngine;

public class StartEmit : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EffectController.StartEmit();
    }
}
