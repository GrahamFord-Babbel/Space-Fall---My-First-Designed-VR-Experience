using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    float time;
    public Animator anim;
    public string animationName1;
    public Animation anim2;
    public GameObject cameraz;
    public Animator animator;
    //[Tooltip ("The name of the Animator trigger parameter")]
    public string triggerName;
    public float startAnimationTime = 15f;
    public float endAnimationTime =16.5f;

    public void Update()
    {
        time += Time.deltaTime;

        // If the player pressed the cardboard button (or touched the screen), set the trigger parameter to active (until it has been used in a transition)
        if (time > startAnimationTime)
        {
            GetComponent<Animator>().enabled= true;
            animator.SetTrigger(triggerName);
        }
        if (time > endAnimationTime)
        {
            GetComponent<Animator>().enabled = false;
            animator.SetTrigger(triggerName);
        }
    }

    public void JumpTime()
    {
        anim.SetTrigger(animationName1);
        print("clip played");
    }

    public void JumpTime2()
    {
        anim2 = GameObject.Find("CameraObject").GetComponent<Animation>();
        anim2.Play("CameraJump");
        print("clip 2 played");
    }
    public void JumpTime3()
    {
        //cameraz.GetComponent<Animator>();

        //camerai.SetActive(true);
    }
}
