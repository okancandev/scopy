using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("")]
public class GameObjectScope : MonoBehaviour
{
    private void OnDestroy()
    {
        if(Scopy.Quiting)
            return;
        
        Scopy.RemoveGameObjectScope(gameObject);
    }
}