using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int estaCaminandoHash;
    int estaRetrocediendoHash;
    void Start()
    {

        animator = GetComponent<Animator>();
        estaCaminandoHash = Animator.StringToHash("EstaCaminando");
        estaRetrocediendoHash = Animator.StringToHash("EstaRetrocediendo");

    }


    void Update()
    {
        bool EstaCaminando = animator.GetBool(estaCaminandoHash);
        bool forewardPressed = Input.GetKey("w");

        bool EstaRetrocediendo = animator.GetBool(estaRetrocediendoHash);
        bool backwardsPressed = Input.GetKey("s");

        if (!EstaCaminando && forewardPressed)
        {
            animator.SetBool(estaCaminandoHash, true);
        }

        if (EstaCaminando && !forewardPressed)

        {
            animator.SetBool(estaCaminandoHash, false);
        }

        if (!EstaRetrocediendo && backwardsPressed)
        {
            animator.SetBool(estaRetrocediendoHash, true);
        }

        if (EstaRetrocediendo && !backwardsPressed)

        {
            animator.SetBool(estaRetrocediendoHash, false);
        }
    }
}
