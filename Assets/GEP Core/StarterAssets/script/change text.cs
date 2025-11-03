using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class changetext : MonoBehaviour
{
    public TextMeshPro TMP;
    public Inventory inventory;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeText(string inventory_string)
    {
        
        gameObject.GetComponent<TextMeshProUGUI>().text = inventory_string;
    }
}