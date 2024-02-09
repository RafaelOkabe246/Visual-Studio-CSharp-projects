using DesignPatternsStudy.Adapter;
using DesignPatternsStudy.Builder;
using DesignPatternsStudy.Facade;
using DesignPatternsStudy.Factory_Pattern_Classes;
using DesignPatternsStudy.Strategy;
using System.Linq;

Console.WriteLine("Hello, World!");

string continueText = "Press any key to continue";

void Continue()
{
    Console.WriteLine(continueText);
    Console.ReadLine();
}

void Message(string message)
{
    Console.WriteLine(message);
}

void Space(int lines)
{
    for (int i = 0; i < lines; i++)
    {
        Console.WriteLine();
    }
}

#region Creational Patterns

#region Factory_pattern 
/*
Continue();

Console.WriteLine("Factory Pattern: Create robots");

TankRobotFactory tankRobotProducer = new TankRobotFactory("01", "Tank factory");
SniperRobotFactory sniperRobotProducer = new SniperRobotFactory("05","Sniper factory");
FlashRobotFactory flashRobotProducer = new FlashRobotFactory("F09", "Flash factory");


Console.WriteLine("Creating robots");


Robot tankRobot = tankRobotProducer.CreateRobot();
Robot sniperRobot = sniperRobotProducer.CreateRobot();
Robot flashRobot = flashRobotProducer.CreateRobot();

Console.WriteLine(tankRobot.GetProducerRegister());
Console.WriteLine(sniperRobot.GetProducerRegister());
Console.WriteLine(flashRobot.GetProducerRegister());


Continue();
*/
#endregion

#region Builder_pattern
/*
Console.WriteLine("Builder Pattern: Building galatic houses");

Director director = new Director();
HouseBuilder houseBuilder = new HouseBuilder();

Console.WriteLine("Select a shape: Round or cube");

string shapeHouseReponse = Console.ReadLine().ToLower();
string[] houseResponses = { "cube", "round" };
while (shapeHouseReponse == null || !houseResponses.Contains(shapeHouseReponse))
{
    Console.WriteLine("Write one of the two options correctly");
    shapeHouseReponse = Console.ReadLine().ToLower();
}
switch(shapeHouseReponse)
{
    case ("round"):
        houseBuilder.SetHouseShapeType(HouseShapeType.Round);
        break;
    case ("cube"):
        houseBuilder.SetHouseShapeType(HouseShapeType.Cube);
        break;
}


Console.WriteLine("Select an enviromment: Extreme, balanced or vacuum");

string envirommentReponse = Console.ReadLine().ToLower();
string[] envirommentResponses = { "extreme","balanced", "vacuum" };
while (envirommentReponse == null || !envirommentResponses.Contains(envirommentReponse))
{
    Console.WriteLine("Write one of the 3 options correctly");

    envirommentReponse = Console.ReadLine().ToLower();
}
switch (envirommentReponse)
{
    case ("vacuum"):
        houseBuilder.SetEnvirommentType(EnvirommentType.Vacuum);
        break;
    case ("balanced"):
        houseBuilder.SetEnvirommentType(EnvirommentType.Balanced);
        break;
    case ("extreme"):
        houseBuilder.SetEnvirommentType(EnvirommentType.Extreme);
        break;
}

House newEarthHouse = houseBuilder.BuildHouse();

Console.WriteLine($"Your new house is ready! It is for {newEarthHouse.envirommentType} enviromment and the shape is {newEarthHouse.houseShapeType}");

Continue();
*/
#endregion
#endregion

#region Structural Patterns

#region Adapter Pattern  
Message("Tranlate alien signals");
Alien alien = new Alien(); 
EarthSpeaker speaker = new EarthSpeaker();

ILanguage alienTranslating = new Adapter(alien);
alienTranslating.SendMessage();
Space(1);
speaker.SendMessage();
Space(1);

Continue();
#endregion

#region Facade Pattern - Game difficult
Message("Set Game difficult");
DifficultManager difficultManager = new DifficultManager();

difficultManager.SetHardDifficult();
difficultManager.ShowNewDifficultChanges();

Continue();
#endregion

#region Decorator Pattern
Message("Defense communication system");


#endregion
#endregion


#region Behaviour Patterns
#region Strategy Pattern - Fantasy hospital
Message("The hospital can cure patients using magic, alchemy or ancient science.");
string treatmentChoice = Console.ReadLine().ToLower();
string[] treatmentOptions = { "magic" , "alchemy" , "science" };
while (treatmentChoice == null || !treatmentOptions.Contains(treatmentChoice))
{
    Console.WriteLine("Write one of the 3 options correctly");

    treatmentChoice = Console.ReadLine().ToLower();
}
Patient patient = new Patient();

switch (treatmentChoice)
{
    case ("magic"):
        MagicTreatment magicTreatment = new MagicTreatment();
        magicTreatment.CurePatient(patient);
        break;
    case ("alchemy"):
        AlchemyTreatment alchemyTreatment = new AlchemyTreatment();
        alchemyTreatment.CurePatient(patient);
        break;
    case ("science"):
        ScienceTreatment scienceTreatment = new ScienceTreatment();
        scienceTreatment.CurePatient(patient);
        break;
}

Message($"The treatment was {treatmentChoice}");
Message($"The side effect war {patient.GetSideEffect()}");

#endregion
#endregion