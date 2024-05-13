using UnityEngine;

namespace Tutorial.Raycast
{
    public class Clicker : MonoBehaviour
    {
        [SerializeField] float length;
        private Ray ray;

        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                var hitSomething = Physics.Raycast(ray, out var hitInfo);
                if(hitSomething)
                {
                    Debug.Log($"Hit something {hitInfo.collider.gameObject.name}");
                    var hitObject = hitInfo.collider.gameObject;
                    hitObject.transform.position = Vector3.one * 2.0f;
                }
                else
                {
                    Debug.Log("Hit Nothing");
                }
            }
        }

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(Camera.main.transform.position, ray.direction * length);            
        }
    }
}