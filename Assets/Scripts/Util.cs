using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//main reason to use namespace
//if you are in a large project, if there is situation where there are two scripts with the same script name
//namespace create programmming folders
namespace MathUtil
{
    public class Util : MonoBehaviour

    {
        public static bool CanSeeObj(GameObject destination, GameObject origin, float range)
        {
            Vector3 dir = Vector3.Normalize(destination.transform.position - origin.transform.position);
            float angleDist = Vector3.Dot(origin.transform.forward, dir);

            Debug.DrawRay(origin.transform.position, origin.transform.forward * 10, Color.red);
            Debug.DrawRay(origin.transform.position, dir * 10, Color.green);


            if (angleDist > range)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Vector3 ObjSide(GameObject destination, GameObject origin)
        {
            Vector3 dir = Vector3.Normalize(destination.transform.position - origin.transform.position);
            Vector3 crossProd = Vector3.Cross(origin.transform.forward, dir);
            Debug.Log(crossProd);

            if(crossProd.y > 0)
            {
                Debug.Log(destination.name + " if left of " + origin.name);
            }
            else
            {
                Debug.Log(destination.name + " is right of " + origin.name);
            }

            return crossProd;
          
        }

    }
}


