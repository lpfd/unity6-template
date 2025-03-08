using UnityEngine;
using Leap.Forward.SaveFiles;
using VContainer;

namespace Game.Model
{
    [CreateAssetMenu(fileName = "SaveFileSlots", menuName = "Scriptable Objects/SaveFileSlots")]
    public class SaveFileSlots : ScriptableObject
    {
        public bool _hasSave0;
        public bool _hasSave1;
        public bool _hasSave2;

        public ISaveManager SaveManager { get; private set; }

        [Inject]
        public void Construct(ISaveManager saveManager)
        {
            SaveManager = saveManager;

            _hasSave0 = SaveManager.HasSaveAtSlot(0);
            _hasSave1 = SaveManager.HasSaveAtSlot(1);
            _hasSave2 = SaveManager.HasSaveAtSlot(2);
        }

        public void LoadGame(int slotIndex)
        {
            if (SaveManager.HasSaveAtSlot(slotIndex))
            {
                SaveManager.LoadGame(slotIndex);
            }
        }

        public void SaveGame(int slotIndex)
        {
            SaveManager.SaveGame(slotIndex);
            switch (slotIndex)
            {
                case 0:
                    _hasSave0 = true;
                    break;
                case 1:
                    _hasSave1 = true;
                    break;
                case 2:
                    _hasSave2 = true;
                    break;
            }
        }
    }
}
