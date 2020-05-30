 using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Borderscript : MonoBehaviour {
    public GameObject castle;
    GameObject on_Bordernote;
    public GameObject score_label;

    int score = 0;

    void Start()
    {
        on_Bordernote = null;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name=="note(Clone)" && on_Bordernote==null)
        {
        
            on_Bordernote = other.gameObject;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.name=="note(Clone)"&& on_Bordernote!=null)
        {
            castle.GetComponent<Castle>().hit(1);
            on_Bordernote = null;

        }
    }
	public void hit(int color)
    {
        if (on_Bordernote != null)
        {
           
            if (color == 1)    /*빨간색*/
            {
                if (on_Bordernote.GetComponent<Image>().color == new Color(1, 0, 0, 1))
                {
                    iTween.MoveTo(on_Bordernote, iTween.Hash("y", 120, "time", 0.25f, "easetype", "easeInQuad", "islocal", true, "oncomplete", "killme", "oncompletetarget", on_Bordernote));
                    iTween.ValueTo(on_Bordernote, iTween.Hash("from", 1, "to", 0, "time", 0.25f, "onupdate", "setAlpha", "onupdatetarget", on_Bordernote));
                    on_Bordernote.GetComponent<Note>().note_speed = 0;
                    castle.GetComponent<Castle>().Spawn(1);
                    score += 100;
                    score_label.GetComponent<Text>().text = score.ToString();
                }
                else
                {
                    castle.GetComponent<Castle>().hit(1);
                }
            }
            else          /*파란색*/
            {
                if (on_Bordernote.GetComponent<Image>().color == new Color(0, 0, 1, 1))
                {
                    iTween.MoveTo(on_Bordernote, iTween.Hash("y", 120, "time", 0.25f, "easetype", "easeInQuad", "islocal", true, "oncomplete", "killme", "oncompletetarget", on_Bordernote));
                    iTween.ValueTo(on_Bordernote, iTween.Hash("from", 1, "to", 0, "time", 0.25f, "onupdate", "setAlpha", "onupdatetarget", on_Bordernote));
                    on_Bordernote.GetComponent<Note>().note_speed = 0;
                    castle.GetComponent<Castle>().Spawn(1);
                    score += 100;
                    score_label.GetComponent<Text>().text = score.ToString();
                }
                else
                {
                    castle.GetComponent<Castle>().hit(1);
                }

            }
            on_Bordernote=null;
        }
        else
        {

            castle.GetComponent<Castle>().hit(1);
        }
    }
    public void scoredown(int score_)
    {
        score -= score_;
        if (score < 0)
        {
            score = 0;
        }
        score_label.GetComponent<Text>().text = score.ToString();
    }
}