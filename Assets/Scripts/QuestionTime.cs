using UnityEngine;
using TMPro;

public class QuestionTime : MonoBehaviour
{
    public TextMeshProUGUI question;

    public bool question1 = true;//are hedgehogs nocturnal
    public bool answer1;
    public bool question2;//are hedgehogs rodents
    public bool answer2;
    public bool question3;//hedgehogs are native to ...
    public bool answer3;
    public bool question4;//hedgehogs are insectivores
    public bool answer4;
    public bool question5;//european hedgehogs give birth to an average 10 babies 
    public bool answer5;
    public bool question6;//baby hedgehogs are called hoglets, or urchins.
    public bool answer6;
    public bool question7;//european hedgehogs can travel about 3-4km (2 miles) a night
    public bool answer7;
    public bool question8;//european hedgehogs can live up to 5 years 
    public bool answer8;
    public bool question9;//european hedgehogs live, on average, for 3 years
    public bool answer9;
    public bool question10;//in denmark and poland, it is illegal to capture or hurt hedgehogs
    public bool answer10;
    public bool question11;//in new zealand, hedgehogs pose a major threat to many native species
    public bool answer11;
    public bool question12;//around half of european hedgehogs dont make it past their first year
    public bool answer12;
    public bool question13;//hedgehogs are born with their spikes
    public bool answer13;
    public bool question14;//mother hedgehogs raise their hoglets alone
    public bool answer14;
    public bool question15;//there are 25 species of hedgehog
    public bool answer15;
    public bool question16;//hedgehogs first evolved 15 million years ago
    public bool answer16;
    public bool question17;//hedgehogs can pause their pregnancies during hibernation
    public bool answer17;

    public GameObject true_button;
    public GameObject false_button;
    public GameObject next_button;

    public GameObject questioncorrect;
    public GameObject questionwrong;

    public GameObject stats;

    void Start()
    {
        question1 = true;
    }

    void Update()
    {
        if (question1 == true)
        {
            question.text = "Question 1: Hedgehogs are Nocturnal.";
        }

        if (answer1 == true)
        {
            question.text = "The answer is True! Hedgehogs are usually active from sunset to sunrise. Hedgehogs who have recently given birth or are pregnant may be seen out during the daytime however.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question2 == true)
        {
            question.text = "Question 2: Hedgehogs are Rodents.";
        }

        if (answer2 == true)
        {
            question.text = "The answer is False! Hedgehogs are part of the mammal order Eulipotyphla, alongside moles and shrews.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question3 == true)
        {
            question.text = "Question 3: Hedgehogs are native to Asia, South America, Europe and Africa.";
        }

        if (answer3 == true)
        {
            question.text = "The answer is False! All living Hedgehogs today are native to Asia, Europe and Africa. An extinct genus of Hedgehogs, Amphechinus, used to live in North America.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question4 == true)
        {
            question.text = "Question 4: Hedgehogs are Insectivores";
        }

        if (answer4 == true)
        {
            question.text = "The answer is True! Their diet consists of mainly invertebrates such as worms and beetles.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question5 == true)
        {
            question.text = "Question 5: On average, Hedgehogs give birth to 10 offspring per litter";
        }

        if (answer5 == true)
        {
            question.text = "The answer is False! On average, Hedgehogs give birth to 5 offspring per litter";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question6 == true)
        {
            question.text = "Question 6: Baby Hedgehogs are called hoglets";
        }

        if (answer6 == true)
        {
            question.text = "The answer is correct! They are also called urchins.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question7 == true)
        {
            question.text = "Question 7: European Hedgehogs can travel about 1km (0.6 miles) per night.";
        }

        if (answer7 == true)
        {
            question.text = "The answer is False! European Hedgehogs travel about 3-4km (1.3-1.8 miles) per night!.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question8 == true)
        {
            question.text = "Question 8: Hedgehogs can live for up to 5 years!";
        }

        if (answer8 == true)
        {
            question.text = "The answer is false! Hedgehogs can live up to 10 years old!";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question9 == true)
        {
            question.text = "Question 9: Hedgehogs live for 3 years on average.";
        }

        if (answer9 == true)
        {
            question.text = "Sadly, the answer is True! Despite the fact they can live for up to 10 years, most hedgehogs only live for 3.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question10 == true)
        {
            question.text = "Question 10: In Denmark, the UK, and Poland, it is illegal to capture or hurt hedgehogs.";
        }

        if (answer10 == true)
        {
            question.text = "The answer is True! However, underweight or sick hedgehogs can be captured and brought to wildlife hospitals.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question11 == true)
        {
            question.text = "Question 11: In New Zealand, hedgehogs are a major threat to many native species";
        }

        if(answer11 == true)
        {
            question.text = "The answer is True! This is because hedgehogs eat the eggs of ground nesting birds.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if(question12 == true)
        {
            question.text = "Question 12: Around half of European Hedgehogs dont make it past their first year";
        }

        if(answer12 == true)
        {
            question.text = "The answer is True! Sadly, due to threats such as cars and habitat loss, many Hedgehogs struggle to survive.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if(question13)
        {
            question.text = "Question 13: Hedgehogs are born with their spikes already on their skin";
        }

        if(answer13)
        {
            question.text = "The answer is False! Hedgehogs are born with their spikes hidden inside their skin, similar to human babies and their teeth.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question14)
        {
            question.text = "Question 14: Hedgehog mothers raise their babies alone.";
        }

        if (answer14)
        {
            question.text = "The answer is True! Hedgehog males leave shortly after mating, and might be unable to recongise their babies.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question15)
        {
            question.text = "Question 15: There are 25 species of Hedgehog.";
        }

        if (answer15)
        {
            question.text = "The answer is False! There are currently only 17 species of Hedgehog.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if (question16)
        {
            question.text = "Question 16: Hedgehogs first evolved 15 million years ago.";
        }

        if (answer16)
        {
            question.text = "The answer is True! They are also one of the oldest species of mammal on the planet.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }

        if(question17)
        {
            question.text = "Question 17: Hedgehogs can pause their pregnancies during hibernation.";
        }    

        if(answer17)
        {
            question.text = "The answer is True! Alongisde 130 other species of mammal, they can pause the development of the embryo until its safe.";
            true_button.SetActive(false);
            false_button.SetActive(false);
            next_button.SetActive(true);
        }
    }

    public void truebutton()
    {
        if(question1)
        {
            question1 = false;
            answer1 = true;
            questioncorrect.SetActive(true);
            stats.GetComponent<Stats>().questioncorrect();
        }

        if (question2)
        {
            questionwrong.SetActive(true);
            stats.GetComponent<Stats>().questionincorrect();
            answer2 = true;
            question2 = false;
        }

        if (question3)
        {
            questionwrong.SetActive(true);
            answer3 = true;
            question3 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question4)
        {
            questioncorrect.SetActive(true);

            stats.GetComponent<Stats>().questioncorrect();
            answer4 = true;
            question4 = false;
        }

        if (question5)
        {
            questionwrong.SetActive(true);
            answer5 = true;
            question5 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question6)
        {
            questioncorrect.SetActive(true);
            stats.GetComponent<Stats>().questioncorrect();
            answer6 = true;
            question6 = false;
        }

        if (question7)
        {
            questionwrong.SetActive(true);
            stats.GetComponent<Stats>().questionincorrect();
            answer7 = true;
            question7 = false;
        }

        if (question8)
        {
            questionwrong.SetActive(true);
            answer8 = true;
            question8 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question9)
        {
            questioncorrect.SetActive(true);
            answer9 = true;
            question9 = false;
            stats.GetComponent<Stats>().questioncorrect();
        }

        if (question10)
        {
            questioncorrect.SetActive(true);
            answer10 = true;
            question10 = false;
            stats.GetComponent<Stats>().questioncorrect();
        }

        if (question11)
        {
            questioncorrect.SetActive(true);
            answer11 = true;
            question11 = false;
            stats.GetComponent<Stats>().questioncorrect();
        }

        if (question12)
        {
            questioncorrect.SetActive(true);
            answer12 = true;
            question12 = false;
            stats.GetComponent<Stats>().questioncorrect();
        }

        if (question13)
        {
            questionwrong.SetActive(true);
            stats.GetComponent<Stats>().questionincorrect();
            answer13 = true;
            question13 = false;
        }

        if (question14)
        {
            questioncorrect.SetActive(true);
            answer14 = true;
            question14 = false;
            stats.GetComponent<Stats>().questioncorrect();
        }

        if (question15)
        {
            questionwrong.SetActive(true);
            stats.GetComponent<Stats>().questionincorrect();
            answer15 = true;
            question15 = false;
        }

        if (question16)
        {
            questioncorrect.SetActive(true);
            answer16 = true;
            question16 = false;
            stats.GetComponent<Stats>().questioncorrect();
        }

        if (question17)
        {
            questioncorrect.SetActive(true);
            answer17 = true;
            question17 = false;
            stats.GetComponent<Stats>().questioncorrect();
        }
    }

    public void falsebutton()
    {
        if (question1)
        {
            questionwrong.SetActive(true);
            stats.GetComponent<Stats>().questionincorrect();
            question1 = false;
            answer1 = true;
        }

        if(question2)
        {
            questioncorrect.SetActive(true);
            stats.GetComponent<Stats>().questioncorrect();
            answer2 = true;
            question2 = false;
        }

        if(question3)
        {
            questioncorrect.SetActive(true);

            stats.GetComponent<Stats>().questioncorrect();
            answer3 = true;
            question3 = false;
        }

        if (question4)
        {
            questionwrong.SetActive(true);
            answer4 = true;
            question4 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question5)
        {
            questioncorrect.SetActive(true);

            stats.GetComponent<Stats>().questioncorrect();
            answer5 = true;
            question5 = false;
        }

        if (question6)
        {
            questionwrong.SetActive(true);
            answer6 = true;
            question6 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question7)
        {
            questioncorrect.SetActive(true);
            stats.GetComponent<Stats>().questioncorrect();
            answer7 = true;
            question7 = false;
        }

        if (question8)
        {
            questioncorrect.SetActive(true);
            stats.GetComponent<Stats>().questioncorrect();
            answer8 = true;
            question8 = false;
        }

        if (question9)
        {
            questionwrong.SetActive(true);
            answer9 = true;
            question9 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question10)
        {
            questionwrong.SetActive(true);
            answer10 = true;
            question10 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question11)
        {
            questionwrong.SetActive(true);
            answer11 = true;
            question11 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question12)
        {
            questionwrong.SetActive(true);
            answer12 = true;
            question12 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question13)
        {
            questioncorrect.SetActive(true);
            stats.GetComponent<Stats>().questioncorrect();
            answer13 = true;
            question13 = false;
        }

        if (question14)
        {
            questionwrong.SetActive(true);
            answer14 = true;
            question14 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question15)
        {
            questioncorrect.SetActive(true);
            stats.GetComponent<Stats>().questioncorrect();
            answer15 = true;
            question15 = false;
        }

        if (question16)
        {
            questionwrong.SetActive(true);
            answer16 = true;
            question16 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }

        if (question17)
        {
            questionwrong.SetActive(true);
            answer17 = true;
            question17 = false;
            stats.GetComponent<Stats>().questionincorrect();
        }
    }

    public void nextbutton()
    {
        if(answer1)
        {
            question2 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer1 = false;
        }

        if (answer2)
        {
            question3 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer2 = false;
        }

        if(answer3)
        {
            question4 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer3 = false;
        }

        if (answer4)
        {
            question5 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer4 = false;
        }

        if (answer5)
        {
            question6 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer5 = false;
        }

        if (answer6)
        {
            question7 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer6 = false;
        }

        if (answer7)
        {
            question8 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer7 = false;
        }

        if (answer8)
        {
            question9 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer8 = false;
        }

        if (answer9)
        {
            question10 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer9 = false;
        }

        if (answer10)
        {
            question11 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer10 = false;
        }

        if (answer11)
        {
            question12 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer11 = false;
        }

        if (answer12)
        {
            question13 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer12 = false;
        }

        if (answer13)
        {
            question14 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer13 = false;
        }

        if (answer14)
        {
            question15 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer14 = false;
        }

        if (answer15)
        {
            question16 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer15 = false;
        }

        if (answer16)
        {
            question17 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer16 = false;
        }

        if (answer17)
        {
            question1 = true;
            true_button.SetActive(true);
            false_button.SetActive(true);
            next_button.SetActive(false);
            questionwrong.SetActive(false);
            questioncorrect.SetActive(false);
            answer17 = false;
        }
    }

}
