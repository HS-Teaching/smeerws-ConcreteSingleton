/* concrete singelton
 * this inherits from the GenericSingleton (a singleton without copying code),   
 * the GenericSingleton fixes the persistency problem and allows lazy instantiation.  
 */
using UnityEngine;

public class ConcreteSingleton : GenericSingletonClass<ConcreteSingleton> {
   
    private string yourName = "";

    public string Name
    {
        get
        {
            Debug.Log("get name " + yourName);
            return yourName;
        }

        set
        {
            Debug.Log("set name " + yourName);
            yourName = value;
        }
    }
}
