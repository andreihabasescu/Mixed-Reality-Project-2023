using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator = null;
    private bool grabbing = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            if (animator != null)
            {
                if (grabbing == false)
                {
                    animator.SetBool("grabbing", true);
                    grabbing = true;
                }
                else
                {
                    animator.SetBool("grabbing", false);
                    grabbing = false;
                }
            }
        }
    }
}