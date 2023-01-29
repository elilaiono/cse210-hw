public class Journal {

    public Journal()
    {

    }


    public void getEntry()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        Console.WriteLine(" ");
        Console.WriteLine("Journal Entry: ");

            foreach (string line in lines)
        {   
            string[] entry = line.Split(",");

            string displayEntry = entry[0];

            Console.WriteLine(displayEntry);
        }   
           
}


}