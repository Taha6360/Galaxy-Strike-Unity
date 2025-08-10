using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSceneManagement : MonoBehaviour
{
   public void reloadLevel()
    {
        StartCoroutine(ReloadLevelCoroutine());
    }

     IEnumerator ReloadLevelCoroutine()
    {
        yield return new WaitForSeconds(1f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);


    }
}
