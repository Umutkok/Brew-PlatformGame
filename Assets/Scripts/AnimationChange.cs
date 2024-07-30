using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    public Animator animator;
    public AnimationClip baloncukdusmeanim;
    public AnimationClip baloculzýplamaanim;
    public AnimationClip baloncukidleanim;
    public AnimationClip baloncukkosmaanim;
    public AnimationClip baloncukolmeanim;

    private AnimatorOverrideController overrideController;

    void Start()
    {
        overrideController = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = overrideController;


        overrideController["Player_Fall"] = baloncukdusmeanim;
        overrideController["Player_jump"] = baloculzýplamaanim;
        overrideController["idle_animation"] = baloncukidleanim;
        overrideController["character_animation_deneme"] = baloncukkosmaanim;
        overrideController["Dead_anim"] = baloncukolmeanim;
    }
}
