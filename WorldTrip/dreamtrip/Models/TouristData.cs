using mytrip;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace touristdata;

// List<Tourist> travllerlist = new List<Tourist>();


  
// travllerlist.Add(new Tourist("Ajinkya","Rokade","ajinky@gmail.com","pass@123"));
// travllerlist.Add(new Tourist("Pratik","Pathk","pratik@gmail.com","pass@123"));
// travllerlist.Add(new Tourist("Pritam","Chavan","pritam@gmail.com","pass@123"));
// travllerlist.Add(new Tourist("Pravin","Desai","pravin@gmail.com","pass@123"));

public class TouristData{

public static List <Tourist> populatetourist()
{
    string filepath = @"E:\Tushar Bhendarkar\Shinchan\Dotnet\Day8\TouristInfo.json";

    var data = File.ReadAllText(filepath);
    List<Tourist> persons = JsonSerializer.Deserialize<List<Tourist>>(data);

    return persons;
}

public static void SerializationTourist(List<Tourist> data)
{
    var jsonfile = JsonSerializer.Serialize<List<Tourist>>(data); 
    var path = @"E:\Tushar Bhendarkar\Shinchan\Dotnet\Day8\TouristInfo.json";
    File.WriteAllText(path,jsonfile);

}

}