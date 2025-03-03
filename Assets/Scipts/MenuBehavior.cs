using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour
{
    public void GoToGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GamePlay");
    }    
}
