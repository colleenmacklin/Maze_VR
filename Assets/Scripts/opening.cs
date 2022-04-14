using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opening : MonoBehaviour
{

    string sceneName;

    // Start is called before the first frame update
    public void LoadScene(string sceneName)
    {
        print("scene Name: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }


}
