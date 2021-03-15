using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedShooting : StateMachineBehaviour
{
    public GameObject bullet;
    public Transform shottingOffset;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");
        Destroy(shot, 3f);
    }
}
