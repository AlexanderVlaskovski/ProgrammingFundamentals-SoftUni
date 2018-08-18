using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AnonymousCache
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dataSets = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, List<string>> dataSet = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine())!= "thetinggoesskrra")
            {
                string[] currentInput = input.Split(new char[] { ' ', ',', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if(currentInput.Length == 1)
                {
                    string dataSetName = currentInput[0];
                    Dictionary<string, int> currentDictionary = new Dictionary<string, int>();

                    if (dataSets.ContainsKey(dataSetName) == false)
                    {
                        if(dataSet.ContainsKey(dataSetName))
                        {
                            foreach (var data in dataSet[dataSetName])
                            {
                                string[] tokens = data.Split();
                                string dataKey = tokens[0];
                                int size = int.Parse(tokens[1]);
                                currentDictionary.Add(dataKey, size);
                            }
                            dataSets.Add(dataSetName, currentDictionary);

                        }
                        else
                        {
                            dataSets.Add(dataSetName, currentDictionary);
                        }
                    }
                }
                else
                {
                    string dataSetName = currentInput[2];
                    string dataKey = currentInput[0];
                    int dataSize = int.Parse(currentInput[1]);

                    if (dataSets.ContainsKey(dataSetName) == false)
                    {
                        List<string> currentList = new List<string>();
                        dataKey = dataKey + ' ' + dataSize;
                        if (dataSet.ContainsKey(dataSetName) == false)
                        {
                            currentList.Add(dataKey);

                            dataSet.Add(dataSetName, currentList);

                        }
                        else
                        {
                            dataSet[dataSetName].Add(dataKey);
                        }
                    }
                    else
                    {
                        dataSets[dataSetName].Add(dataKey, dataSize);
                    }


                }
            }
            foreach (var data in dataSets.OrderByDescending(x => x.Value.Values.Sum()))
            {
                long sum = data.Value.Values.Sum();
                Console.WriteLine($"Data Set: {data.Key}, Total Size: {sum}");
                foreach (var name in data.Value.Keys)
                {
                    Console.WriteLine($"$.{name}");
                }
                break;
            }
        }
    }
}
