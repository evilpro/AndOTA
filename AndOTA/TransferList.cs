using System;
using System.Collections.Generic;
using System.IO;

namespace AndOTA
{
    public class TransferList
    {
        public Int32 Version { get; set; }
        public Int32 BlocksToWrite { get; set; }
        public FileInfo FileContext { get; set; }
        public List<object> Commands { get; set; }

        public static TransferList FromFile(String path)
        {
            if (File.Exists(path))
            {
                try
                {
                    TransferList ListObject = new TransferList();
                    using(FileStream fileStream = File.OpenRead(path))
                    {
                        using(StreamReader fileReader = new StreamReader(fileStream))
                        {
                            ListObject.Version = Int32.Parse(fileReader.ReadLine());
                            ListObject.BlocksToWrite = Int32.Parse(fileReader.ReadLine());

                            if(ListObject.Version >= 2)
                            {
                                fileReader.ReadLine();
                                fileReader.ReadLine();
                            }

                            ListObject.Commands = new List<object>();

                            String line;
                            while((line = fileReader.ReadLine()) != null)
                            {
                                String[] lineParts = line.Split(' ');
                                String action = lineParts[0];
                                switch(action)
                                {
                                    case "erase":
                                        ListObject.Commands.Add(new object[]{ action, Toolbox.GetRangeset(lineParts[1])});
                                        break;
                                    case "new":
                                        ListObject.Commands.Add(new object[] { action, Toolbox.GetRangeset(lineParts[1]) });
                                        break;
                                    case "zero":
                                        ListObject.Commands.Add(new object[] { action, Toolbox.GetRangeset(lineParts[1]) });
                                        break;
                                    default:
                                        return null;
                                }
                            }

                            fileReader.Close();
                        }
                        fileStream.Close();
                    }

                    ListObject.FileContext = new FileInfo(path);

                    return ListObject;
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }
    }
}
