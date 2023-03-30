namespace testfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../results.csv";
            List<Match> matches = new List<Match>();

            using (StreamReader sr = File.OpenText(path))
            {
                string input = sr.ReadLine(); 
                Console.WriteLine("First Line is:" + input);

                while ((input= sr.ReadLine())!=null) 
                {

                    string[] fields = input.Split(',');
                    int goals1, goals2,nYellows;

                    if ((fields.Length >=5) 
                        && int.TryParse(fields[2], out goals1) 
                        && int.TryParse(fields[3], out goals2)
                        && int.TryParse(fields[4], out nYellows)) 
                    {
                        List<string> names =new List<string>();

                        for(int i=5;i<fields.Length;i++)
                            names.Add(fields[i]);

                        Match m = new Match(fields[0], fields[1], goals1, goals2,nYellows,names);
                        Console.WriteLine("Just created:" + m.ToString());
                        matches.Add(m);
                    
                    }                                       
              
                }
                for (int i = 0; i < matches.Count; i++)
                {
                    Console.WriteLine(matches[i].ToString());
                }


            }
        }
    }
}