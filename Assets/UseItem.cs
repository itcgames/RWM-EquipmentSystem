using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    public GameObject Item;
    public int amount;
    public string itemName;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnEnable()
    {
        Item.GetComponent<setupItem>().changeAmount(1);
    }
    // Update is called once per frame
    void Update()
    {
        amount = Item.GetComponent<setupItem>().getAmount();
        Item.GetComponentInChildren<Text>().GetComponentInChildren<Text>().text = itemName +" x " + amount.ToString();
    }

   
}
