using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Note : MonoBehaviour {
    public float note_speed;
    float timer;
	void Start () {
        timer = 0;
	}
	
	
	void Update () {
       
        transform.localPosition += new Vector3(note_speed * Time.deltaTime, 0, 0);
       
	}
    void OnTriggerEnter2D(Collider2D other){
        if (other.name == "Image Deadline")
        {
            Destroy(gameObject);

        }
    }
    void killme()
    {
        Destroy(gameObject);
    }
    void setAlpha(float _A){
        gameObject.GetComponent<Image>().color = new Color(gameObject.GetComponent<Image>().color.r, gameObject.GetComponent<Image>().color.g, gameObject.GetComponent<Image>().color.b, _A);
   }
}
