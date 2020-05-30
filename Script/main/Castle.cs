using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Castle : MonoBehaviour 
{
    public GameObject background;
    public GameObject slime;
    public GameObject hpbar;
    public GameObject border;

    int hp = 100;
   
    public void Spawn(int _number)
    {
        switch (_number)
        {
            case 1:

                GameObject slime_temp = Instantiate(slime) as GameObject;
                slime_temp.transform.SetParent(background.transform);
                slime_temp.transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);

                break;
        }

    }
    public void hit(int power)
    {
        hp -= power;
        hpbar.GetComponent<Image>().fillAmount = hp / 100.0f;
        border.GetComponent<Borderscript>().scoredown(power);

        if (hp <= 0)
        {
            Application.LoadLevel("game over");
        }
    }

	
	
}
