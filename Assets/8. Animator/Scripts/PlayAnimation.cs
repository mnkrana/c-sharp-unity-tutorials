using UnityEngine;

namespace Tutorial.AnimatorTut
{
    public sealed class PlayAnimation : MonoBehaviour
    {
       [SerializeField] private Animator animator;

       void Update()
       {
            if(Input.GetKeyDown(KeyCode.A))
            {
                // animator.SetTrigger("rotate");
                animator.SetFloat("Blend", 0.0f);
            }
            else if(Input.GetKeyDown(KeyCode.B))
            {
                // animator.SetTrigger("scale");
                animator.SetFloat("Blend", 1.0f);
            }
            else if(Input.GetKeyDown(KeyCode.C))
            {            
                animator.SetFloat("Blend", 0.25f);
            }
       }
    }
}