// See https://aka.ms/new-console-template for more information
using modul8_1302223027;

BankTransferConfig config = new BankTransferConfig();
config.readConfig();
if (config.lang == "id")
{
    Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
}
else if (config.lang == "en") {
    Console.Write("Please insert the amount of money to transfer: ");
}

int amoutOfMoney = int.Parse(Console.ReadLine());

int totalTransfer;
int transferFee;
if (amoutOfMoney <= config.transfer.threshold) {
    transferFee = config.transfer.low_fee;
    totalTransfer = amoutOfMoney+config.transfer.low_fee;
   
} else
{
    transferFee = config.transfer.high_fee;
    totalTransfer = amoutOfMoney + config.transfer.high_fee;
}
if (config.lang == "en") {
    Console.WriteLine($"Transfer fee = {transferFee} and Total amount = {totalTransfer}");
} else if (config.lang =="id"){
    Console.WriteLine($"Biaya transfer = {transferFee} dan Total biaya = {totalTransfer}");
}

if (config.lang == "id")
{
    Console.WriteLine("Select transfer method");
} else
{
    Console.WriteLine("Pilih metode transfer:");
}

for (int i = 0; i < config.methods.Length; i++)
{
    Console.WriteLine($"{i + 1} {config.methods[i]}");
}

int methodIndex = int.Parse(Console.ReadLine());
string method = config.methods[methodIndex - 1];


string confirmation;
if (config.lang == "en")
{
    Console.Write($"Please type {config.confirmation.en} to confirm the transaction:");
    confirmation = Console.ReadLine();
    if( confirmation == config.confirmation.en) {
        Console.WriteLine("The transfer is completed");
    } else
    {
        Console.WriteLine("Transfer is cancelled");
    }

} else if (config.lang == "id") {
    Console.Write($"ketik {config.confirmation.id} untuk mengkonfirmasi transaksi: ");
    confirmation = Console.ReadLine();
    if (confirmation == config.confirmation.id)
    {
        Console.WriteLine("Proses transfer berhasil");
    }
    else
    {
        Console.WriteLine("Transfer dibatalkan");
    }
}


