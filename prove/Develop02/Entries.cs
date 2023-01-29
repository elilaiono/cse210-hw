using System.IO;

public class Entries
{

    // List<string> responses = new List<string>(); 
    List<string> prompts = new List<string>();
    List<string> entriesList = new List<string>();
    int index;

    public Entries()
    {  
    prompts.Add("What was the best part of your day?");
    prompts.Add("What is one thing you didn't accomplish today that you wish you did. Why do you think this happened?");
    prompts.Add("What goals were you able to accomplish today?");
    prompts.Add("What is one way you made a difference in someone's life today?");
    }

    public void startProgram()
    {
        getRandomPrompt();
        writeToFile();
    }

    public void getRandomPrompt()
    {
        Random randomPromp = new Random();
        int index = randomPromp.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
        string userInput = Console.ReadLine();
        // responses.Add(userInput);
        entriesList.Add(userInput);
    }

        public void writeToFile()
        {

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string fileName = "myFile.txt";
        entriesList.Add(prompts[index]);
        entriesList.Add(dateText);

        using (StreamWriter outPutFile  = new StreamWriter(fileName))
        {
            
            // outPutFile.WriteLine(responses[0]);
            // outPutFile.WriteLine(prompts[index]);
            // outPutFile.WriteLine(dateText);
            foreach (string entry in entriesList)
            {
                outPutFile.WriteLine(entry);
            }

        }

    }

        public void hailMary()
        {
            List<string> saveEntries = entriesList;
            foreach (string saveEntry in saveEntries)
            {
                Console.WriteLine(saveEntry);
            } 
        }


}