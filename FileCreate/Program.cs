string path = "Files/257.csv";
using (StreamReader reader = new StreamReader(path))
{
    using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Data.csv"))
    {
        while (reader.Peek() != -1)
        {
            string textLine = reader.ReadLine();
            var coloumnElements = textLine.Split(",");
            if (coloumnElements[0] == "GSM")
            {
                writer.WriteLine(coloumnElements[1] + "," + coloumnElements[2] + "," + coloumnElements[3] + "," + 
                    coloumnElements[4] + "," + coloumnElements[6] + "," + coloumnElements[7]);
            }
        }
    }
}