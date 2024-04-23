using Tutorial.SingletonTest;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTest : MonoBehaviour
{
    public void LoadMain()
    {
        SceneManager.LoadScene("4. Singleton");
        SingletonTest.Instance.PlayAudio();
    }

    public void LoadTest()
    {
        SceneManager.LoadScene("4. SingletonTestScene");
        SingletonTest.Instance.PlayAudio();
    }
}
