using TMPro
using UnityEngine;
public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] TextMeshProUGUI Cookietext;

    [SerializeField] int cookies;
}
// int cookies
public void ClickedCookie()
{
    int cookies = 0;
    cookies = cookies + 1;
    cookieText. text = cookies


}