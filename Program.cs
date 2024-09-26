int bestkiddiesboutiqueprices =0;

start:
Console.WriteLine("welcome to best kiddies boutique");
Console.WriteLine("POLO,Shirt,Tops,Gowns");
int choice =int.Parse(Console.ReadLine());

switch (choice)
{
  case 1:
   bestkiddiesboutiqueprices += 100000;
        Console.WriteLine("polo selected");
        break;

    case2:
        bestkiddiesboutiqueprices += 7000;
    Console.WriteLine("shirt selected");
        break;

        case 3:
        bestkiddiesboutiqueprices += 8000;
        Console.WriteLine("tops sellected");
        break;

        case 4:
        bestkiddiesboutiqueprices += 6000;
        Console.WriteLine("gowns selected");
        break;

        default:
        Console.WriteLine("please input polo,shirt,tops,gowns");
        goto start;
        Console.WriteLine($"bestkiddiesboutiqueprices)");
        Console.WriteLine("thanks for patronizing us");




}
