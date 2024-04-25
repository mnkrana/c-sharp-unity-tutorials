using UnityEngine;
using UnityEngine.UI;

namespace Tutorial.ReturnMultipleTypes
{
    public class Manager : MonoBehaviour
    {
        [SerializeField] private Text text;
        private Items items;

        void Start()
        {
            items = GetComponent<Items>();
        }

        public void OnGet()
        {
            var playerData = items.GetPlayerData();
            text.text = $"{playerData.name} \n{playerData.age}";
        }


        public void OnGetData()
        {
            var playerData = items.GetData();
            text.text = $"{playerData.name} \n{playerData.age} \n{playerData.isAlive}";
        }
    }
}