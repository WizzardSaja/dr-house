using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace saja
{
    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> example = new GameContainer<string>();

            
            example.SetItem("Healing Potion");

            
            string storedItem = example.GetItem();
            Debug.Log("Stored item: " + storedItem);

            // وصف العنصر باستخدام DescribeItem
            string description = GameUtils.DescribeItem(storedItem);
            Debug.Log(description);
        }


    }
}