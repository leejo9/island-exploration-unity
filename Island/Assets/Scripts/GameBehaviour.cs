using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    public string LabelText = "Collect all the treasure chests to win!";
    public int maxItems = 7;
    private int itemsCollected = 0;

    public int Items
    {
        get { return itemsCollected; }
        set { itemsCollected = value;
            if (itemsCollected >= maxItems)
            {
                LabelText = "You found all the items!";
            }
            else
            {
                LabelText = "Item found, only " + (maxItems - itemsCollected) + " more to go!";
            }
        }
    }
    public void OnGUI()
    {
        GUI.Box(new Rect(20, 90, 150, 25), "Items Collected " + itemsCollected);
        GUI.Box(new Rect(20, 50, 250, 25), LabelText);
    }
}
