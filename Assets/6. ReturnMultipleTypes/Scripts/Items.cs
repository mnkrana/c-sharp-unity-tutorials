using UnityEngine;

namespace Tutorial.ReturnMultipleTypes
{
    public class Items : MonoBehaviour
    {
        public struct PlayerData
        {
            public string name;
            public int age;
            public bool isAlive;
        }

        [SerializeField] private string playerName;
        [SerializeField] private int age;
        [SerializeField] private bool isAlive;

        public (string name, int age) GetPlayerData()
        {
            return (playerName, age);
        }

        public PlayerData GetData()
        {
            var data = new PlayerData
            {
                name = playerName,
                age = this.age,
                isAlive = this.isAlive,
            };
            return data;
        }
    }
}