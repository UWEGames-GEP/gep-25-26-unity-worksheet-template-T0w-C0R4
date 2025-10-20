using TMPro;
using UnityEngine;

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

    public void changeText(int inventory_slot)
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = inventory.GetItem(inventory_slot);
    }
}