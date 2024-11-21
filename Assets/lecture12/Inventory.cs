using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace saja
{
    public class Inventory : MonoBehaviour
    {
        private List<string> items = new List<string>();

        // اضافة عنصر
        public void AddItem(string item)
        {
            items.Add(item);
        }

        // عرض العناصر  
        public void ShowItems()
        {
            foreach (var item in items)
            {
                Debug.Log(item);
            }
        }

        // زيادة الـ + operator لدمج  
        public static Inventory operator +(Inventory inventory1, Inventory inventory2)
        {
            Inventory combinedInventory = new Inventory();

            // إضافة عناصر من list الأولى
            foreach (var item in inventory1.items)
            {
                combinedInventory.AddItem(item);
            }

            // إضافة عناصر من list الثانية
            foreach (var item in inventory2.items)
            {
                combinedInventory.AddItem(item);
            }

            return combinedInventory;
        }
    }
}