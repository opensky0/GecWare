using Invector.CharacterController;
using System.Diagnostics.Contracts;
using UnityEngine;

namespace GecWare
{
    public class Cheat : MonoBehaviour
    {
        private PlayerController player;
        //private CameraManager cameraMan;
        //private PlayerHealth playerHealth;
        //private CapsuleCollider playerCol;
        //private WeaponsController weaponsController;
        //private WeaponModel weaponModel;
        //private vThirdPersonController thirdPersonController;

        //watermark
        private float colorChangeSpeed = 1f;
        private float timer = 0f;

        private void OnGUI()
        {
            float r = Mathf.PingPong(timer * colorChangeSpeed, 1f);
            float g = Mathf.PingPong(timer * colorChangeSpeed + 0.33f, 1f);
            float b = Mathf.PingPong(timer * colorChangeSpeed + 0.66f, 1f);

            GUI.color = new Color(r, g, b);

            GUI.Label(new Rect(10, 20, 400, 40), "GecWare :3 | " + SystemInfo.graphicsDeviceName + " | " + (int)(1.0f / Time.smoothDeltaTime));
            timer += Time.deltaTime;
        }

        public void Update()
        {
            //if(player == null)
            //{
            //    if(PlayerController.IAEJEMLCGGC != null)
            //    {
            //        player = PlayerController.IAEJEMLCGGC;
            //        //playerHealth = player.DNBIIJJDBLN;
            //        //playerCol = player.DHJJDBEDFOK;
            //        //weaponsController = player.DNLMMIKCGGE;
            //        //weaponModel = player.DNLMMIKCGGE.EPKJMHJNGIB;
            //        //thirdPersonController = player.EHCIACFKDOK;
            //
            //        //cameraMan = CameraManager.NKEFBCLBLKI;
            //    }
            //}
            //else
            //{
                BuildingNetworkController.Instance.KillAllBuildings(false); // Destroy builds
                CameraManager.GDJIEOJCGNC.MainCamera.fieldOfView = 120; // Set Fov
                PlayerController.IAEJEMLCGGC.OLIMGMBHJAP.SetPlayerImmunity(true); // ez
                PlayerController.IAEJEMLCGGC.MNFJLBOKBOG.JICDADILBPO.SetCurrentMagazineAmount(1337); // Inf. ammo

                if (Input.GetKeyDown(KeyCode.Tab)) // tp out of spawn in showdown
                {
                    PlayerController.IAEJEMLCGGC.PFJMPGFDCBL.transform.position = new Vector3(PlayerController.IAEJEMLCGGC.PFJMPGFDCBL.transform.position.x, PlayerController.IAEJEMLCGGC.PFJMPGFDCBL.transform.position.y - 50f, PlayerController.IAEJEMLCGGC.PFJMPGFDCBL.transform.position.z);
                }
                else if (Input.GetKeyDown(KeyCode.Y)) // give mats and add levels to weapons
                {
                    PlayerController.IAEJEMLCGGC.MNFJLBOKBOG.AddLevelsToAllWeapons(999999999);
                    PlayerController.IAEJEMLCGGC.PlayerBuildingManager.AddBuildingAmmo(999999999);
                }
                else if (Input.GetKeyDown(KeyCode.G)) // add speed
                {
                    PlayerController.IAEJEMLCGGC.NELAOBLMMDB.ApplySpeedMultiplier(40f);
                }
                else if (Input.GetKeyDown(KeyCode.H)) // remove speed
                {
                    PlayerController.IAEJEMLCGGC.NELAOBLMMDB.RemoveSpeedMultiplier(40f);
                }
            //}
        }
    }
}