using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul8_1302223027
{
    internal class BankTransferConfig
    {
        public string lang;
        public Transfer transfer;
        public string[] methods;
        public Confirmation confirmation;

        public BankTransferConfig() {
           
        }
        public void readConfig() {


            if (File.Exists("D:\\praktikum kpl\\modul8_1302223027\\bank_transfer_config.json"))
            {
                string jsonContent = File.ReadAllText("D:\\praktikum kpl\\modul8_1302223027\\bank_transfer_config.json");
                BankTransferConfig config = JsonConvert.DeserializeObject<BankTransferConfig>(jsonContent);
                this.lang = config.lang;
                this.transfer = config.transfer;
                this.methods = config.methods;
                this.confirmation = config.confirmation;
            } else
            {
                this.transfer = new Transfer();
                this.methods = new string[6];
                this.confirmation = new Confirmation();
                this.lang = "en";
                this.transfer.threshold = 25000000;
                this.transfer.low_fee = 65000;
                this.transfer.high_fee = 15000;
                this.methods = ["RTO", "(real-time)", "SKN", "RTGS", "BI", "FAST"];
                this.confirmation.id = "ya";
                this.confirmation.en = "yes";
            }
            
        }

    }


    public class Transfer
    {
        public int threshold;
        public int low_fee;
        public int high_fee;
    }

    public class Confirmation
    {
        public string en;
        public string id;
    }
}
