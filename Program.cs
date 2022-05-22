// See https://aka.ms/new-console-template for more information

int totalEggs;
int eggsPerSister;
int eggsForDuckbear;

Console.WriteLine(
    "Four sisters own a chocolate farm and collect chocolate eggs laid by " +
    "chocolate chickens everyday.\nAll four sisters get an equal number of " +
    "chocolate eggs every day, \nand the remainder is fed to their pet duckbear.\n" +
    "How many chocolate eggs were laid by the chocolate chickens? ");

totalEggs = Convert.ToInt16(Console.ReadLine());
eggsPerSister = totalEggs / 4;
eggsForDuckbear = totalEggs % 4;

Console.WriteLine("\nEach sister will receive " + eggsPerSister + " ,and duckbear will receive " + eggsForDuckbear + " eggs.");

Console.ReadKey();
