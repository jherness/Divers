using System;

namespace Ex_Divers_OPP_17_12_21
{
    class Equipment : ICloneable
    {
        //type - 0) KNIFE 1) COMPASS 2) MILKSHAKE 3) HOOK 4) FLAIR 5) GAS_MASK 6) OXYIGEN_BOTTLE 7) DIVE_SUIT 8) CAMERA
        //int amount - range:1-20
        ////string description  - per gear

        string chosenEquipmentType;
        string descriptionPerGear;
        int amount = 0;
        int equipmentId;

        public Equipment(int amount, string chosenEquipmentType = "", string descriptionPerGear = "No Discription...")
        {
            SetAmount(amount);
            SetDescriptionPerGear(descriptionPerGear);
            this.chosenEquipmentType = chosenEquipmentType;
        }
        public Equipment(int equipmentId, string chosenEquipmentType)
        {
            this.equipmentId = equipmentId;
            this.chosenEquipmentType = chosenEquipmentType;
        }

        public void SetDescriptionPerGear(string descriptionPerGear)
        {
            this.descriptionPerGear = descriptionPerGear;
        }

        public void SetAmount(int amount)
        {
            while (!CheckAmout(amount))
            {
                Console.WriteLine("Wrong choice amount. Please choose amount 1-20");
                amount = int.Parse(Console.ReadLine());
            }
            this.amount = amount;
        }

        private bool CheckAmout(int amount)
        {
            if (!(amount >= 1 && amount <= 20))
            {
                return false;
            }
            return true;
        }

        public string GetDescriptionPerGear()
        {
            return this.descriptionPerGear;
        }

        public string GetEquipmentType()
        {
            return this.chosenEquipmentType;
        }

        public int GetAmount()
        {
            return this.amount;
        }

        public int GetEquipmentId()
        {
            return this.equipmentId;
        }

        public override string ToString()
        {
            return $"Type: {this.chosenEquipmentType} Amount: {this.amount} Discription: {this.descriptionPerGear}";
        }

        public object Clone()
        {
            return new Equipment(this.equipmentId, this.chosenEquipmentType);
        }
    }
}
