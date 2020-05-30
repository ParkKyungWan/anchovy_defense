using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour
{


    void Start()
    {
        iTween.MoveTo(gameObject,iTween.Hash("y",100,"time",2,"easetype",iTween.EaseType.easeOutBounce,"islocal",true));
    }


}
