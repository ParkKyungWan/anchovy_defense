using UnityEngine;
using System.Collections;

public class Slime : MonoBehaviour {

    float x_speed;

    void Start()
    {

        x_speed = -80;

    }
    void Update () 
    {
        

        transform.localPosition += new Vector3(x_speed *Time.deltaTime, 0, 0); 
        
	}
    void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.name == "Image enemy castle")
        {
            iTween.MoveTo(gameObject, iTween.Hash("x", transform.localPosition.x -10, "y", transform.localPosition.y + 80, "time", 1.0f, "islocal", true, "easetype", iTween.EaseType.easeInBounce));
            _other.GetComponent<enemyspawn>().hit(5);
            Destroy(gameObject, 1.0f);
        }
        else if (_other.name == "Image enemy enchovy(Clone)")
        {
            iTween.MoveTo(gameObject, iTween.Hash("x", transform.localPosition.x + 200, "y", transform.localPosition.y + 80, "time", 1.0f, "islocal", true, "easetype", iTween.EaseType.easeOutQuad));
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 1.0f);      
        }
    }
}
