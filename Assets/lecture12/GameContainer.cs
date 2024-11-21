using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace saja
{
    public class GameContainer<T> : MonoBehaviour
    {
        private T item;
        public void SetItem(T item)
        {
            this.item = item;
        }
        public T GetItem()
        {
            return this.item;
        }
    }
}
