using TMPro;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] TextMeshProUGUI Cookietext;

    [SerializeField] int cookies;

    [SerializeField] float timer = 0;

    [SerializeField] bool hasGrandma;
    // int cookies

    private void Update()
    {

        if (hasGrandma == true)
        {
            timer = timer + Time.deltaTime;


            // When timer hits 1 it will reset to 0 and give the player a cookie
            if (timer >= 1)
            {
                timer = 0;
                ClickedCookie();
            }
        }
    }
    public void ClickedCookie()
    {

        cookies = cookies + 1;
        int cookie = cookies;
        Cookietext.text = cookies. ToString();


    }



    public void BuyGrandma()
    {



    }

}