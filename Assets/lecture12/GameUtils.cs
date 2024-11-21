using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace saja
{
    public class GameUtils : MonoBehaviour
    {
        public static string DescribeItem<T>(T something)
        {
            return "This item is " + something.ToString();
        }
    }
}