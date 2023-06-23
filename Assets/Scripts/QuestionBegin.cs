using UnityEngine;

public class QuestionBegin : MonoBehaviour
{
    public GameObject questions;
    public GameObject mainscene;
    public GameObject nighttime;

    public void questionsbegin()
    {
        questions.SetActive(true);
        nighttime.SetActive(false);
        mainscene.SetActive(false);
    }

    public void questionsend()
    {
        questions.SetActive(false);
        nighttime.SetActive(true);
        mainscene.SetActive(true);
    }
}
