using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
   public void changeScene(string scene)
    {
        Application.LoadLevel(scene);
    }
}
