using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class enemyspawn : MonoBehaviour {
    public GameObject background;
    public GameObject monsterrr;
    public GameObject hpbar;
    GameObject monsterrr_temp;
    float timer;
    float cool_time;
    
    int hp=100;

    void Start()
    {   
        timer = 0;
        cool_time = Random.Range(0.3f,1.1f);
    }
	void Update()
    {
        timer+=Time.deltaTime;
        if(timer>cool_time){
            monsterrr_temp = Instantiate(monsterrr) as GameObject;
            monsterrr_temp.transform.SetParent(background.transform);
            monsterrr_temp.transform.localScale = new Vector3(1, 1, 1);
            monsterrr_temp.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
            timer = 0;
            cool_time = Random.Range(0.3f, 1.1f);
        }
    }


    public void hit(int power)
    {
        hp -= power;
        hpbar.GetComponent<Image>().fillAmount = hp / 100.0f;
        if (hp <= 0)
        {
            Debug.Log("win");

        }
    }
}
