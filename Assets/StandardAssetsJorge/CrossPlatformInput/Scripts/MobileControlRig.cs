using System;


using UnityEngine;


namespace UnityStandardAssets.CrossPlatformInput
{
    [ExecuteInEditMode]
    public class MobileControlRig : MonoBehaviour
    {
        // this script enables or disables the child objects of a control rig
        // depending on whether the USE_MOBILE_INPUT define is declared.

        // This define is set or unset by a menu item that is included with
        // the Cross Platform Input package.



	void OnEnable()
	{
		CheckEnableControlRig();
	}

        public int callbackOrder
        {
            get
            {
                return 1;
            }
        }


        private void Start()
        {

            if (Application.isPlaying) //if in the editor, need to check if we are playing, as start is also called just after exiting play

            {
                UnityEngine.EventSystems.EventSystem system = GameObject.FindObjectOfType<UnityEngine.EventSystems.EventSystem>();

                if (system == null)
                {//the scene have no event system, spawn one
                    GameObject o = new GameObject("EventSystem");

                    o.AddComponent<UnityEngine.EventSystems.EventSystem>();
                    o.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
                }
            }
        }





        private void Update()
        {
            CheckEnableControlRig();
        }



        private void CheckEnableControlRig()
        {

		EnableControlRig(true);

            EnableControlRig(false);

        }


        private void EnableControlRig(bool enabled)
        {
            foreach (Transform t in transform)
            {
                t.gameObject.SetActive(enabled);
            }
        }


       

    }
}