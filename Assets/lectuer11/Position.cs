using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Assignment18
{
    public struct Position 
    {
      public  float X;
      public float y;
      public float z;
      public Position(float x, float y, float z){
        this.X = x;
        this.y = y;
        this.z = z;
      }
      public void printPosition(){
        Debug.Log("x="+X+",y= "+y+",z= "+z);
      }
      

    }
}