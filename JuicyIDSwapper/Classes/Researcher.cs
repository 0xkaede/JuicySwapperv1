using System.Collections.Generic;
using System.IO;

namespace JuicyIDSwapper.IO
{
    class Researcher
    {
        public static List<long> FindPosition(Stream stream, int searchPosition, long startIndex, byte[] searchPattern)
        {

            List<long> searchResults = new List<long>();
            stream.Position = startIndex;

            while (true)
            {
                if (stream.Position == 500000000)
                {
                    return searchResults;
                }

                var latestbyte = stream.ReadByte();
                if (latestbyte == -1)
                {
                    break;
                }

                if (latestbyte == searchPattern[searchPosition])
                {
                    searchPosition++;
                    if (searchPosition == searchPattern.Length)
                    {
                        searchResults.Add(stream.Position - searchPattern.Length);
                        return searchResults;
                    }
                }
                else
                {
                    searchPosition = 0;
                }
            }

            return searchResults;
        }
    }
}
