using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Notecreater : MonoBehaviour {

    public GameObject Note;

    GameObject note_temp;

    float timer;
    float cool_time;


	void Start () {
        timer = 0;
        cool_time = Random.Range(0.1f,0.9f);
        
	}
	
	
	void Update () {

        timer += Time.deltaTime;
        if(timer>cool_time)
        {
            note_temp = Instantiate(Note) as GameObject;
            if(Random.Range(1,3) == 1)
            note_temp.GetComponent<Image>().color = new Color(1, 0, 0, 1);
            else
                note_temp.GetComponent<Image>().color = new Color(0, 0, 1, 1);
            note_temp.transform.SetParent(transform);
            note_temp.transform.localPosition = new Vector3(-500, 0, 0);

            note_temp.transform.localScale = new Vector3(1, 1, 1);
            timer = 0;

            cool_time = Random.Range(0.1f, 0.9f);
        }
	}
}
