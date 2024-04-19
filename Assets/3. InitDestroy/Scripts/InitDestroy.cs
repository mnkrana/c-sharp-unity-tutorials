using System.Collections.Generic;
using UnityEngine;

namespace Tutorial.InitDestroy
{
    public class InitDestroy : MonoBehaviour
    {
        
        [SerializeField] private GameObject cubePrefab;
        private List<GameObject> cubes;


        public void Init()
        {
            if(cubes == null)
            {
                cubes = new List<GameObject>();
            }

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            
            var pos = cube.transform.position;
            pos.x += cubes.Count * 2.0f;
            cube.transform.position = pos;

            cubes.Add(cube);
        }

        public void InitPrefab()
        {
            if(cubes == null)
            {
                cubes = new List<GameObject>();
            }

            GameObject cube = Instantiate(cubePrefab);
                    
            var pos = cube.transform.position;
            pos.x += cubes.Count * 2.0f;
            cube.transform.position = pos;
            
            cubes.Add(cube);
        }

        public void Destroy()
        {
            if(cubes.Count > 0)
            {
                var cube = cubes[cubes.Count - 1];
                cubes.Remove(cube);
                Destroy(cube);
            }
            else
            {
                Debug.Log("No object to destroy!");
            }

        }
    }
}
