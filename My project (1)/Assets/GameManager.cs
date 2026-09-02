using TMPro;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] TextMeshProUGUI Cookietext;

    [SerializeField] int cookies;

    // int cookies
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