using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }
}
